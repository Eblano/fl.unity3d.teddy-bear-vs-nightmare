#if defined(__arm__)
.text
	.align 3
methods:
	.space 16
	.align 2
Lm_0:
m_Grab_Drag__ctor:
_m_0:

	.byte 13,192,160,225,128,64,45,233,13,112,160,225,0,89,45,233,8,208,77,226,13,176,160,225,0,0,139,229,0,0,155,229
bl p_1

	.byte 0,42,159,237,0,0,0,234,0,0,32,65,194,42,183,238,0,0,155,229,194,11,183,238,5,10,128,237,8,208,139,226
	.byte 0,9,189,232,8,112,157,229,0,160,157,232

Lme_0:
	.align 2
Lm_1:
m_Grab_Drag_Update:
_m_1:

	.byte 13,192,160,225,128,64,45,233,13,112,160,225,0,93,45,233,4,208,77,226,13,176,160,225,0,160,160,225,24,0,218,229
	.byte 0,0,80,227,4,0,0,10,10,0,160,225,0,16,154,229,15,224,160,225,72,240,145,229,3,0,0,234,10,0,160,225
	.byte 0,16,154,229,15,224,160,225,68,240,145,229,4,208,139,226,0,13,189,232,8,112,157,229,0,160,157,232

Lme_1:
	.align 2
Lm_2:
m_Grab_Drag_UpdateToggleDrag:
_m_2:

	.byte 13,192,160,225,128,64,45,233,13,112,160,225,0,93,45,233,4,208,77,226,13,176,160,225,0,160,160,225,0,0,160,227
bl p_2

	.byte 0,0,80,227,4,0,0,10,10,0,160,225,0,16,154,229,15,224,160,225,64,240,145,229,7,0,0,234,16,0,154,229
bl p_3

	.byte 0,0,80,227,3,0,0,10,10,0,160,225,0,16,154,229,15,224,160,225,60,240,145,229,4,208,139,226,0,13,189,232
	.byte 8,112,157,229,0,160,157,232

Lme_2:
	.align 2
Lm_3:
m_Grab_Drag_UpdateHoldDrag:
_m_3:

	.byte 13,192,160,225,128,64,45,233,13,112,160,225,0,93,45,233,4,208,77,226,13,176,160,225,0,160,160,225,0,0,160,227
bl p_4

	.byte 0,0,80,227,13,0,0,10,16,0,154,229
bl p_3

	.byte 0,0,80,227,4,0,0,10,10,0,160,225,0,16,154,229,15,224,160,225,60,240,145,229,6,0,0,234,10,0,160,225
	.byte 0,16,154,229,15,224,160,225,64,240,145,229,1,0,0,234,0,0,160,227,16,0,138,229,4,208,139,226,0,13,189,232
	.byte 8,112,157,229,0,160,157,232

Lme_3:
	.align 2
Lm_4:
m_Grab_Drag_Grab:
_m_4:

	.byte 13,192,160,225,128,64,45,233,13,112,160,225,0,93,45,233,156,208,77,226,13,176,160,225,0,160,160,225,16,0,139,226
	.byte 0,16,160,227,44,32,160,227
bl p_5

	.byte 60,0,139,226,0,16,160,227,24,32,160,227
bl p_5

	.byte 16,0,154,229
bl p_3

	.byte 0,0,80,227,2,0,0,10,0,0,160,227,16,0,138,229,64,0,0,234,16,0,139,226,0,16,160,227,44,32,160,227
bl p_5
bl p_6

	.byte 144,0,139,229,100,0,139,226
bl p_7

	.byte 144,192,155,229,60,0,139,226,140,0,139,229,12,16,160,225,100,32,155,229,104,48,155,229,108,0,155,229,0,0,141,229
	.byte 140,0,155,229,0,224,156,229
bl p_8

	.byte 60,16,139,226,112,0,139,226,24,32,160,227
bl p_9

	.byte 16,192,139,226,112,0,155,229,136,0,139,229,116,16,155,229,120,32,155,229,124,48,155,229,128,0,155,229,0,0,141,229
	.byte 132,0,155,229,4,0,141,229,136,0,155,229,8,192,141,229
bl p_10

	.byte 0,0,80,227,26,0,0,10,16,0,139,226
bl p_11

	.byte 0,16,160,225,0,224,145,229
bl p_12

	.byte 0,16,159,229,0,0,0,234
	.long mono_aot_Assembly_UnityScript_got - . -4
	.byte 1,16,159,231
bl p_13

	.byte 0,0,80,227,14,0,0,10,16,0,139,226
bl p_11

	.byte 0,16,160,225,0,224,145,229
bl p_12

	.byte 0,16,159,229,0,0,0,234
	.long mono_aot_Assembly_UnityScript_got - .
	.byte 1,16,159,231
bl p_13

	.byte 0,0,80,227,2,0,0,10,16,0,139,226
bl p_11

	.byte 16,0,138,229,156,208,139,226,0,13,189,232,8,112,157,229,0,160,157,232

Lme_4:
	.align 2
Lm_5:
m_Grab_Drag_Drag:
_m_5:

	.byte 13,192,160,225,128,64,45,233,13,112,160,225,0,93,45,233,93,223,77,226,13,176,160,225,0,160,160,225,16,0,139,226
	.byte 0,16,160,227,24,32,160,227
bl p_5

	.byte 0,0,160,227,40,0,139,229,0,0,160,227,44,0,139,229,0,0,160,227,48,0,139,229,0,0,160,227,52,0,139,229
	.byte 0,43,159,237,1,0,0,234,0,0,0,0,0,0,0,0,194,11,183,238,14,10,139,237
bl p_6

	.byte 108,1,139,229,176,0,139,226
bl p_7

	.byte 108,193,155,229,16,0,139,226,104,1,139,229,12,16,160,225,176,32,155,229,180,48,155,229,184,0,155,229,0,0,141,229
	.byte 104,1,155,229,0,224,156,229
bl p_8

	.byte 10,0,160,225,0,224,154,229
bl p_14

	.byte 0,32,160,225,188,0,139,226,2,16,160,225,0,224,146,229
bl p_15

	.byte 10,0,160,225,0,224,154,229
bl p_14

	.byte 0,32,160,225,200,0,139,226,2,16,160,225,0,224,146,229
bl p_16

	.byte 5,10,154,237,192,42,183,238,212,0,139,226,200,16,155,229,204,32,155,229,208,48,155,229,194,11,183,238,0,10,141,237
bl p_17

	.byte 224,0,139,226,188,16,155,229,192,32,155,229,196,48,155,229,212,192,155,229,0,192,141,229,216,192,155,229,4,192,141,229
	.byte 220,192,155,229,8,192,141,229
bl p_18

	.byte 10,0,160,225,0,224,154,229
bl p_14

	.byte 0,32,160,225,236,0,139,226,2,16,160,225,0,224,146,229
bl p_16

	.byte 248,0,139,226,236,16,155,229,240,32,155,229,244,48,155,229
bl p_19

	.byte 0,0,160,227,116,0,139,229,0,0,160,227,120,0,139,229,0,0,160,227,124,0,139,229,0,0,160,227,128,0,139,229
	.byte 116,0,139,226,248,16,155,229,252,32,155,229,0,49,155,229,224,192,155,229,0,192,141,229,228,192,155,229,4,192,141,229
	.byte 232,192,155,229,8,192,141,229
bl p_20

	.byte 116,0,155,229,40,0,139,229,120,0,155,229,44,0,139,229,124,0,155,229,48,0,139,229,128,0,155,229,52,0,139,229
	.byte 0,0,160,227,56,0,139,229,40,0,139,226,100,1,139,229,16,16,139,226,65,15,139,226,24,32,160,227
bl p_9

	.byte 100,1,155,229,56,192,139,226,96,1,139,229,4,17,155,229,8,33,155,229,12,49,155,229,16,1,155,229,0,0,141,229
	.byte 20,1,155,229,4,0,141,229,24,1,155,229,8,0,141,229,96,1,155,229,12,192,141,229
bl p_21

	.byte 0,0,80,227,64,0,0,10,16,0,154,229,104,1,139,229,16,0,139,226,0,16,144,229,28,17,139,229,4,16,144,229
	.byte 32,17,139,229,8,0,144,229,36,1,139,229,16,0,139,226,12,0,128,226,0,16,144,229,40,17,139,229,4,16,144,229
	.byte 44,17,139,229,8,0,144,229,48,1,139,229,14,10,155,237,192,42,183,238,77,15,139,226,40,17,155,229,44,33,155,229
	.byte 48,49,155,229,194,11,183,238,0,10,141,237
bl p_17

	.byte 80,15,139,226,28,17,155,229,32,33,155,229,36,49,155,229,52,193,155,229,0,192,141,229,56,193,155,229,4,192,141,229
	.byte 60,193,155,229,8,192,141,229
bl p_18

	.byte 104,193,155,229,12,0,160,225,64,17,155,229,68,33,155,229,72,49,155,229,0,224,156,229
bl p_22

	.byte 16,0,154,229,100,1,139,229,10,0,160,225,0,224,154,229
bl p_14

	.byte 0,32,160,225,83,15,139,226,2,16,160,225,0,224,146,229
bl p_23

	.byte 100,193,155,229,12,0,160,225,96,1,139,229,76,17,155,229,80,33,155,229,84,49,155,229,88,1,155,229,0,0,141,229
	.byte 96,1,155,229,0,224,156,229
bl p_24

	.byte 93,223,139,226,0,13,189,232,8,112,157,229,0,160,157,232

Lme_5:
	.align 2
Lm_6:
m_Grab_Drag_OldDrag:
_m_6:

	.byte 13,192,160,225,128,64,45,233,13,112,160,225,0,89,45,233,144,208,77,226,13,176,160,225,124,0,139,229,16,0,139,226
	.byte 0,16,160,227,24,32,160,227
bl p_5
bl p_6

	.byte 136,0,139,229,64,0,139,226
bl p_7

	.byte 136,192,155,229,16,0,139,226,132,0,139,229,12,16,160,225,64,32,155,229,68,48,155,229,72,0,155,229,0,0,141,229
	.byte 132,0,155,229,0,224,156,229
bl p_8

	.byte 124,0,155,229,16,16,144,229,128,16,139,229,16,16,139,226,0,32,145,229,76,32,139,229,4,32,145,229,80,32,139,229
	.byte 8,16,145,229,84,16,139,229,16,16,139,226,12,16,129,226,0,32,145,229,88,32,139,229,4,32,145,229,92,32,139,229
	.byte 8,16,145,229,96,16,139,229,5,10,144,237,192,42,183,238,100,0,139,226,88,16,155,229,92,32,155,229,96,48,155,229
	.byte 194,11,183,238,0,10,141,237
bl p_17

	.byte 112,0,139,226,76,16,155,229,80,32,155,229,84,48,155,229,100,192,155,229,0,192,141,229,104,192,155,229,4,192,141,229
	.byte 108,192,155,229,8,192,141,229
bl p_18

	.byte 128,192,155,229,12,0,160,225,112,16,155,229,116,32,155,229,120,48,155,229,0,224,156,229
bl p_22

	.byte 144,208,139,226,0,9,189,232,8,112,157,229,0,160,157,232

Lme_6:
	.align 2
Lm_7:
m_Grab_Drag_Main:
_m_7:

	.byte 13,192,160,225,128,64,45,233,13,112,160,225,0,89,45,233,8,208,77,226,13,176,160,225,0,0,139,229,8,208,139,226
	.byte 0,9,189,232,8,112,157,229,0,160,157,232

Lme_7:
	.align 2
Lm_9:
m_wrapper_managed_to_native_System_Array_GetGenericValueImpl_int_object_:
_m_9:

	.byte 13,192,160,225,240,95,45,233,120,208,77,226,13,176,160,225,0,0,139,229,4,16,139,229,8,32,139,229
bl p_25

	.byte 16,16,141,226,4,0,129,229,0,32,144,229,0,32,129,229,0,16,128,229,16,208,129,229,15,32,160,225,20,32,129,229
	.byte 0,0,155,229,0,0,80,227,16,0,0,10,0,0,155,229,4,16,155,229,8,32,155,229
bl p_26

	.byte 0,0,159,229,0,0,0,234
	.long mono_aot_Assembly_UnityScript_got - . + 4
	.byte 0,0,159,231,0,0,144,229,0,0,80,227,10,0,0,26,16,32,139,226,0,192,146,229,4,224,146,229,0,192,142,229
	.byte 104,208,130,226,240,175,157,232,150,0,160,227,6,12,128,226,2,4,128,226
bl p_27
bl p_28
bl p_29

	.byte 242,255,255,234

Lme_9:
.text
	.align 3
methods_end:
.data
	.align 3
method_addresses:
	.align 2
	.long _m_0
	.align 2
	.long _m_1
	.align 2
	.long _m_2
	.align 2
	.long _m_3
	.align 2
	.long _m_4
	.align 2
	.long _m_5
	.align 2
	.long _m_6
	.align 2
	.long _m_7
	.align 2
	.long 0
	.align 2
	.long _m_9
.text
	.align 3
method_offsets:

	.long Lm_0 - methods,Lm_1 - methods,Lm_2 - methods,Lm_3 - methods,Lm_4 - methods,Lm_5 - methods,Lm_6 - methods,Lm_7 - methods
	.long -1,Lm_9 - methods

.text
	.align 3
method_info:
mi:
Lm_0_p:

	.byte 0,0
Lm_1_p:

	.byte 0,0
Lm_2_p:

	.byte 0,0
Lm_3_p:

	.byte 0,0
Lm_4_p:

	.byte 0,2,2,3
Lm_5_p:

	.byte 0,0
Lm_6_p:

	.byte 0,0
Lm_7_p:

	.byte 0,0
Lm_9_p:

	.byte 0,1,4
.text
	.align 3
method_info_offsets:

	.long Lm_0_p - mi,Lm_1_p - mi,Lm_2_p - mi,Lm_3_p - mi,Lm_4_p - mi,Lm_5_p - mi,Lm_6_p - mi,Lm_7_p - mi
	.long 0,Lm_9_p - mi

.text
	.align 3
extra_method_info:

	.byte 0,1,6,83,121,115,116,101,109,46,65,114,114,97,121,58,71,101,116,71,101,110,101,114,105,99,86,97,108,117,101,73
	.byte 109,112,108,32,40,105,110,116,44,111,98,106,101,99,116,38,41,0

.text
	.align 3
extra_method_table:

	.long 11,0,0,0,1,9,0,0
	.long 0,0,0,0,0,0,0,0
	.long 0,0,0,0,0,0,0,0
	.long 0,0,0,0,0,0,0,0
	.long 0,0
.text
	.align 3
extra_method_info_offsets:

	.long 1,9,1
.text
	.align 3
method_order:

	.long 0,16777215,0,1,2,3,4,5
	.long 6,7,9

.text
method_order_end:
.text
	.align 3
class_name_table:

	.short 11, 1, 0, 2, 0, 0, 0, 0
	.short 0, 0, 0, 0, 0, 0, 0, 0
	.short 0, 0, 0, 0, 0, 0, 0
.text
	.align 3
got_info:

	.byte 12,0,39,17,0,1,17,0,11,33,3,193,0,23,185,3,193,0,24,23,3,193,0,24,88,3,193,0,24,22,3,194
	.byte 0,2,107,3,193,0,23,68,3,193,0,24,26,3,193,0,23,66,3,194,0,2,111,3,193,0,2,123,3,193,0,4
	.byte 138,3,193,0,24,127,3,194,0,2,122,3,193,0,24,92,3,193,0,24,189,3,193,0,24,205,3,193,0,19,14,3
	.byte 193,0,19,11,3,193,0,19,13,3,193,0,20,29,3,193,0,20,41,3,193,0,24,190,3,193,0,24,209,3,193,0
	.byte 24,210,7,17,109,111,110,111,95,103,101,116,95,108,109,102,95,97,100,100,114,0,31,255,254,0,0,0,41,2,2,198
	.byte 0,4,3,0,1,1,2,2,7,30,109,111,110,111,95,99,114,101,97,116,101,95,99,111,114,108,105,98,95,101,120,99
	.byte 101,112,116,105,111,110,95,48,0,7,25,109,111,110,111,95,97,114,99,104,95,116,104,114,111,119,95,101,120,99,101,112
	.byte 116,105,111,110,0,7,35,109,111,110,111,95,116,104,114,101,97,100,95,105,110,116,101,114,114,117,112,116,105,111,110,95
	.byte 99,104,101,99,107,112,111,105,110,116,0
.text
	.align 3
got_info_offsets:

	.long 0,2,3,6,9
.text
	.align 3
ex_info:
ex:
Le_0_p:

	.byte 80,2,0,0
Le_1_p:

	.byte 92,2,26,0
Le_2_p:

	.byte 112,2,26,0
Le_3_p:

	.byte 124,2,26,0
Le_4_p:

	.byte 129,108,2,54,0
Le_5_p:

	.byte 131,72,2,83,0
Le_6_p:

	.byte 129,44,2,112,0
Le_7_p:

	.byte 44,2,0,0
Le_9_p:

	.byte 128,172,2,128,139,0
.text
	.align 3
ex_info_offsets:

	.long Le_0_p - ex,Le_1_p - ex,Le_2_p - ex,Le_3_p - ex,Le_4_p - ex,Le_5_p - ex,Le_6_p - ex,Le_7_p - ex
	.long 0,Le_9_p - ex

.text
	.align 3
unwind_info:

	.byte 25,12,13,0,76,14,8,135,2,68,14,24,136,6,139,5,140,4,142,3,68,14,32,68,13,11,27,12,13,0,76,14
	.byte 8,135,2,68,14,28,136,7,138,6,139,5,140,4,142,3,68,14,32,68,13,11,28,12,13,0,76,14,8,135,2,68
	.byte 14,28,136,7,138,6,139,5,140,4,142,3,68,14,184,1,68,13,11,28,12,13,0,76,14,8,135,2,68,14,28,136
	.byte 7,138,6,139,5,140,4,142,3,68,14,144,3,68,13,11,26,12,13,0,76,14,8,135,2,68,14,24,136,6,139,5
	.byte 140,4,142,3,68,14,168,1,68,13,11,33,12,13,0,72,14,40,132,10,133,9,134,8,135,7,136,6,137,5,138,4
	.byte 139,3,140,2,142,1,68,14,160,1,68,13,11
.text
	.align 3
class_info:
LK_I_0:

	.byte 0,128,144,8,0,0,1
LK_I_1:

	.byte 11,128,160,28,0,0,4,193,0,24,87,193,0,24,59,194,0,0,4,193,0,24,58,8,7,6,5,4,3,2
.text
	.align 3
class_info_offsets:

	.long LK_I_0 - class_info,LK_I_1 - class_info


.text
	.align 4
plt:
mono_aot_Assembly_UnityScript_plt:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_Assembly_UnityScript_got - . + 16,0
p_1:
plt_UnityEngine_MonoBehaviour__ctor:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_Assembly_UnityScript_got - . + 20,10
p_2:
plt_UnityEngine_Input_GetMouseButtonDown_int:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_Assembly_UnityScript_got - . + 24,15
p_3:
plt_UnityEngine_Object_op_Implicit_UnityEngine_Object:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_Assembly_UnityScript_got - . + 28,20
p_4:
plt_UnityEngine_Input_GetMouseButton_int:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_Assembly_UnityScript_got - . + 32,25
p_5:
plt_string_memset_byte__int_int:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_Assembly_UnityScript_got - . + 36,30
p_6:
plt_UnityEngine_Camera_get_main:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_Assembly_UnityScript_got - . + 40,35
p_7:
plt_UnityEngine_Input_get_mousePosition:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_Assembly_UnityScript_got - . + 44,40
p_8:
plt_UnityEngine_Camera_ScreenPointToRay_UnityEngine_Vector3:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_Assembly_UnityScript_got - . + 48,45
p_9:
plt_string_memcpy_byte__byte__int:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_Assembly_UnityScript_got - . + 52,50
p_10:
plt_UnityEngine_Physics_Raycast_UnityEngine_Ray_UnityEngine_RaycastHit_:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_Assembly_UnityScript_got - . + 56,55
p_11:
plt_UnityEngine_RaycastHit_get_transform:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_Assembly_UnityScript_got - . + 60,60
p_12:
plt_UnityEngine_Component_get_tag:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_Assembly_UnityScript_got - . + 64,65
p_13:
plt_string_op_Inequality_string_string:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_Assembly_UnityScript_got - . + 68,70
p_14:
plt_UnityEngine_Component_get_transform:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_Assembly_UnityScript_got - . + 72,75
p_15:
plt_UnityEngine_Transform_get_position:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_Assembly_UnityScript_got - . + 76,80
p_16:
plt_UnityEngine_Transform_get_forward:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_Assembly_UnityScript_got - . + 80,85
p_17:
plt_UnityEngine_Vector3_op_Multiply_UnityEngine_Vector3_single:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_Assembly_UnityScript_got - . + 84,90
p_18:
plt_UnityEngine_Vector3_op_Addition_UnityEngine_Vector3_UnityEngine_Vector3:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_Assembly_UnityScript_got - . + 88,95
p_19:
plt_UnityEngine_Vector3_op_UnaryNegation_UnityEngine_Vector3:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_Assembly_UnityScript_got - . + 92,100
p_20:
plt_UnityEngine_Plane__ctor_UnityEngine_Vector3_UnityEngine_Vector3:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_Assembly_UnityScript_got - . + 96,105
p_21:
plt_UnityEngine_Plane_Raycast_UnityEngine_Ray_single_:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_Assembly_UnityScript_got - . + 100,110
p_22:
plt_UnityEngine_Transform_set_position_UnityEngine_Vector3:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_Assembly_UnityScript_got - . + 104,115
p_23:
plt_UnityEngine_Transform_get_rotation:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_Assembly_UnityScript_got - . + 108,120
p_24:
plt_UnityEngine_Transform_set_rotation_UnityEngine_Quaternion:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_Assembly_UnityScript_got - . + 112,125
p_25:
plt__jit_icall_mono_get_lmf_addr:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_Assembly_UnityScript_got - . + 116,130
p_26:
plt__icall_native_System_Array_GetGenericValueImpl_object_int_object_:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_Assembly_UnityScript_got - . + 120,150
p_27:
plt__jit_icall_mono_create_corlib_exception_0:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_Assembly_UnityScript_got - . + 124,168
p_28:
plt__jit_icall_mono_arch_throw_exception:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_Assembly_UnityScript_got - . + 128,201
p_29:
plt__jit_icall_mono_thread_interruption_checkpoint:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_Assembly_UnityScript_got - . + 132,229
plt_end:
.text
	.align 3
mono_image_table:

	.long 3
	.asciz "Assembly-UnityScript"
	.asciz "F68EB047-A3F3-4209-BD78-889C954C5654"
	.asciz ""
	.asciz ""
	.align 3

	.long 0,0,0,0,0
	.asciz "UnityEngine"
	.asciz "59A9B842-1C4D-4240-B57A-EBDA35250FA7"
	.asciz ""
	.asciz ""
	.align 3

	.long 0,0,0,0,0
	.asciz "mscorlib"
	.asciz "F7DE7BB6-83A9-4F92-BD7A-366EC18B3DE9"
	.asciz ""
	.asciz "7cec85d7bea7798e"
	.align 3

	.long 1,2,0,5,0
.data
	.align 3
mono_aot_Assembly_UnityScript_got:
	.space 140
got_end:
.data
	.align 3
mono_aot_got_addr:
	.align 2
	.long mono_aot_Assembly_UnityScript_got
.data
	.align 3
mono_aot_file_info:

	.long 5,140,30,10,1024,1024,128,0
	.long 0,0,0,0,0
.text
	.align 2
mono_assembly_guid:
	.asciz "F68EB047-A3F3-4209-BD78-889C954C5654"
.text
	.align 2
mono_aot_version:
	.asciz "66"
.text
	.align 2
mono_aot_opt_flags:
	.asciz "55650815"
.text
	.align 2
mono_aot_full_aot:
	.asciz "TRUE"
.text
	.align 2
mono_runtime_version:
	.asciz ""
.text
	.align 2
mono_aot_assembly_name:
	.asciz "Assembly-UnityScript"
.text
	.align 3
Lglobals_hash:

	.short 73, 27, 0, 0, 0, 0, 0, 0
	.short 0, 15, 0, 19, 0, 0, 0, 0
	.short 0, 6, 0, 0, 0, 3, 0, 0
	.short 0, 0, 0, 0, 0, 0, 0, 29
	.short 0, 13, 0, 5, 0, 0, 0, 0
	.short 0, 4, 0, 28, 0, 0, 0, 9
	.short 0, 0, 0, 0, 0, 0, 0, 14
	.short 0, 1, 0, 0, 0, 0, 0, 12
	.short 74, 0, 0, 0, 0, 0, 0, 30
	.short 0, 2, 75, 0, 0, 0, 0, 0
	.short 0, 0, 0, 0, 0, 0, 0, 0
	.short 0, 22, 0, 0, 0, 0, 0, 0
	.short 0, 11, 0, 17, 0, 8, 0, 0
	.short 0, 0, 0, 0, 0, 0, 0, 0
	.short 0, 0, 0, 0, 0, 0, 0, 0
	.short 0, 0, 0, 0, 0, 16, 0, 20
	.short 0, 7, 73, 24, 0, 10, 0, 0
	.short 0, 0, 0, 0, 0, 0, 0, 0
	.short 0, 21, 0, 18, 76, 23, 0, 25
	.short 0, 26, 0
.text
	.align 2
name_0:
	.asciz "methods"
.text
	.align 2
name_1:
	.asciz "methods_end"
.text
	.align 2
name_2:
	.asciz "method_addresses"
.text
	.align 2
name_3:
	.asciz "method_offsets"
.text
	.align 2
name_4:
	.asciz "method_info"
.text
	.align 2
name_5:
	.asciz "method_info_offsets"
.text
	.align 2
name_6:
	.asciz "extra_method_info"
.text
	.align 2
name_7:
	.asciz "extra_method_table"
.text
	.align 2
name_8:
	.asciz "extra_method_info_offsets"
.text
	.align 2
name_9:
	.asciz "method_order"
.text
	.align 2
name_10:
	.asciz "method_order_end"
.text
	.align 2
name_11:
	.asciz "class_name_table"
.text
	.align 2
name_12:
	.asciz "got_info"
.text
	.align 2
name_13:
	.asciz "got_info_offsets"
.text
	.align 2
name_14:
	.asciz "ex_info"
.text
	.align 2
name_15:
	.asciz "ex_info_offsets"
.text
	.align 2
name_16:
	.asciz "unwind_info"
.text
	.align 2
name_17:
	.asciz "class_info"
.text
	.align 2
name_18:
	.asciz "class_info_offsets"
.text
	.align 2
name_19:
	.asciz "plt"
.text
	.align 2
name_20:
	.asciz "plt_end"
.text
	.align 2
name_21:
	.asciz "mono_image_table"
.text
	.align 2
name_22:
	.asciz "mono_aot_got_addr"
.text
	.align 2
name_23:
	.asciz "mono_aot_file_info"
.text
	.align 2
name_24:
	.asciz "mono_assembly_guid"
.text
	.align 2
name_25:
	.asciz "mono_aot_version"
.text
	.align 2
name_26:
	.asciz "mono_aot_opt_flags"
.text
	.align 2
name_27:
	.asciz "mono_aot_full_aot"
.text
	.align 2
name_28:
	.asciz "mono_runtime_version"
.text
	.align 2
name_29:
	.asciz "mono_aot_assembly_name"
.data
	.align 3
Lglobals:
	.align 2
	.long Lglobals_hash
	.align 2
	.long name_0
	.align 2
	.long methods
	.align 2
	.long name_1
	.align 2
	.long methods_end
	.align 2
	.long name_2
	.align 2
	.long method_addresses
	.align 2
	.long name_3
	.align 2
	.long method_offsets
	.align 2
	.long name_4
	.align 2
	.long method_info
	.align 2
	.long name_5
	.align 2
	.long method_info_offsets
	.align 2
	.long name_6
	.align 2
	.long extra_method_info
	.align 2
	.long name_7
	.align 2
	.long extra_method_table
	.align 2
	.long name_8
	.align 2
	.long extra_method_info_offsets
	.align 2
	.long name_9
	.align 2
	.long method_order
	.align 2
	.long name_10
	.align 2
	.long method_order_end
	.align 2
	.long name_11
	.align 2
	.long class_name_table
	.align 2
	.long name_12
	.align 2
	.long got_info
	.align 2
	.long name_13
	.align 2
	.long got_info_offsets
	.align 2
	.long name_14
	.align 2
	.long ex_info
	.align 2
	.long name_15
	.align 2
	.long ex_info_offsets
	.align 2
	.long name_16
	.align 2
	.long unwind_info
	.align 2
	.long name_17
	.align 2
	.long class_info
	.align 2
	.long name_18
	.align 2
	.long class_info_offsets
	.align 2
	.long name_19
	.align 2
	.long plt
	.align 2
	.long name_20
	.align 2
	.long plt_end
	.align 2
	.long name_21
	.align 2
	.long mono_image_table
	.align 2
	.long name_22
	.align 2
	.long mono_aot_got_addr
	.align 2
	.long name_23
	.align 2
	.long mono_aot_file_info
	.align 2
	.long name_24
	.align 2
	.long mono_assembly_guid
	.align 2
	.long name_25
	.align 2
	.long mono_aot_version
	.align 2
	.long name_26
	.align 2
	.long mono_aot_opt_flags
	.align 2
	.long name_27
	.align 2
	.long mono_aot_full_aot
	.align 2
	.long name_28
	.align 2
	.long mono_runtime_version
	.align 2
	.long name_29
	.align 2
	.long mono_aot_assembly_name

	.long 0,0
	.globl _mono_aot_module_Assembly_UnityScript_info
	.align 3
_mono_aot_module_Assembly_UnityScript_info:
	.align 2
	.long Lglobals
.text
	.align 3
mem_end:
#endif
