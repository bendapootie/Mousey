﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace JoytsicTest
{
    enum ButtonState
    {
        Idle,
        Pressed,
        Released,
        Held
    };

    enum GamepadAxis
    {
        LeftStickX,
        LeftStickY,
        RightStickX,
        RightStickY,
        LeftTrigger,
        RightTrigger
    };

    enum GamepadButton
    {
        A,
        B,
        X,
        Y,
        DPAD_UP,
        DPAD_DOWN,
        DPAD_LEFT,
        DPAD_RIGHT,
        LEFT_SHOULDER,
        RIGHT_SHOULDER,
        LEFT_THUMB,
        RIGHT_THUMB,
        START,
        BACK
    };

    struct GamepadState
    {
        // Disable warning about parameters never being assigned to.
        // These get marshaled over from the native dll
#pragma warning disable 0649
        public float LeftStickX;
        public float LeftStickY;
        public float RightStickX;
        public float RightStickY;
        public float LeftTrigger;
        public float RightTrigger;
        public UInt32 ButtonStateFlags;
#pragma warning restore 0649

        public float GetAxisValue(GamepadAxis axis)
        {
            switch ((int)axis)
            {
                case 0: return LeftStickX;
                case 1: return LeftStickY;
                case 2: return RightStickX;
                case 3: return RightStickY;
                case 4: return LeftTrigger;
                case 5: return RightTrigger;
            }
            return 0.0f;
        }

        public bool IsDown(GamepadButton button)
        {
            return (ButtonStateFlags & (1 << (int)button)) != 0;
        }
    };

    struct GamepadHistory
    {
        public GamepadState PreviousState;
        public GamepadState CurrentState;

        public bool IsDown(GamepadButton button)
        {
            return CurrentState.IsDown(button);
        }

        public bool WasPressed(GamepadButton button)
        {
            return CurrentState.IsDown(button) && !PreviousState.IsDown(button);
        }

        public bool WasReleased(GamepadButton button)
        {
            return !CurrentState.IsDown(button) && PreviousState.IsDown(button);
        }

        public bool WasHeld(GamepadButton button)
        {
            return CurrentState.IsDown(button) && PreviousState.IsDown(button);
        }

        public bool WasAxisPulled(GamepadAxis axis, float threshold)
        {
            float current = CurrentState.GetAxisValue(axis);
            float previous = PreviousState.GetAxisValue(axis);
            if (threshold >= 0.0f)
            {
                return (current >= threshold) && (previous < threshold);
            }
            else
            {
                return (current <= threshold) && (previous > threshold);
            }
        }

        public bool WasAxisReleased(GamepadAxis axis, float threshold)
        {
            float current = CurrentState.GetAxisValue(axis);
            float previous = PreviousState.GetAxisValue(axis);
            if (threshold >= 0.0f)
            {
                return (current < threshold) && (previous >= threshold);
            }
            else
            {
                return (current > threshold) && (previous <= threshold);
            }
        }
    }

    public partial class Form1 : Form
    {
        [DllImport("MouseHookDLL.dll")] static extern void HK_StartHook();
        [DllImport("MouseHookDLL.dll")] static extern void HK_EndHook();

        [DllImport("MouseHookDLL.dll")] static extern Boolean HK_IsIdle();
        [DllImport("MouseHookDLL.dll")] static extern Boolean HK_IsCancled();
        [DllImport("MouseHookDLL.dll")] static extern Boolean HK_IsRecording();
        [DllImport("MouseHookDLL.dll")] static extern Boolean HK_IsPlayback();
        [DllImport("MouseHookDLL.dll")] static extern Boolean HK_IsAutoClicking();
        [DllImport("MouseHookDLL.dll")] static extern Boolean HK_IsRecordingSaved();

        [DllImport("MouseHookDLL.dll")] static extern void HK_SetRecordingKey(UInt32 vkCode);
        [DllImport("MouseHookDLL.dll")] static extern void HK_SetPlaybackKey(UInt32 vkCode);
        [DllImport("MouseHookDLL.dll")] static extern void HK_SetCancelPlaybackKey(UInt32 vkCode);
        [DllImport("MouseHookDLL.dll")] static extern void HK_SetAutoClickKey(UInt32 vkCode);

        [DllImport("MouseHookDLL.dll")] static extern void HK_StartRecording();
        [DllImport("MouseHookDLL.dll")] static extern void HK_StopRecording();

        [DllImport("MouseHookDLL.dll")] static extern IntPtr HK_GetRecordingString();
        [DllImport("MouseHookDLL.dll")] static extern UInt32 HK_SetRecordingString(IntPtr stringToSet);

        [DllImport("MouseHookDLL.dll")] static extern UInt32 HK_SendSingleCommand(IntPtr stringCommand);

        [DllImport("MouseHookDLL.dll")] static extern void HK_StartPlayback();
        [DllImport("MouseHookDLL.dll")] static extern void HK_CancelPlayback();

        [DllImport("MouseHookDLL.dll")] static extern void HK_StartAutoClicking();
        [DllImport("MouseHookDLL.dll")] static extern void HK_StopAutoClicking();

        [DllImport("MouseHookDLL.dll")] static extern void HK_Update();

        [DllImport("MouseHookDLL.dll")] static extern UInt32 PAD_NewGamepad(UInt32 GamepadId);
        [DllImport("MouseHookDLL.dll")] static extern void PAD_Update(UInt32 GamepadId);
        [DllImport("MouseHookDLL.dll")] static extern void PAD_Refresh(UInt32 GamepadId);
        [DllImport("MouseHookDLL.dll")] static extern GamepadState PAD_GetGamepadState(UInt32 GamepadId);

        const uint INPUT_MOUSE = 0;
        const uint INPUT_KEYBOARD = 1;
        const uint INPUT_HARDWARE = 2;

        const uint VK_ESCAPE = 0x1B;

        const uint VK_F1 = 0x70;
        const uint VK_F2 = 0x71;
        const uint VK_F3 = 0x72;
        const uint VK_F4 = 0x73;
        const uint VK_F5 = 0x74;
        const uint VK_F6 = 0x75;
        const uint VK_F7 = 0x76;
        const uint VK_F8 = 0x77;
        const uint VK_F9 = 0x78;
        const uint VK_F10 = 0x79;
        const uint VK_F11 = 0x7A;
        const uint VK_F12 = 0x7B;

        const uint VK_NUMLOCK = 0x90;
        const uint VK_SCROLL = 0x91;

        const string KeyDownCommandFormatString = "1 0 0x00 {0}";
        const string KeyUpCommandFormatString = "1 0 0x02 {0}";
        const string MouseCursorMoveFormatString = "0 0 0x8001 0x00 {0} {1}";
        const string LeftMouseDownCommand = "0 0 0x02 0x00 0 0";
        const string LeftMouseUpCommand = "0 0 0x04 0x00 0 0";
        const string RightMouseDownCommand = "0 0 0x08 0x00 0 0";
        const string RightMouseUpCommand = "0 0 0x010 0x00 0 0";
        const string MouseWheelScrollDown = "0 0 0x800 0xFFFFFF88 0 0";
        const string MouseWheelScrollUp = "0 0 0x800 0x78 0 0";
        const string WKeyDownCommand = "1 0 0x00 0x57";
        const string WKeyUpCommand = "1 0 0x02 0x57";
        const string AKeyDownCommand = "1 0 0x00 0x41";
        const string AKeyUpCommand = "1 0 0x02 0x41";
        const string SKeyDownCommand = "1 0 0x00 0x53";
        const string SKeyUpCommand = "1 0 0x02 0x53";
        const string DKeyDownCommand = "1 0 0x00 0x44";
        const string DKeyUpCommand = "1 0 0x02 0x44";
        const string RKeyDownCommand = "1 0 0x00 0x52";
        const string RKeyUpCommand = "1 0 0x02 0x52";
        const string FKeyDownCommand = "1 0 0x00 0x46";
        const string FKeyUpCommand = "1 0 0x02 0x46";
        const int KeyValue_R = 0x52;
        const int KeyValue_F = 0x46;
        const int KeyValue_W = 0x57;
        const int KeyValue_A = 0x41;
        const int KeyValue_S = 0x53;
        const int KeyValue_D = 0x44;
        const int KeyValue_X = 0x58;
        const int KeyValue_M = 0x4D;
        const int KeyValue_1 = 0x31;
        const int KeyValue_2 = 0x32;
        const int KeyValue_3 = 0x33;
        const int KeyValue_4 = 0x34;
        const int KeyValue_5 = 0x35;
        const int KeyValue_6 = 0x36;
        const int KeyValue_7 = 0x37;
        const int KeyValue_8 = 0x38;
        const int KeyValue_9 = 0x39;
        const int KeyValue_0 = 0x30;

        const float LeftThumbInnerDeadZoneDefaultValue = 0.2395f;  // Official MS suggested value = 7849.0f / 32768.0f = 0.2395;
        const float LeftThumbOuterDeadZoneDefaultValue = 0.85f;
        const float RightThumbInnerDeadZoneDefaultValue = 0.1500f;  // Official MS suggested value = 8689.0f / 32768.0f = 0.2652;
        const float RightThumbOuterDeadZoneDefaultValue = 0.85f;
        const float TriggerDeadZoneDefaultValue = 0.0009f;  // Official MS suggested value = 30.0f / 32768.0f = 0.0009;

        const bool FeatherMovementDefaultValue = true;
        const bool RadialMouseDefaultValue = true;
        const bool SubPixelMouseDefaultValue = true;
        const float StickTranslationExponentDefaultValue = 3.0f;
        const float MouseSensitivityDefaultValue = 25.0f;

        Timer UpdateTimer = null;
        int FrameNumber = 0;
        UInt32 GamepadId = 0;
        GamepadHistory GamepadHistory = new GamepadHistory();
        Dictionary<GamepadButton, int> SimpleButtonToKeyMap = new Dictionary<GamepadButton, int>();
        PointF RelativeMouseMovementRemainder = new PointF(0.0f, 0.0f);

        public Form1()
        {
            InitializeComponent();

            // Dead Zone initialization
            LeftThumbInnerDeadZoneInput.Value = (decimal)LeftThumbInnerDeadZoneDefaultValue;
            LeftThumbOuterDeadZoneInput.Value = (decimal)LeftThumbOuterDeadZoneDefaultValue;
            RightThumbInnerDeadZoneInput.Value = (decimal)RightThumbInnerDeadZoneDefaultValue;
            RightThumbOuterDeadZoneInput.Value = (decimal)RightThumbOuterDeadZoneDefaultValue;
            TriggerDeadZoneInput.Value = (decimal)TriggerDeadZoneDefaultValue;

            // Mouse interpretation
            FeatherMovementInput.Checked = FeatherMovementDefaultValue;
            RadialMouseInput.Checked = RadialMouseDefaultValue;
            SubPixelMouseInput.Checked = SubPixelMouseDefaultValue;
            StickTranslationExponentInput.Value = (decimal)StickTranslationExponentDefaultValue;
            MouseSensitivityInput.Value = (decimal)MouseSensitivityDefaultValue;
        }

        private void InitInputHooks()
        {
            HK_StartHook();
            HK_SetRecordingKey(VK_F12);
            HK_SetPlaybackKey(VK_F9);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GamepadId = PAD_NewGamepad(1);

            SimpleButtonToKeyMap.Add(GamepadButton.Y, KeyValue_R);             // 'R' - Reload
            SimpleButtonToKeyMap.Add(GamepadButton.X, KeyValue_F);             // 'F' - Interact
            SimpleButtonToKeyMap.Add(GamepadButton.DPAD_UP, KeyValue_7);       // '7' - Bandage
            SimpleButtonToKeyMap.Add(GamepadButton.DPAD_DOWN, KeyValue_8);     // '8' - Med Kit
            SimpleButtonToKeyMap.Add(GamepadButton.DPAD_LEFT, KeyValue_9);     // '9' - Soda
            SimpleButtonToKeyMap.Add(GamepadButton.DPAD_RIGHT, KeyValue_0);    // '0' - Pills
            SimpleButtonToKeyMap.Add(GamepadButton.B, KeyValue_X);             // 'X' - Cancel Action
            SimpleButtonToKeyMap.Add(GamepadButton.START, KeyValue_M);         // 'M' - Map

            InitInputHooks();

            // Start 60hz update timer
            UpdateTimer = new Timer();
            UpdateTimer.Interval = (1000 / 60) - 1; // ~60hz
            UpdateTimer.Tick += TimerUpdate;
            UpdateTimer.Enabled = true;
            UpdateTimer.Start();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            HK_EndHook();
        }

        private float LeftStickInnerDeadZone
        {
            get { return (float)LeftThumbInnerDeadZoneInput.Value; }
        }

        private float LeftStickOuterDeadZone
        {
            get { return (float)LeftThumbOuterDeadZoneInput.Value; }
        }

        private float RightStickInnerDeadZone
        {
            get { return (float)RightThumbInnerDeadZoneInput.Value; }
        }

        private float RightStickOuterDeadZone
        {
            get { return (float)RightThumbOuterDeadZoneInput.Value; }
        }

        private float TriggerDeadZone
        {
            get { return (float)TriggerDeadZoneInput.Value; }
        }

        private bool IsFeatherMovement
        {
            get { return FeatherMovementInput.Checked; }
        }

        private bool IsRadialMouse
        {
            get { return RadialMouseInput.Checked; }
        }
        private bool IsSubPixelMouse
        {
            get { return SubPixelMouseInput.Checked; }
        }
        private float StickTranslationExponent
        {
            get { return (float)StickTranslationExponentInput.Value; }
        }
        private float MouseSensitivity
        {
            get { return (float)MouseSensitivityInput.Value; }
        }


        private string GetRecordingString()
        {
            IntPtr rawPointer = HK_GetRecordingString();
            string returnString = Marshal.PtrToStringAnsi(rawPointer);
            return returnString;
        }

        private int SetRecordingString(string s)
        {
            IntPtr nativeAnsiString = Marshal.StringToHGlobalAnsi(s);
            UInt32 numInputsProcessed = HK_SetRecordingString(nativeAnsiString);
            Marshal.FreeHGlobal(nativeAnsiString);
            return (int)numInputsProcessed;
        }

        private int SendSingleCommand(string s)
        {
            //textBox1.Text += s + System.Environment.NewLine;
            IntPtr nativeAnsiString = Marshal.StringToHGlobalAnsi(s);
            UInt32 numInputsProcessed = HK_SendSingleCommand(nativeAnsiString);
            Marshal.FreeHGlobal(nativeAnsiString);
            return (int)numInputsProcessed;
        }

        private ButtonState UpdateButtonToKey(GamepadButton button, int keyValue)
        {
            ButtonState returnState = ButtonState.Idle;
            if (GamepadHistory.WasPressed(button))
            {
                string command = string.Format(KeyDownCommandFormatString, keyValue);
                SendSingleCommand(command);
                returnState = ButtonState.Pressed;
            }
            else if (GamepadHistory.WasReleased(button))
            {
                string command = string.Format(KeyUpCommandFormatString, keyValue);
                SendSingleCommand(command);
                returnState = ButtonState.Released;
            }
            else if (GamepadHistory.WasHeld(button))
            {
                returnState = ButtonState.Held;
            }
            return returnState;
        }

        private void UpdateSimpleButtonToKeyMappings()
        {
            foreach (var entry in SimpleButtonToKeyMap)
            {
                GamepadButton button = entry.Key;
                int keyboardValue = entry.Value;
                UpdateButtonToKey(button, keyboardValue);
            }
        }

        private void TimerUpdate(object sender, EventArgs e)
        {
            FrameNumber++;

            HK_Update();
            PAD_Update(GamepadId);
            // Remember the previous gamepad state, and update the current state
            GamepadHistory.PreviousState = GamepadHistory.CurrentState;
            GamepadHistory.CurrentState = PAD_GetGamepadState(GamepadId);
            PAD_Refresh(GamepadId);

            // <Back> button toggles radial vs relative mouse movement
            if (GamepadHistory.WasPressed(GamepadButton.BACK))
            {
                RadialMouseInput.Checked = !RadialMouseInput.Checked;
            }

            UpdateSimpleButtonToKeyMappings();

            // Cycle weapons
            {
                if (GamepadHistory.WasPressed(GamepadButton.RIGHT_SHOULDER))
                {
                    SendSingleCommand(MouseWheelScrollDown);
                }
                if (GamepadHistory.WasPressed(GamepadButton.LEFT_SHOULDER))
                {
                    SendSingleCommand(MouseWheelScrollUp);
                }
            }

            // TODO - Generalize the "WasTriggerPulled/Released" functions to work for any axis
            if (GamepadHistory.WasAxisPulled(GamepadAxis.RightTrigger, TriggerDeadZone))
            {
                SendSingleCommand(LeftMouseDownCommand);
            }
            if (GamepadHistory.WasAxisReleased(GamepadAxis.RightTrigger, TriggerDeadZone))
            {
                SendSingleCommand(LeftMouseUpCommand);
            }

            // Left trigger maps to Right-Click
            if (GamepadHistory.WasAxisPulled(GamepadAxis.LeftTrigger, TriggerDeadZone))
            {
                SendSingleCommand(RightMouseDownCommand);
            }
            if (GamepadHistory.WasAxisReleased(GamepadAxis.LeftTrigger, TriggerDeadZone))
            {
                SendSingleCommand(RightMouseUpCommand);
            }


            if (GamepadHistory.WasAxisPulled(GamepadAxis.LeftStickX, LeftStickInnerDeadZone))
            {
                SendSingleCommand(DKeyDownCommand);
            }
            if (GamepadHistory.WasAxisReleased(GamepadAxis.LeftStickX, LeftStickInnerDeadZone))
            {
                SendSingleCommand(DKeyUpCommand);
            }
            if (GamepadHistory.WasAxisPulled(GamepadAxis.LeftStickY, LeftStickInnerDeadZone))
            {
                SendSingleCommand(WKeyDownCommand);
            }
            if (GamepadHistory.WasAxisReleased(GamepadAxis.LeftStickY, LeftStickInnerDeadZone))
            {
                SendSingleCommand(WKeyUpCommand);
            }

            if (GamepadHistory.WasAxisPulled(GamepadAxis.LeftStickX, -LeftStickInnerDeadZone))
            {
                SendSingleCommand(AKeyDownCommand);
            }
            if (GamepadHistory.WasAxisReleased(GamepadAxis.LeftStickX, -LeftStickInnerDeadZone))
            {
                SendSingleCommand(AKeyUpCommand);
            }
            if (GamepadHistory.WasAxisPulled(GamepadAxis.LeftStickY, -LeftStickInnerDeadZone))
            {
                SendSingleCommand(SKeyDownCommand);
            }
            if (GamepadHistory.WasAxisReleased(GamepadAxis.LeftStickY, -LeftStickInnerDeadZone))
            {
                SendSingleCommand(SKeyUpCommand);
            }

            UpdateMousePosition();
        }

        private PointF ApplyDeadzone(PointF rawDeflection, float innerZone, float outerZone)
        {
            // TODO - Make sure we handle an innerZone of 0.0 without divide by zero error
            PointF output = new PointF(rawDeflection.X, rawDeflection.Y);

            // Get distance from (0,0) to apply center deadzone
            float r = (float)Math.Sqrt(rawDeflection.X * rawDeflection.X + rawDeflection.Y * rawDeflection.Y);

            // Scale 't' between innerZone and outerZone
            float t = (r - innerZone) / (outerZone - innerZone);
            t = Math.Max(0.0f, Math.Min(1.0f, t));

            output.X = t * (rawDeflection.X / r);
            output.Y = t * (rawDeflection.Y / r);

            return output;
        }

        /// <summary>
        /// Struct representing a point.
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct POINT
        {
            public int X;
            public int Y;

            public static implicit operator Point(POINT point)
            {
                return new Point(point.X, point.Y);
            }
        }

        /// <summary>
        /// Retrieves the cursor's position, in screen coordinates.
        /// </summary>
        /// <see>See MSDN documentation for further information.</see>
        [DllImport("user32.dll")]
        public static extern bool GetCursorPos(out POINT lpPoint);

        public static Point GetCursorPosition()
        {
            POINT lpPoint;
            GetCursorPos(out lpPoint);
            //bool success = User32.GetCursorPos(out lpPoint);
            // if (!success)

            return lpPoint;
        }

        private void UpdateMousePosition()
        {
            // Get joystick deflection in range [-1.0 .. 1.0]
            PointF rawDeflection = new PointF(GamepadHistory.CurrentState.RightStickX, GamepadHistory.CurrentState.RightStickY);
            PointF cleanDeflection = ApplyDeadzone(rawDeflection, RightStickInnerDeadZone, RightStickOuterDeadZone);

            // Only send mouse input if there's deflection outside the deadzone
            if (cleanDeflection.X != 0.0f || cleanDeflection.Y != 0)
            {
                Rectangle screenResolution = Screen.PrimaryScreen.Bounds;
                float aspectRatio = (float)screenResolution.Width / (float)screenResolution.Height;

                // Calculate the deflection radially (radius and vector)
                float deflectionRadius = (float)Math.Sqrt(cleanDeflection.X * cleanDeflection.X + cleanDeflection.Y * cleanDeflection.Y);
                float deflectionDirectionX = cleanDeflection.X / deflectionRadius;
                float deflectionDirectionY = -cleanDeflection.Y / deflectionRadius; // Negate because mouse positions are inverted from stick deflection

                if (IsRadialMouse)
                {
                    const float MousePositionMaxRadiusScalar = 0.5f;

                    // Center mouse cursor in screen
                    // TODO - How does this work with multiple monitors?
                    int screenMouseCenter = 32768;  // Half of 65536 is always the center of the screen
                                                    // Scale 'X' position by aspect ratio so mouse position is circular regardless of resolution
                    int mouseX = screenMouseCenter + (int)(32768.0f * MousePositionMaxRadiusScalar * deflectionDirectionX / aspectRatio);
                    int mouseY = screenMouseCenter + (int)(32768.0f * MousePositionMaxRadiusScalar * deflectionDirectionY);
                    // Set mouse position
                    string commandString = string.Format(MouseCursorMoveFormatString, mouseX, mouseY);
                    toolStripStatusLabel1.Text = string.Format("({0}) - {1}", FrameNumber, commandString);

                    SendSingleCommand(commandString);
                }
                else
                {
                    Point oldCursorPosition = GetCursorPosition();
                    Point newCursorPosition = oldCursorPosition;
                    {
                        if (!IsSubPixelMouse)
                        {
                            RelativeMouseMovementRemainder.X = 0;
                            RelativeMouseMovementRemainder.Y = 0;
                        }

                        // Apply the power curve the the input
                        // TODO - Have separate power curves per stick?
                        float translatedDeflectionRadius = (float)Math.Pow(deflectionRadius, StickTranslationExponent);
                        translatedDeflectionRadius = Math.Min(Math.Max(translatedDeflectionRadius, 0.0f), 1.0f);
                        PointF translatedDeflection = PointF.Empty;
                        translatedDeflection.X = deflectionDirectionX * translatedDeflectionRadius;
                        translatedDeflection.Y = deflectionDirectionY * translatedDeflectionRadius;

                        PointF deltaMouse = PointF.Empty;
                        deltaMouse.X += (translatedDeflection.X * MouseSensitivity);
                        deltaMouse.Y += (translatedDeflection.Y * MouseSensitivity);
                        RelativeMouseMovementRemainder.X = deltaMouse.X - (int)deltaMouse.X;
                        RelativeMouseMovementRemainder.Y = deltaMouse.Y - (int)deltaMouse.Y;

                        newCursorPosition.X = oldCursorPosition.X + (int)(deltaMouse.X);
                        newCursorPosition.Y = oldCursorPosition.Y + (int)(deltaMouse.Y);
                    }
                    
                    Point normalizedCursorPosition = Point.Empty;
                    normalizedCursorPosition.X = (newCursorPosition.X * 65536 + screenResolution.Width - 1) / screenResolution.Width;
                    normalizedCursorPosition.Y = (newCursorPosition.Y * 65536 + screenResolution.Height - 1) / screenResolution.Height;

                    string commandString = string.Format(MouseCursorMoveFormatString, normalizedCursorPosition.X, normalizedCursorPosition.Y);
                    toolStripStatusLabel1.Text = string.Format("({0}, {1}) - {2}", oldCursorPosition.X, oldCursorPosition.Y, commandString);
                    SendSingleCommand(commandString);
                }
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Icon made by [freepik](https://www.freepik.com/) from www.flaticon.com");
        }
    }
}
