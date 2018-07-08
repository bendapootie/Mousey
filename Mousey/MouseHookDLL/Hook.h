#pragma once

struct GamepadState
{
	float LeftStickX;
	float LeftStickY;
	float RightStickX;
	float RightStickY;
	float LeftTrigger;
	float RightTrigger;
	DWORD ButtonStateFlags;
};

#ifdef _MouseHookDLL_EXPORT
	#define MouseHookDLL_API __declspec(dllexport)
	#define CallType __stdcall
#else
	#define MouseHookDLL_API __declspec(dllimport)
	#define CallType
#endif

extern "C" {
MouseHookDLL_API void CallType HK_StartHook();
MouseHookDLL_API void CallType HK_EndHook();
 
MouseHookDLL_API BOOL CallType HK_IsIdle();
MouseHookDLL_API BOOL CallType HK_IsCancled();
MouseHookDLL_API BOOL CallType HK_IsRecording();
MouseHookDLL_API BOOL CallType HK_IsPlayback();
MouseHookDLL_API BOOL CallType HK_IsAutoClicking();
MouseHookDLL_API BOOL CallType HK_IsRecordingSaved();

MouseHookDLL_API void CallType HK_SetRecordingKey(DWORD vkCode);
MouseHookDLL_API void CallType HK_SetPlaybackKey(DWORD vkCode);
MouseHookDLL_API void CallType HK_SetCancelPlaybackKey(DWORD vkCode);
MouseHookDLL_API void CallType HK_SetAutoClickKey(DWORD vkCode);

MouseHookDLL_API void CallType HK_StartRecording();
MouseHookDLL_API void CallType HK_StopRecording();

MouseHookDLL_API const char* CallType HK_GetRecordingString();
MouseHookDLL_API DWORD CallType HK_SetRecordingString(const char* string);

// Note: This function ignores the time parameter of the passed in string
MouseHookDLL_API DWORD CallType HK_SendSingleCommand(const char* string);

MouseHookDLL_API void CallType HK_StartPlayback();
MouseHookDLL_API void CallType HK_CancelPlayback();

MouseHookDLL_API void CallType HK_StartAutoClicking();
MouseHookDLL_API void CallType HK_StopAutoClicking();

// Should be Called regularly from the main thread.  This is the function
// that sends input commands to the system.
MouseHookDLL_API void CallType HK_Update();


// Gamepad functions
// Todo - These should probably be in a separate dll
MouseHookDLL_API DWORD CallType PAD_NewGamepad(DWORD GamepadId);
MouseHookDLL_API void CallType PAD_Update(DWORD GamepadId);
MouseHookDLL_API void CallType PAD_Refresh(DWORD GamepadId);
MouseHookDLL_API GamepadState CallType PAD_GetGamepadState(DWORD GamepadId);
}