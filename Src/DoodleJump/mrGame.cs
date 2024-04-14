// Type: mrGame.MrGame
// Assembly: DoodleJump, Version=1.8.10.0, Culture=neutral, PublicKeyToken=null

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.IO.IsolatedStorage;
using System.Text;
using System.Threading;

using Windows.UI.Core;
using Windows.Devices.Sensors;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
//using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input.Touch;
using Microsoft.Xna.Framework.Media;
using Windows.Foundation;


//#nullable disable
namespace mrGame
{
  public class MrGame
  {
    public Game1 xnagame;
    public float p_tf_Xu;
    public float p_tf_Xv;
    public float p_tf_Xx;
    public float p_tf_Xy;
    public float p_tf_X1;
    public float p_tf_Yu;
    public float p_tf_Yv;
    public float p_tf_Yx;
    public float p_tf_Yy;
    public float p_tf_Y1;
    public float p_tf_invdet1;
    public float p_tf_invdet2;
    public float p_tf_xu;
    public float p_tf_yu;
    public float p_tf_xv;
    public float p_tf_yv;
    public float[] p_egfx_stack;
    public int p_egfx_sp;
    public int dynamic_X_RES;
    public int dynamic_Y_RES;
    public int[][] p_globalPalettes;
    public bool p_gp_loaded;
    public bool p_pow2_texture = true;
    public mrGame.MrGame.Image[] p_allImages = new mrGame.MrGame.Image[1559];
    public int p_tempClipX;
    public int p_tempClipY;
    public int p_tempClipWidth;
    public int p_tempClipHeight;
    public int fgColor;
    public int p_blendmode;
    private Color cFgColor;
    public sbyte[] p_options;
    public sbyte[] p_indexTable1;
    public short[] p_indexTable2;
    public int[] p_indexTable3;
    public bool mainTextLoaded;
    public bool p_processHideNotifyNextFrame;
    public bool p_processShowNotifyNextFrame;
    public bool p_mainGroupsLoaded;
    public bool p_sizeChangedBeforeMainGroupsLoaded;
    public long p_lastloadtime;
    public bool p_lb_fillScreen;
    public int p_loadingBoxCounter;
    public int p_acceleration_x;
    public int p_acceleration_y;
    public int p_acceleration_z;
    public mrGame.MrGame.ByteInput p_data_istream;
    public mrGame.MrGame.ByteInput p_bytecodec_istream;
    private BinaryWriter p_binaryWriter;
    public mrGame.MrGame.MrgString[] p_localelist = new mrGame.MrGame.MrgString[5]
    {
      (mrGame.MrGame.MrgString) "EN",
      (mrGame.MrGame.MrgString) "FR",
      (mrGame.MrGame.MrgString) "ES",
      (mrGame.MrGame.MrgString) "DE",
      (mrGame.MrGame.MrgString) "IT"
    };
    public mrGame.MrGame.MrgString[] p_allTexts = new mrGame.MrGame.MrgString[160];
    public int[] p_keyBuffer = new int[20];
    public bool[] p_keys = new bool[80];
    public bool[] p_keyTypeBuffer = new bool[20];
    public int p_keyCounter;
    public bool p_newKeyEvent;
    public mrGame.MrGame.EmergeTouch[] p_touchdata;
    public int p_mt_first;
    public int p_mt_secondary;
    public int p_mt_last;
    public int p_mt_last_if_down;
    public int p_mt_count;
    public bool p_multitouch_initialized;
    public int p_optionSound;
    public bool p_inGame;
    public bool p_gameDisplay;
    public bool p_forcedPaint;
    public bool p_exitrunko;
    public bool repaintAll;
    public bool repaintScreen;
    public bool p_initializingState;
    public long p_startTimeMS;
    private static DateTime p_Jan1970 = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
    public int frameNum;
    public int smoothtime;
    public int gametime;
    public int timedelta;
    public bool cursorBlink;
    public int p_lastCursorBlink;
    public bool gametimePaused;
    public int p_realtime;
    public int p_lasttime;
    public int p_timebufferlen;
    public int p_mspf;
    public int p_starttime;
    public int p_lastrealtime;
    public int p_monotime;
    public int p_monotimedelta;
    public int p_stabletimedelta;
    public int p_outliercounter;
    public int p_zerocount;
    public int[] p_timebuffer = new int[4];
    public bool[] p_soundGroupLoaded;
    private mrGame.MrGame.Sound[] p_soundEffects = new mrGame.MrGame.Sound[31];
    private static Dictionary<int, mrGame.MrGame.LeaderboardInfo> p_xbla_Leaderboards;
    private static GamerServicesComponent p_gamerServicesInstance = (GamerServicesComponent) null;
    private static SignedInGamer p_SignedInGamer = (SignedInGamer) null;
    private static bool p_TitleUpdateAvailable = false;
    private static bool p_displayTitleUpdateAvailable = false;
    private static bool p_xbla_showMarketPlace = false;
    private static object p_AchievementLock = new object();
        private static AchievementCollection p_Achievements;// = (AchievementCollection) null;
    private static int p_xbla_MaxGamerScore = 0;
    private static int p_xbla_EarnedGamerScore = 0;
    private Accelerometer _accelerometer;
    private static bool p_xna_sensor_activatedByGame = false;
    public int runko_state;
    public bool p_inputtingText;
    public bool p_isUnlocked;
    public bool p_em_selectLanguageActive;
    public int p_langID;
    public bool p_em_gotoGame;
    public bool p_em_introMode;
    public bool p_em_confirming;
    public bool p_gameIntroInited;
    public bool p_game_menuInited;
    public int p_em_confirmElement;
    public mrGame.MrGame.MrgString p_em_confirmText;
    public int[] p_em_menuStack = new int[5];
    public int[] p_em_pointerStack = new int[5];
    public int[] p_em_currentMenuElements = new int[12];
    public int p_em_stackPos;
    public int p_em_currentMenuPointer;
    public int p_em_currentMenuLength;
    public int p_em_currentMenuType;
    public int p_em_currentMenuTopic;
    public int p_em_currentMenuScroll;
    public int p_em_specialStartMenu;
    public int p_em_specialIngameMenu;
    public int p_em_textboxCurrentLine;
    public int p_em_maxLines;
    public int p_em_cursorY;
    public mrGame.MrGame.MrgString p_em_currentMenuTextboxString;
    public sbyte[] p_options_multioption;
    public int p_confirmationPage;
    public int customization_menuid;
    public short customization_initialStartElementTextIndex;
    public bool p_em_softkeysPaintedInThisFrame;
    public mrGame.MrGame.MrgString p_uid_instanceId;
    public bool p_eg_listeningKeyPresses;
    public mrGame.MrGame.GuiKeyBind[] p_eg_keyBinds;
    public int p_eg_keyBindAmount;
    public bool p_eg_wrappingEnabled;
    public int p_eg_compareLeftThreshold;
    public int p_eg_compareRightThreshold;
    public int p_eg_compareBottomThreshold;
    public int p_eg_compareTopThreshold;
    public int p_eg_repeatingKey;
    public int p_eg_repeatAmount;
    public int p_eg_lastKeyRepeat;
    public int p_eg_pointerVX;
    public int p_eg_pointerVY;
    public bool p_eg_eventRegistered;
    public bool p_eg_pressEventRegistered;
    public int p_eg_guiBorderLeft;
    public int p_eg_guiBorderRight;
    public int p_eg_guiBorderTop;
    public int p_eg_guiBorderBottom;
    public int p_eg_elementAmount;
    public mrGame.MrGame.GuiElement[] p_eg_elementList;
    public int[] p_eg_elementOrdering;
    public bool p_eg_keyMode;
    public int p_eg_prevElementOnPointer;
    public int p_eg_focusElement;
    public int p_eg_prevFocusElement;
    public bool p_eg_hidden;
    public int p_eg_origFocusElement;
    public bool p_eg_hackPressingKeyInsideGui;
    public bool p_eg_horizontalMovementEnabled;
    public bool p_eg_verticalMovementOnly;
    public bool p_eg_numpadEvent;
    public bool p_eg_pressingGuiSoftkey;
    public bool p_eg_guiLocked;
    public bool p_eg_gameAreaFocusable;
    public int p_eg_origPointerX;
    public int p_eg_origPointerY;
    public bool p_eg_pointerReportedDown;
    public int p_eg_oldTbInputFlags;
    public int p_eg_prevPointerX;
    public int p_eg_prevPointerY;
    public int p_eg_pointerDraggingElement;
    public bool p_eg_draggingHorizontal;
    public bool p_eg_draggingVertical;
    public bool p_eg_guiPainted;
    public int p_eg_guiScrollX;
    public int p_eg_guiScrollY;
    public int p_eg_guiScrollSrcX;
    public int p_eg_guiScrollSrcY;
    public int p_eg_guiScrollT;
    public int p_eg_areaX;
    public int p_eg_areaY;
    public int p_eg_areaW;
    public int p_eg_areaH;
    public bool p_eg_scrollingWithPointer;
    public bool p_eg_autoScroll;
    public int p_eg_scrollMargin;
    public int p_eg_guiScrollDuration;
    public int p_eg_lastScrollPX;
    public int p_eg_lastScrollPY;
    public int hs_currentTable;
    public int[] hs_data_int;
    public mrGame.MrGame.MrgString[] hs_data_string;
    public int p_tb_scroll;
    public int p_tb_origScroll;
    public int p_tb_scrollTime;
    public int p_tb_changeTime;
    public int p_tb_scrollHeight;
    public int p_tb_scrollVelocity;
    public int p_tb_timeLeft;
    public bool p_tb_showScrollbar;
    public int p_tb_inputHandleFlags;
    public int p_tb_backupConfirmHandleFlags;
    public int p_tbBackupHandleFlags;
    public bool p_tb_pointerPressedInside;
    public int p_tb_pointerOrigScroll;
    public int p_tb_pointerLastY;
    public int p_tb_pointerLastYSpeed;
    public bool p_tb_pointerHandleRelease;
    public mrGame.MrGame.MrgString p_tb_text;
    public short[] p_tb_stuff = new short[1800];
    public short[] p_tb_lines = new short[300];
    public short[] p_tb_images = new short[404];
    public int p_tb_stuffCount;
    public int p_tb_imageCount;
    public int p_tb_lineCount;
    public int p_tb_anchorCount;
    public int p_tb_realLineCount;
    public int p_tb_boxSizeHeight;
    public int p_tb_stuffHeight;
    public int p_tb_avgLinesPerPage;
    public int p_tb_currenBoxId;
    public bool p_tb_oldBehavior;
    public int p_tbBackupId;
    public int p_tb_lastVisibleLine;
    public int tb_maxLines;
    public int tb_numLines;
    public int tb_numPages;
    public int tb_lScrollLine;
    public int p_tbBackupFont;
    public int p_tbBackupWidth;
    public int p_tbBackupHeight;
    public mrGame.MrGame.MrgString p_tbBackupString;
    public bool p_tbBackupEmulateOld;
    public int p_tbBackupBorderX;
    public int p_tbBackupBorderY;
    public int p_tbBackupBorderWidth;
    public int p_tbBackupBorderHeight;
    public int p_tbBackupTextX;
    public int p_tbBackupTextY;
    public int p_tbBorderX;
    public int p_tbBorderY;
    public int p_tbBorderWidth;
    public int p_tbBorderHeight;
    public int p_tbTextX;
    public int p_tbTextY;
    public int p_tbMaxLineWidth;
    public int p_tbFont;
    public int p_tbCurrentLine;
    public bool tb_loadFinished;
    public int p_cal_secs;
    public int p_cal_day;
    public int p_cal_month;
    public int p_cal_year;
    public mrGame.MrGame.MrgString p_cal_tmpstr;
    public int p_cal_timezoneTemp;
    public mrGame.MrGame.MrgString p_textinputString;
    public int p_textinputOkLabel;
    public mrGame.MrGame.MrgString p_textinputCaption;
    public int[] p_bmfont_charindextbl;
    private Random rand_randomi;
    public short[] sinTbl;
    public int common_fp_screenWidth;
    public int common_fp_screenHeight;
    public int common_fp_configNormalAccX;
    public int common_fp_configNormalDecX;
    public int common_fp_configNormalAccY;
    public int common_fp_configMaxVelX;
    public int common_fp_configMaxFallVelY;
    public int common_fp_configJumpVelY;
    public int common_fp_configShortLegsVelY;
    public int common_fp_configPropellerHat1stPhaseDur;
    public int common_fp_configPropellerHat2ndPhaseDur;
    public int common_fp_configPropellerHat3rdPhaseDur;
    public int common_fp_configCharacterYLimit;
    public int common_fp_configLogicScreenWidth;
    public int common_fp_configLogicScreenHeight;
    public int common_fp_xRatio;
    public int common_fp_yRatio;
    public int common_fp_configBrownPlatformFallVelY;
    public int common_fp_configCharacterSpringVelY;
    public int common_seed;
    public bool popup_active;
    public short popup_type;
    public int popup_buttonTextId;
    public int[] stats_table;
    public int stats_startTimeMs;
    public int themes_current;
    public short[] themes_scenes;
    public short[] themes_scenesIndexes;
    public bool[] themes_scenesMarked;
    public short[] themes_characterTrunkOffset;
    public int[] themes_spaceBg;
    public int themes_spaceBgH;
    public mrGame.MrGame.Pair[] themes_map;
    public bool themes_allowPropellerHat;
    public bool themes_allowShield;
    public mrGame.MrGame.Particle[] particles_array;
    public bool particles_enabled;
    public int particles_active;
    public int particles_fp_time;
    public bool particles_p_rainPlaying;
    public bool particles_thunder;
    public int particles_blendTime;
    public int[] particles_thunderBlendValue;
    public bool particles_p_rainThunderTriggerd;
    public mrGame.MrGame.GameObject[] objects_array;
    public int objects_begin;
    public int objects_end;
    public int objects_collidedIndex;
    public int objects_holdOnIndex;
    public int objects_maxHeight;
    public sbyte[] objects_monsterBlueWingsAnim;
    public int doodleHoaxY;
    public int character_fp_velX;
    public int character_fp_velY;
    public int character_fp_accX;
    public int character_fp_accY;
    public int character_fp_posX;
    public int character_fp_posY;
    public int character_fp_origPosX;
    public int character_fp_origPosY;
    public bool character_isFacingLeft;
    public int character_rotationTime;
    public int powerup_rotationTime;
    public int character_fp_width;
    public int character_fp_height;
    public int character_state;
    public int character_fp_stateTime;
    public bool powerup_fallDirectionLeft;
    public int powerup_fp_fallPosX;
    public int powerup_fp_fallPosY;
    public int powerup_fp_fallVelX;
    public int powerup_fp_fallVelY;
    public int powerup_fp_fallAccX;
    public int powerup_fp_fallAccY;
    public int powerup_fp_shieldTime;
    public int powerup_nextPropellerHatHeight;
    public int powerup_nextJetPackHeight;
    public int powerup_nextRocketHeight;
    public int powerup_usedJetPacks;
    public int powerup_springShoesJumpsLeft;
    public bool powerup_propellerHatInScene;
    public bool powerup_jetPackInScene;
    public int character_fp_movementDelta;
    public int platforms_begin;
    public int platforms_end;
    public int platforms_fp_width;
    public int platforms_fp_wWidth;
    public int platforms_fp_wHeight;
    public int platforms_minDistance;
    public short[] platforms_scenes;
    public short[] platforms_scenesIndexes;
    public bool platforms_scenarioAborted;
    public mrGame.MrGame.Platform[] platforms_array;
    public int projectiles_count;
    public int projectiles_timeFromLast;
    public int projectiles_holdOnIndex;
    public mrGame.MrGame.Projectile[] projectiles_array;
    public mrGame.MrGame.MrgString highscores_playerName;
    public bool multiplayer_enabled;
    public bool multiplayer_loadingState;
    public int multiplayer_player;
    public int multiplayer_maxplayers;
    public mrGame.MrGame.MrgString[] multiplayer_playerNames;
    public bool doj_showTapToChangeImage;
    public bool theme_notSlided;
    public int doj_textInputMode;
    public bool menu_intro;
    public int doj_initialMenu;
    public int menu_fp_time;
    public int menu_softkey1;
    public int menu_softkey2;
    public int menuTopY;
    public int menuBottomY;
    public bool horizArrowVisible;
    public int mainMenuThemeSliderY;
    public int loading_stepsCounter;
    public int loading_lastLoadingTime;
    public int loading_fp_posY;
    public int loading_fp_velY;
    public int intro_time;
    public bool tutorial_active;
    public short tutorial_mode;
    public bool doj_exitGame;
    public bool doj_isInGameMenu;
    public int doj_fp_time;
    public int doj_screen_fp_posX;
    public int doj_fp_screenYOffset;
    public int doj_fp_screenYOffsetOld;
    public int doj_score;
    public int doj_backgroundPixelsOffset;
    public bool doj_endGameSeq;
    public int doj_fp_endGameYoff;
    public char[] doj_scoreCharArr;
    public bool doj_drawRippedPaper;
    public bool doj_gameOver;
    public bool doj_classicMode;
    public bool doj_loading;
    public bool doj_leftKeyDown;
    public bool doj_rightKeyDown;
    public int doj_fp_keyDownTime;
    public int doj_pointerX;
    public int doj_fp_pixelAccX;
    public bool doj_pointerDown;
    public bool doj_sfx_monsterWarning;
    public bool doj_sfx_ufoWarning;
    public int acc_x;
    public short mAchievements;
    public sbyte[] mAchievementStats;
    public sbyte[] mAchievementLimits;
    public bool dxIsAuthenticated;
    public int dxResultIndex;
    public bool dxCheckRequest;
    public int dxScoresId;
    public bool dxErrorRequest;
    public int leaderboardIndex;
        public bool isExceptionFirstShown = true;

        public void egfx_reset()
    {
      this.p_tf_Xu = this.p_tf_Xx = this.p_tf_Yv = this.p_tf_Yy = 1f;
      this.p_tf_Xv = this.p_tf_Xy = this.p_tf_X1 = this.p_tf_Yu = this.p_tf_Yx = this.p_tf_Y1 = 0.0f;
      this.p_tf_invdet1 = (float) (1.0 / ((double) this.p_tf_Xx * (double) this.p_tf_Yy - (double) this.p_tf_Yx * (double) this.p_tf_Xy));
      this.p_tf_invdet2 = (float) (1.0 / ((double) this.p_tf_Xu * (double) this.p_tf_Yv - (double) this.p_tf_Yu * (double) this.p_tf_Xv));
      this.p_tf_xu = (float) (1.0 + (((double) this.p_tf_Xu - (double) this.p_tf_Xx) * (double) this.p_tf_Yy - ((double) this.p_tf_Yu - (double) this.p_tf_Yx) * (double) this.p_tf_Xy) * (double) this.p_tf_invdet1);
      this.p_tf_xv = (float) ((double) this.p_tf_Xv * (double) this.p_tf_Yy - (double) this.p_tf_Yv * (double) this.p_tf_Xy) * this.p_tf_invdet1;
      this.p_tf_yu = (float) ((double) this.p_tf_Yu * (double) this.p_tf_Xx - (double) this.p_tf_Xu * (double) this.p_tf_Yx) * this.p_tf_invdet1;
      this.p_tf_yv = (float) (1.0 + (((double) this.p_tf_Yv - (double) this.p_tf_Yy) * (double) this.p_tf_Xx - ((double) this.p_tf_Xv - (double) this.p_tf_Xy) * (double) this.p_tf_Yx) * (double) this.p_tf_invdet1);
    }

    public void egfx_push()
    {
      this.p_egfx_stack[this.p_egfx_sp++] = this.p_tf_Xu;
      this.p_egfx_stack[this.p_egfx_sp++] = this.p_tf_Xv;
      this.p_egfx_stack[this.p_egfx_sp++] = this.p_tf_Xx;
      this.p_egfx_stack[this.p_egfx_sp++] = this.p_tf_Xy;
      this.p_egfx_stack[this.p_egfx_sp++] = this.p_tf_X1;
      this.p_egfx_stack[this.p_egfx_sp++] = this.p_tf_Yu;
      this.p_egfx_stack[this.p_egfx_sp++] = this.p_tf_Yv;
      this.p_egfx_stack[this.p_egfx_sp++] = this.p_tf_Yx;
      this.p_egfx_stack[this.p_egfx_sp++] = this.p_tf_Yy;
      this.p_egfx_stack[this.p_egfx_sp++] = this.p_tf_Y1;
    }

    public void egfx_pop()
    {
      this.p_tf_Y1 = this.p_egfx_stack[--this.p_egfx_sp];
      this.p_tf_Yy = this.p_egfx_stack[--this.p_egfx_sp];
      this.p_tf_Yx = this.p_egfx_stack[--this.p_egfx_sp];
      this.p_tf_Yv = this.p_egfx_stack[--this.p_egfx_sp];
      this.p_tf_Yu = this.p_egfx_stack[--this.p_egfx_sp];
      this.p_tf_X1 = this.p_egfx_stack[--this.p_egfx_sp];
      this.p_tf_Xy = this.p_egfx_stack[--this.p_egfx_sp];
      this.p_tf_Xx = this.p_egfx_stack[--this.p_egfx_sp];
      this.p_tf_Xv = this.p_egfx_stack[--this.p_egfx_sp];
      this.p_tf_Xu = this.p_egfx_stack[--this.p_egfx_sp];
      this.p_tf_invdet1 = (float) (1.0 / ((double) this.p_tf_Xx * (double) this.p_tf_Yy - (double) this.p_tf_Yx * (double) this.p_tf_Xy));
      this.p_tf_invdet2 = (float) (1.0 / ((double) this.p_tf_Xu * (double) this.p_tf_Yv - (double) this.p_tf_Yu * (double) this.p_tf_Xv));
      this.p_tf_xu = (float) (1.0 + (((double) this.p_tf_Xu - (double) this.p_tf_Xx) * (double) this.p_tf_Yy - ((double) this.p_tf_Yu - (double) this.p_tf_Yx) * (double) this.p_tf_Xy) * (double) this.p_tf_invdet1);
      this.p_tf_xv = (float) ((double) this.p_tf_Xv * (double) this.p_tf_Yy - (double) this.p_tf_Yv * (double) this.p_tf_Xy) * this.p_tf_invdet1;
      this.p_tf_yu = (float) ((double) this.p_tf_Yu * (double) this.p_tf_Xx - (double) this.p_tf_Xu * (double) this.p_tf_Yx) * this.p_tf_invdet1;
      this.p_tf_yv = (float) (1.0 + (((double) this.p_tf_Yv - (double) this.p_tf_Yy) * (double) this.p_tf_Xx - ((double) this.p_tf_Xv - (double) this.p_tf_Xy) * (double) this.p_tf_Yx) * (double) this.p_tf_invdet1);
    }

    public void mrp_egfx_init()
    {
      this.p_egfx_stack = new float[160];
      this.p_egfx_sp = 0;
      this.egfx_reset();
    }

    public void mrp_egfx_free() => this.p_egfx_stack = (float[]) null;

    public void p_egfx_coord_move_f(float x, float y)
    {
      this.p_tf_X1 += (float) ((double) x * (double) this.p_tf_Xx + (double) y * (double) this.p_tf_Xy);
      this.p_tf_Y1 += (float) ((double) x * (double) this.p_tf_Yx + (double) y * (double) this.p_tf_Yy);
    }

    public void p_egfx_pixel_scale_f(float scale)
    {
      this.p_tf_Xu *= scale;
      this.p_tf_Xv *= scale;
      this.p_tf_Yu *= scale;
      this.p_tf_Yv *= scale;
      this.p_tf_invdet1 = (float) (1.0 / ((double) this.p_tf_Xx * (double) this.p_tf_Yy - (double) this.p_tf_Yx * (double) this.p_tf_Xy));
      this.p_tf_invdet2 = (float) (1.0 / ((double) this.p_tf_Xu * (double) this.p_tf_Yv - (double) this.p_tf_Yu * (double) this.p_tf_Xv));
      this.p_tf_xu = (float) (1.0 + (((double) this.p_tf_Xu - (double) this.p_tf_Xx) * (double) this.p_tf_Yy - ((double) this.p_tf_Yu - (double) this.p_tf_Yx) * (double) this.p_tf_Xy) * (double) this.p_tf_invdet1);
      this.p_tf_xv = (float) ((double) this.p_tf_Xv * (double) this.p_tf_Yy - (double) this.p_tf_Yv * (double) this.p_tf_Xy) * this.p_tf_invdet1;
      this.p_tf_yu = (float) ((double) this.p_tf_Yu * (double) this.p_tf_Xx - (double) this.p_tf_Xu * (double) this.p_tf_Yx) * this.p_tf_invdet1;
      this.p_tf_yv = (float) (1.0 + (((double) this.p_tf_Yv - (double) this.p_tf_Yy) * (double) this.p_tf_Xx - ((double) this.p_tf_Xv - (double) this.p_tf_Xy) * (double) this.p_tf_Yx) * (double) this.p_tf_invdet1);
    }

    public void p_egfx_pixel_stretch_f(float scaleu, float scalev)
    {
      this.p_tf_Xu *= scaleu;
      this.p_tf_Xv *= scalev;
      this.p_tf_Yu *= scaleu;
      this.p_tf_Yv *= scalev;
      this.p_tf_invdet1 = (float) (1.0 / ((double) this.p_tf_Xx * (double) this.p_tf_Yy - (double) this.p_tf_Yx * (double) this.p_tf_Xy));
      this.p_tf_invdet2 = (float) (1.0 / ((double) this.p_tf_Xu * (double) this.p_tf_Yv - (double) this.p_tf_Yu * (double) this.p_tf_Xv));
      this.p_tf_xu = (float) (1.0 + (((double) this.p_tf_Xu - (double) this.p_tf_Xx) * (double) this.p_tf_Yy - ((double) this.p_tf_Yu - (double) this.p_tf_Yx) * (double) this.p_tf_Xy) * (double) this.p_tf_invdet1);
      this.p_tf_xv = (float) ((double) this.p_tf_Xv * (double) this.p_tf_Yy - (double) this.p_tf_Yv * (double) this.p_tf_Xy) * this.p_tf_invdet1;
      this.p_tf_yu = (float) ((double) this.p_tf_Yu * (double) this.p_tf_Xx - (double) this.p_tf_Xu * (double) this.p_tf_Yx) * this.p_tf_invdet1;
      this.p_tf_yv = (float) (1.0 + (((double) this.p_tf_Yv - (double) this.p_tf_Yy) * (double) this.p_tf_Xx - ((double) this.p_tf_Xv - (double) this.p_tf_Xy) * (double) this.p_tf_Yx) * (double) this.p_tf_invdet1);
    }

    public void p_egfx_pixel_linearTransform_f(float Xu, float Yu, float Xv, float Yv)
    {
      float pTfXu = this.p_tf_Xu;
      float pTfYu = this.p_tf_Yu;
      float pTfXv = this.p_tf_Xv;
      float pTfYv = this.p_tf_Yv;
      this.p_tf_Xu = (float) ((double) Xu * (double) pTfXu + (double) Yu * (double) pTfXv);
      this.p_tf_Yu = (float) ((double) Xu * (double) pTfYu + (double) Yu * (double) pTfYv);
      this.p_tf_Xv = (float) ((double) Xv * (double) pTfXu + (double) Yv * (double) pTfXv);
      this.p_tf_Yv = (float) ((double) Xv * (double) pTfYu + (double) Yv * (double) pTfYv);
      this.p_tf_invdet1 = (float) (1.0 / ((double) this.p_tf_Xx * (double) this.p_tf_Yy - (double) this.p_tf_Yx * (double) this.p_tf_Xy));
      this.p_tf_invdet2 = (float) (1.0 / ((double) this.p_tf_Xu * (double) this.p_tf_Yv - (double) this.p_tf_Yu * (double) this.p_tf_Xv));
      this.p_tf_xu = (float) (1.0 + (((double) this.p_tf_Xu - (double) this.p_tf_Xx) * (double) this.p_tf_Yy - ((double) this.p_tf_Yu - (double) this.p_tf_Yx) * (double) this.p_tf_Xy) * (double) this.p_tf_invdet1);
      this.p_tf_xv = (float) ((double) this.p_tf_Xv * (double) this.p_tf_Yy - (double) this.p_tf_Yv * (double) this.p_tf_Xy) * this.p_tf_invdet1;
      this.p_tf_yu = (float) ((double) this.p_tf_Yu * (double) this.p_tf_Xx - (double) this.p_tf_Xu * (double) this.p_tf_Yx) * this.p_tf_invdet1;
      this.p_tf_yv = (float) (1.0 + (((double) this.p_tf_Yv - (double) this.p_tf_Yy) * (double) this.p_tf_Xx - ((double) this.p_tf_Xv - (double) this.p_tf_Xy) * (double) this.p_tf_Yx) * (double) this.p_tf_invdet1);
    }

    public void p_egfx_pixel_rotate_f(float revolutions)
    {
      float Yu = (float) Math.Sin(Math.IEEERemainder((double) revolutions, 1.0) * (2.0 * Math.PI));
      float num = (float) Math.Cos(Math.IEEERemainder((double) revolutions, 1.0) * (2.0 * Math.PI));
      this.p_egfx_pixel_linearTransform_f(num, Yu, -Yu, num);
    }

    public void p_egfx_coord_linearTransform_f(float Xx, float Yx, float Xy, float Yy)
    {
      float pTfXx = this.p_tf_Xx;
      float pTfYx = this.p_tf_Yx;
      float pTfXy = this.p_tf_Xy;
      float pTfYy = this.p_tf_Yy;
      this.p_tf_Xx = (float) ((double) Xx * (double) pTfXx + (double) Yx * (double) pTfXy);
      this.p_tf_Yx = (float) ((double) Xx * (double) pTfYx + (double) Yx * (double) pTfYy);
      this.p_tf_Xy = (float) ((double) Xy * (double) pTfXx + (double) Yy * (double) pTfXy);
      this.p_tf_Yy = (float) ((double) Xy * (double) pTfYx + (double) Yy * (double) pTfYy);
      this.p_tf_invdet1 = (float) (1.0 / ((double) this.p_tf_Xx * (double) this.p_tf_Yy - (double) this.p_tf_Yx * (double) this.p_tf_Xy));
      this.p_tf_invdet2 = (float) (1.0 / ((double) this.p_tf_Xu * (double) this.p_tf_Yv - (double) this.p_tf_Yu * (double) this.p_tf_Xv));
      this.p_tf_xu = (float) (1.0 + (((double) this.p_tf_Xu - (double) this.p_tf_Xx) * (double) this.p_tf_Yy - ((double) this.p_tf_Yu - (double) this.p_tf_Yx) * (double) this.p_tf_Xy) * (double) this.p_tf_invdet1);
      this.p_tf_xv = (float) ((double) this.p_tf_Xv * (double) this.p_tf_Yy - (double) this.p_tf_Yv * (double) this.p_tf_Xy) * this.p_tf_invdet1;
      this.p_tf_yu = (float) ((double) this.p_tf_Yu * (double) this.p_tf_Xx - (double) this.p_tf_Xu * (double) this.p_tf_Yx) * this.p_tf_invdet1;
      this.p_tf_yv = (float) (1.0 + (((double) this.p_tf_Yv - (double) this.p_tf_Yy) * (double) this.p_tf_Xx - ((double) this.p_tf_Xv - (double) this.p_tf_Xy) * (double) this.p_tf_Yx) * (double) this.p_tf_invdet1);
    }

    public void p_egfx_coord_rotateAbout_f(float revolutions, float centerx, float centery)
    {
      float Yx = (float) Math.Sin(Math.IEEERemainder((double) revolutions, 1.0) * (2.0 * Math.PI));
      float num = (float) Math.Cos(Math.IEEERemainder((double) revolutions, 1.0) * (2.0 * Math.PI));
      this.p_egfx_coord_move_f(centerx, centery);
      this.p_egfx_coord_linearTransform_f(num, Yx, -Yx, num);
      this.p_egfx_coord_move_f(-centerx, -centery);
    }

    public void egfx_rotateAbout(int r16, int centerx, int centery)
    {
      this.p_egfx_coord_rotateAbout_f((float) r16 * 1.52587891E-05f, (float) centerx, (float) centery);
      this.p_egfx_pixel_rotate_f((float) r16 * 1.52587891E-05f);
    }

    public int gfx_getAlignX(int bits, int xsize)
    {
      if ((bits & 1) != 0)
        return xsize >> 1;
      return (bits & 8) != 0 ? xsize : 0;
    }

    public int gfx_getAlignY(int bits, int ysize)
    {
      if ((bits & 2) != 0)
        return ysize >> 1;
      return (bits & 32) != 0 ? ysize : 0;
    }

    public void p_loadGlobalPalettes()
    {
      if (this.p_gp_loaded)
        return;
      this.p_data_istream = this.p_bi_free(this.p_data_istream) == null ? this.data_createFileInput((mrGame.MrGame.MrgString) "p", 0) : (mrGame.MrGame.ByteInput) null;
      int length1 = ++this.p_data_istream.pos <= this.p_data_istream.limit || this.p_bi_fillbuf_rev(this.p_data_istream, 1) ? (int) this.p_data_istream.buf[this.p_data_istream.pos - 1] & (int) byte.MaxValue : -1;
      this.p_globalPalettes = new int[length1][];
      for (int index1 = 0; index1 < length1; ++index1)
      {
        int length2 = ++this.p_data_istream.pos <= this.p_data_istream.limit || this.p_bi_fillbuf_rev(this.p_data_istream, 1) ? (int) this.p_data_istream.buf[this.p_data_istream.pos - 1] & (int) byte.MaxValue : -1;
        this.p_globalPalettes[index1] = new int[length2];
        for (int index2 = 1; index2 < length2; ++index2)
        {
          uint num1 = (this.p_data_istream.pos += 2) <= this.p_data_istream.limit || this.p_bi_fillbuf_rev(this.p_data_istream, 2) ? (uint) (short) ((int) this.p_data_istream.buf[this.p_data_istream.pos - 2] << 8 | (int) this.p_data_istream.buf[this.p_data_istream.pos - 1] & (int) byte.MaxValue) : uint.MaxValue;
          uint num2 = num1 & 31U;
          uint num3 = (uint) (byte) ((num2 << 3) + (num2 >> 2)) << 8;
          uint num4 = num1 >> 5 & 63U;
          uint num5 = (num3 | (uint) (byte) ((num4 << 2) + (num4 >> 4))) << 8;
          uint num6 = num1 >> 11 & 31U;
          uint num7 = num5 | (uint) (byte) ((num6 << 3) + (num6 >> 2));
          this.p_globalPalettes[index1][index2] = (int) num7 | -16777216;
        }
      }
      this.p_gp_loaded = true;
    }

    public void p_freeGlobalPalettes()
    {
      this.p_globalPalettes = (int[][]) null;
      this.p_gp_loaded = false;
    }

    public int gfx_getImageHeight(int imageindex) => this.p_allImages[imageindex].height;

    public int gfx_getImageWidth(int imageindex) => this.p_allImages[imageindex].width;

    public void gfx_loadGroup(int index)
    {
      this.p_loadGlobalPalettes();
      this.debug_text((mrGame.MrGame.MrgString) ("gfx_loadGroup " + (object) index));
      int objectId = (int) this.p_indexTable2[1344 + index];
      int length = (int) this.p_indexTable2[1344 + (index + 1)] - objectId;
      try
      {
        this.p_data_istream = this.p_bi_free(this.p_data_istream) == null ? this.data_createFileInput((mrGame.MrGame.MrgString) ("g" + (object) index), 0) : (mrGame.MrGame.ByteInput) null;
        for (int index1 = 0; index1 < length; ++index1)
        {
          this.mrg_loading(2, objectId);
          this.loadImage(objectId++);
        }
        this.p_data_istream = this.p_bi_free(this.p_data_istream);
      }
      catch (Exception ex)
      {
      }
      mrGame.MrGame.Image[] imageArray = new mrGame.MrGame.Image[length];
      Array.Copy((Array) this.p_allImages, (int) this.p_indexTable2[1344 + index], (Array) imageArray, 0, imageArray.Length);
      Array.Sort<mrGame.MrGame.Image>(imageArray);
      int[] numArray = new int[2048];
      bool flag1;
      do
      {
        int width = 0;
        int num1 = 0;
        Array.Clear((Array) numArray, 0, numArray.Length);
        foreach (mrGame.MrGame.Image image in imageArray)
        {
          if (image != null)
          {
            int num2 = image.width + 2;
            int num3 = image.height + 2;
            int index2 = 1;
            int num4 = 2048 - num2;
            while (index2 < 2046)
            {
              int num5 = numArray[index2];
              if (num5 < num4)
              {
                bool flag2 = false;
                for (int index3 = 1; index3 < num3; ++index3)
                {
                  int index4 = index2 + index3;
                  if (index4 >= 2046 || numArray[index4] != num5)
                  {
                    index2 = index4;
                    flag2 = true;
                    break;
                  }
                }
                if (!flag2)
                {
                  image.x = num5;
                  image.y = index2;
                  image.gp = true;
                  int num6 = num5 + num2;
                  for (int index5 = 0; index5 < num3; ++index5)
                    numArray[index2 + index5] = num6;
                  if (width < num6)
                    width = num6;
                  if (num1 < index2 + num3)
                  {
                    num1 = index2 + num3;
                    break;
                  }
                  break;
                }
              }
              else
                ++index2;
            }
          }
        }
        int height = num1 + 2;
        this.p_pow2_texture = true;
        Texture2D texture2D = new Texture2D(this.xnagame.graphics.GraphicsDevice, width, height);
        uint[] data1 = new uint[4]
        {
          uint.MaxValue,
          uint.MaxValue,
          uint.MaxValue,
          uint.MaxValue
        };
        texture2D.SetData<uint>(0, new Rectangle?(new Rectangle(width - 2, height - 2, 2, 2)), data1, 0, data1.Length);
        flag1 = true;
        for (int index6 = 0; index6 < imageArray.Length; ++index6)
        {
          mrGame.MrGame.Image image = imageArray[index6];
          if (image != null)
          {
            if (image.gp)
            {
              this.mrg_loading(2, objectId);
              texture2D.SetData<uint>(0, new Rectangle?(new Rectangle(image.x + 1, image.y + 1, image.width, image.height)), image.data, 0, image.data.Length);
              texture2D.SetData<uint>(0, new Rectangle?(new Rectangle(image.x + 1, image.y, image.width, 1)), image.data, 0, image.width);
              texture2D.SetData<uint>(0, new Rectangle?(new Rectangle(image.x + 1, image.y + 1 + image.height, image.width, 1)), image.data, image.width * (image.height - 1), image.width);
              uint[] data2 = new uint[image.height + 2];
              int index7 = 1;
              int index8 = 0;
              while (index7 <= image.height)
              {
                data2[index7] = image.data[index8];
                ++index7;
                index8 += image.width;
              }
              data2[0] = data2[1];
              data2[data2.Length - 1] = data2[data2.Length - 2];
              texture2D.SetData<uint>(0, new Rectangle?(new Rectangle(image.x, image.y, 1, image.height + 2)), data2, 0, data2.Length);
              int index9 = 1;
              int index10 = image.width - 1;
              while (index9 <= image.height)
              {
                data2[index9] = image.data[index10];
                ++index9;
                index10 += image.width;
              }
              data2[0] = data2[1];
              data2[data2.Length - 1] = data2[data2.Length - 2];
              texture2D.SetData<uint>(0, new Rectangle?(new Rectangle(image.x + 1 + image.width, image.y, 1, image.height + 2)), data2, 0, data2.Length);
              image.tex = texture2D;
              image.t1 = new Vector2((float) (image.x + 1) / (float) width, (float) (image.y + 1) / (float) height);
              image.t2 = new Vector2((float) image.width / (float) width, (float) image.height / (float) height);
              image.t2 += image.t1;
              image.data = (uint[]) null;
              imageArray[index6] = (mrGame.MrGame.Image) null;
            }
            else
              flag1 = false;
          }
        }
      }
      while (!flag1);
      GC.Collect();
    }

    public void gfx_unloadGroup(int index)
    {
      int index1 = (int) this.p_indexTable2[1344 + index];
      int num = (int) this.p_indexTable2[1344 + (index + 1)] - index1;
      for (int index2 = 0; index2 < num; ++index2)
      {
        if (this.p_allImages[index1] != null)
        {
          if (this.p_allImages[index1].tex != null)
          {
            this.p_allImages[index1].tex.Dispose();
            this.p_allImages[index1].tex = (Texture2D) null;
          }
          this.p_allImages[index1] = (mrGame.MrGame.Image) null;
        }
        ++index1;
      }
      GC.Collect();
    }

    public void loadImage(int index)
    {
      int w;
      int h;
      int pal;
      int len;
      bool flag;
      do
      {
        w = (this.p_data_istream.pos += 2) <= this.p_data_istream.limit || this.p_bi_fillbuf_rev(this.p_data_istream, 2) ? ((int) this.p_data_istream.buf[this.p_data_istream.pos - 2] & (int) byte.MaxValue) << 8 | (int) this.p_data_istream.buf[this.p_data_istream.pos - 1] & (int) byte.MaxValue : -1;
        h = (this.p_data_istream.pos += 2) <= this.p_data_istream.limit || this.p_bi_fillbuf_rev(this.p_data_istream, 2) ? ((int) this.p_data_istream.buf[this.p_data_istream.pos - 2] & (int) byte.MaxValue) << 8 | (int) this.p_data_istream.buf[this.p_data_istream.pos - 1] & (int) byte.MaxValue : -1;
        pal = ++this.p_data_istream.pos <= this.p_data_istream.limit || this.p_bi_fillbuf_rev(this.p_data_istream, 1) ? (int) this.p_data_istream.buf[this.p_data_istream.pos - 1] & (int) byte.MaxValue : -1;
        int num = ++this.p_data_istream.pos <= this.p_data_istream.limit || this.p_bi_fillbuf_rev(this.p_data_istream, 1) ? (int) this.p_data_istream.buf[this.p_data_istream.pos - 1] & (int) byte.MaxValue : -1;
        len = (pal == (int) byte.MaxValue ? w * 4 : w) * h;
        flag = num == 0 || num == (int) this.p_options[4] + 1;
        if (!flag)
        {
          this.debug_text((mrGame.MrGame.MrgString) "Wrong language, skipping to next img.");
          this.p_data_istream.pos += len;
          ++this.p_data_istream.pos;
        }
      }
      while (!flag);
      sbyte[] numArray = new sbyte[len];
      this.bi_getBytes(this.p_data_istream, numArray, 0, len);
      mrGame.MrGame.Image image = this.p_getImage(numArray, w, h, pal);
      this.p_allImages[index] = image;
      ++this.p_data_istream.pos;
    }

    public mrGame.MrGame.Image p_getImage(sbyte[] data, int w, int h, int pal)
    {
      mrGame.MrGame.Image image = new mrGame.MrGame.Image();
      image.width = w;
      image.height = h;
      image.size = w * h;
      if (pal != (int) byte.MaxValue)
      {
        uint[] numArray = new uint[data.Length];
        for (int index = 0; index < data.Length; ++index)
          numArray[index] = (uint) this.p_globalPalettes[pal][(int) data[index] & (int) byte.MaxValue];
        image.data = numArray;
      }
      if (pal == (int) byte.MaxValue)
      {
        uint[] numArray = new uint[data.Length / 4];
        int index1 = 0;
        int index2 = 0;
        while (index1 < numArray.Length)
        {
          uint num1 = (uint) data[index2] & (uint) byte.MaxValue;
          uint num2 = (uint) data[index2 + 1] & (uint) byte.MaxValue;
          uint num3 = (uint) data[index2 + 2] & (uint) byte.MaxValue;
          uint num4 = (uint) data[index2 + 3] & (uint) byte.MaxValue;
          uint num5 = num3 * num4 / (uint) byte.MaxValue;
          uint num6 = num2 * num4 / (uint) byte.MaxValue;
          uint num7 = num1 * num4 / (uint) byte.MaxValue;
          numArray[index1] = (uint) ((int) num4 << 24 | (int) num7 << 16 | (int) num6 << 8) | num5;
          ++index1;
          index2 += 4;
        }
        image.data = numArray;
      }
      return image;
    }

    public void gfx_drawSubImage(
      int index,
      int x,
      int y,
      int align,
      int xsize,
      int ysize,
      int xp,
      int yp)
    {
      x -= this.gfx_getAlignX(align, xsize);
      y -= this.gfx_getAlignY(align, ysize);
      if (x >= this.dynamic_X_RES || y >= this.dynamic_Y_RES || x + xsize < 0 || y + ysize < 0)
        return;
      this.p_setSubClip(x, y, xsize, ysize);
      this.gfx_drawImage(index, x - xp, y - yp, 0, 0);
      this.p_resumeClip();
    }

    public void gfx_drawImage(int imageindex, int x, int y, int align, int trans)
    {
      Texture2D tex = this.p_allImages[imageindex].tex;
      mrGame.MrGame.Image pAllImage = this.p_allImages[imageindex];
      int xsize;
      int ysize;
      if (trans == 1 || trans == 3 || trans == 6 || trans == 7)
      {
        xsize = pAllImage.height;
        ysize = pAllImage.width;
      }
      else
      {
        xsize = pAllImage.width;
        ysize = pAllImage.height;
      }
      float num1 = (float) ((double) x * (double) this.p_tf_Xx + (double) y * (double) this.p_tf_Xy + (double) this.p_tf_X1 - ((double) this.gfx_getAlignX(align, xsize) * (double) this.p_tf_Xu + (double) this.gfx_getAlignY(align, ysize) * (double) this.p_tf_Xv));
      float num2 = (float) ((double) x * (double) this.p_tf_Yx + (double) y * (double) this.p_tf_Yy + (double) this.p_tf_Y1 - ((double) this.gfx_getAlignX(align, xsize) * (double) this.p_tf_Yu + (double) this.gfx_getAlignY(align, ysize) * (double) this.p_tf_Yv));
      this.xnagame.vertices[0].Position.X = num1;
      this.xnagame.vertices[0].Position.Y = num2;
      if ((double) num1 > (double) this.dynamic_X_RES || (double) num1 + (double) xsize < 0.0 || (double) num2 > (double) this.dynamic_Y_RES || (double) num2 + (double) ysize < 0.0)
        return;
      this.xnagame.vertices[1].Position.X = num1 + (float) ((double) xsize * (double) this.p_tf_Xu + 0.0 * (double) this.p_tf_Xv);
      this.xnagame.vertices[1].Position.Y = num2 + (float) ((double) xsize * (double) this.p_tf_Yu + 0.0 * (double) this.p_tf_Yv);
      this.xnagame.vertices[2].Position.X = num1 + (float) (0.0 * (double) this.p_tf_Xu + (double) ysize * (double) this.p_tf_Xv);
      this.xnagame.vertices[2].Position.Y = num2 + (float) (0.0 * (double) this.p_tf_Yu + (double) ysize * (double) this.p_tf_Yv);
      this.xnagame.vertices[3].Position.X = num1 + (float) ((double) xsize * (double) this.p_tf_Xu + (double) ysize * (double) this.p_tf_Xv);
      this.xnagame.vertices[3].Position.Y = num2 + (float) ((double) xsize * (double) this.p_tf_Yu + (double) ysize * (double) this.p_tf_Yv);
      float x1 = pAllImage.t1.X;
      float y1 = pAllImage.t1.Y;
      float x2 = pAllImage.t2.X;
      float y2 = pAllImage.t2.Y;
      switch (trans)
      {
        case 1:
          this.xnagame.vertices[0].TextureCoordinate.X = x1;
          this.xnagame.vertices[0].TextureCoordinate.Y = y2;
          this.xnagame.vertices[1].TextureCoordinate.X = x1;
          this.xnagame.vertices[1].TextureCoordinate.Y = y1;
          this.xnagame.vertices[2].TextureCoordinate.X = x2;
          this.xnagame.vertices[2].TextureCoordinate.Y = y2;
          this.xnagame.vertices[3].TextureCoordinate.X = x2;
          this.xnagame.vertices[3].TextureCoordinate.Y = y1;
          break;
        case 2:
          this.xnagame.vertices[0].TextureCoordinate.X = x2;
          this.xnagame.vertices[0].TextureCoordinate.Y = y2;
          this.xnagame.vertices[1].TextureCoordinate.X = x1;
          this.xnagame.vertices[1].TextureCoordinate.Y = y2;
          this.xnagame.vertices[2].TextureCoordinate.X = x2;
          this.xnagame.vertices[2].TextureCoordinate.Y = y1;
          this.xnagame.vertices[3].TextureCoordinate.X = x1;
          this.xnagame.vertices[3].TextureCoordinate.Y = y1;
          break;
        case 3:
          this.xnagame.vertices[0].TextureCoordinate.X = x2;
          this.xnagame.vertices[0].TextureCoordinate.Y = y1;
          this.xnagame.vertices[1].TextureCoordinate.X = x2;
          this.xnagame.vertices[1].TextureCoordinate.Y = y2;
          this.xnagame.vertices[2].TextureCoordinate.X = x1;
          this.xnagame.vertices[2].TextureCoordinate.Y = y1;
          this.xnagame.vertices[3].TextureCoordinate.X = x1;
          this.xnagame.vertices[3].TextureCoordinate.Y = y2;
          break;
        case 4:
          this.xnagame.vertices[0].TextureCoordinate.X = x2;
          this.xnagame.vertices[0].TextureCoordinate.Y = y1;
          this.xnagame.vertices[1].TextureCoordinate.X = x1;
          this.xnagame.vertices[1].TextureCoordinate.Y = y1;
          this.xnagame.vertices[2].TextureCoordinate.X = x2;
          this.xnagame.vertices[2].TextureCoordinate.Y = y2;
          this.xnagame.vertices[3].TextureCoordinate.X = x1;
          this.xnagame.vertices[3].TextureCoordinate.Y = y2;
          break;
        case 5:
          this.xnagame.vertices[0].TextureCoordinate.X = x1;
          this.xnagame.vertices[0].TextureCoordinate.Y = y2;
          this.xnagame.vertices[1].TextureCoordinate.X = x2;
          this.xnagame.vertices[1].TextureCoordinate.Y = y2;
          this.xnagame.vertices[2].TextureCoordinate.X = x1;
          this.xnagame.vertices[2].TextureCoordinate.Y = y1;
          this.xnagame.vertices[3].TextureCoordinate.X = x2;
          this.xnagame.vertices[3].TextureCoordinate.Y = y1;
          break;
        case 6:
          this.xnagame.vertices[0].TextureCoordinate.X = x1;
          this.xnagame.vertices[0].TextureCoordinate.Y = y1;
          this.xnagame.vertices[1].TextureCoordinate.X = x1;
          this.xnagame.vertices[1].TextureCoordinate.Y = y2;
          this.xnagame.vertices[2].TextureCoordinate.X = x2;
          this.xnagame.vertices[2].TextureCoordinate.Y = y1;
          this.xnagame.vertices[3].TextureCoordinate.X = x2;
          this.xnagame.vertices[3].TextureCoordinate.Y = y2;
          break;
        case 7:
          this.xnagame.vertices[0].TextureCoordinate.X = x2;
          this.xnagame.vertices[0].TextureCoordinate.Y = y2;
          this.xnagame.vertices[1].TextureCoordinate.X = x2;
          this.xnagame.vertices[1].TextureCoordinate.Y = y1;
          this.xnagame.vertices[2].TextureCoordinate.X = x1;
          this.xnagame.vertices[2].TextureCoordinate.Y = y2;
          this.xnagame.vertices[3].TextureCoordinate.X = x1;
          this.xnagame.vertices[3].TextureCoordinate.Y = y1;
          break;
        default:
          this.xnagame.vertices[0].TextureCoordinate.X = x1;
          this.xnagame.vertices[0].TextureCoordinate.Y = y1;
          this.xnagame.vertices[1].TextureCoordinate.X = x2;
          this.xnagame.vertices[1].TextureCoordinate.Y = y1;
          this.xnagame.vertices[2].TextureCoordinate.X = x1;
          this.xnagame.vertices[2].TextureCoordinate.Y = y2;
          this.xnagame.vertices[3].TextureCoordinate.X = x2;
          this.xnagame.vertices[3].TextureCoordinate.Y = y2;
          break;
      }
      this.xnagame.graphics.GraphicsDevice.Textures[0] = (Texture) tex;
      Color color = (this.p_blendmode & 16) != 0 ? this.cFgColor : Color.White;
      this.xnagame.vertices[0].Color = color;
      this.xnagame.vertices[1].Color = color;
      this.xnagame.vertices[2].Color = color;
      this.xnagame.vertices[3].Color = color;
      this.xnagame.graphics.GraphicsDevice.DrawUserPrimitives<VertexPositionColorTexture>(PrimitiveType.TriangleStrip, this.xnagame.vertices, 0, 2);
    }

    public int gfx_getFontHeight(int font)
    {
      return (font & (int) sbyte.MaxValue) >= 3 ? (int) this.p_indexTable1[3873 + ((font & (int) sbyte.MaxValue) - 3)] : 0;
    }

    public int gfx_stringWidth(int font, mrGame.MrGame.MrgString str)
    {
      if ((font & 8192) != 0)
      {
        font &= -8193;
        str = str.toUpperCase();
      }
      return (font & (int) sbyte.MaxValue) >= 3 ? this.p_bmfont_stringWidth(font & (int) sbyte.MaxValue, str) : 0;
    }

    public void gfx_drawString(int font, mrGame.MrGame.MrgString str, int x, int y, int align)
    {
      if ((mrGame.MrGame.MrgString) null == str || str.toString() == null)
        return;
      if ((font & 8192) != 0)
      {
        font &= -8193;
        str = str.toUpperCase();
      }
      x -= this.gfx_getAlignX(align, this.gfx_stringWidth(font, str));
      y -= this.gfx_getAlignY(align, this.gfx_getFontHeight(font));
      if ((font & (int) sbyte.MaxValue) < 3)
        return;
      this.p_bmfont_drawString(font & (int) sbyte.MaxValue, str, x, y);
    }

    public int gfx_getClipX() => this.xnagame.clipRectangle.X;

    public int gfx_getClipY() => this.xnagame.clipRectangle.Y;

    public int gfx_getClipW() => this.xnagame.clipRectangle.Width;

    public int gfx_getClipH() => this.xnagame.clipRectangle.Height;

    public void gfx_setClip(int x0, int y0, int dx, int dy)
    {
      this.xnagame.clipRectangle.X = x0;
      this.xnagame.clipRectangle.Y = y0;
      this.xnagame.clipRectangle.Width = dx;
      this.xnagame.clipRectangle.Height = dy;
      this.xnagame.gfx_setClip(x0, y0, dx, dy);
    }

    public void p_setSubClip(int x, int y, int width, int height)
    {
      this.p_tempClipX = this.gfx_getClipX();
      this.p_tempClipY = this.gfx_getClipY();
      this.p_tempClipWidth = this.gfx_getClipW();
      this.p_tempClipHeight = this.gfx_getClipH();
      int pTempClipX = this.p_tempClipX;
      int pTempClipY = this.p_tempClipY;
      int pTempClipWidth = this.p_tempClipWidth;
      int pTempClipHeight = this.p_tempClipHeight;
      int num1 = x + width;
      int num2 = y + height;
      if (x < pTempClipX)
        x = pTempClipX;
      if (y < pTempClipY)
        y = pTempClipY;
      if (num1 > pTempClipWidth + pTempClipX)
        num1 = pTempClipWidth + pTempClipX;
      if (num2 > pTempClipHeight + pTempClipY)
        num2 = pTempClipHeight + pTempClipY;
      this.gfx_setClip(x, y, num1 - x, num2 - y);
    }

    public void p_resumeClip()
    {
      this.gfx_setClip(this.p_tempClipX, this.p_tempClipY, this.p_tempClipWidth, this.p_tempClipHeight);
    }

    public void gfx_fillRect(int x, int y, int w, int h)
    {
      float num1 = (float) ((double) x * (double) this.p_tf_Xx + (double) y * (double) this.p_tf_Xy) + this.p_tf_X1;
      float num2 = (float) ((double) x * (double) this.p_tf_Yx + (double) y * (double) this.p_tf_Yy) + this.p_tf_Y1;
      this.xnagame.vertices[0].Position.X = num1;
      this.xnagame.vertices[0].Position.Y = num2;
      this.xnagame.vertices[1].Position.X = num1 + (float) ((double) w * (double) this.p_tf_Xu + 0.0 * (double) this.p_tf_Xv);
      this.xnagame.vertices[1].Position.Y = num2 + (float) ((double) w * (double) this.p_tf_Yu + 0.0 * (double) this.p_tf_Yv);
      this.xnagame.vertices[2].Position.X = num1 + (float) (0.0 * (double) this.p_tf_Xu + (double) h * (double) this.p_tf_Xv);
      this.xnagame.vertices[2].Position.Y = num2 + (float) (0.0 * (double) this.p_tf_Yu + (double) h * (double) this.p_tf_Yv);
      this.xnagame.vertices[3].Position.X = num1 + (float) ((double) w * (double) this.p_tf_Xu + (double) h * (double) this.p_tf_Xv);
      this.xnagame.vertices[3].Position.Y = num2 + (float) ((double) w * (double) this.p_tf_Yu + (double) h * (double) this.p_tf_Yv);
      this.xnagame.graphics.GraphicsDevice.Textures[0] = (Texture) this.xnagame.tex;
      for (int index = 0; index < 4; ++index)
      {
        this.xnagame.vertices[index].Color = this.cFgColor;
        this.xnagame.vertices[index].TextureCoordinate = Vector2.One;
      }
      this.xnagame.graphics.GraphicsDevice.DrawUserPrimitives<VertexPositionColorTexture>(PrimitiveType.TriangleStrip, this.xnagame.vertices, 0, 2);
    }

    public void gfx_fillRectGradiant(int x, int y, int w, int h, int c1, int c2)
    {
      float num1 = (float) ((double) x * (double) this.p_tf_Xx + (double) y * (double) this.p_tf_Xy) + this.p_tf_X1;
      float num2 = (float) ((double) x * (double) this.p_tf_Yx + (double) y * (double) this.p_tf_Yy) + this.p_tf_Y1;
      this.xnagame.vertices[0].Position.X = num1;
      this.xnagame.vertices[0].Position.Y = num2;
      this.xnagame.vertices[1].Position.X = num1 + (float) ((double) w * (double) this.p_tf_Xu + 0.0 * (double) this.p_tf_Xv);
      this.xnagame.vertices[1].Position.Y = num2 + (float) ((double) w * (double) this.p_tf_Yu + 0.0 * (double) this.p_tf_Yv);
      this.xnagame.vertices[2].Position.X = num1 + (float) (0.0 * (double) this.p_tf_Xu + (double) h * (double) this.p_tf_Xv);
      this.xnagame.vertices[2].Position.Y = num2 + (float) (0.0 * (double) this.p_tf_Yu + (double) h * (double) this.p_tf_Yv);
      this.xnagame.vertices[3].Position.X = num1 + (float) ((double) w * (double) this.p_tf_Xu + (double) h * (double) this.p_tf_Xv);
      this.xnagame.vertices[3].Position.Y = num2 + (float) ((double) w * (double) this.p_tf_Yu + (double) h * (double) this.p_tf_Yv);
      this.xnagame.graphics.GraphicsDevice.Textures[0] = (Texture) this.xnagame.tex;
      this.xnagame.vertices[0].Color = this.xnagame.vertices[1].Color = new Color(c1 >> 16 & (int) byte.MaxValue, c1 >> 8 & (int) byte.MaxValue, c1 & (int) byte.MaxValue, (int) byte.MaxValue);
      this.xnagame.vertices[2].Color = this.xnagame.vertices[3].Color = new Color(c2 >> 16 & (int) byte.MaxValue, c2 >> 8 & (int) byte.MaxValue, c2 & (int) byte.MaxValue, (int) byte.MaxValue);
      for (int index = 0; index < 4; ++index)
        this.xnagame.vertices[index].TextureCoordinate = Vector2.One;
      this.xnagame.graphics.GraphicsDevice.DrawUserPrimitives<VertexPositionColorTexture>(PrimitiveType.TriangleStrip, this.xnagame.vertices, 0, 2);
    }

    public void gfx_drawHLine(int x1, int y, int x2) => this.gfx_fillRect(x1, y, x2 - x1, 1);

    public void gfx_drawVLine(int x, int y1, int y2) => this.gfx_fillRect(x, y1, 1, y2 - y1);

    public void gfx_drawRect(int x, int y, int w, int h)
    {
      float num1 = (float) ((double) x * (double) this.p_tf_Xx + (double) y * (double) this.p_tf_Xy) + this.p_tf_X1;
      float num2 = (float) ((double) x * (double) this.p_tf_Yx + (double) y * (double) this.p_tf_Yy) + this.p_tf_Y1;
      this.xnagame.vertices[0].Position.X = this.xnagame.vertices[4].Position.X = num1;
      this.xnagame.vertices[0].Position.Y = this.xnagame.vertices[4].Position.Y = num2;
      this.xnagame.vertices[1].Position.X = num1 + (float) ((double) w * (double) this.p_tf_Xu + 0.0 * (double) this.p_tf_Xv);
      this.xnagame.vertices[1].Position.Y = num2 + (float) ((double) w * (double) this.p_tf_Yu + 0.0 * (double) this.p_tf_Yv);
      this.xnagame.vertices[2].Position.X = num1 + (float) ((double) w * (double) this.p_tf_Xu + (double) h * (double) this.p_tf_Xv);
      this.xnagame.vertices[2].Position.Y = num2 + (float) ((double) w * (double) this.p_tf_Yu + (double) h * (double) this.p_tf_Yv);
      this.xnagame.vertices[3].Position.X = num1 + (float) (0.0 * (double) this.p_tf_Xu + (double) h * (double) this.p_tf_Xv);
      this.xnagame.vertices[3].Position.Y = num2 + (float) (0.0 * (double) this.p_tf_Yu + (double) h * (double) this.p_tf_Yv);
      this.xnagame.graphics.GraphicsDevice.Textures[0] = (Texture) this.xnagame.tex;
      for (int index = 0; index < 5; ++index)
      {
        this.xnagame.vertices[index].Color = this.cFgColor;
        this.xnagame.vertices[index].TextureCoordinate = Vector2.One;
      }
      this.xnagame.graphics.GraphicsDevice.DrawUserPrimitives<VertexPositionColorTexture>(PrimitiveType.LineStrip, this.xnagame.vertices, 0, 4);
    }

    public void gfx_setColorExt(int alphacolor, int blendmode)
    {
      this.p_blendmode = blendmode;
      this.fgColor = alphacolor;
      uint num1 = 0;
      uint num2 = (uint) alphacolor;
      switch (blendmode)
      {
        case 0:
          num1 = num2 | 4278190080U;
          break;
        case 1:
        case 17:
          num1 = num2;
          break;
        case 2:
        case 18:
          uint num3 = (uint) (((int) (num2 >> 24) & (int) byte.MaxValue) + 1);
          num1 = (uint) ((int) ((num2 & 16711935U) * num3 >> 8) & 16711935 | ((int) (num2 >> 8) & (int) byte.MaxValue | 16711680) * (int) num3 & -16711936);
          break;
        case 3:
          num1 = (uint) (-1 - ((int) num2 & 16777215));
          break;
      }
      this.cFgColor.PackedValue = num1 ^ (uint) (((int) num1 & (int) byte.MaxValue ^ (int) (num1 >> 16) & (int) byte.MaxValue) * 65537);
    }

    public void gfx_setColor(int color) => this.gfx_setColorExt(color | -16777216, 0);

    public int gfx_getColor() => this.fgColor;

    public void gfx_setBackgroundColor(int color)
    {
    }

    public void gfx_drawLine(int x0, int y0, int x1, int y1)
    {
      this.xnagame.vertices[0].Position.X = (float) ((double) x0 * (double) this.p_tf_Xx + (double) y0 * (double) this.p_tf_Xy) + this.p_tf_X1;
      this.xnagame.vertices[0].Position.Y = (float) ((double) x0 * (double) this.p_tf_Yx + (double) y0 * (double) this.p_tf_Yy) + this.p_tf_Y1;
      this.xnagame.vertices[1].Position.X = (float) ((double) x1 * (double) this.p_tf_Xx + (double) y1 * (double) this.p_tf_Xy) + this.p_tf_X1;
      this.xnagame.vertices[1].Position.Y = (float) ((double) x1 * (double) this.p_tf_Yx + (double) y1 * (double) this.p_tf_Yy) + this.p_tf_Y1;
      this.xnagame.graphics.GraphicsDevice.Textures[0] = (Texture) this.xnagame.tex;
      for (int index = 0; index < 2; ++index)
      {
        this.xnagame.vertices[index].Color = this.cFgColor;
        this.xnagame.vertices[index].TextureCoordinate = Vector2.One;
      }
      this.xnagame.graphics.GraphicsDevice.DrawUserPrimitives<VertexPositionColorTexture>(PrimitiveType.LineList, this.xnagame.vertices, 0, 1);
    }

    public void gfx_drawArc(int x, int y, int width, int height, int angle1, int angle2)
    {
    }

    public void gfx_fillArc(int x, int y, int width, int height, int angle1, int angle2)
    {
    }

    public void gfx_fillTriangle(int x0, int y0, int x1, int y1, int x2, int y2)
    {
      this.xnagame.vertices[0].Position.X = (float) ((double) x0 * (double) this.p_tf_Xx + (double) y0 * (double) this.p_tf_Xy) + this.p_tf_X1;
      this.xnagame.vertices[0].Position.Y = (float) ((double) x0 * (double) this.p_tf_Yx + (double) y0 * (double) this.p_tf_Yy) + this.p_tf_Y1;
      this.xnagame.vertices[1].Position.X = (float) ((double) x1 * (double) this.p_tf_Xx + (double) y1 * (double) this.p_tf_Xy) + this.p_tf_X1;
      this.xnagame.vertices[1].Position.Y = (float) ((double) x1 * (double) this.p_tf_Yx + (double) y1 * (double) this.p_tf_Yy) + this.p_tf_Y1;
      this.xnagame.vertices[2].Position.X = (float) ((double) x2 * (double) this.p_tf_Xx + (double) y2 * (double) this.p_tf_Xy) + this.p_tf_X1;
      this.xnagame.vertices[2].Position.Y = (float) ((double) x2 * (double) this.p_tf_Yx + (double) y2 * (double) this.p_tf_Yy) + this.p_tf_Y1;
      this.xnagame.graphics.GraphicsDevice.Textures[0] = (Texture) this.xnagame.tex;
      for (int index = 0; index < 3; ++index)
      {
        this.xnagame.vertices[index].Color = this.cFgColor;
        this.xnagame.vertices[index].TextureCoordinate = Vector2.One;
      }
      this.xnagame.graphics.GraphicsDevice.DrawUserPrimitives<VertexPositionColorTexture>(PrimitiveType.TriangleList, this.xnagame.vertices, 0, 1);
    }

    public void gfx_drawTriangle(int x0, int y0, int x1, int y1, int x2, int y2)
    {
      this.xnagame.vertices[3].Position.X = this.xnagame.vertices[0].Position.X = (float) ((double) x0 * (double) this.p_tf_Xx + (double) y0 * (double) this.p_tf_Xy) + this.p_tf_X1;
      this.xnagame.vertices[3].Position.Y = this.xnagame.vertices[0].Position.Y = (float) ((double) x0 * (double) this.p_tf_Yx + (double) y0 * (double) this.p_tf_Yy) + this.p_tf_Y1;
      this.xnagame.vertices[1].Position.X = (float) ((double) x1 * (double) this.p_tf_Xx + (double) y1 * (double) this.p_tf_Xy) + this.p_tf_X1;
      this.xnagame.vertices[1].Position.Y = (float) ((double) x1 * (double) this.p_tf_Yx + (double) y1 * (double) this.p_tf_Yy) + this.p_tf_Y1;
      this.xnagame.vertices[2].Position.X = (float) ((double) x2 * (double) this.p_tf_Xx + (double) y2 * (double) this.p_tf_Xy) + this.p_tf_X1;
      this.xnagame.vertices[2].Position.Y = (float) ((double) x2 * (double) this.p_tf_Yx + (double) y2 * (double) this.p_tf_Yy) + this.p_tf_Y1;
      this.xnagame.graphics.GraphicsDevice.Textures[0] = (Texture) this.xnagame.tex;
      for (int index = 0; index < 4; ++index)
      {
        this.xnagame.vertices[index].Color = this.cFgColor;
        this.xnagame.vertices[index].TextureCoordinate = Vector2.One;
      }
      this.xnagame.graphics.GraphicsDevice.DrawUserPrimitives<VertexPositionColorTexture>(PrimitiveType.LineStrip, this.xnagame.vertices, 0, 3);
    }

    public void gfx_setRenderTargetImage(int index)
    {
      this.xnagame.graphics.GraphicsDevice.SetRenderTarget((RenderTarget2D) this.p_allImages[index].tex);
      this.xnagame.basicEffect.Projection = Matrix.CreateOrthographicOffCenter(0.5f, (float) this.p_allImages[index].tex.Width + 0.5f, (float) this.p_allImages[index].tex.Height + 0.5f, 0.5f, 0.0f, 1f);
      this.xnagame.basicEffect.CurrentTechnique.Passes[0].Apply();
    }

    public void gfx_setRenderTarget_DISPLAY(int index)
    {
      this.xnagame.graphics.GraphicsDevice.SetRenderTarget((RenderTarget2D) null);
      this.xnagame.basicEffect.Projection = Matrix.CreateOrthographicOffCenter(0.5f, (float) this.xnagame.graphics.PreferredBackBufferWidth + 0.5f, (float) this.xnagame.graphics.PreferredBackBufferHeight + 0.5f, 0.5f, 0.0f, 1f);
    }

    public void gfx_createMutableImage(int index, int w, int h)
    {
      this.p_allImages[index] = new mrGame.MrGame.Image();
      this.p_allImages[index].tex = (Texture2D) new RenderTarget2D(this.xnagame.graphics.GraphicsDevice, w, h);
      this.p_allImages[index].tex.Name = "Mutable";
      this.p_allImages[index].width = w;
      this.p_allImages[index].height = h;
      this.p_allImages[index].t1 = Vector2.Zero;
      this.p_allImages[index].t2 = Vector2.One;
    }

    public void gfx_freeMutableImage(int index)
    {
      this.p_allImages[index].tex.Dispose();
      this.p_allImages[index].tex = (Texture2D) null;
      this.p_allImages[index] = (mrGame.MrGame.Image) null;
    }

    public void gfx_triangleStrip(int[] coords, int[] colors, int imageindex, int[] texcoords)
    {
      int length = coords.Length >> 1;
      VertexPositionColorTexture[] vertexData = new VertexPositionColorTexture[length];
      int index1 = 0;
      int num1 = 0;
      for (; index1 < length; ++index1)
      {
        int[] numArray1 = coords;
        int index2 = num1;
        int num2 = index2 + 1;
        int num3 = numArray1[index2];
        int[] numArray2 = coords;
        int index3 = num2;
        num1 = index3 + 1;
        int num4 = numArray2[index3];
        vertexData[index1].Position = new Vector3((float) ((double) num3 * (double) this.p_tf_Xx + (double) num4 * (double) this.p_tf_Xy) + this.p_tf_X1, (float) ((double) num3 * (double) this.p_tf_Yx + (double) num4 * (double) this.p_tf_Yy) + this.p_tf_Y1, 0.0f);
      }
      if (colors != null)
      {
        for (int index4 = 0; index4 < length; ++index4)
        {
          Color color1 = new Color();
          uint num5 = 0;
          uint color2 = (uint) colors[index4];
          if (texcoords != null)
          {
            switch (this.p_blendmode)
            {
              case 17:
                num5 = color2;
                break;
              case 18:
                uint num6 = (uint) (((int) (color2 >> 24) & (int) byte.MaxValue) + 1);
                num5 = (uint) ((int) ((color2 & 16711935U) * num6 >> 8) & 16711935 | ((int) (color2 >> 8) & (int) byte.MaxValue | 16711680) * (int) num6 & -16711936);
                break;
              default:
                num5 = uint.MaxValue;
                break;
            }
          }
          else
          {
            uint num7 = (uint) (((int) (color2 >> 24) & (int) byte.MaxValue) + 1);
            switch (this.p_blendmode)
            {
              case 0:
                num5 = color2 | 4278190080U;
                break;
              case 1:
                num5 = color2;
                break;
              case 2:
                num5 = (uint) ((int) ((color2 & 16711935U) * num7 >> 8) & 16711935 | ((int) (color2 >> 8) & (int) byte.MaxValue | 16711680) * (int) num7 & -16711936);
                break;
              case 3:
                num5 = (uint) (-1 - ((int) color2 & 16777215));
                break;
              case 17:
                num5 = color2;
                break;
              case 18:
                num5 = (uint) ((int) ((color2 & 16711935U) * num7 >> 8) & 16711935 | ((int) (color2 >> 8) & (int) byte.MaxValue | 16711680) * (int) num7 & -16711936);
                break;
            }
          }
          color1.PackedValue = num5 ^ (uint) (((int) num5 & (int) byte.MaxValue ^ (int) (num5 >> 16) & (int) byte.MaxValue) * 65537);
          vertexData[index4].Color = color1;
        }
      }
      else
      {
        for (int index5 = 0; index5 < length; ++index5)
          vertexData[index5].Color = (this.p_blendmode & 16) != 0 ? this.cFgColor : Color.White;
      }
      if (imageindex >= 0)
      {
        mrGame.MrGame.Image pAllImage = this.p_allImages[imageindex];
        this.xnagame.graphics.GraphicsDevice.Textures[0] = (Texture) pAllImage.tex;
        if (texcoords != null)
        {
          float x = pAllImage.t1.X;
          float y = pAllImage.t1.Y;
          float num8 = pAllImage.t2.X - x;
          float num9 = pAllImage.t2.Y - y;
          int index6 = 0;
          int num10 = 0;
          for (; index6 < length; ++index6)
          {
            int[] numArray3 = texcoords;
            int index7 = num10;
            int num11 = index7 + 1;
            int num12 = numArray3[index7];
            int[] numArray4 = texcoords;
            int index8 = num11;
            num10 = index8 + 1;
            int num13 = numArray4[index8];
            vertexData[index6].TextureCoordinate = new Vector2(x + (float) num12 * 1.52587891E-05f * num8, y + (float) num13 * 1.52587891E-05f * num9);
          }
        }
        else
        {
          for (int index9 = 0; index9 < length; ++index9)
            vertexData[index9].TextureCoordinate = Vector2.Zero;
        }
      }
      else
      {
        this.xnagame.graphics.GraphicsDevice.Textures[0] = (Texture) this.xnagame.tex;
        for (int index10 = 0; index10 < length; ++index10)
          vertexData[index10].TextureCoordinate = Vector2.Zero;
      }
      this.xnagame.graphics.GraphicsDevice.DrawUserPrimitives<VertexPositionColorTexture>(PrimitiveType.TriangleStrip, vertexData, 0, length >> 1);
    }

    public void p_loadOptions()
    {
      this.p_options = this.mrg_loadData((mrGame.MrGame.MrgString) "ropt");
      if (this.p_options == null || this.p_options.Length != 11)
      {
        if (this.p_options != null)
          this.p_options = (sbyte[]) null;
        this.p_options = new sbyte[11];
        for (int index = 0; index < 11; ++index)
          this.p_options[index] = (sbyte) 0;
        this.p_options[0] = (sbyte) 1;
        this.debug_text((mrGame.MrGame.MrgString) "soundoption index: ");
        this.p_options[1] = (sbyte) 1;
        this.debug_text((mrGame.MrGame.MrgString) ("vibraoption index: " + (object) 1));
        this.p_options[2] = (sbyte) 1;
        this.debug_text((mrGame.MrGame.MrgString) ("tiltoption index: " + (object) 2));
        this.p_options[4] = (sbyte) -1;
        this.debug_text((mrGame.MrGame.MrgString) ("options size: " + (object) 11));
      }
      this.p_setPhoneLanguage();
    }

    public void mrg_saveOptions() => this.mrg_saveData((mrGame.MrGame.MrgString) "ropt", this.p_options);

    public void p_freeIndexTables()
    {
      this.p_indexTable1 = (sbyte[]) null;
      this.p_indexTable2 = (short[]) null;
      this.p_indexTable3 = (int[]) null;
    }

    public void p_loadIndexTables()
    {
      this.p_data_istream = this.p_bi_free(this.p_data_istream) == null 
                ? this.data_createFileInput((mrGame.MrGame.MrgString) "i", 0) 
                : (mrGame.MrGame.ByteInput) null;

      this.p_indexTable1 = new sbyte[3909];

      this.bi_getBytes(this.p_data_istream, this.p_indexTable1, 0, 3909);

      this.p_indexTable2 = new short[2962];

    for (int index = 0; index < 2962; ++index)
    {
        if (this.p_data_istream != null)
        {
            this.p_indexTable2[index] = (this.p_data_istream.pos += 2) <= this.p_data_istream.limit ||
                this.p_bi_fillbuf_rev(this.p_data_istream, 2)
                ? (short)((int)this.p_data_istream.buf[this.p_data_istream.pos - 2] << 8 |
                    (int)this.p_data_istream.buf[this.p_data_istream.pos - 1] & (int)byte.MaxValue)
                : (short)-1;
        }
    }
      
      this.p_indexTable3 = new int[425];

            for (int index = 0; index < 425; ++index)
            {
                if (this.p_data_istream != null)
                {
                  this.p_indexTable3[index] = (this.p_data_istream.pos += 4) <= this.p_data_istream.limit
                    || this.p_bi_fillbuf_rev(this.p_data_istream, 4) 
                    ? (int)this.p_data_istream.buf[this.p_data_istream.pos - 4] << 24 
                        | ((int)this.p_data_istream.buf[this.p_data_istream.pos - 3] & (int)byte.MaxValue) << 16 
                        | ((int)this.p_data_istream.buf[this.p_data_istream.pos - 2] & (int)byte.MaxValue) << 8 
                        | (int)this.p_data_istream.buf[this.p_data_istream.pos - 1] & (int)byte.MaxValue
                    : -1;
                }
            }
      this.p_data_istream = this.p_bi_free(this.p_data_istream);
    }

    public void sizeChanged(int w, int h)
    {
      this.dynamic_X_RES = w;
      this.dynamic_Y_RES = h;
      this.repaintAll = true;
      if (!this.p_mainGroupsLoaded)
      {
        this.p_sizeChangedBeforeMainGroupsLoaded = true;
      }
      else
      {
        this.game_resolutionChanged();
        int inputHandleFlags = this.p_tb_inputHandleFlags;
        int confirmHandleFlags = this.p_tb_backupConfirmHandleFlags;
        if (!this.p_gameDisplay)
          this.p_em_resolutionChanged();
        this.p_tb_inputHandleFlags = inputHandleFlags;
        if (this.p_em_confirming)
        {
          this.p_em_confirming = false;
          this.em_confirm(this.p_em_confirmElement, true);
        }
        this.p_tb_backupConfirmHandleFlags = confirmHandleFlags;
      }
    }

    public void p_realPaint()
    {
      this.p_egfx_sp = 0;
      this.egfx_reset();
      if (this.repaintAll)
        this.gfx_setClip(0, 0, this.dynamic_X_RES, this.dynamic_Y_RES);
      this.p_eg_guiPainted = false;
      if (this.p_forcedPaint)
      {
        if (this.p_lb_fillScreen)
        {
          mrGame.MrGame.MrgString pAllText = this.p_allTexts[19];
          for (int index = 0; index < 1 + this.p_loadingBoxCounter % 3; ++index)
            pAllText += (mrGame.MrGame.MrgString) ".";
          ++this.p_loadingBoxCounter;
          int num = this.gfx_stringWidth(0, this.p_allTexts[19] + (mrGame.MrGame.MrgString) "...");
          int w = num + (num >> 2);
          int fontHeight = this.gfx_getFontHeight(0);
          int y = (this.dynamic_Y_RES >> 1) - (fontHeight >> 1) - fontHeight;
          this.gfx_setColor(0);
          this.gfx_fillRect((this.dynamic_X_RES >> 1) - (w >> 1) - 1, y + 2, w, fontHeight << 1);
          this.gfx_setColor(7829367);
          this.gfx_fillRect((this.dynamic_X_RES >> 1) - (w >> 1), y, w, fontHeight << 1);
          this.gfx_setColor(16777215);
          this.gfx_drawRect((this.dynamic_X_RES >> 1) - (w >> 1), y, w, fontHeight << 1);
          this.gfx_drawString(0, pAllText, (this.dynamic_X_RES >> 1) - (this.gfx_stringWidth(0, this.p_allTexts[19] + (mrGame.MrGame.MrgString) "...") >> 1), this.dynamic_Y_RES >> 1, 36);
          this.p_lb_fillScreen = false;
        }
        else
          this.game_forcedPaint();
      }
      else if (!this.p_gameDisplay)
        this.menu_paint();
      else
        this.game_paint();
      if (this.p_eg_guiPainted)
        return;
      this.p_eg_paint();
    }

    public void mrg_loading(int callerId, int objectId)
    {
      this.mrp_doTime();
      long num = (long) this.p_xna_getCurrentMS() - this.p_lastloadtime;
      if (num >= 0L && num < 50L || !this.mainTextLoaded)
        return;
      this.mrg_setSoftkeyText1((mrGame.MrGame.MrgString) " ");
      this.mrg_setSoftkeyText2((mrGame.MrGame.MrgString) " ");
      if (this.p_mainGroupsLoaded)
        this.game_loadingCallback(callerId, objectId);
      this.repaintAll = true;
      this.p_lastloadtime = (long) this.p_xna_getCurrentMS();
    }

    public void mrg_drawLoadingBox()
    {
      this.p_lb_fillScreen = true;
      this.mrg_forcePaintNow();
    }

    public void hideNotify() => this.p_processHideNotifyNextFrame = true;

    public void safe_hideNotify()
    {
      this.game_hideNotify();
      if (this.p_em_introMode && !this.p_em_confirming && !this.p_initializingState)
        this.mrp_keyPressed((int) this.p_indexTable2[6] - 10);
      this.repaintAll = true;
      this.sfx_pauseAll();
      if (!this.p_gameDisplay)
        return;
      int num = this.p_initializingState ? 1 : 0;
    }

    public void showNotify() => this.p_processShowNotifyNextFrame = true;

    public void safe_showNotify()
    {
      this.sfx_unpauseAll();
      if (!this.p_initializingState)
        this.game_showNotify();
      this.mrg_resetKeys();
      this.repaintAll = true;
      this.repaintScreen = true;
      this.sfx_unpauseAll();
      if (!this.p_em_introMode || this.p_em_confirming || this.p_initializingState)
        return;
      this.mrp_keyPressed((int) this.p_indexTable2[6] - 10);
    }

    public bool mrg_isPointerOnSoftkey1()
    {
      return this.p_touchdata[this.p_mt_last].upy > this.dynamic_Y_RES - 1 - this.gfx_getFontHeight(3) && this.p_touchdata[this.p_mt_last].upx > (this.dynamic_X_RES >> 1) + (this.gfx_getFontHeight(3) << 1);
    }

    public bool mrg_isPointerOnSoftkey2()
    {
      return this.p_touchdata[this.p_mt_last].upy > this.dynamic_Y_RES - 1 - this.gfx_getFontHeight(3) && this.p_touchdata[this.p_mt_last].upx < (this.dynamic_X_RES >> 1) - (this.gfx_getFontHeight(3) << 1);
    }

    public bool p_bi_fillbuf_fwd(mrGame.MrGame.ByteInput bi, int bytes)
    {
      bi.fillbuf(bytes);
      return bi.pos + bytes <= bi.limit;
    }

    public bool p_bi_fillbuf_rev(mrGame.MrGame.ByteInput bi, int bytes)
    {
      bi.pos -= bytes;
      bi.fillbuf(bytes);
      if (bi.pos + bytes > bi.limit)
        return false;
      bi.pos += bytes;
      return true;
    }

    public mrGame.MrGame.MrgString bi_getString(mrGame.MrGame.ByteInput bi)
    {
      mrGame.MrGame.MrgString mrgString = (mrGame.MrGame.MrgString) "";
      int num1 = bi.pos + 2 <= bi.limit || this.p_bi_fillbuf_fwd(bi, 2) ? ((int) bi.buf[bi.pos] & (int) byte.MaxValue) << 8 | (int) bi.buf[bi.pos + 1] & (int) byte.MaxValue : -1;
      if (num1 < 0 || bi.pos + (num1 + 2) > bi.limit && !this.p_bi_fillbuf_fwd(bi, num1 + 2))
        return (mrGame.MrGame.MrgString) null;
      bi.pos += 2;
      while (num1 > 0)
      {
        int num2 = (int) bi.buf[bi.pos++] & (int) byte.MaxValue;
        --num1;
        int num3 = (num2 & 128) != 0 ? ((num2 & 32) != 0 ? ((num2 & 16) != 0 ? 3 : 2) : 1) : 0;
        int num4 = num2 & (int) sbyte.MaxValue >> num3;
        while (num3-- > 0)
        {
          int num5 = (int) bi.buf[bi.pos++] & (int) byte.MaxValue;
          --num1;
          num4 = num4 << 6 | num5 & 63;
        }
        mrgString += (mrGame.MrGame.MrgString) (char) num4;
      }
      return mrgString;
    }

    public int bi_getBytes(mrGame.MrGame.ByteInput bi, sbyte[] arr, int start, int len)
    {
        int bytes1 = 0;

        if (bi == null)
        {
            Debug.WriteLine("[error] bi_getBytes problem: bi is null!");
            return bytes1;
        }

      int length;
      for (; len > 0; len -= length)
      {
        int bytes2 = 4096 < len ? 4096 : len;
        if (bi.pos + bytes2 > bi.limit)
          this.p_bi_fillbuf_fwd(bi, bytes2);
        length = bi.limit - bi.pos;
        if (length > len)
          length = len;
        if (length > 0)
        {
          Array.Copy((Array) bi.buf, bi.pos, (Array) arr, start + bytes1, length);
          bi.pos += length;
          bytes1 += length;
        }
        else
          break;
      }
      return bytes1;
    }

    public mrGame.MrGame.ByteInput p_bi_free(mrGame.MrGame.ByteInput bi)
    {
      if (bi != null)
        bi = bi.close();
      bi = (mrGame.MrGame.ByteInput) null;
      return bi;
    }

    public void p_data_init() => this.p_data_istream = (mrGame.MrGame.ByteInput) null;

    public void p_data_free() => this.p_data_istream = this.p_bi_free(this.p_data_istream);

    public mrGame.MrGame.ByteInput data_createFileInput(mrGame.MrGame.MrgString filename, int skip)
    {
      try
      {
        Stream stream = TitleContainer.OpenStream(filename.toString());
        stream.Seek((long) skip, SeekOrigin.Begin);
        mrGame.MrGame.DataByteInput fileInput = new mrGame.MrGame.DataByteInput();
        fileInput.stream = stream;
        fileInput.buf = new sbyte[4096];
        fileInput.limit = 0;
        fileInput.pos = 0;
        return (mrGame.MrGame.ByteInput) fileInput;
      }
      catch (FileNotFoundException ex)
      {
        return (mrGame.MrGame.ByteInput) null;
      }
    }

    public bool mrg_saveData(mrGame.MrGame.MrgString rmsId, sbyte[] data)
    {
      IsolatedStorageFileStream storageFileStream;
      try
      {
        storageFileStream = IsolatedStorageFile.GetUserStoreForApplication().OpenFile(rmsId.toString(), FileMode.OpenOrCreate);
      }
      catch (IsolatedStorageException ex)
      {
        return false;
      }
      if (storageFileStream == null)
        return false;
      byte[] bytes = BitConverter.GetBytes(data.Length);
      storageFileStream.Write(bytes, 0, 4);
      byte[] numArray = new byte[data.Length];
      Buffer.BlockCopy((Array) data, 0, (Array) numArray, 0, data.Length);
      storageFileStream.Write(numArray, 0, data.Length);
      storageFileStream.Flush();//.Close();
      return true;
    }

    public sbyte[] mrg_loadData(mrGame.MrGame.MrgString rmsId)
    {
      IsolatedStorageFileStream storageFileStream;
      try
      {
        if (!IsolatedStorageFile.GetUserStoreForApplication().FileExists(rmsId.toString()))
          return (sbyte[]) null;
        storageFileStream = IsolatedStorageFile.GetUserStoreForApplication().OpenFile(rmsId.toString(), FileMode.Open);
      }
      catch (IsolatedStorageException ex)
      {
        return (sbyte[]) null;
      }
      if (storageFileStream == null)
        return (sbyte[]) null;
      byte[] buffer = new byte[4];
      storageFileStream.Read(buffer, 0, 4);
      int int32 = BitConverter.ToInt32(buffer, 0);
      byte[] numArray = new byte[int32];
      storageFileStream.Read(numArray, 0, int32);
      storageFileStream.Flush();
      sbyte[] dst = new sbyte[numArray.Length];
      Buffer.BlockCopy((Array) numArray, 0, (Array) dst, 0, numArray.Length);
      return dst;
    }

    public void mrg_eraseData(mrGame.MrGame.MrgString rmsId)
    {
      IsolatedStorageFile.GetUserStoreForApplication().DeleteFile(rmsId.toString());
    }

        public void p_resetRecordStore()
        {
            //IsolatedStorageFile.GetUserStoreForApplication().Remove();
        }

        public void data_readFile(mrGame.MrGame.MrgString filename, int start, int len, sbyte[] dest)
    {
      this.p_data_istream = this.p_bi_free(this.p_data_istream) == null ? this.data_createFileInput(filename, start) : (mrGame.MrGame.ByteInput) null;
      this.bi_getBytes(this.p_data_istream, dest, start, len);
      this.p_data_istream = this.p_bi_free(this.p_data_istream);
    }

    public sbyte[] p_getFile_byte(int group, int filepos, int filesize, sbyte[] bytetable)
    {
      if (bytetable == null)
        bytetable = new sbyte[filesize];
      this.p_data_istream = this.p_bi_free(this.p_data_istream) == null ? this.data_createFileInput((mrGame.MrGame.MrgString) ("b" + (object) group), filepos) : (mrGame.MrGame.ByteInput) null;
      this.bi_getBytes(this.p_data_istream, bytetable, 0, filesize);
      this.p_data_istream = this.p_bi_free(this.p_data_istream);
      return bytetable;
    }

    public int[] p_getFile_int(int group, int filepos, int filesize, int[] inttable)
    {
      if (inttable == null)
        inttable = new int[filesize >> 2];
      this.p_data_istream = this.p_bi_free(this.p_data_istream) == null ? this.data_createFileInput((mrGame.MrGame.MrgString) ("b" + (object) group), filepos) : (mrGame.MrGame.ByteInput) null;
      for (int index = 0; index < filesize >> 2; ++index)
        inttable[index] = (this.p_data_istream.pos += 4) <= this.p_data_istream.limit || this.p_bi_fillbuf_rev(this.p_data_istream, 4) ? (int) this.p_data_istream.buf[this.p_data_istream.pos - 4] << 24 | ((int) this.p_data_istream.buf[this.p_data_istream.pos - 3] & (int) byte.MaxValue) << 16 | ((int) this.p_data_istream.buf[this.p_data_istream.pos - 2] & (int) byte.MaxValue) << 8 | (int) this.p_data_istream.buf[this.p_data_istream.pos - 1] & (int) byte.MaxValue : -1;
      this.p_data_istream = this.p_bi_free(this.p_data_istream);
      return inttable;
    }

    public short[] p_getFile_short(int group, int filepos, int filesize, short[] shorttable)
    {
      if (shorttable == null)
        shorttable = new short[filesize >> 1];
      this.p_data_istream = this.p_bi_free(this.p_data_istream) == null ? this.data_createFileInput((mrGame.MrGame.MrgString) ("b" + (object) group), filepos) : (mrGame.MrGame.ByteInput) null;
      for (int index = 0; index < filesize >> 1; ++index)
        shorttable[index] = (this.p_data_istream.pos += 2) <= this.p_data_istream.limit || this.p_bi_fillbuf_rev(this.p_data_istream, 2) ? (short) ((int) this.p_data_istream.buf[this.p_data_istream.pos - 2] << 8 | (int) this.p_data_istream.buf[this.p_data_istream.pos - 1] & (int) byte.MaxValue) : (short) -1;
      this.p_data_istream = this.p_bi_free(this.p_data_istream);
      return shorttable;
    }

    public void be_newArray()
    {
      if (this.p_binaryWriter != null)
        this.be_close();
      this.p_binaryWriter = new BinaryWriter((Stream) new MemoryStream(1024), Encoding.UTF8);
    }

    public void be_writeInt(int value)
    {
      this.p_binaryWriter.Write((byte) (value >> 24));
      this.p_binaryWriter.Write((byte) (value >> 16));
      this.p_binaryWriter.Write((byte) (value >> 8));
      this.p_binaryWriter.Write((byte) value);
    }

    public void be_writeShort(int value)
    {
      this.p_binaryWriter.Write((byte) (value >> 8));
      this.p_binaryWriter.Write((byte) value);
    }

    public void be_writeByte(int value) => this.p_binaryWriter.Write((byte) value);

    public void be_writeBoolean(bool value)
    {
      this.p_binaryWriter.Write(value ? (byte) 1 : (byte) 0);
    }

    public void be_writeString(mrGame.MrGame.MrgString str)
    {
      int num1 = str.length();
      int num2 = 0;
      for (int index = 0; index < num1; ++index)
      {
        char ch = str.charAt(index);
        if (ch >= '\u0001' && ch <= '\u007F')
          ++num2;
        else if (ch > '\u07FF')
          num2 += 3;
        else
          num2 += 2;
      }
      this.be_writeShort((int) (short) num2);
      for (int index = 0; index < num1; ++index)
      {
        char ch = str.charAt(index);
        if (ch >= '\u0001' && ch <= '\u007F')
          this.p_binaryWriter.Write((byte) ch);
        else if (ch > '\u07FF')
        {
          this.p_binaryWriter.Write((byte) (224 | (int) ch >> 12 & 15));
          this.p_binaryWriter.Write((byte) (128 | (int) ch >> 6 & 63));
          this.p_binaryWriter.Write((byte) (128 | (int) ch & 63));
        }
        else
        {
          this.p_binaryWriter.Write((byte) (192 | (int) ch >> 6 & 31));
          this.p_binaryWriter.Write((byte) (128 | (int) ch & 63));
        }
      }
    }

    public sbyte[] be_getByteArray()
    {
      this.p_binaryWriter.Flush();
      byte[] array = ((MemoryStream) this.p_binaryWriter.BaseStream).ToArray();
      sbyte[] dst = new sbyte[array.Length];
      Buffer.BlockCopy((Array) array, 0, (Array) dst, 0, array.Length);
      return dst;
    }

    public void be_close()
    {
      this.p_binaryWriter.Flush();
      this.p_binaryWriter.Dispose();
      this.p_binaryWriter = (BinaryWriter) null;
    }

    public mrGame.MrGame.ByteInput byte_array_createInput(sbyte[] a)
    {
      return new mrGame.MrGame.ByteInput()
      {
        buf = a,
        pos = 0,
        flags = 0,
        limit = a.Length
      };
    }

    public void p_changeLanguage(sbyte languageIndex)
    {
      this.p_options[4] = languageIndex;
      for (int groupIndex = 0; groupIndex < 4; ++groupIndex)
      {
        if (this.p_allTexts[(int) this.p_indexTable2[1339 + groupIndex]] != (mrGame.MrGame.MrgString) null)
        {
          this.p_allTexts[(int) this.p_indexTable2[1339 + groupIndex]] = (mrGame.MrGame.MrgString) null;
          this.txt_loadGroup(groupIndex);
        }
      }
    }

    public void p_setPhoneLanguage()
    {
      mrGame.MrGame.MrgString mrgString = new mrGame.MrGame.MrgString(CultureInfo.CurrentUICulture.ToString());
      this.debug_text((mrGame.MrGame.MrgString) "phone locale: [" + mrgString + (mrGame.MrGame.MrgString) "]");
      for (sbyte index = 0; index < (sbyte) 5; ++index)
      {
        if (mrgString.toUpperCase().startsWith(this.p_localelist[(int) index]))
        {
          this.p_options[4] = index;
          return;
        }
      }
      this.p_options[4] = (sbyte) 0;
    }

    public void txt_unloadGroup(int groupIndex)
    {
      this.debug_text((mrGame.MrGame.MrgString) ("unload text group: " + (object) groupIndex));
      for (int index = (int) this.p_indexTable2[1339 + groupIndex]; index < (int) this.p_indexTable2[1339 + (groupIndex + 1)]; ++index)
        this.p_allTexts[index] = (mrGame.MrGame.MrgString) null;
    }

    public void txt_loadGroup(int groupIndex)
    {
      this.debug_text((mrGame.MrGame.MrgString) ("load text group: " + (object) groupIndex));
      if (this.p_allTexts[(int) this.p_indexTable2[1339 + groupIndex]] != (mrGame.MrGame.MrgString) null)
      {
        this.debug_text((mrGame.MrGame.MrgString) ("textgroup already loaded " + (object) groupIndex + ". not p_loading"));
      }
      else
      {
        try
        {
          this.p_data_istream = this.p_bi_free(this.p_data_istream) == null ? this.data_createFileInput((mrGame.MrGame.MrgString) "l", this.p_indexTable3[groupIndex + (int) this.p_options[4] * 4]) : (mrGame.MrGame.ByteInput) null;
          for (int index = (int) this.p_indexTable2[1339 + groupIndex]; index < (int) this.p_indexTable2[1339 + (groupIndex + 1)]; ++index)
          {
            this.p_allTexts[index] = this.bi_getString(this.p_data_istream);
            this.debug_text((mrGame.MrGame.MrgString) ("text[" + (object) index + "] loaded: ") + this.p_allTexts[index]);
          }
          this.p_data_istream = this.p_bi_free(this.p_data_istream);
        }
        catch (Exception ex)
        {
        }
      }
    }

    public mrGame.MrGame.MrgString txt_stringParam(mrGame.MrGame.MrgString s, mrGame.MrGame.MrgString p1, int n)
    {
      mrGame.MrGame.MrgString needle = (mrGame.MrGame.MrgString) ("%" + (object) n);
      int to = s.indexOf(needle);
      return to == -1 ? s : s.substring(0, to) + p1 + s.substring(to + needle.length(), s.length());
    }

    public mrGame.MrGame.MrgString txt_stringParam(mrGame.MrGame.MrgString s, mrGame.MrGame.MrgString[] strings)
    {
      for (int index = 0; index < strings.Length; ++index)
        s = this.txt_stringParam(s, strings[index], index + 1);
      return s;
    }

    public void mrg_resetKeys()
    {
      this.debug_text((mrGame.MrGame.MrgString) "mrg_resetKeys()");
      this.p_keyCounter = 0;
      for (int index = 0; index < 80; ++index)
        this.p_keys[index] = false;
    }

    public void keyPressed(int keyCode)
    {
      if (keyCode + 10 >= 80 | keyCode < -10)
        return;
      this.p_newKeyEvent = true;
      if (this.p_keyCounter >= 19)
        this.mrg_resetKeys();
      keyCode += 10;
      this.p_keyBuffer[this.p_keyCounter] = keyCode;
      this.p_keyTypeBuffer[this.p_keyCounter] = true;
      ++this.p_keyCounter;
    }

    public void keyReleased(int keyCode)
    {
      if (keyCode + 10 >= 80 | keyCode < -10)
        return;
      this.p_newKeyEvent = true;
      if (this.p_keyCounter >= 19)
        this.mrg_resetKeys();
      keyCode += 10;
      this.p_keyBuffer[this.p_keyCounter] = keyCode;
      this.p_keyTypeBuffer[this.p_keyCounter] = false;
      ++this.p_keyCounter;
    }

    public void p_runKeyEvents()
    {
      for (int index1 = 0; index1 < this.p_keyCounter; ++index1)
      {
        int index2 = this.p_keyBuffer[index1];
        if (this.p_keyTypeBuffer[index1])
        {
          this.p_keys[index2] = true;
          if (this.p_tb_inputHandleFlags == 0 || this.p_tb_inputHandleFlags != 0 && !this.p_tb_keyPressed(index2))
          {
            this.p_eg_eventRegistered = false;
            this.p_eg_pressEventRegistered = false;
            if (!this.p_eg_pressingGuiSoftkey)
            {
              if (this.mrg_isKey(index2, 57))
                this.p_eg_pointerPressed();
              else
                this.p_eg_keyPressed(index2);
            }
            else
              this.p_eg_pressingGuiSoftkey = false;
            if (this.p_eg_eventRegistered && (this.p_eg_focusElement != -1 || this.p_eg_pressEventRegistered))
              this.debug_text((mrGame.MrGame.MrgString) "Key event caught by GUI!");
            else if (!this.p_gameDisplay)
              this.menu_keyPressed(index2);
            else
              this.game_keyPressed(index2);
          }
        }
        else if (this.p_keys[index2])
        {
          this.p_keys[index2] = false;
          this.p_eg_eventRegistered = false;
          if (this.mrg_isKey(index2, 57))
            this.p_eg_pointerReleased();
          else
            this.p_eg_keyReleased(index2);
          if (!this.p_eg_eventRegistered || this.p_eg_focusElement == -1)
          {
            if (!this.p_gameDisplay)
              this.menu_keyReleased(index2);
            else
              this.game_keyReleased(index2);
          }
        }
      }
      this.p_keyCounter = 0;
    }

    public bool mrg_isKey(int gameKeyCode)
    {
      if (gameKeyCode < 65536)
      {
        if (gameKeyCode < 80)
          return this.p_keys[gameKeyCode];
        this.debug_text((mrGame.MrGame.MrgString) "ERROR mrg_isKey(int gameKeyCode) out of bounds");
      }
      else
      {
        for (int index1 = 0; index1 < gameKeyCode >> 16; ++index1)
        {
          int index2 = (int) this.p_indexTable2[(gameKeyCode & (int) ushort.MaxValue) + index1];
          if (index2 < 80 && this.p_keys[index2])
            return true;
        }
      }
      return false;
    }

    public bool mrg_isKey(int keyCode, int gameKeyCode)
    {
      if (gameKeyCode < 65536)
        return keyCode == gameKeyCode;
      for (int index = 0; index < gameKeyCode >> 16; ++index)
      {
        if ((int) this.p_indexTable2[(gameKeyCode & (int) ushort.MaxValue) + index] == keyCode)
          return true;
      }
      return false;
    }

    public void mrp_multitouch_reset()
    {
      this.p_mt_first = 0;
      this.p_mt_secondary = 0;
      this.p_mt_last = 0;
      this.p_mt_last_if_down = 0;
      this.p_mt_count = 0;
      for (int index = 0; index <= 8; ++index)
      {
        this.p_touchdata[index].dnt = this.p_touchdata[index].upt = (long) (this.p_touchdata[index].dnx = this.p_touchdata[index].dny = this.p_touchdata[index].upx = this.p_touchdata[index].upy = this.p_touchdata[index].tid = -1);
        this.p_touchdata[index].state = 0;
      }
    }

    public void mrp_multitouch_init()
    {
      if (this.p_multitouch_initialized)
        return;
      this.p_touchdata = new mrGame.MrGame.EmergeTouch[9];
      for (int index = 0; index <= 8; ++index)
        this.p_touchdata[index] = new mrGame.MrGame.EmergeTouch();
      this.mrp_multitouch_reset();
      this.p_multitouch_initialized = true;
      this.debug_text((mrGame.MrGame.MrgString) "MultiTouch Initialized!");
    }

    public void mrp_multitouch_move(int tid, long time, int x, int y)
    {
      if (!this.p_multitouch_initialized)
        return;
      for (int index = 1; index <= 8; ++index)
      {
        if (this.p_touchdata[index].state == 1 && this.p_touchdata[index].tid == tid)
        {
          this.p_touchdata[index].upx = x;
          this.p_touchdata[index].upy = y;
          this.p_touchdata[index].upt = time;
          return;
        }
      }
      this.mrp_multitouch_create(tid, time, x, y);
    }

    public void mrp_multitouch_create(int tid, long time, int x, int y)
    {
      if (!this.p_multitouch_initialized)
        return;
      for (int index = 1; index <= 8; ++index)
      {
        if (this.p_touchdata[index].state == 2 && index != this.p_mt_first && index != this.p_mt_secondary && index != this.p_mt_last)
        {
          this.p_touchdata[index].state = 0;
          this.p_touchdata[index].tid = -1;
        }
      }
      this.mrp_multitouch_release(tid, time);
      for (int index1 = 1; index1 <= 8; ++index1)
      {
        if (this.p_touchdata[index1].state == 0)
        {
          this.p_touchdata[index1].state = 1;
          this.p_touchdata[index1].dnx = this.p_touchdata[index1].upx = x;
          this.p_touchdata[index1].dny = this.p_touchdata[index1].upy = y;
          this.p_touchdata[index1].dnt = this.p_touchdata[index1].upt = time;
          this.p_touchdata[index1].tid = tid;
          this.p_mt_count = 0;
          for (int index2 = 1; index2 <= 8; ++index2)
          {
            if (this.p_touchdata[index2].state == 1)
              ++this.p_mt_count;
          }
          this.p_mt_last = this.p_mt_last_if_down = index1;
          if (this.p_mt_count == 1)
            this.p_mt_first = index1;
          else if (this.p_touchdata[this.p_mt_first].state == 1)
            this.p_mt_secondary = index1;
          this.mrp_keyPressed(47);
          break;
        }
      }
    }

    public void mrp_multitouch_release(int tid, long time)
    {
      if (!this.p_multitouch_initialized)
        return;
      for (int index = 1; index <= 8; ++index)
      {
        if (this.p_touchdata[index].tid == tid && this.p_touchdata[index].state == 1)
        {
          this.p_touchdata[index].state = 2;
          this.p_touchdata[index].upt = time;
          if (index == this.p_mt_last)
            this.p_mt_last_if_down = 0;
          this.mrp_keyReleased(47);
        }
      }
      for (int index = 1; index <= 8; ++index)
      {
        if (this.p_touchdata[index].state == 1)
          ++this.p_mt_count;
      }
    }

    public void p_print_touches()
    {
    }

    public void debug_text(mrGame.MrGame.MrgString s)
    {
            Debug.WriteLine("[i] " + s);
    }

    public int unsigned_shr(int a, int b) => a >>> b;

    public void System_gc() => GC.Collect();

    public int p_xna_getCurrentMS() => (int) ((DateTime.Now.Ticks - this.p_startTimeMS) / 10000L);

    public int p_xna_getCalendarTime()
    {
      return (int) ((DateTime.UtcNow - mrGame.MrGame.p_Jan1970).TotalMilliseconds / 10000000.0);
    }

    public void mrg_vibrate(int a)
    {
      if (a <= 0)
        return;
      if (this.p_options[1] == (sbyte) 0)
        return;
      try
      {
        //VibrateController.Default.Start(TimeSpan.FromMilliseconds(Convert.ToDouble(a)));
      }
      catch (Exception ex)
      {
      }
    }

    public void mrg_forcedPaint()
    {
    }

    public void mrg_setSoftkeyText1(mrGame.MrGame.MrgString s)
    {
    }

    public void mrg_setSoftkeyText2(mrGame.MrGame.MrgString s)
    {
    }

    public void mrp_keyPressed(int key) => this.keyPressed(key);

    public void mrp_keyReleased(int key) => this.keyReleased(key);

    public bool mrp_beginPaint() => false;

    public void mrp_endPaint()
    {
    }

    public void mrp_blitScreen()
    {
    }

    public bool mrp_eventCallback(mrGame.MrGame mrgame) => true;

    public void p_str_preinit()
    {
    }

    public void p_data_preinit()
    {
    }

    public void p_gfx_preinit()
    {
    }

    public void p_txt_preinit()
    {
    }

    public void p_gfx_free()
    {
    }

    public void p_txt_free()
    {
    }

    public void p_gfx_init()
    {
    }

    public void mrp_initTime()
    {
      this.p_starttime = this.p_xna_getCurrentMS();
      this.smoothtime = 0;
      this.p_realtime = 0;
      this.p_lasttime = 0;
      this.p_monotime = 0;
      this.mrg_resetTime();
    }

    public void mrg_resetTime()
    {
      this.frameNum = 0;
      this.p_timebufferlen = 0;
      this.timedelta = 0;
      this.gametime = 0;
      this.gametimePaused = false;
      this.smoothtime = this.p_xna_getCurrentMS() - this.p_starttime;
      for (int index = 0; index < 4; ++index)
        this.p_timebuffer[index] = 0;
      this.smoothtime = this.p_monotime;
      this.p_monotimedelta = 0;
      this.p_stabletimedelta = 0;
      this.p_outliercounter = 0;
      this.p_zerocount = 0;
      this.cursorBlink = true;
      this.p_lastCursorBlink = 0;
    }

    public void mrp_doTime()
    {
      ++this.frameNum;
      this.p_lasttime = this.smoothtime;
      this.p_realtime = this.p_xna_getCurrentMS() - this.p_starttime;
      int num1 = this.p_realtime - this.p_lastrealtime;
      this.p_lastrealtime = this.p_realtime;
      this.p_monotimedelta = num1;
      if (this.p_monotimedelta < 0)
        this.p_monotimedelta = 1;
      this.p_mspf = this.p_monotimedelta;
      if (this.p_monotimedelta > 1000)
        this.p_monotimedelta = 1000 + (this.p_monotimedelta - 1000) * 1000 / this.p_monotimedelta;
      this.p_monotime += this.p_monotimedelta;
      if (this.p_monotimedelta == 0)
      {
        ++this.p_zerocount;
      }
      else
      {
        int num2 = this.p_monotimedelta * 16 / (this.p_zerocount + 1);
        this.p_zerocount = 0;
        if (num2 * 8 > this.p_stabletimedelta * 6 && num2 * 8 < this.p_stabletimedelta * 10)
        {
          this.p_stabletimedelta += num2 - this.p_stabletimedelta + 8 >> 4;
          this.p_outliercounter = 0;
        }
        else
          ++this.p_outliercounter;
        if (this.p_outliercounter > 3)
          this.p_stabletimedelta = num2;
      }
      this.timedelta = this.p_stabletimedelta + 8 >> 4;
      this.timedelta += this.p_monotime - this.smoothtime - this.timedelta + 4 >> 3;
      if (this.timedelta < this.p_monotime - this.smoothtime - 30)
        this.timedelta = this.p_monotime - this.smoothtime - 30;
      if (this.timedelta > this.p_monotime - this.smoothtime + 30)
        this.timedelta = this.p_monotime - this.smoothtime + 30;
      if (this.timedelta < 0)
        this.timedelta = 0;
      this.smoothtime += this.timedelta;
      if (this.p_gameDisplay && !this.gametimePaused)
        this.gametime += this.timedelta;
      if (this.smoothtime - this.p_lastCursorBlink <= 300)
        return;
      this.cursorBlink = !this.cursorBlink;
      this.p_lastCursorBlink = this.smoothtime;
    }

    public void p_sfx_preinit() => this.p_soundGroupLoaded = new bool[2];

    public void p_sfx_free() => this.p_soundGroupLoaded = (bool[]) null;

    public void sfx_loadGroup(int groupIndex)
    {
      int num1 = (int) this.p_indexTable2[1355 + groupIndex];
      int num2 = (int) this.p_indexTable2[1353 + groupIndex];
      int start = this.p_indexTable3[20 + num1];
      if (this.p_soundGroupLoaded[groupIndex])
      {
        this.debug_text((mrGame.MrGame.MrgString) "soundgroup already loaded");
      }
      else
      {
        this.p_soundGroupLoaded[groupIndex] = true;
        Stream stream = TitleContainer.OpenStream("s");
        for (int objectId = num1; objectId < num1 + num2; ++objectId)
        {
          this.mrg_loading(3, objectId);
          int audioFormat = (int) this.p_indexTable1[3878 + objectId];
          if (audioFormat != 0)
          {
            int index = (int) this.p_indexTable2[1357 + objectId];
            int num3 = this.p_indexTable3[82 + objectId];
            if (audioFormat == 19 || audioFormat == 3)
              this.p_soundEffects[index] = new mrGame.MrGame.Sound(stream, start, start + num3, audioFormat);
            else
              this.debug_text((mrGame.MrGame.MrgString) ("Unsupported sound type=" + (object) audioFormat));
            start += num3;
          }
        }
      }
    }

    public void sfx_unloadGroup(int groupIndex)
    {
      int num1 = (int) this.p_indexTable2[1355 + groupIndex];
      int num2 = (int) this.p_indexTable2[1353 + groupIndex];
      int num3 = this.p_indexTable3[20 + num1];
      if (this.p_soundGroupLoaded[groupIndex])
      {
        for (int index1 = num1; index1 < num1 + num2; ++index1)
        {
          if (this.p_indexTable1[3878 + index1] != (sbyte) 0)
          {
            int index2 = (int) this.p_indexTable2[1357 + index1];
            if (this.p_soundEffects[index2] != null)
            {
              this.p_soundEffects[index2].Close();
              this.p_soundEffects[index2] = (mrGame.MrGame.Sound) null;
            }
          }
        }
      }
      this.p_soundGroupLoaded[groupIndex] = false;
    }

    public void p_playSound(int index, int priority, int loopCount)
    {
      if (this.p_options[0] == (sbyte) 0 || this.p_indexTable1[3878 + index] == (sbyte) 0)
        return;
      int index1 = (int) this.p_indexTable2[1357 + index];
      int num = (int) this.p_indexTable1[3878 + index];
      this.debug_text((mrGame.MrGame.MrgString) ("sfx_playExt " + (object) index + ", " + (object) priority + ", " + (object) loopCount + " type=" + (object) num + " realindex=" + (object) index1));
      if (this.p_soundEffects[index1] != null)
        this.p_soundEffects[index1].Play(loopCount);
      else
        this.debug_text((mrGame.MrGame.MrgString) ("Error: Sound not loaded == sfx_playExt " + (object) index));
    }

    public void sfx_stop(int index)
    {
      this.debug_text((mrGame.MrGame.MrgString) ("sfx_stop " + (object) index));
      if (this.p_indexTable1[3878 + index] == (sbyte) 0)
        return;
      int index1 = (int) this.p_indexTable2[1357 + index];
      if (this.p_soundEffects[index1] == null)
        return;
      this.p_soundEffects[index1].Stop();
    }

    public int sfx_getPlayLength(int index)
    {
      int index1 = (int) this.p_indexTable2[1357 + index];
      return this.p_soundEffects[index1] != null ? this.p_soundEffects[index1].Length() : 0;
    }

    public void p_sfx_logic()
    {
      for (int index = 0; index < 31; ++index)
      {
        if (this.p_soundEffects[index] != null)
          this.p_soundEffects[index].Logic();
      }
    }

    public void sfx_stopAll()
    {
      this.debug_text((mrGame.MrGame.MrgString) nameof (sfx_stopAll));
      for (int index = 0; index < 31; ++index)
      {
        if (this.p_soundEffects[index] != null)
          this.p_soundEffects[index].Stop();
      }
    }

    public void sfx_pauseAll()
    {
      this.debug_text((mrGame.MrGame.MrgString) nameof (sfx_pauseAll));
      for (int index = 0; index < 31; ++index)
      {
        if (this.p_soundEffects[index] != null)
          this.p_soundEffects[index].Pause();
      }
    }

    public void sfx_unpauseAll()
    {
      this.debug_text((mrGame.MrGame.MrgString) nameof (sfx_unpauseAll));
      for (int index = 0; index < 31; ++index)
      {
        if (this.p_soundEffects[index] != null)
          this.p_soundEffects[index].Resume();
      }
    }

    public bool p_xbla_isUnlocked() => this.customization_isUnlocked();

    public void p_xbla_preinit()
    {
      mrGame.MrGame.p_xbla_Leaderboards = new Dictionary<int, mrGame.MrGame.LeaderboardInfo>();
      SignedInGamer.SignedIn += new EventHandler<SignedInEventArgs>(this.p_xbla_GamerSignedInCB);
      mrGame.MrGame.p_gamerServicesInstance = new GamerServicesComponent((Game) this.xnagame);
    }

    public void p_xbla_disableGamerServices()
    {
      if (mrGame.MrGame.p_gamerServicesInstance == null)
        return;
      mrGame.MrGame.p_gamerServicesInstance.Enabled = false;
    }

    public bool p_xbla_isGamerServicesAvailable()
    {
      if (mrGame.MrGame.p_gamerServicesInstance != null && mrGame.MrGame.p_gamerServicesInstance.Enabled && this.p_xbla_isUnlocked())
        return true;
      this.debug_text((mrGame.MrGame.MrgString) "Note: GamerServices NOT available");
      return false;
    }

    public bool xbla_isAvailable() => this.p_xbla_isGamerServicesAvailable();

    public void p_xbla_GamerSignedInCB(object sender, SignedInEventArgs args)
    {
      try
      {
        mrGame.MrGame.p_SignedInGamer = args.Gamer;
        if (mrGame.MrGame.p_SignedInGamer == null)
          return;
        mrGame.MrGame.p_SignedInGamer.BeginGetAchievements(new AsyncCallback(mrGame.MrGame.p_xbla_GetAchievementsCallback), (object) mrGame.MrGame.p_SignedInGamer);
      }
      catch (Exception ex)
      {
      }
    }

    public mrGame.MrGame.MrgString xbla_getPlayerId()
    {
      try
      {
        //if (mrGame.MrGame.p_SignedInGamer != null)
        //  return new mrGame.MrGame.MrgString(mrGame.MrGame.p_SignedInGamer.Gamertag);
        return default;
      }
      catch (Exception ex)
      {
      }
      return new mrGame.MrGame.MrgString(string.Empty);
    }

    public bool xbla_isAuthenticated()
    {
      try
      {
        if (mrGame.MrGame.p_SignedInGamer != null)
          return true;
      }
      catch (Exception ex)
      {
      }
      return false;
    }

    public bool p_xbla_isLeaderboardValid(int leaderboardId)
    {
      return mrGame.MrGame.p_xbla_Leaderboards.ContainsKey(leaderboardId) && mrGame.MrGame.p_xbla_Leaderboards[leaderboardId].Reader != null;
    }

    public LeaderboardKey p_xbla_leaderboard_generateKey(int timeScope, int valueType)
    {
      return timeScope == 0 ? (valueType == 0 ? LeaderboardKey.BestScoreLifeTime : LeaderboardKey.BestTimeLifeTime) : (valueType == 0 ? LeaderboardKey.BestScoreRecent : LeaderboardKey.BestTimeRecent);
    }

    public int xbla_leaderboard_load(
      int leaderboardId,
      bool pivotGamer,
      int startingPage,
      int numScoresPerPage,
      int timeScope,
      int valueType)
    {
      try
      {
        if (!this.p_xbla_isGamerServicesAvailable() || mrGame.MrGame.p_SignedInGamer == null || 0 > leaderboardId)
          return -1;
        LeaderboardKey key = this.p_xbla_leaderboard_generateKey(timeScope, valueType);
        mrGame.MrGame.LeaderboardInfo asyncState;
        if (mrGame.MrGame.p_xbla_Leaderboards.ContainsKey(leaderboardId))
        {
          asyncState = mrGame.MrGame.p_xbla_Leaderboards[leaderboardId];
          if (asyncState.State != mrGame.MrGame.LeaderBoardState.UnInitialized)
          {
            this.debug_text((mrGame.MrGame.MrgString) ("Note: Leaderboard[" + (object) leaderboardId + "] already loaded or loading, ignoring load request."));
            return leaderboardId;
          }
        }
        else
        {
          asyncState = new mrGame.MrGame.LeaderboardInfo();
          mrGame.MrGame.p_xbla_Leaderboards.Add(leaderboardId, asyncState);
        }
        asyncState.NumScoresPerPage = numScoresPerPage;
        asyncState.Identity = LeaderboardIdentity.Create(key, leaderboardId);
        asyncState.State = mrGame.MrGame.LeaderBoardState.PageRequested;
        if (pivotGamer)
          LeaderboardReader.BeginRead(asyncState.Identity, (Gamer) mrGame.MrGame.p_SignedInGamer, numScoresPerPage, new AsyncCallback(this.p_xbla_LeaderboardReadCallback), (object) asyncState);
        else
          LeaderboardReader.BeginRead(asyncState.Identity, startingPage, numScoresPerPage, new AsyncCallback(this.p_xbla_LeaderboardReadCallback), (object) asyncState);
        return leaderboardId;
      }
      catch (Exception ex)
      {
        return -1;
      }
    }

    public mrGame.MrGame.MrgString xbla_leaderboard_getAlias(int leaderboardId, int index)
    {
      try
      {
        if (this.p_xbla_isLeaderboardValid(leaderboardId))
        {
            //if (index < mrGame.MrGame.p_xbla_Leaderboards[leaderboardId].Reader.Entries.Count)
            //  return new mrGame.MrGame.MrgString(mrGame.MrGame.p_xbla_Leaderboards[leaderboardId].Reader.Entries[index].Gamer.Gamertag);
            return default;
        }
      }
      catch (Exception ex)
      {
      }
      return new mrGame.MrGame.MrgString(string.Empty);
    }

    public long xbla_leaderboard_getScore(int leaderboardId, int index)
    {
      try
      {
        if (this.p_xbla_isLeaderboardValid(leaderboardId))
        {
            //if (index < mrGame.MrGame.p_xbla_Leaderboards[leaderboardId].Reader.Entries.Count)
            //  return (long) mrGame.MrGame.p_xbla_Leaderboards[leaderboardId].Reader.Entries[index].Columns.GetValueInt32("BestScore");
            return default;
        }
      }
      catch (Exception ex)
      {
      }
      return 0;
    }

    public long xbla_leaderboard_getRank(int leaderboardId, int index)
    {
      try
      {
        if (this.p_xbla_isLeaderboardValid(leaderboardId))
          return (long) mrGame.MrGame.p_xbla_Leaderboards[leaderboardId].Reader.PageStart + 1L + (long) index;
      }
      catch (Exception ex)
      {
      }
      return 0;
    }

    public void p_xbla_LeaderboardReadCallback(IAsyncResult result)
    {
      mrGame.MrGame.LeaderboardInfo asyncState = result.AsyncState as mrGame.MrGame.LeaderboardInfo;
      try
      {
        switch (asyncState.State)
        {
          case mrGame.MrGame.LeaderBoardState.PageRequested:
            asyncState.Reader = LeaderboardReader.EndRead(result);
            break;
          case mrGame.MrGame.LeaderBoardState.PageUpRequested:
            asyncState.Reader.EndPageUp(result);
            break;
          case mrGame.MrGame.LeaderBoardState.PageDownRequested:
            asyncState.Reader.EndPageDown(result);
            break;
        }
        if (asyncState.Reader != null)
        {
          asyncState.State = mrGame.MrGame.LeaderBoardState.PageReady;
          return;
        }
      }
      catch (Exception ex)
      {
        this.debug_text((mrGame.MrGame.MrgString) ("ERR in p_xbla_LeaderboardReadCallback: " + ex.ToString()));
      }
      if (asyncState == null)
        return;
      asyncState.State = mrGame.MrGame.LeaderBoardState.UnInitialized;
    }

    public bool xbla_leaderboard_isReady(int leaderboardId)
    {
      try
      {
        if (!mrGame.MrGame.p_xbla_Leaderboards.ContainsKey(leaderboardId) || mrGame.MrGame.p_xbla_Leaderboards[leaderboardId].State == mrGame.MrGame.LeaderBoardState.UnInitialized)
          return true;
        if (mrGame.MrGame.LeaderBoardState.PageReady == mrGame.MrGame.p_xbla_Leaderboards[leaderboardId].State)
          return true;
      }
      catch (Exception ex)
      {
      }
      return false;
    }

    public int xbla_leaderboard_getError(int leaderboardId)
    {
      try
      {
        if (mrGame.MrGame.p_xbla_Leaderboards.ContainsKey(leaderboardId) && mrGame.MrGame.p_xbla_Leaderboards[leaderboardId].State != mrGame.MrGame.LeaderBoardState.UnInitialized)
          return 0;
        return this.p_xbla_isGamerServicesAvailable() ? -3 : -2;
      }
      catch (Exception ex)
      {
        return -1;
      }
    }

    public bool xbla_leaderboard_CanPageUp(int leaderboardId)
    {
      try
      {
        if (this.p_xbla_isLeaderboardValid(leaderboardId))
        {
          if (mrGame.MrGame.LeaderBoardState.PageReady == mrGame.MrGame.p_xbla_Leaderboards[leaderboardId].State)
          {
            if (mrGame.MrGame.p_xbla_Leaderboards[leaderboardId].Reader.CanPageUp)
              return true;
          }
        }
      }
      catch (Exception ex)
      {
      }
      return false;
    }

    public bool xbla_leaderboard_CanPageDown(int leaderboardId)
    {
      try
      {
        if (this.p_xbla_isLeaderboardValid(leaderboardId))
        {
          if (mrGame.MrGame.LeaderBoardState.PageReady == mrGame.MrGame.p_xbla_Leaderboards[leaderboardId].State)
          {
            if (mrGame.MrGame.p_xbla_Leaderboards[leaderboardId].Reader.CanPageDown)
              return true;
          }
        }
      }
      catch (Exception ex)
      {
      }
      return false;
    }

    public bool xbla_leaderboard_PageUp(int leaderboardId)
    {
      try
      {
        if (this.xbla_leaderboard_CanPageUp(leaderboardId))
        {
          mrGame.MrGame.LeaderboardInfo pXblaLeaderboard = mrGame.MrGame.p_xbla_Leaderboards[leaderboardId];
          pXblaLeaderboard.State = mrGame.MrGame.LeaderBoardState.PageUpRequested;
          pXblaLeaderboard.Reader.BeginPageUp(new AsyncCallback(this.p_xbla_LeaderboardReadCallback), (object) pXblaLeaderboard);
          return true;
        }
      }
      catch (Exception ex)
      {
      }
      return false;
    }

    public bool xbla_leaderboard_PageDown(int leaderboardId)
    {
      try
      {
        if (this.xbla_leaderboard_CanPageDown(leaderboardId))
        {
          mrGame.MrGame.LeaderboardInfo pXblaLeaderboard = mrGame.MrGame.p_xbla_Leaderboards[leaderboardId];
          pXblaLeaderboard.State = mrGame.MrGame.LeaderBoardState.PageDownRequested;
          pXblaLeaderboard.Reader.BeginPageDown(new AsyncCallback(this.p_xbla_LeaderboardReadCallback), (object) pXblaLeaderboard);
          return true;
        }
      }
      catch (Exception ex)
      {
      }
      return false;
    }

    public void xbla_leaderboard_reportScore(int leaderboardId, int valueType, long value)
    {
      try
      {
        if (!this.p_xbla_isGamerServicesAvailable() || mrGame.MrGame.p_SignedInGamer == null)
          return;
        LeaderboardIdentity leaderboardId1 = LeaderboardIdentity.Create(valueType != 0 ? LeaderboardKey.BestTimeLifeTime : LeaderboardKey.BestScoreLifeTime, leaderboardId);
        LeaderboardEntry leaderboard = default;//mrGame.MrGame.p_SignedInGamer.LeaderboardWriter.GetLeaderboard(leaderboardId1);
        leaderboard.Rating = value;
        //leaderboard.Columns.SetValue("TimeStamp", DateTime.Now);
        mrGame.MrGame.p_xbla_Leaderboards[leaderboardId].State = mrGame.MrGame.LeaderBoardState.UnInitialized;
      }
      catch (Exception ex)
      {
      }
    }

    public int xbla_leaderboard_getSize(int leaderboardId)
    {
      try
      {
        if (this.xbla_leaderboard_isReady(leaderboardId))
          return mrGame.MrGame.p_xbla_Leaderboards[leaderboardId].Reader != null ? mrGame.MrGame.p_xbla_Leaderboards[leaderboardId].Reader.Entries.Count : 0;
      }
      catch (Exception ex)
      {
      }
      return 0;
    }

    private static void p_xbla_AwardAchievementCB(IAsyncResult result)
    {
      try
      {
        if (!(result.AsyncState is SignedInGamer asyncState))
          return;
        asyncState.EndAwardAchievement(result);
        asyncState.BeginGetAchievements(new AsyncCallback(mrGame.MrGame.p_xbla_GetAchievementsCallback), (object) asyncState);
      }
      catch (Exception ex)
      {
      }
    }

    public void xbla_AwardAchievement(mrGame.MrGame.MrgString achievementKey)
    {
      this.debug_text((mrGame.MrGame.MrgString) "AwardAchievement: " + achievementKey);
      if ((mrGame.MrGame.MrgString) null == achievementKey || achievementKey.length() == 0 || !this.p_xbla_isGamerServicesAvailable() || mrGame.MrGame.p_SignedInGamer == null || this.xbla_achievement_isCompleted(achievementKey))
        return;
      mrGame.MrGame.p_SignedInGamer.BeginAwardAchievement(achievementKey.toString(), new AsyncCallback(mrGame.MrGame.p_xbla_AwardAchievementCB), (object) mrGame.MrGame.p_SignedInGamer);
    }

    public bool xbla_achievments_isReady() => mrGame.MrGame.p_Achievements != null;

    public int xbla_achievements_getNumber()
    {
            if (mrGame.MrGame.p_Achievements != null)
                return default;//mrGame.MrGame.p_Achievements.Count;

      this.debug_text((mrGame.MrGame.MrgString) "Error: xbla_achievement_getNumber() called when achievements not downloaded yet, returning 0;");
      return 0;
    }

    public mrGame.MrGame.MrgString xbla_achievements_getId(int index)
    {
      try
      {
        if (mrGame.MrGame.p_Achievements != null)
        {
          lock (mrGame.MrGame.p_AchievementLock)
          {
            //if (index < mrGame.MrGame.p_Achievements.Count)
              return default;//new mrGame.MrGame.MrgString(mrGame.MrGame.p_Achievements[index].Key);
          }
          this.debug_text((mrGame.MrGame.MrgString) ("Error: xbla_achievements_getId(index) invalid index: " + (object) index));
        }
      }
      catch (Exception ex)
      {
      }
      return new mrGame.MrGame.MrgString(string.Empty);
    }

    public bool xbla_achievement_isHidden(mrGame.MrGame.MrgString achievementKey)
    {
      try
      {
        if (mrGame.MrGame.p_Achievements != null)
        {
          lock (mrGame.MrGame.p_AchievementLock)
          {
                        /*
            Achievement pAchievement = mrGame.MrGame.p_Achievements[achievementKey.toString()];
            if (pAchievement.IsEarned)
              return false;
            if (pAchievement.DisplayBeforeEarned)
              return false;
                        */
            return false;
          }
        }
      }
      catch (Exception ex)
      {
      }
      return true;
    }

    public bool xbla_achievement_isCompleted(mrGame.MrGame.MrgString achievementKey)
    {
      try
      {
        if (mrGame.MrGame.p_Achievements == null || achievementKey.len < 1)
          return false;
        lock (mrGame.MrGame.p_AchievementLock)
        {
          //if (mrGame.MrGame.p_Achievements[achievementKey.toString()].IsEarned)
            return true;
        }
      }
      catch (Exception ex)
      {
      }
      return false;
    }

    public mrGame.MrGame.MrgString xbla_achievement_getDateEarned(mrGame.MrGame.MrgString achievementKey)
    {
      try
      {
        if (mrGame.MrGame.p_Achievements != null)
        {
          lock (mrGame.MrGame.p_AchievementLock)
          {
                        //Achievement pAchievement = mrGame.MrGame.p_Achievements[achievementKey.toString()];
                        //if (pAchievement.IsEarned)
                        //  return new mrGame.MrGame.MrgString(pAchievement.EarnedDateTime.ToShortDateString());
                        return default;
          }
        }
      }
      catch (Exception ex)
      {
      }
      return new mrGame.MrGame.MrgString(string.Empty);
    }

    public mrGame.MrGame.MrgString xbla_achievement_getName(mrGame.MrGame.MrgString achievementKey)
    {
      try
      {
        if (mrGame.MrGame.p_Achievements != null)
        {
                    //lock (mrGame.MrGame.p_AchievementLock)
                    //  return new mrGame.MrGame.MrgString(mrGame.MrGame.p_Achievements[achievementKey.toString()].Name);
                    return default;
        }
      }
      catch (Exception ex)
      {
      }
      return new mrGame.MrGame.MrgString(string.Empty);
    }

    public mrGame.MrGame.MrgString xbla_achievement_getDescription(mrGame.MrGame.MrgString achievementKey)
    {
      try
      {
        if (mrGame.MrGame.p_Achievements != null)
        {
          //lock (mrGame.MrGame.p_AchievementLock)
          //  return new mrGame.MrGame.MrgString(mrGame.MrGame.p_Achievements[achievementKey.toString()].Description);
          return default;
        }
      }
      catch (Exception ex)
      {
      }
      return new mrGame.MrGame.MrgString(string.Empty);
    }

    public mrGame.MrGame.MrgString xbla_achievement_getHowToEarn(mrGame.MrGame.MrgString achievementKey)
    {
      try
      {
        if (mrGame.MrGame.p_Achievements != null)
        {
          //lock (mrGame.MrGame.p_AchievementLock)
          //  return new mrGame.MrGame.MrgString(mrGame.MrGame.p_Achievements[achievementKey.toString()].HowToEarn);
          return default;
        }
      }
      catch (Exception ex)
      {
      }
      return new mrGame.MrGame.MrgString(string.Empty);
    }

    public int xbla_achievement_GetMaxGamerScore()
    {
      lock (mrGame.MrGame.p_AchievementLock)
        return mrGame.MrGame.p_xbla_MaxGamerScore;
    }

    public int xbla_achievement_GetEarnedGamerScore()
    {
      lock (mrGame.MrGame.p_AchievementLock)
        return mrGame.MrGame.p_xbla_EarnedGamerScore;
    }

    private static void p_xbla_GetAchievementsCallback(IAsyncResult result)
    {
      if (!(result.AsyncState is SignedInGamer asyncState))
        return;
      try
      {
        lock (mrGame.MrGame.p_AchievementLock)
        {
          AchievementCollection pAchievements = mrGame.MrGame.p_Achievements;
          mrGame.MrGame.p_xbla_MaxGamerScore = 0;
          mrGame.MrGame.p_xbla_EarnedGamerScore = 0;
          mrGame.MrGame.p_Achievements = asyncState.EndGetAchievements(result);

          //RnD
          /*
          for (int index = 0; index < mrGame.MrGame.p_Achievements.Count; ++index)
          {
            Achievement pAchievement = mrGame.MrGame.p_Achievements[index];
            mrGame.MrGame.p_xbla_MaxGamerScore += pAchievement.GamerScore;
            if (pAchievement.IsEarned)
              mrGame.MrGame.p_xbla_EarnedGamerScore += pAchievement.GamerScore;
          }
         */
        }
      }
      catch (Exception ex)
      {
      }
    }

    public bool p_isUpdateAvailable()
    {
      return mrGame.MrGame.p_displayTitleUpdateAvailable || mrGame.MrGame.p_xbla_showMarketPlace;
    }

    public bool p_xbla_systemMessageIsVisible()
    {
      return mrGame.MrGame.p_gamerServicesInstance != null && Guide.IsVisible;
    }

    public void p_xbla_HandleUpdateRequired()
    {
      if (mrGame.MrGame.p_TitleUpdateAvailable)
        return;
      mrGame.MrGame.p_TitleUpdateAvailable = true;
      mrGame.MrGame.p_displayTitleUpdateAvailable = true;
    }

    public void p_ShowUpdateAvailableDialog()
    {
      mrGame.MrGame.MrgString pAllText1 = this.p_allTexts[41];
      mrGame.MrGame.MrgString pAllText2 = this.p_allTexts[40];
      mrGame.MrGame.MrgString pAllText3 = this.p_allTexts[29];
      mrGame.MrGame.MrgString pAllText4 = this.p_allTexts[30];
      try
      {
        if (this.p_xbla_systemMessageIsVisible())
          return;
        if (mrGame.MrGame.p_xbla_showMarketPlace)
        {
          mrGame.MrGame.p_xbla_showMarketPlace = false;
          this.p_ShowMarketPlace();
        }
        else
        {
          if (!mrGame.MrGame.p_displayTitleUpdateAvailable)
            return;
          mrGame.MrGame.p_displayTitleUpdateAvailable = false;
          Guide.BeginShowMessageBox(pAllText3.toString(), pAllText4.toString(), (IEnumerable<string>) new List<string>()
          {
            pAllText1.toString(),
            pAllText2.toString()
          }, 1, /*MessageBoxIcon.Alert*/default, new AsyncCallback(this.p_UpdateAvailableDialogCB), (object) null);
        }
      }
      catch (Exception ex)
      {
      }
    }

    public void p_ShowMarketPlace()
    {
      try
      {
        if (this.p_xbla_systemMessageIsVisible())
          return;
        Guide.ShowMarketplace(PlayerIndex.One);
      }
      catch (Exception ex)
      {
      }
    }

    public void p_UpdateAvailableDialogCB(IAsyncResult userResult)
    {
      try
      {
        int? nullable = Guide.EndShowMessageBox(userResult);
        if (!nullable.HasValue || nullable.Value == 0)
          return;
        if (Guide.IsTrialMode)
          mrGame.MrGame.p_xbla_showMarketPlace = true;
        else
          new MarketplaceDetailTask()
          {
            ContentType = ((MarketplaceContentType) 1)
          }.Show();
      }
      catch (Exception ex)
      {
      }
    }

    public void p_xna_startAccelerationSensor_withState()
    {
      if (!mrGame.MrGame.p_xna_sensor_activatedByGame)
        return;

      this.mrg_startAccelerationSensor();
    }

    public void p_xna_stopAccelerationSensor_withState()
    {
      if (!mrGame.MrGame.p_xna_sensor_activatedByGame)
        return;
      this.mrg_stopAccelerationSensor();
      mrGame.MrGame.p_xna_sensor_activatedByGame = true;
    }

    public void mrg_startAccelerationSensor()
    {
           
      try
      {
                //PhoneApplicationService.Current.UserIdleDetectionMode = (IdleDetectionMode) 1;

                //if (this._accelerometer == null)
                //{
                //  this._accelerometer = new Accelerometer();//();
                //  this._accelerometer.ReadingChanged += new EventHandler<AccelerometerReadingChangedEventArgs>(this.p_xna_AccelerometerReadingChanged);
                //}

                if (_accelerometer == null)
                    _accelerometer = Accelerometer.GetDefault();

                if (_accelerometer != null)
                {
                    // Establish the report interval
                    uint minReportInterval = _accelerometer.MinimumReportInterval;
                    uint reportInterval = minReportInterval > 16 ? minReportInterval : 16;
                    _accelerometer.ReportInterval = reportInterval;

                    // Assign an event handler for the reading-changed event
                    _accelerometer.ReadingChanged += new TypedEventHandler<Accelerometer, AccelerometerReadingChangedEventArgs>(p_xna_AccelerometerReadingChanged);
                }

                this.debug_text((mrGame.MrGame.MrgString) nameof (mrg_startAccelerationSensor));

        mrGame.MrGame.p_xna_sensor_activatedByGame = true;

        //this._accelerometer.Start();

      }
      catch (Exception ex)//(AccelerometerFailedException ex)
      {
         Debug.WriteLine("[ex] Accelerometer reading error: " + ex.Message);
      }
      //catch (UnauthorizedAccessException ex)
      //{
      //}
      //catch
      //{
      //}
            
    }

    public void mrg_stopAccelerationSensor()
    {
      try
      {
        //PhoneApplicationService.Current.UserIdleDetectionMode = (IdleDetectionMode) 0;
        if (this._accelerometer != null)
        {
          this.debug_text((mrGame.MrGame.MrgString) nameof (mrg_stopAccelerationSensor));
          mrGame.MrGame.p_xna_sensor_activatedByGame = false;
          
          //RnD
          //this._accelerometer.Stop();
        }
      }
      catch (Exception ex)//(AccelerometerFailedException ex)
      {
         Debug.WriteLine("[ex] Accelerometer failed: " + ex.Message);
      }
      this.p_acceleration_x = 0;
      this.p_acceleration_y = 0;
      this.p_acceleration_z = 0;
    }

    public async void p_xna_AccelerometerReadingChanged(object sender, AccelerometerReadingChangedEventArgs e)
    {
      try
      {
        int int32_1 = 0;
        int int32_2 = 0;
        int int32_3 = 0;

        //await Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
        //{
       
         int32_1 = Convert.ToInt32(
            (e.Reading.AccelerationX * (double) ushort.MaxValue <= (double) ushort.MaxValue 
            ? e.Reading.AccelerationX * (double) ushort.MaxValue 
            : (double) ushort.MaxValue) >= -65535.0 
            ? (e.Reading.AccelerationX * (double) ushort.MaxValue <= (double) ushort.MaxValue
            ? (float) (e.Reading.AccelerationX * (double) ushort.MaxValue) : (float) ushort.MaxValue)
            : -65535f );

        int32_2 = Convert.ToInt32(
            (e.Reading.AccelerationY * (double) ushort.MaxValue <= (double) ushort.MaxValue 
            ? e.Reading.AccelerationY * (double) ushort.MaxValue 
            : (double) ushort.MaxValue) >= -65535.0
                 ? (e.Reading.AccelerationY * (double) ushort.MaxValue <= (double) ushort.MaxValue 
                ? (float) (e.Reading.AccelerationY * (double) ushort.MaxValue) 
                : (float) ushort.MaxValue) 
            : -65535f);

        int32_3 = Convert.ToInt32(
            (e.Reading.AccelerationZ * (double) ushort.MaxValue <= (double) ushort.MaxValue
            ? e.Reading.AccelerationZ * (double) ushort.MaxValue : (double) ushort.MaxValue) >= -65535.0 
            ? (e.Reading.AccelerationZ * (double) ushort.MaxValue <= (double) ushort.MaxValue 
            ? (float) (e.Reading.AccelerationZ * (double) ushort.MaxValue)
            : (float) ushort.MaxValue) : -65535f);
        
        // });

        switch (TouchPanel.DisplayOrientation)
        {
          case DisplayOrientation.LandscapeLeft:
            this.p_acceleration_x = -int32_2;
            this.p_acceleration_y = int32_1;
            this.p_acceleration_z = int32_3;
            break;
          case DisplayOrientation.LandscapeRight:
            this.p_acceleration_x = int32_2;
            this.p_acceleration_y = -int32_1;
            this.p_acceleration_z = int32_3;
            break;
          case DisplayOrientation.Portrait:
            this.p_acceleration_x = int32_1;
            this.p_acceleration_y = int32_2;
            this.p_acceleration_z = int32_3;
            break;
        }
      }
      catch (Exception ex)
      {
        if (isExceptionFirstShown)
        {
            Debug.WriteLine("[ex] p_xna_AccelerometerReadingChanged error: " + ex.Message);
            isExceptionFirstShown = false;
        }
      }
    }

    public void mrp_exitRunko()
    {
      if (this.p_exitrunko)
        return;
      this.p_exitrunko = true;
      this.sfx_stopAll();
      if (this.p_options == null)
        return;
      this.mrg_saveOptions();
    }

    public void mrg_exitApp() => this.mrp_exitRunko();

    public void mrg_requestIngameMenuPauseSound(bool pause)
    {
      this.p_xna_stopAccelerationSensor_withState();
      if (pause)
        this.sfx_pauseAll();
      this.p_gameDisplay = false;
      this.repaintAll = true;
      this.menu_start();
    }

    public void mrg_requestIngameMenu() => this.mrg_requestIngameMenuPauseSound(true);

    public void mrg_forcePaintNow()
    {
      this.p_forcedPaint = true;
      this.xnagame.basicEffect.CurrentTechnique.Passes[0].Apply();
      this.p_realPaint();
      this.mrp_endPaint();
      this.xnagame.graphics.GraphicsDevice.Present();
      this.p_forcedPaint = false;
    }

    public void mrp_runkoMain()
    {
      if (this.runko_state == 3)
        return;
      this.runko_state = this.mrp_runkoStep(this.runko_state);
    }

    public void p_lng_preinit()
    {
      switch (CultureInfo.CurrentCulture.TwoLetterISOLanguageName)
      {
        case "it":
          this.p_langID = 16;
          break;
        case "fr":
          this.p_langID = 12;
          break;
        case "de":
          this.p_langID = 7;
          break;
        case "es":
          this.p_langID = 10;
          break;
        case "pt":
          this.p_langID = 22;
          break;
        default:
          this.p_langID = 9;
          break;
      }
    }

    public void mrp_preinits()
    {
      this.p_lng_preinit();
      this.p_str_preinit();
      this.p_data_preinit();
      this.p_gfx_preinit();
      this.p_sfx_preinit();
      this.p_xbla_preinit();
    }

    public void mrg_exitToMain()
    {
      this.p_initializingState = true;
      this.debug_text((mrGame.MrGame.MrgString) "exit game to menu!");
      this.game_unload();
      this.mrg_resetTime();
      this.p_inGame = false;
      this.p_gameDisplay = false;
      this.repaintAll = true;
      this.repaintScreen = false;
      this.menu_start();
      this.mrg_resetKeys();
      this.p_initializingState = false;
    }

    public int mrp_runkoStep(int oldstate)
    {
      switch (oldstate)
      {
        case 0:
          this.p_initializingState = true;
          this.p_lb_fillScreen = false;
          this.p_mainGroupsLoaded = false;
          this.mrp_multitouch_init();
          this.mainTextLoaded = false;
          this.hs_currentTable = -1;
          this.hs_data_int = (int[]) null;
          this.p_exitrunko = false;
          this.p_txt_preinit();
          this.p_data_init();
          this.p_loadIndexTables();
          this.p_loadOptions();
          this.p_gfx_init();
          this.p_em_selectLanguage();
          this.mrp_initTime();
          this.mrg_resetKeys();
          this.mrp_egfx_init();
          this.p_bmfont_init();
          this.p_eg_init();
          this.p_processHideNotifyNextFrame = false;
          this.p_processShowNotifyNextFrame = false;
          this.menu_preinit();
          this.game_preinit();
          this.p_tb_initSmoothScroll(0, 0);
          this.p_tb_changeTime = this.p_tb_timeLeft = this.p_tb_scroll = 0;
          this.p_tb_text = (mrGame.MrGame.MrgString) null;
          this.p_tbFont = 0;
          this.txt_loadGroup(0);
          this.mainTextLoaded = true;
          this.p_gameDisplay = false;
          this.gfx_loadGroup(0);
          this.p_pow2_texture = false;
          this.sfx_loadGroup(0);
          this.p_mainGroupsLoaded = true;
          this.debug_text((mrGame.MrGame.MrgString) "start mainloop");
          this.p_inGame = false;
          this.repaintScreen = false;
          this.repaintAll = true;
          this.p_forcedPaint = false;
          this.debug_text((mrGame.MrGame.MrgString) "going to menu start");
          this.menu_start();
          this.debug_text((mrGame.MrGame.MrgString) "starting mainloop");
          this.mrg_resetKeys();
          this.p_initializingState = false;
          return 1;
        case 1:
          if (!this.mrp_eventCallback(this) || this.p_exitrunko)
            return 2;
          if (this.p_processHideNotifyNextFrame)
          {
            this.p_processHideNotifyNextFrame = false;
            this.safe_hideNotify();
          }
          if (this.p_processShowNotifyNextFrame)
          {
            this.p_processShowNotifyNextFrame = false;
            this.safe_showNotify();
          }
          this.mrp_doTime();
          this.p_runKeyEvents();
          this.p_sfx_logic();
          if (this.p_tb_inputHandleFlags != 0)
            this.p_tb_inputHandlerLogic();
          this.p_eg_logic();
          this.p_eg_updatePointer();
          if (this.p_gameDisplay)
          {
            if (!this.game_logic())
              this.mrg_exitToMain();
          }
          else if (!this.menu_logic())
          {
            this.p_initializingState = true;
            this.debug_text((mrGame.MrGame.MrgString) "exit menu to game!");
            this.repaintScreen = false;
            this.repaintAll = true;
            this.p_gameDisplay = true;
            if (!this.p_inGame)
            {
              this.debug_text((mrGame.MrGame.MrgString) "MainLoop: p_inGame=false");
              this.menu_unload();
              this.mrg_resetTime();
              this.p_inGame = true;
              this.game_start();
            }
            else
            {
              this.p_xna_startAccelerationSensor_withState();
              if (!(this.p_tbBackupString == (mrGame.MrGame.MrgString) null))
              {
                this.debug_text((mrGame.MrGame.MrgString) "Restore backup textbox");
                this.p_tb2_make(this.p_tbBackupId, this.p_tbBackupFont, this.p_tbBackupString, this.p_tbBackupWidth, this.p_tbBackupHeight, false, this.p_tbBackupEmulateOld);
                this.p_tbBorderX = this.p_tbBackupBorderX;
                this.p_tbBorderY = this.p_tbBackupBorderY;
                this.p_tbBorderWidth = this.p_tbBackupBorderWidth;
                this.p_tbBorderHeight = this.p_tbBackupBorderHeight;
                this.p_tbTextX = this.p_tbBackupTextX;
                this.p_tbTextY = this.p_tbBackupTextY;
                this.p_tb_inputHandleFlags = this.p_tbBackupHandleFlags;
              }
            }
            this.mrg_resetKeys();
            this.sfx_unpauseAll();
            this.p_initializingState = false;
          }
          this.p_tb_updateSmoothScroll();
          return 1;
        case 2:
          this.p_initializingState = true;
          if (this.p_inGame)
            this.game_unload();
          else
            this.menu_unload();
          this.game_free();
          this.p_gfx_free();
          this.p_bmfont_free();
          this.p_eg_free();
          this.p_em_free();
          this.p_options = (sbyte[]) null;
          this.hs_unload();
          this.p_sfx_free();
          this.p_data_free();
          this.p_freeIndexTables();
          this.p_txt_free();
          this.debug_text((mrGame.MrGame.MrgString) "exit mainloop");
          this.p_initializingState = false;
          return 0;
        default:
          return 0;
      }
    }

    public void mrp_initSize(int w, int h)
    {
      this.dynamic_X_RES = w;
      this.dynamic_Y_RES = h;
    }

    public void mrp_sizeChanged(int w, int h) => this.sizeChanged(w, h);

    public static DisplayOrientation mrp_getSupportedOrientations() => DisplayOrientation.Portrait;

    public int mrp_getFreeMemory()
    {
        long num = 10;// (long) DeviceExtendedProperties.GetValue("ApplicationCurrentMemoryUsage");
        return (int)(320000 - num);//((long) DeviceExtendedProperties.GetValue("DeviceTotalMemory") - num);
    }

    public int mrp_getTotalMemory()
    {
        //object obj = DeviceExtendedProperties.GetValue("DeviceTotalMemory");
        //if (obj == null)
        //  return 0;
        //long num = (long) obj;
        return (int)320000;//num > (long) int.MaxValue ? int.MaxValue : (int) num;
    }

    public mrGame.MrGame.MrgString mrp_textinput(
      mrGame.MrGame.MrgString caption,
      mrGame.MrGame.MrgString s,
      int oklabel,
      int len,
      int type)
    {
      this.p_inputtingText = true;
      IAsyncResult result = Guide.BeginShowKeyboardInput(PlayerIndex.One, caption.toString(), "", s.toString(), (AsyncCallback) null, (object) null);
      //Thread.Sleep(0);
      result.AsyncWaitHandle.WaitOne();
      this.p_inputtingText = false;
      return new mrGame.MrGame.MrgString(Guide.EndShowKeyboardInput(result));
    }

    public void customization_preinitUnlock()
    {
    }

        public void customization_unlockInit()
        {
            this.p_isUnlocked = !Guide.IsTrialMode;
        }

        public bool customization_isUnlocked()
        {
            return this.p_isUnlocked;
        }

        public void p_em_selectLanguage()
    {
      if (this.p_options[4] != (sbyte) -1)
        return;
      this.p_em_selectLanguageActive = true;
      this.p_allTexts = new mrGame.MrGame.MrgString[7]
      {
        (mrGame.MrGame.MrgString) "Select Language",
        (mrGame.MrGame.MrgString) "English",
        (mrGame.MrGame.MrgString) "Français",
        (mrGame.MrGame.MrgString) "Español",
        (mrGame.MrGame.MrgString) "Deutsch",
        (mrGame.MrGame.MrgString) "Italiano",
        (mrGame.MrGame.MrgString) "OK"
      };
      this.p_options_multioption = new sbyte[11];
      this.p_em_introMode = false;
      this.p_game_menuInited = true;
      this.p_em_specialStartMenu = -1;
      this.p_em_specialIngameMenu = -1;
      this.p_em_cursorY = -1;
      this.p_em_confirming = false;
      this.p_em_maxLines = (this.dynamic_Y_RES - 1 - this.gfx_getFontHeight(3) - ((this.dynamic_Y_RES >> 4) + 4 + this.gfx_getFontHeight(3))) / this.gfx_getFontHeight(3);
      this.p_em_gotoGame = false;
      this.em_resetStack();
      this.em_pushMenu(4);
      if (this.p_options[4] != (sbyte) -1)
        this.p_em_currentMenuPointer = (int) this.p_options[4];
      this.mrg_resetKeys();
      this.debug_text((mrGame.MrGame.MrgString) ("currentLangIndex:" + (object) this.p_options[4]));
      do
      {
        this.mrp_doTime();
        this.p_eg_logic();
        this.menu_logic();
        if (this.repaintScreen)
        {
          this.mrp_doTime();
          this.p_runKeyEvents();
          if (this.mrp_beginPaint())
          {
            this.p_realPaint();
            this.mrp_endPaint();
          }
          this.mrp_blitScreen();
          do
          {
            this.p_newKeyEvent = false;
            this.mrp_eventCallback(this);
          }
          while (this.p_newKeyEvent);
        }
        this.repaintScreen = false;
        this.p_runKeyEvents();
      }
      while (this.p_em_selectLanguageActive);
      this.debug_text((mrGame.MrGame.MrgString) ("Language Selected currentLangIndex:" + (object) this.p_options[4]));
      this.p_allTexts = new mrGame.MrGame.MrgString[160];
      this.p_options_multioption = (sbyte[]) null;
    }

    public void em_setElementType(int eid, int type, int value)
    {
      this.p_indexTable2[1509 + eid * 4] = (short) type;
      this.p_indexTable2[1509 + (eid * 4 + 1)] = (short) value;
    }

    public void p_em_free() => this.p_options_multioption = (sbyte[]) null;

    public void menu_preinit()
    {
      this.p_options_multioption = new sbyte[11];
      this.p_em_introMode = true;
      this.p_em_specialStartMenu = -1;
      this.p_gameIntroInited = false;
      this.p_game_menuInited = false;
      this.p_em_currentMenuTopic = -1;
      this.p_em_specialIngameMenu = -1;
      this.p_em_cursorY = -1;
      this.p_em_confirming = false;
      this.customization_preinit();
    }

    public void em_setSpecialStartMenu(int menuid) => this.p_em_specialStartMenu = menuid;

    public void em_setSpecialIngameMenu(int menuid) => this.p_em_specialIngameMenu = menuid;

    public void menu_start()
    {
      this.debug_text((mrGame.MrGame.MrgString) ("menu p_start " + (object) this.p_em_introMode + " ingame: " + (object) this.p_inGame));
      if (this.p_em_introMode)
      {
        this.gfx_loadGroup(1);
        this.txt_loadGroup(1);
        if (MediaPlayer.GameHasControl)
          return;
        this.p_options[0] = (sbyte) 0;
        this.p_indexTable2[1535] = (short) 2;
        this.em_confirm(7);
      }
      else
      {
        this.p_em_gotoGame = false;
        this.em_resetStack();
        if (this.p_inGame)
        {
          if (this.p_em_specialIngameMenu != -1)
          {
            this.em_pushMenu(this.p_em_specialIngameMenu);
            this.p_em_specialIngameMenu = -1;
          }
          else
            this.em_pushMenu(2);
          this.sfx_pauseAll();
        }
        else
        {
          this.gfx_loadGroup(2);
          this.txt_loadGroup(2);
          if (!this.p_game_menuInited)
          {
            this.p_customizationStuff();
            if (!this.p_game_menuInited)
            {
              this.emi_init();
              this.p_game_menuInited = true;
            }
          }
          this.em_pushMenu(0);
          if (this.p_em_specialStartMenu == -1)
            return;
          this.em_pushMenu(this.p_em_specialStartMenu);
          this.p_em_specialStartMenu = -1;
        }
      }
    }

    public void menu_unload()
    {
      this.gfx_unloadGroup(2);
      this.txt_unloadGroup(2);
      this.p_em_confirmText = (mrGame.MrGame.MrgString) null;
    }

    public bool menu_logic()
    {
      if (this.p_em_introMode)
      {
        if (!this.p_gameIntroInited && !this.p_em_confirming)
        {
          this.emi_introStart();
          this.p_gameIntroInited = true;
        }
        this.repaintScreen = true;
        return true;
      }
      if (this.p_em_gotoGame)
      {
        this.p_em_dispatchEvent(!this.p_game_menuInited || this.p_em_stackPos < 0 ? 0 : this.p_em_menuStack[this.p_em_stackPos], 1, 1);
        return false;
      }
      this.emi_logic(!this.p_game_menuInited || this.p_em_stackPos < 0 ? 0 : this.p_em_menuStack[this.p_em_stackPos]);
      this.customization_logic();
      this.repaintScreen = true;
      return true;
    }

    public void p_em_dispatchEvent(int menuId, int _event, int param)
    {
      this.debug_text((mrGame.MrGame.MrgString) ("emi_event: " + (object) _event));
      this.emi_event(menuId, _event, param);
      if (!this.em_isCustomizationActive())
        return;
      this.customization_menuEvent(menuId, _event, param);
    }

    public void em_invokeCustomConfirmation(mrGame.MrGame.MrgString text)
    {
      this.p_em_confirming = true;
      this.p_em_confirmText = text;
      this.p_em_confirmElement = -1;
      this.p_em_dispatchEvent(!this.p_game_menuInited || this.p_em_stackPos < 0 ? 0 : this.p_em_menuStack[this.p_em_stackPos], 2, -1);
    }

    public bool em_hasElementConfirmation(int elId)
    {
      return (this.p_indexTable2[1509 + elId * 4] == (short) 3 || this.p_indexTable2[1509 + elId * 4] == (short) 2) && this.p_indexTable2[1509 + (elId * 4 + 1)] == (short) 1;
    }

    public bool em_confirm(int elementid) => this.em_confirm(elementid, false);

    public bool em_confirm(int elementid, bool sizeChanged)
    {
      this.debug_text((mrGame.MrGame.MrgString) ("*********************em_confirm:" + (object) elementid + "******************"));
      if ((!this.customization_isUnlocked() || this.p_indexTable2[1511] == (short) 2) && elementid == 1)
        return true;
      this.debug_text((mrGame.MrGame.MrgString) "em_confirm: 0");
      int num = (int) this.p_indexTable2[1509 + (elementid * 4 + 1)];
      if (this.p_em_confirming || num != 1)
        return true;
      this.debug_text((mrGame.MrGame.MrgString) "em_confirm: 1");
      this.p_em_confirming = true;
      this.p_em_confirmElement = elementid;
      this.p_tb_backupConfirmHandleFlags = this.p_tb_inputHandleFlags;
      this.debug_text((mrGame.MrGame.MrgString) "em_confirm: 2");
      this.debug_text((mrGame.MrGame.MrgString) "em_confirm: 3");
      this.p_em_confirmText = this.txt_stringParam(this.p_allTexts[4], this.p_allTexts[(int) this.p_indexTable2[1509 + (elementid * 4 + 3)]], 1);
      this.p_confirmationPage = 0;
      this.p_em_dispatchEvent(!this.p_game_menuInited || this.p_em_stackPos < 0 ? 0 : this.p_em_menuStack[this.p_em_stackPos], 2, elementid);
      return false;
    }

    public void em_doAction(int elementid, int action)
    {
      int num = (int) this.p_indexTable2[1509 + elementid * 4];
      int index = (int) this.p_indexTable2[1509 + (elementid * 4 + 1)];
      if (!this.customization_doAction(elementid, action))
        return;
      if (num == 1 && action == 1)
        this.em_pushMenu(index);
      if (num == 4 && action == 1)
      {
        this.p_options[index] = (sbyte) (1 - (int) this.p_options[index]);
        this.mrg_saveOptions();
        if (index == 0)
          this.sfx_stopAll();
        if (index == 1 && this.p_options[1] != (sbyte) 0)
          this.mrg_vibrate(300);
        this.emi_optionNotify(index);
      }
      if (num == 6)
      {
        if (action == 1)
          this.p_em_setMultiOption(elementid, index, 65536);
        if (action == 2)
          this.p_em_setMultiOption(elementid, index, 1);
        if (action == 3)
          this.p_em_setMultiOption(elementid, index, -1);
        this.emi_optionNotify(index);
      }
      if (num == 2 && action == 1 && this.em_confirm(elementid))
        this.p_em_runkoAction(elementid);
      if (num != 3 || action != 1 || !this.em_confirm(elementid))
        return;
      this.emi_gameAction(elementid);
    }

    public void p_em_runkoAction(int elementid)
    {
      this.debug_text((mrGame.MrGame.MrgString) ("p_em_runkoAction:" + (object) elementid));
      if (this.p_em_selectLanguageActive)
      {
        this.debug_text((mrGame.MrGame.MrgString) ("selected element:" + (object) elementid));
        this.p_options[4] = (sbyte) (elementid - 16);
        this.p_em_selectLanguageActive = false;
      }
      else
      {
        if (elementid == 11)
        {
          this.debug_text((mrGame.MrGame.MrgString) "p_em_runkoAction:EE_RETURN");
          this.p_em_gotoGame = true;
        }
        if (elementid == 3)
        {
          this.debug_text((mrGame.MrGame.MrgString) "p_em_runkoAction:EE_EXIT");
          this.mrg_exitApp();
        }
        if (elementid == 13)
        {
          this.debug_text((mrGame.MrGame.MrgString) "p_em_runkoAction:EE_BACK");
          this.em_popMenu();
        }
        if (elementid == 14)
        {
          this.debug_text((mrGame.MrGame.MrgString) "p_em_runkoAction:EE_CONFIRMYES");
          if (this.p_em_confirmElement != -1)
          {
            this.em_doAction(this.p_em_confirmElement, 1);
            this.p_em_confirming = false;
            this.debug_text((mrGame.MrGame.MrgString) "RESTORE FLAGS");
            this.p_tb_handleInput(this.p_tb_backupConfirmHandleFlags, false);
          }
          else
            this.p_em_confirming = false;
          if (this.em_isCustomizationActive())
            this.customization_confirmedYes();
          this.p_em_dispatchEvent(!this.p_game_menuInited || this.p_em_stackPos < 0 ? 0 : this.p_em_menuStack[this.p_em_stackPos], 3, this.p_em_confirmElement);
        }
        if (elementid == 15)
        {
          this.debug_text((mrGame.MrGame.MrgString) "EE_CONFIRMNO");
          this.p_em_confirming = false;
          if (this.p_em_confirmElement != -1)
          {
            this.debug_text((mrGame.MrGame.MrgString) "RESTORE FALGS");
            this.p_tb_handleInput(this.p_tb_backupConfirmHandleFlags, false);
          }
          if (this.em_isCustomizationActive())
            this.customization_confirmedNo();
          this.debug_text((mrGame.MrGame.MrgString) ("elementid " + (object) elementid));
          this.p_em_dispatchEvent(!this.p_game_menuInited || this.p_em_stackPos < 0 ? 0 : this.p_em_menuStack[this.p_em_stackPos], 3, this.p_em_confirmElement != 7 ? -1 : this.p_em_confirmElement);
        }
        if (elementid == 10)
          this.p_resetRecordStore();
        if (elementid == 5)
          this.p_hs_resetAll();
        if (elementid != 7)
          return;
        this.p_options[0] = (sbyte) 1;
        MediaPlayer.Stop();
        this.p_indexTable2[1535] = (short) 0;
      }
    }

    public void p_em_exitIntro()
    {
      this.debug_text((mrGame.MrGame.MrgString) "************** p_em_introMode=false; *****************");
      this.p_em_introMode = false;
      this.gfx_unloadGroup(1);
      this.txt_unloadGroup(1);
      this.menu_start();
      this.mrg_resetKeys();
    }

    public void menu_keyPressed(int k)
    {
      if (this.p_em_gotoGame)
        return;
      this.emi_keyPressed(!this.p_game_menuInited || this.p_em_stackPos < 0 ? 0 : this.p_em_menuStack[this.p_em_stackPos], k);
      if (this.p_em_confirming)
        return;
      if (this.p_em_introMode)
      {
        if (!this.p_gameIntroInited || !this.mrg_isKey(k, 327697))
          return;
        this.p_em_exitIntro();
      }
      else
      {
        switch (this.p_em_currentMenuType)
        {
          case 1:
            if (this.customization_isKeyPressed(k, !this.p_game_menuInited || this.p_em_stackPos < 0 ? 0 : this.p_em_menuStack[this.p_em_stackPos]))
              return;
            break;
        }
        if (!this.mrg_isKey(k, 262153))
          return;
        int num = this.p_em_selectLanguageActive ? 1 : 0;
      }
    }

    public void menu_keyReleased(int k)
    {
      this.emi_keyReleased(!this.p_game_menuInited || this.p_em_stackPos < 0 ? 0 : this.p_em_menuStack[this.p_em_stackPos], k);
      if (!this.mrg_isKey(k, 57))
        return;
      this.debug_text((mrGame.MrGame.MrgString) "POINTER RELEASED");
      if (!this.p_em_softkeysPaintedInThisFrame)
        return;
      if (this.p_touchdata[this.p_mt_last].upy > this.dynamic_Y_RES - 1 - this.gfx_getFontHeight(3))
      {
        if (this.p_touchdata[this.p_mt_last].upx < (this.dynamic_X_RES >> 1) - this.gfx_getFontHeight(3))
        {
          this.debug_text((mrGame.MrGame.MrgString) "TRIGGER 1d");
          this.mrp_keyPressed(62);
        }
        else if (this.p_touchdata[this.p_mt_last].upx > (this.dynamic_X_RES >> 1) + this.gfx_getFontHeight(3))
        {
          this.debug_text((mrGame.MrGame.MrgString) "TRIGGER 2d");
          this.mrp_keyPressed(63);
        }
        if (this.p_tb_inputHandleFlags != 0 || this.p_em_currentMenuType == 2)
          return;
        if (this.p_em_isPointerOnArrow(1))
        {
          this.debug_text((mrGame.MrGame.MrgString) "TRIGGER 3e");
          this.mrp_keyPressed(61);
        }
        if (this.p_em_isPointerOnArrow(0))
        {
          this.debug_text((mrGame.MrGame.MrgString) "TRIGGER 4e");
          this.mrp_keyPressed(60);
        }
        if (this.p_em_isPointerOnArrow(2))
        {
          this.debug_text((mrGame.MrGame.MrgString) "TRIGGER 5e");
          this.mrp_keyPressed(58);
        }
        if (!this.p_em_isPointerOnArrow(3))
          return;
        this.debug_text((mrGame.MrGame.MrgString) "TRIGGER 6e");
        this.mrp_keyPressed(59);
      }
      else if (this.p_em_isPointerOnArrow(1))
      {
        this.debug_text((mrGame.MrGame.MrgString) "TRIGGER 3f");
        this.mrp_keyPressed(61);
      }
      else if (this.p_em_isPointerOnArrow(0))
      {
        this.debug_text((mrGame.MrGame.MrgString) "TRIGGER 4f");
        this.mrp_keyPressed(60);
      }
      else
      {
        if (this.p_em_confirming || this.p_em_currentMenuType != 4)
          return;
        this.mrp_keyPressed((int) this.p_indexTable2[6] - 10);
      }
    }

    public void em_resetStack() => this.p_em_stackPos = -1;

    public int em_getMenuType(int menuId)
    {
      return (int) (short) ((int) this.p_indexTable2[1388 + (int) this.p_indexTable2[1491 + menuId]] & -32769);
    }

    public bool em_isCustomizationActive()
    {
      return ((int) this.p_indexTable2[1388 + (int) this.p_indexTable2[1491 + (!this.p_game_menuInited || this.p_em_stackPos < 0 ? 0 : this.p_em_menuStack[this.p_em_stackPos])]] & 32768) != 0;
    }

    public mrGame.MrGame.MrgString em_getCurrentMenuText()
    {
      if (this.em_isCustomizationActive())
      {
        mrGame.MrGame.MrgString text = this.customization_getText();
        if (!(text == (mrGame.MrGame.MrgString) null))
          return text;
      }
      return this.p_em_currentMenuTextboxString;
    }

    public int em_getAmountOfVisibleElements(int menuId)
    {
      int num1 = (int) this.p_indexTable2[1491 + menuId];
      switch (this.p_indexTable2[1388 + num1])
      {
        case 0:
        case 5:
          int ofVisibleElements = 0;
          for (int index = 3; index < (int) this.p_indexTable2[1388 + (num1 + 2)] + 3; ++index)
          {
            int num2 = (int) this.p_indexTable2[1388 + (num1 + index)];
            if (num2 != -1 && this.p_indexTable2[1509 + (num2 * 4 + 2)] != (short) 2)
              ++ofVisibleElements;
          }
          return ofVisibleElements;
        default:
          return 0;
      }
    }

    public int em_getMenuTopic(int menuId)
    {
      return (int) this.p_indexTable2[1388 + ((int) this.p_indexTable2[1491 + menuId] + 1)];
    }

    public int em_getVisibleMenuElement(int menuId, int n)
    {
      int num1 = (int) this.p_indexTable2[1491 + menuId];
      int num2 = (int) this.p_indexTable2[1388 + num1];
      int num3 = 0;
      for (int index = 3; index < (int) this.p_indexTable2[1388 + (num1 + 2)] + 3; ++index)
      {
        int visibleMenuElement = (int) this.p_indexTable2[1388 + (num1 + index)];
        if (visibleMenuElement != -1 && this.p_indexTable2[1509 + (visibleMenuElement * 4 + 2)] != (short) 2)
        {
          if (num3 == n)
            return visibleMenuElement;
          ++num3;
        }
      }
      return -1;
    }

    public void p_em_resolutionChanged()
    {
      if (!this.p_mainGroupsLoaded)
        return;
      this.p_em_initCurrentMenuEx(true);
    }

    public void p_em_initCurrentMenu() => this.p_em_initCurrentMenuEx(false);

    public void p_em_initCurrentMenuEx(bool resolutionChanged)
    {
      int pEmMenu = this.p_em_menuStack[this.p_em_stackPos];
      int num1 = (int) this.p_indexTable2[1491 + pEmMenu];
      this.p_em_currentMenuType = (int) (short) ((int) this.p_indexTable2[1388 + num1] & -32769);
      this.p_em_currentMenuTopic = (int) this.p_indexTable2[1388 + (num1 + 1)];
      this.p_em_currentMenuLength = 0;
      this.p_em_currentMenuScroll = 0;
      this.debug_text((mrGame.MrGame.MrgString) "init 0");
      this.p_tb_handleInput(0, false);
      int num2 = this.p_mainGroupsLoaded ? this.gfx_getFontHeight(3) : 15;
      if (num2 != 0)
        this.p_em_maxLines = (this.dynamic_Y_RES - 1 - this.gfx_getFontHeight(3) - ((this.dynamic_Y_RES >> 4) + 4 + this.gfx_getFontHeight(3))) / num2;
      if (this.p_em_currentMenuScroll > this.p_em_currentMenuPointer)
        this.p_em_currentMenuScroll = this.p_em_currentMenuPointer;
      if (this.p_em_currentMenuScroll <= this.p_em_currentMenuPointer - this.p_em_maxLines)
        this.p_em_currentMenuScroll = this.p_em_currentMenuPointer - this.p_em_maxLines + 1;
      if (!this.customization_isUnlocked() && (!this.p_game_menuInited || this.p_em_stackPos < 0 ? 0 : this.p_em_menuStack[this.p_em_stackPos]) == 0)
        this.p_indexTable2[1511] = (short) 2;
      if (this.customization_isUnlocked())
      {
        this.p_indexTable2[1595] = (short) 2;
        this.p_indexTable2[1603] = (short) 0;
        this.p_indexTable2[1599] = (short) 0;
      }
      else
      {
        this.p_indexTable2[1595] = (short) 0;
        this.p_indexTable2[1603] = (short) 1;
        this.p_indexTable2[1599] = (short) 1;
      }
      this.debug_text((mrGame.MrGame.MrgString) ("initcurrentmenu: menuid=" + (object) pEmMenu + ", index=" + (object) num1));
      if (this.p_em_currentMenuType == 0)
      {
        int num3 = -1;
        for (int index = 3; index < (int) this.p_indexTable2[1388 + (num1 + 2)] + 3; ++index)
        {
          int num4 = (int) this.p_indexTable2[1388 + (num1 + index)];
          if (num4 != -1 && this.p_indexTable2[1509 + (num4 * 4 + 2)] != (short) 2)
          {
            this.p_em_currentMenuElements[this.p_em_currentMenuLength] = num4;
            if (num3 == -1 && this.p_indexTable2[1509 + (num4 * 4 + 2)] == (short) 0)
              num3 = this.p_em_currentMenuLength;
            ++this.p_em_currentMenuLength;
          }
        }
      }
      else if (this.p_em_currentMenuType == 1)
      {
        mrGame.MrGame.MrgString mrgString = (mrGame.MrGame.MrgString) "";
        int num5 = (int) this.p_indexTable2[1388 + (num1 + 2)];
        int table = (int) this.p_indexTable2[1388 + (num1 + 3)];
        switch (num5)
        {
          case 1:
            mrgString = this.p_allTexts[table];
            if (pEmMenu == 9)
            {
              mrgString = mrgString + (mrGame.MrGame.MrgString) "\n\n" + this.p_allTexts[31];
              break;
            }
            break;
          case 2:
            if (table < 256)
            {
              mrgString = this.hs_getHighscore_text(table);
              break;
            }
            break;
        }
        this.p_em_currentMenuTextboxString = mrgString;
        this.p_em_textboxCurrentLine = 0;
        ++this.p_em_currentMenuLength;
      }
      this.emi_menuInitCallback(pEmMenu);
      if (!this.p_em_introMode && !this.p_em_confirming)
      {
        if (resolutionChanged)
          this.p_em_dispatchEvent(pEmMenu, 4, 0);
        else
          this.p_em_dispatchEvent(pEmMenu, 0, 0);
      }
      this.p_em_updateCursorY();
    }

    public void em_storeActiveElement(int id)
    {
      if (this.p_em_stackPos < 0)
        return;
      this.p_em_pointerStack[this.p_em_stackPos] = id;
    }

    public void em_pushMenu(int menuid)
    {
      if (this.p_em_stackPos >= 0)
        this.p_em_dispatchEvent(!this.p_game_menuInited || this.p_em_stackPos < 0 ? 0 : this.p_em_menuStack[this.p_em_stackPos], 1, 0);
      this.debug_text((mrGame.MrGame.MrgString) ("push menu: " + (object) menuid));
      ++this.p_em_stackPos;
      this.p_em_menuStack[this.p_em_stackPos] = menuid;
      if (this.em_getMenuType(menuid) == 0 || this.em_getMenuType(menuid) == 5)
        this.p_em_pointerStack[this.p_em_stackPos] = -1;
      this.p_em_initCurrentMenu();
      for (int index = 0; index < 11; ++index)
        this.p_options_multioption[index] = this.p_options[index];
    }

    public void em_selectItem(int elId)
    {
      if (this.em_isCustomizationActive() && this.customization_continueRequested())
        return;
      this.em_doAction(elId, 1);
    }

    public void em_back()
    {
      if (this.em_isCustomizationActive() && this.customization_backRequested())
        return;
      if (this.p_em_stackPos > 0)
        this.em_popMenu();
      else if (!this.p_inGame)
        this.em_doAction(3, 1);
      else
        this.p_em_gotoGame = true;
    }

    public void em_popMenu()
    {
      this.debug_text((mrGame.MrGame.MrgString) "********************* em_popMenu()");
      this.p_em_dispatchEvent(!this.p_game_menuInited || this.p_em_stackPos < 0 ? 0 : this.p_em_menuStack[this.p_em_stackPos], 1, 0);
      --this.p_em_stackPos;
      this.p_em_currentMenuPointer = this.p_em_pointerStack[this.p_em_stackPos];
      this.p_em_initCurrentMenu();
    }

    public int em_getElementPosition(int menuid, int elementid)
    {
      int num = (int) this.p_indexTable2[1491 + menuid];
      for (int elementPosition = 0; elementPosition < (int) this.p_indexTable2[1388 + (num + 2)]; ++elementPosition)
      {
        if ((int) this.p_indexTable2[1388 + (num + 3 + elementPosition)] == elementid)
          return elementPosition;
      }
      this.debug_text((mrGame.MrGame.MrgString) ("error menuelement " + (object) elementid + " not found from menu " + (object) menuid));
      return -1;
    }

    public int em_getElementAmount(int menuid)
    {
      return (int) this.p_indexTable2[1388 + ((int) this.p_indexTable2[1491 + menuid] + 2)];
    }

    public int em_getElementIdAtPos(int menuid, int pos)
    {
      return (int) this.p_indexTable2[1388 + ((int) this.p_indexTable2[1491 + menuid] + pos + 3)];
    }

    public void em_insertElementToPosition(int menuid, int elementid, int pos)
    {
      this.debug_text((mrGame.MrGame.MrgString) ("*******em_insertElementAtPosition:" + (object) menuid + "," + (object) elementid + "," + (object) pos));
      int num = (int) this.p_indexTable2[1491 + menuid];
      for (int index = (int) this.p_indexTable2[1388 + (num + 2)] - 1; index > pos; --index)
        this.p_indexTable2[1388 + (num + index + 3)] = this.p_indexTable2[1388 + (num + index + 2)];
      this.p_indexTable2[1388 + (num + pos + 3)] = (short) elementid;
    }

    public void em_insertElement(int menuid, int elementid, int beforeElement)
    {
      this.debug_text((mrGame.MrGame.MrgString) ("*******em_insertElement:" + (object) menuid + "," + (object) elementid + "," + (object) beforeElement));
      this.em_insertElementToPosition(menuid, elementid, this.em_getElementPosition(menuid, beforeElement));
    }

    public void em_addElement(int menuid, int elementid, int afterElement)
    {
      this.debug_text((mrGame.MrGame.MrgString) ("*******em_addElement:" + (object) menuid + "," + (object) elementid + "," + (object) afterElement));
      int elementPosition = this.em_getElementPosition(menuid, afterElement);
      int num = (int) this.p_indexTable2[1491 + menuid];
      this.debug_text((mrGame.MrGame.MrgString) ("*******new beforeElement pos:" + (object) (num + 4 + elementPosition)));
      this.em_insertElement(menuid, elementid, (int) this.p_indexTable2[1388 + (num + 4 + elementPosition)]);
    }

    public void em_replaceElement(int menuId, int newId, int oldId)
    {
      int elementPosition = this.em_getElementPosition(menuId, oldId);
      this.p_indexTable2[1388 + ((int) this.p_indexTable2[1491 + menuId] + 3 + elementPosition)] = (short) newId;
    }

    public void em_removeElement(int menuid, int elementid)
    {
      int elementPosition = this.em_getElementPosition(menuid, elementid);
      int num1 = (int) this.p_indexTable2[1491 + menuid];
      int num2 = (int) this.p_indexTable2[1388 + (num1 + 2)];
      for (int index = elementPosition; index < num2 - 1; ++index)
        this.p_indexTable2[1388 + (num1 + index + 3)] = this.p_indexTable2[1388 + (num1 + index + 4)];
      this.p_indexTable2[1388 + (num1 + num2 + 2)] = (short) -1;
    }

    public int em_getCurrentMenuElementHeight()
    {
      return this.p_em_currentMenuType != 0 ? 0 : (this.p_mainGroupsLoaded ? this.gfx_getFontHeight(3) : 15);
    }

    public int em_getCurrentMenuHeight()
    {
      if (this.p_em_currentMenuType != 0)
        return 0;
      int currentMenuHeight = this.p_em_currentMenuLength * (this.p_mainGroupsLoaded ? this.gfx_getFontHeight(3) : 15);
      if (currentMenuHeight > this.dynamic_Y_RES - 1 - this.gfx_getFontHeight(3) - ((this.dynamic_Y_RES >> 4) + 4 + this.gfx_getFontHeight(3)))
        currentMenuHeight = this.dynamic_Y_RES - 1 - this.gfx_getFontHeight(3) - ((this.dynamic_Y_RES >> 4) + 4 + this.gfx_getFontHeight(3));
      return currentMenuHeight;
    }

    public int em_getCurrentMenuWidth()
    {
      if (this.p_em_currentMenuType != 0)
        return 0;
      int currentMenuPointer = this.p_em_currentMenuPointer;
      int currentMenuWidth = 0;
      for (int index = 0; index < this.p_em_currentMenuLength; ++index)
      {
        this.p_em_currentMenuPointer = index;
        int selectWidth = this.em_getSelectWidth(3);
        if (selectWidth > currentMenuWidth)
          currentMenuWidth = selectWidth;
      }
      this.p_em_currentMenuPointer = currentMenuPointer;
      return currentMenuWidth;
    }

    public int em_getSelectWidth(int font)
    {
      int num = this.p_em_currentMenuElements[this.p_em_currentMenuPointer] * 4;
      int index = (int) this.p_indexTable2[1509 + (num + 1)];
      mrGame.MrGame.StringBuffer stringBuffer = new mrGame.MrGame.StringBuffer();
      stringBuffer.append(this.p_allTexts[(int) this.p_indexTable2[1509 + (num + 3)]]);
      int selectWidth;
      if (this.p_indexTable2[1509 + num] == (short) 4)
      {
        stringBuffer.append(" : ");
        stringBuffer.append(this.p_options[index] != (sbyte) 0 ? this.p_allTexts[10] : this.p_allTexts[11]);
        selectWidth = this.gfx_stringWidth(font, stringBuffer.toString());
      }
      else if (this.p_indexTable2[1509 + num] == (short) 6)
      {
        stringBuffer.append(" : ");
        stringBuffer.append(this.p_em_getMultiOptionText(this.p_em_currentMenuElements[this.p_em_currentMenuPointer], (int) this.p_options_multioption[index]));
        selectWidth = this.gfx_stringWidth(font, stringBuffer.toString());
      }
      else
        selectWidth = this.gfx_stringWidth(font, stringBuffer.toString());
      return selectWidth;
    }

    public mrGame.MrGame.MrgString p_em_getMultiOptionText(int elementid, int value)
    {
      return (mrGame.MrGame.MrgString) "";
    }

    public void p_em_setMultiOption(int elementid, int optionIndex, int value)
    {
    }

    public bool p_em_isPointerOnArrow(int n)
    {
      bool flag1 = false;
      bool flag2 = false;
      bool flag3 = false;
      bool flag4 = false;
      if (this.p_touchdata[this.p_mt_last].upy > this.dynamic_Y_RES - 1 - this.gfx_getFontHeight(3) && this.p_touchdata[this.p_mt_last].upx > (this.dynamic_X_RES >> 1) - ((this.p_mainGroupsLoaded ? this.gfx_getFontHeight(3) : 15) >> 1) && this.p_touchdata[this.p_mt_last].upx < (this.dynamic_X_RES >> 1) + ((this.p_mainGroupsLoaded ? this.gfx_getFontHeight(3) : 15) >> 1))
      {
        if (this.p_touchdata[this.p_mt_last].upy < this.dynamic_Y_RES - 1 - this.gfx_getFontHeight(3) + ((this.p_mainGroupsLoaded ? this.gfx_getFontHeight(3) : 15) >> 1))
          flag3 = true;
        if (this.p_touchdata[this.p_mt_last].upy > this.dynamic_Y_RES - 1 - this.gfx_getFontHeight(3) + ((this.p_mainGroupsLoaded ? this.gfx_getFontHeight(3) : 15) >> 1))
          flag4 = true;
      }
      return n == 0 && flag1 || n == 1 && flag2 || n == 2 && flag3 || n == 3 && flag4;
    }

    public void customization_preinit()
    {
      this.customization_menuid = -1;
      this.customization_initialStartElementTextIndex = (short) -1;
      this.customization_preinitUnlock();
    }

    public bool customization_isKeyPressed(int k, int menuid) => false;

    public bool customization_doAction(int elementid, int action)
    {
      if (action != 1 || elementid != 21)
        return true;
      this.customization_launchPurchase(!this.p_game_menuInited || this.p_em_stackPos < 0 ? 0 : this.p_em_menuStack[this.p_em_stackPos]);
      return false;
    }

    public void customization_keyPressedPurchaseSplash(int k, int menuId)
    {
      this.debug_text((mrGame.MrGame.MrgString) ("customization_keyPressedPurchaseSplash k:" + (object) k));
      if (this.mrg_isKey(k, 69))
      {
        if (this.p_tb_lineCount <= 0 || this.p_tb_scroll >= (int) this.p_tb_lines[this.p_tb_lineCount - 1] << 10)
          return;
        this.p_tb_changeLine(2);
      }
      else if (this.mrg_isKey(k, 68))
      {
        if (this.p_tb_scroll <= 0)
          return;
        this.p_tb_changeLine(4);
      }
      else
      {
        if (this.mrg_isKey(k, 262153) || !this.mrg_isKey(k, 196614))
          return;
        this.customization_launchPurchase(menuId);
      }
    }

    public void customization_launchPurchase(int menuId)
    {
      Guide.ShowMarketplace(PlayerIndex.One);

      //while (Guide.IsVisible)
      //  Thread.Sleep(500);
      
      this.p_isUnlocked = !Guide.IsTrialMode;
      this.p_em_initCurrentMenu();
    }

    public void customization_init()
    {
    }

    public bool customization_isMakeSplash(int menuid)
    {
      this.customization_menuid = menuid;
      return false;
    }

    public bool customization_isDrawSplash(int menuid) => false;

    public mrGame.MrGame.MrgString customization_stripQuotes(mrGame.MrGame.MrgString url)
    {
      for (int index = 0; index < url.length(); ++index)
      {
        if (url.charAt(index) == '"')
          url = url.substring(0, index) + url.substring(index + 1, url.length() - index - 1);
      }
      return url;
    }

    public void customization_paintSoftkeys(int back_text_index, int select_text_index)
    {
      this.p_em_softkeysPaintedInThisFrame = true;
      if (this.p_lb_fillScreen)
        return;
      if (this.p_touchdata[this.p_mt_last].upy > this.dynamic_Y_RES - 1 - this.gfx_getFontHeight(3) && this.p_touchdata[this.p_mt_last].upy < this.dynamic_Y_RES && this.p_touchdata[this.p_mt_last].upx >= (this.dynamic_X_RES >> 1) - this.gfx_getFontHeight(3))
      {
        int upx = this.p_touchdata[this.p_mt_last].upx;
        int num = (this.dynamic_X_RES >> 1) + this.gfx_getFontHeight(3);
      }
      this.gfx_setColor(0);
      if (select_text_index != -1)
        this.gfx_drawString(3, this.p_allTexts[select_text_index], this.dynamic_X_RES >> 6, this.dynamic_Y_RES - 1 - this.gfx_getFontHeight(3), 20);
      this.gfx_setColor(0);
      if (back_text_index == -1)
        return;
      this.gfx_drawString(3, this.p_allTexts[back_text_index], this.dynamic_X_RES - (this.dynamic_X_RES >> 6), this.dynamic_Y_RES - 1 - this.gfx_getFontHeight(3), 24);
    }

    public bool customization_isCustomizationMenu(int currentMenuId) => false;

    public void p_customizationStuff()
    {
      this.debug_text((mrGame.MrGame.MrgString) "******************* p_customizationStuff()");
      this.customization_unlockInit();
      if (!this.customization_isUnlocked())
      {
        this.p_indexTable2[1516] = (short) 23;
      }
      else
      {
        this.debug_text((mrGame.MrGame.MrgString) "******************* resetting start element label");
        this.p_indexTable2[1516] = this.customization_initialStartElementTextIndex;
      }
      this.customization_init();
      if (!this.customization_isUnlocked())
        return;
      this.debug_text((mrGame.MrGame.MrgString) "******************* activating disabled start element");
      this.p_indexTable2[1515] = (short) 0;
    }

    public void p_customizationUnlockMenus()
    {
      this.p_indexTable2[1516] = this.customization_initialStartElementTextIndex;
    }

    public mrGame.MrGame.MrgString customization_getText() => (mrGame.MrGame.MrgString) null;

    public int customization_getContinueKeyHint()
    {
      int pEmMenu = !this.p_game_menuInited || this.p_em_stackPos < 0 ? 0 : this.p_em_menuStack[this.p_em_stackPos];
      return -2;
    }

    public int customization_getBackKeyHint()
    {
      int pEmMenu = !this.p_game_menuInited || this.p_em_stackPos < 0 ? 0 : this.p_em_menuStack[this.p_em_stackPos];
      return -2;
    }

    public void customization_menuEvent(int menuId, int eventId, int eventParam)
    {
      switch (eventId)
      {
        case 0:
        case 4:
          this.customization_isMakeSplash(menuId);
          break;
      }
    }

    public void customization_paint(int menuId) => this.customization_isDrawSplash(menuId);

    public void customization_logic()
    {
    }

    public bool customization_continueRequested()
    {
      return this.customization_isKeyPressed(4, !this.p_game_menuInited || this.p_em_stackPos < 0 ? 0 : this.p_em_menuStack[this.p_em_stackPos]);
    }

    public bool customization_backRequested()
    {
      return this.customization_isKeyPressed(10, !this.p_game_menuInited || this.p_em_stackPos < 0 ? 0 : this.p_em_menuStack[this.p_em_stackPos]);
    }

    public void customization_confirmedYes()
    {
    }

    public void customization_confirmedNo()
    {
    }

    public void p_em_updateCursorY()
    {
      if (this.p_em_currentMenuType == 0)
      {
        int num = this.p_mainGroupsLoaded ? this.gfx_getFontHeight(3) : 15;
        this.p_em_cursorY = (this.dynamic_Y_RES >> 4) + 4 + this.gfx_getFontHeight(3) + (this.p_em_currentMenuPointer - this.p_em_currentMenuScroll) * num;
      }
      else
        this.p_em_cursorY = -1;
      if (!this.p_em_confirming)
        return;
      this.p_em_cursorY = -1;
    }

    public int em_getContinueKeyHint() => this.em_getContinueKeyHint(-1);

    public int em_getContinueKeyHint(int selectedMenuElemntId)
    {
      if (this.em_isCustomizationActive())
      {
        int continueKeyHint = this.customization_getContinueKeyHint();
        if (continueKeyHint != -2)
          return continueKeyHint;
      }
      if (!this.p_mainGroupsLoaded)
        return -1;
      if (this.p_em_introMode)
        return 147;
      if (this.p_em_confirming)
        return 2;
      return this.eg_getElementType(this.eg_getFocusElementId()) == 0 ? 5 : -1;
    }

    public int em_getBackKeyHint() => this.em_getBackKeyHint(-1);

    public int em_getBackKeyHint(int selectedMenuElement)
    {
      if (this.em_isCustomizationActive())
      {
        int backKeyHint = this.customization_getBackKeyHint();
        if (backKeyHint != -2)
          return backKeyHint;
      }
      if (!this.p_mainGroupsLoaded)
        return -1;
      if (this.p_em_confirming)
        return 3;
      if (this.p_em_stackPos > 0)
        return 6;
      return this.p_inGame ? 9 : -1;
    }

    public void em_paintScrollArrows(bool up, bool down)
    {
      if (this.p_lb_fillScreen)
        return;
      int num1 = this.dynamic_Y_RES - (this.dynamic_Y_RES - 1 - this.gfx_getFontHeight(3)) >> 1;
      int num2 = this.dynamic_Y_RES - num1;
      int x1_1 = this.dynamic_X_RES >> 1;
      int num3 = num1;
      this.gfx_setColor(0);
      if (up)
        this.gfx_fillTriangle(x1_1 - num3, num2 - 1, x1_1, num2 - num1 - 1, x1_1 + num3, num2 - 1);
      if (down)
        this.gfx_fillTriangle(x1_1 - num3, num2 + 1, x1_1, num2 + num1 + 1, x1_1 + num3, num2 + 1);
      int x1_2 = x1_1 + 1;
      int num4 = num2 - 1;
      bool flag1 = this.p_em_isPointerOnArrow(2);
      bool flag2 = this.p_em_isPointerOnArrow(3);
      if (flag1)
        this.gfx_setColor(16777215);
      else
        this.gfx_setColor(11184810);
      if (up)
        this.gfx_fillTriangle(x1_2 - num3, num4 - 1, x1_2, num4 - num1 - 1, x1_2 + num3, num4 - 1);
      if (flag2)
        this.gfx_setColor(16777215);
      else
        this.gfx_setColor(11184810);
      if (!down)
        return;
      this.gfx_fillTriangle(x1_2 - num3, num4 + 1, x1_2, num4 + num1 + 1, x1_2 + num3, num4 + 1);
    }

    public void em_paintSideScrollArrows(bool left, bool right, int gap, int y)
    {
      if (this.p_lb_fillScreen)
        return;
      int y1 = y + ((this.p_mainGroupsLoaded ? this.gfx_getFontHeight(3) : 15) >> 1);
      int num1 = (this.p_mainGroupsLoaded ? this.gfx_getFontHeight(3) : 15) >> 1;
      int num2 = gap >> 1;
      int num3 = (this.dynamic_X_RES >> 1) - num2;
      int num4 = (this.dynamic_X_RES >> 1) + num2;
      int num5 = (num1 & 1) != 0 ? num1 : num1 + 1;
      bool flag = false;
      if (num3 - num5 < 0)
      {
        num3 = num5;
        flag = true;
      }
      if (num4 + num5 >= this.dynamic_X_RES)
      {
        num4 = this.dynamic_X_RES - num5;
        flag = true;
      }
      if (flag && !this.cursorBlink)
        return;
      this.gfx_setColor(this.p_em_isPointerOnArrow(0) ? 16777215 : 11184810);
      if (left)
        this.gfx_fillTriangle(num3 - 1, y1 - num1, num3 - num5, y1, num3 - 1, y1 + num1);
      this.gfx_setColor(this.p_em_isPointerOnArrow(1) ? 16777215 : 11184810);
      if (!right)
        return;
      this.gfx_fillTriangle(num4 + 1, y1 - num1, num4 + num5, y1, num4 + 1, y1 + num1);
    }

    public void em_paintScrollbar(int value, int visible, int maximum)
    {
      this.gfx_setColor(6974058);
      int num1 = this.dynamic_Y_RES - 1 - this.gfx_getFontHeight(3) - ((this.dynamic_Y_RES >> 4) + 4 + this.gfx_getFontHeight(3)) - this.dynamic_X_RES / 24;
      int num2 = num1 * value / maximum;
      int h = num1 * visible / maximum + (num1 * visible % maximum == 0 ? 0 : 1);
      this.gfx_fillArc(this.dynamic_X_RES - this.dynamic_X_RES / 20, (this.dynamic_Y_RES >> 4) + 4 + this.gfx_getFontHeight(3) + num2, this.dynamic_X_RES / 24, this.dynamic_X_RES / 24, 0, 360);
      this.gfx_fillArc(this.dynamic_X_RES - this.dynamic_X_RES / 20, (this.dynamic_Y_RES >> 4) + 4 + this.gfx_getFontHeight(3) + num2 + h, this.dynamic_X_RES / 24, this.dynamic_X_RES / 24, 0, 360);
      this.gfx_fillRect(this.dynamic_X_RES - this.dynamic_X_RES / 20, (this.dynamic_Y_RES >> 4) + 4 + this.gfx_getFontHeight(3) + num2 + (this.dynamic_X_RES / 24 >> 1), this.dynamic_X_RES / 24, h);
    }

    public void em_paintSoftkeys(int back_text_index, int select_text_index)
    {
      if (this.p_lb_fillScreen)
        return;
      this.p_em_softkeysPaintedInThisFrame = true;
      this.gfx_setBackgroundColor(0);
      bool flag1 = false;
      bool flag2 = false;
      if (this.p_touchdata[this.p_mt_last].upy > this.dynamic_Y_RES - 1 - this.gfx_getFontHeight(3) && this.p_touchdata[this.p_mt_last].upy < this.dynamic_Y_RES)
      {
        if (this.p_touchdata[this.p_mt_last].upx < (this.dynamic_X_RES >> 1) - this.gfx_getFontHeight(3))
          flag1 = true;
        else if (this.p_touchdata[this.p_mt_last].upx > (this.dynamic_X_RES >> 1) + this.gfx_getFontHeight(3))
          flag2 = true;
      }
      this.gfx_setColor(11184810);
      if (flag1)
        this.gfx_setColor(16777215);
      if (select_text_index != -1)
        this.gfx_drawString(this.p_mainGroupsLoaded ? 3 : 0, this.p_allTexts[select_text_index], this.dynamic_X_RES >> 6, this.dynamic_Y_RES - 1 - this.gfx_getFontHeight(3), 20);
      this.gfx_setColor(11184810);
      if (flag2)
        this.gfx_setColor(16777215);
      if (back_text_index == -1)
        return;
      this.gfx_drawString(this.p_mainGroupsLoaded ? 3 : 0, this.p_allTexts[back_text_index], this.dynamic_X_RES - (this.dynamic_X_RES >> 6), this.dynamic_Y_RES - 1 - this.gfx_getFontHeight(3), 24);
    }

    public void em_drawTopic()
    {
      this.gfx_setBackgroundColor(0);
      this.gfx_setColor(16711680);
      this.gfx_drawString(this.p_mainGroupsLoaded ? 3 : 0, this.p_allTexts[this.p_em_currentMenuTopic], this.dynamic_X_RES >> 1, this.dynamic_Y_RES >> 4, 17);
    }

    public void menu_paint()
    {
      this.p_em_softkeysPaintedInThisFrame = false;
      this.gfx_setClip(0, 0, this.dynamic_X_RES, this.dynamic_Y_RES);
      if (this.p_em_confirming)
        this.emi_paint(!this.p_game_menuInited || this.p_em_stackPos < 0 ? 0 : this.p_em_menuStack[this.p_em_stackPos]);
      else if (this.p_em_introMode)
      {
        this.emi_introPaint();
      }
      else
      {
        this.emi_paint(!this.p_game_menuInited || this.p_em_stackPos < 0 ? 0 : this.p_em_menuStack[this.p_em_stackPos]);
        this.customization_paint(!this.p_game_menuInited || this.p_em_stackPos < 0 ? 0 : this.p_em_menuStack[this.p_em_stackPos]);
      }
    }

    public mrGame.MrGame.MrgString uid_getDeviceID() => (mrGame.MrGame.MrgString) "";

    public mrGame.MrGame.MrgString uid_getId()
    {
      if (this.p_uid_instanceId == (mrGame.MrGame.MrgString) null)
        this.p_uid_loadInstanceID();
      if (this.p_uid_instanceId == (mrGame.MrGame.MrgString) null)
      {
        this.p_uid_instanceId = (mrGame.MrGame.MrgString) string.Concat((object) this.p_xna_getCurrentMS());
        this.p_uid_instanceId = this.p_uid_instanceId.substring(this.p_uid_instanceId.length() - 9 < 0 ? 0 : this.p_uid_instanceId.length() - 9);
        mrGame.MrGame.MrgString mrgString = (mrGame.MrGame.MrgString) string.Concat((object) this.smoothtime);
        this.p_uid_instanceId = (mrGame.MrGame.MrgString) "" + this.p_uid_instanceId + mrgString.substring(mrgString.length() - 6 < 0 ? 0 : mrgString.length() - 6);
        if (this.p_uid_instanceId.length() > 15)
          this.p_uid_instanceId = this.p_uid_instanceId.substring(0, 14);
        this.p_uid_saveInstanceID();
      }
      return this.p_uid_instanceId;
    }

    public bool p_uid_saveInstanceID()
    {
      if (this.p_uid_instanceId == (mrGame.MrGame.MrgString) null)
        return false;
      try
      {
        this.be_newArray();
        this.be_writeString(this.p_uid_instanceId);
        sbyte[] byteArray = this.be_getByteArray();
        this.be_close();
        this.mrg_saveData((mrGame.MrGame.MrgString) "p_uid_uid", byteArray);
        return true;
      }
      catch (Exception ex)
      {
      }
      return false;
    }

    public bool p_uid_loadInstanceID()
    {
      sbyte[] a = this.mrg_loadData((mrGame.MrGame.MrgString) "p_uid_uid");
      if (a != null)
      {
        sbyte[] numArray;
        try
        {
          this.p_bytecodec_istream = this.byte_array_createInput(a);
          this.p_uid_instanceId = this.bi_getString(this.p_bytecodec_istream);
          this.p_bytecodec_istream = this.p_bi_free(this.p_bytecodec_istream);
          numArray = (sbyte[]) null;
          return true;
        }
        catch (Exception ex)
        {
        }
        numArray = (sbyte[]) null;
      }
      return false;
    }

    public int p_eg_getSelectorVisualValue(int realId)
    {
      if (!this.p_eg_elementList[realId].isDragging)
        return this.EG_NERP(this.p_eg_elementList[realId]._params[4], this.p_eg_elementList[realId]._params[3] << 10, this.smoothtime - this.p_eg_elementList[realId]._params[5], 250);
      int num1 = this.p_eg_elementList[realId]._params[0];
      int num2 = this.p_eg_elementList[realId]._params[1] - num1;
      if (this.p_eg_elementList[realId]._params[2] == 0)
      {
        int num3 = this.p_eg_pointerX() - this.p_eg_scrX(realId);
        int w = this.p_eg_elementList[realId].w;
        if (num3 < 0)
          num3 = 0;
        if (num3 > w)
          num3 = w;
        return (num1 + num2 * num3 << 10) / w;
      }
      int num4 = this.p_eg_pointerY() - this.p_eg_scrY(realId);
      int h = this.p_eg_elementList[realId].h;
      if (num4 < 0)
        num4 = 0;
      if (num4 > h)
        num4 = h;
      return (num1 + num2 * num4 << 10) / h;
    }

    public void p_eg_selectorIncrease(int realId)
    {
      this.p_eg_setSelectorValue(realId, this.p_eg_getSelectorValue(realId) + 1);
    }

    public void p_eg_selectorDecrease(int realId)
    {
      this.p_eg_setSelectorValue(realId, this.p_eg_getSelectorValue(realId) - 1);
    }

    public int p_eg_getSelectorValue(int realId) => this.p_eg_elementList[realId]._params[3];

    public int eg_getSelectorValue(int elId)
    {
      int realId = this.p_eg_getRealId(elId);
      return realId != -1 ? this.p_eg_getSelectorValue(realId) : 0;
    }

    public void p_eg_selector_pressEvent(int realId)
    {
      int num1 = this.p_eg_elementList[realId]._params[1] - this.p_eg_elementList[realId]._params[0];
      int num2 = this.p_eg_elementList[realId]._params[0];
      int num3;
      int num4;
      if (this.p_eg_elementList[realId]._params[2] == 0)
      {
        num3 = this.p_eg_pointerX() - this.p_eg_scrX(realId);
        num4 = this.p_eg_elementList[realId].w;
      }
      else
      {
        num3 = this.p_eg_pointerY() - this.p_eg_scrY(realId);
        num4 = this.p_eg_elementList[realId].h;
      }
      int num5 = num2 + (num3 * num1 + (num4 >> 1)) / num4;
      this.p_eg_setSelectorValue(realId, num5);
    }

    public void p_eg_selector_dragEvent(int realId, bool started)
    {
      if (started)
        return;
      int num1 = this.p_eg_elementList[realId]._params[1] - this.p_eg_elementList[realId]._params[0];
      int num2 = this.p_eg_elementList[realId]._params[0];
      int num3;
      int num4;
      if (this.p_eg_elementList[realId]._params[2] == 0)
      {
        num3 = this.p_eg_pointerX() - this.p_eg_scrX(realId);
        num4 = this.p_eg_elementList[realId].w;
      }
      else
      {
        num3 = this.p_eg_pointerY() - this.p_eg_scrY(realId);
        num4 = this.p_eg_elementList[realId].h;
      }
      int num5 = num2 + (num3 * num1 + (num4 >> 1)) / num4;
      this.p_eg_elementList[realId]._params[4] = (num2 + num1 * num3 << 10) / num4;
      this.p_eg_elementList[realId]._params[5] = this.smoothtime;
      this.p_eg_setSelectorValue(realId, num5);
    }

    public void p_eg_setSelectorValue(int realId, int value)
    {
      mrGame.MrGame.GuiElement pEgElement = this.p_eg_elementList[realId];
      int num1 = pEgElement._params[0];
      int num2 = pEgElement._params[1];
      if (value < num1)
        value = num1;
      if (value > num2)
        value = num2;
      if (value == pEgElement._params[3])
        return;
      pEgElement._params[4] = this.p_eg_getSelectorVisualValue(realId);
      pEgElement._params[5] = this.smoothtime;
      pEgElement._params[3] = value;
      this.p_eg_registerEvent(realId, 12);
    }

    public void eg_setSelectorValue(int elId, int value)
    {
      int realId = this.p_eg_getRealId(elId);
      if (realId == -1)
        return;
      this.p_eg_setSelectorValue(realId, value);
    }

    public void p_eg_selector_paint(int realId)
    {
      int id = this.p_eg_elementList[realId].id;
      int x = this.p_eg_scrX(realId);
      int y = this.p_eg_scrY(realId);
      int w = this.p_eg_elementList[realId].w;
      int h = this.p_eg_elementList[realId].h;
      int selectorVisualValue = this.p_eg_getSelectorVisualValue(realId);
      int valP = this.p_eg_elementList[realId]._params[2] != 0 ? selectorVisualValue * h / (this.p_eg_elementList[realId]._params[1] - this.p_eg_elementList[realId]._params[0]) >> 10 : selectorVisualValue * w / (this.p_eg_elementList[realId]._params[1] - this.p_eg_elementList[realId]._params[0]) >> 10;
      this.egi_paintSelector(id, x, y, w, h, valP);
    }

    public void eg_addSelector(
      int id,
      int minValue,
      int maxValue,
      int defaultValue,
      bool vertical,
      int pos_align,
      int component_align,
      int x,
      int y,
      int w,
      int h)
    {
      mrGame.MrGame.GuiElement element = new mrGame.MrGame.GuiElement();
      element.type = 2;
      element.id = id;
      element.x = x;
      element.y = y;
      element.w = w;
      element.h = h;
      element.txt = (mrGame.MrGame.MrgString) "";
      element.eventMask = 1;
      element.pos_align = pos_align;
      element.draggableHoriz = !vertical;
      element.draggableVert = vertical;
      element._params = new int[6];
      element._params[0] = minValue;
      element._params[1] = maxValue;
      element._params[2] = vertical ? 1 : 0;
      element._params[3] = defaultValue;
      element._params[4] = defaultValue << 10;
      this.p_eg_addElement(element, component_align);
      element._params = (int[]) null;
    }

    public int p_eg_smoothClamp(int a, int b, int s)
    {
      if (a >= 0 && a <= b)
        return a;
      return a < 0 ? this.EG_NERP(0, -s, -a, 1024) : this.EG_NERP(b, b + s, a - b, 1024);
    }

    public bool p_eg_slider_draggingPrevented(int real_id) => false;

    public void eg_setSliderMaximumChange(int elementId, int max)
    {
      int realId = this.p_eg_getRealId(elementId);
      if (realId == -1)
        return;
      this.p_eg_elementList[realId]._params[11] = max;
    }

    public void p_eg_slider_dragEvent(int real_id, bool started)
    {
      mrGame.MrGame.GuiElement pEgElement = this.p_eg_elementList[real_id];
      if (started)
      {
        if (!this.p_eg_draggingHorizontal)
          pEgElement._params[12] = 1;
        pEgElement.isDragging = false;
        pEgElement._params[5] = this.p_eg_slider_getVisualSelection(real_id);
        pEgElement.isDragging = true;
      }
      else
      {
        bool flag1 = pEgElement._params[12] != 0;
        bool flag2 = false;
        pEgElement._params[12] = 0;
        if (flag2 || this.p_eg_slider_draggingPrevented(real_id))
          return;
        this.p_eg_slider_setDragSelection(real_id);
      }
    }

    public void p_eg_slider_setDragSelection(int real_id)
    {
      mrGame.MrGame.GuiElement pEgElement = this.p_eg_elementList[real_id];
      pEgElement.isDragging = true;
      int num1 = pEgElement._params[6] == 0 ? pEgElement.drag_VX : pEgElement.drag_VY;
      int num2 = pEgElement._params[5] + 512;
      int num3 = this.p_eg_slider_getVisualSelection(real_id) + 512 >> 10;
      int num4 = (this.p_eg_slider_getVisualSelection(real_id) + 512 - num2 >= 0 ? 1 : -1) * (512 - pEgElement._params[13]);
      int selection = this.p_eg_slider_getVisualSelection(real_id) + 512 - (pEgElement._params[7] * num1 >> 10) + num4 >> 10;
      int num5 = pEgElement._params[11];
      if (num5 > 0 && (num3 - selection < 0 ? -(num3 - selection) : num3 - selection) > num5)
        selection = selection - num3 >= 0 ? num3 + num5 : num3 - num5;
      pEgElement._params[5] = this.p_eg_slider_getVisualSelection(real_id);
      pEgElement.isDragging = false;
      this.p_eg_slider_setSelection(real_id, selection);
    }

    public void p_eg_slider_paint(int realId)
    {
      int id = this.p_eg_elementList[realId].id;
      int x = this.p_eg_scrX(realId);
      int y = this.p_eg_scrY(realId);
      int w = this.p_eg_elementList[realId].w;
      int h = this.p_eg_elementList[realId].h;
      int shift = 10;
      int selOffset = this.p_eg_slider_getVisualSelection(realId) & (1 << shift) - 1;
      int selId = this.p_eg_slider_getVisualSelection(realId) >> shift;
      int sel = this.p_eg_slider_getSelectionFromSelId(realId, selId);
      if (this.p_eg_elementList[realId]._params[1] == 0 && this.p_eg_slider_getVisualSelection(realId) < 0)
        sel = -1;
      this.egi_paintSlider(id, sel, selOffset, shift, x, y, w, h);
    }

    public int p_eg_slider_getSelectionFromSelId(int slider_id, int selId)
    {
      bool flag = this.p_eg_elementList[slider_id]._params[1] != 0;
      int num = this.p_eg_elementList[slider_id]._params[0];
      if (!flag)
      {
        if (selId < 0)
          return 0;
        return selId <= num - 1 ? selId : num - 1;
      }
      return selId < 0 ? selId - num * ((selId + 1) / num - 1) : selId % num;
    }

    public void p_eg_slider_logic(int realId)
    {
      mrGame.MrGame.GuiElement pEgElement = this.p_eg_elementList[realId];
      int visualSliderValue = this.eg_getVisualSliderValue(this.p_eg_elementList[realId].id);
      if (visualSliderValue != pEgElement._params[8])
        this.p_eg_registerEvent(realId, 11);
      pEgElement._params[8] = visualSliderValue;
    }

    public int eg_getVisualSliderValue(int id)
    {
      int realId = this.p_eg_getRealId(id);
      return this.p_eg_slider_getSelectionFromSelId(realId, this.p_eg_slider_getVisualSelection(realId) + 512 >> 10);
    }

    public int eg_getSliderValue(int id)
    {
      int realId = this.p_eg_getRealId(id);
      return this.p_eg_slider_getSelectionFromSelId(realId, this.p_eg_elementList[realId]._params[2] + 512 >> 10);
    }

    public void eg_setSliderDragSensitivity(int id, int sensitivity)
    {
      int realId = this.p_eg_getRealId(id);
      if (realId == -1)
        return;
      this.p_eg_elementList[realId]._params[10] = sensitivity;
    }

    public void eg_setSliderSensitivity(int id, int sensitivity)
    {
      int realId = this.p_eg_getRealId(id);
      if (realId == -1)
        return;
      this.p_eg_elementList[realId]._params[10] = this.p_eg_elementList[realId]._params[7] = sensitivity;
    }

    public int p_eg_slider_getRealSelection(int realId)
    {
      return this.p_eg_elementList[realId]._params[2] >> 10;
    }

    public int p_eg_slider_getVisualSelection(int realId)
    {
      mrGame.MrGame.GuiElement pEgElement = this.p_eg_elementList[realId];
      if (!pEgElement.isDragging || this.p_eg_slider_draggingPrevented(realId) || !this.p_eg_draggingHorizontal)
        return this.EG_NERP(pEgElement._params[5], pEgElement._params[2], this.smoothtime - pEgElement._params[4], pEgElement._params[3]);
      int num = pEgElement._params[6] == 0 ? pEgElement.drag_startX - this.p_eg_pointerX() : pEgElement.drag_startY - this.p_eg_pointerY();
      int a = pEgElement._params[5] + pEgElement._params[10] * num / this.dynamic_X_RES;
      if (this.p_eg_elementList[realId]._params[1] == 0)
        a = this.p_eg_smoothClamp(a, (this.p_eg_elementList[realId]._params[0] << 10) - 1024 + 1, this.p_eg_elementList[realId]._params[9]);
      pEgElement._params[4] = this.smoothtime - pEgElement._params[3];
      pEgElement._params[2] = a;
      return a;
    }

    public void p_eg_slider_setSelection(int realId, int selection)
    {
      if (this.p_eg_elementList[realId]._params[1] == 0)
        selection = selection < 0 ? 0 : (selection > this.p_eg_elementList[realId]._params[0] - 1 ? this.p_eg_elementList[realId]._params[0] - 1 : selection);
      this.p_eg_elementList[realId]._params[5] = this.p_eg_slider_getVisualSelection(realId);
      this.p_eg_elementList[realId]._params[2] = selection << 10;
      this.p_eg_elementList[realId]._params[4] = this.smoothtime;
    }

    public void eg_slideLeft(int elId)
    {
      int realId = this.p_eg_getRealId(elId);
      if (realId == -1)
        return;
      this.p_eg_slider_setSelection(realId, this.p_eg_slider_getRealSelection(realId) - 1);
    }

    public void eg_slideRight(int elId)
    {
      int realId = this.p_eg_getRealId(elId);
      if (realId == -1)
        return;
      this.p_eg_slider_setSelection(realId, this.p_eg_slider_getRealSelection(realId) + 1);
    }

    public void eg_setSliderSelectionImmediately(int elId, int selection)
    {
      int realId = this.p_eg_getRealId(elId);
      this.p_eg_slider_setSelection(realId, selection);
      this.p_eg_elementList[realId]._params[4] -= this.p_eg_elementList[realId]._params[3];
      this.p_eg_registerEvent(realId, 11);
    }

    public void eg_setSliderSelection(int elId, int selection)
    {
      this.p_eg_slider_setSelection(this.p_eg_getRealId(elId), selection);
    }

    public void p_eg_slider_eventPressed(int realId) => this.p_eg_slider_setDragSelection(realId);

    public void eg_setSliderSelectionSpan(int elementId, int timeSpan)
    {
      this.p_eg_elementList[this.p_eg_getRealId(elementId)]._params[3] = timeSpan;
    }

    public void eg_setSliderClampAmount(int elementId, int clampAmount)
    {
      this.p_eg_elementList[this.p_eg_getRealId(elementId)]._params[9] = clampAmount;
    }

    public void eg_addSlider(
      int id,
      int elementAmount,
      bool loop,
      bool vertical,
      int pos_align,
      int component_align,
      int x,
      int y,
      int w,
      int h)
    {
      this.eg_addSlider(id, elementAmount, loop, vertical, pos_align, component_align, x, y, w, h, false);
    }

    public void eg_setSliderSelectionChangeOffset(int elId, int offset)
    {
      int realId = this.p_eg_getRealId(elId);
      if (realId < 0)
        return;
      this.p_eg_elementList[realId]._params[13] = offset;
    }

    public void eg_addSlider(
      int id,
      int elementAmount,
      bool loop,
      bool vertical,
      int pos_align,
      int component_align,
      int x,
      int y,
      int w,
      int h,
      bool isStatic)
    {
      mrGame.MrGame.GuiElement element = new mrGame.MrGame.GuiElement();
      element.type = 1;
      element.id = id;
      element.x = x;
      element.y = y;
      element.w = w;
      element.h = h;
      element.txt = (mrGame.MrGame.MrgString) "";
      element.eventMask = 1;
      element.pos_align = pos_align;
      element.draggableHoriz = !vertical;
      element.draggableVert = vertical;
      element._params = new int[14];
      element._params[0] = elementAmount;
      element._params[1] = loop ? 1 : 0;
      element._params[8] = element._params[5] = element._params[2] = 0;
      element._params[3] = 500;
      element._params[4] = 0;
      element._params[6] = vertical ? 1 : 0;
      element._params[10] = element._params[7] = 1024;
      element._params[9] = 512;
      element._params[12] = 0;
      element._params[11] = 1;
      element._params[13] = 512;
      this.p_eg_addElement(element, component_align, isStatic);
      element._params = (int[]) null;
    }

    public void eg_enableWrapping(bool enable) => this.p_eg_wrappingEnabled = enable;

    public void p_eg_initKeypad()
    {
      this.p_eg_listeningKeyPresses = false;
      this.p_eg_keyBinds = new mrGame.MrGame.GuiKeyBind[10];
      this.p_eg_keyBindAmount = 0;
    }

    public void p_eg_freeKeypad() => this.p_eg_keyBinds = (mrGame.MrGame.GuiKeyBind[]) null;

    public void p_eg_resetKeypad()
    {
      for (int index = 0; index < this.p_eg_keyBindAmount; ++index)
        this.p_eg_keyBinds[index] = (mrGame.MrGame.GuiKeyBind) null;
      this.p_eg_keyBindAmount = 0;
    }

    public void p_eg_doAction(int realId, int action, int actionType)
    {
      if (realId == -1)
        return;
      if (actionType == 2)
      {
        this.p_eg_doAction(realId, action, 0);
        this.p_eg_doAction(realId, action, 1);
      }
      else
      {
        switch (action)
        {
          case 0:
            if (actionType != 0)
              break;
            this.p_eg_registerEvent(realId, 1, true);
            break;
          case 1:
            if (actionType != 0)
              break;
            this.eg_slideLeft(this.p_eg_elementList[realId].id);
            break;
          case 2:
            if (actionType != 0)
              break;
            this.eg_slideRight(this.p_eg_elementList[realId].id);
            break;
          case 3:
            if (actionType != 0)
              break;
            this.p_eg_selectorIncrease(realId);
            break;
          case 4:
            if (actionType != 0)
              break;
            this.p_eg_selectorDecrease(realId);
            break;
        }
      }
    }

    public bool p_eg_handleKeyBindsPressed(int keyCode)
    {
      bool flag = false;
      this.p_eg_numpadEvent = true;
      for (int index = 0; index < this.p_eg_keyBindAmount; ++index)
      {
        if (this.mrg_isKey(keyCode, this.p_eg_keyBinds[index].key))
        {
          this.p_eg_doAction(this.p_eg_getRealId(this.p_eg_keyBinds[index].elId), this.p_eg_keyBinds[index].action, 0);
          flag = true;
        }
      }
      this.p_eg_numpadEvent = false;
      return flag;
    }

    public bool p_eg_handleKeyBindsReleased(int keyCode)
    {
      bool flag = false;
      this.p_eg_numpadEvent = true;
      for (int index = 0; index < this.p_eg_keyBindAmount; ++index)
      {
        if (this.mrg_isKey(keyCode, this.p_eg_keyBinds[index].key))
        {
          this.p_eg_doAction(this.p_eg_getRealId(this.p_eg_keyBinds[index].elId), this.p_eg_keyBinds[index].action, 1);
          flag = true;
        }
      }
      this.p_eg_numpadEvent = false;
      return flag;
    }

    public void eg_bindAction(int elId, int key, int action)
    {
      this.p_eg_keyBinds[this.p_eg_keyBindAmount] = new mrGame.MrGame.GuiKeyBind();
      mrGame.MrGame.GuiKeyBind pEgKeyBind = this.p_eg_keyBinds[this.p_eg_keyBindAmount];
      ++this.p_eg_keyBindAmount;
      pEgKeyBind.elId = elId;
      pEgKeyBind.key = key;
      pEgKeyBind.action = action;
    }

    public void p_eg_removeBind(int bId)
    {
      this.p_eg_keyBinds[bId] = (mrGame.MrGame.GuiKeyBind) null;
      for (int index = bId; index < this.p_eg_keyBindAmount - 1; ++index)
        this.p_eg_keyBinds[index] = this.p_eg_keyBinds[index + 1];
      --this.p_eg_keyBindAmount;
    }

    public void eg_removeBinds(int elId)
    {
      for (int bId = 0; bId < this.p_eg_keyBindAmount; ++bId)
      {
        if (this.p_eg_keyBinds[bId].elId == elId)
        {
          this.p_eg_removeBind(bId);
          --bId;
        }
      }
    }

    public void p_eg_setKeypadSelectionRealID(int realId)
    {
      if (!this.p_eg_elementList[realId].keypadFocus)
        return;
      this.p_eg_setFocus(realId);
    }

    public void p_eg_setKeypadSelection(int elId)
    {
      int realId = this.p_eg_getRealId(elId);
      if (realId == -1)
        return;
      this.p_eg_setKeypadSelectionRealID(realId);
    }

    public void eg_listenKeyPresses(bool handle) => this.p_eg_listeningKeyPresses = handle;

    public void p_eg_setKeypadMode(bool set)
    {
      if (this.p_eg_keyMode == set)
        return;
      this.p_eg_keyMode = set;
      if (!set || this.p_eg_elementAmount <= 0)
        return;
      this.p_eg_resetDragging();
      if (this.p_eg_focusElement != -1)
        return;
      this.p_eg_setKeypadSelection(0);
    }

    public int p_eg_getComparableX(int rid)
    {
      int comparableX = this.p_eg_scrXWithoutScroll(rid);
      int w = this.p_eg_elementList[rid & -251658241].w;
      if (!this.p_eg_elementList[rid & -251658241].isStatic)
        return comparableX;
      return comparableX < this.p_eg_areaX + (this.p_eg_areaW >> 1) ? comparableX - this.p_eg_compareLeftThreshold : comparableX + this.p_eg_compareRightThreshold;
    }

    public int p_eg_getComparableY(int rid)
    {
      int comparableY = this.p_eg_scrYWithoutScroll(rid);
      int h = this.p_eg_elementList[rid & -251658241].h;
      if (!this.p_eg_elementList[rid & -251658241].isStatic)
        return comparableY;
      return comparableY < this.p_eg_areaY + (this.p_eg_areaH >> 1) ? comparableY - this.p_eg_compareTopThreshold : comparableY + this.p_eg_compareBottomThreshold;
    }

    public int p_eg_focusCompareX(
      int x,
      int w,
      int x0,
      int w0,
      int x1,
      int w1,
      int dx,
      int y,
      int h,
      int y0,
      int h0,
      int y1,
      int h1)
    {
      int num1;
      int num2;
      if (dx > 0)
      {
        num1 = x + w - x0 < 0 ? -(x + w - x0) : x + w - x0;
        num2 = x + w - x1 < 0 ? -(x + w - x1) : x + w - x1;
      }
      else if (dx < 0)
      {
        num1 = x - x0 - w0 < 0 ? -(x - x0 - w0) : x - x0 - w0;
        num2 = x - x1 - w1 < 0 ? -(x - x1 - w1) : x - x1 - w1;
      }
      else
      {
        int num3 = x + (w >> 1) - (x0 + (w0 >> 1)) < 0 ? -(x + (w >> 1) - (x0 + (w0 >> 1))) : x + (w >> 1) - (x0 + (w0 >> 1));
        int num4 = x + (w >> 1) - (x1 + (w1 >> 1)) < 0 ? -(x + (w >> 1) - (x1 + (w1 >> 1))) : x + (w >> 1) - (x1 + (w1 >> 1));
        int num5 = y + (h >> 1) - (y0 + (h0 >> 1)) < 0 ? -(y + (h >> 1) - (y0 + (h0 >> 1))) : y + (h >> 1) - (y0 + (h0 >> 1));
        int num6 = y + (h >> 1) - (y1 + (h1 >> 1)) < 0 ? -(y + (h >> 1) - (y1 + (h1 >> 1))) : y + (h >> 1) - (y1 + (h1 >> 1));
        num1 = (num3 << 16) / (num3 * num3 + num5 * num5);
        num2 = (num4 << 16) / (num4 * num4 + num6 * num6);
      }
      if (num1 == num2)
        return 0;
      return num1 > num2 ? -1 : 1;
    }

    public bool p_eg_focusCompare(int rid, int rid0, int rid1, int dx, int dy)
    {
      int num1 = this.p_eg_getComparableX(rid);
      int comparableY1 = this.p_eg_getComparableY(rid);
      int num2 = this.p_eg_elementList[rid & -251658241].w;
      int h1 = this.p_eg_elementList[rid & -251658241].h;
      int num3 = this.p_eg_getComparableX(rid0);
      int comparableY2 = this.p_eg_getComparableY(rid0);
      int num4 = this.p_eg_elementList[rid0 & -251658241].w;
      int h2 = this.p_eg_elementList[rid0 & -251658241].h;
      int num5 = this.p_eg_getComparableX(rid1);
      int comparableY3 = this.p_eg_getComparableY(rid1);
      int num6 = this.p_eg_elementList[rid1 & -251658241].w;
      int h3 = this.p_eg_elementList[rid1 & -251658241].h;
      if (this.p_eg_verticalMovementOnly)
      {
        num1 = 0;
        num3 = 0;
        num5 = 0;
        num2 = 1;
        num4 = 1;
        num6 = 1;
      }
      if (dy == 0)
        return this.p_eg_focusCompareX(num1, num2, num3, num4, num5, num6, 0, comparableY1, h1, comparableY2, h2, comparableY3, h3) == -1;
      return dx == 0 && this.p_eg_focusCompareX(comparableY1, h1, comparableY2, h2, comparableY3, h3, 0, num1, num2, num3, num4, num5, num6) == -1;
    }

    public int p_eg_test(
      int dx,
      int dy,
      int x,
      int y,
      int w,
      int h,
      int x0,
      int y0,
      int w0,
      int h0,
      int l,
      int bid)
    {
      return dx > 0 && x0 + w0 <= x + w || dx < 0 && x0 >= x || dy > 0 && y0 + h0 <= y + h || dy < 0 && y0 >= y || !this.p_eg_elementList[l & -251658241].keypadFocus || bid != -1 && !this.p_eg_focusCompare(this.p_eg_focusElement, l, bid, dx, dy) ? bid : l;
    }

    public void p_eg_moveFocus(int dx, int dy)
    {
      int bid = -1;
      int elId = this.egi_moveFocus(this.p_eg_focusElement == -1 ? -1 : this.p_eg_elementList[this.p_eg_focusElement].id, dx, dy);
      if (elId != -1)
      {
        this.eg_setFocus(elId);
      }
      else
      {
        int x;
        int y;
        int w1;
        int h1;
        if (this.p_eg_focusElement != -1)
        {
          x = this.p_eg_getComparableX(this.p_eg_focusElement);
          y = this.p_eg_getComparableY(this.p_eg_focusElement);
          w1 = this.p_eg_elementList[this.p_eg_focusElement].w;
          h1 = this.p_eg_elementList[this.p_eg_focusElement].h;
        }
        else
        {
          x = this.p_eg_pointerX();
          y = this.p_eg_pointerY();
          w1 = h1 = 1;
        }
        this.p_eg_compareLeftThreshold = 0;
        this.p_eg_compareRightThreshold = 0;
        this.p_eg_compareBottomThreshold = 0;
        this.p_eg_compareTopThreshold = 0;
        for (int el = 0; el < this.p_eg_elementAmount; ++el)
        {
          if (this.p_eg_elementList[el].isStatic && this.p_eg_elementList[el].keypadFocus)
          {
            int num1 = this.p_eg_scrXWithoutScroll(el);
            int num2 = this.p_eg_scrYWithoutScroll(el);
            int w2 = this.p_eg_elementList[el].w;
            int h2 = this.p_eg_elementList[el].h;
            if (num2 + h2 > this.p_eg_guiBorderTop && num2 < this.p_eg_guiBorderBottom)
            {
              if (num1 < this.p_eg_areaX && num1 > this.p_eg_guiBorderLeft)
              {
                int num3 = num1 - this.p_eg_guiBorderLeft;
                if (num3 > this.p_eg_compareLeftThreshold)
                  this.p_eg_compareLeftThreshold = num3;
              }
              else if (num1 > this.p_eg_areaX + this.p_eg_areaW && num1 < this.p_eg_guiBorderRight)
              {
                int num4 = this.p_eg_guiBorderRight - num1;
                if (num4 > this.p_eg_compareRightThreshold)
                  this.p_eg_compareRightThreshold = num4;
              }
            }
            if (num1 + w2 > this.p_eg_guiBorderLeft && num1 < this.p_eg_guiBorderRight)
            {
              if (num2 < this.p_eg_areaY && num2 > this.p_eg_guiBorderTop)
              {
                int num5 = num2 - this.p_eg_guiBorderTop;
                if (num5 > this.p_eg_compareTopThreshold)
                  this.p_eg_compareTopThreshold = num5;
              }
              else if (num2 > this.p_eg_areaY + this.p_eg_areaH && num2 < this.p_eg_guiBorderBottom)
              {
                int num6 = this.p_eg_guiBorderBottom - num2;
                if (num6 > this.p_eg_compareBottomThreshold)
                  this.p_eg_compareBottomThreshold = num6;
              }
            }
          }
        }
        for (int index = 0; index < this.p_eg_elementAmount; ++index)
        {
          if (index != this.p_eg_focusElement && this.p_eg_elementList[index].enabled)
          {
            int comparableX1 = this.p_eg_getComparableX(index);
            int comparableY = this.p_eg_getComparableY(index);
            int w3 = this.p_eg_elementList[index].w;
            int h3 = this.p_eg_elementList[index].h;
            bid = !this.p_eg_verticalMovementOnly ? this.p_eg_test(dx, dy, x, y, w1, h1, comparableX1, comparableY, w3, h3, index, bid) : this.p_eg_test(0, dy, 0, y, 1, h1, 0, comparableY, 1, h3, index, bid);
            if (this.p_eg_wrappingEnabled)
            {
              if (dy > 0)
              {
                comparableY = this.p_eg_getComparableY(index | 33554432);
                bid = this.p_eg_test(dx, dy, x, y, w1, h1, comparableX1, comparableY, w3, h3, index | 33554432, bid);
              }
              if (dy < 0)
              {
                comparableY = this.p_eg_getComparableY(index | 16777216);
                bid = this.p_eg_test(dx, dy, x, y, w1, h1, comparableX1, comparableY, w3, h3, index | 16777216, bid);
              }
              if (this.p_eg_horizontalMovementEnabled)
              {
                if (dx < 0)
                {
                  int comparableX2 = this.p_eg_getComparableX(index | 67108864);
                  bid = this.p_eg_test(dx, dy, x, y, w1, h1, comparableX2, comparableY, w3, h3, index | 67108864, bid);
                }
                if (dx > 0)
                {
                  int comparableX3 = this.p_eg_getComparableX(index | 134217728);
                  bid = this.p_eg_test(dx, dy, x, y, w1, h1, comparableX3, comparableY, w3, h3, index | 134217728, bid);
                }
              }
            }
          }
        }
        if (bid == -1)
          return;
        this.p_eg_setFocus(bid & -251658241);
      }
    }

    public void p_eg_keyRepeatLogic()
    {
      if (!this.mrg_isKey(this.p_eg_repeatingKey))
      {
        this.p_eg_repeatingKey = 0;
      }
      else
      {
        for (int index = this.smoothtime - this.p_eg_lastKeyRepeat; index > 400 && this.p_eg_repeatAmount < 1 || index > 100 && this.p_eg_repeatAmount >= 1; index = this.smoothtime - this.p_eg_lastKeyRepeat)
        {
          this.p_eg_handleKeypress(this.p_eg_repeatingKey);
          if (this.p_eg_repeatAmount < 1)
            this.p_eg_lastKeyRepeat += 400;
          else
            this.p_eg_lastKeyRepeat += 100;
          ++this.p_eg_repeatAmount;
        }
      }
    }

    public void p_eg_keyPressed(int keyCode)
    {
      if (this.p_eg_guiLocked)
        return;
      this.p_eg_repeatingKey = keyCode;
      this.p_eg_repeatAmount = 0;
      this.p_eg_lastKeyRepeat = this.smoothtime;
      this.p_eg_handleKeypress(keyCode);
    }

    public void p_eg_handleKeypress(int keyCode)
    {
      if (this.p_eg_hackPressingKeyInsideGui)
      {
        this.p_eg_hackPressingKeyInsideGui = false;
      }
      else
      {
        if (this.p_eg_hidden || this.p_eg_elementAmount <= 0)
          return;
        if (this.p_eg_handleKeyBindsPressed(keyCode))
        {
          this.p_eg_eventRegistered = true;
          this.mrg_resetKeys();
        }
        else
        {
          if (!this.p_eg_listeningKeyPresses)
            return;
          bool flag1 = this.p_eg_focusElement != -1;
          this.p_eg_numpadEvent = true;
          if (this.p_eg_keyMode && this.p_eg_focusElement == -1)
            this.p_eg_setFocus(0);
          if (!this.p_eg_keyMode)
          {
            this.p_eg_setKeypadMode(true);
            if (this.p_eg_focusElement == -1)
              this.p_eg_setKeypadSelectionRealID(0);
          }
          bool flag2 = false;
          if (flag1)
          {
            if (this.mrg_isKey(keyCode, 196608))
            {
              this.p_eg_doAction(this.p_eg_focusElement, 0, 0);
              flag2 = true;
            }
            else if (this.p_eg_focusElement != -1 && this.p_eg_elementList[this.p_eg_focusElement].type == 1)
            {
              if (this.mrg_isKey(keyCode, 70))
              {
                this.p_eg_doAction(this.p_eg_focusElement, 1, 0);
                flag2 = true;
              }
              else if (this.mrg_isKey(keyCode, 71))
              {
                this.p_eg_doAction(this.p_eg_focusElement, 2, 0);
                flag2 = true;
              }
            }
            else if (this.p_eg_focusElement != -1 && this.p_eg_elementList[this.p_eg_focusElement].type == 2)
            {
              if (this.mrg_isKey(keyCode, 70))
              {
                this.p_eg_doAction(this.p_eg_focusElement, 4, 0);
                flag2 = true;
              }
              else if (this.mrg_isKey(keyCode, 71))
              {
                this.p_eg_doAction(this.p_eg_focusElement, 3, 0);
                flag2 = true;
              }
            }
            if (!flag2)
            {
              int dx = 0;
              int dy = 0;
              if (this.mrg_isKey(keyCode, 70) && this.p_eg_horizontalMovementEnabled)
                --dx;
              if (this.mrg_isKey(keyCode, 71) && this.p_eg_horizontalMovementEnabled)
                ++dx;
              if (this.mrg_isKey(keyCode, 68))
                --dy;
              if (this.mrg_isKey(keyCode, 69))
                ++dy;
              if (dx != 0 || dy != 0)
                this.p_eg_moveFocus(dx, dy);
            }
          }
          this.p_eg_numpadEvent = false;
        }
      }
    }

    public void p_eg_keyReleased(int keyCode)
    {
      if (this.p_eg_guiLocked || this.p_eg_hackPressingKeyInsideGui || this.p_eg_hidden || this.p_eg_elementAmount <= 0)
        return;
      if (this.p_eg_handleKeyBindsReleased(keyCode))
      {
        this.p_eg_eventRegistered = true;
      }
      else
      {
        if (!this.p_eg_listeningKeyPresses || this.p_eg_focusElement == -1)
          return;
        if (this.mrg_isKey(keyCode, 196608))
        {
          this.p_eg_doAction(this.p_eg_focusElement, 0, 1);
        }
        else
        {
          if (this.p_eg_focusElement == -1 || this.p_eg_elementList[this.p_eg_focusElement].type != 1)
            return;
          if (this.mrg_isKey(keyCode, 70))
          {
            this.p_eg_doAction(this.p_eg_focusElement, 1, 1);
          }
          else
          {
            if (!this.mrg_isKey(keyCode, 71))
              return;
            this.p_eg_doAction(this.p_eg_focusElement, 2, 1);
          }
        }
      }
    }

    public int EG_NERP(int a, int b, int t, int t0)
    {
      if (t < 0)
        return a;
      if (t > t0)
        return b;
      int num = (a * (t0 - (t * (-(t << 8) / t0 + 512) >> 8)) + b * (t * (-(t << 8) / t0 + 512) >> 8)) / t0;
      if (num < (a < b ? a : b))
        num = a < b ? a : b;
      if (num > (a > b ? a : b))
        num = a > b ? a : b;
      return num;
    }

    public int eg_getFocusElementId()
    {
      return this.p_eg_focusElement != -1 ? this.p_eg_elementList[this.p_eg_focusElement].id : -1;
    }

    public bool eg_elementExists(int id) => this.p_eg_getRealId(id) != -1;

    public void eg_removeElement(int elementId)
    {
      int realId = this.p_eg_getRealId(elementId);
      if (realId == -1)
        return;
      this.eg_removeBinds(elementId);
      this.debug_text((mrGame.MrGame.MrgString) ("freeElement(0): " + (object) realId));
      this.p_eg_freeElement(this.p_eg_elementList[realId]);
      this.p_eg_elementList[realId] = (mrGame.MrGame.GuiElement) null;
      for (int index = realId; index < this.p_eg_elementAmount - 1; ++index)
        this.p_eg_elementList[index] = this.p_eg_elementList[index + 1];
      int index1 = 0;
      while (index1 < this.p_eg_elementAmount && this.p_eg_elementOrdering[index1] != realId)
        ++index1;
      for (int index2 = index1; index2 < this.p_eg_elementAmount - 1; ++index2)
        this.p_eg_elementOrdering[index2] = this.p_eg_elementOrdering[index2 + 1];
      --this.p_eg_elementAmount;
      for (int index3 = 0; index3 < this.p_eg_elementAmount; ++index3)
      {
        if (this.p_eg_elementOrdering[index3] > realId)
          --this.p_eg_elementOrdering[index3];
      }
      if (this.p_eg_focusElement == realId)
        this.p_eg_focusElement = -1;
      if (this.p_eg_focusElement > realId)
        --this.p_eg_focusElement;
      if (this.p_eg_origFocusElement > realId)
        --this.p_eg_origFocusElement;
      if (this.p_eg_prevElementOnPointer > realId)
        --this.p_eg_prevElementOnPointer;
      if (this.p_eg_pointerDraggingElement <= realId)
        return;
      --this.p_eg_pointerDraggingElement;
    }

    public void eg_init(int max_elements)
    {
    }

    public int p_eg_getRealId(int elementId)
    {
      for (int realId = 0; realId < this.p_eg_elementAmount; ++realId)
      {
        if (this.p_eg_elementList[realId].id == elementId)
          return realId;
      }
      return -1;
    }

    public void eg_setDraggable(int id, bool set)
    {
      int realId = this.p_eg_getRealId(id);
      if (realId == -1)
        return;
      this.p_eg_elementList[realId].draggableHoriz = set;
      this.p_eg_elementList[realId].draggableVert = set;
    }

    public void eg_disableHorizontalMovement(bool disable)
    {
      this.p_eg_horizontalMovementEnabled = !disable;
    }

    public void eg_setVerticalMenuMode(bool set)
    {
      this.p_eg_horizontalMovementEnabled = !set;
      this.p_eg_verticalMovementOnly = set;
    }

    public void eg_setElementDimensions(int elId, int x, int y, int w, int h)
    {
      int realId = this.p_eg_getRealId(elId);
      if (realId == -1)
        return;
      this.p_eg_elementList[realId].ax = x;
      this.p_eg_elementList[realId].ay = y;
      this.p_eg_elementList[realId].w = w;
      this.p_eg_elementList[realId].h = h;
      this.p_eg_setAlignment(this.p_eg_elementList[realId]);
      this.p_eg_recomputeBBox();
    }

    public void eg_allocGui(mrGame.MrGame.Gui gui)
    {
      gui.elementList = new mrGame.MrGame.GuiElement[10];
      for (int index = 0; index < 10; ++index)
        gui.elementList[index] = new mrGame.MrGame.GuiElement();
      gui.elementAmount = 0;
    }

    public void eg_freeGui(mrGame.MrGame.Gui gui)
    {
      for (int index = 0; index < 10; ++index)
        gui.elementList[index] = (mrGame.MrGame.GuiElement) null;
      gui.elementList = (mrGame.MrGame.GuiElement[]) null;
    }

    public void p_eg_copyGuiElement(mrGame.MrGame.GuiElement to, mrGame.MrGame.GuiElement from)
    {
      to.type = from.type;
      to.id = from.id;
      to.eg_id = from.eg_id;
      to.pos_align = from.pos_align;
      to.align = from.align;
      to.x = from.x;
      to.y = from.y;
      to.w = from.w;
      to.h = from.h;
      to.txt = from.txt;
      to.eventMask = from.eventMask;
      to.draggableHoriz = from.draggableHoriz;
      to.draggableVert = from.draggableVert;
      if (from._params == null)
      {
        to._params = (int[]) null;
      }
      else
      {
        to._params = new int[from._params.Length];
        for (int index = 0; index < from._params.Length; ++index)
          to._params[index] = from._params[index];
      }
    }

    public int eg_getElementX(int id)
    {
      int realId = this.p_eg_getRealId(id);
      return realId != -1 ? this.p_eg_scrX(realId) : -1;
    }

    public int eg_getElementY(int id)
    {
      int realId = this.p_eg_getRealId(id);
      return realId != -1 ? this.p_eg_scrY(realId) : -1;
    }

    public int eg_getElementWidth(int id)
    {
      int realId = this.p_eg_getRealId(id);
      return realId != -1 ? this.p_eg_elementList[realId].w : -1;
    }

    public int eg_getElementHeight(int id)
    {
      int realId = this.p_eg_getRealId(id);
      return realId != -1 ? this.p_eg_elementList[realId].h : -1;
    }

    public void eg_saveGui(mrGame.MrGame.Gui gui)
    {
      for (int index = 0; index < this.p_eg_elementAmount; ++index)
      {
        gui.elementList[index] = new mrGame.MrGame.GuiElement();
        this.p_eg_copyGuiElement(gui.elementList[index], this.p_eg_elementList[index]);
      }
      gui.elementAmount = this.p_eg_elementAmount;
    }

    public void eg_loadGui(mrGame.MrGame.Gui gui)
    {
      for (int index = 0; index < gui.elementAmount; ++index)
        this.p_eg_copyGuiElement(this.p_eg_elementList[index], gui.elementList[index]);
      this.p_eg_elementAmount = gui.elementAmount;
    }

    public void eg_init(int max_elements, int guitileWidth, int guitileHeight)
    {
    }

    public void p_eg_init()
    {
      this.p_eg_elementList = new mrGame.MrGame.GuiElement[10];
      this.p_eg_elementOrdering = new int[10];
      this.p_eg_elementAmount = 0;
      this.p_eg_focusElement = -1;
      this.p_eg_prevElementOnPointer = -1;
      this.p_eg_pointerDraggingElement = -1;
      this.p_eg_hackPressingKeyInsideGui = false;
      this.p_eg_hidden = false;
      this.p_eg_initKeypad();
      this.p_eg_setKeypadMode(false);
      this.eg_reset();
    }

    public void eg_setKeypadFocusable(int elId, bool set)
    {
      int realId = this.p_eg_getRealId(elId);
      if (realId == -1)
        return;
      this.p_eg_elementList[realId].keypadFocus = set;
    }

    public void eg_hide(bool hide)
    {
      int num1 = this.p_eg_hidden ? 1 : 0;
      int num2 = hide ? 1 : 0;
      if (this.p_eg_hidden && !hide)
      {
        for (int realId = 0; realId < this.p_eg_elementAmount; ++realId)
          this.p_eg_registerEvent(realId, 6);
      }
      this.p_eg_hidden = hide;
    }

    public void p_eg_free()
    {
      this.eg_reset();
      this.p_eg_freeKeypad();
      for (int index = 0; index < this.p_eg_elementAmount; ++index)
      {
        this.debug_text((mrGame.MrGame.MrgString) ("freeElement(1): " + (object) index));
        this.p_eg_freeElement(this.p_eg_elementList[index]);
        this.p_eg_elementList[index] = (mrGame.MrGame.GuiElement) null;
      }
      this.p_eg_elementList = (mrGame.MrGame.GuiElement[]) null;
      this.p_eg_elementOrdering = (int[]) null;
    }

    public void eg_setEnabled(int id, bool enabled)
    {
      int elementWithId = this.p_eg_getElementWithId(id);
      if (elementWithId < 0 || this.p_eg_elementList[elementWithId].enabled == enabled)
        return;
      this.p_eg_elementList[elementWithId].enabled = enabled;
      if (enabled)
        this.p_eg_registerEvent(elementWithId, 8);
      else
        this.p_eg_registerEvent(elementWithId, 7);
      this.p_eg_recomputeBBox();
    }

    public bool eg_isEnabled(int elId)
    {
      int realId = this.p_eg_getRealId(elId);
      return realId != -1 && this.p_eg_elementList[realId].enabled;
    }

    public mrGame.MrGame.GuiElement eg_getElement(int id)
    {
      int elementWithId = this.p_eg_getElementWithId(id);
      return elementWithId >= 0 ? this.p_eg_elementList[elementWithId] : this.p_eg_elementList[0];
    }

    public void p_eg_setAlignment(mrGame.MrGame.GuiElement element)
    {
      int align = element.align;
      int posAlign = element.pos_align;
      int num1 = 0;
      int num2 = 0;
      if ((posAlign & 16) == 0)
      {
        if ((align & 8) != 0)
          num1 = 2;
        if ((align & 1) != 0)
          num1 = 1;
        if ((posAlign & 8) != 0)
          num1 *= -1;
      }
      else
      {
        if ((align & 4) != 0)
          num1 = 1;
        if ((align & 8) != 0)
          num1 = -1;
      }
      if ((posAlign & 32) == 0)
      {
        if ((align & 32) != 0)
          num2 = 2;
        if ((align & 2) != 0)
          num2 = 1;
        if ((posAlign & 2) != 0)
          num2 *= -1;
      }
      else
      {
        if ((align & 16) != 0)
          num2 = 1;
        if ((align & 32) != 0)
          num2 = -1;
      }
      element.x = element.ax - (num1 * element.w >> 1);
      element.y = element.ay - (num2 * element.h >> 1);
    }

    public void p_eg_addElement(mrGame.MrGame.GuiElement element, int align)
    {
      this.p_eg_addElement(element, align, false);
    }

    public void eg_setAlwaysOnTop(int elId, bool set)
    {
      this.eg_setElementLevel(elId, int.MaxValue);
    }

    public void eg_setElementLevel(int eId, int level)
    {
      int realId = this.p_eg_getRealId(eId);
      if (realId == -1)
        return;
      this.p_eg_elementList[realId].elementLevel = level;
      if (level <= this.p_eg_elementList[realId].elementLevel)
        return;
      this.p_eg_riseElement(realId);
    }

    public void p_eg_riseElementFromElementOrderId(int eoId)
    {
      int index1 = this.p_eg_elementOrdering[eoId];
      int index2 = eoId + 1;
      while (index2 < this.p_eg_elementAmount && this.p_eg_elementList[index1].elementLevel >= this.p_eg_elementList[this.p_eg_elementOrdering[index2]].elementLevel)
        ++index2;
      for (int index3 = eoId; index3 < index2 - 1; ++index3)
        this.p_eg_elementOrdering[index3] = this.p_eg_elementOrdering[index3 + 1];
      this.p_eg_elementOrdering[index2 - 1] = index1;
    }

    public void p_eg_riseElement(int realId)
    {
      for (int eoId = 0; eoId < this.p_eg_elementAmount; ++eoId)
      {
        if (this.p_eg_elementOrdering[eoId] == realId)
        {
          this.p_eg_riseElementFromElementOrderId(eoId);
          break;
        }
      }
    }

    public void p_eg_recomputeBBox()
    {
      this.p_eg_guiBorderLeft = int.MaxValue;
      this.p_eg_guiBorderTop = int.MaxValue;
      this.p_eg_guiBorderRight = int.MinValue;
      this.p_eg_guiBorderBottom = int.MinValue;
      for (int el = 0; el < this.p_eg_elementAmount; ++el)
      {
        mrGame.MrGame.GuiElement pEgElement = this.p_eg_elementList[el];
        if (pEgElement.enabled && !pEgElement.isStatic)
        {
          int num1 = this.p_eg_scrXWithoutScroll(el);
          int num2 = this.p_eg_scrYWithoutScroll(el);
          int num3 = num1 + pEgElement.w;
          int num4 = num2 + pEgElement.h;
          if (num1 < this.p_eg_guiBorderLeft)
            this.p_eg_guiBorderLeft = num1;
          if (num2 < this.p_eg_guiBorderTop)
            this.p_eg_guiBorderTop = num2;
          if (num3 > this.p_eg_guiBorderRight)
            this.p_eg_guiBorderRight = num3;
          if (num4 > this.p_eg_guiBorderBottom)
            this.p_eg_guiBorderBottom = num4;
        }
      }
    }

    public void p_eg_addElement(mrGame.MrGame.GuiElement element, int align, bool isStatic)
    {
      element.ax = element.x;
      element.ay = element.y;
      element.align = align;
      this.p_eg_setAlignment(element);
      this.debug_text((mrGame.MrGame.MrgString) ("addElement: " + (object) this.p_eg_elementAmount));
      this.p_eg_elementList[this.p_eg_elementAmount] = new mrGame.MrGame.GuiElement();
      this.p_eg_elementList[this.p_eg_elementAmount].eventTimeList = new int[12];
      for (int index = 0; index < 12; ++index)
        this.p_eg_elementList[this.p_eg_elementAmount].eventTimeList[index] = int.MinValue;
      this.p_eg_copyGuiElement(this.p_eg_elementList[this.p_eg_elementAmount], element);
      this.p_eg_elementList[this.p_eg_elementAmount].eg_id = this.p_eg_elementAmount;
      this.p_eg_elementList[this.p_eg_elementAmount]._event = -1;
      this.p_eg_elementList[this.p_eg_elementAmount].enabled = true;
      this.p_eg_elementList[this.p_eg_elementAmount].keypadFocus = true;
      this.p_eg_elementList[this.p_eg_elementAmount].visible = true;
      this.p_eg_elementList[this.p_eg_elementAmount].elementLevel = 0;
      this.p_eg_elementList[this.p_eg_elementAmount].isDragging = false;
      for (int index = this.p_eg_elementAmount - 1; index >= 0; --index)
        this.p_eg_elementOrdering[index + 1] = this.p_eg_elementOrdering[index];
      this.p_eg_elementOrdering[0] = this.p_eg_elementAmount;
      this.p_eg_elementList[this.p_eg_elementAmount].isStatic = isStatic;
      if (!isStatic)
      {
        int num1 = this.p_eg_scrXWithoutScroll(this.p_eg_elementAmount);
        int num2 = this.p_eg_scrYWithoutScroll(this.p_eg_elementAmount);
        int num3 = num1 + element.w;
        int num4 = num2 + element.h;
        if (num1 < this.p_eg_guiBorderLeft)
          this.p_eg_guiBorderLeft = num1;
        if (num2 < this.p_eg_guiBorderTop)
          this.p_eg_guiBorderTop = num2;
        if (num3 > this.p_eg_guiBorderRight)
          this.p_eg_guiBorderRight = num3;
        if (num4 > this.p_eg_guiBorderBottom)
          this.p_eg_guiBorderBottom = num4;
      }
      ++this.p_eg_elementAmount;
      this.p_eg_registerEvent(this.p_eg_elementAmount - 1, 6);
      this.p_eg_riseElementFromElementOrderId(0);
    }

    public void eg_setElementText(int eId, mrGame.MrGame.MrgString txt)
    {
      int realId = this.p_eg_getRealId(eId);
      if (realId == -1)
        return;
      this.p_eg_elementList[realId].txt = txt;
    }

    public void p_eg_addElement(mrGame.MrGame.GuiElement element)
    {
      this.p_eg_addElement(element, 20);
    }

    public void p_eg_freeElement(mrGame.MrGame.GuiElement element)
    {
      if (element._params != null)
        element._params = (int[]) null;
      element.txt = (mrGame.MrGame.MrgString) null;
      element.eventTimeList = (int[]) null;
    }

    public void eg_lockGui(bool _lock) => this.p_eg_guiLocked = _lock;

    public void eg_reset()
    {
      for (int index = 0; index < this.p_eg_elementAmount; ++index)
      {
        this.debug_text((mrGame.MrGame.MrgString) ("freeElement(2): " + (object) index));
        this.p_eg_freeElement(this.p_eg_elementList[index]);
        this.p_eg_elementList[index] = (mrGame.MrGame.GuiElement) null;
      }
      this.p_eg_elementAmount = 0;
      this.p_eg_prevFocusElement = this.p_eg_focusElement = -1;
      this.p_eg_prevElementOnPointer = -1;
      this.p_eg_pressingGuiSoftkey = false;
      this.p_eg_gameAreaFocusable = true;
      this.eg_hide(false);
      this.eg_listenKeyPresses(false);
      this.p_eg_resetKeypad();
      this.eg_setVerticalMenuMode(false);
      this.eg_setScrollMargin(0);
      this.p_eg_guiScrollDuration = 400;
      this.eg_enableWrapping(false);
      this.p_eg_pointerReportedDown = false;
      this.eg_enableAutoScroll(false);
      this.eg_resetArea();
      this.eg_resetScroll();
      this.eg_lockGui(false);
      this.p_eg_repeatingKey = 0;
      this.p_eg_numpadEvent = false;
      this.eg_disableHorizontalMovement(false);
      this.p_eg_draggingHorizontal = false;
      this.p_eg_draggingVertical = false;
      this.p_eg_guiBorderLeft = int.MaxValue;
      this.p_eg_guiBorderTop = int.MaxValue;
      this.p_eg_guiBorderRight = int.MinValue;
      this.p_eg_guiBorderBottom = int.MinValue;
    }

    public int p_eg_getElementWithId(int id)
    {
      for (int elementWithId = 0; elementWithId < this.p_eg_elementAmount; ++elementWithId)
      {
        if (this.p_eg_elementList[elementWithId].id == id)
          return elementWithId;
      }
      return -1;
    }

    public void eg_addTextButton(
      int id,
      mrGame.MrGame.MrgString txt,
      int pos_align,
      int component_align,
      int x,
      int y,
      int w,
      int h)
    {
      this.eg_addTextButton(id, txt, pos_align, component_align, x, y, w, h, false);
    }

    public void eg_addTextButton(
      int id,
      mrGame.MrGame.MrgString txt,
      int pos_align,
      int component_align,
      int x,
      int y,
      int w,
      int h,
      bool _static)
    {
      this.p_eg_addElement(new mrGame.MrGame.GuiElement()
      {
        type = 0,
        id = id,
        x = x,
        y = y,
        w = w,
        h = h,
        txt = txt,
        eventMask = 1,
        pos_align = pos_align,
        _params = (int[]) null,
        draggableHoriz = false,
        draggableVert = false
      }, component_align, _static);
    }

    public void eg_addTextButton(
      int id,
      mrGame.MrGame.MrgString txt,
      int pos_align,
      int x,
      int y,
      int w,
      int h)
    {
      int num1 = 0;
      int num2 = (pos_align & 16) == 0 ? num1 | 4 : num1 | 1;
      int component_align = (pos_align & 32) == 0 ? num2 | 16 : num2 | 2;
      this.eg_addTextButton(id, txt, pos_align, component_align, x, y, w, h);
    }

    public bool p_eg_pointerDown() => this.p_eg_pointerReportedDown;

    public int p_eg_pointerX() => this.p_touchdata[this.p_mt_last].upx;

    public int p_eg_pointerY() => this.p_touchdata[this.p_mt_last].upy;

    public int eg_getDragStartOffsetX()
    {
      return this.p_eg_pointerDraggingElement != -1 ? this.p_eg_elementList[this.p_eg_pointerDraggingElement].drag_startOffsetX : int.MinValue;
    }

    public int eg_getDragStartOffsetY()
    {
      return this.p_eg_pointerDraggingElement != -1 ? this.p_eg_elementList[this.p_eg_pointerDraggingElement].drag_startOffsetY : int.MinValue;
    }

    public int p_eg_scrXWithoutScroll(int el)
    {
      int num1 = this.p_eg_guiBorderRight - this.p_eg_guiBorderLeft;
      int num2 = 0;
      if ((el & 67108864) != 0)
        num2 = -num1 << 2;
      if ((el & 134217728) != 0)
        num2 = num1 << 2;
      el &= -251658241;
      int w = this.p_eg_elementList[el].w;
      if ((this.p_eg_elementList[el].pos_align & 4) != 0)
        return this.p_eg_elementList[el].x + num2;
      return (this.p_eg_elementList[el].pos_align & 16) != 0 ? (this.dynamic_X_RES >> 1) + this.p_eg_elementList[el].x - (w >> 1) + num2 : this.dynamic_X_RES - this.p_eg_elementList[el].x + num2;
    }

    public int p_eg_scrYWithoutScroll(int el)
    {
      int num1 = this.p_eg_guiBorderBottom - this.p_eg_guiBorderTop;
      int num2 = 0;
      if ((el & 16777216) != 0)
        num2 = -num1 << 2;
      if ((el & 33554432) != 0)
        num2 = num1 << 2;
      el &= -251658241;
      int h = this.p_eg_elementList[el].h;
      if ((this.p_eg_elementList[el].pos_align & 1) != 0)
        return this.p_eg_elementList[el].y + num2;
      return (this.p_eg_elementList[el].pos_align & 32) != 0 ? (this.dynamic_Y_RES >> 1) + this.p_eg_elementList[el].y - (h >> 1) + num2 : this.dynamic_Y_RES - this.p_eg_elementList[el].y + num2;
    }

    public int p_eg_scrX(int el)
    {
      el &= -251658241;
      return !this.p_eg_elementList[el].isStatic ? this.p_eg_scrXWithoutScroll(el) + this.p_eg_getScrollX() : this.p_eg_scrXWithoutScroll(el);
    }

    public int p_eg_scrY(int el)
    {
      int num = 0;
      el &= -251658241;
      return !this.p_eg_elementList[el].isStatic ? this.p_eg_scrYWithoutScroll(el) + this.p_eg_getScrollY() + num : this.p_eg_scrYWithoutScroll(el) + num;
    }

    public int p_eg_getElementAt(int x, int y)
    {
      for (int index = this.p_eg_elementAmount - 1; index >= 0; --index)
      {
        int el = this.p_eg_elementOrdering[index];
        int w = this.p_eg_elementList[el].w;
        int h = this.p_eg_elementList[el].h;
        if (this.p_eg_elementList[el].enabled && x >= this.p_eg_scrX(el) && y >= this.p_eg_scrY(el) && x < this.p_eg_scrX(el) + w && y < this.p_eg_scrY(el) + h && (x >= this.p_eg_areaX && x < this.p_eg_areaX + this.p_eg_areaW && y >= this.p_eg_areaY && y < this.p_eg_areaY + this.p_eg_areaH && !this.p_eg_elementList[el].isStatic || this.p_eg_elementList[el].isStatic))
          return el;
      }
      return -1;
    }

    public void eg_setFocus(int elId)
    {
      if (elId == -1)
        this.p_eg_setFocus(-1);
      int realId = this.p_eg_getRealId(elId);
      if (realId == -1)
        return;
      this.p_eg_setFocus(realId);
    }

    public bool eg_hasFocus(int elId)
    {
      if (elId == -1)
        return this.p_eg_focusElement == -1;
      int realId = this.p_eg_getRealId(elId);
      return realId != -1 && this.p_eg_focusElement == realId;
    }

    public int eg_getPreviousFocusElement()
    {
      return this.p_eg_prevFocusElement == -1 ? -1 : this.p_eg_elementList[this.p_eg_prevFocusElement].id;
    }

    public void p_eg_setFocus(int realId)
    {
      if (realId == -1 && !this.p_eg_gameAreaFocusable || realId != -1 && !this.p_eg_elementList[realId].enabled)
        return;
      if (this.p_eg_focusElement != realId)
      {
        this.p_eg_prevFocusElement = this.p_eg_focusElement;
        int pEgFocusElement = this.p_eg_focusElement;
        this.p_eg_focusElement = realId;
        this.p_eg_registerEvent(pEgFocusElement, 5);
        this.p_eg_registerEvent(this.p_eg_focusElement, 4);
      }
      if (realId == -1)
        return;
      this.p_eg_riseElement(realId);
    }

    public void p_eg_pointerPressed()
    {
      if (this.p_eg_pointerReportedDown)
        return;
      this.p_eg_pointerReportedDown = true;
      if (this.p_eg_guiLocked)
        return;
      this.p_eg_setKeypadMode(false);
      int x = this.p_eg_pointerX();
      int y = this.p_eg_pointerY();
      this.p_eg_prevPointerX = this.p_eg_origPointerX = x;
      this.p_eg_prevPointerY = this.p_eg_origPointerY = y;
      int elementAt = this.p_eg_getElementAt(x, y);
      if (elementAt != -1 && !this.p_eg_elementList[elementAt].enabled)
        return;
      this.p_eg_setFocus(elementAt);
      this.p_eg_origFocusElement = this.p_eg_focusElement;
      if (elementAt != -1)
      {
        this.p_eg_elementList[elementAt].pressX = x;
        this.p_eg_elementList[elementAt].pressY = y;
      }
      this.p_eg_pointerDraggingElement = -1;
      this.p_eg_registerEvent(elementAt, 2);
    }

    public void p_eg_eventPressed(int elId) => this.p_eg_eventPressed(elId, false);

    public void p_eg_eventPressed(int elId, bool keypadPress)
    {
      int elementWithId = this.p_eg_getElementWithId(elId);
      if (elementWithId >= -1 && !this.p_eg_elementList[elementWithId].enabled)
        return;
      switch (elId)
      {
        case 268435456:
          this.eg_reset();
          this.em_doAction(14, 1);
          this.mrg_resetKeys();
          return;
        case 268435457:
          this.eg_reset();
          this.em_doAction(15, 1);
          this.mrg_resetKeys();
          return;
        case 268435458:
          this.eg_reset();
          this.em_doAction(13, 1);
          break;
      }
      if (this.p_eg_elementList[elementWithId].type == 1)
        this.p_eg_slider_eventPressed(elementWithId);
      if (!keypadPress && this.p_eg_elementList[elementWithId].type == 2)
        this.p_eg_selector_pressEvent(elementWithId);
      this.egi_eventPressed(elId);
    }

    public int eg_eventOccured(int element, int _event)
    {
      int realId = this.p_eg_getRealId(element);
      return this.p_eg_elementList[realId].eventTimeList[_event - 1] == int.MinValue ? int.MaxValue : this.smoothtime - this.p_eg_elementList[realId].eventTimeList[_event - 1];
    }

    public void p_eg_eventAppeared(int elId)
    {
    }

    public void p_eg_registerEvent(int realId, int _event)
    {
      this.p_eg_registerEvent(realId, _event, false);
    }

    public void p_eg_registerEvent(int realId, int _event, bool keypadPress)
    {
      if (this.p_eg_hidden || realId < 0 || !this.p_eg_elementList[realId].enabled && _event != 7)
        return;
      this.p_eg_eventRegistered = true;
      if (_event == 1)
        this.p_eg_pressEventRegistered = true;
      this.p_eg_elementList[realId]._event = _event;
      this.p_eg_elementList[realId].eventTime = this.smoothtime;
      this.p_eg_elementList[realId].eventTimeList[_event - 1] = this.smoothtime;
      switch (_event)
      {
        case 1:
          if ((this.p_eg_elementList[realId].eventMask & 1) == 0)
            break;
          this.p_eg_eventPressed(this.p_eg_elementList[realId].id, keypadPress);
          break;
        case 6:
          this.p_eg_eventAppeared(this.p_eg_elementList[realId].id);
          break;
        case 9:
          this.p_eg_dragEvent(this.p_eg_elementList[realId].id, false);
          break;
        case 10:
          this.p_eg_dragEvent(this.p_eg_elementList[realId].id, true);
          break;
        case 12:
          this.egi_selectorValueChanged(this.p_eg_elementList[realId].id);
          break;
      }
    }

    public void p_eg_dragEvent(int id, bool started)
    {
      int realId = this.p_eg_getRealId(id);
      if (realId == -1)
        return;
      this.p_eg_elementList[realId].isDragging = started;
      if (started)
      {
        this.p_eg_elementList[realId].drag_currX = this.p_eg_elementList[realId].drag_startX = this.p_eg_pointerX();
        this.p_eg_elementList[realId].drag_currY = this.p_eg_elementList[realId].drag_startY = this.p_eg_pointerY();
        this.p_eg_elementList[realId].drag_startOffsetX = this.p_eg_pointerX() - this.p_eg_elementList[realId].x;
        this.p_eg_elementList[realId].drag_startOffsetY = this.p_eg_pointerY() - this.p_eg_elementList[realId].y;
      }
      if (this.p_eg_elementList[realId].type == 1)
        this.p_eg_slider_dragEvent(realId, started);
      if (this.p_eg_elementList[realId].type != 2)
        return;
      this.p_eg_selector_dragEvent(realId, started);
    }

    public void p_eg_pointerReleased()
    {
      if (!this.p_eg_pointerReportedDown)
        return;
      this.p_eg_pointerReportedDown = false;
      if (this.p_eg_guiLocked)
        return;
      this.p_eg_stopScrollingWithPointer();
      int elementAt = this.p_eg_getElementAt(this.p_eg_pointerX(), this.p_eg_pointerY());
      if (this.p_eg_pointerDraggingElement == -1)
      {
        if (this.p_eg_focusElement == elementAt)
        {
          this.p_eg_registerEvent(elementAt, 1);
        }
        else
        {
          if (this.p_eg_focusElement != -1 && this.p_eg_elementList[this.p_eg_focusElement]._event == 2)
            this.p_eg_registerEvent(this.p_eg_focusElement, 3);
          for (int realId = 0; realId < this.p_eg_elementAmount; ++realId)
          {
            if (this.p_eg_elementList[realId]._event == 2)
              this.p_eg_registerEvent(realId, 3);
          }
          this.p_eg_setFocus(-1);
        }
      }
      else
        this.p_eg_resetDragging();
      this.p_eg_prevElementOnPointer = -1;
      this.p_eg_draggingHorizontal = false;
      this.p_eg_draggingVertical = false;
    }

    public void p_eg_resetDragging()
    {
      if (this.p_eg_pointerDraggingElement != -1)
      {
        this.p_eg_registerEvent(this.p_eg_pointerDraggingElement, 9);
        this.p_eg_pointerDraggingElement = -1;
      }
      this.p_eg_draggingVertical = false;
      this.p_eg_draggingHorizontal = false;
    }

    public int eg_getElementType(int elId) => this.p_eg_getElementType(elId);

    public int p_eg_getElementType(int elid)
    {
      int realId = this.p_eg_getRealId(elid);
      return realId < 0 ? -1 : this.p_eg_elementList[realId].type;
    }

    public void p_eg_logic()
    {
      if (this.p_eg_guiLocked)
        this.eg_setFocus(-1);
      this.p_eg_scrollLogic();
      for (int realId = 0; realId < this.p_eg_elementAmount; ++realId)
      {
        if (this.p_eg_elementList[realId].type == 1)
          this.p_eg_slider_logic(realId);
      }
      this.p_eg_keyRepeatLogic();
    }

    public void p_eg_updatePointer()
    {
      if (this.p_eg_pointerReportedDown && !this.mrg_isKey(57))
        this.p_eg_pointerReleased();
      if (!this.p_eg_pointerReportedDown && this.mrg_isKey(57))
        this.p_eg_pointerPressed();
      if (this.p_eg_guiLocked)
        return;
      int x = this.p_eg_pointerX();
      int y = this.p_eg_pointerY();
      int pEgPrevPointerX = this.p_eg_prevPointerX;
      int pEgPrevPointerY = this.p_eg_prevPointerY;
      int elementAt = this.p_eg_getElementAt(x, y);
      int elementOnPointer = this.p_eg_prevElementOnPointer;
      int num1 = x - this.p_eg_origPointerX;
      int num2 = y - this.p_eg_origPointerY;
      if (this.p_eg_pointerDown())
      {
        if (num1 < -10 || num1 > 10)
          this.p_eg_draggingHorizontal = true;
        if (num2 < -20 || num2 > 20)
          this.p_eg_draggingVertical = true;
      }
      if (this.p_eg_pointerDown() && this.p_eg_pointerDraggingElement == -1)
      {
        bool flag1 = num1 < -10 || num1 > 10;
        bool flag2 = num2 < -10 || num2 > 10;
        if (flag1 || flag2)
        {
          if (elementAt != -1 && (flag1 && this.p_eg_elementList[elementAt].draggableHoriz || flag2 && this.p_eg_elementList[elementAt].draggableVert) && !this.p_eg_scrollingWithPointer)
          {
            if (elementAt == this.p_eg_focusElement)
            {
              this.p_eg_pointerDraggingElement = elementAt;
              this.p_eg_registerEvent(this.p_eg_pointerDraggingElement, 10);
            }
          }
          else if (this.p_eg_autoScroll)
            this.p_eg_startScrollingWithPointer();
        }
      }
      else if (this.p_eg_pointerDraggingElement != -1)
      {
        this.p_eg_elementList[this.p_eg_pointerDraggingElement].drag_currX = x;
        this.p_eg_elementList[this.p_eg_pointerDraggingElement].drag_currY = y;
      }
      if (this.p_eg_focusElement != -1)
      {
        this.p_eg_elementList[this.p_eg_focusElement].drag_VX = this.timedelta != 0 ? 1000 * (x - pEgPrevPointerX) / this.timedelta : 0;
        this.p_eg_elementList[this.p_eg_focusElement].drag_VY = this.timedelta != 0 ? 1000 * (y - pEgPrevPointerY) / this.timedelta : 0;
      }
      if (this.p_eg_pointerDown())
      {
        this.p_eg_pointerVX = this.timedelta != 0 ? 1000 * (x - pEgPrevPointerX) / this.timedelta : 0;
        this.p_eg_pointerVY = this.timedelta != 0 ? 1000 * (y - pEgPrevPointerY) / this.timedelta : 0;
      }
      if (!this.p_eg_scrollingWithPointer && this.p_eg_pointerDraggingElement == -1 && elementAt != elementOnPointer && this.p_eg_origFocusElement != -1)
      {
        if (this.p_eg_pointerDown())
        {
          this.p_eg_setFocus(elementAt);
          if (this.p_eg_focusElement != -1 && this.p_eg_elementList[this.p_eg_focusElement]._event != 3)
            this.p_eg_registerEvent(this.p_eg_focusElement, 3);
          if (this.p_eg_getElementAt(this.p_eg_pointerX(), this.p_eg_pointerY()) == elementAt)
            this.p_eg_registerEvent(elementAt, 2);
        }
        else if (elementOnPointer == this.p_eg_focusElement && this.p_eg_pointerDown())
          this.p_eg_registerEvent(elementOnPointer, 3);
      }
      this.p_eg_prevPointerX = x;
      this.p_eg_prevPointerY = y;
      this.p_eg_prevElementOnPointer = elementAt;
    }

    public void eg_paint() => this.p_eg_paint();

    public void eg_skipPaint() => this.p_eg_guiPainted = true;

    public void p_eg_paint()
    {
      int pEgElementAmount = this.p_eg_elementAmount;
      this.p_eg_guiPainted = true;
      if (this.p_eg_hidden)
        return;
      int clipX = this.gfx_getClipX();
      int clipY = this.gfx_getClipY();
      int clipW = this.gfx_getClipW();
      int clipH = this.gfx_getClipH();
      int num = 0;
      for (int index1 = 0; index1 < this.p_eg_elementAmount; ++index1)
      {
        int index2 = this.p_eg_elementOrdering[index1];
        int id = this.p_eg_elementList[index2].id;
        int x = this.p_eg_scrX(index2);
        int y = this.p_eg_scrY(index2);
        int w = this.p_eg_elementList[index2].w;
        int h = this.p_eg_elementList[index2].h;
        if (this.p_eg_elementList[index2].visible)
        {
          if (!this.p_eg_elementList[index2].isStatic)
          {
            if (num != 1)
            {
              num = 1;
              this.gfx_setClip(this.p_eg_areaX, this.p_eg_areaY, this.p_eg_areaW, this.p_eg_areaH);
            }
          }
          else if (num != 2)
          {
            num = 2;
            this.gfx_setClip(0, 0, this.dynamic_X_RES, this.dynamic_Y_RES);
          }
          switch (this.p_eg_elementList[index2].type)
          {
            case 0:
              this.egi_textButtonPaint(id, x, y, w, h, this.p_eg_elementList[index2].txt, this.p_eg_elementList[index2]._event, this.smoothtime - this.p_eg_elementList[index2].eventTime, this.p_eg_focusElement == index2);
              continue;
            case 1:
              this.p_eg_slider_paint(index2);
              continue;
            case 2:
              this.p_eg_selector_paint(index2);
              continue;
            default:
              continue;
          }
        }
      }
      if (num == 0)
        return;
      this.gfx_setClip(clipX, clipY, clipW, clipH);
    }

    public void eg_setScrollMargin(int mrg) => this.p_eg_scrollMargin = mrg;

    public void eg_enableAutoScroll(bool enable) => this.p_eg_autoScroll = enable;

    public bool eg_isDisabled(int elId)
    {
      int realId = this.p_eg_getRealId(elId);
      return realId >= 0 && !this.p_eg_elementList[realId].enabled;
    }

    public void eg_resetScroll()
    {
      this.p_eg_guiScrollX = this.p_eg_guiScrollY = this.p_eg_guiScrollSrcX = this.p_eg_guiScrollSrcY = this.p_eg_guiScrollT = 0;
      this.p_eg_scrollingWithPointer = false;
    }

    public int p_eg_getScrollX()
    {
      return this.EG_NERP(this.p_eg_guiScrollSrcX, this.p_eg_guiScrollX, this.smoothtime - this.p_eg_guiScrollT, this.p_eg_guiScrollDuration);
    }

    public int p_eg_getScrollY()
    {
      return this.EG_NERP(this.p_eg_guiScrollSrcY, this.p_eg_guiScrollY, this.smoothtime - this.p_eg_guiScrollT, this.p_eg_guiScrollDuration);
    }

    public int p_eg_clampScrollX(int x)
    {
      if (!this.p_eg_horizontalMovementEnabled)
        return this.p_eg_guiScrollX;
      int num = this.p_eg_guiBorderRight - this.p_eg_guiBorderLeft + 2 * this.p_eg_scrollMargin;
      bool flag1 = this.p_eg_guiBorderLeft - this.p_eg_scrollMargin + x > this.p_eg_areaX;
      bool flag2 = this.p_eg_guiBorderRight + this.p_eg_scrollMargin + x < this.p_eg_areaX + this.p_eg_areaW;
      if (num < this.p_eg_areaW)
      {
        if (flag1 && !flag2)
          x = this.p_eg_areaX + this.p_eg_areaW - this.p_eg_scrollMargin - this.p_eg_guiBorderRight - 1;
        if (!flag1 && flag2 || !flag1 && !flag2)
          x = this.p_eg_areaX + this.p_eg_scrollMargin - this.p_eg_guiBorderLeft + 1;
      }
      else
      {
        if (flag1 && !flag2)
          x = this.p_eg_areaX + this.p_eg_scrollMargin - this.p_eg_guiBorderLeft;
        if (!flag1 && flag2)
          x = this.p_eg_areaX + this.p_eg_areaW - this.p_eg_scrollMargin - this.p_eg_guiBorderRight;
      }
      return x;
    }

    public int p_eg_clampScrollY(int y)
    {
      int num = this.p_eg_guiBorderBottom - this.p_eg_guiBorderTop + 2 * this.p_eg_scrollMargin;
      bool flag1 = this.p_eg_guiBorderTop - this.p_eg_scrollMargin + y > this.p_eg_areaY;
      bool flag2 = this.p_eg_guiBorderBottom + this.p_eg_scrollMargin + y < this.p_eg_areaY + this.p_eg_areaH;
      if (num < this.p_eg_areaH)
      {
        if (flag1 && !flag2)
          y = this.p_eg_areaY + this.p_eg_areaH - this.p_eg_scrollMargin - this.p_eg_guiBorderBottom - 1;
        if (!flag1 && flag2 || !flag1 && !flag2)
          y = this.p_eg_areaY + this.p_eg_scrollMargin - this.p_eg_guiBorderTop + 1;
      }
      else
      {
        if (flag1 && !flag2)
          y = this.p_eg_areaY + this.p_eg_scrollMargin - this.p_eg_guiBorderTop;
        if (!flag1 && flag2)
          y = this.p_eg_areaY + this.p_eg_areaH - this.p_eg_scrollMargin - this.p_eg_guiBorderBottom;
      }
      return y;
    }

    public void p_eg_scroll(int x, int y) => this.p_eg_scroll(x, y, 400);

    public void p_eg_scroll(int x, int y, int duration)
    {
      x = this.p_eg_clampScrollX(x);
      y = this.p_eg_clampScrollY(y);
      if (x == this.p_eg_guiScrollX && y == this.p_eg_guiScrollY)
        return;
      this.p_eg_guiScrollDuration = duration;
      this.p_eg_guiScrollSrcX = this.p_eg_getScrollX();
      this.p_eg_guiScrollSrcY = this.p_eg_getScrollY();
      this.p_eg_guiScrollX = x;
      this.p_eg_guiScrollY = y;
      this.p_eg_guiScrollT = this.smoothtime;
    }

    public void p_eg_scrollImmediately(int x, int y)
    {
      x = this.p_eg_clampScrollX(x);
      y = this.p_eg_clampScrollY(y);
      this.p_eg_guiScrollSrcX = this.p_eg_guiScrollX = x;
      this.p_eg_guiScrollSrcY = this.p_eg_guiScrollY = y;
      this.p_eg_guiScrollT = this.smoothtime;
    }

    public bool eg_canScrollUp() => this.p_eg_guiBorderTop + this.p_eg_guiScrollY < this.p_eg_areaY;

    public bool eg_canScrollDown()
    {
      return this.p_eg_guiBorderBottom + this.p_eg_guiScrollY > this.p_eg_areaY + this.p_eg_areaH;
    }

    public void eg_resetArea() => this.eg_setArea(0, 0, this.dynamic_X_RES, this.dynamic_Y_RES);

    public void eg_setArea(int x, int y, int w, int h)
    {
      this.p_eg_areaX = x;
      this.p_eg_areaY = y;
      this.p_eg_areaW = w;
      this.p_eg_areaH = h;
    }

    public void p_eg_stopScrollingWithPointer()
    {
      if (!this.p_eg_scrollingWithPointer)
        return;
      this.p_eg_scrollingWithPointer = false;
    }

    public void p_eg_startScrollingWithPointer()
    {
      if (!this.p_eg_canScroll() || this.p_eg_scrollingWithPointer)
        return;
      this.p_eg_scrollingWithPointer = true;
      this.p_eg_lastScrollPX = this.p_eg_pointerX();
      this.p_eg_lastScrollPY = this.p_eg_pointerY();
      this.eg_setFocus(-1);
    }

    public void p_eg_scrollTo(int realId)
    {
      int num1 = this.p_eg_scrXWithoutScroll(realId) + this.p_eg_guiScrollX;
      int num2 = this.p_eg_scrYWithoutScroll(realId) + this.p_eg_guiScrollY;
      int w = this.p_eg_elementList[realId].w;
      int h = this.p_eg_elementList[realId].h;
      int num3 = 0;
      int num4 = 0;
      if (num1 + w + this.p_eg_scrollMargin > this.p_eg_areaX + this.p_eg_areaW)
        num3 = this.p_eg_areaX + this.p_eg_areaW - num1 - w - this.p_eg_scrollMargin;
      if (num2 + h + this.p_eg_scrollMargin > this.p_eg_areaY + this.p_eg_areaH)
        num4 = this.p_eg_areaY + this.p_eg_areaH - num2 - h - this.p_eg_scrollMargin;
      if (num1 - this.p_eg_scrollMargin < this.p_eg_areaX)
        num3 = this.p_eg_areaX - num1 + this.p_eg_scrollMargin;
      if (num2 - this.p_eg_scrollMargin < this.p_eg_areaY)
        num4 = this.p_eg_areaY - num2 + this.p_eg_scrollMargin;
      this.p_eg_scroll(this.p_eg_guiScrollX + num3, this.p_eg_guiScrollY + num4);
    }

    public void eg_scrollTo(int elId)
    {
      int realId = this.p_eg_getRealId(elId);
      if (realId == -1)
        return;
      this.p_eg_scrollTo(realId);
    }

    public void eg_setElementStatic(int id, bool isStatic)
    {
      int realId = this.p_eg_getRealId(id);
      if (realId == -1)
        return;
      this.p_eg_elementList[realId].isStatic = isStatic;
    }

    public bool p_eg_canScrollVert()
    {
      return this.p_eg_guiBorderTop + this.p_eg_guiScrollY < this.p_eg_areaY || this.p_eg_guiBorderBottom + this.p_eg_guiScrollY >= this.p_eg_areaY + this.p_eg_areaH;
    }

    public bool p_eg_canScrollHoriz()
    {
      return this.p_eg_guiBorderLeft + this.p_eg_guiScrollX < this.p_eg_areaX || this.p_eg_guiBorderRight + this.p_eg_guiScrollX >= this.p_eg_areaX + this.p_eg_areaW;
    }

    public bool p_eg_canScroll() => this.p_eg_canScrollVert() || this.p_eg_canScrollHoriz();

    public void p_eg_scrollLogic()
    {
      if (!this.p_eg_autoScroll)
        return;
      if (this.p_eg_focusElement != -1 && !this.p_eg_elementList[this.p_eg_focusElement].isStatic)
        this.p_eg_scrollTo(this.p_eg_focusElement);
      if (!this.p_eg_scrollingWithPointer)
        return;
      int num1 = 0;
      int num2 = 0;
      if (this.p_eg_guiBorderLeft + this.p_eg_guiScrollX < this.p_eg_areaX || this.p_eg_guiBorderRight + this.p_eg_guiScrollX >= this.p_eg_areaX + this.p_eg_areaW)
        num1 = this.p_eg_pointerX() - this.p_eg_lastScrollPX;
      if (this.p_eg_guiBorderTop + this.p_eg_guiScrollY < this.p_eg_areaY || this.p_eg_guiBorderBottom + this.p_eg_guiScrollY >= this.p_eg_areaY + this.p_eg_areaH)
        num2 = this.p_eg_pointerY() - this.p_eg_lastScrollPY;
      this.p_eg_scrollImmediately(this.p_eg_guiScrollX + num1, this.p_eg_guiScrollY + num2);
      this.p_eg_lastScrollPX = this.p_eg_pointerX();
      this.p_eg_lastScrollPY = this.p_eg_pointerY();
    }

    public int hs_queryPlace(int table, int score)
    {
      if (this.hs_currentTable != table || this.hs_data_int == null)
        this.hs_load(table);
      for (int index = 0; index < 10; ++index)
      {
        if (score > this.hs_data_int[index])
          return index;
      }
      return -1;
    }

    public int hs_addScore(
      int table,
      mrGame.MrGame.MrgString name,
      int score,
      int extra,
      int sessionID,
      mrGame.MrGame.MrgString checksum)
    {
      this.debug_text((mrGame.MrGame.MrgString) ("hs_addScore(" + (object) table + ", ") + (name == (mrGame.MrGame.MrgString) null ? (mrGame.MrGame.MrgString) "null" : name) + (mrGame.MrGame.MrgString) ", " + (mrGame.MrGame.MrgString) score + (mrGame.MrGame.MrgString) ", " + (mrGame.MrGame.MrgString) extra + (mrGame.MrGame.MrgString) ", " + (mrGame.MrGame.MrgString) sessionID + (mrGame.MrGame.MrgString) " " + (checksum == (mrGame.MrGame.MrgString) null ? (mrGame.MrGame.MrgString) "null" : checksum) + (mrGame.MrGame.MrgString) ")");
      if (this.hs_currentTable != table || this.hs_data_int == null)
        this.hs_load(table);
      int num1 = -1;
      for (int index1 = 0; index1 < 10; ++index1)
      {
        if (score > this.hs_data_int[index1])
        {
          if (sessionID == 0)
          {
            for (int index2 = 8; index2 >= index1; --index2)
            {
              for (int index3 = 0; index3 < 5; ++index3)
                this.hs_data_int[index2 + 1 + 10 * index3] = this.hs_data_int[index2 + 10 * index3];
              for (int index4 = 0; index4 < 2; ++index4)
                this.hs_data_string[index2 + 1 + 10 * index4] = this.hs_data_string[index2 + 10 * index4];
            }
          }
          else
          {
            int num2 = -1;
            for (int index5 = 0; index5 < 10; ++index5)
            {
              if (this.hs_data_int[index5 + 40] == sessionID)
                num2 = index5;
            }
            if (num2 == -1)
            {
              for (int index6 = 8; index6 >= index1; --index6)
              {
                for (int index7 = 0; index7 < 5; ++index7)
                  this.hs_data_int[index6 + 1 + 10 * index7] = this.hs_data_int[index6 + 10 * index7];
                for (int index8 = 0; index8 < 2; ++index8)
                  this.hs_data_string[index6 + 1 + 10 * index8] = this.hs_data_string[index6 + 10 * index8];
              }
            }
            else if (num2 >= index1)
            {
              if (num2 > index1)
              {
                for (int index9 = num2 - 1; index9 >= index1; --index9)
                {
                  for (int index10 = 0; index10 < 5; ++index10)
                    this.hs_data_int[index9 + 1 + 10 * index10] = this.hs_data_int[index9 + 10 * index10];
                  for (int index11 = 0; index11 < 2; ++index11)
                    this.hs_data_string[index9 + 1 + 10 * index11] = this.hs_data_string[index9 + 10 * index11];
                }
              }
            }
            else
              break;
          }
          this.hs_data_int[index1] = score;
          this.hs_data_int[index1 + 10] = index1;
          this.hs_data_int[index1 + 20] = extra;
          this.hs_data_int[index1 + 30] = this.p_xna_getCalendarTime() / 1;
          this.hs_data_int[index1 + 40] = sessionID;
          this.hs_data_string[index1] = name;
          this.hs_data_string[index1 + 10] = checksum == (mrGame.MrGame.MrgString) null ? (mrGame.MrGame.MrgString) "" : checksum;
          num1 = index1;
          break;
        }
      }
      if (num1 < 0)
        return -1;
      int num3 = 1;
      int num4 = -1;
      for (int index = 0; index < 10; ++index)
      {
        if (this.hs_data_int[index] == num4 && this.hs_data_int[index + 40] != 0)
        {
          this.hs_data_int[index + 10] = num3;
        }
        else
        {
          this.hs_data_int[index + 10] = index + 1;
          num3 = index + 1;
          num4 = this.hs_data_int[index];
        }
      }
      this.hs_save();
      return num1;
    }

    public bool hs_load(int table)
    {
      this.debug_text((mrGame.MrGame.MrgString) ("highscores: hs_load(" + (object) table + ")"));
      if (this.hs_data_int == null)
      {
        this.hs_data_int = new int[50];
        this.hs_data_string = new mrGame.MrGame.MrgString[20];
      }
      this.hs_currentTable = table;
      sbyte[] a = this.mrg_loadData((mrGame.MrGame.MrgString) ("420" + (object) this.hs_currentTable));
      if (a != null)
      {
        try
        {
          this.p_bytecodec_istream = this.byte_array_createInput(a);
          for (int index = 0; index < this.hs_data_int.Length; ++index)
            this.hs_data_int[index] = (this.p_bytecodec_istream.pos += 4) <= this.p_bytecodec_istream.limit || this.p_bi_fillbuf_rev(this.p_bytecodec_istream, 4) ? (int) this.p_bytecodec_istream.buf[this.p_bytecodec_istream.pos - 4] << 24 | ((int) this.p_bytecodec_istream.buf[this.p_bytecodec_istream.pos - 3] & (int) byte.MaxValue) << 16 | ((int) this.p_bytecodec_istream.buf[this.p_bytecodec_istream.pos - 2] & (int) byte.MaxValue) << 8 | (int) this.p_bytecodec_istream.buf[this.p_bytecodec_istream.pos - 1] & (int) byte.MaxValue : -1;
          for (int index = 0; index < this.hs_data_string.Length; ++index)
            this.hs_data_string[index] = this.bi_getString(this.p_bytecodec_istream);
          this.p_bytecodec_istream = this.p_bi_free(this.p_bytecodec_istream);
        }
        catch (Exception ex)
        {
        }
        this.debug_text((mrGame.MrGame.MrgString) "hsgettext.exit2");
        return true;
      }
      this.debug_text((mrGame.MrGame.MrgString) "hsload.y");
      this.p_hs_reset(table);
      this.debug_text((mrGame.MrGame.MrgString) "hsgettext.exit1");
      return false;
    }

    public bool hs_save()
    {
      this.debug_text((mrGame.MrGame.MrgString) "highscores: hs_save()");
      if (this.hs_currentTable < 0)
      {
        this.debug_text((mrGame.MrGame.MrgString) "WARNING! hs_currentTable is invalid. scores probably aren't initialized. highscores not saved.");
        return false;
      }
      bool flag = false;
      try
      {
        this.be_newArray();
        for (int index = 0; index < this.hs_data_int.Length; ++index)
          this.be_writeInt(this.hs_data_int[index]);
        for (int index = 0; index < this.hs_data_string.Length; ++index)
          this.be_writeString(this.hs_data_string[index]);
        sbyte[] byteArray = this.be_getByteArray();
        this.be_close();
        flag = this.mrg_saveData((mrGame.MrGame.MrgString) ("420" + (object) this.hs_currentTable), byteArray);
      }
      catch (Exception ex)
      {
      }
      return flag;
    }

    public void p_hs_resetAll()
    {
      int hsCurrentTable = this.hs_currentTable;
      for (int table = 0; table < 2; ++table)
        this.p_hs_reset(table);
      this.hs_currentTable = hsCurrentTable;
    }

    public void p_hs_reset(int table)
    {
      this.debug_text((mrGame.MrGame.MrgString) ("hs_reset(" + (object) table + ")"));
      this.debug_text((mrGame.MrGame.MrgString) ("highscores: hs_reset(" + (object) table + ")"));
      this.debug_text((mrGame.MrGame.MrgString) ("datasize: " + (object) 50));
      if (this.hs_data_int == null)
      {
        this.hs_data_int = new int[50];
        this.hs_data_string = new mrGame.MrGame.MrgString[20];
      }
      this.hs_currentTable = table;
      this.debug_text((mrGame.MrGame.MrgString) "hs_reset.2");
      this.debug_text((mrGame.MrGame.MrgString) "hs_reset.3");
      for (int index = 0; index < 10; ++index)
      {
        this.debug_text((mrGame.MrGame.MrgString) ("hs.reset loop: " + (object) index));
        this.hs_data_int[index + 10] = index + 1;
        this.hs_data_int[index] = this.game_hs_defaultscore(table, index);
        this.hs_data_int[index + 20] = this.game_hs_defaultextra(table, index);
        this.hs_data_string[index] = (mrGame.MrGame.MrgString) "" + this.game_hs_defaultname(table, index);
        this.hs_data_int[index + 40] = 0;
        this.hs_data_int[index + 30] = this.p_xna_getCurrentMS() / 1000;
        this.hs_data_string[index + 10] = (mrGame.MrGame.MrgString) "";
      }
      this.debug_text((mrGame.MrGame.MrgString) "hs_reset.4");
      this.hs_save();
      this.debug_text((mrGame.MrGame.MrgString) "hs_reset.5");
    }

    public void hs_unload()
    {
      if (this.hs_data_int == null)
        return;
      for (int index = 0; index < 20; ++index)
        this.hs_data_string[index] = (mrGame.MrGame.MrgString) null;
      this.hs_data_int = (int[]) null;
      this.hs_data_string = (mrGame.MrGame.MrgString[]) null;
    }

    public int hs_generateSessionID() => this.p_xna_getCurrentMS() / 1000;

    public mrGame.MrGame.MrgString hs_getHighscore_text(int table)
    {
      this.debug_text((mrGame.MrGame.MrgString) "hsgettext");
      if (this.hs_currentTable != table)
        this.hs_load(table);
      mrGame.MrGame.StringBuffer stringBuffer = new mrGame.MrGame.StringBuffer();
      for (int index = 0; index < 10; ++index)
      {
        stringBuffer.append('\u0014');
        stringBuffer.append(this.hs_data_int[index + 10]);
        stringBuffer.append(' ');
        stringBuffer.append(this.hs_data_string[index]);
        stringBuffer.append('\u0015');
        stringBuffer.append(this.hs_data_int[index]);
      }
      return stringBuffer.toString();
    }

    public bool p_tb_isScrolling() => this.p_tb_changeTime + this.p_tb_scrollTime > this.smoothtime;

    public void p_tb_initSmoothScroll(int time, int scrollHeight)
    {
      this.p_tb_origScroll = this.p_tb_scroll;
      this.p_tb_changeTime = this.smoothtime;
      this.p_tb_scrollHeight = scrollHeight;
      this.p_tb_scrollTime = time;
      this.p_tb_scrollVelocity = 0;
    }

    public void p_tb_addVelocity(int velocity)
    {
      this.p_tb_scrollVelocity += velocity;
      this.p_tb_scrollHeight = 0;
    }

    public void p_tb_setScroll(int scroll)
    {
      this.p_tb_scroll = scroll;
      this.p_tb_clampScroll();
      this.p_tb_origScroll = this.p_tb_scroll;
      this.p_tb_scrollHeight = 0;
    }

    public void p_tb_clampScroll()
    {
      if (this.p_tb_scroll < 0)
      {
        this.p_tb_scroll = 0;
      }
      else
      {
        if (this.p_tb_lineCount <= 0 || this.p_tb_scroll <= (int) this.p_tb_lines[this.p_tb_lineCount - 1] << 10)
          return;
        this.p_tb_scroll = (int) this.p_tb_lines[this.p_tb_lineCount - 1] << 10;
      }
    }

    public int p_tb_getScrollHeight() => (int) this.p_tb_lines[this.p_tb_lineCount - 1] << 10;

    public void p_tb_updateSmoothScroll()
    {
      if (this.p_tb_text == (mrGame.MrGame.MrgString) null)
        return;
      if (this.p_tb_changeTime + this.p_tb_scrollTime > this.smoothtime && this.p_tb_scrollTime != 0)
      {
        int num1 = this.smoothtime - this.p_tb_changeTime - (this.p_tb_scrollTime >> 1);
        int num2 = (this.p_tb_scrollTime >> 1) - (num1 < 0 ? -num1 : num1);
        int num3 = (this.p_tb_scrollTime >> 1) - num2 * num2 / (this.p_tb_scrollTime >> 1);
        if (num1 < 0)
          num3 = -num3;
        this.p_tb_scroll = this.p_tb_origScroll + (num3 + (this.p_tb_scrollTime >> 1)) * this.p_tb_scrollHeight / this.p_tb_scrollTime;
        this.p_tb_showScrollbar = true;
      }
      else
      {
        if (this.p_tb_scrollVelocity != 0)
        {
          for (this.p_tb_timeLeft += this.timedelta; this.p_tb_timeLeft > 10; this.p_tb_timeLeft -= 10)
          {
            this.p_tb_scroll += this.p_tb_scrollVelocity;
            this.p_tb_origScroll = this.p_tb_scroll;
            this.p_tb_scrollVelocity = this.p_tb_scrollVelocity * 920 >> 10;
            if (this.p_tb_scrollVelocity > -10 && this.p_tb_scrollVelocity < 10)
              this.p_tb_scrollVelocity = 0;
            this.p_tb_clampScroll();
          }
          this.p_tb_showScrollbar = true;
        }
        else
          this.p_tb_scroll = this.p_tb_origScroll + this.p_tb_scrollHeight;
        this.p_tb_clampScroll();
        for (int index = 0; index < this.p_tb_lineCount; ++index)
        {
          if ((int) this.p_tb_lines[index] <= this.p_tb_scroll >> 10 && (int) this.p_tb_lines[index + 1] > this.p_tb_scroll >> 10)
          {
            this.p_tbCurrentLine = index;
            break;
          }
        }
      }
    }

    public void tb_skipSmoothScroll()
    {
      this.p_tb_scrollTime = 0;
      this.p_tb_updateSmoothScroll();
    }

    public void p_tb_handleInput(int flags, bool backup)
    {
      if (backup)
        this.p_tbBackupHandleFlags = flags;
      this.p_tb_inputHandleFlags = flags;
    }

    public void p_tb_inputHandlerLogic()
    {
      if ((this.p_tb_inputHandleFlags & 1) != 0)
      {
        if (this.mrg_isKey(68) && !this.p_tb_isScrolling() && this.p_tb_scroll > 0)
          this.p_tb_addVelocity(-this.timedelta * 48);
        if (this.mrg_isKey(69) && !this.p_tb_isScrolling() && this.p_tb_lineCount > 0 && this.p_tb_scroll < (int) this.p_tb_lines[this.p_tb_lineCount - 1] << 10)
          this.p_tb_addVelocity(this.timedelta * 48);
      }
      if ((this.p_tb_inputHandleFlags & 2) == 0)
        return;
      if ((this.p_tb_inputHandleFlags & 4) != 0 && this.mrg_isKey(57) && (this.p_em_isPointerOnArrow(2) || this.p_em_isPointerOnArrow(3)) && !this.p_tb_pointerPressedInside)
      {
        if (this.p_em_isPointerOnArrow(2) && this.p_tb_scroll > 0)
          this.p_tb_addVelocity(-this.timedelta * 48);
        if (this.p_em_isPointerOnArrow(3) && this.p_tb_lineCount > 0 && this.p_tb_scroll < (int) this.p_tb_lines[this.p_tb_lineCount - 1] << 10)
          this.p_tb_addVelocity(this.timedelta * 48);
        this.p_tb_pointerPressedInside = false;
      }
      else if (this.mrg_isKey(57) && this.p_tb_pointerPressedInside)
      {
        this.p_tb_setScroll(this.p_tb_pointerOrigScroll + (this.p_touchdata[this.p_mt_last].dny - this.p_touchdata[this.p_mt_last].upy << 10));
        this.p_tb_pointerLastYSpeed = this.p_tb_pointerLastY - this.p_touchdata[this.p_mt_last].upy;
        this.p_tb_pointerLastY = this.p_touchdata[this.p_mt_last].upy;
        this.p_tb_pointerHandleRelease = true;
        this.p_tb_showScrollbar = true;
      }
      else
      {
        if (!this.p_tb_pointerHandleRelease)
          return;
        this.p_tb_addVelocity(this.p_tb_pointerLastYSpeed << 10);
        this.p_tb_pointerHandleRelease = false;
      }
    }

    public bool p_tb_keyPressed(int keyCode)
    {
      if ((this.p_tb_inputHandleFlags & 1) == 1)
      {
        if (this.mrg_isKey(keyCode, 68))
        {
          this.p_tb_changeLine(4);
          return true;
        }
        if (this.mrg_isKey(keyCode, 69))
        {
          this.p_tb_changeLine(2);
          return true;
        }
      }
      if ((this.p_tb_inputHandleFlags & 2) == 2 && this.mrg_isKey(keyCode, 57))
      {
        this.p_tb_pointerPressedInside = false;
        if (this.p_touchdata[this.p_mt_last].upx > this.p_tbBorderX && this.p_touchdata[this.p_mt_last].upy > this.p_tbBorderY && this.p_touchdata[this.p_mt_last].upx < this.p_tbBorderX + this.p_tbBorderWidth && this.p_touchdata[this.p_mt_last].upy < this.p_tbBorderY + this.p_tbBorderHeight)
        {
          if (!this.p_em_isPointerOnArrow(3) && !this.p_em_isPointerOnArrow(2))
            this.p_tb_pointerPressedInside = true;
          this.p_tb_pointerOrigScroll = this.p_tb_scroll;
          this.p_tb_pointerLastY = this.p_touchdata[this.p_mt_last].upy;
        }
      }
      return false;
    }

    public void p_tb_make(
      int font,
      mrGame.MrGame.MrgString text,
      int boxWidth,
      int boxHeight,
      bool backup)
    {
      this.p_tb2_make(-1, font, text, boxWidth - 2, boxHeight, backup, true);
      this.tb_maxLines = boxHeight / this.gfx_getFontHeight(font);
      if (this.tb_maxLines < 1)
        this.tb_maxLines = 1;
      this.tb_numLines = this.p_tb_realLineCount;
      this.tb_numPages = 1;
      for (int index = 1; index < this.p_tb_realLineCount; ++index)
      {
        if ((int) this.p_tb_lines[index] - (int) this.p_tb_lines[this.p_tbCurrentLine] >= this.p_tb_boxSizeHeight)
        {
          this.p_tbCurrentLine = index - 1;
          ++this.tb_numPages;
        }
      }
      this.tb_lScrollLine = this.p_tb_lineCount - 1;
    }

    public void p_tb2_make(
      int id,
      int font,
      mrGame.MrGame.MrgString text,
      int boxWidth,
      int boxHeight,
      bool backup,
      bool emulateOld)
    {
      this.p_tbCurrentLine = 0;
      this.p_tb_realLineCount = 0;
      this.p_tb_scroll = 0;
      this.p_tb_initSmoothScroll(0, 0);
      int currentMs = this.p_xna_getCurrentMS();
      bool flag1 = false;
      this.tb_loadFinished = false;
      if (backup)
      {
        this.p_tbBackupId = id;
        this.p_tbBackupFont = font;
        this.p_tbBackupWidth = boxWidth;
        this.p_tbBackupHeight = boxHeight;
        this.p_tbBackupString = text;
        this.p_tbBackupEmulateOld = emulateOld;
      }
      this.p_tb_currenBoxId = id;
      this.p_tb_oldBehavior = emulateOld;
      this.p_tb_text = (mrGame.MrGame.MrgString) null;
      this.p_tb_text = text;
      this.p_tb_boxSizeHeight = boxHeight;
      this.p_tb_stuffCount = 0;
      this.p_tb_lineCount = 0;
      this.p_tbMaxLineWidth = 0;
      this.p_tb_lastVisibleLine = -1;
      int num1 = 0;
      int num2 = 0;
      int num3 = 0;
      int num4 = 0;
      int fontHeight = this.gfx_getFontHeight(font);
      int num5 = this.gfx_stringWidth(font, (mrGame.MrGame.MrgString) " ");
      int num6 = 0;
      int num7 = emulateOld ? 2 : 0;
      this.p_tb_lines[0] = (short) 0;
      int index1 = 1;
      int num8 = 0;
      int num9 = boxWidth;
      int num10 = 0;
      int num11 = num8;
      int num12 = num9;
      int num13 = -1;
      int num14 = 0;
      int num15 = 0;
      int num16 = 0;
      int index2 = 0;
      bool flag2 = false;
      int index3 = 0;
      int num17 = 0;
      int num18 = 0;
      int num19 = num7;
      int num20 = text.length();
      while (num2 < num20)
      {
        if ((!this.p_inGame || !this.p_gameDisplay && this.p_inGame) && this.p_xna_getCurrentMS() - currentMs > 250 && !flag1)
        {
          this.mrg_drawLoadingBox();
          currentMs = this.p_xna_getCurrentMS();
        }
        int num21 = (int) text.charAt(num2);
        ++num2;
        bool flag3 = false;
        bool flag4 = false;
        switch (num21)
        {
          case 10:
            if (num4 < num13 - num6)
              num4 = num13 - num6;
            num13 = -1;
            flag4 = flag3 = true;
            break;
          case 19:
          case 25:
          case 27:
          case 28:
            int num22 = num2 - 1;
            int num23 = 0;
            for (; text.charAt(num2) != ':'; ++num2)
              num23 = num23 * 10 + ((int) text.charAt(num2) - 48);
            ++num2;
            switch (num21)
            {
              case 25:
              case 28:
                int imageSize = this.tbi_getImageSize(id, num23);
                int num24 = imageSize >> 16 & (int) ushort.MaxValue;
                int num25 = imageSize & (int) ushort.MaxValue;
                if (num21 == 25)
                {
                  num3 = num8;
                  num8 += num24;
                  if (num8 <= num9 || boxWidth < num24)
                  {
                    short[] pTbImages1 = this.p_tb_images;
                    int index4 = num10;
                    int num26 = index4 + 1;
                    int num27 = (int) (short) num23;
                    pTbImages1[index4] = (short) num27;
                    short[] pTbImages2 = this.p_tb_images;
                    int index5 = num26;
                    int num28 = index5 + 1;
                    int num29 = (int) (short) num3;
                    pTbImages2[index5] = (short) num29;
                    short[] pTbImages3 = this.p_tb_images;
                    int index6 = num28;
                    int num30 = index6 + 1;
                    int num31 = (int) (short) num4;
                    pTbImages3[index6] = (short) num31;
                    short[] pTbImages4 = this.p_tb_images;
                    int index7 = num30;
                    num10 = index7 + 1;
                    int num32 = (int) (short) num25;
                    pTbImages4[index7] = (short) num32;
                    if (num6 < num25)
                      num6 = num25;
                    num18 = num8;
                    if (num2 == num20)
                    {
                      flag3 = true;
                      break;
                    }
                    break;
                  }
                  num2 = num22;
                  flag3 = true;
                  num8 -= num24;
                  break;
                }
                if (num8 == 0)
                {
                  switch (num7)
                  {
                    case 0:
                      num3 = 0;
                      num11 = num24;
                      num8 = num11;
                      break;
                    case 1:
                      num3 = boxWidth - num24;
                      num12 = num3;
                      num9 = num12;
                      break;
                    case 2:
                      num3 = (boxWidth - num24) / 2;
                      num6 = num25;
                      flag4 = flag3 = true;
                      for (int index8 = fontHeight; index8 < num25; index8 += fontHeight)
                      {
                        this.p_tb_lines[index1] = (short) (num4 + index8);
                        ++index1;
                      }
                      break;
                  }
                  num17 = num8;
                  num13 = num4 + num25 + 2;
                  short[] pTbImages5 = this.p_tb_images;
                  int index9 = num10;
                  int num33 = index9 + 1;
                  int num34 = (int) (short) num23;
                  pTbImages5[index9] = (short) num34;
                  short[] pTbImages6 = this.p_tb_images;
                  int index10 = num33;
                  int num35 = index10 + 1;
                  int num36 = (int) (short) num3;
                  pTbImages6[index10] = (short) num36;
                  short[] pTbImages7 = this.p_tb_images;
                  int index11 = num35;
                  int num37 = index11 + 1;
                  int num38 = (int) (short) num4;
                  pTbImages7[index11] = (short) num38;
                  short[] pTbImages8 = this.p_tb_images;
                  int index12 = num37;
                  num10 = index12 + 1;
                  int num39 = (int) (short) num25;
                  pTbImages8[index12] = (short) num39;
                  num14 = num10;
                  num15 = num10;
                  break;
                }
                flag4 = flag3 = true;
                num2 = num22;
                break;
              case 27:
                this.p_tb_stuff[num1++] = (short) -(num23 + 1 + 16383);
                break;
              default:
                this.p_tb_stuff[num1++] = (short) -(num23 + 1);
                font = this.tbi_getFont(id, num23);
                num5 = this.gfx_stringWidth(font, (mrGame.MrGame.MrgString) " ");
                fontHeight = this.gfx_getFontHeight(font);
                if (num8 == num17)
                {
                  num6 = fontHeight;
                  break;
                }
                break;
            }
            break;
          case 20:
          case 21:
          case 22:
            flag2 = true;
            num19 = num21 - 20;
            if (emulateOld && num7 == 1 && num19 == 0 && num8 > num17)
              flag3 = true;
            if (num7 == 2 && num19 != 2 && num8 > num17)
            {
              flag3 = true;
              break;
            }
            break;
          case 32:
            if (num8 > num17)
              num8 += num5;
            while (num2 < num20 && text.charAt(num2) == ' ')
              ++num2;
            break;
          default:
            --num2;
            int from = num2;
            int num40 = -1;
            int num41 = num9 - num8;
            bool flag5 = false;
            int num42 = num12 - num11;
            for (; num2 <= num20; ++num2)
            {
              int num43 = num2 == num20 ? -1 : (int) text.charAt(num2);
              if (num43 == 32 || num43 == 10 || num43 == 9 || num43 >= 19 && num43 <= 28 || num43 == -1)
              {
                int num44 = this.gfx_stringWidth(font, text.substring(from, num2));
                if (num44 > num41)
                {
                  if (num40 >= 0)
                  {
                    num2 = num40;
                    if (num43 == 32 && num44 - num16 < num42)
                    {
                      flag5 = true;
                      break;
                    }
                    break;
                  }
                  if (num41 < num42 && num44 < num42)
                  {
                    num2 = from;
                    flag3 = true;
                    break;
                  }
                  int to = from + 1;
                  int num45;
                  int num46;
                  for (num46 = num45 = this.gfx_stringWidth(font, text.substring(from, to)); num45 < num41; num45 = this.gfx_stringWidth(font, text.substring(from, to)))
                  {
                    ++to;
                    num46 = num45;
                  }
                  num16 = num46;
                  num2 = to - 1;
                  if (from == num2)
                  {
                    if (num45 < num42)
                    {
                      flag3 = true;
                      break;
                    }
                    ++num2;
                    num16 = this.gfx_stringWidth(font, text.substring(from, num2));
                    break;
                  }
                  break;
                }
                num40 = num2;
                num16 = num44;
                if (num43 != 32)
                {
                  while (text.charAt(num2 - 1) == ' ')
                    --num2;
                  num16 = num2 > from ? this.gfx_stringWidth(font, text.substring(from, num2)) : 0;
                  break;
                }
              }
            }
            if (!flag3)
            {
              num3 = num8;
              num8 += num16;
              num18 = num8;
              short[] pTbStuff1 = this.p_tb_stuff;
              int index13 = num1;
              int num47 = index13 + 1;
              int num48 = (int) (short) from;
              pTbStuff1[index13] = (short) num48;
              short[] pTbStuff2 = this.p_tb_stuff;
              int index14 = num47;
              int num49 = index14 + 1;
              int num50 = (int) (short) (num2 - from);
              pTbStuff2[index14] = (short) num50;
              short[] pTbStuff3 = this.p_tb_stuff;
              int index15 = num49;
              int num51 = index15 + 1;
              int num52 = (int) (short) num3;
              pTbStuff3[index15] = (short) num52;
              short[] pTbStuff4 = this.p_tb_stuff;
              int index16 = num51;
              int num53 = index16 + 1;
              int num54 = (int) (short) num4;
              pTbStuff4[index16] = (short) num54;
              short[] pTbStuff5 = this.p_tb_stuff;
              int index17 = num53;
              int num55 = index17 + 1;
              int num56 = (int) (short) num16;
              pTbStuff5[index17] = (short) num56;
              short[] pTbStuff6 = this.p_tb_stuff;
              int index18 = num55;
              num1 = index18 + 1;
              int num57 = (int) (short) fontHeight;
              pTbStuff6[index18] = (short) num57;
              if (flag5)
                flag3 = true;
              if (num6 < fontHeight)
              {
                num6 = fontHeight;
                break;
              }
              break;
            }
            break;
        }
        if (num2 == num20)
          flag3 = true;
        if (flag2 || flag3)
        {
          if (this.p_tbMaxLineWidth < num8)
            this.p_tbMaxLineWidth = num8;
          if (num7 != 0)
          {
            int num58 = num9 - num18;
            if (num7 == 2)
              num58 = (num58 + 1) / 2;
            while (index3 < num1)
            {
              if (this.p_tb_stuff[index3] >= (short) 0)
              {
                this.p_tb_stuff[index3 + 2] += (short) num58;
                index3 += 6;
              }
              else
                ++index3;
            }
            for (; num15 < num10; num15 += 4)
              this.p_tb_images[num15 + 1] += (short) num58;
            if (num7 == 1)
            {
              this.p_tbMaxLineWidth = num9;
              num8 = num17;
              num9 = num8 + num58;
            }
            else if (num19 == 1)
            {
              num8 = num18;
            }
            else
            {
              num8 = num17;
              num9 -= num18;
            }
          }
          else
          {
            index3 = num1;
            num15 = num10;
          }
          num17 = num8;
          flag2 = false;
          num7 = num19;
        }
        if (flag3)
        {
          while (index2 < num1)
          {
            if (this.p_tb_stuff[index2] >= (short) 0)
            {
              this.p_tb_stuff[index2 + 3] += (short) ((num6 - (int) this.p_tb_stuff[index2 + 5]) / 2);
              index2 += 6;
            }
            else
              ++index2;
          }
          for (; num14 < num10; num14 += 4)
            this.p_tb_images[num14 + 2] += (short) ((num6 - (int) this.p_tb_images[num14 + 3]) / 2);
          num4 += num6;
          if (flag4)
            num4 = num4;
          num6 = fontHeight;
          if (num4 > num13)
          {
            num8 = 0;
            num9 = boxWidth;
            num11 = 0;
            num12 = boxWidth;
          }
          else
          {
            num8 = num11;
            num9 = num12;
          }
          num17 = num8;
          num18 = num8;
          this.p_tb_lines[index1] = (short) num4;
          ++index1;
        }
      }
      while (num4 <= num13)
      {
        num4 += fontHeight;
        this.p_tb_lines[index1] = (short) num4;
        ++index1;
      }
      this.debug_text((mrGame.MrGame.MrgString) ("TEST TEST: " + (object) num4 + " " + (object) num1));
      this.p_tb_stuffHeight = num4;
      this.p_tb_stuffCount = num1;
      this.p_tb_imageCount = num10;
      this.p_tb_realLineCount = index1;
      this.p_tb_avgLinesPerPage = this.p_tb_stuffHeight > 0 ? boxHeight / (this.p_tb_stuffHeight / this.p_tb_realLineCount) : 0;
      while (index1 > 1)
      {
        --index1;
        if ((int) this.p_tb_lines[this.p_tb_realLineCount - 1] - (int) this.p_tb_lines[index1 - 1] > boxHeight)
        {
          ++index1;
          break;
        }
      }
      this.p_tb_lineCount = index1;
      this.tb_loadFinished = true;
      this.p_lb_fillScreen = false;
    }

    public void tb_draw(int font, int boxX, int boxY, int firstLine)
    {
      int pTbLine = (int) this.p_tb_lines[firstLine];
      this.tb_drawEx(font, boxX, boxY, pTbLine);
    }

    public void tb_drawEx(int font, int boxX, int boxY, int scroll)
    {
      if (!this.tb_loadFinished)
        return;
      int color = this.gfx_getColor();
      int num1 = font;
      int index1 = 0;
      int clipX = this.gfx_getClipX();
      int clipY = this.gfx_getClipY();
      int clipW = this.gfx_getClipW();
      int clipH = this.gfx_getClipH();
      int num2 = clipX + clipW;
      int num3 = clipY + clipH;
      int num4 = 0;
      int num5 = boxY - 1;
      int num6 = num4 + this.dynamic_X_RES;
      int num7 = num5 + this.p_tbBorderHeight - (this.p_tbTextY - this.p_tbBorderY << 1) + 2 + 3;
      int x0 = num4 > clipX ? num4 : clipX;
      int y0 = num5 > clipY ? num5 : clipY;
      int num8 = num6 < num2 ? num6 : num2;
      int num9 = num7 < num3 ? num7 : num3;
      this.gfx_setClip(x0, y0, num8 - x0, num9 - y0);
      int num10 = scroll;
      int num11 = this.p_tb_lastVisibleLine >= 0 ? (int) this.p_tb_lines[this.p_tb_lastVisibleLine] : this.p_tb_boxSizeHeight + 1;
      int num12 = this.p_tb_stuffHeight - this.p_tb_boxSizeHeight;
      if (num12 > 0 && num10 > num12)
        num10 = num12;
      while (index1 < this.p_tb_stuffCount)
      {
        if (this.p_tb_stuff[index1] >= (short) 0)
        {
          int num13 = (int) this.p_tb_stuff[index1 + 3] - num10;
          if (num13 < num11)
          {
            if (num13 > (int) -this.p_tb_stuff[index1 + 5] && num13 <= this.p_tb_boxSizeHeight)
            {
              int y = num13 + boxY;
              int x = boxX + (int) this.p_tb_stuff[index1 + 2];
              int from = (int) this.p_tb_stuff[index1];
              mrGame.MrGame.MrgString str = this.p_tb_text.substring(from, from + (int) this.p_tb_stuff[index1 + 1]);
              this.gfx_drawString(font, str, x, y, 20);
            }
            else if (num13 >= 0)
              break;
            index1 += 6;
          }
          else
            break;
        }
        else
        {
          int id1 = (int) -this.p_tb_stuff[index1] - 1;
          if (id1 < 16383)
          {
            font = id1 == 0 ? num1 : this.tbi_getFont(this.p_tb_currenBoxId, id1);
          }
          else
          {
            int id2 = id1 - 16383;
            this.gfx_setColor(id2 == 0 ? color : this.tbi_getFontColor(this.p_tb_currenBoxId, id2));
          }
          ++index1;
        }
      }
      for (int index2 = 0; index2 < this.p_tb_imageCount; index2 += 4)
      {
        int num14 = (int) this.p_tb_images[index2 + 2] - num10;
        if (num14 < num11)
        {
          if (num14 >= (int) -this.p_tb_images[index2 + 3] && num14 < this.p_tb_boxSizeHeight)
          {
            int x = boxX + (int) this.p_tb_images[index2 + 1];
            this.tbi_drawImage(this.p_tb_currenBoxId, (int) this.p_tb_images[index2], x, num14 + boxY);
          }
          else if (num14 >= 0)
            break;
        }
        else
          break;
      }
      this.gfx_setClip(clipX, clipY, clipW, clipH);
      this.gfx_setColor(color);
    }

    public void p_tb_makeBordered(
      int font,
      mrGame.MrGame.MrgString text,
      int x,
      int y,
      int width,
      int height,
      int borderWidth,
      int borderHeight,
      int crop,
      bool backup)
    {
      this.p_tb_make(font, text, width - (borderWidth << 1), height - (borderHeight << 1), backup);
      this.p_tbBorderX = x + borderWidth;
      this.p_tbBorderY = y + borderHeight;
      this.p_tbBorderWidth = width - (borderWidth << 1);
      this.p_tbBorderHeight = height - (borderHeight << 1);
      this.p_tbTextX = this.p_tbBorderX;
      this.p_tbTextY = this.p_tbBorderY;
      this.debug_text((mrGame.MrGame.MrgString) ("p_tbTextY right now 1: " + (object) this.p_tbTextY));
      int pTbStuffHeight = this.p_tb_stuffHeight;
      this.debug_text((mrGame.MrGame.MrgString) ("border " + (object) this.p_tbBorderHeight));
      this.debug_text((mrGame.MrGame.MrgString) ("text " + (object) pTbStuffHeight));
      if (pTbStuffHeight < this.p_tbBorderHeight)
        this.p_tbTextY += this.p_tbBorderHeight - pTbStuffHeight >> 1;
      this.debug_text((mrGame.MrGame.MrgString) ("p_tbTextY right now 2: " + (object) this.p_tbTextY));
      if (crop != 0)
      {
        if (this.tb_numPages == 1)
        {
          int num = height - (borderHeight << 1) - pTbStuffHeight;
          if ((crop & 4) != 0 && (crop & 8) != 0)
          {
            this.p_tbBorderY += num >> 1;
            this.p_tbBorderHeight -= num;
          }
          else if ((crop & 4) != 0)
          {
            this.p_tbTextY = this.p_tbBorderY + this.p_tbBorderHeight - pTbStuffHeight;
            this.p_tbBorderY = this.p_tbTextY;
            this.p_tbBorderHeight = pTbStuffHeight;
          }
          else if ((crop & 8) != 0)
          {
            this.p_tbTextY = this.p_tbBorderY;
            this.p_tbBorderHeight = pTbStuffHeight;
          }
        }
        int num1 = width - (borderWidth << 1) - this.p_tbMaxLineWidth;
        if ((crop & 1) != 0 && (crop & 2) != 0)
        {
          this.p_tbBorderX += num1 >> 1;
          this.p_tbBorderWidth -= num1;
        }
        else if ((crop & 1) != 0)
        {
          this.p_tbBorderX += num1 >> 1;
          this.p_tbBorderWidth -= num1 >> 1;
        }
        else if ((crop & 2) != 0)
          this.p_tbBorderWidth -= num1 >> 1;
      }
      this.debug_text((mrGame.MrGame.MrgString) ("p_tbTextY right now 3: " + (object) this.p_tbTextY));
      this.p_tbBorderX -= borderWidth;
      this.p_tbBorderY -= borderHeight;
      this.p_tbBorderWidth += borderWidth << 1;
      this.p_tbBorderHeight += borderHeight << 1;
      this.p_tbFont = font;
      this.p_tbCurrentLine = 0;
      if (backup)
      {
        this.p_tbBackupBorderX = this.p_tbBorderX;
        this.p_tbBackupBorderY = this.p_tbBorderY;
        this.p_tbBackupBorderWidth = this.p_tbBorderWidth;
        this.p_tbBackupBorderHeight = this.p_tbBorderHeight;
        this.p_tbBackupTextX = this.p_tbTextX;
        this.p_tbBackupTextY = this.p_tbTextY;
      }
      this.debug_text((mrGame.MrGame.MrgString) ("p_tbTextY right now 4: " + (object) this.p_tbTextY));
    }

    public bool p_tb_changeLine(int direction)
    {
      if (direction == 4 && (this.p_tb_scroll & 1023) != 0 && !this.p_tb_isScrolling())
      {
        this.p_tb_initSmoothScroll(250, -(this.p_tb_scroll - ((int) this.p_tb_lines[this.p_tbCurrentLine] << 10)));
        return true;
      }
      if (direction == 2 && ++this.p_tbCurrentLine > this.tb_lScrollLine)
      {
        this.p_tbCurrentLine = this.tb_lScrollLine;
        return false;
      }
      if (direction == 4 && --this.p_tbCurrentLine < 0)
      {
        this.p_tbCurrentLine = 0;
        return false;
      }
      this.p_tb_initSmoothScroll(250, ((int) this.p_tb_lines[this.p_tbCurrentLine] << 10) - this.p_tb_scroll);
      return true;
    }

    public bool p_tb_changePage(int direction)
    {
      if (direction == 1)
      {
        for (int index = this.p_tbCurrentLine + 1; index < this.p_tb_realLineCount; ++index)
        {
          if ((int) this.p_tb_lines[index] - (int) this.p_tb_lines[this.p_tbCurrentLine] > this.p_tb_boxSizeHeight || index > this.tb_lScrollLine)
          {
            int num = index - 1;
            if (this.p_tbCurrentLine != num)
              this.p_tbCurrentLine = num;
            else
              ++this.p_tbCurrentLine;
            this.p_tb_initSmoothScroll(500, ((int) this.p_tb_lines[this.p_tbCurrentLine] << 10) - this.p_tb_scroll);
            return true;
          }
        }
      }
      if (direction != 3 || this.p_tbCurrentLine == 0)
        return false;
      int pTbCurrentLine = this.p_tbCurrentLine;
      while (this.p_tbCurrentLine > 0)
      {
        --this.p_tbCurrentLine;
        if ((int) this.p_tb_lines[pTbCurrentLine] - (int) this.p_tb_lines[this.p_tbCurrentLine] > this.p_tb_boxSizeHeight)
        {
          ++this.p_tbCurrentLine;
          if (pTbCurrentLine == this.p_tbCurrentLine)
            --this.p_tbCurrentLine;
          this.p_tb_initSmoothScroll(500, ((int) this.p_tb_lines[this.p_tbCurrentLine] << 10) - this.p_tb_scroll);
          return true;
        }
      }
      this.p_tbCurrentLine = 0;
      this.p_tb_initSmoothScroll(500, ((int) this.p_tb_lines[this.p_tbCurrentLine] << 10) - this.p_tb_scroll);
      return true;
    }

    public void tb_setBorderedLocation(int x, int y)
    {
      int num1 = x - this.p_tbTextX;
      int num2 = y - this.p_tbTextY;
      this.p_tbTextX = x;
      this.p_tbTextY = y;
      this.p_tbBorderX += num1;
      this.p_tbBorderY += num2;
    }

    public void p_cal_setTime(int unixsecs)
    {
      this.p_cal_day = unixsecs / 86400 + 718812 + 730 - 28 - 31;
      this.p_cal_secs = unixsecs % 86400;
      this.p_cal_year = (this.p_cal_day * 4 + 3) / 1461;
      this.p_cal_day -= this.p_cal_year * 1461 / 4;
      this.p_cal_month = (this.p_cal_day * 5 + 2) / 153;
      this.p_cal_day += 1 - (this.p_cal_month * 153 + 2) / 5;
      int num = this.p_cal_month / 10;
      this.p_cal_month += 3 - 12 * num;
      this.p_cal_year += num;
    }

    public void p_cal_fmt(int index, int val, int len)
    {
      this.p_cal_tmpstr = this.txt_stringParam(this.p_cal_tmpstr, (mrGame.MrGame.MrgString) string.Concat((object) val), index);
    }

    public mrGame.MrGame.MrgString cal_format(mrGame.MrGame.MrgString fmt)
    {
      this.p_cal_tmpstr = fmt;
      this.p_cal_fmt(1, this.p_cal_year, 4);
      this.p_cal_fmt(2, this.p_cal_month, 2);
      this.p_cal_fmt(3, this.p_cal_day, 2);
      this.p_cal_fmt(4, this.p_cal_secs / 3600, 2);
      this.p_cal_fmt(5, this.p_cal_secs / 60 % 60, 2);
      this.p_cal_fmt(6, this.p_cal_secs % 60, 2);
      return this.p_cal_tmpstr;
    }

    public bool p_unsigned_lt(int a, int b) => Convert.ToUInt32(a) < Convert.ToUInt32(b);

    public bool p_unsigned_lte(int a, int b) => Convert.ToUInt32(a) <= Convert.ToUInt32(b);

    public bool p_unsigned_gt(int a, int b) => Convert.ToUInt32(a) > Convert.ToUInt32(b);

    public bool p_unsigned_gte(int a, int b) => Convert.ToUInt32(a) >= Convert.ToUInt32(b);

    public void p_bmfont_init()
    {
      this.p_bmfont_charindextbl = new int[640];
      for (int index1 = 3; index1 < 8; ++index1)
      {
        for (int index2 = 0; index2 < (int) this.p_indexTable2[42 + (index1 + 1 - 3)] - (int) this.p_indexTable2[42 + (index1 - 3)]; ++index2)
        {
          int a = (int) this.p_indexTable2[48 + ((int) this.p_indexTable2[42 + (index1 - 3)] + index2)];
          if (this.p_unsigned_lt(a, 128))
            this.p_bmfont_charindextbl[(index1 - 3) * 128 + a] = index2;
        }
      }
    }

    public void p_bmfont_free() => this.p_bmfont_charindextbl = (int[]) null;

    public int p_bmfont_getCharacterIndex(int fnt, char c)
    {
      return !this.p_unsigned_lt((int) c, 128) ? this.p_bmfont_characterIndex_slow(fnt, c) : this.p_bmfont_charindextbl[(fnt - 3) * 128 + (int) c];
    }

    public int p_bmfont_characterIndex_slow(int font, char c)
    {
      for (int index = 0; index < (int) this.p_indexTable2[42 + (font + 1 - 3)] - (int) this.p_indexTable2[42 + (font - 3)]; ++index)
      {
        if ((int) this.p_indexTable2[48 + ((int) this.p_indexTable2[42 + (font - 3)] + index)] == (int) c)
          return index;
      }
      return 0;
    }

    public int p_bmfont_stringWidth(int font, mrGame.MrGame.MrgString s)
    {
      int num1 = 0;
      for (int index = 0; index < s.length(); ++index)
      {
        int num2 = this.p_unsigned_lt((int) s.charAt(index), 128) ? this.p_bmfont_charindextbl[(font - 3) * 128 + (int) s.charAt(index)] : this.p_bmfont_characterIndex_slow(font, s.charAt(index));
        num1 += (int) this.p_indexTable1[(int) this.p_indexTable2[24 + (font - 3)] + num2];
      }
      return num1;
    }

    public int p_bmfont_getxoff(int font, int ci)
    {
      return (int) this.p_indexTable1[1291 + ((int) this.p_indexTable2[30 + (font - 3)] + ci)];
    }

    public int p_bmfont_getyoff(int font, int ci)
    {
      return (int) this.p_indexTable1[2582 + ((int) this.p_indexTable2[36 + (font - 3)] + ci)];
    }

    public int p_bmfont_getImage(int font, int ci)
    {
      return (int) this.p_indexTable2[1671 + ((int) this.p_indexTable2[1665 + (font - 3)] + ci)];
    }

    public void p_bmfont_drawString(int font, mrGame.MrGame.MrgString s, int x, int y)
    {
      for (int index = 0; index < s.length(); ++index)
      {
        char ch = s.charAt(index);
        int num1 = this.p_unsigned_lt((int) ch, 128) ? this.p_bmfont_charindextbl[(font - 3) * 128 + (int) ch] : this.p_bmfont_characterIndex_slow(font, ch);
        int num2 = (int) this.p_indexTable2[1671 + ((int) this.p_indexTable2[1665 + (font - 3)] + num1)];
        if (num2 > 0)
          this.gfx_drawImage(num2 - 1, x + (int) this.p_indexTable1[1291 + ((int) this.p_indexTable2[30 + (font - 3)] + num1)], y + (int) this.p_indexTable1[2582 + ((int) this.p_indexTable2[36 + (font - 3)] + num1)], 20, 0);
        x += (int) this.p_indexTable1[(int) this.p_indexTable2[24 + (font - 3)] + num1];
      }
    }

    public int abs(int xcd) => xcd < 0 ? -xcd : xcd;

    private int rand()
    {
      if (this.rand_randomi == null)
        this.rand_randomi = new Random();
      return this.rand_randomi.Next() & int.MaxValue;
    }

    public void initSinTables()
    {
      int[] numArray1 = (int[]) null;
      if (this.sinTbl != null)
        return;
      int[] numArray2 = new int[360];
      long num1 = 1073741824;
      long num2 = 1073578287;
      numArray2[0] = (int) (num1 >> 14);
      numArray2[1] = (int) (num2 >> 14);
      for (int index = 2; index < 90; ++index)
      {
        long num3 = (num2 * 2147156574L >> 30) - num1;
        numArray2[index] = (int) (num3 >> 14);
        num1 = num2;
        num2 = num3;
      }
      numArray2[90] = 0;
      for (int index = 89; index > 0; --index)
        numArray2[index + 90] = -numArray2[90 - index];
      numArray2[180] = -65536;
      for (int index = 179; index > 0; --index)
        numArray2[index + 180] = numArray2[180 - index];
      this.sinTbl = new short[360];
      for (int index = 0; index < 360; ++index)
        this.sinTbl[index] = (short) (numArray2[(index + 270) % 360] >> 2);
      numArray1 = (int[]) null;
    }

    public int lerp(int a, int b, int t, int t0)
    {
      if (t < 0)
        return a;
      return t > t0 ? b : (a * (t0 - t) + b * t) / t0;
    }

    public int alerp(int a, int b, int t, int t0)
    {
      t = (4 * t * t / t0 - t) / 3;
      return this.lerp(a, b, t, t0);
    }

    public int nlerp(int a, int b, int t, int t0, int ak)
    {
      if (t < 0)
        return a;
      if (t > t0)
        return b;
      int num1 = -ak << 16;
      int num2 = (num1 - 65536) / t0;
      int num3 = 131072 - num1;
      return (a * (t0 - (t * (num2 * t + num3) >> 16)) + b * (t * (num2 * t + num3) >> 16)) / t0;
    }

    public int stringToInt(mrGame.MrGame.MrgString str) => Convert.ToInt32((object) str);

    public long stringToInt64(mrGame.MrGame.MrgString str) => Convert.ToInt64((object) str);

    public void gfx_fillScreenWithImage(int img)
    {
      int imageWidth = this.gfx_getImageWidth(img);
      int imageHeight = this.gfx_getImageHeight(img);
      for (int y = 0; y < this.dynamic_Y_RES; y += imageHeight)
      {
        for (int x = 0; x < this.dynamic_X_RES; x += imageWidth)
          this.gfx_drawImage(img, x, y, 20, 0);
      }
    }

    public void gfx_fillAreaWithImage(int img, int x, int y, int w, int h)
    {
      int clipX = this.gfx_getClipX();
      int clipY = this.gfx_getClipY();
      int clipW = this.gfx_getClipW();
      int clipH = this.gfx_getClipH();
      this.gfx_setClip(x, y, w, h);
      int imageWidth = this.gfx_getImageWidth(img);
      int imageHeight = this.gfx_getImageHeight(img);
      for (int y1 = y; y1 < y + h; y1 += imageHeight)
      {
        for (int x1 = x; x1 < x + w; x1 += imageWidth)
          this.gfx_drawImage(img, x1, y1, 20, 0);
      }
      this.gfx_setClip(clipX, clipY, clipW, clipH);
    }

    public mrGame.MrGame.MrgString txt_addThousandSeparator_s(
      mrGame.MrGame.MrgString text,
      mrGame.MrGame.MrgString separator)
    {
      mrGame.MrGame.StringBuffer stringBuffer = new mrGame.MrGame.StringBuffer();
      int num1 = text.length();
      int num2 = num1 % 3;
      stringBuffer.append(text.substring(0, num2));
      for (; num2 < num1; num2 += 3)
      {
        if (num2 > 0)
          stringBuffer.append(separator);
        stringBuffer.append(text.substring(num2, num2 + 3));
      }
      return stringBuffer.toString();
    }

    public mrGame.MrGame.MrgString txt_addThousandSeparator_s(int value, mrGame.MrGame.MrgString separator)
    {
      return this.txt_addThousandSeparator_s((mrGame.MrGame.MrgString) string.Concat((object) value), separator);
    }

    public int sqrt(int input)
    {
      int num1 = 256;
      int num2 = input;
      int num3;
      while (true)
      {
        if (num2 == 0)
          num2 = 1;
        num3 = num2 + (input << 8) / num2 >> 1;
        if (num2 - num3 >= num1 || num3 - num2 >= num1)
          num2 = num3;
        else
          break;
      }
      return num3;
    }

    public int fp_mul(int fp_a, int fp_b) => (int) ((long) fp_a * (long) fp_b >> 11);

    public int fp_div(int fp_a, int fp_b) => (int) (((long) fp_a << 11) / (long) fp_b);

    public void common_init()
    {
      this.platforms_fp_wWidth = 116736;
      this.platforms_fp_wHeight = 30720;
      this.platforms_minDistance = this.platforms_fp_wHeight + (this.platforms_fp_wHeight >> 1) >> 11;
      this.common_fp_configNormalAccX = 1331200;
      this.common_fp_configNormalDecX = this.p_options[2] == (sbyte) 0 ? 2048000 : 1740800;
      this.common_fp_configNormalAccY = 1769472;
      this.common_fp_configMaxVelX = 884736;
      this.common_fp_configMaxFallVelY = -1105920;
      this.common_fp_configJumpVelY = 1146880;
      this.common_fp_configShortLegsVelY = 983040;
      this.common_fp_configCharacterYLimit = 471040;
      this.common_fp_configBrownPlatformFallVelY = 532480;
      this.common_fp_configCharacterSpringVelY = 1843200;
      this.common_fp_configPropellerHat1stPhaseDur = 2730;
      this.common_fp_configPropellerHat2ndPhaseDur = 3072;
      this.common_fp_configPropellerHat3rdPhaseDur = 1024;
      this.common_fp_configLogicScreenWidth = 655360;
      this.common_fp_configLogicScreenHeight = 983040;
      this.common_seed = this.rand();
      this.common_reset();
    }

    public void common_reset()
    {
    }

    public void common_free()
    {
    }

    public void popup_init()
    {
      this.popup_active = false;
      this.popup_type = (short) 0;
      this.popup_buttonTextId = -1;
    }

    public void popup_drawBack(int x, int y, int w, int h)
    {
      int clipX = this.gfx_getClipX();
      int clipY = this.gfx_getClipY();
      int clipW = this.gfx_getClipW();
      int clipH = this.gfx_getClipH();
      int num = 0;
      this.gfx_setClip(x + num, y + num, w - (num << 1), h - (num << 1));
      for (int y1 = y; y1 < y + h; y1 += 719)
      {
        for (int x1 = x; x1 < x + w; x1 += 441)
          this.gfx_drawImage(0, x1, y1, 20, 0);
      }
      this.gfx_setClip(x, y, w, h);
      this.popup_drawFrame(x, y, w, h);
      this.gfx_setClip(clipX, clipY, clipW, clipH);
    }

    public void popup_drawFrame(int x, int y, int w, int h)
    {
      int clipX = this.gfx_getClipX();
      int clipY = this.gfx_getClipY();
      int clipW = this.gfx_getClipW();
      int clipH = this.gfx_getClipH();
      int num1 = 27;
      int num2 = 22;
      this.gfx_drawImage(19, x, y, 20, 0);
      this.gfx_drawImage(19, x + w, y, 24, 1);
      this.gfx_drawImage(19, x, y + h, 36, 3);
      this.gfx_drawImage(19, x + w, y + h, 40, 2);
      this.gfx_setClip(x + num1, y + num2, w - (num1 << 1), h - (num2 << 1));
      for (int x1 = x + num1; x1 < x + w - num1; ++x1)
      {
        this.gfx_drawImage(20, x1, y + num2, 20, 0);
        this.gfx_drawImage(20, x1, y + h - num2, 36, 2);
      }
      this.gfx_setClip(x + num2, y + num1, w - (num2 << 1), h - (num1 << 1));
      for (int y1 = y + num1; y1 < y + h - num1; ++y1)
      {
        this.gfx_drawImage(20, x + num2, y1, 20, 3);
        this.gfx_drawImage(20, x + w - num2, y1, 24, 1);
      }
      this.gfx_setClip(clipX, clipY, clipW, clipH);
    }

    public void popup_drawTutorial(int x, int y, int w, int h, int firstImage, int fillImage)
    {
      int clipX = this.gfx_getClipX();
      int clipY = this.gfx_getClipY();
      int clipW = this.gfx_getClipW();
      int clipH = this.gfx_getClipH();
      int imageWidth = this.gfx_getImageWidth(firstImage);
      int imageHeight = this.gfx_getImageHeight(firstImage);
      this.gfx_drawImage(firstImage, x, y, 20, 0);
      this.gfx_drawImage(firstImage + 2, x + w, y, 24, 0);
      this.gfx_drawImage(firstImage + 5, x, y + h, 36, 0);
      this.gfx_drawImage(firstImage + 7, x + w, y + h, 40, 0);
      this.gfx_setClip(x + imageWidth, y, w - imageWidth * 2, h);
      for (int x1 = x + imageWidth; x1 < x + w - imageWidth; x1 += this.gfx_getImageWidth(firstImage + 1))
      {
        this.gfx_drawImage(firstImage + 1, x1, y, 20, 0);
        this.gfx_drawImage(firstImage + 6, x1, y + h, 36, 0);
      }
      this.gfx_setClip(x, y + imageHeight, w, h - imageHeight * 2);
      for (int y1 = y + imageHeight; y1 < y + h - imageHeight; y1 += this.gfx_getImageHeight(firstImage + 3))
      {
        this.gfx_drawImage(firstImage + 3, x, y1, 20, 0);
        this.gfx_drawImage(firstImage + 4, x + w, y1, 24, 0);
      }
      this.gfx_setClip(x + imageWidth, y + imageHeight, w - imageWidth * 2, h - imageHeight * 2);
      for (int y2 = y + imageHeight; y2 < y + imageHeight + h; y2 += this.gfx_getImageHeight(fillImage))
      {
        for (int x2 = x + imageWidth; x2 < x + imageWidth + w; x2 += this.gfx_getImageWidth(fillImage))
          this.gfx_drawImage(fillImage, x2, y2, 20, 0);
      }
      this.gfx_setClip(clipX, clipY, clipW, clipH);
    }

    public void popup_create(mrGame.MrGame.MrgString text, int bId, int bTextId, short type)
    {
      this.popup_active = true;
      this.eg_reset();
      this.popup_type = type;
      this.popup_buttonTextId = bTextId;
      int x = 8;
      int y1 = 8;
      int height = this.dynamic_Y_RES - 29;
      int width = this.dynamic_X_RES - (x << 1);
      int borderWidth = 33;
      int borderHeight = 29;
      if (type == (short) 1)
        height -= 29;
      this.p_tb_makeBordered(3, text, x, y1, width, height, borderWidth, borderHeight, 15, true);
      this.p_tb_handleInput(-1, true);
      int pTbBorderHeight = this.p_tbBorderHeight;
      int pTbBorderWidth = this.p_tbBorderWidth;
      this.tb_setBorderedLocation(x + 33 - ((pTbBorderWidth - 33 - 33) % 13 >> 1), this.p_tbBorderY + 29 - ((pTbBorderHeight - 29 - 29) % 13 >> 1));
      int y2 = this.p_tbBorderY + (pTbBorderHeight + (13 - (pTbBorderHeight - 58) % 13)) - 29;
      this.menu_addTextButton(bId, this.p_allTexts[bTextId], 17, 17, 0, y2);
    }

    public void popup_delete()
    {
      this.p_tb_handleInput(0, true);
      this.popup_active = false;
      this.popup_buttonTextId = -1;
      this.popup_type = (short) 0;
      this.popup_active = false;
      this.eg_reset();
    }

    public void popup_keyPressed(int keyCode)
    {
      switch (this.popup_type)
      {
        case 1:
          this.tutorial_keyPressed(keyCode);
          break;
        case 2:
          this.demo_keyPressed(keyCode);
          break;
      }
    }

    public void popup_keyReleased(int keyCode)
    {
      switch (this.popup_type)
      {
        case 1:
          this.tutorial_keyReleased(keyCode);
          break;
        case 2:
          this.demo_keyReleased(keyCode);
          break;
      }
    }

    public void popup_screenSizeUpdate()
    {
      switch (this.popup_type)
      {
        case 1:
          this.tutorial_screenSizeUpdate();
          break;
        case 2:
          this.demo_screenSizeChanged();
          break;
      }
    }

    public void popup_paint()
    {
      int pTbBorderX = this.p_tbBorderX;
      int pTbBorderY = this.p_tbBorderY;
      int pTbBorderHeight = this.p_tbBorderHeight;
      int pTbBorderWidth = this.p_tbBorderWidth;
      int w = pTbBorderWidth + (13 - (pTbBorderWidth - 66) % 13);
      int h = pTbBorderHeight + (13 - (pTbBorderHeight - 58) % 13);
      this.popup_drawTutorial(pTbBorderX, pTbBorderY, w, h, 766, 774);
      this.tb_drawEx(this.p_tbFont, this.p_tbTextX, this.p_tbTextY, this.p_tb_scroll >> 10);
      this.drawTextBoxArrows();
    }

    public void stats_init() => this.stats_table = (int[]) null;

    public void stats_load()
    {
      this.p_stats_load();
      if (this.stats_table != null)
        return;
      this.stats_table = new int[20];
      int[] statsTable = this.stats_table;
      int num = 0;
      int index = 0;
      for (int length = statsTable.Length; index < length; ++index)
        statsTable[index] = num;
    }

    public void stats_free() => this.stats_table = (int[]) null;

    public void p_stats_load()
    {
      this.debug_text((mrGame.MrGame.MrgString) "Stats loading");
      sbyte[] a = this.mrg_loadData((mrGame.MrGame.MrgString) "stats");
      if (a != null)
      {
        this.stats_table = new int[20];
        int[] statsTable = this.stats_table;
        int num = 0;
        int index1 = 0;
        for (int length = statsTable.Length; index1 < length; ++index1)
          statsTable[index1] = num;
        try
        {
          this.p_bytecodec_istream = this.byte_array_createInput(a);
          if (((this.p_bytecodec_istream.pos += 4) <= this.p_bytecodec_istream.limit || this.p_bi_fillbuf_rev(this.p_bytecodec_istream, 4) ? (int) this.p_bytecodec_istream.buf[this.p_bytecodec_istream.pos - 4] << 24 | ((int) this.p_bytecodec_istream.buf[this.p_bytecodec_istream.pos - 3] & (int) byte.MaxValue) << 16 | ((int) this.p_bytecodec_istream.buf[this.p_bytecodec_istream.pos - 2] & (int) byte.MaxValue) << 8 | (int) this.p_bytecodec_istream.buf[this.p_bytecodec_istream.pos - 1] & (int) byte.MaxValue : -1) == 1)
          {
            for (int index2 = 0; index2 < 20; ++index2)
              this.stats_table[index2] = (this.p_bytecodec_istream.pos += 4) <= this.p_bytecodec_istream.limit || this.p_bi_fillbuf_rev(this.p_bytecodec_istream, 4) ? (int) this.p_bytecodec_istream.buf[this.p_bytecodec_istream.pos - 4] << 24 | ((int) this.p_bytecodec_istream.buf[this.p_bytecodec_istream.pos - 3] & (int) byte.MaxValue) << 16 | ((int) this.p_bytecodec_istream.buf[this.p_bytecodec_istream.pos - 2] & (int) byte.MaxValue) << 8 | (int) this.p_bytecodec_istream.buf[this.p_bytecodec_istream.pos - 1] & (int) byte.MaxValue : -1;
          }
          this.p_bytecodec_istream = this.p_bi_free(this.p_bytecodec_istream);
        }
        catch (Exception ex)
        {
        }
      }
      this.debug_text((mrGame.MrGame.MrgString) "Stats loaded");
    }

    public void stats_save()
    {
      this.debug_text((mrGame.MrGame.MrgString) "Stats saving");
      try
      {
        this.be_newArray();
        this.be_writeInt(1);
        for (int index = 0; index < 20; ++index)
          this.be_writeInt(this.stats_table[index]);
        sbyte[] byteArray = this.be_getByteArray();
        this.be_close();
        this.mrg_saveData((mrGame.MrGame.MrgString) "stats", byteArray);
      }
      catch (Exception ex)
      {
      }
      this.debug_text((mrGame.MrGame.MrgString) "Stats saved");
    }

    public void stats_set(int id, int value)
    {
      if (this.multiplayer_enabled)
        return;
      this.stats_table[id] = value;
    }

    public int stats_get(int id) => this.stats_table[id];

    public void stats_bump(int id)
    {
      if (this.multiplayer_enabled)
        return;
      ++this.stats_table[id];
      if (id != 10)
        return;
      ++this.stats_table[12];
    }

    public void stats_gameStarted()
    {
      if (this.multiplayer_enabled || this.stats_table == null)
        return;
      this.stats_table[12] = 0;
      this.stats_startTimeMs = this.smoothtime;
      this.debug_text((mrGame.MrGame.MrgString) "Stats GameStarted");
    }

    public void stats_reset()
    {
      if (this.stats_table != null)
      {
        int[] statsTable = this.stats_table;
        int num = 0;
        int index = 0;
        for (int length = statsTable.Length; index < length; ++index)
          statsTable[index] = num;
      }
      this.stats_save();
    }

    public void stats_gameEnded()
    {
      if (this.multiplayer_enabled)
        return;
      if (this.stats_table[12] > this.stats_table[11])
        this.stats_table[11] = this.stats_table[12];
      ++this.stats_table[0];
      this.stats_table[3] = (this.smoothtime - this.stats_startTimeMs) / 1000;
      this.stats_table[2] += this.stats_table[3];
      if (this.stats_table[3] > this.stats_table[4])
        this.stats_table[4] = this.stats_table[3];
      this.stats_table[1] = this.doj_score;
      this.stats_table[5] += this.doj_score;
      this.debug_text((mrGame.MrGame.MrgString) "Stats Game ended");
      for (int index = 0; index < 20; ++index)
        this.debug_text((mrGame.MrGame.MrgString) (index.ToString() + ": " + (object) this.stats_table[index]));
      this.stats_save();
    }

    public mrGame.MrGame.MrgString stats_createTBContent()
    {
      mrGame.MrGame.MrgString tbContent = (mrGame.MrGame.MrgString) "";
      if (this.dynamic_X_RES < -1)
      {
        for (int statId = 0; statId < 20; ++statId)
        {
          mrGame.MrGame.MrgString linerFrontStatLine = this.p_stats_createReadable2LinerFrontStatLine(statId);
          mrGame.MrGame.MrgString mrgString1 = tbContent + linerFrontStatLine + (mrGame.MrGame.MrgString) "\n";
          mrGame.MrGame.MrgString mrgString2 = (mrGame.MrGame.MrgString) null;
          mrGame.MrGame.MrgString linerBackStatLine = this.p_stats_createReadable2LinerBackStatLine(statId);
          tbContent = mrgString1 + linerBackStatLine + (mrGame.MrGame.MrgString) "\n";
          mrgString2 = (mrGame.MrGame.MrgString) null;
        }
      }
      else
      {
        for (int statId = 0; statId < 20; ++statId)
        {
          mrGame.MrGame.MrgString readableStatLine = this.p_stats_createReadableStatLine(statId);
          tbContent = tbContent + readableStatLine + (mrGame.MrGame.MrgString) "\n";
        }
      }
      return tbContent;
    }

    public mrGame.MrGame.MrgString p_stats_createReadableStatLine(int statId)
    {
      mrGame.MrGame.MrgString s = this.txt_stringParam(this.p_allTexts[77], this.p_allTexts[statId + 56], 1);
      int num = this.stats_table[0];
      if (num == 0)
        num = 1;
      mrGame.MrGame.MrgString p1;
      switch (statId)
      {
        case 2:
        case 3:
        case 4:
          p1 = this.p_stats_createTimeString(this.stats_table[statId]);
          break;
        case 5:
          p1 = (mrGame.MrGame.MrgString) string.Concat((object) (this.stats_table[statId] / num));
          break;
        case 13:
          p1 = (mrGame.MrGame.MrgString) string.Concat((object) (this.stats_table[10] / num));
          break;
        default:
          p1 = (mrGame.MrGame.MrgString) string.Concat((object) this.stats_table[statId]);
          break;
      }
      return this.txt_stringParam(s, p1, 2);
    }

    public mrGame.MrGame.MrgString p_stats_createReadable2LinerFrontStatLine(int statId)
    {
      return this.txt_stringParam(this.p_allTexts[78], this.p_allTexts[statId + 56], 1);
    }

    public mrGame.MrGame.MrgString p_stats_createReadable2LinerBackStatLine(int statId)
    {
      int num = this.stats_table[0];
      if (num == 0)
        num = 1;
      mrGame.MrGame.MrgString p1;
      switch (statId)
      {
        case 2:
        case 3:
        case 4:
          p1 = this.p_stats_createTimeString(this.stats_table[statId]);
          break;
        case 5:
          p1 = (mrGame.MrGame.MrgString) string.Concat((object) (this.stats_table[statId] / num));
          break;
        case 13:
          p1 = (mrGame.MrGame.MrgString) string.Concat((object) (this.stats_table[10] / num));
          break;
        default:
          p1 = (mrGame.MrGame.MrgString) string.Concat((object) this.stats_table[statId]);
          break;
      }
      return this.txt_stringParam(this.p_allTexts[79], p1, 1);
    }

    public mrGame.MrGame.MrgString p_stats_createTimeString(int sec)
    {
      int num1 = sec / 3600;
      sec -= num1 * 3600;
      int num2 = sec / 60;
      sec -= num2 * 60;
      mrGame.MrGame.MrgString mrgString = (mrGame.MrGame.MrgString) "";
      if (num1 != 0)
      {
        mrGame.MrGame.MrgString p1 = (mrGame.MrGame.MrgString) string.Concat((object) num1);
        mrgString = mrgString + this.txt_stringParam(this.p_allTexts[80], p1, 1) + this.p_allTexts[83];
      }
      if (num2 != 0 || num1 != 0)
      {
        mrGame.MrGame.MrgString p1 = (mrGame.MrGame.MrgString) string.Concat((object) num2);
        mrgString = mrgString + this.txt_stringParam(this.p_allTexts[81], p1, 1) + this.p_allTexts[83];
      }
      mrGame.MrGame.MrgString p1_1 = (mrGame.MrGame.MrgString) string.Concat((object) sec);
      return mrgString + this.txt_stringParam(this.p_allTexts[82], p1_1, 1);
    }

    public void themes_init()
    {
      this.themes_current = 1;
      this.themes_scenes = (short[]) null;
      this.themes_scenesIndexes = (short[]) null;
      this.themes_scenesMarked = (bool[]) null;
      this.themes_reset();
      this.themes_map = (mrGame.MrGame.Pair[]) null;
      this.themes_characterTrunkOffset = (short[]) null;
      this.themes_spaceBg = (int[]) null;
      this.themes_spaceBgH = 0;
      this.particles_thunderBlendValue = (int[]) null;
    }

    public void themes_reset()
    {
      this.themes_scenesReset();
      this.themes_allowPropellerHat = true;
      this.themes_allowShield = true;
    }

    public void p_themes_loadCharacterTrunkOffset()
    {
      int num = 99;
      switch (this.themes_current)
      {
        case 1:
          num = 100;
          break;
        case 2:
          num = 102;
          break;
        case 3:
          num = 101;
          break;
        case 4:
          num = 103;
          break;
      }
      this.themes_characterTrunkOffset = this.p_getFile_short(this.p_indexTable3[113 + num * 3], this.p_indexTable3[113 + (num * 3 + 1)], this.p_indexTable3[113 + (num * 3 + 2)], (short[]) null);
      if (this.themes_characterTrunkOffset.Length != 0)
        return;
      this.p_themes_unloadCharacterTrunkOffset();
    }

    public void p_themes_unloadCharacterTrunkOffset()
    {
      this.themes_characterTrunkOffset = (short[]) null;
      this.themes_characterTrunkOffset = (short[]) null;
    }

    public short themes_getTrunkOffsetX(int angle)
    {
      if (this.themes_characterTrunkOffset == null)
        return 0;
      this.debug_text((mrGame.MrGame.MrgString) ("x: " + (object) this.themes_characterTrunkOffset[this.p_themes_getTrunkOffIndex(angle) + 1]));
      return this.themes_characterTrunkOffset[this.p_themes_getTrunkOffIndex(angle) + 1];
    }

    public short themes_getTrunkOffsetY(int angle)
    {
      return this.themes_characterTrunkOffset == null ? (short) 0 : this.themes_characterTrunkOffset[this.p_themes_getTrunkOffIndex(angle) + 2];
    }

    public bool themes_isTunkOffsetLoaded() => this.themes_characterTrunkOffset != null;

    public int p_themes_getTrunkOffIndex(int angle)
    {
      int length = this.themes_characterTrunkOffset.Length;
      int trunkOffIndex1 = 0;
      this.debug_text((mrGame.MrGame.MrgString) ("len: " + (object) length));
      this.debug_text((mrGame.MrGame.MrgString) ("angle: " + (object) angle));
      for (; trunkOffIndex1 < length - 3; trunkOffIndex1 += 3)
      {
        if (angle < (int) this.themes_characterTrunkOffset[trunkOffIndex1] && angle <= 0)
        {
          this.debug_text((mrGame.MrGame.MrgString) ("i: " + (object) trunkOffIndex1));
          return trunkOffIndex1;
        }
      }
      for (int trunkOffIndex2 = length - 3; trunkOffIndex2 > 0; trunkOffIndex2 -= 3)
      {
        if (angle > (int) this.themes_characterTrunkOffset[trunkOffIndex2] && angle > 0)
        {
          this.debug_text((mrGame.MrGame.MrgString) ("i: " + (object) trunkOffIndex2));
          return trunkOffIndex2;
        }
      }
      return length - 3;
    }

    public void themes_load()
    {
      this.themes_current = (int) this.p_options[7];
      this.p_themes_loadCharacterTrunkOffset();
      if (this.themes_current == 0)
      {
        this.themes_allowPropellerHat = true;
        this.themes_allowShield = true;
      }
      else if (this.themes_current == 1)
      {
        this.themes_allowPropellerHat = false;
        this.themes_allowShield = false;
        this.gfx_loadGroup(4);
        int[] fileInt = this.p_getFile_int(this.p_indexTable3[395], this.p_indexTable3[396], this.p_indexTable3[397], (int[]) null);
        int length = fileInt.Length / 2;
        this.themes_map = new mrGame.MrGame.Pair[length];
        for (int index = 0; index < length; ++index)
        {
          this.themes_map[index] = new mrGame.MrGame.Pair();
          this.themes_map[index].first = fileInt[index * 2];
          this.themes_map[index].second = fileInt[index * 2 + 1];
        }
      }
      else if (this.themes_current == 3)
      {
        this.themes_allowPropellerHat = false;
        this.themes_allowShield = false;
        this.gfx_loadGroup(5);
        int[] fileInt = this.p_getFile_int(this.p_indexTable3[398], this.p_indexTable3[399], this.p_indexTable3[400], (int[]) null);
        int length = (fileInt.Length - 8) / 2;
        this.themes_map = new mrGame.MrGame.Pair[length];
        for (int index = 0; index < length; ++index)
        {
          this.themes_map[index] = new mrGame.MrGame.Pair();
          this.themes_map[index].first = fileInt[index * 2];
          this.themes_map[index].second = fileInt[index * 2 + 1];
        }
        this.particles_thunderBlendValue = new int[8];
        int num = fileInt.Length - 8;
        for (int index = 0; index < 8; ++index)
          this.particles_thunderBlendValue[index] = fileInt[num++];
      }
      else if (this.themes_current == 2)
      {
        this.themes_allowPropellerHat = true;
        this.themes_allowShield = true;
        this.gfx_loadGroup(6);
        int[] fileInt = this.p_getFile_int(this.p_indexTable3[401], this.p_indexTable3[402], this.p_indexTable3[403], (int[]) null);
        int length = fileInt.Length / 2;
        this.themes_map = new mrGame.MrGame.Pair[length];
        for (int index = 0; index < length; ++index)
        {
          this.themes_map[index] = new mrGame.MrGame.Pair();
          this.themes_map[index].first = fileInt[index * 2];
          this.themes_map[index].second = fileInt[index * 2 + 1];
        }
      }
      else
      {
        if (this.themes_current != 4)
          return;
        this.themes_allowPropellerHat = true;
        this.themes_allowShield = false;
        this.gfx_loadGroup(7);
        int[] fileInt = this.p_getFile_int(this.p_indexTable3[404], this.p_indexTable3[405], this.p_indexTable3[406], (int[]) null);
        int length1 = fileInt.Length / 2;
        this.themes_map = new mrGame.MrGame.Pair[length1];
        for (int index = 0; index < length1; ++index)
        {
          this.themes_map[index] = new mrGame.MrGame.Pair();
          this.themes_map[index].first = fileInt[index * 2];
          this.themes_map[index].second = fileInt[index * 2 + 1];
        }
        this.themes_spaceBg = this.p_getFile_int(this.p_indexTable3[407], this.p_indexTable3[408], this.p_indexTable3[409], (int[]) null);
        int length2 = this.themes_spaceBg.Length;
        this.themes_spaceBgH = 0;
        for (int index = 0; index < length2; index += 4)
        {
          this.themes_spaceBg[index] = this.fp_mul(this.themes_spaceBg[index] << 11, this.common_fp_yRatio) >> 11;
          this.themes_spaceBgH += this.themes_spaceBg[index];
        }
      }
    }

    public void themes_gameStart()
    {
      this.themes_current = (int) this.p_options[7];
      if (this.themes_current == 1 || this.themes_current == 3)
      {
        this.doj_drawRippedPaper = true;
        this.themes_allowPropellerHat = false;
      }
      else
        this.themes_allowPropellerHat = true;
      if (this.themes_current == 4 || this.themes_current == 3 || this.themes_current == 1)
        this.themes_allowShield = false;
      else
        this.themes_allowShield = true;
    }

    public void themes_unload()
    {
      this.p_themes_unloadCharacterTrunkOffset();
      if (this.themes_current == 0)
        return;
      if (this.themes_current == 1)
        this.gfx_unloadGroup(4);
      else if (this.themes_current == 3)
      {
        this.gfx_unloadGroup(5);
        this.particles_thunderBlendValue = (int[]) null;
        this.particles_thunderBlendValue = (int[]) null;
      }
      else if (this.themes_current == 2)
        this.gfx_unloadGroup(6);
      else if (this.themes_current == 4)
      {
        this.gfx_unloadGroup(7);
        this.themes_spaceBg = (int[]) null;
        this.themes_spaceBg = (int[]) null;
      }
      int length = this.themes_map.Length;
      for (int index = 0; index < length; ++index)
        this.themes_map[index] = (mrGame.MrGame.Pair) null;
      this.themes_map = (mrGame.MrGame.Pair[]) null;
      this.themes_map = (mrGame.MrGame.Pair[]) null;
    }

    public void themes_scenesReset()
    {
      if (this.themes_scenesMarked == null)
        return;
      for (int index = 0; index < this.themes_scenesMarked.Length; ++index)
        this.themes_scenesMarked[index] = false;
    }

    public int themes_getImageId(int id)
    {
      if (!this.p_inGame || this.themes_current == 0 || this.themes_map == null)
        return id;
      for (int index = 0; index < this.themes_map.Length; ++index)
      {
        if (this.themes_map[index].first == id)
          return this.themes_map[index].second;
      }
      return id;
    }

    public int themes_getOffset(int offset)
    {
      if (offset == 6 && !this.p_inGame)
        return 6;
      if (this.themes_current == 1)
      {
        switch (offset)
        {
          case 1:
            return -12;
          case 2:
            return 10;
          case 5:
            return 11;
          case 6:
            return 2;
          default:
            this.debug_text((mrGame.MrGame.MrgString) "unknown offset");
            return 0;
        }
      }
      else if (this.themes_current == 4)
      {
        switch (offset)
        {
          case 1:
            return -12;
          case 2:
            return 8;
          case 3:
            return -5;
          case 4:
            return -6;
          case 5:
            return 10;
          case 6:
            return 6;
          default:
            this.debug_text((mrGame.MrGame.MrgString) "unknown offset");
            return 0;
        }
      }
      else
      {
        if (this.themes_current == 3)
        {
          switch (offset)
          {
            case 1:
              return -5;
            case 2:
              return 4;
            case 5:
              return 10;
            case 6:
              return 1;
          }
        }
        else if (this.themes_current == 2)
        {
          switch (offset)
          {
            case 1:
              return -8;
            case 2:
            case 5:
              return 0;
            case 3:
              return -8;
            case 4:
              return -15;
            case 6:
              return 6;
            default:
              this.debug_text((mrGame.MrGame.MrgString) "unknown offset");
              return 0;
          }
        }
        switch (offset - 1)
        {
          case 0:
            return -1;
          case 1:
            return 0;
          case 2:
            return 0;
          case 3:
            return -13;
          case 4:
            return 10;
          case 5:
            return 6;
          default:
            this.debug_text((mrGame.MrGame.MrgString) "unknown offset");
            return 0;
        }
      }
    }

    public int themes_getColor(int color)
    {
      int num = this.themes_current;
      if (!this.p_inGame)
        num = 0;
      switch (num)
      {
        case 0:
          if (color == 14)
            return 16052202;
          break;
        case 1:
          if (color == 14)
            return 5075621;
          break;
        case 2:
          if (color == 14)
            return 4604736;
          break;
        case 3:
          if (color == 14)
            return 5737519;
          break;
        case 4:
          if (color == 14)
            return 4344664;
          break;
        default:
          return 0;
      }
      return 0;
    }

    public void themes_free() => this.themes_scenesUnload();

    public void themes_scenesLoad()
    {
      this.themes_scenesReset();
      this.themes_scenesIndexes = new short[21];
      short length1 = 0;
      for (int index = 0; index < 20; ++index)
      {
        short[] fileShort = this.p_getFile_short(this.p_indexTable3[113 + (74 + index) * 3], this.p_indexTable3[113 + ((74 + index) * 3 + 1)], this.p_indexTable3[113 + ((74 + index) * 3 + 2)], (short[]) null);
        this.themes_scenesIndexes[index] = length1;
        length1 += (short) fileShort.Length;
      }
      this.themes_scenesIndexes[20] = length1;
      this.themes_scenes = new short[(int) length1];
      this.themes_scenesMarked = new bool[(int) length1];
      for (int index = 0; index < 20; ++index)
      {
        short[] fileShort = this.p_getFile_short(this.p_indexTable3[113 + (74 + index) * 3], this.p_indexTable3[113 + ((74 + index) * 3 + 1)], this.p_indexTable3[113 + ((74 + index) * 3 + 2)], (short[]) null);
        int length2 = fileShort.Length;
        Array.Copy((Array) fileShort, 0, (Array) this.themes_scenes, (int) this.themes_scenesIndexes[index], length2);
        this.themes_scenesMarked[index] = false;
      }
    }

    public void themes_scenesUnload()
    {
      this.themes_scenes = (short[]) null;
      this.themes_scenes = (short[]) null;
      this.themes_scenesIndexes = (short[]) null;
      this.themes_scenesIndexes = (short[]) null;
      this.themes_scenesMarked = (bool[]) null;
      this.themes_scenesMarked = (bool[]) null;
    }

    public short p_themes_scenesGetNext(bool hard)
    {
      int num = 0;
      if (hard)
        num = 1;
      if (!this.doj_classicMode)
        num += 2;
      short themesScenesIndex1 = this.themes_scenesIndexes[this.themes_current * 4 + num];
      short themesScenesIndex2 = this.themes_scenesIndexes[this.themes_current * 4 + num + 1];
      int index1;
      do
      {
        index1 = this.rand() % ((int) themesScenesIndex2 - (int) themesScenesIndex1) + (int) themesScenesIndex1;
      }
      while (this.themes_scenesMarked[index1]);
      this.themes_scenesMarked[index1] = true;
      bool flag = true;
      for (int index2 = (int) themesScenesIndex1; index2 < (int) themesScenesIndex2; ++index2)
      {
        if (!this.themes_scenesMarked[index2])
          flag = false;
        this.debug_text((mrGame.MrGame.MrgString) (" " + (object) this.themes_scenesMarked[index2]));
      }
      if (flag)
      {
        for (int index3 = (int) themesScenesIndex1; index3 < (int) themesScenesIndex2; ++index3)
          this.themes_scenesMarked[index3] = false;
      }
      return this.themes_scenes[index1];
    }

    public short themes_scenesGetNextHard() => this.p_themes_scenesGetNext(true);

    public short themes_scenesGetNextEasy() => this.p_themes_scenesGetNext(false);

    public int themes_getCount() => 5;

    public int themes_getThemeId(int sel) => sel;

    public int themes_getThemeSel() => this.themes_current;

    public void particles_init()
    {
      this.debug_text((mrGame.MrGame.MrgString) "PARTICLES INIT");
      this.particles_array = new mrGame.MrGame.Particle[60];
      for (int index = 0; index < 60; ++index)
        this.particles_array[index] = new mrGame.MrGame.Particle();
      this.particles_enabled = false;
      this.particles_p_rainPlaying = false;
      this.particles_thunder = false;
      this.particles_blendTime = 0;
      this.particles_p_rainThunderTriggerd = false;
    }

    public void particles_reset()
    {
      this.debug_text((mrGame.MrGame.MrgString) "PARTICLES RESET");
      this.particles_enabled = true;
      this.particles_fp_time = 0;
      switch (this.themes_current)
      {
        case 1:
          this.p_particles_initSnow();
          break;
        case 3:
          this.p_particles_initRain();
          break;
        case 4:
          this.p_particles_initStar();
          break;
        default:
          this.particles_enabled = false;
          break;
      }
    }

    public void particles_free()
    {
      for (int index = 0; index < 60; ++index)
        this.particles_array[index] = (mrGame.MrGame.Particle) null;
      this.particles_array = (mrGame.MrGame.Particle[]) null;
    }

    public void particles_update(int fp_dt)
    {
      if (!this.particles_enabled)
        return;
      switch (this.themes_current)
      {
        case 1:
          this.p_particles_updateSnow(fp_dt);
          break;
        case 3:
          this.p_particles_updateRain(fp_dt);
          break;
        case 4:
          this.p_particles_updateStar(fp_dt);
          break;
      }
    }

    public void particles_drawBackground()
    {
      if (!this.particles_enabled || this.themes_current != 4)
        return;
      this.p_particles_drawStar();
    }

    public void particles_drawForeground()
    {
      if (!this.particles_enabled)
        return;
      switch (this.themes_current)
      {
        case 1:
          this.p_particles_drawSnow();
          break;
        case 3:
          this.p_particles_drawRain();
          break;
      }
    }

    public void p_particles_updateSnow(int fp_dt)
    {
      for (int i = 0; i < 60; ++i)
      {
        int fpY = this.particles_array[i].fp_y;
        this.particles_array[i].fp_y -= this.fp_mul(this.particles_array[i].fp_vel, fp_dt);
        if (this.particles_array[i].fp_y - this.doj_fp_screenYOffset < 0)
        {
          this.p_particles_initSnowFlake(i);
        }
        else
        {
          int fp_a = fpY - this.particles_array[i].fp_y + this.particles_array[i].fp_yOffset;
          this.particles_array[i].fp_yOffset = fp_a;
          int num = this.fp_mul((int) this.sinTbl[((this.fp_div(this.fp_mul(fp_a - this.fp_mul(this.particles_array[i].fp_cycle, this.fp_div(fp_a, this.particles_array[i].fp_cycle) >> 11 << 11), 737280), this.particles_array[i].fp_cycle) >> 11) + 360) % 360] >> 3, this.particles_array[i].fp_amplitude);
          this.particles_array[i].fp_x += num - this.particles_array[i].fp_xOffset;
          this.particles_array[i].fp_xOffset = num;
        }
      }
    }

    public void p_particles_drawSnow()
    {
      for (int index = 0; index < 60; ++index)
        this.gfx_drawImage((int) this.particles_array[index].type + 1206, this.doj_worldToScreenX(this.particles_array[index].fp_x), this.doj_worldToScreenY(this.particles_array[index].fp_y - this.doj_fp_screenYOffset), 3, 0);
    }

    public void p_particles_initSnow()
    {
      for (int i = 0; i < 60; ++i)
      {
        this.p_particles_initSnowFlake(i);
        int num = this.fp_div(this.rand() % this.dynamic_Y_RES << 11, this.common_fp_yRatio);
        this.particles_array[i].fp_y = num + this.doj_fp_screenYOffset;
      }
    }

    public void p_particles_initSnowFlake(int i)
    {
      short num1 = (short) (this.rand() % 3);
      int num2 = this.rand() % 50 + 50 << 11;
      int num3 = this.fp_div(this.rand() % ((this.dynamic_X_RES >> 5) - (this.dynamic_X_RES >> 6)) + (this.dynamic_X_RES >> 6) << 11, this.common_fp_xRatio);
      int num4 = this.fp_div(this.rand() % ((this.dynamic_Y_RES >> 1) - (this.dynamic_Y_RES >> 2)) + (this.dynamic_Y_RES >> 2) << 11, this.common_fp_yRatio);
      int num5 = this.fp_div(this.rand() % this.dynamic_X_RES << 11, this.common_fp_xRatio);
      int num6 = this.fp_div(this.dynamic_Y_RES << 11, this.common_fp_yRatio);
      this.particles_array[i].fp_x = num5;
      this.particles_array[i].fp_y = num6 + this.doj_fp_screenYOffset;
      this.particles_array[i].type = num1;
      this.particles_array[i].fp_vel = num2;
      this.particles_array[i].fp_amplitude = num3;
      this.particles_array[i].fp_cycle = num4;
    }

    public void p_particles_updateRain(int fp_dt)
    {
      this.particles_fp_time += fp_dt;
      this.particles_fp_time %= 122880;
      if (this.particles_fp_time > 61440)
      {
        if (this.particles_fp_time < 92160)
          this.particles_active = (this.particles_fp_time - 61440) / 15 * 60 >> 11;
        else if (this.particles_fp_time < 122880)
          this.particles_active = (122880 - this.particles_fp_time) / 15 * 60 >> 11;
        if (this.particles_fp_time < 92672 && this.particles_fp_time > 91648)
        {
          this.particles_thunder = true;
          this.particles_blendTime += fp_dt;
          if (!this.particles_p_rainThunderTriggerd)
          {
            this.particles_p_rainThunderTriggerd = true;
            this.p_playSound(30, 128, 1);
          }
        }
        else
        {
          this.particles_blendTime = 0;
          this.particles_thunder = false;
          this.particles_p_rainThunderTriggerd = false;
        }
        this.p_particles_startRainSnd();
      }
      else
      {
        this.p_particles_stopRainSnd();
        this.particles_active = 0;
      }
      for (int i = 0; i < 60; ++i)
      {
        int fpY = this.particles_array[i].fp_y;
        this.particles_array[i].fp_y -= this.fp_mul(this.particles_array[i].fp_vel, fp_dt);
        this.particles_array[i].fp_x -= this.fp_mul(this.particles_array[i].fp_vel, fp_dt) / 3;
        if (this.particles_array[i].fp_y - this.doj_fp_screenYOffset < 0 && i < this.particles_active)
          this.p_particles_initRainDrop(i);
      }
    }

    public void p_particles_drawRain()
    {
      for (int index = 0; index < this.particles_active; ++index)
        this.gfx_drawImage(1329, this.doj_worldToScreenX(this.particles_array[index].fp_x), this.doj_worldToScreenY(this.particles_array[index].fp_y - this.doj_fp_screenYOffset), 3, 0);
    }

    public void p_particles_initRain()
    {
      this.particles_active = 0;
      for (int i = 0; i < this.particles_active; ++i)
      {
        this.p_particles_initRainDrop(i);
        int num = this.fp_div(this.rand() % this.dynamic_Y_RES << 11, this.common_fp_yRatio);
        this.particles_array[i].fp_y = num + this.doj_fp_screenYOffset;
      }
    }

    public void p_particles_initRainDrop(int i)
    {
      int num1 = this.rand() % 300 + 300 << 11;
      int num2 = this.fp_div(this.rand() % (this.dynamic_X_RES + this.dynamic_X_RES / 3) << 11, this.common_fp_xRatio);
      int num3 = this.fp_div(this.dynamic_Y_RES << 11, this.common_fp_yRatio);
      this.particles_array[i].fp_x = num2;
      this.particles_array[i].fp_y = num3 + this.doj_fp_screenYOffset;
      this.particles_array[i].fp_vel = num1;
    }

    public void p_particles_startRainSnd()
    {
      if (this.particles_p_rainPlaying)
        return;
      this.p_playSound(29, 0, 0);
      this.particles_p_rainPlaying = true;
    }

    public void p_particles_stopRainSnd()
    {
      if (!this.particles_p_rainPlaying)
        return;
      this.sfx_stop(29);
      this.particles_p_rainPlaying = false;
    }

    public void p_particles_updateStar(int fp_dt)
    {
      this.particles_fp_time += fp_dt;
      if (this.particles_fp_time <= this.particles_array[0].fp_cycle && this.particles_array[0].fp_cycle != -1)
        return;
      if (this.particles_array[0].fp_cycle != -1)
      {
        this.particles_array[0].fp_cycle = -1;
        this.particles_array[0].fp_y += this.doj_fp_screenYOffset;
      }
      this.particles_array[0].fp_x += this.fp_mul(this.particles_array[0].fp_xOffset, fp_dt);
      this.particles_array[0].fp_y += this.fp_mul(this.particles_array[0].fp_yOffset, fp_dt);
      if (this.particles_array[0].fp_y - this.doj_fp_screenYOffset >= -61440 && (this.particles_array[0].fp_x >= -61440 || this.particles_array[0].fp_vel > 170 || this.particles_array[0].fp_vel < 145) && (this.particles_array[0].fp_x <= 716800 || this.particles_array[0].fp_vel <= 170 && this.particles_array[0].fp_vel >= 145))
        return;
      this.p_particles_initStar();
    }

    public void p_particles_initStar()
    {
      short num1 = (short) (this.rand() % 2 + 5);
      this.particles_array[0].fp_cycle = this.particles_fp_time + (this.rand() % 6144 + 2048);
      this.particles_array[0].fp_amplitude = (122880 + 16384 * (this.rand() % 6)) / 100;
      this.particles_array[0].type = num1;
      int num2;
      int num3;
      if (this.rand() % 2 == 1)
      {
        this.particles_array[0].fp_vel = this.rand() % 25 + 145;
        num2 = this.rand() % 320 + 160 << 11;
        num3 = this.rand() % 40 + 500 << 11;
      }
      else
      {
        this.particles_array[0].fp_vel = this.rand() % 25 + 190;
        num2 = this.rand() % 320 - 160 << 11;
        num3 = this.rand() % 40 + 500 << 11;
      }
      this.particles_array[0].fp_x = num2;
      this.particles_array[0].fp_y = num3;
      this.particles_array[0].fp_xOffset = ((int) -this.sinTbl[this.particles_array[0].fp_vel] * 6 >> 3) * 60;
      this.particles_array[0].fp_yOffset = ((int) this.sinTbl[(this.particles_array[0].fp_vel + 90) % 360] * 6 >> 3) * 60;
    }

    public void p_particles_drawStar()
    {
      if (this.particles_array[0].fp_cycle != -1)
        return;
      this.egfx_reset();
      int num = 0;
      if ((this.particles_fp_time >> 8) % 3 == 1)
        num = 1;
      else if ((this.particles_fp_time >> 8) % 3 == 2)
        num = 2;
      int imageindex;
      if (this.particles_array[0].type == (short) 5)
      {
        this.p_egfx_pixel_rotate_f((float) ((int) ushort.MaxValue - 182 * this.particles_array[0].fp_vel) * 1.52587891E-05f);
        imageindex = num + 1554;
      }
      else
      {
        this.p_egfx_pixel_rotate_f((float) ((int) ushort.MaxValue - 182 * this.particles_array[0].fp_vel) * 1.52587891E-05f);
        imageindex = num + 1554;
      }
      int fp_y = this.particles_array[0].fp_y - this.doj_fp_screenYOffset;
      this.p_egfx_pixel_scale_f((float) (this.particles_array[0].fp_amplitude << 5) * 1.52587891E-05f);
      this.gfx_drawImage(imageindex, this.doj_worldToScreenX(this.particles_array[0].fp_x), this.doj_worldToScreenY(fp_y), 17, 0);
      this.egfx_reset();
    }

    public void objects_init()
    {
      this.objects_array = new mrGame.MrGame.GameObject[30];
      for (int index = 0; index < 30; ++index)
        this.objects_array[index] = new mrGame.MrGame.GameObject();
      this.objects_reset();
      this.objects_maxHeight = 136;
      this.objects_monsterBlueWingsAnim = (sbyte[]) null;
    }

    public void objects_load()
    {
      this.objects_monsterBlueWingsAnim = this.p_getFile_byte(this.p_indexTable3[116], this.p_indexTable3[117], this.p_indexTable3[118], (sbyte[]) null);
    }

    public void objects_unload()
    {
      this.objects_monsterBlueWingsAnim = (sbyte[]) null;
      this.objects_monsterBlueWingsAnim = (sbyte[]) null;
    }

    public void objects_reset()
    {
      this.objects_begin = 0;
      this.objects_end = 0;
      this.objects_collidedIndex = 0;
      this.objects_holdOnIndex = -1;
    }

    public void objects_free()
    {
      for (int index = 0; index < 30; ++index)
        this.objects_array[index] = (mrGame.MrGame.GameObject) null;
      this.objects_array = (mrGame.MrGame.GameObject[]) null;
      this.objects_monsterBlueWingsAnim = (sbyte[]) null;
      this.objects_monsterBlueWingsAnim = (sbyte[]) null;
    }

    public void objects_push(int wx, int wy, int id)
    {
      this.objects_array[this.objects_end].fp_x = wx;
      this.objects_array[this.objects_end].fp_y = wy;
      this.objects_array[this.objects_end].id = id;
      this.objects_array[this.objects_end].fp_velY = 0;
      this.objects_array[this.objects_end].fp_rangeX = 0;
      this.objects_array[this.objects_end].fp_rangeY = 0;
      this.objects_array[this.objects_end].fp_offsetX = 0;
      this.objects_array[this.objects_end].fp_offsetY = 0;
      this.objects_array[this.objects_end].fp_timeUpdate = 0;
      ++this.objects_end;
      while (this.objects_end >= 30)
        this.objects_end -= 30;
    }

    public void objects_pushMenuObject()
    {
      this.objects_reset();
      this.objects_push(532480, 819200, 5);
    }

    public void objects_update(int fp_time)
    {
      int num1 = this.fp_div(this.objects_maxHeight << 11, this.common_fp_yRatio) >> 1;
      for (int objectsBegin = this.objects_begin; objectsBegin < this.objects_end + 30; ++objectsBegin)
      {
        int index = this.objects_begin >= this.objects_end ? (objectsBegin < 30 ? objectsBegin : objectsBegin - 30) : objectsBegin;
        if (index == this.objects_end)
          break;
        if (this.objects_array[index].fp_y - this.doj_fp_screenYOffset < -num1 && this.objects_array[index].id != 32)
        {
          if (this.objects_array[index].id != 4)
          {
            this.achievement_add(5);
            this.achievement_add(6);
          }
          this.objects_array[index].id = 32;
          this.doj_stopWarningSounds();
        }
        else if (this.objects_array[index].id != 32 && index != this.objects_holdOnIndex)
        {
          if (this.objects_array[index].fp_velY < 0)
            this.objects_array[index].fp_y += this.fp_mul(this.objects_array[index].fp_velY, fp_time);
          else if (this.objects_array[index].id == 10 || this.objects_array[index].id == 11 || this.objects_array[index].id == 31 || this.objects_array[index].id == 30 || this.objects_array[index].id == 8 || this.objects_array[index].id == 7)
          {
            int num2 = 10 * (int) this.sinTbl[this.objects_array[index].fp_rangeX >> 11] >> 3;
            this.objects_array[index].fp_x += num2 - this.objects_array[index].fp_offsetX;
            this.objects_array[index].fp_offsetX = num2;
            this.objects_array[index].fp_rangeX += this.fp_mul(1720320, fp_time);
            while (this.objects_array[index].fp_rangeX >= 737280)
              this.objects_array[index].fp_rangeX -= 737280;
            int num3 = 5 * (int) this.sinTbl[this.objects_array[index].fp_rangeY >> 11] >> 3;
            this.objects_array[index].fp_y += num3 - this.objects_array[index].fp_offsetY;
            this.objects_array[index].fp_offsetY = num3;
            this.objects_array[index].fp_rangeY += this.fp_mul(344064, fp_time);
            while (this.objects_array[index].fp_rangeY >= 737280)
              this.objects_array[index].fp_rangeY -= 737280;
            if (this.objects_array[index].id == 31)
            {
              this.objects_array[index].fp_timeUpdate += fp_time;
              if (this.objects_array[index].fp_timeUpdate > 192)
                this.objects_array[index].id = 30;
            }
          }
          else if (this.objects_array[index].id == 9)
          {
            if (this.objects_array[index].fp_rangeX == 0)
              this.objects_array[index].fp_rangeX = 245760;
            int num4 = this.fp_mul(fp_time, this.objects_array[index].fp_rangeX);
            this.objects_array[index].fp_x += num4;
            int num5 = this.fp_mul(108544, this.common_fp_xRatio) >> 1;
            if (this.objects_array[index].fp_x + num5 > this.common_fp_configLogicScreenWidth)
            {
              this.objects_array[index].fp_x = this.common_fp_configLogicScreenWidth - num5;
              this.objects_array[index].fp_rangeX = -245760;
            }
            else if (this.objects_array[index].fp_x - num5 < 0)
            {
              this.objects_array[index].fp_x = num5;
              this.objects_array[index].fp_rangeX = 245760;
            }
            int num6 = 10 * (int) this.sinTbl[this.objects_array[index].fp_rangeY >> 11] >> 3;
            this.objects_array[index].fp_y += num6 - this.objects_array[index].fp_offsetY;
            this.objects_array[index].fp_offsetY = num6;
            this.objects_array[index].fp_rangeY += this.fp_mul(1044480, fp_time);
            while (this.objects_array[index].fp_rangeY >= 737280)
              this.objects_array[index].fp_rangeY -= 737280;
          }
          else if (this.objects_array[index].id == 5)
          {
            int num7 = 20 * ((int) this.sinTbl[this.fp_div(this.fp_mul(this.objects_array[index].fp_rangeX, 40), 12868) * 360 >> 11] >> 3);
            this.objects_array[index].fp_x += num7 - this.objects_array[index].fp_offsetX;
            this.objects_array[index].fp_offsetX = num7;
            this.objects_array[index].fp_rangeX += this.fp_mul(122880, fp_time);
            if (this.objects_array[index].fp_rangeX >= 645120)
              this.objects_array[index].fp_rangeX = 0;
            int num8 = 10 * ((int) this.sinTbl[this.fp_div(this.fp_mul(this.objects_array[index].fp_rangeY, 81), 12868) * 360 >> 11] >> 3);
            this.objects_array[index].fp_y += num8 - this.objects_array[index].fp_offsetY;
            this.objects_array[index].fp_offsetY = num8;
            this.objects_array[index].fp_rangeY += this.fp_mul(122880, fp_time);
            if (this.objects_array[index].fp_rangeY >= 323584)
              this.objects_array[index].fp_rangeY = 0;
          }
          else if (this.objects_array[index].id == 22)
          {
            if (this.objects_array[index].fp_timeUpdate == 0 && this.objects_array[index].fp_y - this.doj_fp_screenYOffset < this.common_fp_configLogicScreenHeight)
            {
              this.objects_array[index].fp_rangeX = this.rand() % 360;
              this.objects_array[index].fp_rangeY = 245760;
              this.objects_array[index].fp_timeUpdate += 204800;
              this.objects_array[index].fp_velY = 221184;
              this.objects_array[index].fp_offsetY = 4;
            }
            else if (this.objects_array[index].fp_y - this.doj_fp_screenYOffset < this.common_fp_configLogicScreenHeight || this.objects_array[index].fp_timeUpdate != 0)
            {
              this.objects_array[index].fp_timeUpdate += fp_time;
              this.objects_array[index].fp_y += this.fp_mul(this.objects_array[index].fp_velY, fp_time);
              int num9 = 5 * ((int) this.sinTbl[this.objects_array[index].fp_rangeX] >> 3);
              this.objects_array[index].fp_x += this.fp_mul((num9 - this.objects_array[index].fp_offsetX) * 60 + this.objects_array[index].fp_rangeY, fp_time);
              this.objects_array[index].fp_rangeX = (this.objects_array[index].fp_rangeX + 8) % 360;
              this.objects_array[index].fp_offsetX = num9;
              int num10 = this.fp_mul(190464, this.common_fp_xRatio) >> 1;
              if (this.objects_array[index].fp_x + num10 > this.common_fp_configLogicScreenWidth)
              {
                this.objects_array[index].fp_x -= this.objects_array[index].fp_x + num10 - this.common_fp_configLogicScreenWidth;
                this.objects_array[index].fp_rangeY = -this.objects_array[index].fp_rangeY;
              }
              else if (this.objects_array[index].fp_x < num10)
              {
                this.objects_array[index].fp_x += num10 - this.objects_array[index].fp_x;
                this.objects_array[index].fp_rangeY = -this.objects_array[index].fp_rangeY;
              }
            }
          }
          else if (this.objects_array[index].id == 26)
          {
            if (this.objects_array[index].fp_timeUpdate == 0)
            {
              this.objects_array[index].fp_timeUpdate += fp_time;
              this.objects_array[index].fp_offsetY = 245760;
              this.objects_array[index].fp_rangeY = this.objects_array[index].fp_y;
              this.objects_array[index].fp_offsetX = 4;
              this.objects_array[index].fp_rangeX = 204800;
            }
            this.objects_array[index].fp_rangeX += fp_time;
            this.objects_array[index].fp_y += this.fp_mul(fp_time, this.objects_array[index].fp_offsetY);
            this.objects_array[index].fp_offsetY -= fp_time * 360;
            if (this.objects_array[index].fp_offsetY < -368640)
              this.objects_array[index].fp_offsetY = -368640;
            if (this.objects_array[index].fp_y < this.objects_array[index].fp_rangeY)
            {
              this.objects_array[index].fp_y = this.objects_array[index].fp_rangeY;
              this.objects_array[index].fp_offsetY = 245760;
            }
          }
        }
      }
    }

    public void objects_drawBackground()
    {
      for (int objectsBegin = this.objects_begin; objectsBegin < this.objects_end + 30; ++objectsBegin)
      {
        int index = this.objects_begin >= this.objects_end ? (objectsBegin < 30 ? objectsBegin : objectsBegin - 30) : objectsBegin;
        if (index == this.objects_end)
          break;
        if (this.objects_array[index].id == 4)
          this.gfx_drawImage(this.themes_getImageId(40), this.doj_worldToScreenX(this.objects_array[index].fp_x), this.doj_worldToScreenY(this.objects_array[index].fp_y - this.doj_fp_screenYOffset), 3, 0);
      }
    }

    public void objects_draw()
    {
      for (int objectsBegin = this.objects_begin; objectsBegin < this.objects_end + 30; ++objectsBegin)
      {
        int index = this.objects_begin >= this.objects_end ? (objectsBegin < 30 ? objectsBegin : objectsBegin - 30) : objectsBegin;
        if (index == this.objects_end)
          break;
        switch (this.objects_array[index].id)
        {
          case 4:
          case 32:
            continue;
          case 5:
            if (this.rand() % 3 == 1)
            {
              int num = 68 - this.themes_getOffset(6);
              this.gfx_drawImage(this.themes_getImageId(47), this.doj_worldToScreenX(this.objects_array[index].fp_x), this.doj_worldToScreenY(this.objects_array[index].fp_y - this.doj_fp_screenYOffset) - num, 3, 0);
              continue;
            }
            int num1 = 68 - this.themes_getOffset(6);
            this.gfx_drawImage(this.themes_getImageId(47), this.doj_worldToScreenX(this.objects_array[index].fp_x), this.doj_worldToScreenY(this.objects_array[index].fp_y - this.doj_fp_screenYOffset) - num1, 3, 0);
            this.gfx_drawImage(this.themes_getImageId(46), this.doj_worldToScreenX(this.objects_array[index].fp_x), this.doj_worldToScreenY(this.objects_array[index].fp_y - this.doj_fp_screenYOffset) + 24, 3, 0);
            continue;
          case 7:
            this.gfx_drawImage(this.themes_getImageId(874), this.doj_worldToScreenX(this.objects_array[index].fp_x), this.doj_worldToScreenY(this.objects_array[index].fp_y - this.doj_fp_screenYOffset), 3, 0);
            continue;
          case 8:
            this.gfx_drawImage(this.themes_getImageId(873), this.doj_worldToScreenX(this.objects_array[index].fp_x), this.doj_worldToScreenY(this.objects_array[index].fp_y - this.doj_fp_screenYOffset), 3, 0);
            continue;
          case 9:
            if (this.objects_array[index].fp_rangeX > 0)
            {
              this.gfx_drawImage(this.themes_getImageId(41), this.doj_worldToScreenX(this.objects_array[index].fp_x), this.doj_worldToScreenY(this.objects_array[index].fp_y - this.doj_fp_screenYOffset), 3, 0);
              continue;
            }
            this.gfx_drawImage(this.themes_getImageId(41), this.doj_worldToScreenX(this.objects_array[index].fp_x), this.doj_worldToScreenY(this.objects_array[index].fp_y - this.doj_fp_screenYOffset), 3, 4);
            continue;
          case 10:
            this.gfx_drawImage(this.themes_getImageId((int) this.objects_monsterBlueWingsAnim[(this.smoothtime >> 5) % this.objects_monsterBlueWingsAnim.Length] + 858), this.doj_worldToScreenX(this.objects_array[index].fp_x), this.doj_worldToScreenY(this.objects_array[index].fp_y - this.doj_fp_screenYOffset), 3, 0);
            continue;
          case 11:
            this.gfx_drawImage(this.themes_getImageId(this.themes_getImageId(863)), this.doj_worldToScreenX(this.objects_array[index].fp_x), this.doj_worldToScreenY(this.objects_array[index].fp_y - this.doj_fp_screenYOffset), 3, 0);
            continue;
          case 22:
            this.gfx_drawImage(this.themes_getImageId((this.smoothtime >> 5) % 4 + 875), this.doj_worldToScreenX(this.objects_array[index].fp_x), this.doj_worldToScreenY(this.objects_array[index].fp_y - this.doj_fp_screenYOffset), 3, 0);
            if (this.objects_array[index].fp_timeUpdate < 204)
            {
              this.gfx_drawImage(this.themes_getImageId(880), this.doj_worldToScreenX(this.objects_array[index].fp_x), this.doj_worldToScreenY(this.objects_array[index].fp_y - this.doj_fp_screenYOffset), 3, 0);
              continue;
            }
            continue;
          case 26:
            if (this.objects_array[index].fp_rangeX < 204)
            {
              this.gfx_drawImage(this.themes_getImageId(882), this.doj_worldToScreenX(this.objects_array[index].fp_x), this.doj_worldToScreenY(this.objects_array[index].fp_y - this.doj_fp_screenYOffset), 33, 0);
              continue;
            }
            this.gfx_drawImage(this.themes_getImageId(881), this.doj_worldToScreenX(this.objects_array[index].fp_x), this.doj_worldToScreenY(this.objects_array[index].fp_y - this.doj_fp_screenYOffset), 33, 0);
            continue;
          case 30:
            this.gfx_drawImage(this.themes_getImageId((this.smoothtime >> 6) % 6 + 866), this.doj_worldToScreenX(this.objects_array[index].fp_x), this.doj_worldToScreenY(this.objects_array[index].fp_y - this.doj_fp_screenYOffset), 3, 0);
            continue;
          case 31:
            this.gfx_drawImage(this.themes_getImageId((this.objects_array[index].fp_timeUpdate >> 6) % -2 + 863), this.doj_worldToScreenX(this.objects_array[index].fp_x), this.doj_worldToScreenY(this.objects_array[index].fp_y - this.doj_fp_screenYOffset), 3, 0);
            continue;
          default:
            this.debug_text((mrGame.MrGame.MrgString) "Unknown object to draw");
            continue;
        }
      }
    }

    public void character_init() => this.character_reset();

    public void character_reset()
    {
      this.character_fp_velX = 0;
      this.character_fp_velY = this.common_fp_configJumpVelY;
      this.character_fp_accX = 0;
      this.character_fp_accY = -this.common_fp_configNormalAccY;
      this.character_fp_posX = this.common_fp_configLogicScreenWidth >> 1;
      this.character_fp_posY = 0;
      this.character_fp_origPosX = this.character_fp_posX;
      this.character_fp_origPosY = this.character_fp_posY;
      this.character_isFacingLeft = true;
      this.doodleHoaxY = -65;
      this.character_state = 0;
      this.character_fp_stateTime = 0;
      this.character_fp_movementDelta = this.character_fp_posX;
      this.powerup_nextPropellerHatHeight = this.rand() % 9000 + 1000;
      this.powerup_nextJetPackHeight = this.rand() % 9500 + 2500;
      this.powerup_nextRocketHeight = this.rand() % 9000 + 3000;
      this.powerup_usedJetPacks = 0;
      this.powerup_springShoesJumpsLeft = 0;
      this.powerup_propellerHatInScene = false;
      this.powerup_jetPackInScene = false;
      this.character_rotationTime = 0;
      this.powerup_rotationTime = 0;
    }

    public void character_free()
    {
    }

    public void character_setMenuMode()
    {
      this.character_reset();
      this.character_fp_accX = 0;
      this.character_fp_velX = 0;
      this.character_fp_posX = this.platforms_array[this.platforms_begin].fp_x;
      this.character_fp_accY = 0;
      this.character_fp_velY = 1105920;
      this.character_fp_posY = -163840;
      this.character_fp_posY = -81920;
      this.character_fp_velY = 3 * this.common_fp_configJumpVelY >> 2;
      this.character_isFacingLeft = false;
    }

    public void character_addState(int state)
    {
      this.character_state |= state;
      this.character_fp_stateTime = 0;
      if ((state & 12288) == 0)
        return;
      this.powerup_fp_shieldTime = 0;
    }

    public void character_removeState(int state) => this.character_state &= ~state;

    public void character_updateState(int fp_dt)
    {
      this.character_rotationTime += fp_dt;
      this.powerup_rotationTime += fp_dt;
      this.character_fp_stateTime += fp_dt;
      if ((this.character_state & 12288) != 0)
        this.powerup_fp_shieldTime += fp_dt;
      if (this.powerup_springShoesJumpsLeft <= 0 && (this.character_state & 131072) != 0 && this.character_fp_velY <= this.common_fp_configShortLegsVelY)
      {
        this.character_fp_stateTime = 0;
        this.character_removeState(131072);
        this.character_state |= 262144;
        this.powerup_rotationTime = 0;
        this.powerup_fallDirectionLeft = this.character_isFacingLeft;
        this.powerup_fp_fallAccY = -this.common_fp_configNormalAccY;
        this.powerup_fp_fallVelY = this.character_fp_velY;
        this.powerup_fp_fallPosY = this.character_fp_posY + this.fp_div(this.themes_getOffset(5) << 11, this.common_fp_yRatio);
        this.powerup_fp_fallAccY = -3686400;
        this.powerup_fp_fallPosX = this.character_fp_posX;
        if (this.powerup_fallDirectionLeft)
        {
          this.powerup_fp_fallPosX -= this.fp_div(45056, this.common_fp_xRatio);
          this.powerup_fp_fallVelX = this.character_fp_velX - 368640;
          this.powerup_fp_fallAccX = 368640;
        }
        else
        {
          this.powerup_fp_fallPosX += this.fp_div(45056, this.common_fp_xRatio);
          this.powerup_fp_fallVelX = this.character_fp_velX + 368640;
          this.powerup_fp_fallAccX = -368640;
        }
        this.achievement_award(0);
      }
      if ((this.character_state & 524288) != 0 && this.character_fp_velY < this.common_fp_configShortLegsVelY)
        this.character_removeState(524288);
      if ((this.character_state & 1048576) != 0)
      {
        if (this.character_fp_stateTime > 10070)
        {
          this.character_fp_stateTime = 0;
          this.character_removeState(1048576);
          this.character_state |= 2097152;
          this.powerup_fallDirectionLeft = this.character_isFacingLeft;
          this.powerup_rotationTime = 0;
          int num1 = 204800;
          if (this.powerup_fallDirectionLeft)
          {
            int num2 = -num1;
          }
          this.powerup_fp_fallVelX = this.character_fp_velX;
          this.powerup_fp_fallAccX = -this.character_fp_velX;
          this.powerup_fp_fallPosX = this.character_fp_posX;
          this.powerup_fp_fallPosY = this.character_fp_posY + this.doj_fp_screenYOffset + 40000;
          this.powerup_fp_fallVelY = this.character_fp_velY + 200000;
          this.powerup_fp_fallAccY = -this.common_fp_configNormalAccY;
          this.character_fp_accY = -this.common_fp_configNormalAccY;
          return;
        }
        if (this.character_fp_stateTime > 8022)
          this.character_fp_accY = -1032192;
        else if (this.character_fp_stateTime > 6281)
          this.character_fp_accY = -1032192;
        else if (this.character_fp_stateTime > 3241)
          this.character_fp_accY = 0;
        else if (this.character_fp_stateTime > 681)
          this.character_fp_accY = 2506752;
      }
      if ((this.character_state & 2097152) == 0)
        return;
      this.powerup_fp_fallVelY += this.fp_mul(this.powerup_fp_fallAccY, fp_dt);
      this.powerup_fp_fallPosY += this.fp_mul(this.powerup_fp_fallVelY, fp_dt);
      this.powerup_fp_fallVelX += this.fp_mul(this.powerup_fp_fallAccX, fp_dt);
      this.powerup_fp_fallPosX += this.fp_mul(this.powerup_fp_fallVelX, fp_dt);
      if (this.powerup_fp_fallPosY - this.doj_fp_screenYOffset >= -this.fp_div(212992, this.common_fp_yRatio))
        return;
      this.character_removeState(2097152);
    }

    public void character_draw()
    {
      this.egfx_push();
      this.egfx_reset();
      if (this.character_fp_velX < 0 && this.character_isFacingLeft)
        this.character_fp_movementDelta = this.character_fp_posX;
      else if (this.character_fp_velX >= 0 && !this.character_isFacingLeft)
        this.character_fp_movementDelta = this.character_fp_posX;
      if (this.character_fp_posX - this.character_fp_movementDelta >= 11000)
        this.character_isFacingLeft = false;
      if (this.character_fp_posX - this.character_fp_movementDelta < -11000 && this.p_inGame)
        this.character_isFacingLeft = true;
      int num1 = 11;
      int y1 = this.doj_worldToScreenY(this.character_fp_posY);
      if (this.character_fp_posY < 0 && (this.character_state & 1024) != 0)
        y1 = -this.character_fp_posY <= this.common_fp_configCharacterYLimit ? this.doj_worldToScreenY(-this.character_fp_posY) : this.doj_worldToScreenY(this.common_fp_configCharacterYLimit);
      int id1 = 42;
      int num2 = 65536;
      int num3 = 0;
      int num4 = 65536;
      int num5 = 65536;
      if ((this.character_state & 16384) != 0)
      {
        num4 = 65536 - this.character_fp_stateTime * 45875 / 819;
        if (num4 < 19661)
          num4 = 19661;
        num5 = 65536 - this.character_fp_stateTime * 29688 / 819;
        if (num5 < 35848)
          num5 = 35848;
      }
      if ((this.character_state & 32768) != 0)
      {
        num4 = 19661;
        num5 = 35848;
      }
      if ((this.character_state & 256) != 0 || (this.character_state & 512) != 0)
      {
        num2 = 65536 - this.character_fp_stateTime * 75;
        if (num2 < 26214)
          num2 = 26214;
        if ((this.character_state & 512) != 0)
          num2 = 26214;
      }
      if ((this.character_state & 524288) != 0)
        num3 = !this.powerup_fallDirectionLeft ? this.character_rotationTime * 58 : -this.character_rotationTime * 58;
      int y2 = y1;
      int num6 = !this.character_isFacingLeft ? num1 - 8 : -(num1 - 6);
      if (this.projectiles_isAnyOnScreen() && this.p_inGame)
        num6 = -6;
      this.egfx_reset();
      this.p_egfx_pixel_scale_f((float) num2 * 1.52587891E-05f);
      if ((this.character_state & 4096) != 0)
        this.gfx_drawImage(this.themes_getImageId(this.rand() % 2 + 845), this.doj_worldToScreenX(this.character_fp_posX) + num6, y1 - 32, 3, 0);
      else if ((this.character_state & 8192) != 0)
      {
        int id2 = this.rand() % 4 + 845;
        if (id2 <= 847)
          this.gfx_drawImage(this.themes_getImageId(id2), this.doj_worldToScreenX(this.character_fp_posX) + num6, y1 - 32, 3, 0);
      }
      int y3 = y1 - this.themes_getOffset(5);
      int x1;
      if (this.projectiles_isAnyOnScreen() && this.p_inGame)
      {
        x1 = this.doj_worldToScreenX(this.character_fp_posX);
        if (this.character_fp_velY > this.common_fp_configShortLegsVelY)
        {
          y1 -= 4;
          this.gfx_drawImage(this.themes_getImageId(775), x1, y1, 33, 0);
        }
        else
          this.gfx_drawImage(this.themes_getImageId(776), x1, y1, 33, 0);
        y2 -= 57;
        if (this.projectiles_count > 0)
        {
          int fpInitVelDiv = this.projectiles_array[this.projectiles_count - 1].fp_initVelDiv;
          int num7 = (8192 * fpInitVelDiv >> 11) * 13 / 10;
          this.egfx_reset();
          this.p_egfx_pixel_rotate_f((float) num7 * 1.52587891E-05f);
          int num8;
          int num9;
          if (this.themes_isTunkOffsetLoaded())
          {
            num8 = (int) this.themes_getTrunkOffsetX(num7 / 182);
            num9 = (int) this.themes_getTrunkOffsetY(num7 / 182);
          }
          else
          {
            int num10 = 22;
            int num11 = num10;
            num8 = this.fp_mul(this.fp_mul(fpInitVelDiv * 13 / 10, this.fp_div(num10 << 11, this.common_fp_xRatio)), this.common_fp_xRatio) >> 11;
            int num12 = this.fp_mul(this.fp_mul(fpInitVelDiv * 10 / 13, this.fp_div(num11 << 11, this.common_fp_yRatio)), this.common_fp_yRatio) >> 11;
            if (num12 > 0)
              num12 = -num12;
            num9 = num12 + 14;
          }
          this.gfx_drawImage(this.themes_getImageId(777), x1 + num8, y2 - num9, 3, 0);
          this.egfx_reset();
        }
        if ((this.character_state & 131072) != 0)
        {
          if (this.character_fp_velY >= this.common_fp_configCharacterSpringVelY - 81920)
            this.gfx_drawImage(this.themes_getImageId(856), x1, y3, 17, 0);
          else if (this.character_fp_velY >= this.common_fp_configCharacterSpringVelY - 163840)
            this.gfx_drawImage(this.themes_getImageId(855), x1, y3, 17, 0);
          else if (this.character_fp_velY >= this.common_fp_configCharacterSpringVelY - 204800)
            this.gfx_drawImage(this.themes_getImageId(854), x1, y3, 17, 0);
          else
            this.gfx_drawImage(this.themes_getImageId(853), x1, y3, 17, 0);
        }
      }
      else
      {
        int trans1 = 0;
        if ((this.character_state & 1048576) != 0)
        {
          if (this.character_isFacingLeft)
            trans1 = 4;
          int num13 = 0;
          int num14 = 0;
          int imageindex;
          if (this.character_fp_stateTime > 6281)
          {
            imageindex = (this.character_fp_stateTime >> 4) % 3 + 1551;
            if (this.rand() % 4 > 2)
            {
              num13 = this.rand() % 5 - 2;
              num14 = this.rand() % 5 - 2;
            }
          }
          else if (this.character_fp_stateTime > 3241)
          {
            imageindex = (this.character_fp_stateTime >> 4) % 3 + 1548;
            num13 = this.rand() % 5 - 2;
            num14 = this.rand() % 5 - 2;
          }
          else
            imageindex = (this.character_fp_stateTime >> 4) % 3 + 1545;
          x1 = this.doj_worldToScreenX(this.character_fp_posX);
          int num15 = 104;
          this.gfx_drawImage(1544, x1 + num13, y1 - num15 + num14, 17, trans1);
          int num16 = 104;
          this.gfx_drawImage(imageindex, x1 + num13, y1 - num15 + num14 + num16, 17, trans1);
        }
        else
        {
          this.doj_worldToScreenX(this.character_fp_posX);
          if (!this.character_isFacingLeft && num3 == 0 || num3 != 0 && !this.powerup_fallDirectionLeft)
            trans1 = 4;
          x1 = this.doj_worldToScreenX(this.character_fp_posX) - num1;
          if (trans1 == 4)
            x1 = this.doj_worldToScreenX(this.character_fp_posX) + num1;
          this.egfx_reset();
          if ((this.character_state & 2097152) != 0)
          {
            int trans2 = 0;
            if (!this.powerup_fallDirectionLeft)
              trans2 = 4;
            this.egfx_reset();
            if (this.powerup_fallDirectionLeft)
              this.p_egfx_pixel_rotate_f((float) (-this.powerup_rotationTime * 6 & (int) ushort.MaxValue) * 1.52587891E-05f);
            else
              this.p_egfx_pixel_rotate_f((float) (this.powerup_rotationTime * 6 & (int) ushort.MaxValue) * 1.52587891E-05f);
            this.gfx_drawImage(1543, this.doj_worldToScreenX(this.powerup_fp_fallPosX), this.doj_worldToScreenY(this.powerup_fp_fallPosY - this.doj_fp_screenYOffset), 3, trans2);
            this.egfx_reset();
          }
          this.egfx_reset();
          this.p_egfx_pixel_scale_f((float) num2 * 1.52587891E-05f);
          this.p_egfx_pixel_stretch_f((float) num4 * 1.52587891E-05f, (float) num5 * 1.52587891E-05f);
          this.p_egfx_pixel_rotate_f((float) num3 * 1.52587891E-05f);
          if ((this.character_state & 16384) != 0)
          {
            this.debug_text((mrGame.MrGame.MrgString) ("*** setting charY=" + (object) this.doodleHoaxY));
            y1 = this.doodleHoaxY;
          }
          if (this.character_fp_velY > this.common_fp_configShortLegsVelY)
          {
            int y4 = y1 - (this.gfx_getImageHeight(this.themes_getImageId(45)) >> 1) - 6;
            this.gfx_drawImage(this.themes_getImageId(45), x1, y4, 3, trans1);
            y1 = y4 + (this.gfx_getImageHeight(this.themes_getImageId(45)) >> 1);
          }
          else
          {
            int y5 = y1 - (this.gfx_getImageHeight(this.themes_getImageId(id1)) >> 1);
            this.gfx_drawImage(this.themes_getImageId(id1), x1, y5, 3, trans1);
            y1 = y5 + (this.gfx_getImageHeight(this.themes_getImageId(id1)) >> 1);
          }
          if ((this.character_state & 131072) != 0)
          {
            int align = 24;
            int x2 = x1 + num1 + this.themes_getOffset(2);
            if (this.character_isFacingLeft)
            {
              align = 20;
              x2 = x1 - num1 - this.themes_getOffset(2);
            }
            if (this.character_fp_velY >= this.common_fp_configCharacterSpringVelY - 81920)
              this.gfx_drawImage(this.themes_getImageId(851), x2, y3, align, trans1);
            else if (this.character_fp_velY >= this.common_fp_configCharacterSpringVelY - 163840)
              this.gfx_drawImage(this.themes_getImageId(850), x2, y3, align, trans1);
            else if (this.character_fp_velY >= this.common_fp_configCharacterSpringVelY - 204800)
              this.gfx_drawImage(this.themes_getImageId(849), x2, y3, align, trans1);
            else
              this.gfx_drawImage(this.themes_getImageId(848), x2, y3, align, trans1);
          }
          y2 -= 65;
        }
      }
      if ((this.character_state & 2048) != 0)
      {
        int id3 = (this.smoothtime >> 6) % 2 + 778;
        int num17 = -num1;
        int trans = 4;
        if (this.character_isFacingLeft)
        {
          num17 = num1;
          trans = 0;
        }
        this.gfx_drawImage(this.themes_getImageId(id3), x1 + num17, y2, 3, trans);
      }
      if ((this.character_state & 7) != 0)
      {
        int num18 = x1;
        int trans = 4;
        int x3;
        if (this.character_isFacingLeft)
        {
          x3 = num18 + (32 + num1 + this.themes_getOffset(1));
          trans = 0;
        }
        else
          x3 = num18 - (32 + num1 + this.themes_getOffset(1));
        int y6 = this.doj_worldToScreenY(this.character_fp_posY) + 8 - 65;
        this.gfx_drawImage(this.themes_getImageId((this.character_state & 1) != 1 || this.character_fp_stateTime <= 61 ? ((this.character_state & 4) != 4 || this.character_fp_stateTime <= 102 ? this.smoothtime % 3 + 834 : this.smoothtime % 3 + 837) : this.smoothtime % 3 + 831), x3, y6, 17, trans);
      }
      if ((this.character_state & 8) != 0)
      {
        int id4 = 839;
        if (this.powerup_fallDirectionLeft)
        {
          this.egfx_reset();
          this.p_egfx_pixel_rotate_f((float) (this.powerup_rotationTime * 10 & (int) ushort.MaxValue) * 1.52587891E-05f);
          if (65536 - this.character_fp_stateTime * 15 < 0)
            ;
          this.gfx_drawImage(this.themes_getImageId(id4), this.doj_worldToScreenX(this.powerup_fp_fallPosX), this.doj_worldToScreenY(this.powerup_fp_fallPosY), 17, 0);
        }
        else
        {
          this.egfx_reset();
          this.p_egfx_pixel_rotate_f((float) ((int) ushort.MaxValue - (this.powerup_rotationTime * 10 & (int) ushort.MaxValue)) * 1.52587891E-05f);
          if (65536 - this.character_fp_stateTime * 15 < 0)
            ;
          this.gfx_drawImage(this.themes_getImageId(id4), this.doj_worldToScreenX(this.powerup_fp_fallPosX), this.doj_worldToScreenY(this.powerup_fp_fallPosY), 17, 4);
        }
      }
      if ((this.character_state & 112) != 0)
      {
        int y7 = y2 - this.themes_getOffset(4);
        int num19 = x1;
        int trans = 4;
        int x4;
        if (this.character_isFacingLeft)
        {
          x4 = num19 + (num1 + this.themes_getOffset(3));
          trans = 0;
        }
        else
          x4 = num19 - (num1 + this.themes_getOffset(3));
        this.gfx_drawImage(this.themes_getImageId(this.smoothtime % 3 + 841), x4, y7, 33, trans);
      }
      if ((this.character_state & 128) != 0)
      {
        this.egfx_reset();
        if (this.powerup_fallDirectionLeft)
          this.p_egfx_pixel_rotate_f((float) (-this.powerup_rotationTime * 16 & (int) ushort.MaxValue) * 1.52587891E-05f);
        else
          this.p_egfx_pixel_rotate_f((float) (this.powerup_rotationTime * 16 & (int) ushort.MaxValue) * 1.52587891E-05f);
        if (65536 - this.character_fp_stateTime * 18 < 0)
          ;
        this.gfx_drawImage(this.themes_getImageId(840), this.doj_worldToScreenX(this.powerup_fp_fallPosX), this.doj_worldToScreenY(this.powerup_fp_fallPosY), 33, 0);
      }
      if ((this.character_state & 262144) != 0)
      {
        int align = 24;
        int trans = 4;
        if (this.powerup_fallDirectionLeft)
        {
          trans = 0;
          align = 4;
        }
        this.egfx_reset();
        if (this.powerup_fallDirectionLeft)
          this.p_egfx_pixel_rotate_f((float) (-this.powerup_rotationTime * 5 & (int) ushort.MaxValue) * 1.52587891E-05f);
        else
          this.p_egfx_pixel_rotate_f((float) (this.powerup_rotationTime * 5 & (int) ushort.MaxValue) * 1.52587891E-05f);
        if (65536 - this.character_fp_stateTime * 6 < 0)
          ;
        this.gfx_drawImage(this.themes_getImageId(848), this.doj_worldToScreenX(this.powerup_fp_fallPosX), this.doj_worldToScreenY(this.powerup_fp_fallPosY), align, trans);
      }
      this.egfx_pop();
      if (this.themes_current != 2 || this.doj_gameOver || !this.p_inGame || this.doj_loading)
        return;
      int screenX = this.doj_worldToScreenX(this.character_fp_posX);
      int y8 = y1 - 21;
      this.gfx_drawImage(1421, screenX, y8, 40, 0);
      this.gfx_drawImage(1421, screenX, y8, 24, 5);
      this.gfx_drawImage(1421, screenX, y8, 36, 4);
      this.gfx_drawImage(1421, screenX, y8, 20, 2);
      int y0 = this.gfx_getImageHeight(this.themes_getImageId(4)) * 10 / 15;
      for (int x5 = screenX - 235; x5 > 0; x5 -= (int) sbyte.MaxValue)
      {
        for (int y9 = y0; y9 < this.dynamic_Y_RES; y9 += (int) sbyte.MaxValue)
          this.gfx_drawImage(1422, x5, y9, 24, 0);
      }
      for (int x6 = screenX + 235; x6 < this.dynamic_X_RES; x6 += (int) sbyte.MaxValue)
      {
        for (int y10 = y0; y10 < this.dynamic_Y_RES; y10 += (int) sbyte.MaxValue)
          this.gfx_drawImage(1422, x6, y10, 20, 0);
      }
      int clipX = this.gfx_getClipX();
      int clipY = this.gfx_getClipY();
      int clipW = this.gfx_getClipW();
      int clipH = this.gfx_getClipH();
      this.gfx_setClip(screenX - 235, y0, 470, y8 - 235 - y0);
      for (int x7 = screenX - 235; x7 < screenX + 235; x7 += (int) sbyte.MaxValue)
      {
        for (int y11 = y0; y11 < y8 - 235; y11 += (int) sbyte.MaxValue)
          this.gfx_drawImage(1422, x7, y11, 20, 0);
      }
      this.gfx_setClip(screenX - 235, y8 + 235, 470, this.dynamic_Y_RES - y8 - 235);
      for (int x8 = screenX - 235; x8 < screenX + 235; x8 += (int) sbyte.MaxValue)
      {
        for (int y12 = y8 + 235; y12 < this.dynamic_Y_RES; y12 += (int) sbyte.MaxValue)
          this.gfx_drawImage(1422, x8, y12, 20, 0);
      }
      this.gfx_setClip(clipX, clipY, clipW, clipH);
    }

    public void character_fire(bool fireFromTouch)
    {
      if ((this.character_state & 1658231) != 0)
        return;
      int fp_vel_x = 0;
      int pOption = (int) this.p_options[5];
      bool shootingMonster = false;
      switch (pOption)
      {
        case 0:
          if (this.objects_begin != this.objects_end)
          {
            int num1 = 0;
            int num2 = 0;
            for (int objectsBegin = this.objects_begin; objectsBegin < this.objects_end + 30; ++objectsBegin)
            {
              int index = this.objects_begin >= this.objects_end ? (objectsBegin < 30 ? objectsBegin : objectsBegin - 30) : objectsBegin;
              if (index != this.objects_end)
              {
                if (this.objects_array[index].id != 4 && this.objects_array[index].id != 32 && this.objects_array[index].fp_y - this.doj_fp_screenYOffset > this.character_fp_posY && this.objects_array[index].fp_y - this.doj_fp_screenYOffset < this.common_fp_configLogicScreenHeight)
                {
                  num1 = this.objects_array[index].fp_x;
                  num2 = this.objects_array[index].fp_y - this.doj_fp_screenYOffset;
                  if (this.objects_array[index].id == 5)
                    num2 += this.fp_div(189440, this.common_fp_yRatio);
                  if (num2 < this.character_fp_posY)
                  {
                    num1 = 0;
                    num2 = 0;
                  }
                  else
                  {
                    shootingMonster = true;
                    break;
                  }
                }
              }
              else
                break;
            }
            if (shootingMonster)
              fp_vel_x = (num1 - this.character_fp_posX) * (2457600 / (num2 - this.character_fp_posY - this.character_fp_height));
          }
          if (fp_vel_x == 0)
          {
            int num = this.rand() % 20 - 10;
            while (num == 0 || num == 1 || num == -1)
              num = this.rand() % 20 - 10;
            fp_vel_x = 2457600 / num;
            break;
          }
          break;
        case 1:
          fp_vel_x = 0;
          break;
        default:
          fp_vel_x = 0;
          if (fireFromTouch)
          {
            fp_vel_x = this.fp_mul(2457600, (this.p_touchdata[this.p_mt_last].upx - (this.dynamic_X_RES >> 1) << 11) / (this.dynamic_X_RES >> 1));
            break;
          }
          break;
      }
      this.projectiles_add(this.character_fp_posX, this.character_fp_posY + this.character_fp_height, fp_vel_x, shootingMonster);
      if (this.themes_current == 1 || this.themes_current == 3)
      {
        if (this.rand() % 2 == 0)
          this.p_playSound(26, 128, 1);
        else
          this.p_playSound(27, 128, 1);
      }
      else if (this.rand() % 2 == 0)
        this.p_playSound(14, 128, 1);
      else
        this.p_playSound(15, 128, 1);
    }

    public bool character_endingPowerup()
    {
      return (this.character_state & 32) != 0 && this.character_fp_stateTime > 2901 || (this.character_state & 4) != 0 && this.character_fp_stateTime > 1792 || (this.character_state & 1048576) != 0 && this.character_fp_stateTime > 5652;
    }

    public bool character_abortScenario()
    {
      return (this.character_state & 3145927) != 0 || (this.character_state & 32) != 0 && this.character_fp_stateTime > 1536;
    }

    public void platforms_init()
    {
      this.platforms_array = new mrGame.MrGame.Platform[120];
      for (int index = 0; index < 120; ++index)
        this.platforms_array[index] = new mrGame.MrGame.Platform();
      this.platforms_reset();
      this.platforms_scenes = (short[]) null;
    }

    public void platforms_reset()
    {
      this.platforms_begin = 0;
      this.platforms_end = 0;
      this.themes_scenesReset();
      this.platforms_scenarioAborted = false;
    }

    public void platforms_free()
    {
      for (int index = 0; index < 120; ++index)
        this.platforms_array[index] = (mrGame.MrGame.Platform) null;
      this.platforms_array = (mrGame.MrGame.Platform[]) null;
      this.platforms_scenes = (short[]) null;
      this.platforms_scenes = (short[]) null;
      this.platforms_scenesIndexes = (short[]) null;
      this.platforms_scenesIndexes = (short[]) null;
    }

    public void platforms_scenesLoad()
    {
      short index1 = 72;
      this.platforms_scenesIndexes = new short[(int) index1 + 1];
      short length1 = 0;
      for (short index2 = 0; (int) index2 < (int) index1; ++index2)
      {
        short[] fileShort = this.p_getFile_short(this.p_indexTable3[113 + ((int) index2 + 2) * 3], this.p_indexTable3[113 + (((int) index2 + 2) * 3 + 1)], this.p_indexTable3[113 + (((int) index2 + 2) * 3 + 2)], (short[]) null);
        this.platforms_scenesIndexes[(int) index2] = length1;
        length1 += (short) fileShort.Length;
      }
      this.platforms_scenesIndexes[(int) index1] = length1;
      this.platforms_scenes = new short[(int) length1];
      for (short index3 = 0; (int) index3 < (int) index1; ++index3)
      {
        short[] fileShort = this.p_getFile_short(this.p_indexTable3[113 + ((int) index3 + 2) * 3], this.p_indexTable3[113 + (((int) index3 + 2) * 3 + 1)], this.p_indexTable3[113 + (((int) index3 + 2) * 3 + 2)], (short[]) null);
        int length2 = fileShort.Length;
        Array.Copy((Array) fileShort, 0, (Array) this.platforms_scenes, (int) this.platforms_scenesIndexes[(int) index3], length2);
      }
      this.themes_scenesLoad();
    }

    public void platforms_scenesUnload()
    {
      this.platforms_scenes = (short[]) null;
      this.platforms_scenes = (short[]) null;
      this.platforms_scenesIndexes = (short[]) null;
      this.platforms_scenesIndexes = (short[]) null;
      this.themes_scenesUnload();
    }

    public void platforms_pushMenuPlatform() => this.platforms_push(122880, 166 << 11, 1, 0, 0);

    public void platforms_push(int wx, int wy, int id, int speed, int offset)
    {
      int num = this.fp_div(this.fp_mul(wy, this.common_fp_yRatio) >> 11 << 11, this.common_fp_yRatio);
      this.platforms_array[this.platforms_end].fp_x = wx;
      this.platforms_array[this.platforms_end].fp_y = num;
      this.platforms_array[this.platforms_end].id = id;
      this.platforms_array[this.platforms_end].updateTime = 0;
      this.platforms_array[this.platforms_end].speed = speed;
      this.platforms_array[this.platforms_end].objOffset = offset;
      ++this.platforms_end;
      while (this.platforms_end >= 120)
        this.platforms_end -= 120;
    }

    public void platforms_generate()
    {
      if (this.character_abortScenario() && !this.platforms_scenarioAborted)
      {
        this.platforms_scenarioAborted = true;
        int num = 0;
        for (int index1 = (this.platforms_end - 1 + 120) % 120; index1 >= this.platforms_begin - 120; --index1)
        {
          int index2 = this.platforms_begin >= this.platforms_end ? (index1 < 0 ? index1 + 120 : index1) : index1;
          if (index2 != this.platforms_begin - 1 && index2 != 120)
          {
            if (this.platforms_array[index2].fp_y - this.doj_fp_screenYOffset <= this.common_fp_configLogicScreenHeight)
            {
              if (this.platforms_end != (index2 + 1 + 120) % 120)
              {
                this.platforms_end = (index2 + 1 + 120) % 120;
                num = this.platforms_array[index2].fp_y;
                break;
              }
              break;
            }
          }
          else
            break;
        }
        if (num != 0)
        {
          for (int index3 = (this.objects_end - 1 + 30) % 30; index3 >= this.objects_begin - 30; --index3)
          {
            int index4 = this.objects_begin >= this.objects_end ? (index3 < 0 ? index3 + 30 : index3) : index3;
            if (index4 != this.objects_begin - 1 && index4 != 30)
            {
              if (this.objects_array[index4].fp_y - this.doj_fp_screenYOffset > this.common_fp_configLogicScreenHeight)
                this.objects_array[index4].id = 32;
            }
            else
              break;
          }
        }
      }
      int index = this.platforms_end - 1;
      if (index < 0)
        index += 120;
      int wy = this.platforms_array[index].fp_y;
      if (this.platforms_end == this.platforms_begin)
      {
        wy = 61440;
        this.platforms_push(327680, wy, 1, 0, 0);
      }
      if (wy > 6144000 && wy - this.doj_fp_screenYOffset < this.common_fp_configLogicScreenHeight && this.rand() % 20 == 10 && (this.character_state & 1048583) == 0 && (!this.character_abortScenario() || !this.platforms_scenarioAborted))
        this.platforms_generatePredefined();
      this.platforms_generateRandom(true, this.common_fp_configLogicScreenHeight - wy + this.doj_fp_screenYOffset);
    }

    public void platforms_generateRandom(bool allowSprings, int rangeHeight)
    {
      if (rangeHeight < 0)
        return;
      int index1 = this.platforms_end - 1;
      if (index1 < 0)
        index1 += 120;
      int num1 = this.platforms_array[index1].fp_y;
      int num2 = this.platforms_array[index1].id;
      if (this.platforms_end == this.platforms_begin)
      {
        num1 = 0;
        num2 = 1;
      }
      int id;
      for (int index2 = num1; num1 - index2 < rangeHeight || (num2 & 1006632960) != 0 || num1 - this.doj_fp_screenYOffset < this.common_fp_configLogicScreenHeight; num2 = id)
      {
        int num3 = num1 >> 11;
        id = 1;
        int speed = 0;
        int offset = 0;
        if (this.rand() % 5 == 0 && (num2 & 1006632960) == 0)
          id = 67108864;
        bool flag = false;
        if (num3 > 5500 && this.rand() % 100 < num3 / 400)
          flag = true;
        if (flag)
        {
          int fp_b = this.fp_div(this.dynamic_X_RES - (this.doj_screen_fp_posX >> 11 << 1) << 11, this.common_fp_configLogicScreenWidth);
          int fp_a = 60 * (1024 + this.rand() % 10 * 102 + this.fp_div(this.doj_fp_screenYOffset, 61440000));
          if (fp_a > 307200)
            fp_a = 307200;
          speed = this.fp_mul(fp_a, fp_b);
          id |= 4;
        }
        int wx = (this.platforms_fp_wWidth >> 1) + this.rand() % (this.common_fp_configLogicScreenWidth - this.platforms_fp_wWidth);
        int num4 = 25 + this.rand() % ((150 + num3) / 150);
        if (num4 > 90)
          num4 = 90;
        if ((num2 & 1006632960) != 0 && num4 > 50)
          num4 = 50;
        if ((num2 & 7340088) != 0 && (num2 & 1006632960) == 0)
        {
          int num5 = num4 + 15;
          int num6 = 30 + this.rand() % ((50 + num3) / 50);
          if ((num2 & 16) != 0)
            num6 += 10;
          if (num6 > 70)
            num6 = 70;
          if ((num2 & 4194304) != 0)
            num6 += 104;
          num4 = num5 + num6;
        }
        if (this.character_endingPowerup())
          num4 >>= 1;
        if (num4 < this.platforms_minDistance && (num2 & 1006632960) == 0)
          num4 = this.platforms_minDistance;
        int num7 = (num1 >> 11) + num4;
        int wy = num7 << 11;
        if ((id & 1006632960) == 0)
        {
          int num8 = this.fp_div(49152, this.common_fp_xRatio);
          if (this.themes_current == 4 && this.powerup_usedJetPacks < 3 && this.powerup_nextRocketHeight < num3 && !this.doj_classicMode && this.powerup_nextRocketHeight != 0 && this.rand() % 10 == 1 && (this.character_state & 119) == 0 && (id & 4) == 0)
          {
            id |= 4194304;
            this.powerup_nextRocketHeight = 0;
            ++this.powerup_usedJetPacks;
            int num9 = 3 * this.platforms_fp_wWidth >> 1;
            if (wx < num9)
              wx = num9;
            else if (wx > this.common_fp_configLogicScreenWidth - num9)
              wx = this.common_fp_configLogicScreenWidth - num9;
          }
          else if (this.powerup_usedJetPacks < 3 && this.powerup_nextJetPackHeight < num3 && !this.doj_classicMode && (this.character_state & 1048695) == 0)
          {
            this.debug_text((mrGame.MrGame.MrgString) ("added jet pack: " + (object) num3));
            id |= 16;
            ++this.powerup_usedJetPacks;
            this.powerup_jetPackInScene = true;
            this.powerup_nextJetPackHeight = this.rand() % 10000 + 10000 + this.powerup_nextJetPackHeight;
            int num10 = this.platforms_fp_wWidth - this.fp_div(65536, this.common_fp_xRatio) - num8;
            offset = this.rand() % num10 - (num10 >> 1);
          }
          else if (this.powerup_nextPropellerHatHeight < num3 && !this.doj_classicMode && this.themes_allowPropellerHat)
          {
            if ((this.character_state & 1048695) != 0)
            {
              this.powerup_nextPropellerHatHeight = this.rand() % 10000 + 10000 + this.powerup_nextPropellerHatHeight;
            }
            else
            {
              this.debug_text((mrGame.MrGame.MrgString) ("added propeller hat: " + (object) num3));
              id |= 32;
              this.powerup_propellerHatInScene = true;
              this.powerup_nextPropellerHatHeight = this.rand() % 10000 + 10000 + this.powerup_nextPropellerHatHeight;
              int num11 = this.platforms_fp_wWidth - this.fp_div(92160, this.common_fp_xRatio) - num8;
              offset = this.rand() % num11 - (num11 >> 1);
            }
          }
          else if (this.rand() % 100 > 90 && allowSprings)
          {
            if (this.rand() % 5 == 1 && !this.doj_classicMode)
            {
              id |= 2097152;
              if (this.powerup_nextPropellerHatHeight - num7 < 556)
                this.powerup_nextPropellerHatHeight += 556;
              if (this.powerup_nextJetPackHeight - num7 < 556)
                this.powerup_nextJetPackHeight += 556;
              if (this.powerup_nextRocketHeight - num7 < 556 && this.powerup_nextRocketHeight != 0)
                this.powerup_nextRocketHeight += 556;
            }
            else
            {
              id |= 8;
              int num12 = this.platforms_fp_wWidth - num8 - num8;
              offset = this.rand() % num12 - (num12 >> 1);
            }
          }
        }
        this.platforms_push(wx, wy, id, speed, offset);
        num1 = wy;
      }
    }

    public void platforms_generatePredefined()
    {
      this.debug_text((mrGame.MrGame.MrgString) " ------------------------------------- PREDEFINEEEEEED ----------------------------");
      if (this.platforms_scenesIndexes == null || this.platforms_scenes == null)
        return;
      this.platforms_scenarioAborted = false;
      int index1 = (this.platforms_end - 1 + 120) % 120;
      int objectsEnd = this.objects_end;
      int platformsEnd = this.platforms_end;
      int fpY1 = this.platforms_array[index1].fp_y;
      int num1 = 0;
      for (int index2 = (this.platforms_end - 1 + 120) % 120; index2 >= this.platforms_begin - 120; --index2)
      {
        int index3 = this.platforms_begin >= this.platforms_end ? (index2 < 0 ? index2 + 120 : index2) : index2;
        if (index3 != this.platforms_begin - 1 && index3 != 120)
        {
          if ((this.platforms_array[index3].id & 2097160) != 0)
          {
            num1 = this.platforms_array[index3].fp_y;
            break;
          }
        }
        else
          break;
      }
      if (num1 != 0 && fpY1 - num1 < 1138688)
        this.platforms_generateRandom(false, fpY1 - num1 + 1138688);
      int index4 = this.platforms_end - 1;
      if (index4 < 0)
        index4 += 120;
      int num2 = this.platforms_array[index4].fp_y;
      int num3 = this.platforms_array[index4].id;
      if (this.platforms_end == this.platforms_begin)
      {
        num2 = 0;
        num3 = 1;
      }
      int num4 = (this.platforms_end - 1 + 120) % 120;
      bool flag = false;
      short index5 = num2 >= 30720000 ? this.themes_scenesGetNextHard() : this.themes_scenesGetNextEasy();
      this.debug_text((mrGame.MrGame.MrgString) ("SCENE: " + (object) index5));
      short platformsScenesIndex1 = this.platforms_scenesIndexes[(int) index5];
      short platformsScenesIndex2 = this.platforms_scenesIndexes[(int) index5 + 1];
      int num5 = this.objects_end % 30;
      for (int index6 = (int) platformsScenesIndex1; index6 < (int) platformsScenesIndex2; index6 += 3)
      {
        int wx = (int) this.platforms_scenes[index6 + 1] << 11;
        int platformsScene = (int) this.platforms_scenes[index6 + 2];
        if (index6 == (int) platformsScenesIndex1 && platformsScene < this.platforms_minDistance && (num3 & 1006632960) == 0)
          num2 += this.platforms_minDistance - platformsScene << 11;
        int wy = num2 + (platformsScene << 11);
        int id = (int) this.platforms_scenes[index6];
        int offset1 = this.rand() % (this.platforms_fp_wWidth - 49152) - (this.platforms_fp_wWidth - 49152 >> 1);
        int fp_b = this.fp_div(this.dynamic_X_RES - (this.doj_screen_fp_posX >> 11 << 1) << 11, this.common_fp_configLogicScreenWidth);
        int fp_a = 60 * (1024 + this.rand() % 10 * 102 + this.fp_div(this.doj_fp_screenYOffset, 61440000));
        if (fp_a > 307200)
          fp_a = 307200;
        int speed = this.fp_mul(fp_a, fp_b);
        switch (id)
        {
          case 0:
            this.platforms_push(wx, wy, 1, 0, 0);
            break;
          case 1:
            this.platforms_push(wx, wy, 5, speed, 0);
            break;
          case 2:
            this.platforms_push(wx, wy, 67108864, 0, 0);
            break;
          case 3:
            this.platforms_push(wx, wy, 2, 0, 0);
            break;
          case 4:
            this.objects_push(wx, wy, 4);
            break;
          case 6:
            this.platforms_push(wx, wy, 9, 0, offset1);
            break;
          case 12:
            this.platforms_push(wx, wy, 65536, 0, 0);
            break;
          case 13:
            this.platforms_push(wx, wy, 131072, 0, 409600);
            break;
          case 14:
            this.platforms_push(wx, wy, 262144, 0, 0);
            break;
          case 15:
            this.platforms_push(wx, wy, 524288, 0, 266240);
            break;
          case 16:
            this.platforms_push(wx, wy, 256, 0, 0);
            break;
          case 17:
            int offset2 = this.rand() % 2000 + 1000;
            this.platforms_push(wx, wy, 256, 0, offset2);
            break;
          case 23:
            this.platforms_push(wx, wy, 1048577, 0, 0);
            break;
          default:
            if (id == 25)
              id = 26;
            if (id == 5 || id >= 7 && id <= 11 || id == 22 || id == 26)
            {
              if (id == 26)
              {
                int fpY2 = this.platforms_array[(this.platforms_end - 1 + 120) % 120].fp_y;
                this.objects_push(wx, fpY2, id);
              }
              else
                this.objects_push(wx, wy, id);
              flag = true;
              break;
            }
            this.objects_end = objectsEnd;
            this.platforms_end = platformsEnd;
            this.platforms_generatePredefined();
            this.debug_text((mrGame.MrGame.MrgString) ("Unknown object/platform type in predefined scene. Id: " + (object) id));
            return;
        }
      }
      if (this.themes_allowShield && flag && !this.doj_classicMode && this.rand() % 8 > 2 && index1 != num4)
      {
        this.platforms_cleanup();
        int index7 = (this.rand() % ((num4 - index1) % 120) + index1) % 120;
        while ((this.platforms_array[index7].id & 1) == 0 || (this.platforms_array[index7].id & 7340088) != 0)
          index7 = (this.rand() % ((num4 - index1) % 120) + index1) % 120;
        this.platforms_array[index7].id |= 128;
        int index8 = (index7 + 1) % 120;
        int num6 = this.fp_div(100352, this.common_fp_yRatio);
        if (index8 != this.platforms_end && this.platforms_array[index8].fp_y - this.platforms_array[index7].fp_y <= num6)
        {
          for (int index9 = index8; index9 < this.platforms_end + 120; ++index9)
          {
            int index10 = index8 >= this.platforms_end ? (index9 < 120 ? index9 : index9 - 120) : index9;
            if (index10 != this.platforms_end)
              this.platforms_array[index10].fp_y += num6;
            else
              break;
          }
          for (int index11 = num5; index11 < this.objects_end + 30; ++index11)
          {
            int index12 = num5 >= this.objects_end ? (index11 < 30 ? index11 : index11 - 30) : index11;
            if (index12 != this.objects_end)
              this.objects_array[index12].fp_y += num6;
            else
              break;
          }
        }
      }
      int index13 = (this.platforms_end - 1 + 120) % 120;
      int fpY3 = this.platforms_array[index13].fp_y;
      int id1 = this.platforms_array[index13].id;
    }

    public void platforms_cleanup()
    {
      while (this.platforms_begin != this.platforms_end && this.platforms_array[this.platforms_begin].fp_y - this.doj_fp_screenYOffset < -this.common_fp_configLogicScreenHeight)
      {
        if ((this.platforms_array[this.platforms_begin].id & 32) != 0)
          this.powerup_propellerHatInScene = false;
        if ((this.platforms_array[this.platforms_begin].id & 16) != 0)
        {
          this.powerup_jetPackInScene = false;
          this.achievement_add(11);
        }
        ++this.platforms_begin;
        if (this.platforms_begin >= 120)
          this.platforms_begin -= 120;
      }
      while (this.objects_begin != this.objects_end && this.objects_array[this.objects_begin].fp_y - this.doj_fp_screenYOffset < -this.common_fp_configLogicScreenHeight)
      {
        ++this.objects_begin;
        if (this.objects_begin >= 30)
          this.objects_begin -= 30;
      }
    }

    public void platforms_cleanup_invisible()
    {
      while (this.platforms_begin != this.platforms_end && this.platforms_array[this.platforms_begin].fp_y - this.doj_fp_screenYOffset < 0)
      {
        if ((this.platforms_array[this.platforms_begin].id & 32) != 0)
          this.powerup_propellerHatInScene = false;
        if ((this.platforms_array[this.platforms_begin].id & 16) != 0)
          this.powerup_jetPackInScene = false;
        ++this.platforms_begin;
        if (this.platforms_begin >= 120)
          this.platforms_begin -= 120;
      }
      while (this.objects_begin != this.objects_end && this.objects_array[this.objects_begin].fp_y - this.doj_fp_screenYOffset < -this.common_fp_configLogicScreenHeight)
      {
        ++this.objects_begin;
        if (this.objects_begin >= 30)
          this.objects_begin -= 30;
      }
    }

    public void platforms_update(int fp_dt)
    {
      for (int platformsBegin = this.platforms_begin; platformsBegin < this.platforms_end + 120; ++platformsBegin)
      {
        int index = this.platforms_begin >= this.platforms_end ? (platformsBegin < 120 ? platformsBegin : platformsBegin - 120) : platformsBegin;
        if (index == this.platforms_end)
          break;
        if ((this.platforms_array[index].id & int.MinValue) == int.MinValue)
        {
          if (this.smoothtime - this.platforms_array[index].updateTime > 166)
          {
            this.debug_text((mrGame.MrGame.MrgString) ("ddaaa = " + (object) (this.smoothtime - this.platforms_array[index].updateTime)));
            this.platforms_array[index].id = 1073741824;
          }
        }
        else if (this.platforms_array[index].id >= 134217728 && this.platforms_array[index].id < 536870912 && this.smoothtime - this.platforms_array[index].updateTime > 34)
        {
          for (; this.smoothtime - this.platforms_array[index].updateTime > 34 && this.platforms_array[index].id < 536870912; this.platforms_array[index].updateTime += 34)
          {
            int num = this.platforms_array[index].id & 4;
            this.platforms_array[index].id = (this.platforms_array[index].id & -5) << 1 | num;
          }
        }
        else if ((this.platforms_array[index].id & 536870912) == 536870912)
        {
          int num = this.fp_mul(this.common_fp_configBrownPlatformFallVelY, fp_dt);
          this.platforms_array[index].fp_y -= num;
          this.platforms_array[index].objOffset += num;
          if (this.platforms_array[index].objOffset > this.dynamic_Y_RES * 3 << 11)
            this.platforms_array[index].id = 1073741824;
        }
        if ((this.platforms_array[index].id & 4) == 4)
        {
          this.platforms_array[index].fp_x += this.fp_div(this.fp_mul(this.platforms_array[index].speed, fp_dt), this.common_fp_xRatio);
          if (this.platforms_array[index].fp_x - (this.platforms_fp_wWidth >> 1) < 0)
            this.platforms_array[index].speed = -this.platforms_array[index].speed > this.platforms_array[index].speed ? -this.platforms_array[index].speed : this.platforms_array[index].speed;
          else if (this.platforms_array[index].fp_x + (this.platforms_fp_wWidth >> 1) > this.common_fp_configLogicScreenWidth)
            this.platforms_array[index].speed = -this.platforms_array[index].speed < this.platforms_array[index].speed ? -this.platforms_array[index].speed : this.platforms_array[index].speed;
        }
        if ((this.platforms_array[index].id & 256) == 256)
        {
          if (this.platforms_array[index].objOffset == 0 && this.platforms_array[index].fp_y < this.doj_fp_screenYOffset + 307200)
          {
            this.platforms_array[index].id = 512;
            this.platforms_array[index].updateTime = this.smoothtime;
          }
          else if (this.platforms_array[index].updateTime == 0 && this.platforms_array[index].objOffset > 0 && this.platforms_array[index].fp_y - this.doj_fp_screenYOffset < this.common_fp_configLogicScreenHeight)
            this.platforms_array[index].updateTime = this.smoothtime;
          else if (this.platforms_array[index].updateTime > 0 && this.platforms_array[index].objOffset > 0 && this.smoothtime - this.platforms_array[index].updateTime > this.platforms_array[index].objOffset)
          {
            this.platforms_array[index].id = 512;
            this.platforms_array[index].updateTime = this.smoothtime;
          }
        }
        else if ((this.platforms_array[index].id & 512) == 512)
        {
          if (this.smoothtime - this.platforms_array[index].updateTime > 120)
          {
            this.platforms_array[index].id = 1024;
            this.platforms_array[index].updateTime = this.smoothtime;
          }
        }
        else if ((this.platforms_array[index].id & 1024) == 1024)
        {
          if (this.smoothtime - this.platforms_array[index].updateTime > 120)
          {
            this.platforms_array[index].id = 2048;
            this.platforms_array[index].updateTime = this.smoothtime;
          }
        }
        else if ((this.platforms_array[index].id & 2048) == 2048)
        {
          if (this.smoothtime - this.platforms_array[index].updateTime > 120)
          {
            this.platforms_array[index].id = 4096;
            this.platforms_array[index].updateTime = this.smoothtime;
          }
        }
        else if ((this.platforms_array[index].id & 4096) == 4096)
        {
          if (this.smoothtime - this.platforms_array[index].updateTime > 380)
          {
            this.platforms_array[index].id = 8192;
            this.platforms_array[index].updateTime = this.smoothtime;
            this.platforms_array[index].objOffset = this.smoothtime;
            if (this.rand() % 2 == 1)
              this.p_playSound(22, 128, 1);
            else
              this.p_playSound(21, 128, 1);
          }
        }
        else if ((this.platforms_array[index].id & 8192) == 8192)
        {
          if (this.smoothtime - this.platforms_array[index].updateTime > 55)
          {
            this.platforms_array[index].id = 16384;
            this.platforms_array[index].updateTime = this.smoothtime;
          }
        }
        else if ((this.platforms_array[index].id & 16384) == 16384)
        {
          if (this.smoothtime - this.platforms_array[index].updateTime > 55)
          {
            this.platforms_array[index].id = 32768;
            this.platforms_array[index].updateTime = this.smoothtime;
          }
        }
        else if ((this.platforms_array[index].id & 32768) == 32768)
        {
          if (this.smoothtime - this.platforms_array[index].updateTime > 222)
            this.platforms_array[index].id = 1073741824;
        }
        else if ((this.platforms_array[index].id & 65536) == 65536 || (this.platforms_array[index].id & 131072) == 131072 || (this.platforms_array[index].id & 262144) == 262144 || (this.platforms_array[index].id & 524288) == 524288)
        {
          int num1 = (this.platforms_array[index].id & 196608) == 0 ? 266240 : 409600;
          if ((this.platforms_array[index].id & 327680) != 0 && this.platforms_array[index].speed == 0 && this.platforms_array[index].fp_y - this.doj_fp_screenYOffset < this.common_fp_configLogicScreenHeight)
            this.platforms_array[index].speed = 1;
          if ((this.platforms_array[index].id & 655360) != 0 && this.platforms_array[index].speed == 0 && this.platforms_array[index].fp_y - this.doj_fp_screenYOffset - num1 > this.common_fp_configLogicScreenHeight)
            this.platforms_array[index].speed = -1;
          int num2 = this.platforms_array[index].objOffset + 60 * fp_dt * this.platforms_array[index].speed;
          if (num2 > num1 && this.platforms_array[index].speed > 0)
          {
            this.platforms_array[index].speed = -this.platforms_array[index].speed;
            num2 = (num1 << 1) - num2;
          }
          if (this.platforms_array[index].objOffset < 0 && this.platforms_array[index].speed < 0)
          {
            this.platforms_array[index].speed = -this.platforms_array[index].speed;
            num2 = -num2;
          }
          this.platforms_array[index].fp_y += num2 - this.platforms_array[index].objOffset;
          this.platforms_array[index].objOffset = num2;
          if (this.platforms_array[index].fp_y - this.doj_fp_screenYOffset < 0)
            this.platforms_array[index].id = 1073741824;
        }
        if ((this.platforms_array[index].id & 2097152) != 0 && this.platforms_array[index].objOffset > 0 && this.platforms_array[index].objOffset < 4)
        {
          this.platforms_array[index].updateTime += fp_dt;
          int num = 81;
          while (this.platforms_array[index].updateTime > num)
          {
            this.platforms_array[index].updateTime -= num;
            ++this.platforms_array[index].objOffset;
          }
        }
      }
    }

    public void platforms_draw()
    {
      int num1 = (this.platforms_fp_width >> 11) - 15 - 18 - 12;
      int num2 = 0;
      if (num1 < 0)
      {
        num2 = num1;
        num1 = 0;
      }
      int width = num1 - (num1 >> 1);
      for (int platformsBegin = this.platforms_begin; platformsBegin < this.platforms_end + 120; ++platformsBegin)
      {
        int platformdIdx = this.platforms_begin >= this.platforms_end ? (platformsBegin < 120 ? platformsBegin : platformsBegin - 120) : platformsBegin;
        if (platformdIdx != this.platforms_end)
        {
          if (this.doj_worldToScreenY(this.platforms_array[platformdIdx].fp_y - this.doj_fp_screenYOffset) >= -47)
          {
            if ((this.platforms_array[platformdIdx].id & 1048321) != 0 || (this.platforms_array[platformdIdx].id & 2) == 2 && this.themes_current != 3)
            {
              if ((this.platforms_array[platformdIdx].id & 8192) == 8192 || (this.platforms_array[platformdIdx].id & 16384) == 16384 || (this.platforms_array[platformdIdx].id & 32768) == 32768)
              {
                int num3 = (this.smoothtime - this.platforms_array[platformdIdx].objOffset) / 2;
                if (num3 > 166)
                  num3 = 166;
                this.debug_text((mrGame.MrGame.MrgString) ("t: " + (object) num3));
                this.gfx_setColorExt((int) byte.MaxValue - ((num3 << 10) * (int) byte.MaxValue / 166 >> 10) << 24 | this.gfx_getColor() & 16777215, 18);
                this.p_platforms_drawRegularPlatformWithGfx(platformdIdx);
              }
              this.p_platforms_drawRegularPlatformWithGfx(platformdIdx);
              this.gfx_setColorExt(-1, 0);
            }
            else if ((this.platforms_array[platformdIdx].id & 134217728) == 134217728)
            {
              int x = this.doj_worldToScreenX(this.platforms_array[platformdIdx].fp_x) - (this.platforms_fp_width >> 11 >> 1);
              int screenY = this.doj_worldToScreenY(this.platforms_array[platformdIdx].fp_y - this.doj_fp_screenYOffset);
              this.gfx_drawImage(this.themes_getImageId(786), x, screenY, 20, 0);
              int num4 = this.doj_worldToScreenX(this.platforms_array[platformdIdx].fp_x) + (this.platforms_fp_width >> 11 >> 1);
              this.gfx_drawImage(this.themes_getImageId(787), num4 + num2, screenY, 24, 0);
            }
            else if ((this.platforms_array[platformdIdx].id & 268435456) == 268435456)
            {
              int x = this.doj_worldToScreenX(this.platforms_array[platformdIdx].fp_x) - (this.platforms_fp_width >> 11 >> 1);
              int screenY = this.doj_worldToScreenY(this.platforms_array[platformdIdx].fp_y - this.doj_fp_screenYOffset);
              this.gfx_drawImage(this.themes_getImageId(788), x, screenY, 20, 0);
              int num5 = this.doj_worldToScreenX(this.platforms_array[platformdIdx].fp_x) + (this.platforms_fp_width >> 11 >> 1);
              this.gfx_drawImage(this.themes_getImageId(789), num5 + num2, screenY, 24, 0);
            }
            else if ((this.platforms_array[platformdIdx].id & 536870912) == 536870912)
            {
              int x = this.doj_worldToScreenX(this.platforms_array[platformdIdx].fp_x) - (this.platforms_fp_width >> 11 >> 1);
              int screenY = this.doj_worldToScreenY(this.platforms_array[platformdIdx].fp_y - this.doj_fp_screenYOffset);
              this.gfx_drawImage(this.themes_getImageId(790), x, screenY, 20, 0);
              int num6 = this.doj_worldToScreenX(this.platforms_array[platformdIdx].fp_x) + (this.platforms_fp_width >> 11 >> 1);
              this.gfx_drawImage(this.themes_getImageId(791), num6 + num2, screenY, 24, 0);
            }
            else if ((this.platforms_array[platformdIdx].id & 67108864) == 67108864)
            {
              int x1 = this.doj_worldToScreenX(this.platforms_array[platformdIdx].fp_x) - (this.platforms_fp_width >> 11 >> 1);
              int screenY = this.doj_worldToScreenY(this.platforms_array[platformdIdx].fp_y - this.doj_fp_screenYOffset);
              this.gfx_drawImage(this.themes_getImageId(781), x1, screenY, 20, 0);
              int x2 = x1 + 15;
              this.platform_fillHorizontal(this.themes_getImageId(782), x2, screenY, width);
              int x3 = x2 + width;
              this.gfx_drawImage(this.themes_getImageId(783), x3, screenY, 20, 0);
              int x4 = x3 + 12;
              this.platform_fillHorizontal(this.themes_getImageId(784), x4, screenY, width);
              int num7 = x4 + width;
              this.gfx_drawImage(this.themes_getImageId(785), num7 + num2, screenY, 20, 0);
            }
            else if ((this.platforms_array[platformdIdx].id & 2) == 2 && this.themes_current == 3)
            {
              int x5 = this.doj_worldToScreenX(this.platforms_array[platformdIdx].fp_x) - (this.platforms_fp_width >> 11 >> 1);
              int screenY = this.doj_worldToScreenY(this.platforms_array[platformdIdx].fp_y - this.doj_fp_screenYOffset);
              this.gfx_drawImage(1253, x5, screenY, 20, 0);
              int x6 = x5 + 10;
              this.platform_fillHorizontal(1254, x6, screenY, width);
              int x7 = x6 + width;
              this.gfx_drawImage(1255, x7, screenY, 20, 0);
              int x8 = x7 + 17;
              this.platform_fillHorizontal(1256, x8, screenY, width);
              this.gfx_drawImage(1257, x8 + width + num2, screenY, 20, 0);
            }
            else if ((this.platforms_array[platformdIdx].id & int.MinValue) == int.MinValue)
            {
              int num8 = (int) byte.MaxValue - ((this.smoothtime - this.platforms_array[platformdIdx].updateTime << 10) * (int) byte.MaxValue / 166 >> 10);
              this.debug_text((mrGame.MrGame.MrgString) ("blendvalue: " + (object) num8));
              this.gfx_setColorExt(num8 << 24 | this.gfx_getColor() & 16777215, 18);
              if (this.themes_current != 3)
              {
                this.p_platforms_drawRegularPlatformWithGfx(platformdIdx);
              }
              else
              {
                int x9 = this.doj_worldToScreenX(this.platforms_array[platformdIdx].fp_x) - (this.platforms_fp_width >> 11 >> 1);
                int screenY = this.doj_worldToScreenY(this.platforms_array[platformdIdx].fp_y - this.doj_fp_screenYOffset);
                this.gfx_drawImage(1253, x9, screenY, 20, 0);
                int x10 = x9 + 10;
                this.platform_fillHorizontal(1254, x10, screenY, width);
                int x11 = x10 + width;
                this.gfx_drawImage(1255, x11, screenY, 20, 0);
                int x12 = x11 + 17;
                this.platform_fillHorizontal(1256, x12, screenY, width);
                this.gfx_drawImage(1257, x12 + width + num2, screenY, 20, 0);
              }
              this.gfx_setColorExt(-1, 0);
            }
          }
        }
        else
          break;
      }
      for (int index1 = (this.platforms_end - 1 + 120) % 120; index1 >= this.platforms_begin - 120; --index1)
      {
        int index2 = this.platforms_begin >= this.platforms_end ? (index1 < 0 ? index1 + 120 : index1) : index1;
        if (index2 == this.platforms_begin - 1 || index2 == 120)
          break;
        if ((this.platforms_array[index2].id & 16) != 0)
        {
          int screenX = this.doj_worldToScreenX(this.platforms_array[index2].fp_x + this.platforms_array[index2].objOffset);
          int screenY = this.doj_worldToScreenY(this.platforms_array[index2].fp_y - this.doj_fp_screenYOffset);
          if (this.themes_current == 1)
            this.gfx_drawImage(1222, screenX, screenY, 33, 0);
          else
            this.gfx_drawImage(this.themes_getImageId(830), screenX, screenY, 33, 0);
        }
        if ((this.platforms_array[index2].id & 32) != 0)
        {
          int screenX = this.doj_worldToScreenX(this.platforms_array[index2].fp_x + this.platforms_array[index2].objOffset);
          int screenY = this.doj_worldToScreenY(this.platforms_array[index2].fp_y - this.doj_fp_screenYOffset);
          this.gfx_drawImage(this.themes_getImageId(840), screenX, screenY, 33, 0);
        }
        if ((this.platforms_array[index2].id & 8) != 0)
        {
          int screenX = this.doj_worldToScreenX(this.platforms_array[index2].fp_x + this.platforms_array[index2].objOffset);
          int y = this.doj_worldToScreenY(this.platforms_array[index2].fp_y - this.doj_fp_screenYOffset) + 3;
          this.gfx_drawImage(this.themes_getImageId(825), screenX, y, 33, 0);
        }
        else if ((this.platforms_array[index2].id & 64) != 0)
        {
          int screenX = this.doj_worldToScreenX(this.platforms_array[index2].fp_x + this.platforms_array[index2].objOffset);
          int y = this.doj_worldToScreenY(this.platforms_array[index2].fp_y - this.doj_fp_screenYOffset) + 3;
          this.gfx_drawImage(this.themes_getImageId(826), screenX, y, 33, 0);
        }
        if ((this.platforms_array[index2].id & 128) != 0)
        {
          int screenX = this.doj_worldToScreenX(this.platforms_array[index2].fp_x + this.platforms_array[index2].objOffset);
          int screenY = this.doj_worldToScreenY(this.platforms_array[index2].fp_y - this.doj_fp_screenYOffset);
          this.gfx_drawImage(this.themes_getImageId(844), screenX, screenY, 33, 0);
        }
        if ((this.platforms_array[index2].id & 1048576) != 0)
        {
          int screenX = this.doj_worldToScreenX(this.platforms_array[index2].fp_x + this.platforms_array[index2].objOffset);
          int screenY = this.doj_worldToScreenY(this.platforms_array[index2].fp_y - this.doj_fp_screenYOffset);
          if (this.themes_current == 1)
            this.gfx_drawImage(1223, screenX, screenY, 33, 0);
          else
            this.gfx_drawImage(this.themes_getImageId(848), screenX, screenY, 33, 0);
        }
        if ((this.platforms_array[index2].id & 2097152) != 0)
        {
          int screenX = this.doj_worldToScreenX(this.platforms_array[index2].fp_x);
          int y = this.doj_worldToScreenY(this.platforms_array[index2].fp_y - this.doj_fp_screenYOffset) + 1;
          if (this.platforms_array[index2].objOffset == 1)
            this.gfx_drawImage(this.themes_getImageId(827), screenX, y, 33, 0);
          else if (this.platforms_array[index2].objOffset == 3)
            this.gfx_drawImage(this.themes_getImageId(829), screenX, y, 33, 0);
          else
            this.gfx_drawImage(this.themes_getImageId(828), screenX, y, 33, 0);
        }
        if ((this.platforms_array[index2].id & 4194304) != 0)
          this.gfx_drawImage(1543, this.doj_worldToScreenX(this.platforms_array[index2].fp_x), this.doj_worldToScreenY(this.platforms_array[index2].fp_y - this.doj_fp_screenYOffset), 33, 0);
      }
    }

    public void p_platforms_drawRegularPlatformWithGfx(int platformdIdx)
    {
      int index = platformdIdx;
      int num1 = this.platforms_fp_width >> 11;
      int id1 = 37;
      int id2 = 38;
      int id3 = 39;
      if ((this.platforms_array[index].id & 5) == 5)
      {
        id1 = 792;
        id2 = 793;
        id3 = 794;
      }
      else if ((this.platforms_array[index].id & 2) == 2 || (this.platforms_array[index].id & int.MinValue) == int.MinValue)
      {
        id1 = 795;
        id2 = 796;
        id3 = 797;
      }
      else if ((this.platforms_array[index].id & 256) == 256)
      {
        id1 = 801;
        id2 = 802;
        id3 = 803;
      }
      else if ((this.platforms_array[index].id & 512) == 512)
      {
        id1 = 804;
        id2 = 805;
        id3 = 806;
      }
      else if ((this.platforms_array[index].id & 1024) == 1024)
      {
        id1 = 807;
        id2 = 808;
        id3 = 809;
      }
      else if ((this.platforms_array[index].id & 2048) == 2048)
      {
        id1 = 810;
        id2 = 811;
        id3 = 812;
      }
      else if ((this.platforms_array[index].id & 4096) == 4096)
      {
        id1 = 813;
        id2 = 814;
        id3 = 815;
      }
      else if ((this.platforms_array[index].id & 8192) == 8192)
      {
        id1 = 816;
        id2 = 817;
        id3 = 818;
      }
      else if ((this.platforms_array[index].id & 16384) == 16384)
      {
        id1 = 819;
        id2 = 820;
        id3 = 821;
      }
      else if ((this.platforms_array[index].id & 32768) == 32768)
      {
        id1 = 822;
        id2 = 823;
        id3 = 824;
      }
      else if ((this.platforms_array[index].id & 65536) == 65536 || (this.platforms_array[index].id & 131072) == 131072 || (this.platforms_array[index].id & 262144) == 262144 || (this.platforms_array[index].id & 524288) == 524288)
      {
        id1 = 798;
        id2 = 799;
        id3 = 800;
      }
      int width = num1 - this.gfx_getImageWidth(this.themes_getImageId(id1)) - this.gfx_getImageWidth(this.themes_getImageId(id3));
      int num2 = 0;
      if (width < 0)
      {
        num2 = width;
        width = 0;
      }
      int x1 = this.doj_worldToScreenX(this.platforms_array[index].fp_x) - (this.platforms_fp_width >> 11 >> 1);
      int screenY = this.doj_worldToScreenY(this.platforms_array[index].fp_y - this.doj_fp_screenYOffset);
      this.gfx_drawImage(this.themes_getImageId(id1), x1, screenY, 20, 0);
      int x2 = x1 + this.gfx_getImageWidth(this.themes_getImageId(id1));
      this.platform_fillHorizontal(this.themes_getImageId(id2), x2, screenY, width);
      int x3 = x2 + (width + num2);
      this.gfx_drawImage(this.themes_getImageId(id3), x3, screenY, 20, 0);
    }

    public void platform_fillHorizontal(int imageId, int x, int y, int width)
    {
      int imageWidth = this.gfx_getImageWidth(imageId);
      int imageHeight = this.gfx_getImageHeight(imageId);
      if (width >= imageWidth)
      {
        int num = width / imageWidth;
        for (int index = 0; index < num; ++index)
        {
          this.gfx_drawImage(this.themes_getImageId(imageId), x, y, 20, 0);
          x += imageWidth;
          width -= imageWidth;
        }
      }
      if (width <= 0)
        return;
      this.gfx_drawSubImage(imageId, x, y, 20, width, imageHeight, 0, 0);
    }

    public void projectiles_init()
    {
      this.projectiles_array = new mrGame.MrGame.Projectile[10];
      for (int index = 0; index < 10; ++index)
        this.projectiles_array[index] = new mrGame.MrGame.Projectile();
      this.projectiles_reset();
    }

    public void projectiles_reset()
    {
      this.projectiles_count = 0;
      this.projectiles_timeFromLast = 0;
      this.projectiles_holdOnIndex = -1;
    }

    public void projectiles_free()
    {
      for (int index = 0; index < 10; ++index)
        this.projectiles_array[index] = (mrGame.MrGame.Projectile) null;
      this.projectiles_array = (mrGame.MrGame.Projectile[]) null;
    }

    public void projectiles_update(int fp_time)
    {
      for (int index = 0; index < this.projectiles_count; ++index)
      {
        if (index != this.projectiles_holdOnIndex)
        {
          this.projectiles_array[index].fp_pos_x += this.fp_mul(fp_time, this.projectiles_array[index].fp_vel_x);
          this.projectiles_array[index].fp_vel_y += this.fp_mul(fp_time, this.projectiles_array[index].fp_acc_y);
          this.projectiles_array[index].fp_pos_y += this.fp_mul(fp_time, this.projectiles_array[index].fp_vel_y);
        }
      }
      this.projectiles_timeFromLast += fp_time;
      this.projectiles_cleanup();
    }

    public bool projectiles_add(int fp_pos_x, int fp_pos_y, int fp_vel_x, bool shootingMonster)
    {
      if (this.projectiles_count < 0)
        this.projectiles_count = 0;
      if (this.projectiles_count >= 10)
        return false;
      this.projectiles_array[this.projectiles_count].fp_pos_x = fp_pos_x;
      this.projectiles_array[this.projectiles_count].fp_pos_y = fp_pos_y + this.doj_fp_screenYOffset;
      this.projectiles_array[this.projectiles_count].fp_vel_x = fp_vel_x;
      if (this.themes_current == 1 || this.themes_current == 3)
      {
        this.projectiles_array[this.projectiles_count].fp_acc_y = -6553600;
        this.projectiles_array[this.projectiles_count].fp_vel_y = 2355200;
        this.projectiles_array[this.projectiles_count].fp_vel_x = this.fp_mul(this.projectiles_array[this.projectiles_count].fp_vel_x, this.fp_div(2355200, 2457600));
        if (shootingMonster)
        {
          int fp_a = 2457;
          this.projectiles_array[this.projectiles_count].fp_vel_y = this.fp_mul(fp_a, this.projectiles_array[this.projectiles_count].fp_vel_y);
          this.projectiles_array[this.projectiles_count].fp_vel_x = this.fp_mul(fp_a, this.projectiles_array[this.projectiles_count].fp_vel_x);
        }
      }
      else
      {
        this.projectiles_array[this.projectiles_count].fp_vel_y = 2457600;
        this.projectiles_array[this.projectiles_count].fp_acc_y = 0;
      }
      this.projectiles_array[this.projectiles_count].fp_initVelDiv = this.fp_div(this.projectiles_array[this.projectiles_count].fp_vel_x, this.projectiles_array[this.projectiles_count].fp_vel_y);
      ++this.projectiles_count;
      this.projectiles_timeFromLast = 0;
      return true;
    }

    public void projectiles_cleanup()
    {
      for (int index1 = this.projectiles_count - 1; index1 >= 0; --index1)
      {
        if (this.projectiles_array[index1].fp_pos_y - this.doj_fp_screenYOffset > this.common_fp_configLogicScreenHeight || this.projectiles_array[index1].fp_pos_y - this.doj_fp_screenYOffset < 0 || this.projectiles_array[index1].fp_pos_x > this.common_fp_configLogicScreenWidth || this.projectiles_array[index1].fp_pos_x < 0)
        {
          for (int index2 = index1; index2 < this.projectiles_count - 1; ++index2)
          {
            this.projectiles_array[index2].fp_pos_x = this.projectiles_array[index2 + 1].fp_pos_x;
            this.projectiles_array[index2].fp_pos_y = this.projectiles_array[index2 + 1].fp_pos_y;
            this.projectiles_array[index2].fp_vel_x = this.projectiles_array[index2 + 1].fp_vel_x;
            this.projectiles_array[index2].fp_vel_y = this.projectiles_array[index2 + 1].fp_vel_y;
          }
          --this.projectiles_count;
          this.achievement_clearStat(7);
          this.achievement_clearStat(8);
        }
      }
    }

    public void projectiles_draw()
    {
      for (int index = 0; index < this.projectiles_count; ++index)
      {
        int screenX = this.doj_worldToScreenX(this.projectiles_array[index].fp_pos_x);
        int screenY = this.doj_worldToScreenY(this.projectiles_array[index].fp_pos_y - this.doj_fp_screenYOffset);
        if (this.themes_current == 4)
        {
          this.egfx_reset();
          int num = 0;
          if (this.projectiles_array[index].fp_vel_x != 0)
            num = (8192 * this.fp_div(this.projectiles_array[index].fp_vel_x, this.projectiles_array[index].fp_vel_y) >> 11) * 14 / 10;
          this.p_egfx_pixel_rotate_f((float) num * 1.52587891E-05f);
          this.gfx_drawImage(this.themes_getImageId(883), screenX, screenY, 3, 0);
          this.egfx_reset();
        }
        else
          this.gfx_drawImage(this.themes_getImageId(883), screenX, screenY, 3, 0);
      }
      if (this.projectiles_holdOnIndex == -1)
        return;
      this.p_projectiles_remove(this.projectiles_holdOnIndex);
      this.projectiles_holdOnIndex = -1;
      if (this.objects_array[this.objects_holdOnIndex].id == 11)
        this.objects_array[this.objects_holdOnIndex].id = 31;
      else if (this.objects_array[this.objects_holdOnIndex].id == 22 && this.objects_array[this.objects_holdOnIndex].fp_offsetY > 0)
      {
        --this.objects_array[this.objects_holdOnIndex].fp_offsetY;
        this.objects_array[this.objects_holdOnIndex].fp_timeUpdate = 1;
      }
      else if (this.objects_array[this.objects_holdOnIndex].id == 26 && this.objects_array[this.objects_holdOnIndex].fp_offsetX > 0)
      {
        --this.objects_array[this.objects_holdOnIndex].fp_offsetX;
        this.objects_array[this.objects_holdOnIndex].fp_rangeX = 0;
      }
      else
        this.objects_array[this.objects_holdOnIndex].id = 32;
      this.objects_holdOnIndex = -1;
    }

    public bool projectiles_markForRemoveIfInArea(int fp_x, int fp_y, int fp_w, int fp_h)
    {
      int num = this.p_projectiles_indexInArea(fp_x, fp_y, fp_w, fp_h);
      if (num == -1)
        return false;
      this.projectiles_holdOnIndex = num;
      return true;
    }

    public bool projectiles_removeIfInArea(int fp_x, int fp_y, int fp_w, int fp_h)
    {
      int index = this.p_projectiles_indexInArea(fp_x, fp_y, fp_w, fp_h);
      if (index == -1)
        return false;
      this.p_projectiles_remove(index);
      return true;
    }

    public int p_projectiles_indexInArea(int fp_x, int fp_y, int fp_w, int fp_h)
    {
      int num1 = this.fp_div(30720, this.common_fp_xRatio);
      int num2 = this.fp_div(32768, this.common_fp_yRatio);
      int num3 = fp_x - (fp_w >> 1) - (num1 >> 1);
      int num4 = fp_x + (fp_w >> 1) + (num1 >> 1);
      int num5 = fp_y + this.doj_fp_screenYOffset - (fp_h >> 1) - (num2 >> 1);
      int num6 = fp_y + this.doj_fp_screenYOffset + (fp_h >> 1) + (num2 >> 1);
      for (int index = 0; index < this.projectiles_count; ++index)
      {
        if (this.projectiles_array[index].fp_pos_x > num3 && this.projectiles_array[index].fp_pos_x < num4 && this.projectiles_array[index].fp_pos_y > num5 && this.projectiles_array[index].fp_pos_y < num6)
          return index;
      }
      return -1;
    }

    public void p_projectiles_remove(int index)
    {
      for (int index1 = index; index1 < this.projectiles_count - 1; ++index1)
      {
        this.projectiles_array[index1].fp_pos_x = this.projectiles_array[index1 + 1].fp_pos_x;
        this.projectiles_array[index1].fp_pos_y = this.projectiles_array[index1 + 1].fp_pos_y;
        this.projectiles_array[index1].fp_vel_x = this.projectiles_array[index1 + 1].fp_vel_x;
        this.projectiles_array[index1].fp_vel_y = this.projectiles_array[index1 + 1].fp_vel_y;
      }
      --this.projectiles_count;
    }

    public bool projectiles_isAnyOnScreen()
    {
      if (this.projectiles_holdOnIndex != -1)
        return true;
      return this.projectiles_count > 0 && this.projectiles_timeFromLast < 1024;
    }

    public int game_hs_defaultscore(int table, int index) => -1;

    public int game_hs_defaultextra(int table, int index) => 0;

    public mrGame.MrGame.MrgString game_hs_defaultname(int table, int index)
    {
      return (mrGame.MrGame.MrgString) "";
    }

    public bool highscores_initialized()
    {
      if (this.mrg_loadData((mrGame.MrGame.MrgString) "player") == null)
        return false;
      return true;
    }

    public void highscores_init()
    {
      this.hs_load(0);
      this.highscores_playerName = (mrGame.MrGame.MrgString) "";
      sbyte[] a = this.mrg_loadData((mrGame.MrGame.MrgString) "player");
      if (a == null)
        return;
      sbyte[] numArray;
      try
      {
        this.p_bytecodec_istream = this.byte_array_createInput(a);
        this.highscores_playerName = this.bi_getString(this.p_bytecodec_istream);
        this.p_bytecodec_istream = this.p_bi_free(this.p_bytecodec_istream);
        numArray = (sbyte[]) null;
      }
      catch (Exception ex)
      {
      }
      numArray = (sbyte[]) null;
    }

    public void highscores_free()
    {
      this.hs_unload();
      this.highscores_savePlayerName();
      this.highscores_playerName = (mrGame.MrGame.MrgString) null;
    }

    public void highscores_savePlayerName()
    {
      this.debug_text((mrGame.MrGame.MrgString) "saving player name");
      try
      {
        this.be_newArray();
        this.be_writeString(this.highscores_playerName);
        sbyte[] byteArray = this.be_getByteArray();
        this.be_close();
        this.mrg_saveData((mrGame.MrGame.MrgString) "player", byteArray);
      }
      catch (Exception ex)
      {
      }
    }

    public int highscores_add(mrGame.MrGame.MrgString name, int score)
    {
      if (this.multiplayer_enabled)
        return -1;
      this.debug_text((mrGame.MrGame.MrgString) "****** HIGHSCORES_ADD(" + name + (mrGame.MrGame.MrgString) "," + (mrGame.MrGame.MrgString) score + (mrGame.MrGame.MrgString) ")");
      return this.hs_addScore(0, name, score, 0, 0, (mrGame.MrGame.MrgString) "");
    }

    public int highscores_multi_add(mrGame.MrGame.MrgString name, int score)
    {
      return this.hs_addScore(1, name, score, 0, 0, (mrGame.MrGame.MrgString) "");
    }

    public void highscores_multi_reset() => this.p_hs_reset(1);

    public void highscores_draw_local_markers()
    {
      this.highscores_draw_markers(0, this.themes_getImageId(884));
    }

    public void highscores_draw_multiplayer_markers()
    {
      this.highscores_draw_markers(1, this.themes_getImageId(884));
    }

    public void highscores_draw_markers(int table, int imageIndex)
    {
      int num1 = this.hs_queryPlace(table, this.doj_score + (this.common_fp_configLogicScreenHeight >> 11));
      if (num1 == -1)
        return;
      for (int index = num1; index < 10; ++index)
      {
        int num2 = this.hs_data_int[index];
        if (num2 > 0)
        {
          int num3 = num2 << 11;
          if (num2 >= this.doj_score + (this.common_fp_configLogicScreenHeight >> 11) || num3 - (this.doj_score << 11) <= 0)
            break;
          int screenY = this.doj_worldToScreenY(num3 - this.doj_fp_screenYOffset);
          int num4 = this.doj_screen_fp_posX >> 11;
          this.gfx_drawImage(this.themes_getImageId(imageIndex), this.dynamic_X_RES - num4, screenY, 10, 0);
          int y = screenY - this.gfx_getFontHeight(7);
          this.gfx_setColor(0);
          this.gfx_drawString(7, this.hs_data_string[index], this.dynamic_X_RES - num4, y, 24);
        }
      }
    }

    public void multiplayer_init()
    {
      this.multiplayer_enabled = false;
      this.multiplayer_loadingState = false;
      this.multiplayer_maxplayers = 1;
      this.multiplayer_player = -1;
      this.multiplayer_playerNames = new mrGame.MrGame.MrgString[8];
      for (int index = 0; index < 8; ++index)
        this.multiplayer_playerNames[index] = (mrGame.MrGame.MrgString) "";
    }

    public void multiplayer_free()
    {
      for (int index = 0; index < 8; ++index)
        this.multiplayer_playerNames[index] = (mrGame.MrGame.MrgString) null;
      this.multiplayer_playerNames = (mrGame.MrGame.MrgString[]) null;
    }

    public void multiplayer_saveState()
    {
      try
      {
        this.be_newArray();
        this.be_writeInt(this.multiplayer_maxplayers);
        this.be_writeInt(this.multiplayer_player);
        for (int index = 0; index < 8; ++index)
          this.be_writeString(this.multiplayer_playerNames[index]);
        sbyte[] byteArray = this.be_getByteArray();
        this.be_close();
        this.mrg_saveData((mrGame.MrGame.MrgString) "multi", byteArray);
      }
      catch (Exception ex)
      {
      }
    }

    public void multiplayer_loadState()
    {
      int num1 = -1;
      int num2 = -1;
      sbyte[] a = this.mrg_loadData((mrGame.MrGame.MrgString) "multi");
      if (a != null)
      {
        sbyte[] numArray;
        try
        {
          this.p_bytecodec_istream = this.byte_array_createInput(a);
          num1 = (this.p_bytecodec_istream.pos += 4) <= this.p_bytecodec_istream.limit || this.p_bi_fillbuf_rev(this.p_bytecodec_istream, 4) ? (int) this.p_bytecodec_istream.buf[this.p_bytecodec_istream.pos - 4] << 24 | ((int) this.p_bytecodec_istream.buf[this.p_bytecodec_istream.pos - 3] & (int) byte.MaxValue) << 16 | ((int) this.p_bytecodec_istream.buf[this.p_bytecodec_istream.pos - 2] & (int) byte.MaxValue) << 8 | (int) this.p_bytecodec_istream.buf[this.p_bytecodec_istream.pos - 1] & (int) byte.MaxValue : -1;
          num2 = (this.p_bytecodec_istream.pos += 4) <= this.p_bytecodec_istream.limit || this.p_bi_fillbuf_rev(this.p_bytecodec_istream, 4) ? (int) this.p_bytecodec_istream.buf[this.p_bytecodec_istream.pos - 4] << 24 | ((int) this.p_bytecodec_istream.buf[this.p_bytecodec_istream.pos - 3] & (int) byte.MaxValue) << 16 | ((int) this.p_bytecodec_istream.buf[this.p_bytecodec_istream.pos - 2] & (int) byte.MaxValue) << 8 | (int) this.p_bytecodec_istream.buf[this.p_bytecodec_istream.pos - 1] & (int) byte.MaxValue : -1;
          if (num1 != -1 && num2 != -1)
          {
            for (int index = 0; index < 8; ++index)
              this.multiplayer_playerNames[index] = this.bi_getString(this.p_bytecodec_istream);
          }
          this.p_bytecodec_istream = this.p_bi_free(this.p_bytecodec_istream);
          numArray = (sbyte[]) null;
        }
        catch (Exception ex)
        {
        }
        numArray = (sbyte[]) null;
      }
      if (num1 == -1 && num2 == -1)
      {
        this.hs_load(1);
        this.multiplayer_player = 0;
        this.multiplayer_loadingState = false;
      }
      else
      {
        this.multiplayer_player = num2;
        this.multiplayer_maxplayers = num1;
        this.hs_load(1);
        this.multiplayer_loadingState = true;
      }
    }

    public void multiplayer_clearState(bool clearNames)
    {
      if (this.multiplayer_maxplayers != this.multiplayer_player)
        return;
      try
      {
        this.be_newArray();
        this.be_writeInt(-1);
        this.be_writeInt(-1);
        sbyte[] byteArray = this.be_getByteArray();
        this.be_close();
        this.mrg_saveData((mrGame.MrGame.MrgString) "multi", byteArray);
      }
      catch (Exception ex)
      {
      }
      this.highscores_multi_reset();
      this.multiplayer_player = -1;
      if (!clearNames)
        return;
      for (int index = 0; index < 8; ++index)
        this.multiplayer_playerNames[index] = (mrGame.MrGame.MrgString) "";
    }

    public void multiplayer_reset()
    {
      this.multiplayer_player = this.multiplayer_maxplayers;
      this.multiplayer_clearState(true);
    }

    public mrGame.MrGame.MrgString multiplayer_getCurrentPlayerName()
    {
      return this.multiplayer_player < 0 || this.multiplayer_player >= 8 ? (mrGame.MrGame.MrgString) "" : this.multiplayer_playerNames[this.multiplayer_player];
    }

    public void multiplayer_setCurrentPlayerName(mrGame.MrGame.MrgString player)
    {
      if (this.multiplayer_player < 0 || this.multiplayer_player >= 8)
        return;
      this.multiplayer_playerNames[this.multiplayer_player] = player;
    }

    public void egi_eventPressed(int id)
    {
      this.debug_text((mrGame.MrGame.MrgString) ("======================================= event pressed - M E N U ID: " + (object) (!this.p_game_menuInited || this.p_em_stackPos < 0 ? 0 : this.p_em_menuStack[this.p_em_stackPos]) + " id: " + (object) id));
      switch (id)
      {
        case 4:
          this.em_selectItem(id);
          break;
        case 24:
          this.p_options[5] = (sbyte) (((int) this.p_options[5] + 1) % 3);
          break;
        case 25:
          int upx = this.p_touchdata[this.p_mt_last].upx;
          int upy = this.p_touchdata[this.p_mt_last].upy;
          int elementY = this.eg_getElementY(25);
          int elementX = this.eg_getElementX(25);
          int elementWidth = this.eg_getElementWidth(25);
          int num1 = this.gfx_getFontHeight(5) * 3 >> 1;
          int num2 = elementY + num1 + (this.gfx_getImageHeight(21) >> 1);
          int num3 = 7;
          int num4 = elementX;
          if (num4 < num3)
            num4 = num3;
          int num5 = elementX + elementWidth;
          if (num5 > this.dynamic_X_RES - num3)
            num5 = this.dynamic_X_RES - num3;
          if (!this.horizArrowVisible || upy <= num2 - 30 || upy >= num2 + 30)
            break;
          if (upx < num4 + 29 && upx > num4)
          {
            this.eg_slideLeft(25);
            break;
          }
          if (upx >= num5 || upx <= num5 - 29)
            break;
          this.eg_slideRight(25);
          break;
        case 38:
          this.p_em_gotoGame = true;
          this.game_exitToMenu(15);
          break;
        case 1000:
          this.em_doAction(14, 1);
          break;
        case 1001:
          this.em_doAction(15, 1);
          break;
        case 1002:
          this.mrg_requestIngameMenu();
          break;
        case 1003:
        case 1019:
          this.em_back();
          break;
        case 1004:
          if (this.p_inGame)
          {
            if (this.multiplayer_player == this.multiplayer_maxplayers)
              this.multiplayer_clearState(true);
            this.game_exit();
            this.p_tb_handleInput(-1, true);
            this.highscores_add(this.highscores_playerName, this.doj_score);
            this.dojxbla_reportResult(this.doj_score);
            this.debug_text((mrGame.MrGame.MrgString) ("score: " + (object) this.doj_score));
            this.mrg_resetKeys();
            break;
          }
          this.em_popMenu();
          break;
        case 1005:
          this.highscores_add(this.highscores_playerName, this.doj_score);
          this.dojxbla_reportResult(this.doj_score);
          this.debug_text((mrGame.MrGame.MrgString) ("score: " + (object) this.doj_score));
          this.doj_restartGame();
          break;
        case 1006:
          this.p_tb_handleInput(0, true);
          ++this.multiplayer_player;
          this.highscores_playerName = (mrGame.MrGame.MrgString) "";
          this.eg_reset();
          this.doj_restartGame();
          break;
        case 1007:
          this.eg_listenKeyPresses(false);
          int focusElementId = this.eg_getFocusElementId();
          this.doj_eg_setFocus(-1);
          this.doj_textInputMode = 1;
          this.eg_lockGui(true);
          this.highscores_playerName = this.mrp_textinput(this.p_allTexts[91].toLowerCase(), this.highscores_playerName, 107, 8, 0);
          this.eg_lockGui(false);
          this.doj_eg_setFocus(focusElementId);
          this.mrg_resetKeys();
          this.eg_listenKeyPresses(true);
          break;
        case 1008:
          this.p_tb_handleInput(0, true);
          this.multiplayer_clearState(false);
          this.multiplayer_player = 0;
          this.multiplayer_enabled = true;
          this.eg_reset();
          this.p_em_gotoGame = true;
          this.doj_restartGame();
          break;
        case 1009:
          break;
        case 1010:
          this.tutorial_nextScreen();
          break;
        case 1016:
          this.popup_delete();
          this.doj_endGame();
          break;
        case 1020:
          this.popup_delete();
          break;
        default:
          if (this.p_inGame && (this.p_gameDisplay || !this.p_inGame))
            break;
          this.em_selectItem(id);
          break;
      }
    }

    public void menu_buttonPaint(
      mrGame.MrGame.MrgString txt,
      int x,
      int y,
      int w,
      int h,
      bool focused,
      bool softkey)
    {
      txt = txt.toLowerCase();
      if (this.p_inGame && this.doj_fp_endGameYoff != 0 && (this.p_gameDisplay || !this.p_inGame))
        y += this.doj_worldToScreenY(this.doj_fp_endGameYoff);
      if (this.p_em_selectLanguageActive)
      {
        this.gfx_setClip(0, 0, this.dynamic_X_RES, this.dynamic_Y_RES);
        this.gfx_getFontHeight(0);
        this.gfx_setColor(focused ? 14257788 : 16049353);
        this.gfx_fillRect(x, y, w, h);
        this.gfx_setColor(1118481);
        this.gfx_drawRect(x, y, w, h);
        this.gfx_setColor(0);
        this.gfx_setColor(0);
        this.gfx_drawString(0, txt, x + (w >> 1), y + h - (h - this.gfx_getFontHeight(0) >> 1), 33);
      }
      else
      {
        int x1 = x;
        int imageindex = 7;
        int num1 = 60;
        int num2 = 60;
        if (focused)
        {
          imageindex = 10;
          num1 = 60;
          num2 = 60;
        }
        int num3 = 12;
        this.gfx_drawImage(imageindex, x1, y, 20, 0);
        for (int x2 = x1 + num1; x2 < x + w - num2; ++x2)
          this.gfx_drawImage(imageindex + 1, x2, y, 20, 0);
        this.gfx_drawImage(imageindex + 2, x + w, y, 24, 0);
        this.gfx_setColor(0);
        this.gfx_drawString(3, txt, x + (w >> 1), y + num3, 17);
      }
    }

    public void egi_textButtonPaint(
      int id,
      int x,
      int y,
      int w,
      int h,
      mrGame.MrGame.MrgString txt,
      int lastEvent,
      int lastEventTime,
      bool focused)
    {
      txt = txt.toLowerCase();
      if (false)
        return;
      switch (id)
      {
        case 24:
          int fontHeight1 = this.gfx_getFontHeight(3);
          int num1 = 4;
          if (focused)
          {
            this.gfx_setColor(52224);
            this.gfx_drawString(3, txt, this.dynamic_X_RES >> 1, y, 17);
          }
          else
          {
            this.gfx_setColor(0);
            this.gfx_drawString(3, txt, this.dynamic_X_RES >> 1, y, 17);
          }
          if (this.p_options[5] == (sbyte) 0)
          {
            this.gfx_setColor(13421772);
            this.gfx_drawString(5, this.p_allTexts[37], this.dynamic_X_RES >> 1, y + fontHeight1 + num1, 17);
            break;
          }
          if (this.p_options[5] == (sbyte) 1)
          {
            this.gfx_setColor(13421772);
            this.gfx_drawString(5, this.p_allTexts[35], this.dynamic_X_RES >> 1, y + fontHeight1 + num1, 17);
            break;
          }
          this.gfx_setColor(13421772);
          this.gfx_drawString(5, this.p_allTexts[36], this.dynamic_X_RES >> 1, y + fontHeight1 + num1, 17);
          break;
        case 31:
          int fontHeight2 = this.gfx_getFontHeight(3);
          int num2 = 4;
          if (focused)
          {
            this.gfx_setColor(52224);
            this.gfx_drawString(3, txt, this.dynamic_X_RES >> 1, y, 17);
          }
          else
          {
            this.gfx_setColor(0);
            this.gfx_drawString(3, txt, this.dynamic_X_RES >> 1, y, 17);
          }
          if (this.p_options[8] == (sbyte) 0)
          {
            this.gfx_setColor(13421772);
            this.gfx_drawString(5, this.p_allTexts[43], this.dynamic_X_RES >> 1, y + fontHeight2 + num2, 17);
            break;
          }
          this.gfx_setColor(13421772);
          this.gfx_drawString(5, this.p_allTexts[44], this.dynamic_X_RES >> 1, y + fontHeight2 + num2, 17);
          break;
        case 1007:
          if (this.doj_fp_endGameYoff != 0)
            y += this.doj_worldToScreenY(this.doj_fp_endGameYoff);
          mrGame.MrGame.MrgString str = this.p_allTexts[33] + (mrGame.MrGame.MrgString) "" + this.highscores_playerName;
          if (this.gfx_stringWidth(3, str) > this.dynamic_X_RES * 9 / 10)
          {
            str = this.highscores_playerName;
            this.gfx_stringWidth(3, str);
          }
          int font;
          if (focused)
          {
            this.gfx_setColor(52224);
            font = 3;
          }
          else
          {
            this.gfx_setColor(0);
            font = 3;
          }
          this.gfx_drawString(font, str, this.dynamic_X_RES >> 1, y, 17);
          if (this.doj_showTapToChangeImage)
          {
            int x1 = (this.dynamic_X_RES >> 1) + this.gfx_stringWidth(3, str) / 2 + 170;
            int num3 = this.doj_screen_fp_posX >> 11;
            if (x1 >= this.dynamic_X_RES - num3)
              x1 = this.dynamic_X_RES - num3 - 1;
            this.gfx_drawImage(33, x1, y + this.gfx_getFontHeight(3), 24, 0);
          }
          break;
        case 1009:
          mrGame.MrGame.MrgString lowerCase = this.txt_stringParam(this.p_allTexts[92], (mrGame.MrGame.MrgString) string.Concat((object) (this.multiplayer_maxplayers + 1)), 1).toLowerCase();
          if (focused)
          {
            this.gfx_setColor(52224);
            this.gfx_drawString(3, lowerCase, x, y, 20);
          }
          else
          {
            this.gfx_setColor(0);
            this.gfx_drawString(3, lowerCase, x, y, 20);
          }
          int num4 = (this.gfx_getFontHeight(3) > this.gfx_getFontHeight(5) ? this.gfx_getFontHeight(3) : this.gfx_getFontHeight(5)) >> 2;
          this.menu_drawSlider(this.multiplayer_maxplayers - 1, 6, x, y + h + num4, w, 16);
          break;
        case 1019:
          this.gfx_drawImage(6, x, y, 20, 0);
          break;
        default:
          if (id < 1000 && this.p_indexTable2[1509 + id * 4] == (short) 4)
          {
            int num5 = this.gfx_getFontHeight(3) > this.gfx_getFontHeight(5) ? this.gfx_getFontHeight(3) : this.gfx_getFontHeight(5);
            int num6 = num5 >> 2;
            if (focused)
            {
              this.gfx_setColor(52224);
              this.gfx_drawString(3, this.p_allTexts[(int) this.p_indexTable2[1509 + (id * 4 + 3)]].toLowerCase(), this.dynamic_X_RES >> 1, y + num6, 17);
            }
            else
            {
              this.gfx_setColor(0);
              this.gfx_drawString(3, this.p_allTexts[(int) this.p_indexTable2[1509 + (id * 4 + 3)]].toLowerCase(), this.dynamic_X_RES >> 1, y + num6, 17);
            }
            if (this.p_options[(int) this.p_indexTable2[1509 + (id * 4 + 1)]] == (sbyte) 1)
            {
              this.gfx_setColor(13421772);
              this.gfx_drawString(5, this.p_allTexts[10], this.dynamic_X_RES >> 1, y + h - num6 - num5, 17);
              break;
            }
            this.gfx_setColor(13421772);
            this.gfx_drawString(5, this.p_allTexts[11], this.dynamic_X_RES >> 1, y + h - num6 - num5, 17);
            break;
          }
          this.menu_buttonPaint(txt, x, y, w, h, focused, false);
          break;
      }
    }

    public void menu_drawSlider(int step, int steps, int x, int y, int w, int vAlign)
    {
      int num = 10;
      if (vAlign == 16)
        num = -num;
      this.gfx_drawImage(13, x, y - num, 4 | vAlign, 0);
      for (int index = 42; index < w - 42; index += 4)
        this.gfx_drawImage(14, x + index, y - num, 4 | vAlign, 0);
      this.gfx_drawImage(15, x + w, y - num, 8 | vAlign, 0);
      w -= 29;
      this.gfx_drawImage(16, w / steps * step + x + 14, y, 1 | vAlign, 0);
    }

    public void egi_paintSlider(
      int id,
      int sel,
      int selOffset,
      int shift,
      int x,
      int y,
      int w,
      int h)
    {
      sbyte sliderValue = (sbyte) this.eg_getSliderValue(id);
      this.p_options[7] = (sbyte) this.themes_getThemeId((int) sliderValue);
      this.themes_current = this.themes_getThemeId((int) sliderValue);
      this.eg_getFocusElementId();
      int num1 = this.gfx_getFontHeight(5) * 3 >> 1;
      int num2 = 21;
      int num3 = w - 450 >> 1;
      y = this.dynamic_Y_RES - num1 - 90;
      if ((!this.p_game_menuInited || this.p_em_stackPos < 0 ? 0 : this.p_em_menuStack[this.p_em_stackPos]) == 0)
      {
        this.gfx_setColor(0);
        this.gfx_fillRect(0, y + num1, this.dynamic_X_RES, this.dynamic_Y_RES - (y + num1));
      }
      if (selOffset == 0)
      {
        this.gfx_drawImage(num2 + sel, x + num3, y + num1, 20, 0);
        int count = this.themes_getCount();
        int clipX = this.gfx_getClipX();
        int clipY = this.gfx_getClipY();
        int clipW = this.gfx_getClipW();
        int clipH = this.gfx_getClipH();
        int num4 = 113;
        this.gfx_setClip(x + num3 - (num4 >> 1), y + num1, num4 + 450, h);
        this.gfx_drawImage(num2 + (sel - 1 + count) % count, x + num3 - 450, y + num1, 20, 0);
        this.gfx_drawImage(num2 + (sel + 1) % count, x + num3 + 450, y + num1, 20, 0);
        this.gfx_drawImage(26, x + num3 + 450, y + num1, 17, 4);
        this.gfx_drawImage(26, x + num3, y + num1, 17, 0);
        this.gfx_setClip(clipX, clipY, clipW, clipH);
      }
      else
      {
        int count = this.themes_getCount();
        int clipX = this.gfx_getClipX();
        int clipY = this.gfx_getClipY();
        int clipW = this.gfx_getClipW();
        int clipH = this.gfx_getClipH();
        int num5 = 113;
        this.gfx_setClip(x + num3 - (num5 >> 1), y + num1, num5 + 450, h);
        int num6 = w - (num3 << 1) - (w - (num3 << 1)) * selOffset / (1 << shift);
        this.gfx_drawImage(num2 + sel, x + num6 + num3, y + num1, 24, 0);
        this.gfx_drawImage(num2 + (sel + 1) % count, x + num6 + num3, y + num1, 20, 0);
        this.gfx_drawImage(num2 + (sel - 1 + count) % count, x + num6 + num3 - 450, y + num1, 24, 0);
        this.gfx_drawImage(num2 + (sel + 2) % count, x + num6 + num3 + 450, y + num1, 20, 0);
        this.gfx_drawImage(26, x + num3 + 450, y + num1, 17, 4);
        this.gfx_drawImage(26, x + num3, y + num1, 17, 0);
        this.gfx_setClip(clipX, clipY, clipW, clipH);
      }
      if (this.themes_current == 0 && this.theme_notSlided)
      {
        int num7 = selOffset >= 1 << shift - 1 ? (int) byte.MaxValue - 2 * ((int) byte.MaxValue * ((1 << shift) - selOffset) >> shift) : (int) byte.MaxValue - 2 * ((int) byte.MaxValue * selOffset >> shift);
        if (num7 > 0)
          this.gfx_setColorExt(num7 << 24 | 16777215, 18);
        this.gfx_drawImage(34, this.dynamic_X_RES, this.dynamic_Y_RES, 40, 0);
        this.gfx_setColorExt(-1, 0);
      }
      else
        this.theme_notSlided = false;
      int y1 = y + num1 + (this.gfx_getImageHeight(21) >> 1);
      int num8 = 7;
      int x1 = x;
      if (x1 < num8)
        x1 = num8;
      int x2 = x + w;
      if (x2 > this.dynamic_X_RES - num8)
        x2 = this.dynamic_X_RES - num8;
      if (!this.horizArrowVisible)
        return;
      this.gfx_drawImage(17, x1, y1, 6, 1);
      this.gfx_drawImage(18, x2, y1, 10, 1);
    }

    public void egi_paintSelector(int id, int x, int y, int w, int h, int valP)
    {
      int pEmMenu = !this.p_game_menuInited || this.p_em_stackPos < 0 ? 0 : this.p_em_menuStack[this.p_em_stackPos];
      bool flag = false;
      if (pEmMenu == 1 && this.eg_getFocusElementId() == 6 || pEmMenu == 14 && this.eg_getFocusElementId() == 1009)
        flag = true;
      mrGame.MrGame.MrgString lowerCase = this.p_allTexts[(int) this.p_indexTable2[1536]].toLowerCase();
      mrGame.MrGame.MrgString mrgString;
      if (id == 1009)
      {
        mrgString = (mrGame.MrGame.MrgString) null;
        lowerCase = this.txt_stringParam(this.p_allTexts[92], (mrGame.MrGame.MrgString) string.Concat((object) (this.multiplayer_maxplayers + 1)), 1).toLowerCase();
      }
      int num1 = this.gfx_getFontHeight(3) > this.gfx_getFontHeight(5) ? this.gfx_getFontHeight(3) : this.gfx_getFontHeight(5);
      if (flag)
      {
        this.gfx_setColor(52224);
        this.gfx_drawString(3, lowerCase, this.dynamic_X_RES >> 1, y + (num1 >> 2), 17);
      }
      else
      {
        this.gfx_setColor(0);
        this.gfx_drawString(3, lowerCase, this.dynamic_X_RES >> 1, y + (num1 >> 2), 17);
      }
      mrgString = (mrGame.MrGame.MrgString) null;
      int num2 = -29 - num1;
      this.gfx_drawImage(13, x - 42, y - num2, 4, 0);
      for (int index = 42; index < w + 42; index += 4)
        this.gfx_drawImage(14, x + index - 42, y - num2, 4, 0);
      this.gfx_drawImage(15, x + w + 42, y - num2, 8, 0);
      w -= 29;
      this.gfx_drawImage(16, x + valP, y - num2, 3, 0);
    }

    public void egi_selectorValueChanged(int id)
    {
      this.debug_text((mrGame.MrGame.MrgString) "selector value changed");
      switch (id)
      {
        case 6:
          this.debug_text((mrGame.MrGame.MrgString) ("SND VAL: " + (object) this.eg_getSelectorValue(id)));
          this.p_indexTable2[1534] = (short) this.eg_getSelectorValue(id);
          if (this.eg_getSelectorValue(id) == 0)
          {
            this.p_options[0] = (sbyte) 0;
            this.emi_optionNotify(0);
            break;
          }
          this.p_options[0] = (sbyte) 1;
          this.emi_optionNotify(0);
          break;
        case 1009:
          this.multiplayer_maxplayers = this.eg_getSelectorValue(id) + 1;
          this.debug_text((mrGame.MrGame.MrgString) ("multiplayer_maxplayers: " + (object) this.multiplayer_maxplayers));
          break;
        default:
          this.debug_text((mrGame.MrGame.MrgString) "Unknown slider value changed");
          break;
      }
    }

    public void emi_init()
    {
      this.debug_text((mrGame.MrGame.MrgString) "E M I _ I N I T ( )");
      this.menu_softkey1 = 107;
      this.menu_softkey2 = -1;
      this.menu_intro = false;
      this.theme_notSlided = true;
      this.doj_postInit();
      if (!this.highscores_initialized())
      {
        this.highscores_savePlayerName();
        this.menu_resetGame();
      }
      this.menu_reset();
    }

    public void emi_free()
    {
    }

    public void emi_menuInitCallback(int menuId)
    {
      this.debug_text((mrGame.MrGame.MrgString) ("emi_menuInitCallback: " + (object) menuId));
      switch (menuId)
      {
        case 16:
          this.leaderboards_init();
          break;
        case 17:
          this.achievement_init();
          break;
      }
      this.p_indexTable2[1547] = (short) 2;
      this.p_indexTable2[1635] = (short) 2;
    }

    public void dojmenu_createGui(int menuId)
    {
      this.debug_text((mrGame.MrGame.MrgString) ("--------------- create GUI - M E N U ID: " + (object) menuId));
      if (!this.customization_isUnlocked())
      {
        this.p_indexTable2[1659] = (short) 2;
        this.p_indexTable2[1599] = (short) 1;
        this.p_indexTable2[1603] = (short) 1;
      }
      else
      {
        this.p_indexTable2[1659] = (short) 0;
        this.p_indexTable2[1599] = (short) 0;
        this.p_indexTable2[1603] = (short) 0;
      }
      this.eg_reset();
      this.menuBottomY = 0;
      this.menuTopY = 0;
      this.p_eg_setKeypadMode(false);
      if (menuId == 0)
      {
        this.multiplayer_enabled = false;
        this.menu_addThemesSlider();
      }
      if (this.em_getMenuType(menuId) == 0 || this.em_getMenuType(menuId) == 5)
      {
        this.em_getAmountOfVisibleElements(menuId);
        int num1 = 32;
        this.gfx_getFontHeight(3);
        this.gfx_getFontHeight(3);
        int num2 = this.dynamic_X_RES >> 5;
        int num3 = this.dynamic_X_RES - (this.dynamic_X_RES >> 5);
        int num4 = num1 + 83;
        this.menuTopY = num4;
        if (menuId == 4)
          num4 = this.gfx_getFontHeight(0) >> 1;
        int num5 = this.gfx_getFontHeight(3) > this.gfx_getFontHeight(5) ? this.gfx_getFontHeight(3) : this.gfx_getFontHeight(5);
        int num6 = 76;
        if (menuId == 0 || menuId == 15)
        {
          int num7 = num6 + 83 + 57;
          int num8 = 0;
          num8 = 90 + 15;
          int y = 135;
          int num9 = this.dynamic_Y_RES - this.mainMenuThemeSliderY + 29;
          this.debug_text((mrGame.MrGame.MrgString) ("*** eg_setArea() #1: y=" + (object) y));
          this.eg_setArea(0, y, this.dynamic_X_RES, this.dynamic_Y_RES - y - num9);
        }
        else
        {
          int num10 = num6 + (83 + this.gfx_getFontHeight(3)) + 57;
          this.debug_text((mrGame.MrGame.MrgString) ("*** eg_setArea() #3: y=" + (object) (83 + this.gfx_getFontHeight(3))));
          this.eg_setArea(0, 83 + this.gfx_getFontHeight(3), this.dynamic_X_RES, this.dynamic_Y_RES - num10);
          int num11 = num4 + this.gfx_getFontHeight(3);
        }
        if (menuId == 13)
        {
          this.debug_text((mrGame.MrGame.MrgString) "*** eg_setArea() #6: y=0");
          this.eg_setArea(0, 0, this.dynamic_X_RES, this.dynamic_Y_RES);
        }
        if (menuId == 4)
        {
          this.debug_text((mrGame.MrGame.MrgString) "*** eg_setArea() #7: y=0");
          this.eg_setArea(0, 0, this.dynamic_X_RES, this.dynamic_Y_RES);
        }
        for (int n = this.em_getAmountOfVisibleElements(menuId) - 1; n >= 0; --n)
        {
          int visibleMenuElement = this.em_getVisibleMenuElement(menuId, n);
          switch (visibleMenuElement)
          {
            case 34:
            case 35:
              this.p_indexTable2[1509 + (visibleMenuElement * 4 + 2)] = (short) 2;
              break;
          }
        }
        int ofVisibleElements = this.em_getAmountOfVisibleElements(menuId);
        int y1 = this.p_eg_areaY;
        this.debug_text((mrGame.MrGame.MrgString) ("********* FORCING Y = " + (object) y1));
        for (int n = 0; n < ofVisibleElements; ++n)
        {
          this.debug_text((mrGame.MrGame.MrgString) ("*** item #" + (object) n + ": borderbottom = " + (object) this.p_eg_guiBorderBottom));
          int visibleMenuElement = this.em_getVisibleMenuElement(menuId, n);
          int index = (int) this.p_indexTable2[1509 + (visibleMenuElement * 4 + 3)];
          int num12 = 0;
          this.debug_text((mrGame.MrGame.MrgString) ("elID: " + (object) visibleMenuElement + " elType: " + (object) this.p_indexTable2[1509 + visibleMenuElement * 4] + "  txt_get(textId) = ") + this.p_allTexts[index]);
          if (!(this.p_allTexts[index] == (mrGame.MrGame.MrgString) null))
            num12 = this.gfx_stringWidth(3, this.p_allTexts[index]) + num1;
          int w1 = (num12 > 120 ? num12 : 120) + (this.dynamic_X_RES >> 3);
          int num13 = this.gfx_getFontHeight(3) + (num1 >> 1);
          int h = num13 > 57 ? num13 : 57;
          if (this.p_indexTable2[1509 + visibleMenuElement * 4] == (short) 4)
          {
            h = num5 * 5 >> 1;
            w1 = num3 - num2;
          }
          if (this.p_indexTable2[1509 + visibleMenuElement * 4] == (short) 6)
          {
            h = num5 * 5 >> 1;
            w1 = num3 - num2;
          }
          if (visibleMenuElement == 25)
          {
            int count = this.themes_getCount();
            int imageindex = 21;
            h = (num5 * 3 >> 1) + this.gfx_getImageHeight(imageindex);
            int w2 = this.gfx_getImageWidth(imageindex) + 29;
            if (w2 > this.dynamic_X_RES)
              w2 = this.dynamic_X_RES;
            int x = (this.dynamic_X_RES >> 1) - (w2 >> 1);
            this.eg_addSlider(visibleMenuElement, count, true, false, 5, 20, x, y1, w2, h);
            this.eg_setSliderSelectionImmediately(visibleMenuElement, this.themes_getThemeSel());
            this.eg_setElementStatic(visibleMenuElement, true);
            this.eg_setKeypadFocusable(visibleMenuElement, false);
          }
          else
          {
            int x = 0;
            int num14 = 0;
            int pos_align = 17;
            int component_align = 17;
            if (menuId == 0 || menuId == 6 || menuId == 5)
            {
              w1 = this.gfx_stringWidth(3, this.p_allTexts[index]) + num1 + 12;
              int num15 = 132;
              if (num15 > w1)
                w1 = num15;
              if (!this.p_em_confirming && !this.p_inGame)
              {
                int num16 = y1;
                if (n < 4)
                {
                  pos_align = 5;
                  component_align = 20;
                }
                int num17;
                int num18;
                switch (n)
                {
                  case 0:
                    x = (this.dynamic_X_RES >> 4) + (this.dynamic_X_RES >> 6);
                    num17 = this.dynamic_Y_RES >> 2;
                    num16 = y1 + 30;
                    break;
                  case 1:
                    x = this.dynamic_X_RES >> 3;
                    num17 = (this.dynamic_Y_RES >> 1) - (this.dynamic_Y_RES >> 3);
                    num16 = y1;
                    break;
                  case 2:
                    num18 = this.dynamic_X_RES - this.dynamic_X_RES / 16 - w1;
                    num17 = (this.dynamic_Y_RES >> 1) - (this.dynamic_Y_RES >> 3) + (this.dynamic_Y_RES >> 3);
                    x = this.dynamic_X_RES - (this.dynamic_X_RES >> 4) - (this.dynamic_X_RES >> 4) - w1 + 10;
                    num16 = y1 + 70;
                    break;
                  case 3:
                    num18 = this.dynamic_X_RES - (this.dynamic_X_RES >> 4) - (this.dynamic_X_RES >> 4) - w1;
                    num17 = (this.dynamic_Y_RES >> 1) - (this.dynamic_Y_RES >> 3) + (this.dynamic_Y_RES >> 3) + (this.dynamic_Y_RES >> 2);
                    x = this.dynamic_X_RES - (this.dynamic_X_RES >> 4) - (this.dynamic_X_RES >> 4) - w1 + 10;
                    num16 = y1;
                    break;
                  case 4:
                    x = this.dynamic_X_RES - (this.dynamic_X_RES >> 4) - (this.dynamic_X_RES >> 4) - w1 - 190;
                    num16 = y1;
                    break;
                  case 5:
                    num16 = y1;
                    break;
                }
                this.debug_text((mrGame.MrGame.MrgString) ("y>>>>>> = " + (object) y1));
                y1 = num16;
              }
            }
            this.debug_text((mrGame.MrGame.MrgString) ("adding button at y=" + (object) y1));
            this.eg_addTextButton(visibleMenuElement, this.p_allTexts[index], pos_align, component_align, x, y1 + num14, w1, h);
            this.eg_setKeypadFocusable(visibleMenuElement, false);
          }
          if (menuId == 1 && visibleMenuElement != 10 && visibleMenuElement != 5 && visibleMenuElement != 29 && visibleMenuElement != 30)
            y1 += h / 2 + h / 3;
          else
            y1 += h + 12;
        }
        int visibleMenuElement1 = this.em_getVisibleMenuElement(menuId, 0);
        this.menuBottomY = y1;
        this.eg_setVerticalMenuMode(true);
        this.eg_enableAutoScroll(this.p_menu_canScrollDown(menuId));
        this.eg_listenKeyPresses(true);
        this.eg_enableWrapping(true);
        this.debug_text((mrGame.MrGame.MrgString) ("saved element idx: " + (object) this.p_em_pointerStack[this.p_em_stackPos]));
        if (this.p_em_pointerStack[this.p_em_stackPos] != -1)
          this.doj_eg_setFocus(this.p_em_pointerStack[this.p_em_stackPos]);
        else
          this.doj_eg_setFocus(visibleMenuElement1);
      }
      if (this.em_getMenuType(menuId) == 1 || this.em_getMenuType(menuId) == 4)
      {
        int y = 83 + this.gfx_getFontHeight(3);
        int num19 = this.dynamic_Y_RES - 76 - 57;
        int x1 = this.dynamic_X_RES >> 5;
        int num20 = this.dynamic_X_RES - (this.dynamic_X_RES >> 5);
        if (menuId == 3)
        {
          int x2 = x1 + 8;
          int num21 = num20 - 8;
          this.menu_createHighscoresTB(3, x2, y, num21 - x2, num19 - y, 0, 0, 8);
        }
        else if (!(this.em_getCurrentMenuText() == (mrGame.MrGame.MrgString) null))
          this.p_tb_makeBordered(3, this.em_getCurrentMenuText(), x1, y, num20 - x1, num19 - y, 0, 0, 8, true);
        this.p_tb_handleInput(-1, true);
      }
      if (menuId == 14)
      {
        this.eg_reset();
        this.eg_listenKeyPresses(false);
        this.mrg_resetKeys();
        this.multiplayer_enabled = true;
        int fontHeight = this.gfx_getFontHeight(3);
        int h1 = fontHeight * 5 >> 1;
        int num22 = this.dynamic_X_RES - (this.dynamic_X_RES >> 5) - (this.dynamic_X_RES >> 5);
        int num23 = 84 + (num22 >> 2);
        int x = (this.dynamic_X_RES >> 1) - (num22 >> 1) + (num23 >> 1);
        int w3 = num22 - num23;
        int y2 = 32 + 83 + this.gfx_getFontHeight(3);
        this.eg_addSelector(1009, 0, 6, this.multiplayer_maxplayers - 1, false, 5, 20, x, y2, w3, h1);
        this.eg_setKeypadFocusable(1009, false);
        int y3 = y2 + (h1 + 12);
        int id = 36;
        int index = (int) this.p_indexTable2[1509 + (id * 4 + 3)];
        int num24 = this.gfx_stringWidth(3, this.p_allTexts[index]);
        int w4 = (num24 > 120 ? num24 : 120) + (this.dynamic_X_RES >> 3);
        int num25 = fontHeight * 3 >> 1;
        int h2 = num25 > 57 ? num25 : 57;
        this.eg_addTextButton(id, this.p_allTexts[index], 17, 17, 0, y3, w4, h2);
        this.doj_eg_setFocus(1009);
        this.multiplayer_loadState();
        if (this.multiplayer_loadingState)
        {
          this.eg_reset();
          this.p_em_gotoGame = true;
          return;
        }
        this.eg_setVerticalMenuMode(true);
        this.eg_listenKeyPresses(true);
      }
      if (menuId == 7)
      {
        this.eg_reset();
        this.eg_listenKeyPresses(false);
        this.mrg_resetKeys();
        int y = 83 + this.gfx_getFontHeight(3);
        int num26 = this.dynamic_Y_RES - 76 - 52;
        int x = (this.dynamic_X_RES >> 5) + 8;
        int num27 = this.dynamic_X_RES - (this.dynamic_X_RES >> 5) - 8;
        this.menu_createStatsTB(3, x, y, num27 - x, num26 - y, 0, 0, 8);
      }
      if (menuId == 15)
      {
        this.eg_reset();
        this.eg_listenKeyPresses(false);
        this.mrg_resetKeys();
        int num = 57;
        int y4 = 12 + (this.dynamic_Y_RES >> 10) + 83;
        int margin = 32;
        this.menu_addTextButton(1004, this.p_allTexts[89], 17, 17, 0, y4);
        this.doj_eg_setFocus(1004);
        int y5 = y4 + (12 + num);
        this.menu_addTextButton(1008, this.p_allTexts[95], 17, 17, 0, y5);
        int y6 = y5 + (12 + num);
        this.menu_createMultiplayerScoresTB(margin, y6);
        this.eg_setVerticalMenuMode(true);
      }
      if (menuId == 16)
        this.leaderboards_createGui();
      if (menuId == 17)
        this.achievement_createGui();
      if (this.em_getBackKeyHint() == -1 || menuId == 0 || menuId == 2 || menuId == 15)
        return;
      int num28 = this.gfx_getFontHeight(3) + 4;
      int h3 = num28 > 57 ? num28 : 57;
      int num29 = 76;
      if (menuId == 0)
      {
        num29 = 168;
        if (120 > this.gfx_stringWidth(3, this.p_allTexts[this.em_getBackKeyHint()]) + 30 + 30)
          ;
        this.eg_addTextButton(1019, this.p_allTexts[this.em_getBackKeyHint()], 5, 24, this.dynamic_X_RES - 1, 1, 48, 48, true);
      }
      else
      {
        int num30 = 20;
        this.eg_addTextButton(1003, this.p_allTexts[this.em_getBackKeyHint()], 5, 24, this.dynamic_X_RES - 16, this.dynamic_Y_RES - h3 - num30, (this.dynamic_X_RES >> 1) - 32, h3, true);
      }
      this.eg_setElementStatic(1003, true);
    }

    public void emi_event(int menuId, int _event, int param)
    {
      switch (_event)
      {
        case 0:
          this.p_tb_handleInput(0, true);
          this.mrg_resetKeys();
          this.eg_reset();
          this.dojmenu_createGui(menuId);
          if (menuId != 0 || this.doj_initialMenu == 0)
            break;
          this.em_pushMenu(this.doj_initialMenu);
          this.doj_initialMenu = 0;
          break;
        case 1:
          this.mrg_resetKeys();
          this.em_storeActiveElement(this.eg_getFocusElementId());
          bool flag = param != 0;
          this.eg_reset();
          if (menuId == 2)
          {
            int num1 = flag ? 1 : 0;
          }
          if (menuId != 15)
            break;
          this.multiplayer_clearState(true);
          break;
        case 2:
          this.em_storeActiveElement(this.eg_getFocusElementId());
          this.eg_reset();
          int fontHeight = this.gfx_getFontHeight(3);
          int num2 = fontHeight + 8;
          int h = num2 > 57 ? num2 : 57;
          int y = 83 + (fontHeight << 1) + 12;
          this.eg_addTextButton(1000, this.p_allTexts[2], 17, 17, 0, y, this.dynamic_X_RES >> 1, h);
          this.eg_addTextButton(1001, this.p_allTexts[3], 17, 17, 0, y + (h + 12), this.dynamic_X_RES >> 1, h);
          this.eg_bindAction(1001, 196611, 0);
          this.eg_enableAutoScroll(true);
          this.eg_listenKeyPresses(true);
          this.eg_enableWrapping(true);
          this.doj_eg_setFocus(1001);
          break;
        case 3:
          this.eg_reset();
          this.debug_text((mrGame.MrGame.MrgString) ("menu intro = " + (object) this.menu_intro));
          if (this.menu_intro)
            break;
          this.dojmenu_createGui(menuId);
          break;
        default:
          this.debug_text((mrGame.MrGame.MrgString) "Unhandled menu event");
          break;
      }
    }

    public void emi_paint(int menuId)
    {
      if (this.p_em_selectLanguageActive)
      {
        this.gfx_setColor(16052202);
        this.gfx_fillRect(0, 0, this.dynamic_X_RES, this.dynamic_Y_RES);
        this.eg_paint();
        if (this.eg_canScrollUp())
        {
          int num1 = 16;
          int x0 = this.dynamic_X_RES - (num1 << 2);
          int num2 = 63;
          this.gfx_setColor(0);
          this.gfx_fillTriangle(x0, num2, x0 + num1, num2 - num1, x0 + (num1 << 1), num2);
        }
        if (!this.eg_canScrollDown())
          return;
        int num3 = 16;
        int x0_1 = this.dynamic_X_RES - (num3 << 2);
        int num4 = this.dynamic_Y_RES - 83 + 20;
        this.gfx_setColor(0);
        this.gfx_fillTriangle(x0_1, num4, x0_1 + num3, num4 + num3, x0_1 + (num3 << 1), num4);
      }
      else
      {
        int dynamicYRes = this.dynamic_Y_RES;
        if (menuId != 2 && menuId != 1024)
        {
          this.gfx_setColor(0);
          this.gfx_fillRect(0, this.dynamic_Y_RES - 90, this.dynamic_X_RES, 90);
          int num = 76;
          if (menuId == 0)
            num = 91;
          if (menuId == 0)
            dynamicYRes -= num;
        }
        for (int y = dynamicYRes; y > 0; y -= 126)
          this.gfx_drawImage(1, 0, y, 36, 0);
        for (int y = dynamicYRes; y > 0; y -= 126)
        {
          for (int x = 39; x < this.dynamic_X_RES; x += 441)
            this.gfx_drawImage(0, x, y, 36, 0);
        }
        if ((menuId == 0 || menuId == 1 || menuId == 14 || menuId == 5 || menuId == 6 || menuId == 13 || menuId == 16 || menuId == 17) && !this.p_em_confirming && !this.p_inGame)
        {
          if (menuId == 0)
          {
            this.gfx_drawImage(759, this.dynamic_X_RES >> 4, 26, 20, 0);
            this.gfx_drawImage(2, this.dynamic_X_RES - 141, this.dynamic_Y_RES / 2 + 14 - 38, 36, 0);
            this.gfx_drawImage(760, this.dynamic_X_RES - ((this.dynamic_X_RES >> 1) - (this.dynamic_X_RES >> 4)), (this.dynamic_Y_RES >> 2) - 33 + 10, 24, 0);
            this.gfx_drawImage(761, 24, (this.dynamic_Y_RES >> 1) - (this.dynamic_Y_RES >> 3) + 23, 20, 0);
            this.gfx_drawImage(762, (this.dynamic_X_RES >> 3) + (this.dynamic_X_RES >> 3) + 40, (this.dynamic_Y_RES >> 1) - (this.dynamic_Y_RES >> 3) + (this.dynamic_Y_RES >> 3), 20, 0);
            this.gfx_drawImage(763, this.dynamic_X_RES - (this.dynamic_X_RES >> 3), (this.dynamic_Y_RES >> 1) - (this.dynamic_Y_RES >> 3) + (this.dynamic_Y_RES >> 3) + (this.dynamic_Y_RES >> 2), 24, 0);
          }
          else
          {
            this.gfx_drawImage(759, this.dynamic_X_RES >> 4, 13, 20, 0);
            this.gfx_drawImage(759, this.dynamic_X_RES - ((this.dynamic_X_RES >> 4) + (this.dynamic_X_RES >> 5)), 0, 24, 0);
            this.gfx_drawImage(760, this.dynamic_X_RES - (this.dynamic_X_RES >> 5), 83, 24, 0);
            this.gfx_drawImage(763, this.dynamic_X_RES - (this.dynamic_X_RES >> 3), 41, 24, 0);
          }
        }
        if (menuId != 1024 && (this.em_getMenuType(menuId) == 1 || this.em_getMenuType(menuId) == 4 || menuId == 15 || menuId == 10 || menuId == 11 || menuId == 12 || menuId == 7) && !this.p_em_confirming && !this.p_inGame)
        {
          this.gfx_drawImage(759, this.dynamic_X_RES - ((this.dynamic_X_RES >> 4) + (this.dynamic_X_RES >> 5)), 0, 24, 0);
          this.gfx_drawImage(760, this.dynamic_X_RES - (this.dynamic_X_RES >> 5), 83, 24, 0);
          this.gfx_drawImage(763, this.dynamic_X_RES - (this.dynamic_X_RES >> 3), 41, 24, 0);
        }
        if (menuId == 0 || menuId == 1 || menuId == 3 || menuId == 14 || menuId == 15 || menuId == 9 || menuId == 8 || menuId == 2 || menuId == 7 || menuId == 5 || menuId == 6 || menuId == 13 || menuId == 16 || menuId == 17 && menuId != 1024)
        {
          int y = 0;
          if (menuId == 0)
            y = 52;
          this.gfx_drawImage(35, 0, y, 20, 0);
          if (menuId != 0 && menuId != 15)
          {
            this.gfx_setColor(0);
            this.gfx_drawString(3, this.p_allTexts[this.em_getMenuTopic(menuId)].toLowerCase(), this.dynamic_X_RES - 76, 73, 24);
          }
        }
        if (menuId == 16)
          this.leaderboards_paint();
        if (menuId == 17)
          this.achievement_paint();
        if (menuId != 1024 && (this.em_getMenuType(menuId) == 1 || this.em_getMenuType(menuId) == 4 || menuId == 11 || menuId == 12 || menuId == 7 || menuId == 15))
        {
          this.gfx_setColor(0);
          this.tb_drawEx(this.p_tbFont, this.p_tbTextX, this.p_tbTextY, this.p_tb_scroll >> 10);
          this.drawTextBoxArrows();
        }
        if (this.p_em_confirming)
        {
          this.gfx_setColor(0);
          int fontHeight = this.gfx_getFontHeight(3);
          this.gfx_drawString(3, this.p_em_confirmText.toLowerCase(), this.dynamic_X_RES >> 1, fontHeight + 83 + 12, 17);
        }
        if (menuId == 15)
          this.menu_drawMultiplayerFinal();
        this.eg_paint();
        if (menuId == 0)
        {
          int imageindex = 30;
          int num = 90;
          for (int x = 0; x < this.dynamic_X_RES; x += 76)
          {
            this.gfx_drawImage(imageindex, x, this.dynamic_Y_RES - num - 15, 20, 0);
            ++imageindex;
            if (imageindex > 32)
              imageindex = 30;
          }
        }
        if ((menuId == 0 || menuId == 1 || menuId == 14 || menuId == 5 || menuId == 6 || menuId == 13) && !this.p_em_confirming && !this.p_inGame && menuId == 0)
        {
          this.platforms_draw();
          this.character_draw();
          this.objects_draw();
        }
        if (this.p_em_confirming)
          return;
        if (this.eg_canScrollUp())
          this.gfx_drawImage(18, this.dynamic_X_RES >> 1, this.p_menu_getUpScrollParameter(false, menuId), this.p_menu_getUpScrollParameter(true, menuId), 0);
        if (!this.p_menu_canScrollDown(menuId))
          return;
        this.gfx_drawImage(17, this.dynamic_X_RES >> 1, this.p_menu_getDownScrollParameter(false, menuId), this.p_menu_getDownScrollParameter(true, menuId), 0);
      }
    }

    public bool p_menu_canScrollDown(int menuId)
    {
      switch (menuId)
      {
        case 0:
          return this.menuBottomY > this.p_eg_areaY + this.p_eg_areaH && this.eg_canScrollDown();
        case 15:
          return this.menuBottomY > this.p_eg_areaY + this.p_eg_areaH;
        default:
          return this.eg_canScrollDown();
      }
    }

    public int p_menu_getUpScrollParameter(bool getAlign, int menuId)
    {
      int num1 = 83;
      if (menuId == 1)
      {
        int num2 = num1 + this.gfx_getFontHeight(3);
      }
      int num3;
      int num4;
      if (menuId == 1)
      {
        num3 = this.p_eg_areaY - this.gfx_getFontHeight(3);
        num4 = 33;
      }
      else
      {
        num3 = this.dynamic_Y_RES >> 5;
        num4 = 17;
      }
      if (menuId == 14 || menuId == 15 || menuId == 11 || menuId == 12)
      {
        num3 = this.p_tbBorderY - 1;
        if (menuId == 15)
          num3 -= (this.gfx_getFontHeight(3) << 1) / 3;
      }
      if (this.p_em_selectLanguageActive && menuId == 4)
        num3 = 63;
      return !getAlign ? num3 : num4;
    }

    public int p_menu_getDownScrollParameter(bool getAlign, int menuId)
    {
      int num1 = this.p_eg_areaY + this.p_eg_areaH + 3;
      int num2 = 17;
      if (this.em_getMenuType(menuId) == 1 || this.em_getMenuType(menuId) == 4 || menuId == 14 || menuId == 15 || menuId == 7 || menuId == 3 || menuId == 11 || menuId == 12)
        num1 = this.p_tbBorderY + this.p_tbBorderHeight + 1;
      if (this.p_em_selectLanguageActive && menuId == 4)
        num1 = this.dynamic_Y_RES - 83 + 20;
      return !getAlign ? num1 : num2;
    }

    public void p_menu_drawSoftKeysAtBottom(
      int softKey1Text,
      bool focused1,
      int softKey2Text,
      bool focused2)
    {
      if (softKey1Text >= 0)
        this.p_menu_drawSoftKey(softKey1Text, focused1, 0);
      if (softKey2Text < 0)
        return;
      this.p_menu_drawSoftKey(softKey2Text, focused2, 1);
    }

    public void p_menu_drawSoftKeysAtRight(
      int softKey1Text,
      bool focused1,
      int softKey2Text,
      bool focused2)
    {
      if (softKey1Text >= 0)
        this.p_menu_drawSoftKey(softKey1Text, focused1, 1);
      if (softKey2Text < 0)
        return;
      this.p_menu_drawSoftKey(softKey2Text, focused2, 2);
    }

    public void p_menu_drawSoftKey(int softKeyText, bool focused, int position)
    {
      if (softKeyText < 0)
        return;
      if (softKeyText == 17)
      {
        this.p_menu_drawPauseIcon(position, focused);
      }
      else
      {
        int softKeyButtonWidth = this.p_menu_getSoftKeyButtonWidth(softKeyText);
        int y = position == 0 || position == 1 ? this.dynamic_Y_RES - this.gfx_getFontHeight(3) - (this.dynamic_X_RES >> 5) : 0;
        int x = position != 0 ? this.dynamic_X_RES - softKeyButtonWidth - 1 : 0;
        this.menu_buttonPaint(this.p_allTexts[softKeyText], x, y, softKeyButtonWidth, this.gfx_getFontHeight(3) + (this.dynamic_Y_RES >> 6), focused, true);
      }
    }

    public int p_menu_getSoftKeyButtonWidth(int softKeyText)
    {
      int softKeyButtonWidth = this.gfx_stringWidth(3, this.p_allTexts[softKeyText]) + 60;
      if (softKeyButtonWidth < 120)
        softKeyButtonWidth = 120;
      return softKeyButtonWidth;
    }

    public void p_menu_drawPauseIcon(int position, bool focused)
    {
      int x = 0;
      int y = 0;
      int align = 0;
      switch (position)
      {
        case 0:
          x = (this.dynamic_X_RES >> 4) + (this.doj_screen_fp_posX >> 11);
          y = this.dynamic_Y_RES;
          align = 36;
          break;
        case 1:
          x = this.dynamic_X_RES - (this.dynamic_X_RES >> 4) - (this.doj_screen_fp_posX >> 11);
          y = this.dynamic_Y_RES;
          align = 40;
          break;
      }
      this.gfx_drawImage(885, x, y, align, 0);
    }

    public int egi_moveFocus(int id, int dx, int dy)
    {
      int pEmMenu = !this.p_game_menuInited || this.p_em_stackPos < 0 ? 0 : this.p_em_menuStack[this.p_em_stackPos];
      int ofVisibleElements = this.em_getAmountOfVisibleElements(pEmMenu);
      if (dx + dy > 0)
      {
        for (int n = 0; n < ofVisibleElements - 1; ++n)
        {
          if (id == this.em_getVisibleMenuElement(pEmMenu, n))
            return this.em_getVisibleMenuElement(pEmMenu, n + 1);
        }
        if (id == this.em_getVisibleMenuElement(pEmMenu, ofVisibleElements - 1))
          return this.em_getBackKeyHint() != -1 && pEmMenu != 2 ? 1003 : this.em_getVisibleMenuElement(pEmMenu, 0);
        if (id == 1003)
          return this.em_getVisibleMenuElement(pEmMenu, 0);
      }
      else if (dx + dy < 0)
      {
        for (int n = 1; n < ofVisibleElements; ++n)
        {
          if (id == this.em_getVisibleMenuElement(pEmMenu, n))
            return this.em_getVisibleMenuElement(pEmMenu, n - 1);
        }
        if (id == this.em_getVisibleMenuElement(pEmMenu, 0))
          return this.em_getBackKeyHint() != -1 && pEmMenu != 2 ? 1003 : this.em_getVisibleMenuElement(pEmMenu, ofVisibleElements - 1);
        if (id == 1003)
          return this.em_getVisibleMenuElement(pEmMenu, ofVisibleElements - 1);
      }
      return -1;
    }

    public void textinput_paint()
    {
      this.gfx_setColor(16052202);
      this.gfx_fillRect(0, 0, this.dynamic_X_RES, this.dynamic_Y_RES);
      switch (this.doj_textInputMode)
      {
        case 1:
          if (this.doj_gameOver)
          {
            int num1 = (this.dynamic_Y_RES >> 4) + (this.doj_screen_fp_posX >> 11);
            this.doj_DrawGameBackground();
            this.doj_DrawGameForeground();
            this.doj_DrawHud();
            this.doj_DrawBorders();
            int h = (this.gfx_getFontHeight(3) >> 1 << 3) + 54;
            int y1 = (this.dynamic_Y_RES >> 1) - (h >> 1);
            int x1 = num1;
            int w = this.dynamic_X_RES - (num1 << 1);
            int num2 = 27;
            int num3 = (h - (num2 << 1)) / 3;
            this.popup_drawTutorial(x1, y1, w, h, 766, 774);
            int num4 = y1 + num2 + num3;
            int x0 = x1 + num2;
            int clipX = this.gfx_getClipX();
            int clipY = this.gfx_getClipY();
            int clipW = this.gfx_getClipW();
            int clipH = this.gfx_getClipH();
            this.gfx_setClip(x0, num4, w - (num2 << 1), h - (num2 << 1));
            this.gfx_setColor(0);
            this.gfx_drawString(3, this.p_textinputCaption, this.dynamic_X_RES >> 1, num4, 17);
            int y2 = num4 + num3;
            int x2 = this.dynamic_X_RES - this.gfx_stringWidth(3, this.p_textinputString) >> 1;
            if (this.cursorBlink)
            {
              this.gfx_setColor(0);
              this.gfx_drawString(3, this.p_textinputString, x2, y2, 20);
            }
            else
            {
              this.gfx_setColor(0);
              this.gfx_drawString(3, this.p_textinputString + (mrGame.MrGame.MrgString) "_", x2, y2, 20);
            }
            this.gfx_setClip(clipX, clipY, clipW, clipH);
            break;
          }
          break;
        case 2:
          if (this.multiplayer_enabled)
          {
            int num = this.dynamic_Y_RES >> 4;
            this.emi_paint(14);
            this.eg_skipPaint();
            int h = this.gfx_getFontHeight(3) << 2;
            int y3 = (this.dynamic_Y_RES >> 1) - (this.dynamic_Y_RES >> 3) + (num << 1);
            int x3 = num;
            this.popup_drawBack(x3, y3, this.dynamic_X_RES - (num << 1), h);
            int y4 = y3 + 27;
            int x4 = x3 + 27;
            this.gfx_setColor(0);
            this.gfx_drawString(3, this.p_textinputCaption, x4, y4, 20);
            int y5 = y4 + this.gfx_getFontHeight(3);
            if (this.cursorBlink)
            {
              this.gfx_setColor(0);
              this.gfx_drawString(3, this.p_textinputString, x4, y5, 20);
              break;
            }
            this.gfx_setColor(0);
            this.gfx_drawString(3, this.p_textinputString + (mrGame.MrGame.MrgString) "_", x4, y5, 20);
            break;
          }
          break;
        default:
          this.debug_text((mrGame.MrGame.MrgString) "Unknown input type");
          break;
      }
      this.menu_paintSoftkeys(this.p_textinputOkLabel, 106);
    }

    public void menu_paintSoftkeys(int softKey1Text, int softKey2Text)
    {
      bool flag1 = this.mrg_isPointerOnSoftkey1();
      bool flag2 = this.mrg_isPointerOnSoftkey2();
      bool flag3 = true;
      bool flag4 = true;
      if (flag3)
      {
        if (flag4)
          this.p_menu_drawSoftKeysAtBottom(softKey2Text, flag2, softKey1Text, flag1);
        else
          this.p_menu_drawSoftKeysAtBottom(softKey1Text, flag1, softKey2Text, flag2);
      }
      else if (flag4)
        this.p_menu_drawSoftKeysAtRight(softKey2Text, flag2, softKey1Text, flag1);
      else
        this.p_menu_drawSoftKeysAtRight(softKey1Text, flag1, softKey2Text, flag2);
    }

    public void doj_drawMultiplayerGameOverScreen()
    {
      int elementHeight = this.eg_getElementHeight(1004);
      int y = this.eg_getElementY(1004) + elementHeight + 12;
      if (this.doj_score >= 0)
        this.p_doj_drawScoreWithLabel(this.p_allTexts[108], this.doj_score, y);
      this.tb_drawEx(this.p_tbFont, this.p_tbTextX, this.p_tbTextY, this.p_tb_scroll >> 10);
      this.drawTextBoxArrows();
    }

    public void drawTextBoxArrows()
    {
      int num = this.dynamic_X_RES >> 1;
      int x = (this.dynamic_X_RES >> 1) + (this.p_tbBorderWidth >> 1);
      if (x >= this.dynamic_X_RES - 30)
        x = this.dynamic_X_RES - 30 - 1;
      int y1 = this.p_tbBorderY - 1;
      int y2 = this.p_tbBorderY + this.p_tbBorderHeight + 1;
      if ((!this.p_game_menuInited || this.p_em_stackPos < 0 ? 0 : this.p_em_menuStack[this.p_em_stackPos]) == 15)
        y1 -= (this.gfx_getFontHeight(3) << 1) / 3;
      this.gfx_setColor(16763955);
      if (this.p_tb_scroll > 0)
        this.gfx_drawImage(18, x, y1, 33, 0);
      if (this.p_tb_lineCount <= 0 || this.p_tb_scroll >= (int) this.p_tb_lines[this.p_tb_lineCount - 1] << 10)
        return;
      this.gfx_drawImage(17, x, y2, 17, 0);
    }

    public void doj_drawGameOverScreen()
    {
      int elementHeight = this.eg_getElementHeight(1004);
      int num = 0;
      if (this.doj_fp_endGameYoff != 0)
        num += this.doj_worldToScreenY(this.doj_fp_endGameYoff);
      int y1 = num + 65;
      this.gfx_drawImage(36, this.dynamic_X_RES >> 1, y1, 17, 0);
      int y2 = y1 + 104;
      if (this.doj_score >= 0 && this.p_doj_drawScoreWithLabel(this.p_allTexts[108], this.doj_score, y2))
        y2 += this.gfx_getFontHeight(4);
      int y3 = y2 + ((elementHeight >> 1) + 12);
      int dojScore = this.hs_data_int[0];
      if (dojScore <= 0 || dojScore < this.doj_score)
        dojScore = this.doj_score;
      if (dojScore >= 0)
        this.p_doj_drawScoreWithLabel(this.p_allTexts[109], dojScore, y3);
      if (this.doj_gameOver)
        return;
      this.platforms_draw();
      this.character_draw();
      this.objects_draw();
      this.doj_DrawGameForeground();
    }

    public bool p_doj_drawScoreWithLabel(mrGame.MrGame.MrgString label_, int score, int y)
    {
      label_ = label_.toLowerCase();
      mrGame.MrGame.MrgString str = (mrGame.MrGame.MrgString) (" " + (object) score);
      int num1 = this.gfx_stringWidth(3, label_);
      int num2 = this.gfx_stringWidth(4, str);
      int x1 = (this.dynamic_X_RES >> 1) - (num1 + num2) / 2;
      if (num1 + num2 > this.dynamic_X_RES)
      {
        this.gfx_setColor(0);
        int x2 = (this.dynamic_X_RES >> 1) - num1 / 2;
        this.gfx_drawString(3, label_, x2, y, 20);
        int x3 = (this.dynamic_X_RES >> 1) - num2 / 2;
        y += this.gfx_getFontHeight(4);
        this.gfx_drawString(4, str, x3, y, 20);
        return true;
      }
      this.gfx_setColor(0);
      this.gfx_drawString(3, label_, x1, y, 20);
      this.gfx_drawString(4, str, x1 + num1, y, 20);
      return false;
    }

    public void menu_drawMultiplayerFinal()
    {
      int y = 95 + (12 + 57 << 1);
      mrGame.MrGame.MrgString lowerCase = this.txt_stringParam(this.p_allTexts[97], this.hs_data_string[0], 1).toLowerCase();
      this.gfx_setColor(0);
      this.gfx_drawString(3, lowerCase, this.dynamic_X_RES >> 1, y, 17);
    }

    public void doj_startEndGame()
    {
      if (this.doj_endGameSeq || this.multiplayer_enabled)
        return;
      this.doj_endGameSeq = true;
      this.p_menu_createSingleplayerEndGameMenu();
      this.eg_listenKeyPresses(false);
      this.doj_fp_endGameYoff = -983040;
    }

    public void doj_endGame()
    {
      this.sfx_stopAll();
      this.doj_endGameSeq = false;
      if (this.doj_gameOver && !this.multiplayer_loadingState)
        return;
      this.debug_text((mrGame.MrGame.MrgString) "End game");
      this.doj_gameOver = true;
      this.doj_stopWarningSounds();
      this.mrg_stopAccelerationSensor();
      this.mrg_resetKeys();
      this.eg_reset();
      this.stats_gameEnded();
      this.achievement_save();
      if (this.multiplayer_enabled)
      {
        this.eg_listenKeyPresses(false);
        int val = -1;
        if (!this.multiplayer_loadingState)
        {
          int num1 = this.dynamic_Y_RES >> 10;
          int margin = 32;
          int num2 = 12 + num1 + 69 + 69;
          this.mrg_resetKeys();
          this.doj_textInputMode = 1;
          this.eg_lockGui(true);
          this.multiplayer_setCurrentPlayerName(this.mrp_textinput(this.p_allTexts[91].toLowerCase(), this.multiplayer_getCurrentPlayerName(), 107, 8, 0));
          this.eg_lockGui(false);
          this.highscores_multi_add(this.multiplayer_getCurrentPlayerName(), this.doj_score);
          this.multiplayer_saveState();
          if (this.multiplayer_player == this.multiplayer_maxplayers)
          {
            this.egi_eventPressed(38);
          }
          else
          {
            val = this.p_menu_createMultiplayerEndGameMenu();
            this.mrg_resetKeys();
            int y = num2 + 81;
            this.menu_createMultiplayerScoresTB(margin, y);
          }
        }
        else
          val = this.p_menu_createMultiplayerEndGameMenu();
        this.doj_eg_setFocus(val);
        this.mrg_resetKeys();
      }
      else
      {
        bool flag = false;
        for (int index = 0; index < 10; ++index)
        {
          if (this.doj_score > this.hs_data_int[index])
          {
            flag = true;
            break;
          }
        }
        if (flag)
        {
          this.eg_listenKeyPresses(false);
          this.mrg_resetKeys();
          this.doj_textInputMode = 1;
          this.eg_lockGui(true);
          if (this.highscores_playerName.equals((mrGame.MrGame.MrgString) ""))
            this.highscores_playerName = this.mrp_textinput(this.p_allTexts[91].toLowerCase(), this.highscores_playerName, 107, 8, 0);
          this.eg_lockGui(false);
          this.mrg_resetKeys();
        }
        this.p_menu_createSingleplayerEndGameMenu();
        this.eg_listenKeyPresses(true);
        this.eg_setVerticalMenuMode(true);
        this.eg_enableWrapping(true);
        this.doj_eg_setFocus(1005);
      }
    }

    public void menu_reinitializeEndGameMenu()
    {
      this.eg_reset();
      if (this.multiplayer_enabled)
      {
        this.doj_eg_setFocus(this.p_menu_createMultiplayerEndGameMenu());
      }
      else
      {
        this.p_menu_createSingleplayerEndGameMenu();
        this.eg_listenKeyPresses(true);
        this.doj_eg_setFocus(1005);
      }
    }

    public void p_menu_createSingleplayerEndGameMenu()
    {
      int num1 = this.dynamic_Y_RES >> 10;
      this.gfx_getFontHeight(3);
      this.debug_text((mrGame.MrGame.MrgString) "*** eg_setarea() #9");
      this.eg_setArea(0, 0, this.dynamic_X_RES, this.dynamic_Y_RES);
      int num2 = 0 + 104 + 65;
      int num3 = this.gfx_getFontHeight(3) + (this.dynamic_X_RES >> 5);
      int num4 = num3 > 57 ? num3 : 57;
      int y1 = num2 + ((num4 >> 1) + 12 << 1);
      this.menu_addTextButton(1007, this.p_allTexts[91].toLowerCase(), 17, 17, 0, y1);
      this.debug_text((mrGame.MrGame.MrgString) "=========== eg_setKeypadFocusable false ===============");
      this.eg_setKeypadFocusable(1007, false);
      int num5 = y1 + 69;
      int num6 = this.dynamic_Y_RES - 76 - num5 - 138 >> 2;
      int num7 = this.eg_getElementY(1007) + this.p_menu_getTextButtonHeight();
      int y2 = num5 + 12 + num6;
      int y3 = num5 + (69 + num6) + 12 + (num6 >> 1);
      int num8 = y3 + this.p_menu_getTextButtonHeight() - y2;
      if (this.dynamic_Y_RES - num7 - num8 >= 30)
      {
        this.doj_showTapToChangeImage = true;
        int num9 = num7 + 30;
        if (num9 > y2)
        {
          int num10 = num9 - y2;
          y2 += num10;
          y3 += num10;
        }
      }
      else
        this.doj_showTapToChangeImage = false;
      this.menu_addTextButton(1005, this.p_allTexts[90], 17, 17, 0, y2);
      this.eg_setKeypadFocusable(1005, false);
      this.menu_addTextButton(1004, this.p_allTexts[89], 5, 17, this.dynamic_X_RES - (this.dynamic_X_RES >> 2) - (this.doj_screen_fp_posX >> 11 >> 1) - (this.dynamic_X_RES >> 4), y3);
      this.eg_setKeypadFocusable(1004, false);
    }

    public int p_menu_createMultiplayerEndGameMenu()
    {
      int margin = 32;
      this.gfx_getFontHeight(3);
      int num = 12 + (this.dynamic_Y_RES >> 10);
      int multiplayerEndGameMenu = -1;
      this.debug_text((mrGame.MrGame.MrgString) "*** eg_setArea() #8");
      this.eg_setArea(0, 0, this.dynamic_X_RES, this.dynamic_Y_RES);
      this.eg_setVerticalMenuMode(true);
      int y1 = num + 65;
      this.doj_eg_setFocus(1004);
      if (this.multiplayer_player < this.multiplayer_maxplayers)
      {
        this.menu_addTextButton(1006, this.p_allTexts[94], 17, 17, 0, y1);
      }
      else
      {
        this.menu_addTextButton(38, this.p_allTexts[105], 17, 17, 0, y1);
        multiplayerEndGameMenu = 38;
      }
      int y2 = y1 + 69;
      this.menu_addTextButton(1004, this.p_allTexts[89], 17, 17, 0, y2);
      int y3 = y2 + 69;
      this.menu_createMultiplayerScoresTB(margin, y3);
      return multiplayerEndGameMenu;
    }

    public void doj_eg_setFocus(int val)
    {
    }

    public void menu_createStatsTB(
      int font,
      int x,
      int y,
      int width,
      int height,
      int borderWidth,
      int borderHeight,
      int crop)
    {
      this.debug_text((mrGame.MrGame.MrgString) ("create stats text box: " + (object) font + " " + (object) x + " " + (object) y + " " + (object) height + " " + (object) borderHeight + " " + (object) borderWidth + " " + (object) crop));
      mrGame.MrGame.MrgString tbContent = this.stats_createTBContent();
      this.debug_text(tbContent);
      this.p_tb_makeBordered(font, tbContent, x, y, width, height, borderWidth, borderHeight, crop, true);
      this.p_tb_handleInput(-1, true);
    }

    public void menu_createMultiplayerScoresTB(int margin, int y)
    {
      int num1 = margin;
      int num2 = margin;
      int x = num1 + (this.doj_screen_fp_posX >> 11);
      this.hs_queryPlace(1, 0);
      mrGame.MrGame.MrgString text = (mrGame.MrGame.MrgString) "";
      for (int index = 0; index <= this.multiplayer_maxplayers; ++index)
      {
        mrGame.MrGame.MrgString highscoreLine = this.menu_createHighscoreLine(index + 1, this.hs_data_int[index], this.hs_data_string[index]);
        text += highscoreLine;
      }
      int num3 = 0;
      int width = this.dynamic_X_RES - (x << 1);
      int height = this.dynamic_Y_RES - y - num2 * 2 - 29 - 29 - num3;
      this.p_tb_makeBordered(3, text, x, y + 29 + num3, width, height, 0, 0, 8, true);
      this.p_tb_handleInput(-1, true);
    }

    public void menu_createHighscoresTB(
      int font,
      int x,
      int y,
      int width,
      int height,
      int borderWidth,
      int borderHeight,
      int crop)
    {
      this.hs_queryPlace(0, 0);
      mrGame.MrGame.MrgString text = (mrGame.MrGame.MrgString) "";
      for (int index = 0; index < 10; ++index)
      {
        mrGame.MrGame.MrgString highscoreLine = this.menu_createHighscoreLine(index + 1, this.hs_data_int[index], this.hs_data_string[index]);
        text += highscoreLine;
      }
      this.p_tb_makeBordered(font, text, x, y, width, height, borderWidth, borderHeight, crop, true);
      this.p_tb_handleInput(-1, true);
    }

    public mrGame.MrGame.MrgString menu_createHighscoreLine(
      int place,
      int score,
      mrGame.MrGame.MrgString name)
    {
      return this.txt_stringParam(this.txt_stringParam(this.txt_stringParam(this.p_allTexts[96], (mrGame.MrGame.MrgString) string.Concat((object) place), 1), name, 2), score == -1 ? (mrGame.MrGame.MrgString) "\n" : this.txt_addThousandSeparator_s(score, this.p_allTexts[46]), 3);
    }

    public void emi_logic(int menuId)
    {
      if (!this.p_gameDisplay && this.p_inGame)
        this.doj_isInGameMenu = true;
      if (this.p_em_selectLanguageActive)
        return;
      if (this.character_fp_posX == this.platforms_array[this.platforms_begin].fp_x && menuId == 0 && !this.p_em_confirming && !this.p_inGame)
        this.physics_menu();
      if (menuId != 16)
        return;
      this.leaderboards_update();
    }

    public void customization_gameUnlocked()
    {
      this.eg_reset();
      this.dojmenu_createGui(!this.p_game_menuInited || this.p_em_stackPos < 0 ? 0 : this.p_em_menuStack[this.p_em_stackPos]);
    }

    public void emi_gameAction(int elementId)
    {
      if (elementId == 36)
        this.p_em_gotoGame = true;
      if (elementId == 12)
      {
        this.p_em_gotoGame = true;
        this.sfx_stopAll();
        this.game_exit();
      }
      if (elementId == 10)
      {
        this.menu_resetGame();
        this.achievement_reset();
      }
      if (elementId != 5)
        return;
      this.p_hs_reset(0);
    }

    public void menu_resetGame()
    {
      this.p_options[6] = (sbyte) 1;
      this.tutorial_reset();
      this.p_options[8] = (sbyte) 1;
      this.p_hs_resetAll();
      this.multiplayer_reset();
      this.stats_reset();
      this.highscores_playerName = (mrGame.MrGame.MrgString) "";
      this.highscores_savePlayerName();
    }

    public void menu_reset()
    {
      this.platforms_reset();
      this.platforms_pushMenuPlatform();
      this.character_setMenuMode();
      this.menu_fp_time = 0;
      this.objects_pushMenuObject();
      this.doj_fp_screenYOffset = 0;
    }

    public void emi_keyPressed(int menuId, int keyCode)
    {
      if (menuId == 0 && this.mrg_isKey(keyCode, 10))
        this.menu_xbla_handleClearKeyMainMenu();
      if (!this.p_em_selectLanguageActive && this.mrg_isKey(keyCode, 262153) && !this.p_em_introMode)
      {
        if (menuId != 2 && menuId != 15)
          this.em_back();
        else if (!this.p_gameDisplay && this.p_inGame)
          this.p_em_gotoGame = true;
      }
      if (menuId == 0 && this.mrg_isKey(keyCode, 70))
        this.eg_slideLeft(25);
      if (menuId == 0 && this.mrg_isKey(keyCode, 71))
        this.eg_slideRight(25);
      this.menu_checkScrollArrowPress(keyCode, menuId);
    }

    public void menu_checkScrollArrowPress(int keyCode, int menuId)
    {
      if (!this.mrg_isKey(keyCode, 57))
        return;
      int upx = this.p_touchdata[this.p_mt_last].upx;
      int upy = this.p_touchdata[this.p_mt_last].upy;
      int num1 = this.gfx_getFontHeight(3) + 16;
      int num2 = (num1 > 57 ? num1 : 57) + 12;
      int num3 = this.p_menu_getUpScrollParameter(false, menuId);
      int downScrollParameter = this.p_menu_getDownScrollParameter(false, menuId);
      if (this.em_getMenuType(menuId) == 1 || this.em_getMenuType(menuId) == 4 || menuId == 7)
        num3 = this.p_tbBorderY - 1;
      bool flag1 = this.abs(upy - num3) <= 29;
      bool flag2 = this.abs(upy - downScrollParameter) <= 29;
      if (this.em_getMenuType(menuId) == 1 || this.em_getMenuType(menuId) == 4 || menuId == 7 || menuId == 14 || menuId == 15 || menuId == 11 || menuId == 12)
      {
        if (flag1)
        {
          this.debug_text((mrGame.MrGame.MrgString) "TXT scroll up");
          this.p_tb_changePage(3);
        }
        if (!flag2)
          return;
        this.debug_text((mrGame.MrGame.MrgString) "TXT scroll down");
        this.p_tb_changePage(1);
      }
      else
      {
        if (flag1 && this.eg_canScrollUp())
        {
          this.debug_text((mrGame.MrGame.MrgString) "scroll up");
          this.p_eg_guiScrollY += num2;
        }
        if (!flag2 || !this.p_menu_canScrollDown(menuId))
          return;
        this.debug_text((mrGame.MrGame.MrgString) "scroll down");
        this.p_eg_guiScrollY -= num2;
      }
    }

    public void menu_xbla_handleClearKeyMainMenu()
    {
      if (!this.menu_intro)
        return;
      this.mrg_exitApp();
    }

    public void emi_keyReleased(int menuId, int keyCode)
    {
      if ((!this.p_game_menuInited || this.p_em_stackPos < 0 ? 0 : this.p_em_menuStack[this.p_em_stackPos]) == 16 && this.mrg_isKey(keyCode, 57))
        this.leaderboards_pointerPressed();
      else if (!this.mrg_isKey(keyCode, 196608))
        ;
    }

    public void emi_optionNotify(int optionIndex)
    {
      if (optionIndex != 6)
        return;
      this.tutorial_reset();
    }

    public void menu_addTextButton(
      int id,
      mrGame.MrGame.MrgString text,
      int align1,
      int align2,
      int x,
      int y)
    {
      int num1 = this.dynamic_X_RES >> 4;
      int num2 = this.gfx_stringWidth(3, text) + num1;
      int w = (num2 > 120 ? num2 : 120) + (this.dynamic_X_RES >> 3);
      int textButtonHeight = this.p_menu_getTextButtonHeight();
      this.eg_addTextButton(id, text, align1, align2, x, y, w, textButtonHeight);
    }

    public int p_menu_getTextButtonHeight()
    {
      int num1 = this.dynamic_X_RES >> 4;
      int num2 = this.gfx_getFontHeight(3) + (num1 >> 1);
      return num2 > 57 ? num2 : 57;
    }

    public void menu_addTextButton(
      int id,
      mrGame.MrGame.MrgString text,
      int align1,
      int align2,
      int x,
      int y,
      int h)
    {
      int num1 = this.dynamic_X_RES >> 4;
      int num2 = this.gfx_stringWidth(3, text) + num1;
      int w = num2 > 120 ? num2 : 120;
      this.eg_addTextButton(id, text, align1, align2, x, y, w, h);
    }

    public void menu_screenSizeUpdate()
    {
      if (!this.p_mainGroupsLoaded || this.p_em_confirming)
        return;
      int pEmMenu = !this.p_game_menuInited || this.p_em_stackPos < 0 ? 0 : this.p_em_menuStack[this.p_em_stackPos];
      this.em_storeActiveElement(this.eg_getFocusElementId());
      this.eg_reset();
      this.dojmenu_createGui(pEmMenu);
    }

    public void menu_addThemesSlider()
    {
      this.horizArrowVisible = false;
      int count = this.themes_getCount();
      int num = 32 + 83;
      if (this.gfx_getFontHeight(3) <= this.gfx_getFontHeight(5))
        this.gfx_getFontHeight(5);
      else
        this.gfx_getFontHeight(3);
      int dynamicXRes = this.dynamic_X_RES;
      int h = 119;
      int x = (this.dynamic_X_RES >> 1) - (dynamicXRes >> 1);
      this.mainMenuThemeSliderY = this.dynamic_Y_RES - h;
      this.eg_addSlider(25, count, true, false, 5, 20, x, this.mainMenuThemeSliderY, dynamicXRes, h);
      this.eg_setSliderSelectionImmediately(25, this.themes_getThemeSel());
      this.eg_setElementStatic(25, true);
      this.eg_setKeypadFocusable(25, false);
    }

    public void tbi_drawImage(int textboxId, int imageId, int x, int y)
    {
      if (imageId == 1)
      {
        this.gfx_drawImage(this.themes_getImageId(37), x, y, 20, 0);
        int x1 = x + 40;
        int width = (this.platforms_fp_width >> 11) - 40 - 37;
        int num = 0;
        if (width < 0)
        {
          num = width;
          width = 0;
        }
        this.platform_fillHorizontal(this.themes_getImageId(38), x1, y, width);
        int x2 = x1 + (width + num);
        this.gfx_drawImage(this.themes_getImageId(39), x2, y, 20, 0);
      }
      else if (imageId >= 200 && imageId < 213)
      {
        int index = imageId - 200;
        this.achievement_paintSliderBase(index, x, y);
        this.achievement_paintItem(index, x, y);
      }
      else if (imageId == 199)
      {
        this.leaderboards_paintButton(x, y, 210, 72, true);
        this.leaderboards_paintButton(x + 210, y, 210, 72, false);
      }
      else if (imageId >= 300)
      {
        int index = imageId - 300;
        this.achievement_paintSliderBase(index, x, y);
        y += 72 - this.gfx_getFontHeight(3) >> 1;
        if (this.leaderboards_getTbType() == 0)
        {
          if (this.xbla_leaderboard_getError(this.dxScoresId) != 0)
            return;
          this.gfx_drawString(3, this.dojxbla_getLeaderboardRankAndName(index), x + 24, y, 20);
          this.gfx_drawString(4, this.dojxbla_getLeaderboardScore(index), this.dynamic_X_RES - 24, y, 24);
        }
        else
        {
          this.gfx_drawString(3, this.dojxbla_getLeaderboardLocalRankAndName(index), x + 24, y, 20);
          this.gfx_drawString(4, this.dojxbla_getLeaderboardLocalScore(index), this.dynamic_X_RES - 24, y, 24);
        }
      }
      else
        this.gfx_drawImage(this.themes_getImageId(this.textbox_getImgId(textboxId, imageId)), x, y, 20, 0);
    }

    public int tbi_getImageSize(int textboxId, int imageId)
    {
      if (imageId == 1)
        return this.platforms_fp_width >> 11 << 16 | 22;
      if (imageId >= 199)
        return 27525192;
      int imgId = this.textbox_getImgId(textboxId, imageId);
      return this.gfx_getImageWidth(imgId) << 16 | this.gfx_getImageHeight(imgId);
    }

    public int tbi_getFont(int tbId, int id)
    {
      int font;
      switch (id)
      {
        case 1:
          font = 3;
          break;
        case 2:
          font = 3;
          break;
        case 3:
          font = 5;
          break;
        case 4:
          font = 7;
          break;
        case 5:
          font = 4;
          break;
        default:
          font = -1;
          break;
      }
      return font;
    }

    public int tbi_getFontColor(int tbId, int id)
    {
      int fontColor;
      switch (id)
      {
        case 1:
          fontColor = 0;
          break;
        case 2:
          fontColor = 52224;
          break;
        case 3:
          fontColor = 13421772;
          break;
        case 4:
          fontColor = 0;
          break;
        case 5:
          fontColor = 0;
          break;
        default:
          fontColor = -1;
          break;
      }
      return fontColor;
    }

    public int textbox_getImgId(int textboxId, int imageId)
    {
      switch (imageId)
      {
        case 2:
          return 40;
        case 3:
          return 41;
        default:
          return -1;
      }
    }

    public void game_loadingCallback(int callerID, int objectid)
    {
      this.doj_loading = true;
      this.loading_update((this.timedelta << 11) / 1000);
      if (this.loading_lastLoadingTime > this.smoothtime)
        this.loading_lastLoadingTime = this.smoothtime - 1000;
      if (this.smoothtime - this.loading_lastLoadingTime <= 100)
        return;
      this.mrg_forcePaintNow();
      this.loading_lastLoadingTime = this.smoothtime;
      this.loading_stepsCounter += 100;
    }

    public void game_forcedPaint()
    {
      this.eg_skipPaint();
      if (!this.p_mainGroupsLoaded)
      {
        this.gfx_setColor(16052202);
        this.gfx_fillRect(0, 0, this.dynamic_X_RES, this.dynamic_Y_RES);
        int y = this.doj_worldToScreenY(this.loading_fp_posY) - (this.dynamic_Y_RES >> 1);
        this.gfx_setColor(0);
        this.gfx_fillRect((this.dynamic_X_RES >> 1) - 21 - 1, y - 1, 45, 45);
        this.gfx_setColor(13289493);
        this.gfx_fillRect((this.dynamic_X_RES >> 1) - 21, y, 43, 43);
      }
      else
      {
        this.doj_DrawGameBackground();
        this.gfx_setColor(0);
        this.gfx_drawString(3, this.p_allTexts[38].toLowerCase(), this.dynamic_X_RES >> 1, (this.dynamic_Y_RES >> 1) + (this.dynamic_Y_RES >> 1 >> 1), 17);
        if (this.loading_stepsCounter > 2000)
          this.gfx_drawImage(42, (this.dynamic_X_RES >> 1) - 11, this.doj_worldToScreenY(this.loading_fp_posY) - (this.dynamic_Y_RES >> 1), 33, 0);
        int x = (this.dynamic_X_RES >> 1) - 40;
        this.gfx_drawImage(37, x, this.dynamic_Y_RES >> 1, 20, 0);
        this.gfx_drawImage(39, x + 40, this.dynamic_Y_RES >> 1, 20, 0);
      }
    }

    public void loading_init()
    {
      this.loading_stepsCounter = 0;
      this.loading_lastLoadingTime = 0;
      this.loading_fp_posY = 0;
      this.loading_fp_velY = this.common_fp_configJumpVelY;
    }

    public void loading_update(int fp_dt)
    {
      this.debug_text((mrGame.MrGame.MrgString) ("loading update: " + (object) fp_dt));
      this.loading_fp_velY += this.fp_mul(-this.common_fp_configNormalAccY, fp_dt);
      if (this.loading_fp_velY < this.common_fp_configMaxFallVelY)
        this.loading_fp_velY = this.common_fp_configMaxFallVelY;
      this.loading_fp_posY += this.fp_mul(this.loading_fp_velY, fp_dt);
      if (this.loading_fp_posY < 0)
      {
        this.loading_fp_velY = this.common_fp_configJumpVelY;
        this.loading_fp_posY = 0;
      }
      this.debug_text((mrGame.MrGame.MrgString) ("charY: " + (object) this.doj_worldToScreenY(this.loading_fp_posY)));
      this.debug_text((mrGame.MrGame.MrgString) ("velY: " + (object) this.doj_worldToScreenY(this.loading_fp_velY)));
    }

    public void demo_keyPressed(int keyCode)
    {
    }

    public void demo_keyReleased(int keyCode)
    {
      this.debug_text((mrGame.MrGame.MrgString) ("=========================333333333333333 + " + (object) keyCode + "," + (object) 196608 + ", " + (object) 5));
      if (!this.mrg_isKey(keyCode, 196608) && !this.mrg_isKey(keyCode, 5))
        return;
      this.debug_text((mrGame.MrGame.MrgString) "demo_keyReleased( int keyCode )");
      this.popup_delete();
      this.doj_endGame();
    }

    public void demo_screenSizeChanged()
    {
      this.popup_delete();
      this.popup_create(this.p_allTexts[158], 1016, 159, (short) 2);
    }

    public void emi_introStart()
    {
      this.intro_time = this.smoothtime;
      this.debug_text((mrGame.MrGame.MrgString) ("x spacing: " + (object) (this.dynamic_X_RES - 195 - 192 >> 2) + " y spacing: " + (object) (this.dynamic_Y_RES - 222 - 30 >> 2)));
    }

    public void emi_introPaint()
    {
      int num = this.smoothtime - this.intro_time;
      int y1 = this.dynamic_Y_RES - 222 - 30 - 222 >> 2;
      int x = this.dynamic_X_RES - 192 - 195 >> 2;
      this.doj_DrawGameBackground();
      if (num > 100)
      {
        int y2 = (y1 * 2 + 222 + 222 + this.dynamic_Y_RES) / 2;
        this.gfx_drawImage(757, x, y2, 6, 0);
        this.gfx_drawImage(758, this.dynamic_X_RES - x, y2, 10, 0);
      }
      if (num > 500 && num < 800)
        this.gfx_drawImage(755, (x + 192) * (num - 500) / 300 - 192, y1 * 2 + 222, 20, 0);
      if (num >= 800)
        this.gfx_drawImage(755, x, y1 * 2 + 222, 20, 0);
      if (num > 900 && num < 1200)
        this.gfx_drawImage(754, this.dynamic_X_RES + (195 - (x + 195) * (num - 900) / 300), y1 * 2 + 222, 24, 0);
      if (num >= 1200)
        this.gfx_drawImage(754, this.dynamic_X_RES - x, y1 * 2 + 222, 24, 0);
      if (num > 1300 && num < 1600)
        this.gfx_drawImage(756, this.dynamic_X_RES >> 1, (y1 + 222) * (num - 1300) / 300 - 222, 17, 0);
      if (num >= 1600)
        this.gfx_drawImage(756, this.dynamic_X_RES >> 1, y1, 17, 0);
      if (num <= 3500)
        return;
      this.mrp_keyPressed((int) this.p_indexTable2[6] - 10);
    }

    public void physics_updateControls(int fp_dt)
    {
      if (this.doj_gameOver || fp_dt == 0)
        return;
      bool flag = false;
      if ((this.character_state & 18688) == 0)
      {
        if (this.p_options[2] != (sbyte) 0)
        {
          this.character_fp_accX = 0;
          this.character_fp_velX = this.fp_mul(8192, this.acc_x >> 9 << 11);
          this.debug_text((mrGame.MrGame.MrgString) ("DOJ X == " + (object) this.character_fp_velX));
        }
        else if (this.mrg_isKey(70))
          this.character_fp_accX = this.character_fp_velX <= 0 ? -this.common_fp_configNormalAccX : -this.common_fp_configNormalDecX;
        else if (this.mrg_isKey(71))
          this.character_fp_accX = this.character_fp_velX >= 0 ? this.common_fp_configNormalAccX : this.common_fp_configNormalDecX;
        else if (!this.doj_pointerDown)
        {
          this.character_fp_accX = this.character_fp_velX <= 0 ? (this.character_fp_velX >= 0 ? 0 : this.common_fp_configNormalDecX) : -this.common_fp_configNormalDecX;
          flag = true;
        }
      }
      if ((this.character_state & 68608) != 0)
      {
        this.character_fp_accX = this.character_fp_velX <= 0 ? (this.character_fp_velX >= 0 ? 0 : this.common_fp_configNormalDecX) : -this.common_fp_configNormalDecX;
        flag = true;
      }
      int characterFpVelX = this.character_fp_velX;
      this.character_fp_velX += this.fp_mul(this.character_fp_accX, fp_dt);
      if (flag && (characterFpVelX > 0 && this.character_fp_velX < 0 || characterFpVelX < 0 && this.character_fp_velX > 0))
        this.character_fp_velX = 0;
      if (this.character_fp_velX > this.common_fp_configMaxVelX)
        this.character_fp_velX = this.common_fp_configMaxVelX;
      else if (this.character_fp_velX < -this.common_fp_configMaxVelX)
        this.character_fp_velX = -this.common_fp_configMaxVelX;
      this.character_fp_posX += this.fp_mul(this.character_fp_velX, fp_dt);
      if (this.character_fp_posX < 0)
      {
        this.character_fp_posX += this.common_fp_configLogicScreenWidth;
        this.character_fp_movementDelta += this.common_fp_configLogicScreenWidth;
      }
      if (this.character_fp_posX <= this.common_fp_configLogicScreenWidth)
        return;
      this.character_fp_posX -= this.common_fp_configLogicScreenWidth;
      this.character_fp_movementDelta -= this.common_fp_configLogicScreenWidth;
    }

    public void physics_menu()
    {
      int num = (this.timedelta << 11) / 1000;
      if (num > 204)
        num = 204;
      this.menu_fp_time += num;
      if (this.menu_fp_time < 34)
        return;
      bool flag = false;
      this.objects_update(this.menu_fp_time);
      for (; this.menu_fp_time > 11 && !flag; this.menu_fp_time -= 11)
      {
        this.physics_menuUpdate(11);
        if (this.character_state == 0 || (this.character_state & 12424) != 0)
          flag = this.physics_menuUpdateCollisions();
      }
    }

    public void physics_menuUpdate(int fp_time)
    {
      this.character_fp_velY += this.fp_mul(this.character_fp_accY, fp_time);
      if (this.character_fp_velY < this.common_fp_configMaxFallVelY)
        this.character_fp_velY = this.common_fp_configMaxFallVelY;
      this.character_fp_posY += this.fp_mul(this.character_fp_velY, fp_time);
    }

    public bool physics_menuUpdateCollisions()
    {
      int fpX = this.platforms_array[this.platforms_begin].fp_x;
      int num1 = this.platforms_array[this.platforms_begin].fp_y - this.doj_fp_screenYOffset;
      int num2 = num1 - this.platforms_fp_wHeight;
      int num3 = fpX - (this.platforms_fp_wWidth >> 1) - (this.character_fp_width >> 1);
      int num4 = fpX + (this.platforms_fp_wWidth >> 1) + (this.character_fp_width >> 1);
      if (this.character_fp_velY < 0 && this.character_fp_posX >= num3 && this.character_fp_posX <= num4 && this.character_fp_posY >= num2 && this.character_fp_posY <= num1)
      {
        this.character_fp_posY = num1;
        this.character_fp_velY = 3 * this.common_fp_configJumpVelY >> 2;
        this.character_fp_accY = -this.common_fp_configNormalAccY;
        this.p_playSound(4, 128, 1);
        return true;
      }
      if (this.character_fp_velY > 0 && this.character_fp_posY >= num2 && this.character_fp_posY <= num1)
        this.character_fp_accY = -this.common_fp_configNormalAccY;
      return false;
    }

    public void physics_update(int fp_time)
    {
      if (this.doj_gameOver)
        return;
      this.projectiles_update(fp_time);
      if ((this.character_state & 66560) != 0 && (this.character_state & 49920) == 0)
      {
        if (this.themes_current == 0)
          this.doj_drawRippedPaper = false;
        this.character_fp_velY += this.fp_mul(this.character_fp_accY, fp_time);
        if (this.character_fp_velY < this.common_fp_configMaxFallVelY)
          this.character_fp_velY = this.common_fp_configMaxFallVelY;
        this.character_fp_posY += this.fp_mul(this.character_fp_velY, fp_time);
        if ((this.character_state & 65536) != 0)
        {
          this.doj_backgroundPixelsOffset = 0;
          this.doj_drawRippedPaper = true;
          if (this.character_fp_stateTime > 1269)
            this.doj_endGame();
        }
        if ((this.character_state & 1024) == 0)
          return;
        if (this.character_fp_stateTime > 1638)
        {
          this.doj_backgroundPixelsOffset = 0;
          this.doj_drawRippedPaper = true;
        }
        if (this.character_fp_stateTime > 1751)
        {
          this.character_removeState(1024);
          this.character_addState(65536);
          this.character_removeState(128);
          this.character_removeState(2097152);
          this.character_removeState(8);
          this.character_removeState(262144);
          this.character_fp_posY = this.common_fp_configCharacterYLimit;
          this.doj_fp_endGameYoff = 0;
        }
        else
        {
          this.doj_startEndGame();
          this.doj_fp_screenYOffset -= fp_time * 1200;
          this.doj_backgroundPixelsOffset = (this.doj_score - (this.doj_fp_screenYOffset >> 11)) % 719;
          this.doj_fp_endGameYoff += fp_time * 1200;
          int num = this.fp_div(this.dynamic_Y_RES << 11, this.common_fp_yRatio);
          if (this.doj_fp_endGameYoff <= num)
            return;
          this.doj_fp_endGameYoff = num;
        }
      }
      else
      {
        this.objects_update(fp_time);
        this.character_fp_velY += this.fp_mul(this.character_fp_accY, fp_time);
        if (this.character_fp_velY < this.common_fp_configMaxFallVelY)
          this.character_fp_velY = this.common_fp_configMaxFallVelY;
        this.character_fp_posY += this.fp_mul(this.character_fp_velY, fp_time);
        if (this.character_fp_posY < 0 && (this.character_state & 1098496) == 0 && !this.physics_updateCollisions())
        {
          this.p_playSound(7, 128, 1);
          this.stats_bump(16);
          this.character_addState(1024);
          this.platforms_cleanup_invisible();
        }
        else
        {
          int num1 = 0;
          if (this.character_fp_posY > this.common_fp_configCharacterYLimit)
          {
            num1 = this.character_fp_posY - this.common_fp_configCharacterYLimit;
            this.doj_fp_screenYOffset += num1;
            this.character_fp_posY = this.common_fp_configCharacterYLimit;
            this.doj_score = this.doj_fp_screenYOffset >> 11;
          }
          if (!this.customization_isUnlocked() && this.doj_score > 7500)
            this.popup_create(this.p_allTexts[158], 1016, 159, (short) 2);
          if ((this.character_state & 1) != 0 && this.character_fp_stateTime > 2048)
          {
            this.character_removeState(1);
            this.character_addState(2);
            this.character_fp_accY = 0;
          }
          if ((this.character_state & 2) != 0 && this.character_fp_stateTime > 2048)
          {
            this.character_removeState(2);
            this.character_addState(4);
            this.character_fp_accY = -884736;
          }
          if ((this.character_state & 4) != 0 && this.character_fp_stateTime > 2048)
          {
            this.character_removeState(4);
            this.character_addState(8);
            this.character_rotationTime = 0;
            this.powerup_rotationTime = 0;
            this.character_fp_accY = -this.common_fp_configNormalAccY;
            this.powerup_fallDirectionLeft = this.character_isFacingLeft;
            int num2 = this.fp_div(87040, this.common_fp_xRatio);
            this.powerup_fp_fallPosX = !this.character_isFacingLeft ? this.character_fp_posX - num2 : this.character_fp_posX + num2;
            this.powerup_fp_fallPosY = this.character_fp_posY - this.fp_div(-116736, this.common_fp_yRatio);
            this.powerup_fp_fallVelY = this.character_fp_velY;
            this.powerup_fp_fallAccY = -3686400;
            this.powerup_fallDirectionLeft = this.character_isFacingLeft;
            if (!this.character_isFacingLeft)
            {
              this.powerup_fp_fallVelX = -46080;
              this.powerup_fp_fallAccX = 46080;
            }
            else
            {
              this.powerup_fp_fallVelX = 46080;
              this.powerup_fp_fallAccX = -46080;
            }
          }
          if ((this.character_state & 8) != 0)
          {
            this.powerup_fp_fallVelY += this.fp_mul(this.powerup_fp_fallAccY, fp_time);
            if (this.powerup_fp_fallVelY < -614400)
              this.powerup_fp_fallVelY = -614400;
            this.powerup_fp_fallPosY += this.fp_mul(this.powerup_fp_fallVelY, fp_time) - num1;
            if (this.powerup_fp_fallPosY < 0)
              this.character_removeState(8);
            this.powerup_fp_fallVelX += this.fp_mul(this.powerup_fp_fallAccX, fp_time);
            this.powerup_fp_fallPosX += this.fp_mul(this.powerup_fp_fallVelX, fp_time);
          }
          if ((this.character_state & 16) != 0 && this.character_fp_stateTime > this.common_fp_configPropellerHat1stPhaseDur)
          {
            this.character_removeState(16);
            this.character_addState(32);
            this.character_fp_accY = 0;
          }
          if ((this.character_state & 32) != 0 && this.character_fp_stateTime > this.common_fp_configPropellerHat2ndPhaseDur)
          {
            this.character_removeState(32);
            this.character_addState(64);
            this.character_fp_accY = -737280;
          }
          if ((this.character_state & 64) != 0 && this.character_fp_stateTime > this.common_fp_configPropellerHat3rdPhaseDur)
          {
            this.character_removeState(64);
            this.character_addState(128);
            this.powerup_rotationTime = 0;
            this.character_fp_accY = -this.common_fp_configNormalAccY;
            this.powerup_fallDirectionLeft = this.character_isFacingLeft;
            int num3 = this.fp_div(20480, this.common_fp_xRatio);
            if (this.character_isFacingLeft)
            {
              this.powerup_fp_fallPosX = this.character_fp_posX + num3;
              this.powerup_fp_fallVelX = -368640;
              this.powerup_fp_fallAccX = 368640;
            }
            else
            {
              this.powerup_fp_fallPosX = this.character_fp_posX - num3;
              this.powerup_fp_fallVelX = 368640;
              this.powerup_fp_fallAccX = -368640;
            }
            this.powerup_fp_fallPosY = this.character_fp_posY - this.fp_div(-116736, this.common_fp_yRatio);
            this.powerup_fp_fallVelY = this.character_fp_velY + 245760;
            this.powerup_fp_fallAccY = -3686400;
          }
          if ((this.character_state & 128) != 0)
          {
            this.powerup_fp_fallVelY += this.fp_mul(this.powerup_fp_fallAccY, fp_time);
            if (this.powerup_fp_fallVelY < -614400)
              this.powerup_fp_fallVelY = -614400;
            this.powerup_fp_fallPosY += this.fp_mul(this.powerup_fp_fallVelY, fp_time) - num1;
            if (this.powerup_fp_fallPosY < 0)
              this.character_removeState(128);
            this.powerup_fp_fallVelX += this.fp_mul(this.powerup_fp_fallAccX, fp_time);
            this.powerup_fp_fallPosX += this.fp_mul(this.powerup_fp_fallVelX, fp_time);
          }
          if ((this.character_state & 262144) != 0)
          {
            this.powerup_fp_fallVelY += this.fp_mul(this.powerup_fp_fallAccY, fp_time);
            if (this.powerup_fp_fallVelY < -614400)
              this.powerup_fp_fallVelY = -614400;
            this.powerup_fp_fallPosY += this.fp_mul(this.powerup_fp_fallVelY, fp_time) - num1;
            if (this.powerup_fp_fallPosY < 0)
              this.character_removeState(262144);
            this.powerup_fp_fallVelX += this.fp_mul(this.powerup_fp_fallAccX, fp_time);
            this.powerup_fp_fallPosX += this.fp_mul(this.powerup_fp_fallVelX, fp_time);
          }
          if ((this.character_state & 4096) != 0 && this.powerup_fp_shieldTime > 8533)
          {
            this.character_removeState(4096);
            this.character_addState(8192);
          }
          if ((this.character_state & 8192) != 0 && this.powerup_fp_shieldTime > 4096)
            this.character_removeState(8192);
          if ((this.character_state & 256) != 0)
          {
            if (this.character_fp_stateTime > 409)
            {
              this.character_removeState(256);
              this.character_addState(512);
            }
            else
            {
              int num4 = 22528;
              if (this.character_isFacingLeft)
                num4 = -num4;
              this.character_fp_posX = this.character_fp_origPosX - this.character_fp_stateTime * (this.character_fp_origPosX - this.objects_array[this.objects_collidedIndex].fp_x + num4) / 409;
              this.character_fp_posY = this.character_fp_origPosY - this.character_fp_stateTime * (this.character_fp_origPosY - (this.objects_array[this.objects_collidedIndex].fp_y - this.doj_fp_screenYOffset - (this.character_fp_height >> 1))) / 409;
            }
          }
          if ((this.character_state & 16384) != 0)
          {
            if (this.character_fp_stateTime > 819)
            {
              this.character_removeState(16384);
              this.character_addState(32768);
            }
            else
            {
              int num5 = 22528;
              if (this.character_isFacingLeft)
                num5 = -num5;
              this.character_fp_posX = this.character_fp_origPosX - this.character_fp_stateTime * (this.character_fp_origPosX - this.objects_array[this.objects_collidedIndex].fp_x + num5) / 819;
              int num6 = this.doj_worldToScreenY(this.objects_array[this.objects_collidedIndex].fp_y - this.doj_fp_screenYOffset) - (68 - this.themes_getOffset(6)) + 49;
              int screenY = this.doj_worldToScreenY(this.character_fp_origPosY);
              int num7 = this.character_fp_stateTime * (num6 - screenY) / 819;
              this.doodleHoaxY = screenY + num7;
            }
          }
          if ((this.character_state & 33280) == 0)
            return;
          if (this.character_fp_stateTime > 1000)
          {
            this.doj_endGame();
          }
          else
          {
            this.character_fp_velX = 0;
            this.character_fp_velY = 0;
          }
        }
      }
    }

    public bool physics_updateCollisions()
    {
      if (this.doj_gameOver || (this.character_state & 101888) != 0)
        return false;
      for (int objectsBegin = this.objects_begin; objectsBegin < this.objects_end + 30; ++objectsBegin)
      {
        int index = this.objects_begin >= this.objects_end ? (objectsBegin < 30 ? objectsBegin : objectsBegin - 30) : objectsBegin;
        if (index != this.objects_end)
        {
          int fpX = this.objects_array[index].fp_x;
          int fp_y = this.objects_array[index].fp_y - this.doj_fp_screenYOffset;
          if (this.objects_array[index].id == 4 && (this.character_state & 1048951) == 0)
          {
            int num1 = fpX - this.fp_div(71680, this.common_fp_xRatio) - (this.character_fp_width >> 1);
            int num2 = fpX + this.fp_div(71680, this.common_fp_xRatio) + (this.character_fp_width >> 1);
            int num3 = fp_y - this.fp_div(71680, this.common_fp_yRatio) - this.character_fp_height;
            int num4 = fp_y + this.fp_div(71680, this.common_fp_yRatio);
            if (this.character_fp_posX >= num1 && this.character_fp_posX <= num2 && this.character_fp_posY >= num3 && this.character_fp_posY <= num4)
            {
              this.character_fp_origPosX = this.character_fp_posX;
              this.character_fp_origPosY = this.character_fp_posY;
              this.character_addState(256);
              this.stats_bump(19);
              this.objects_collidedIndex = index;
              this.character_fp_accX = 0;
              this.character_fp_accY = 0;
              this.character_fp_velX = 0;
              this.character_fp_velY = -(this.character_fp_posY + this.doj_fp_screenYOffset - this.objects_array[index].fp_y);
              this.doj_stopWarningSounds();
              this.p_playSound(5, 128, 1);
            }
          }
          else
          {
            int num5;
            int num6;
            switch (this.objects_array[index].id)
            {
              case 5:
                num5 = this.fp_div(112640, this.common_fp_xRatio);
                num6 = this.fp_div(50176, this.common_fp_yRatio);
                int num7 = this.fp_div(189440, this.common_fp_yRatio);
                fp_y += num7;
                break;
              case 7:
                num5 = this.fp_div(80896, this.common_fp_xRatio);
                num6 = this.fp_div(72704, this.common_fp_yRatio);
                break;
              case 8:
                num5 = this.fp_div(66560, this.common_fp_xRatio);
                num6 = this.fp_div(52224, this.common_fp_yRatio);
                break;
              case 9:
                num5 = this.fp_div(54272, this.common_fp_xRatio);
                num6 = this.fp_div(70656, this.common_fp_yRatio);
                break;
              case 10:
                num5 = this.fp_div(116736, this.common_fp_xRatio);
                num6 = this.fp_div(66560, this.common_fp_yRatio);
                break;
              case 11:
              case 30:
                num5 = this.fp_div(120832, this.common_fp_xRatio);
                num6 = this.fp_div(88064, this.common_fp_yRatio);
                break;
              case 22:
                num5 = this.fp_div(95232, this.common_fp_xRatio);
                num6 = this.fp_div(130048, this.common_fp_yRatio);
                break;
              case 26:
                num5 = this.fp_div(131072, this.common_fp_xRatio);
                num6 = this.fp_div(45056, this.common_fp_yRatio);
                fp_y += num6;
                break;
              default:
                continue;
            }
            int num8 = num5 - (num5 >> 4);
            int num9 = num6 - (num6 >> 4);
            if (this.projectiles_markForRemoveIfInArea(fpX, fp_y, num8 << 1, num9 << 1))
            {
              bool flag = false;
              if (this.objects_holdOnIndex != index)
              {
                this.objects_holdOnIndex = index;
                flag = true;
              }
              if (this.objects_array[index].id != 11 && flag)
              {
                this.doj_stopWarningSounds();
                if (this.objects_array[index].id != 5)
                {
                  this.stats_bump(6);
                  if (this.themes_current == 1)
                    this.p_playSound(28, 128, 1);
                  else
                    this.p_playSound(11, 128, 1);
                }
                else
                {
                  this.stats_bump(8);
                  if ((this.character_state & 16384) != 0)
                  {
                    this.character_removeState(16384);
                    this.character_fp_accY = -this.common_fp_configNormalAccY;
                    this.achievement_award(12);
                  }
                }
                this.achievement_add(7);
                this.achievement_add(8);
              }
            }
            else if ((this.character_state & 112) != 0)
            {
              int num10 = num9 + this.fp_div(100352, this.common_fp_yRatio);
              if (this.character_fp_posX >= fpX - num8 && this.character_fp_posX <= fpX + num8 && this.character_fp_posY >= fp_y - num10 - (this.character_fp_height >> 1) && this.character_fp_posY <= fp_y + num10 - (this.character_fp_height >> 1) && this.objects_array[index].fp_velY >= 0)
              {
                this.objects_array[index].id = 32;
                this.doj_stopWarningSounds();
                this.p_playSound(11, 128, 1);
              }
            }
            else if ((this.character_state & 1064967) == 0)
            {
              if (this.objects_array[index].id == 5)
              {
                fp_y = this.objects_array[index].fp_y - this.doj_fp_screenYOffset;
                num8 = this.fp_div(126976, this.common_fp_xRatio);
                num9 = this.fp_div(189440, this.common_fp_yRatio);
              }
              int num11 = num8 + (this.character_fp_width >> 1);
              if (this.character_fp_posX >= fpX - num11 && this.character_fp_posX <= fpX + num11 && this.character_fp_posY >= fp_y - num9 - (this.character_fp_height >> 1) && this.character_fp_posY <= fp_y + num9 - (this.character_fp_height >> 1) && this.objects_array[index].fp_velY >= 0)
              {
                if (this.character_fp_velY >= 0 && (this.character_state & 12288) == 0)
                {
                  if (this.objects_array[index].id != 5)
                  {
                    this.character_addState(2048);
                    this.character_fp_velY = 0;
                    this.character_fp_accX = -this.character_fp_accX;
                    this.p_playSound(10, 128, 1);
                    this.doj_stopWarningSounds();
                    this.stats_bump(17);
                  }
                  else
                  {
                    if ((this.character_state & 16384) == 0)
                      this.stats_bump(18);
                    this.character_addState(16384);
                    this.doj_stopWarningSounds();
                    this.p_playSound(17, 128, 1);
                    this.character_fp_origPosX = this.character_fp_posX;
                    this.character_fp_origPosY = this.character_fp_posY;
                    this.doj_fp_screenYOffsetOld = this.doj_fp_screenYOffset;
                    this.objects_collidedIndex = index;
                    this.character_fp_velX = 0;
                    this.character_fp_velY = 0;
                    this.character_fp_accX = 0;
                    this.character_fp_accY = 0;
                  }
                }
                else if (this.character_fp_velY < 0)
                {
                  this.objects_array[index].fp_velY = -1105920;
                  this.character_fp_velY = 1433600;
                  this.p_playSound(9, 128, 1);
                  this.doj_stopWarningSounds();
                  if (this.objects_array[index].id == 5)
                  {
                    this.stats_bump(9);
                  }
                  else
                  {
                    this.stats_bump(7);
                    this.achievement_add(3);
                    this.achievement_add(4);
                  }
                }
              }
              else if (this.objects_array[index].fp_y - this.doj_fp_screenYOffset < (this.common_fp_configLogicScreenHeight << 2) - this.common_fp_configLogicScreenHeight >> 1 && this.objects_array[index].fp_y - this.doj_fp_screenYOffset > 0 && this.objects_array[index].id != 4 && this.objects_array[index].id != 32)
              {
                if (this.objects_array[index].id == 5 && !this.doj_sfx_ufoWarning)
                {
                  this.p_playSound(19, 0, 0);
                  this.doj_sfx_ufoWarning = true;
                }
                if (this.objects_array[index].id != 5 && !this.doj_sfx_monsterWarning)
                {
                  this.p_playSound(12, 0, 0);
                  this.doj_sfx_monsterWarning = true;
                }
              }
            }
          }
        }
        else
          break;
      }
      for (int platformsBegin = this.platforms_begin; platformsBegin < this.platforms_end + 120; ++platformsBegin)
      {
        int index = this.platforms_begin >= this.platforms_end ? (platformsBegin < 120 ? platformsBegin : platformsBegin - 120) : platformsBegin;
        if (index != this.platforms_end)
        {
          int fpX = this.platforms_array[index].fp_x;
          int num12 = this.platforms_array[index].fp_y - this.doj_fp_screenYOffset;
          int id = this.platforms_array[index].id;
          int num13 = this.fp_div(45056, this.common_fp_yRatio);
          int num14 = num13 > this.platforms_fp_wHeight ? num13 : this.platforms_fp_wHeight;
          int num15 = num12 - num14;
          int num16 = fpX - (this.platforms_fp_wWidth >> 1) - (this.character_fp_width >> 1);
          int num17 = fpX + (this.platforms_fp_wWidth >> 1) + (this.character_fp_width >> 1);
          if ((id & 8) != 0)
          {
            int num18 = fpX + this.platforms_array[index].objOffset - this.fp_div(24576, this.common_fp_xRatio) - (this.character_fp_width >> 1);
            int num19 = fpX + this.platforms_array[index].objOffset + this.fp_div(24576, this.common_fp_xRatio) + (this.character_fp_width >> 1);
            int num20 = num15;
            int num21 = num12 + this.fp_div(36864, this.common_fp_yRatio);
            if (this.character_fp_velY < 0 && this.character_fp_posX >= num18 && this.character_fp_posX <= num19 && this.character_fp_posY >= num20 && this.character_fp_posY <= num21)
            {
              this.character_fp_posY = num12 + this.fp_div(79872, this.common_fp_yRatio);
              this.character_fp_velY = this.common_fp_configCharacterSpringVelY;
              this.character_fp_accY = -this.common_fp_configNormalAccY;
              this.platforms_array[index].id &= -9;
              this.platforms_array[index].id |= 64;
              this.p_playSound(16, 128, 1);
              this.stats_bump(10);
              this.achievement_add(1);
              this.achievement_add(2);
              return true;
            }
          }
          else if ((id & 1048576) != 0)
          {
            int num22 = fpX + this.platforms_array[index].objOffset - this.fp_div(38912, this.common_fp_xRatio) - (this.character_fp_width >> 1);
            int num23 = fpX + this.platforms_array[index].objOffset + this.fp_div(38912, this.common_fp_xRatio) + (this.character_fp_width >> 1);
            int num24 = num12;
            int num25 = num12 + this.fp_div(61440, this.common_fp_yRatio);
            if (this.character_fp_velY < 0 && this.character_fp_posX >= num22 && this.character_fp_posX <= num23 && this.character_fp_posY >= num24 && this.character_fp_posY <= num25)
            {
              this.character_fp_posY = num12 + this.fp_div(10240, this.common_fp_yRatio);
              this.character_fp_velY = this.common_fp_configCharacterSpringVelY;
              this.character_fp_accY = -this.common_fp_configNormalAccY;
              this.platforms_array[index].id &= -1048577;
              this.character_state |= 131072;
              this.powerup_springShoesJumpsLeft = 4;
              this.p_playSound(23, 128, 1);
              this.stats_bump(10);
              return true;
            }
          }
          else if ((id & 2097152) != 0)
          {
            int num26 = fpX + this.platforms_array[index].objOffset - this.fp_div(52224, this.common_fp_xRatio) - (this.character_fp_width >> 1);
            int num27 = fpX + this.platforms_array[index].objOffset + this.fp_div(52224, this.common_fp_xRatio) + (this.character_fp_width >> 1);
            int num28 = num12;
            int num29 = num12 + this.fp_div(51200, this.common_fp_yRatio);
            if (this.character_fp_velY < 0 && this.character_fp_posX >= num26 && this.character_fp_posX <= num27 && this.character_fp_posY >= num28 && this.character_fp_posY <= num29)
            {
              this.character_fp_posY = num12 + this.fp_div(26624, this.common_fp_yRatio);
              this.character_fp_velY = 2048000;
              this.character_fp_accY = -this.common_fp_configNormalAccY;
              this.platforms_array[index].objOffset = 1;
              this.platforms_array[index].updateTime = 0;
              this.character_state |= 524288;
              this.character_rotationTime = 0;
              this.powerup_fallDirectionLeft = this.character_isFacingLeft;
              this.p_playSound(24, 128, 1);
              this.stats_bump(10);
              this.achievement_clearStat(1);
              this.achievement_clearStat(2);
              return true;
            }
          }
          else if ((id & 4194304) != 0 && (this.character_state & 119) == 0)
          {
            int num30 = fpX + this.platforms_array[index].objOffset - this.fp_div(71680, this.common_fp_xRatio) - (this.character_fp_width >> 1);
            int num31 = fpX + this.platforms_array[index].objOffset + this.fp_div(71680, this.common_fp_xRatio) + (this.character_fp_width >> 1);
            int num32 = num12;
            int num33 = num12 + this.fp_div(212992, this.common_fp_yRatio);
            if (this.character_fp_posX >= num30 && this.character_fp_posX <= num31 && this.character_fp_posY >= num32 && this.character_fp_posY <= num33)
            {
              this.character_fp_posY = num12;
              this.character_fp_posX = fpX;
              this.character_fp_velY = 0;
              this.character_fp_accY = 1253376;
              this.platforms_array[index].updateTime = 0;
              this.character_addState(1048576);
              this.character_state &= -12289;
              this.character_state &= -68609;
              this.platforms_array[index].id &= -4194305;
              this.p_playSound(25, 128, 1);
              this.achievement_clearStat(1);
              this.achievement_clearStat(2);
              return true;
            }
          }
          else if ((id & 16) != 0 && (this.character_state & 1048695) == 0)
          {
            int num34 = fpX + this.platforms_array[index].objOffset - this.fp_div(32768, this.common_fp_xRatio) - (this.character_fp_width >> 1);
            int num35 = fpX + this.platforms_array[index].objOffset + this.fp_div(32768, this.common_fp_xRatio) + (this.character_fp_width >> 1);
            int num36 = num12 - this.character_fp_height;
            int num37 = num12 + this.fp_div(104448, this.common_fp_yRatio);
            if (this.character_fp_posX >= num34 && this.character_fp_posX <= num35 && this.character_fp_posY >= num36 && this.character_fp_posY <= num37)
            {
              this.character_fp_velY = 1105920;
              this.character_fp_accY = 1253376;
              this.platforms_array[index].id &= -17;
              this.character_addState(1);
              this.powerup_jetPackInScene = false;
              this.p_playSound(8, 128, 1);
              this.stats_bump(14);
              this.achievement_add(10);
              this.achievement_clearStat(1);
              this.achievement_clearStat(2);
              return true;
            }
          }
          else if ((id & 32) != 0 && (this.character_state & 1048695) == 0)
          {
            int num38 = fpX + this.platforms_array[index].objOffset - this.fp_div(46080, this.common_fp_xRatio) - (this.character_fp_width >> 1);
            int num39 = fpX + this.platforms_array[index].objOffset + this.fp_div(46080, this.common_fp_xRatio) + (this.character_fp_width >> 1);
            int num40 = num12 - this.character_fp_height;
            int num41 = num12 + this.fp_div(73728, this.common_fp_yRatio);
            if (this.character_fp_posX >= num38 && this.character_fp_posX <= num39 && this.character_fp_posY >= num40 && this.character_fp_posY <= num41)
            {
              this.platforms_array[index].id &= -33;
              this.character_addState(16);
              this.powerup_propellerHatInScene = false;
              this.stats_bump(15);
              this.achievement_add(9);
              if (this.character_fp_velY > 0)
              {
                this.character_fp_accY = this.fp_div(1228800 - this.character_fp_velY, 2730);
              }
              else
              {
                this.character_fp_velY = 245760;
                this.character_fp_accY = 737280;
              }
              this.p_playSound(13, 128, 1);
              this.achievement_clearStat(1);
              this.achievement_clearStat(2);
            }
          }
          else if ((id & 128) != 0 && (this.character_state & 1048576) == 0)
          {
            int num42 = fpX + this.platforms_array[index].objOffset - this.fp_div(52224, this.common_fp_xRatio) - (this.character_fp_width >> 1);
            int num43 = fpX + this.platforms_array[index].objOffset + this.fp_div(52224, this.common_fp_xRatio) + (this.character_fp_width >> 1);
            int num44 = num12 - this.character_fp_height;
            int num45 = num12 + this.fp_div(100352, this.common_fp_yRatio);
            if (this.character_fp_posX >= num42 && this.character_fp_posX <= num43 && this.character_fp_posY >= num44 && this.character_fp_posY <= num45)
            {
              this.platforms_array[index].id &= -129;
              this.character_addState(4096);
            }
          }
          if ((this.character_state & 131072) != 0)
          {
            int num46 = this.fp_div(40960, this.common_fp_yRatio);
            num15 += num46;
            num12 += num46;
          }
          if (id <= 67108868 && this.character_fp_velY < 0 && this.character_fp_posX >= num16 && this.character_fp_posX <= num17 && this.character_fp_posY >= num15 && this.character_fp_posY <= num12)
          {
            this.achievement_clearStat(1);
            this.achievement_clearStat(2);
            if (id < 67108864)
            {
              if ((this.character_state & 131072) != 0)
              {
                this.character_fp_posY = num12 - this.fp_div(30720, this.common_fp_yRatio);
                this.character_fp_velY = this.common_fp_configCharacterSpringVelY;
                --this.powerup_springShoesJumpsLeft;
                this.p_playSound(23, 128, 1);
              }
              else
              {
                this.character_fp_posY = num12 - this.fp_div(12288, this.common_fp_yRatio);
                this.character_fp_velY = this.common_fp_configJumpVelY;
                if (id == 2)
                {
                  this.platforms_array[index].id = int.MinValue;
                  this.platforms_array[index].updateTime = this.smoothtime;
                  this.p_playSound(20, 128, 1);
                }
                else
                  this.p_playSound(4, 128, 1);
              }
              this.character_fp_accY = -this.common_fp_configNormalAccY;
              this.stats_bump(10);
              return true;
            }
            int num47 = this.platforms_array[index].id & 4;
            this.platforms_array[index].id = 134217728 | num47;
            this.platforms_array[index].updateTime = this.smoothtime;
            this.p_playSound(6, 128, 1);
          }
        }
        else
          break;
      }
      return false;
    }

    public void tutorial_init()
    {
      this.tutorial_reset();
      this.tutorial_mode = (short) 0;
    }

    public void tutorial_reset() => this.tutorial_active = this.p_options[6] == (sbyte) 1;

    public void tutorial_screenSizeUpdate()
    {
      if (this.tutorial_mode >= (short) 4 || !this.tutorial_active)
        return;
      --this.tutorial_mode;
      this.tutorial_nextScreen();
    }

    public void tutorial_nextScreen()
    {
      ++this.tutorial_mode;
      mrGame.MrGame.MrgString text;
      if (this.tutorial_mode == (short) 1)
        text = this.p_allTexts[153] + (mrGame.MrGame.MrgString) "\n" + this.p_allTexts[155];
      else if (this.tutorial_mode == (short) 2)
        text = this.p_allTexts[154];
      else if (this.tutorial_mode == (short) 3)
      {
        text = this.p_allTexts[156];
      }
      else
      {
        this.popup_delete();
        this.tutorial_active = false;
        return;
      }
      this.popup_create(text, 1010, 157, (short) 1);
    }

    public void tutorial_keyPressed(int keyCode)
    {
      if (!this.mrg_isKey(keyCode, 196611))
        return;
      this.tutorial_nextScreen();
    }

    public void tutorial_keyReleased(int keyCode)
    {
      if (!this.mrg_isKey(keyCode, 196608))
        return;
      this.tutorial_nextScreen();
    }

    public void doj_init()
    {
      this.horizArrowVisible = false;
      this.doj_drawRippedPaper = false;
      this.doj_scoreCharArr = new char[30];
      this.debug_text((mrGame.MrGame.MrgString) "*** doj_init(): setting doj_gameover = false");
      this.doj_gameOver = false;
      this.menu_intro = true;
      this.doj_loading = true;
      this.common_init();
      this.loading_init();
      this.doj_updateScreenSizes();
      this.multiplayer_init();
      this.doj_initialMenu = 0;
      this.acc_x = -1;
      this.popup_init();
      this.stats_init();
      this.themes_init();
      this.platforms_init();
      this.objects_init();
      this.particles_init();
      this.initSinTables();
      this.menu_reset();
    }

    public void doj_postInit()
    {
      this.doj_restartGame();
      this.stats_load();
      this.highscores_init();
      this.projectiles_init();
      this.tutorial_init();
      this.achievement_load();
    }

    public void doj_free()
    {
      this.platforms_free();
      this.themes_free();
      this.objects_free();
      this.common_free();
      this.multiplayer_free();
      this.stats_free();
      this.highscores_free();
      this.projectiles_free();
      this.particles_free();
      this.sinTbl = (short[]) null;
      this.doj_scoreCharArr = (char[]) null;
    }

    public void doj_clearGameState()
    {
      this.platforms_reset();
      this.objects_reset();
      this.doj_exitGame = false;
      this.doj_fp_screenYOffset = 0;
      this.doj_score = 0;
      this.doj_backgroundPixelsOffset = 0;
      this.doj_leftKeyDown = false;
      this.doj_rightKeyDown = false;
      this.doj_fp_keyDownTime = 0;
      this.doj_pointerDown = false;
      this.doj_classicMode = false;
      this.character_reset();
      this.doj_fp_time = 0;
      this.projectiles_reset();
      this.doj_sfx_monsterWarning = false;
      this.doj_sfx_ufoWarning = false;
      this.doj_drawRippedPaper = false;
      this.themes_gameStart();
      this.particles_reset();
      this.stats_gameStarted();
      this.doj_endGameSeq = false;
      this.achievement_start();
      this.dojxbla_leaderboards_init();
    }

    public void doj_restartGame()
    {
      this.doj_clearGameState();
      this.debug_text((mrGame.MrGame.MrgString) "*** doj_restartGame(): setting doj_gameover = false");
      this.doj_gameOver = false;
      this.doj_endGameSeq = false;
      this.doj_fp_endGameYoff = 0;
      this.eg_reset();

      if (!this.p_inGame)
        return;
      
      this.mrg_startAccelerationSensor();
    }

    public void game_preinit()
    {
      this.achievement_clear();
      this.leaderboards_preinit();
      this.achievement_preinit();
      this.dojxbla_preinit();
      this.doj_isInGameMenu = false;
      this.doj_init();
    }

    public void game_free()
    {
      this.doj_free();
      this.achievement_free();
    }

    public void game_start()
    {
      this.p_indexTable2[1531] = (short) 2;
      this.p_indexTable2[1551] = (short) 2;
      this.p_indexTable2[1635] = (short) 2;

      this.mrg_startAccelerationSensor();
      
      this.doj_clearGameState();
      if (!this.multiplayer_loadingState)
      {
        this.debug_text((mrGame.MrGame.MrgString) "*** game_start(): setting doj_gameover=false");
        this.doj_gameOver = false;
      }
      else
      {
        this.doj_score = -1;
        this.doj_endGame();
        this.multiplayer_loadingState = false;
      }
      this.repaintAll = true;
      this.gfx_loadGroup(3);
      this.themes_load();
      this.txt_loadGroup(3);
      this.sfx_loadGroup(1);
      this.objects_load();
      this.platforms_scenesLoad();
      this.platforms_reset();
      this.loading_stepsCounter = 0;
    }

    public void game_unload()
    {
      this.p_indexTable2[1531] = (short) 0;
      this.p_indexTable2[1551] = (short) 0;
      this.p_indexTable2[1635] = (short) 0;
      this.gfx_unloadGroup(3);
      this.txt_unloadGroup(3);
      this.sfx_unloadGroup(1);
      this.themes_unload();
      this.objects_unload();
      this.platforms_scenesUnload();
      this.debug_text((mrGame.MrGame.MrgString) "*** game_unload(): doj_gameOver = true");
      this.doj_gameOver = true;
      this.highscores_savePlayerName();
      this.mrg_stopAccelerationSensor();
      this.menu_reset();
      this.doj_fp_screenYOffset = 0;
    }

    public void game_exit()
    {
      this.doj_exitGame = true;
      this.doj_initialMenu = 0;
    }

    public void game_exitToMenu(int menuId)
    {
      this.game_exit();
      this.doj_initialMenu = menuId;
    }

    public void game_keyPressed(int keyCode)
    {
      if (this.doj_gameOver && this.mrg_isKey(keyCode, 57))
        this.menu_checkScrollArrowPress(keyCode, 14);
      if ((this.doj_gameOver || this.multiplayer_loadingState) && this.mrg_isKey(keyCode, 10))
        this.egi_eventPressed(1004);
      if (this.doj_gameOver || this.multiplayer_loadingState)
        return;
      if (this.popup_active)
      {
        this.popup_keyPressed(keyCode);
      }
      else
      {
        if (this.mrg_isKey(keyCode, 196611) && !this.doj_gameOver)
          this.mrg_requestIngameMenu();
        if (this.mrg_isKey(keyCode, 70))
          this.doj_leftKeyDown = true;
        if (this.mrg_isKey(keyCode, 71))
          this.doj_rightKeyDown = true;
        if (this.mrg_isKey(keyCode, 5) && !this.doj_gameOver)
          this.character_fire(false);
        if (!this.mrg_isKey(keyCode, 57))
          return;
        if (this.p_touchdata[this.p_mt_last].upy < 74 && this.p_touchdata[this.p_mt_last].upx > this.dynamic_X_RES - 62 - (this.dynamic_X_RES >> 4) - (this.doj_screen_fp_posX >> 11) && this.p_touchdata[this.p_mt_last].upx < this.dynamic_X_RES - (this.doj_screen_fp_posX >> 11))
        {
          this.mrg_requestIngameMenu();
          this.mrg_resetKeys();
        }
        else
        {
          int upy = this.p_touchdata[this.p_mt_last].upy;
          if (this.p_options[2] != (sbyte) 0)
            this.character_fire(true);
          else if (upy > this.doj_worldToScreenY(this.character_fp_posY))
          {
            this.character_fp_accX = (this.p_touchdata[this.p_mt_last].upx - (this.dynamic_X_RES >> 1)) * this.doj_fp_pixelAccX;
            this.doj_pointerDown = true;
          }
          else
            this.character_fire(true);
        }
      }
    }

    public void game_keyReleased(int keyCode)
    {
      if (this.doj_gameOver || this.multiplayer_loadingState)
        return;
      if (this.popup_active)
      {
        this.popup_keyReleased(keyCode);
      }
      else
      {
        if (this.mrg_isKey(keyCode, 70))
          this.doj_leftKeyDown = false;
        if (this.mrg_isKey(keyCode, 71))
          this.doj_rightKeyDown = false;
        if (!this.mrg_isKey(keyCode, 57))
          return;
        this.character_fp_accX = 0;
        this.doj_pointerDown = false;
      }
    }

    public bool game_logic()
    {
      if (this.doj_exitGame)
        return false;
      if (this.doj_isInGameMenu)
      {
        this.debug_text((mrGame.MrGame.MrgString) "---------- Return from the in-game menu ---------- ");
        this.doj_isInGameMenu = false;
        if (this.doj_gameOver)
        {
          this.menu_reinitializeEndGameMenu();
        }
        else
        {
          this.doj_leftKeyDown = false;
          this.doj_rightKeyDown = false;
        }
      }
      this.acc_x = this.p_acceleration_x;
      if (this.doj_gameOver || this.multiplayer_loadingState)
      {
        this.repaintScreen = true;
        return true;
      }
      this.platforms_generate();
      int fp_dt = (this.timedelta << 11) / 1000;
      if (this.tutorial_active && this.tutorial_mode == (short) 0)
        this.tutorial_nextScreen();
      if (this.popup_active)
      {
        this.repaintScreen = true;
        return true;
      }
      if (fp_dt > 204)
        fp_dt = 204;
      this.doj_fp_time += fp_dt;
      this.physics_updateControls(fp_dt);
      if (this.p_touchdata[this.p_mt_last].state == 1 && this.doj_pointerDown)
        this.character_fp_accX = this.doj_fp_pixelAccX * (this.p_touchdata[this.p_mt_last].upx - (this.dynamic_X_RES >> 1));
      bool flag = false;
      while (this.doj_fp_time > 11 && !flag)
      {
        this.platforms_update(11);
        this.particles_update(11);
        this.physics_update(11);
        if ((this.character_state & 85248) == 0 || (this.character_state & 16384) != 0)
          flag = this.physics_updateCollisions();
        this.character_updateState(11);
        this.doj_fp_time -= 11;
        if (this.objects_begin == this.objects_end)
          this.doj_stopWarningSounds();
      }
      this.platforms_generate();
      this.platforms_cleanup();
      this.repaintScreen = true;
      return true;
    }

    public void doj_DrawGameBackground()
    {
      int y1 = -this.doj_backgroundPixelsOffset;
      this.gfx_fillAreaWithImage(this.themes_getImageId(0), 0, y1, this.dynamic_X_RES, this.dynamic_Y_RES + 719);
      if (this.particles_thunder && this.particles_blendTime < 280)
      {
        int index = this.particles_blendTime / 35;
        this.egfx_push();
        this.egfx_reset();
        this.gfx_setColorExt(this.particles_thunderBlendValue[index] << 24 | 16777215, 2);
        this.gfx_fillRect(0, 0, this.dynamic_X_RES, this.dynamic_Y_RES);
        this.egfx_pop();
      }
      int x1 = this.doj_screen_fp_posX >> 11;
      if ((this.doj_gameOver || this.doj_drawRippedPaper) && this.themes_current != 2 && this.themes_current != 4 && this.themes_current != 0 && !this.doj_loading)
      {
        if (this.themes_current == 1)
        {
          int imageId = this.themes_getImageId(28);
          int imageWidth = this.gfx_getImageWidth(imageId);
          int imageHeight = this.gfx_getImageHeight(imageId);
          this.gfx_fillAreaWithImage(imageId, imageWidth + x1, this.dynamic_Y_RES - imageHeight, this.dynamic_X_RES - (imageWidth + imageWidth) - (x1 << 1), imageHeight);
          this.gfx_drawImage(this.themes_getImageId(27), x1, this.dynamic_Y_RES, 36, 0);
          this.gfx_drawImage(this.themes_getImageId(29), this.dynamic_X_RES - x1, this.dynamic_Y_RES, 40, 0);
        }
        else
        {
          int id = 27;
          for (int x2 = x1; x2 < this.dynamic_X_RES - x1; x2 += 76)
          {
            int num = 0;
            if (this.themes_current == 0)
              num = this.doj_backgroundPixelsOffset;
            this.gfx_drawImage(this.themes_getImageId(id), x2, this.dynamic_Y_RES + num, 36, 0);
            ++id;
            if (id > 29)
              id = 27;
          }
        }
      }
      if (this.themes_current != 4 || !this.p_inGame || this.doj_loading || this.themes_spaceBg == null)
        return;
      int y2 = this.fp_mul(this.doj_fp_screenYOffset, this.common_fp_yRatio) >> 11 >> 4;
      int num1 = this.fp_mul(471040, this.common_fp_yRatio) >> 11;
      int num2 = this.fp_mul(880640, this.common_fp_yRatio) >> 11;
      int x3 = this.doj_screen_fp_posX >> 11;
      if (num1 - y2 > 0)
        this.gfx_drawImage(1538, this.dynamic_X_RES - x3, y2 + num1, 24, 0);
      if (num2 - y2 > 0)
        this.gfx_drawImage(1534, x3, y2, 20, 4);
      int y3 = y2 - num1 - num2;
      int index1 = 0;
      int length = this.themes_spaceBg.Length;
      for (; y3 > this.dynamic_Y_RES + this.gfx_getImageHeight(this.themes_spaceBg[index1 + 1]); index1 = (index1 + 4) % length)
        y3 -= this.themes_spaceBg[index1];
      for (; y3 > -this.gfx_getImageHeight(this.themes_spaceBg[index1 + 1]); index1 = (index1 + 4) % length)
      {
        int align = 20;
        int trans = 0;
        int x4 = 0;
        if (this.themes_spaceBg[index1 + 2] == 1)
        {
          align = 24;
          x4 = this.dynamic_X_RES - x3;
        }
        if (this.themes_spaceBg[index1 + 3] == 1)
          trans = 4;
        if (y3 < 0)
          align = align & -33 | 16;
        this.gfx_drawImage(this.themes_spaceBg[index1 + 1], x4, y3, align, trans);
        y3 -= this.themes_spaceBg[index1];
      }
    }

    public void doj_DrawGameForeground()
    {
      int num1 = this.doj_screen_fp_posX >> 11;
      if (this.themes_current == 3 && this.p_inGame && !this.doj_loading)
      {
        if (true)
        {
          int clipX = this.gfx_getClipX();
          int clipY = this.gfx_getClipY();
          int clipW = this.gfx_getClipW();
          int clipH = this.gfx_getClipH();
          int imageId = this.themes_getImageId(4);
          this.gfx_setClip(clipX, this.gfx_getImageHeight(imageId), clipW, clipH);
          for (int y = (this.fp_mul(this.doj_fp_screenYOffset + 4096000, this.common_fp_yRatio) >> 11) * 11 / 10 % 722 - 722; y < this.dynamic_Y_RES; y += 722)
          {
            this.gfx_drawImage(1322, num1, y, 20, 0);
            this.gfx_drawImage(1323, this.dynamic_X_RES - num1, y, 24, 0);
          }
          this.gfx_setClip(clipX, clipY, clipW, clipH);
          int y1 = this.gfx_getImageHeight(this.themes_getImageId(imageId)) * 10 / 15;
          this.gfx_drawImage(1324, num1, y1, 20, 0);
          this.gfx_drawImage(1325, this.dynamic_X_RES - num1, y1, 24, 0);
          this.gfx_drawImage(1326, 49 + num1, y1, 20, 0);
          this.gfx_drawImage(1327, this.dynamic_X_RES - 48 - num1, y1, 24, 0);
        }
        int trans = 0;
        for (int x = num1; x < this.dynamic_X_RES; x += 451)
        {
          trans = trans != 0 ? 0 : 4;
          this.gfx_drawImage(1328, x, this.dynamic_Y_RES, 36, trans);
        }
      }
      if (this.themes_current != 2 || !this.p_inGame || this.doj_loading)
        return;
      this.gfx_drawImage(1420, num1 > 0 ? this.dynamic_X_RES - num1 - 87 - (this.dynamic_X_RES >> 6) : this.dynamic_X_RES - (this.dynamic_X_RES >> 2), this.dynamic_Y_RES >> 3, 20, 0);
      int x1 = 0;
      int num2 = 0;
      this.gfx_setClip(num1, this.dynamic_Y_RES - 134, this.dynamic_X_RES - (num1 << 1), 134);
      while (x1 < this.dynamic_X_RES)
      {
        this.gfx_drawImage(1391 + num2, x1, this.dynamic_Y_RES, 36, 0);
        x1 += this.gfx_getImageWidth(1391 + num2);
        num2 = (num2 + 1) % 3;
      }
      this.gfx_setClip(0, 0, this.dynamic_X_RES, this.dynamic_Y_RES);
    }

    public void doj_DrawHud()
    {
      int x = this.doj_screen_fp_posX >> 11;
      int imageId = this.themes_getImageId(4);
      int imageWidth = this.gfx_getImageWidth(imageId);
      int imageHeight = this.gfx_getImageHeight(imageId);
      this.gfx_drawImage(imageId - 1, x, 0, 20, 0);
      this.gfx_drawImage(imageId + 1, this.dynamic_X_RES - x, 0, 24, 0);
      this.gfx_fillAreaWithImage(imageId, imageWidth + x, 0, this.dynamic_X_RES - (imageWidth << 1) - (x << 1), imageHeight);
      int y = 32;
      int align = 36;
      int num1 = this.doj_screen_fp_posX >> 11;
      if (this.doj_score >= 0)
      {
        mrGame.MrGame.MrgString pAllText = this.p_allTexts[46];
        int length = this.doj_scoreCharArr.Length;
        int num2 = this.doj_score > 0 ? this.doj_score : -this.doj_score;
        int s;
        this.doj_scoreCharArr[s = length - 1] = (char) (48 + num2 % 10);
        int num3 = 0;
        while ((num2 /= 10) > 0)
        {
          if (++num3 % 3 == 0)
          {
            for (int index = pAllText.length() - 1; index >= 0; --index)
              this.doj_scoreCharArr[--s] = pAllText.charAt(index);
          }
          this.doj_scoreCharArr[--s] = (char) (48 + num2 % 10);
        }
        if (this.doj_score < 0)
          this.doj_scoreCharArr[--s] = '-';
        this.gfx_setColor(0);
        this.gfx_drawString(4, new mrGame.MrGame.MrgString(this.doj_scoreCharArr, s, this.doj_scoreCharArr.Length - s), (this.dynamic_X_RES >> 4) + num1, y, align);
      }
      if (!this.doj_gameOver)
        this.gfx_drawImage(this.themes_getImageId(885), this.dynamic_X_RES - (this.dynamic_X_RES >> 4) - num1, 0, 24, 0);
      if (!this.multiplayer_enabled)
        return;
      mrGame.MrGame.MrgString str = this.txt_stringParam(this.p_allTexts[93], (mrGame.MrGame.MrgString) string.Concat((object) (this.multiplayer_player + 1)), 1).toLowerCase();
      int num4 = this.gfx_stringWidth(4, (mrGame.MrGame.MrgString) "9,999,999");
      if (this.gfx_stringWidth(3, str) + ((this.dynamic_X_RES >> 4) + x + num1) + num4 > this.dynamic_X_RES)
        str = (mrGame.MrGame.MrgString) ("P" + (object) (this.multiplayer_player + 1));
      this.gfx_setColor(0);
      this.gfx_drawString(3, str, this.dynamic_X_RES - 31 - (this.dynamic_X_RES >> 4) - x, 0, 24);
    }

    public void doj_DrawBorders()
    {
      if (this.doj_screen_fp_posX == 0)
        return;
      int num = this.doj_screen_fp_posX >> 11;
      int id = 764;
      if (this.themes_current == 3)
        id = 1334;
      if (this.themes_current == 4)
        id = 1558;
      if (this.themes_current == 2)
        id = 1424;
      if (this.themes_current == 1)
        id = 1221;
      this.gfx_fillAreaWithImage(this.themes_getImageId(id), 0, 0, num, this.dynamic_Y_RES);
      this.gfx_fillAreaWithImage(this.themes_getImageId(id), this.dynamic_X_RES - num, 0, num, this.dynamic_Y_RES);
      this.gfx_fillAreaWithImage(this.themes_getImageId(765), num, 0, 4, this.dynamic_Y_RES);
      this.gfx_fillAreaWithImage(this.themes_getImageId(765), this.dynamic_X_RES - num, 0, 4, this.dynamic_Y_RES);
    }

    public void game_paint()
    {
      if (this.doj_loading)
        this.doj_loading = false;
      if (this.p_mainGroupsLoaded)
      {
        this.doj_DrawGameBackground();
        this.dojxbla_drawMarkers();
        if (!this.doj_gameOver)
        {
          if (this.multiplayer_enabled)
            this.highscores_draw_multiplayer_markers();
          else
            this.highscores_draw_local_markers();
          this.objects_drawBackground();
          this.particles_drawBackground();
          this.platforms_draw();
          this.objects_draw();
          bool flag1 = true;
          if ((this.character_state & 33280) == 0)
          {
            if (!this.doj_endGameSeq)
            {
              this.character_draw();
            }
            else
            {
              flag1 = false;
              this.debug_text((mrGame.MrGame.MrgString) "not drawing char anymore");
            }
          }
          this.projectiles_draw();
          this.particles_drawForeground();
          if (flag1)
            this.doj_DrawGameForeground();
          bool flag2 = false;
          if (this.doj_endGameSeq && !flag2)
          {
            this.eg_paint();
            this.doj_drawGameOverScreen();
          }
          this.doj_DrawHud();
          this.doj_DrawBorders();
          if (!this.popup_active)
            return;
          this.popup_paint();
        }
        else if (this.multiplayer_enabled)
        {
          this.doj_DrawGameForeground();
          this.doj_DrawHud();
          this.doj_DrawBorders();
          this.doj_drawMultiplayerGameOverScreen();
        }
        else
        {
          if ((!this.p_game_menuInited || this.p_em_stackPos < 0 ? 0 : this.p_em_menuStack[this.p_em_stackPos]) == 11 || (!this.p_game_menuInited || this.p_em_stackPos < 0 ? 0 : this.p_em_menuStack[this.p_em_stackPos]) == 12)
            return;
          this.doj_DrawGameForeground();
          this.doj_drawGameOverScreen();
          this.eg_paint();
          this.doj_DrawHud();
          this.doj_DrawBorders();
        }
      }
      else
      {
        this.gfx_setColor(0);
        this.gfx_fillRect(0, 0, this.dynamic_X_RES, this.dynamic_Y_RES);
      }
    }

    public void game_resolutionChanged()
    {
      if (this.p_mainGroupsLoaded)
        this.doj_updateScreenSizes();
      this.repaintAll = true;
    }

    public void game_hideNotify()
    {
    }

    public void game_showNotify()
    {
      if (!this.p_inGame || !this.p_gameDisplay && this.p_inGame || this.doj_gameOver || this.popup_active)
        return;
      this.mrg_resetKeys();
      this.repaintAll = true;
      this.repaintScreen = true;
      this.sfx_pauseAll();
      this.mrg_requestIngameMenu();
    }

    public void doj_updateScreenSizes()
    {
      int num = (this.dynamic_X_RES << 11) / this.dynamic_Y_RES;
      this.common_fp_screenWidth = this.dynamic_X_RES << 11;
      this.common_fp_screenHeight = this.dynamic_Y_RES << 11;
      if (num > 1638)
      {
        this.common_fp_screenWidth = this.common_fp_screenHeight * 80 / 100;
        this.doj_screen_fp_posX = (this.dynamic_X_RES << 11) - this.common_fp_screenWidth >> 1;
      }
      else
        this.doj_screen_fp_posX = 0;
      this.common_fp_xRatio = this.fp_div(this.common_fp_screenWidth, this.common_fp_configLogicScreenWidth);
      this.common_fp_yRatio = this.fp_div(this.common_fp_screenHeight, this.common_fp_configLogicScreenHeight);
      this.platforms_fp_width = this.fp_mul(this.common_fp_xRatio, this.platforms_fp_wWidth);
      this.character_fp_width = this.fp_div(88064, this.common_fp_xRatio);
      this.character_fp_height = this.fp_div(133120, this.common_fp_yRatio);
      this.doj_fp_pixelAccX = this.common_fp_configNormalAccX / ((this.dynamic_X_RES >> 1) - (this.dynamic_X_RES >> 3));
      if (!this.p_inGame || !this.p_gameDisplay && this.p_inGame && !this.doj_gameOver)
      {
        this.menu_screenSizeUpdate();
      }
      else
      {
        if (!this.doj_gameOver && !this.popup_active)
          this.mrg_requestIngameMenu();
        if (this.doj_gameOver)
        {
          this.eg_reset();
          this.menu_reinitializeEndGameMenu();
        }
      }
      if (!this.popup_active)
        return;
      this.popup_screenSizeUpdate();
    }

    public int doj_worldToScreenX(int fp_x)
    {
      return this.fp_mul(fp_x, this.common_fp_xRatio) + this.doj_screen_fp_posX >> 11;
    }

    public int doj_worldToScreenY(int fp_y)
    {
      return -(this.fp_mul(fp_y, this.common_fp_yRatio) >> 11) + this.dynamic_Y_RES;
    }

    public void doj_stopWarningSounds()
    {
      if (this.doj_sfx_ufoWarning)
      {
        this.sfx_stop(19);
        this.doj_sfx_ufoWarning = false;
      }
      if (!this.doj_sfx_monsterWarning)
        return;
      this.sfx_stop(12);
      this.doj_sfx_monsterWarning = false;
    }

    public bool achievement_isSet(int index) => ((int) this.mAchievements & 1 << index) != 0;

    public void achievement_allocate()
    {
      this.mAchievementStats = new sbyte[13];
      this.achievement_start();
    }

    public void achievement_free()
    {
      this.mAchievementStats = (sbyte[]) null;
      this.mAchievementLimits = (sbyte[]) null;
    }

    public void achievement_clear() => this.mAchievements = (short) 0;

    public void achievement_reset()
    {
      this.achievement_clear();
      this.achievement_save();
    }

    public void achievement_start()
    {
      for (int index = 0; index < 13; ++index)
        this.mAchievementStats[index] = (sbyte) 0;
    }

    public void achievement_load()
    {
      this.mAchievements = (short) ((int) this.p_options[9] << 8 & 65280 | (int) this.p_options[10] & (int) byte.MaxValue);
      this.mAchievementLimits = this.p_getFile_byte(0, 0, 11, (sbyte[]) null);
    }

    public void achievement_save()
    {
      this.p_options[9] = (sbyte) ((int) this.mAchievements >> 8);
      this.p_options[10] = (sbyte) ((int) this.mAchievements << 8 >> 8);
      this.mrg_saveOptions();
    }

    public void achievement_clearStat(int achievement)
    {
      this.mAchievementStats[achievement - 1] = (sbyte) 0;
    }

    public void achievement_add(int achievement)
    {
      ++this.mAchievementStats[achievement - 1];
      this.debug_text((mrGame.MrGame.MrgString) ("achieveID: " + (object) (achievement - 1) + " count: " + (object) this.mAchievementStats[achievement - 1]));
      if ((int) this.mAchievementStats[achievement - 1] < (int) this.mAchievementLimits[achievement - 1])
        return;
      this.achievement_award(achievement);
    }

    public void achievement_award(int achievement)
    {
      this.mAchievements |= (short) (1 << achievement);
      this.dojxbla_reportAchievement(achievement);
    }

    public void achievement_checkAll()
    {
      for (int index = 0; index < 13; ++index)
      {
        if (this.xbla_achievement_isCompleted(this.dojxbla_getkey(index)))
          this.mAchievements |= (short) (1 << index);
        if (((int) this.mAchievements & 1 << index) != 0)
          this.dojxbla_reportAchievement(index);
      }
    }

    public void achievement_preinit() => this.achievement_allocate();

    public void achievement_init()
    {
      this.debug_text((mrGame.MrGame.MrgString) "init achievements");
      this.achievement_checkAll();
      this.achievement_addTb();
    }

    public void achievement_createGui() => this.p_tb_handleInput(-1, true);

    public void achievement_addTb()
    {
      mrGame.MrGame.StringBuffer stringBuffer = new mrGame.MrGame.StringBuffer();
      for (int index = 0; index < 13; ++index)
      {
        mrGame.MrGame.MrgString s = this.txt_stringParam(this.p_allTexts[142], (mrGame.MrGame.MrgString) string.Concat((object) (200 + index)), 1);
        stringBuffer.append(s);
      }
      this.p_tb_makeBordered(3, stringBuffer.toString(), this.dynamic_X_RES - 420, 140, 420, 540, 0, 0, 0, true);
      this.p_tb_handleInput(-1, true);
    }

    public void achievement_paint()
    {
      int x = this.dynamic_X_RES - 420;
      int y = 140;
      int num1 = 420;
      int num2 = 540;
      this.gfx_setColor(13747632);
      this.gfx_fillRect(x, y, num1, num2);
      this.tb_drawEx(this.p_tbFont, this.p_tbTextX, this.p_tbTextY, this.p_tb_scroll >> 10);
      this.achievementPaintBox(x, y, num1, num2);
      this.achievement_paintCharacter();
    }

    public void achievement_paintCharacter()
    {
      int x1 = 15;
      int y = this.dynamic_Y_RES - 30;
      int id1 = 37;
      int id2 = 38;
      int id3 = 39;
      this.gfx_drawImage(this.themes_getImageId(id1), x1, y, 20, 0);
      int x2 = x1 + this.gfx_getImageWidth(this.themes_getImageId(id1));
      int width = 85 - this.gfx_getImageWidth(this.themes_getImageId(id1)) - this.gfx_getImageWidth(this.themes_getImageId(id3));
      int num = 0;
      if (width < 0)
      {
        num = width;
        width = 0;
      }
      this.platform_fillHorizontal(this.themes_getImageId(id2), x2, y, width);
      int x3 = x2 + (width + num);
      this.gfx_drawImage(this.themes_getImageId(id3), x3, y, 20, 0);
      this.gfx_drawImage(42, 67, y, 33, 4);
    }

    public void achievement_paintItem(int index, int x, int y)
    {
      this.gfx_drawImage(this.achievement_isSet(index) ? 50 + index : 49, x, y, 20, 0);
      y -= 10;
      x -= 10;
      this.gfx_drawString(3, this.p_allTexts[115 + index], x + 72 + 20, y + 15, 20);
      mrGame.MrGame.MrgString pAllText = this.p_allTexts[128 + index];
      y += 40;
      this.gfx_drawString(6, pAllText, x + 72 + 20, y + 15, 20);
    }

    public void achievement_paintSliderBase(int index, int x, int y)
    {
      int imageindex = index % 2 == 0 ? 65 : 66;
      for (; x < this.dynamic_X_RES; x += this.gfx_getImageWidth(imageindex))
        this.gfx_drawImage(imageindex, x, y, 20, 0);
    }

    public void achievementPaintBox(int x, int y, int width, int height)
    {
      x -= 24;
      y -= 24;
      height += 48;
      width += 24;
      int num1 = 67;
      int imageWidth = this.gfx_getImageWidth(num1);
      int imageHeight = this.gfx_getImageHeight(num1);
      int num2 = imageWidth / 2;
      int num3 = imageHeight / 3;
      int num4 = imageHeight - 2 * num3;
      int num5 = num2;
      int num6 = num3 + num4;
      int w = width - num5;
      int h = height - num6;
      if (w < 0)
      {
        x += w >> 1;
        w = 0;
        width = num5;
      }
      if (h < 0)
      {
        y += h >> 1;
        h = 0;
        height = num6;
      }
      this.gfx_drawSubImage(num1, x, y, 20, num2, num3, 0, 0);
      this.gfx_drawSubImage(num1, x, y + height - num4, 20, num2, num4, 0, imageHeight - num4);
      this.fillAreaWithSubImage(num1, x + num2, y, w, num3, num2, num3, num2, 0);
      this.fillAreaWithSubImage(num1, x, y + num3, num2, h, num2, num3, 0, num3);
      this.fillAreaWithSubImage(num1, x + num2, y + height - num4, w, num4, num2, num4, num2, imageHeight - num4);
    }

    public void fillAreaWithSubImage(
      int img,
      int x,
      int y,
      int w,
      int h,
      int xsize,
      int ysize,
      int xp,
      int yp)
    {
      for (int index1 = 0; index1 < h; index1 += ysize)
      {
        for (int index2 = 0; index2 < w; index2 += xsize)
        {
          int xsize1 = xsize <= w - index2 ? xsize : w - index2;
          int ysize1 = ysize <= h - index1 ? ysize : h - index1;
          this.gfx_drawSubImage(img, x + index2, y + index1, 20, xsize1, ysize1, xp, yp);
        }
      }
    }

    public mrGame.MrGame.MrgString dojxbla_getkey(int index)
    {
      switch (index)
      {
        case 0:
          return (mrGame.MrGame.MrgString) "DOJ_SPRING_SHOES_JUMPER";
        case 1:
          return (mrGame.MrGame.MrgString) "DOJ_SERIAL_SPRINGER";
        case 2:
          return (mrGame.MrGame.MrgString) "DOJ_SUPER_SERIAL_SPRINGER";
        case 3:
          return (mrGame.MrGame.MrgString) "DOJ_MONSTER_BOUNCER";
        case 4:
          return (mrGame.MrGame.MrgString) "DOJ_SUPER_MONSTER_BOUNCER";
        case 5:
          return (mrGame.MrGame.MrgString) "DOJ_CONFLICT_AVOIDER";
        case 6:
          return (mrGame.MrGame.MrgString) "DOJ_SUPER_CONFLICT_AVOIDER";
        case 7:
          return (mrGame.MrGame.MrgString) "DOJ_SHARP_SHOOTER";
        case 8:
          return (mrGame.MrGame.MrgString) "DOJ_SUPER_SHARP_SHOOTER";
        case 9:
          return (mrGame.MrGame.MrgString) "DOJ_PROPELLERHEAD";
        case 10:
          return (mrGame.MrGame.MrgString) "DOJ_JETPACK_RIDER";
        case 11:
          return (mrGame.MrGame.MrgString) "DOJ_OLD_FASHIONED_JUMPER";
        case 12:
          return (mrGame.MrGame.MrgString) "DOJ_UFO_ABDUCTION_SURVIVOR";
        default:
          return (mrGame.MrGame.MrgString) "";
      }
    }

    public void dojxbla_preinit() => this.dxIsAuthenticated = false;

    public void dojxbla_leaderboards_init()
    {
      this.dxResultIndex = !this.xbla_isAvailable() || !this.xbla_isAuthenticated() ? 1 : 0;
      this.dxCheckRequest = false;
      this.dxScoresId = -1;
      this.dxErrorRequest = false;
      this.dojxbla_requestScores();
      this.hs_load(0);
      this.dxIsAuthenticated = this.xbla_isAuthenticated();
    }

    public void dojxbla_free() => this.hs_unload();

    public void dojxbla_update()
    {
    }

    public void dojxbla_leaderboardUpdate()
    {
      if (!this.xbla_isAvailable() || !this.xbla_isAuthenticated())
        return;
      if (!this.dxIsAuthenticated && this.xbla_isAuthenticated())
      {
        this.dxIsAuthenticated = true;
        this.dojxbla_requestScores();
      }
      if (this.dxResultIndex != this.leaderboards_getCurrent())
      {
        this.debug_text((mrGame.MrGame.MrgString) "========================================change screen");
        this.dxResultIndex = this.leaderboards_getCurrent();
        this.dojxbla_closeTb();
        if (this.dxResultIndex != 0)
          this.dojxbla_addTb(1);
        else if (this.dxIsAuthenticated)
          this.dojxbla_addTb(0);
      }
      if (this.dxResultIndex == 0)
        this.dojxbla_display_NotConnected();
      this.dojxbla_updateRequest();
    }

    public mrGame.MrGame.MrgString dojxbla_getPlayerName()
    {
      return this.xbla_isAuthenticated() ? this.xbla_getPlayerId() : (mrGame.MrGame.MrgString) "";
    }

    public void dojxbla_reportAchievement(int index)
    {
      this.xbla_AwardAchievement(this.dojxbla_getkey(index));
    }

    public void dojxbla_reportResult(int result)
    {
      this.xbla_leaderboard_reportScore(0, 0, (long) result);
    }

    public bool dojxbla_isLoading() => this.dxCheckRequest;

    public mrGame.MrGame.MrgString dojxbla_getLeaderboardText()
    {
      mrGame.MrGame.StringBuffer stringBuffer = new mrGame.MrGame.StringBuffer();
      if (this.xbla_isAvailable() && this.xbla_isAuthenticated())
        stringBuffer.append(this.p_allTexts[144]);
      if (!this.dxCheckRequest && !this.dxErrorRequest && this.dxScoresId != -1)
      {
        int size = this.xbla_leaderboard_getSize(this.dxScoresId);
        for (int index = 0; index < size; ++index)
        {
          mrGame.MrGame.MrgString s = this.txt_stringParam(this.p_allTexts[142], (mrGame.MrGame.MrgString) string.Concat((object) (300 + index)), 1);
          stringBuffer.append(s);
        }
      }
      else if (this.dxErrorRequest || this.dxScoresId == -1)
        stringBuffer.append(this.p_allTexts[110]);
      return stringBuffer.toString();
    }

    public mrGame.MrGame.MrgString dojxbla_getLeaderboardRankAndName(int index)
    {
      return this.txt_stringParam(this.txt_stringParam(this.p_allTexts[143], (mrGame.MrGame.MrgString) string.Concat((object) (int) this.xbla_leaderboard_getRank(this.dxScoresId, index)), 1), this.dojxbla_getName(index), 2);
    }

    public mrGame.MrGame.MrgString dojxbla_getLeaderboardLocalRankAndName(int index)
    {
      return this.txt_stringParam(this.txt_stringParam(this.p_allTexts[143], (mrGame.MrGame.MrgString) string.Concat((object) this.hs_data_int[index + 10]), 1), this.hs_data_string[index], 2);
    }

    public mrGame.MrGame.MrgString dojxbla_getLeaderboardScore(int index)
    {
      return this.txt_addThousandSeparator_s((int) this.xbla_leaderboard_getScore(this.dxScoresId, index), this.p_allTexts[46]);
    }

    public mrGame.MrGame.MrgString dojxbla_getLeaderboardLocalScore(int index)
    {
      return this.hs_data_int[index] < 0 ? (mrGame.MrGame.MrgString) "" : this.txt_addThousandSeparator_s(this.hs_data_int[index], this.p_allTexts[46]);
    }

    public mrGame.MrGame.MrgString dojxbla_getName(int index)
    {
      return this.xbla_leaderboard_getAlias(this.dxScoresId, index);
    }

    public void dojxbla_requestScores()
    {
      if (!this.xbla_isAvailable() || !this.xbla_isAuthenticated())
      {
        this.dojxbla_addTb(1);
      }
      else
      {
        this.dojxbla_closeScores();
        this.dxErrorRequest = false;
        this.dxScoresId = this.xbla_leaderboard_load(0, false, 0, 100, 0, 0);
        if (this.dxScoresId > -1)
          this.dxErrorRequest = this.xbla_leaderboard_getError(this.dxScoresId) != 0;
        if (!this.dxErrorRequest)
          this.dxCheckRequest = true;
        this.dojxbla_addTb(0);
      }
    }

    public void dojxbla_closeScores()
    {
      this.dxScoresId = -1;
      this.dxCheckRequest = false;
      this.dxErrorRequest = false;
    }

    public void dojxbla_updateRequest()
    {
      if (!this.xbla_isAvailable() || !this.xbla_isAuthenticated())
      {
        this.dxCheckRequest = false;
      }
      else
      {
        if (!this.dxCheckRequest || this.dxScoresId <= -1 || !this.xbla_leaderboard_isReady(this.dxScoresId))
          return;
        this.dxCheckRequest = false;
        this.debug_text((mrGame.MrGame.MrgString) "============================================================show results");
        if (this.leaderboards_getCurrent() != 0)
          return;
        this.dojxbla_addTb(0);
      }
    }

    public void dojxbla_drawMarkers()
    {
      if (!this.xbla_isAvailable() || !this.xbla_isAuthenticated() || this.dxScoresId <= -1 || !this.xbla_leaderboard_isReady(this.dxScoresId))
        return;
      for (int index = 0; index < 100; ++index)
      {
        int score = (int) this.xbla_leaderboard_getScore(this.dxScoresId, index);
        if (score <= 0)
          break;
        int screenY = this.doj_worldToScreenY((score << 11) - this.doj_fp_screenYOffset);
        int num = this.doj_screen_fp_posX >> 11;
        if (screenY >= -3 && screenY <= this.dynamic_Y_RES + 3)
        {
          this.gfx_drawImage(this.themes_getImageId(884), this.dynamic_X_RES - num, screenY, 10, 0);
          int y = screenY - this.gfx_getFontHeight(7);
          this.gfx_setColor(0);
          this.gfx_drawString(7, this.dojxbla_getName(index), this.dynamic_X_RES - num, y, 24);
        }
      }
    }

    public void dojxbla_closeTb()
    {
    }

    public mrGame.MrGame.MrgString dojxbla_getLocalLeaderboardText()
    {
      mrGame.MrGame.StringBuffer stringBuffer = new mrGame.MrGame.StringBuffer();
      if (this.xbla_isAvailable() && this.xbla_isAuthenticated())
        stringBuffer.append(this.p_allTexts[144]);
      for (int index = 0; index < 10; ++index)
      {
        mrGame.MrGame.MrgString s = this.txt_stringParam(this.p_allTexts[142], (mrGame.MrGame.MrgString) string.Concat((object) (300 + index)), 1);
        stringBuffer.append(s);
      }
      return stringBuffer.toString();
    }

    public void dojxbla_addTb(int id)
    {
      if (id == 0)
      {
        int size = this.xbla_leaderboard_getSize(this.dxScoresId);
        this.leaderboards_addTb(this.dojxbla_getLeaderboardText(), this.dxCheckRequest || this.dxScoresId == -1 || this.dxErrorRequest || size < 10);
      }
      else
        this.leaderboards_addTb(this.dojxbla_getLocalLeaderboardText(), false);
    }

    public void dojxbla_paintRequest(int xcen, int ycen)
    {
      if (!this.xbla_isAvailable() || !this.xbla_isAuthenticated())
        this.dojxbla_display_NotConnected();
      else if (this.dxCheckRequest && this.dxScoresId > -1 && !this.dxErrorRequest)
      {
        if (!this.xbla_leaderboard_isReady(this.dxScoresId))
        {
          this.egfx_push();
          this.egfx_rotateAbout(this.smoothtime % 2048 << 5, xcen, ycen);
          this.gfx_drawImage(48, xcen, ycen, 3, 0);
          this.egfx_pop();
        }
        else
          this.dojxbla_display_NotConnected();
      }
      else
        this.dojxbla_display_NotConnected();
    }

    public void dojxbla_display_NotConnected()
    {
      if (this.xbla_leaderboard_getError(this.dxScoresId) == 0)
        return;
      int num = 0;
      int x = 84;
      int y = 230;
      while (num < 3)
      {
        if (num == 0)
        {
          mrGame.MrGame.MrgString pAllText = this.p_allTexts[111];
          this.gfx_setColor(0);
          this.gfx_drawString(3, pAllText, x, y, 20);
        }
        else if (1 == num)
        {
          mrGame.MrGame.MrgString pAllText = this.p_allTexts[112];
          this.gfx_setColor(0);
          this.gfx_drawString(3, pAllText, x, y, 20);
        }
        else if (2 == num)
        {
          mrGame.MrGame.MrgString pAllText = this.p_allTexts[113];
          this.gfx_setColor(0);
          this.gfx_drawString(3, pAllText, x, y, 20);
        }
        ++num;
        y += 72;
      }
    }

    public void leaderboards_preinit()
    {
    }

    public void leaderboards_init()
    {
      this.debug_text((mrGame.MrGame.MrgString) "init leaderboards");
      this.leaderboardIndex = !this.xbla_isAvailable() || !this.xbla_isAuthenticated() ? 1 : 0;
      this.dojxbla_leaderboards_init();
    }

    public int leaderboards_getCurrent() => this.leaderboardIndex;

    public void leaderboards_addTb(mrGame.MrGame.MrgString text, bool crop)
    {
      this.p_tb_makeBordered(3, text, this.dynamic_X_RES - 420, 140, 420, 540, 0, 0, crop ? 8 : 0, true);
      this.p_tb_handleInput(-1, true);
    }

    public int leaderboards_getTbType() => this.leaderboardIndex;

    public void leaderboards_createGui()
    {
      this.debug_text((mrGame.MrGame.MrgString) "leaderboards: create gui");
      this.p_tb_handleInput(-1, true);
    }

    public void leaderboards_update() => this.dojxbla_leaderboardUpdate();

    public void leaderboards_change(bool friends)
    {
      if (!this.xbla_isAvailable() || !this.xbla_isAuthenticated())
        return;
      this.leaderboardIndex = friends ? 0 : 1;
    }

    public void leaderboards_paintButton(int x, int y, int w, int h, bool friends)
    {
      int num = 69;
      if (this.leaderboardIndex == 0 && friends || this.leaderboardIndex == 1 && !friends)
        --num;
      for (int x1 = x; x1 < x + w; x1 += this.gfx_getImageWidth(num))
      {
        if (x1 > x + w - this.gfx_getImageWidth(num))
          this.gfx_drawSubImage(num, x1, y, 20, this.gfx_getImageWidth(num) - (x1 - (x + w - this.gfx_getImageWidth(num))), this.gfx_getImageHeight(num), 0, 0);
        else
          this.gfx_drawImage(num, x1, y, 20, 0);
      }
      if (friends)
      {
        this.gfx_drawImage(70, x + w, y, 20, 0);
        this.gfx_drawString(3, this.p_allTexts[114], x + (w >> 1), y + (h - this.gfx_getFontHeight(3) >> 1), 17);
      }
      else
      {
        this.gfx_drawImage(70, x - 1, y, 20, 0);
        this.gfx_drawString(3, this.p_allTexts[141], x + (w >> 1), y + (h - this.gfx_getFontHeight(3) >> 1), 17);
      }
    }

    public void leaderboards_pointerPressed()
    {
      if (this.p_touchdata[this.p_mt_last].upy <= 140 || this.p_touchdata[this.p_mt_last].upx <= this.dynamic_X_RES - 420 || this.p_touchdata[this.p_mt_last].upy >= 212 - (this.p_tb_scroll >> 10))
        return;
      if (this.p_touchdata[this.p_mt_last].upx < this.dynamic_X_RES - 210)
        this.leaderboards_change(true);
      else
        this.leaderboards_change(false);
    }

    public void leaderboards_paint()
    {
      int x = this.dynamic_X_RES - 420;
      int y = 140;
      int num1 = 420;
      int num2 = 540;
      this.gfx_setColor(13747632);
      this.gfx_fillRect(x, y, num1, num2);
      this.tb_drawEx(this.p_tbFont, this.p_tbTextX, this.p_tbTextY, this.p_tb_scroll >> 10);
      this.achievementPaintBox(x, y, num1, num2);
      this.achievement_paintCharacter();
      if (this.leaderboardIndex != 0)
        return;
      this.dojxbla_paintRequest(x + (num1 >> 1), y + (num2 >> 1));
    }

    public class Image : IComparable
    {
      public int width;
      public int height;
      public int x;
      public int y;
      public int size;
      public uint[] data;
      public Texture2D tex;
      public bool gp;
      public Vector2 t1;
      public Vector2 t2;

      public int CompareTo(object obj)
      {
        if (obj is mrGame.MrGame.Image image)
          return image.height - this.height;
        throw new ArgumentException("Object is not an Image");
      }
    }

    public class ByteInput
    {
      public sbyte[] buf;
      public int pos;
      public int limit;
      public int flags;

      public virtual void fillbuf(int bytesneeded)
      {
      }

      public virtual mrGame.MrGame.ByteInput close() => this;
    }

    public class DataByteInput : mrGame.MrGame.ByteInput
    {
      public Stream stream;

      public override void fillbuf(int readahead)
      {
        if (this.pos > this.limit)
        {
          this.stream.Seek((long) (this.pos - this.limit), SeekOrigin.Current);
          this.pos = this.limit;
        }
        Array.Copy((Array) this.buf, this.pos, (Array) this.buf, 0, this.limit - this.pos);
        this.limit -= this.pos;
        this.pos = 0;
        byte[] numArray = new byte[this.buf.Length - this.limit];
        int count = this.stream.Read(numArray, 0, numArray.Length);
        Buffer.BlockCopy((Array) numArray, 0, (Array) this.buf, this.limit, count);
        this.limit += count;
      }

      public override mrGame.MrGame.ByteInput close()
      {
        this.stream.Flush();//.Close();
        return (mrGame.MrGame.ByteInput) this;
      }
    }

    public class EmergeTouch
    {
      public int dnx;
      public int dny;
      public int upx;
      public int upy;
      public long dnt;
      public long upt;
      public int state;
      public int tid;
    }

    public class MrgString
    {
      private string str;

      public MrgString() => this.str = string.Empty;

      public MrgString(string s)
      {
        if (s == null)
          this.str = string.Empty;
        else
          this.str = s;
      }

      public MrgString(char[] a, int s, int e)
      {
        try
        {
          if (0 < e)
            this.str = new string(a, s, e);
          else
            this.str = string.Empty;
        }
        catch
        {
          this.str = string.Empty;
        }
      }

      public static implicit operator mrGame.MrGame.MrgString(string s)
      { 
                return new mrGame.MrGame.MrgString(s); 
      }
             

      public static implicit operator mrGame.MrGame.MrgString(char c)
      {
        return new mrGame.MrGame.MrgString(string.Concat((object) c));
      }

      public static implicit operator mrGame.MrGame.MrgString(short i)
      {
        return new mrGame.MrGame.MrgString(string.Concat((object) i));
      }

      public static implicit operator mrGame.MrGame.MrgString(int i)
      {
        return new mrGame.MrGame.MrgString(string.Concat((object) i));
      }

      public static implicit operator mrGame.MrGame.MrgString(long i)
      {
        return new mrGame.MrGame.MrgString(string.Concat((object) i));
      }

      public static bool operator ==(mrGame.MrGame.MrgString a, mrGame.MrGame.MrgString b)
      {
        return object.Equals((object) a, (object) null) || a.length() == 0 
                    ? object.Equals((object) b, (object) null) 
                    || b.length() == 0 : !object.Equals((object) b, (object) null) && b.length() != 0 
                    && object.Equals((object) a.str, (object) b.str);
      }

      public static bool operator !=(mrGame.MrGame.MrgString a, mrGame.MrGame.MrgString b)
      {
        return !(a == b);
      }

      public static mrGame.MrGame.MrgString operator +(mrGame.MrGame.MrgString a, mrGame.MrGame.MrgString b)
      {
        return new mrGame.MrGame.MrgString(a.str + b.str);
      }

      public char this[int key] => this.str[key];

      public string toString() => this.str;

      public override bool Equals(object o) => this == o as mrGame.MrGame.MrgString;

      public override int GetHashCode() => this.str == null ? 0 : this.str.GetHashCode();

      public char charAt(int index) => this.str[index];

      public bool equals(mrGame.MrGame.MrgString another)
      {
        return another != (mrGame.MrGame.MrgString) null && this.str == another.str;
      }

      public int indexOf(char needle) => this.str.IndexOf(needle);

      public int indexOf(mrGame.MrGame.MrgString needle) => this.str.IndexOf(needle.str);

      public int lastIndexOf(char needle) => this.str.LastIndexOf(needle);

      public int lastIndexOf(char needle, int start) => this.str.LastIndexOf(needle, start);

      public int length() => this.str.Length;

      public int len => this.str.Length;

      public bool startsWith(mrGame.MrGame.MrgString what) => this.str.StartsWith(what.str);

      public mrGame.MrGame.MrgString substring(int from)
      {
        return new mrGame.MrGame.MrgString(this.str.Substring(from));
      }

      public mrGame.MrGame.MrgString substring(int from, int to)
      {
        return new mrGame.MrGame.MrgString(this.str.Substring(from, to - from));
      }

      public mrGame.MrGame.MrgString toLowerCase() => new mrGame.MrGame.MrgString(this.str.ToLower());

      public mrGame.MrGame.MrgString toUpperCase() => new mrGame.MrGame.MrgString(this.str.ToUpper());
    }

    private class StringBuffer
    {
      private string str = string.Empty;

      public void append(object c) => this.str += (string) c;

      public mrGame.MrGame.MrgString toString() => new mrGame.MrGame.MrgString(this.str);

      public void append(char c) => this.str += (string) (object) c;

      public void append(string s) => this.str += s;

      public void append(mrGame.MrGame.MrgString s)
      {
        this.str += s != (mrGame.MrGame.MrgString) null ? s.toString() : string.Empty;
      }

      public void append(int i) => this.str += (string) (object) i;
    }

    public class Sound
    {
      private Stream stream;
      private int start;
      private int end;
      private int pos;
      private int mBufferSize;
      private int mSampleRate;
      private AudioChannels mChannels;
      private SoundEffect sndResource;
      private List<SoundEffectInstance> clips = new List<SoundEffectInstance>();
      private int adpcmstate;
      private static int[] adpcm_steptbl = new int[89]
      {
        7,
        8,
        9,
        10,
        11,
        12,
        13,
        14,
        16,
        17,
        19,
        21,
        23,
        25,
        28,
        31,
        34,
        37,
        41,
        45,
        50,
        55,
        60,
        66,
        73,
        80,
        88,
        97,
        107,
        118,
        130,
        143,
        157,
        173,
        190,
        209,
        230,
        253,
        279,
        307,
        337,
        371,
        408,
        449,
        494,
        544,
        598,
        658,
        724,
        796,
        876,
        963,
        1060,
        1166,
        1282,
        1411,
        1552,
        1707,
        1878,
        2066,
        2272,
        2499,
        2749,
        3024,
        3327,
        3660,
        4026,
        4428,
        4871,
        5358,
        5894,
        6484,
        7132,
        7845,
        8630,
        9493,
        10442,
        11487,
        12635,
        13899,
        15289,
        16818,
        18500,
        20350,
        22385,
        24623,
        27086,
        29794,
        (int) short.MaxValue
      };
      private static int[] adpcm_indtbl = new int[16]
      {
        -1,
        -1,
        -1,
        -1,
        2,
        4,
        6,
        8,
        -1,
        -1,
        -1,
        -1,
        2,
        4,
        6,
        8
      };
      private static int[] adpcm_prec_deltas = new int[1424];

      public Sound(Stream stream, int start, int end, int audioFormat)
      {
        this.start = start;
        this.end = end;
        this.pos = start;
        this.mSampleRate = 44100;
        this.mChannels = AudioChannels.Mono;
        this.stream = stream;
        this.adpcmstate = 0;
        switch (audioFormat)
        {
          case 3:
            this.sndResource = new SoundEffect(this.GetWaveData(), 0, this.mBufferSize, this.mSampleRate, this.mChannels, 0, 0);
            break;
          case 19:
            this.sndResource = new SoundEffect(this.GetADPCMData(), 0, (end - start) * 4, this.mSampleRate, this.mChannels, 0, 0);
            break;
        }
        this.stream = (Stream) null;
      }

      public int Length() => (int) this.sndResource.Duration.TotalMilliseconds;

      private byte[] GetADPCMData()
      {
        int num = this.end - this.start;
        this.stream.Seek((long) this.start, SeekOrigin.Begin);
        byte[] adpcmData = new byte[num * 5 + 1 & -2];
        this.stream.Read(adpcmData, adpcmData.Length - num, num);
        this.adpcmstate = mrGame.MrGame.Sound.decodeadpcm(adpcmData, adpcmData.Length - num, adpcmData, 0, num, this.adpcmstate);
        return adpcmData;
      }

      private byte[] GetWaveData()
      {
        this.stream.Seek((long) this.start, SeekOrigin.Begin);
        BinaryReader binaryReader = new BinaryReader(this.stream);
        binaryReader.ReadInt32();
        binaryReader.ReadInt32();
        binaryReader.ReadInt32();
        binaryReader.ReadInt32();
        int num1 = binaryReader.ReadInt32();
        int num2 = (int) binaryReader.ReadInt16();
        int num3 = (int) binaryReader.ReadInt16();
        this.mSampleRate = binaryReader.ReadInt32();
        binaryReader.ReadInt32();
        int num4 = (int) binaryReader.ReadInt16();
        int num5 = (int) binaryReader.ReadInt16();
        this.mChannels = 1 != num3 ? AudioChannels.Stereo : AudioChannels.Mono;
        if (num1 == 18)
        {
          int count = (int) binaryReader.ReadInt16();
          binaryReader.ReadBytes(count);
        }
        int num6 = binaryReader.ReadInt32();
        int count1 = binaryReader.ReadInt32();
        while (num6 != 1635017060)
        {
          binaryReader.ReadBytes(count1);
          num6 = binaryReader.ReadInt32();
          count1 = binaryReader.ReadInt32();
        }
        int count2 = count1 & -2;
        byte[] waveData = binaryReader.ReadBytes(count2);
        this.mBufferSize = waveData.Length;
        return waveData;
      }

      public void Play(int loops)
      {
        try
        {
          SoundEffectInstance instance = this.sndResource.CreateInstance();
          if (loops != 1)
            instance.IsLooped = true;
          this.clips.Add(instance);
          instance.Play();
        }
        catch
        {
        }
      }

      public void Stop()
      {
        try
        {
          for (int index = 0; index < this.clips.Count; ++index)
          {
            this.clips[index].Stop();
            this.clips[index].Dispose();
          }
          this.clips.Clear();
        }
        catch
        {
        }
      }

      public void Pause()
      {
        for (int index = 0; index < this.clips.Count; ++index)
        {
          if (this.clips[index].State == SoundState.Playing)
            this.clips[index].Pause();
        }
      }

      public void Resume()
      {
        try
        {
          for (int index = 0; index < this.clips.Count; ++index)
          {
            if (SoundState.Paused == this.clips[index].State)
              this.clips[index].Resume();
          }
        }
        catch
        {
        }
      }

      public void Logic()
      {
        try
        {
          for (int index = 0; index < this.clips.Count; ++index)
          {
            if (SoundState.Stopped == this.clips[index].State)
            {
              this.clips[index].Dispose();
              this.clips.RemoveAt(index);
              --index;
            }
          }
        }
        catch
        {
        }
      }

      public void Close()
      {
        try
        {
          for (int index = 0; index < this.clips.Count; ++index)
          {
            if (!this.clips[index].IsDisposed)
            {
              this.clips[index].Stop();
              this.clips[index].Dispose();
            }
          }
          this.clips.Clear();
          this.sndResource.Dispose();
        }
        catch
        {
        }
      }

      static Sound()
      {
        for (int index1 = 0; index1 < 89; ++index1)
        {
          int num1 = mrGame.MrGame.Sound.adpcm_steptbl[index1];
          for (int index2 = 0; index2 < 16; ++index2)
          {
            int num2 = num1 >> 3;
            if ((index2 & 1) != 0)
              num2 += num1 >> 2;
            if ((index2 & 2) != 0)
              num2 += num1 >> 1;
            if ((index2 & 4) != 0)
              num2 += num1;
            if ((index2 & 8) != 0)
              num2 = -num2;
            int num3 = index1 + mrGame.MrGame.Sound.adpcm_indtbl[index2];
            if (num3 < 0)
              num3 = 0;
            if (num3 > 88)
              num3 = 88;
            mrGame.MrGame.Sound.adpcm_prec_deltas[index1 * 16 + index2] = (num3 - index1 << 24) + num2;
          }
        }
      }

      private static int decodeadpcm(
        byte[] source,
        int si,
        byte[] dest,
        int di,
        int bytes,
        int state)
      {
        state = (state & -16777216) + 524288 + (int) (short) state;
        for (; bytes > 0; --bytes)
        {
          int num = (int) source[si++];
          state += mrGame.MrGame.Sound.adpcm_prec_deltas[state >> 20 | num & 15];
          dest[di++] = (byte) state;
          dest[di++] = (byte) (state >> 8);
          state += mrGame.MrGame.Sound.adpcm_prec_deltas[state >> 20 | num >> 4 & 15];
          dest[di++] = (byte) state;
          dest[di++] = (byte) (state >> 8);
        }
        return state & -16711681;
      }
    }

    public enum LeaderBoardState
    {
      UnInitialized,
      PageReady,
      PageRequested,
      PageUpRequested,
      PageDownRequested,
    }

    public class LeaderboardInfo
    {
      public LeaderboardIdentity Identity;
      public LeaderboardReader Reader;
      public int NumScoresPerPage;
      public mrGame.MrGame.LeaderBoardState State;

      public LeaderboardInfo() => this.State = mrGame.MrGame.LeaderBoardState.UnInitialized;
    }

    public class GuiKeyBind
    {
      public int elId;
      public int key;
      public int action;
    }

    public class GuiElement
    {
      public int type;
      public int id;
      public int eg_id;
      public int pos_align;
      public int x;
      public int y;
      public int w;
      public int h;
      public int ax;
      public int ay;
      public int align;
      public mrGame.MrGame.MrgString txt;
      public int eventMask;
      public bool enabled;
      public int[] _params;
      public bool draggableHoriz;
      public bool draggableVert;
      public bool isDragging;
      public int drag_startX;
      public int drag_startY;
      public int drag_startOffsetX;
      public int drag_startOffsetY;
      public int drag_currX;
      public int drag_currY;
      public int drag_VX;
      public int drag_VY;
      public int pressX;
      public int pressY;
      public int _event;
      public int eventTime;
      public int[] eventTimeList;
      public bool keypadFocus;
      public bool visible;
      public bool isStatic;
      public int elementLevel;
    }

    public class Gui
    {
      public int elementAmount;
      public mrGame.MrGame.GuiElement[] elementList;
    }

    public class Pair
    {
      public int first;
      public int second;
    }

    public class Particle
    {
      public int fp_x;
      public int fp_y;
      public short type;
      public int fp_vel;
      public int fp_amplitude;
      public int fp_cycle;
      public int fp_xOffset;
      public int fp_yOffset;
    }

    public class GameObject
    {
      public int id;
      public int fp_timeUpdate;
      public int fp_x;
      public int fp_y;
      public int fp_velY;
      public int fp_rangeX;
      public int fp_rangeY;
      public int fp_offsetX;
      public int fp_offsetY;
    }

    public class Platform
    {
      public int fp_x;
      public int fp_y;
      public int id;
      public int updateTime;
      public int speed;
      public int objOffset;
    }

    public class Projectile
    {
      public int fp_pos_x;
      public int fp_pos_y;
      public int fp_vel_x;
      public int fp_vel_y;
      public int fp_acc_y;
      public int fp_initVelDiv;
    }
  }
}
