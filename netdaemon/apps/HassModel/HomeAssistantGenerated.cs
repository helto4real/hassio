using System;
using System.Collections.Generic;

namespace HomeAssistantGenerated
{
    public interface IEntities
    {
        AutomationEntities Automation { get; }

        BinarySensorEntities BinarySensor { get; }

        ButtonEntities Button { get; }

        CalendarEntities Calendar { get; }

        CameraEntities Camera { get; }

        CoverEntities Cover { get; }

        DeviceTrackerEntities DeviceTracker { get; }

        GroupEntities Group { get; }

        InputBooleanEntities InputBoolean { get; }

        InputNumberEntities InputNumber { get; }

        InputSelectEntities InputSelect { get; }

        InputTextEntities InputText { get; }

        LightEntities Light { get; }

        LockEntities Lock { get; }

        MediaPlayerEntities MediaPlayer { get; }

        NumberEntities Number { get; }

        PersonEntities Person { get; }

        ProximityEntities Proximity { get; }

        RemoteEntities Remote { get; }

        SceneEntities Scene { get; }

        ScriptEntities Script { get; }

        SelectEntities Select { get; }

        SensorEntities Sensor { get; }

        SunEntities Sun { get; }

        SwitchEntities Switch { get; }

        TimerEntities Timer { get; }

        WeatherEntities Weather { get; }

        ZoneEntities Zone { get; }
    }

    public class Entities : IEntities
    {
        private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
        public Entities(NetDaemon.HassModel.Common.IHaContext haContext)
        {
            _haContext = haContext;
        }

        public AutomationEntities Automation => new(_haContext);
        public BinarySensorEntities BinarySensor => new(_haContext);
        public ButtonEntities Button => new(_haContext);
        public CalendarEntities Calendar => new(_haContext);
        public CameraEntities Camera => new(_haContext);
        public CoverEntities Cover => new(_haContext);
        public DeviceTrackerEntities DeviceTracker => new(_haContext);
        public GroupEntities Group => new(_haContext);
        public InputBooleanEntities InputBoolean => new(_haContext);
        public InputNumberEntities InputNumber => new(_haContext);
        public InputSelectEntities InputSelect => new(_haContext);
        public InputTextEntities InputText => new(_haContext);
        public LightEntities Light => new(_haContext);
        public LockEntities Lock => new(_haContext);
        public MediaPlayerEntities MediaPlayer => new(_haContext);
        public NumberEntities Number => new(_haContext);
        public PersonEntities Person => new(_haContext);
        public ProximityEntities Proximity => new(_haContext);
        public RemoteEntities Remote => new(_haContext);
        public SceneEntities Scene => new(_haContext);
        public ScriptEntities Script => new(_haContext);
        public SelectEntities Select => new(_haContext);
        public SensorEntities Sensor => new(_haContext);
        public SunEntities Sun => new(_haContext);
        public SwitchEntities Switch => new(_haContext);
        public TimerEntities Timer => new(_haContext);
        public WeatherEntities Weather => new(_haContext);
        public ZoneEntities Zone => new(_haContext);
    }

    public class AutomationEntities
    {
        private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
        public AutomationEntities(NetDaemon.HassModel.Common.IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>automation 3</summary>
        public AutomationEntity Automation3 => new(_haContext, "automation.automation_3");
        ///<summary>Set theme at startup</summary>
        public AutomationEntity SetThemeAtStartup => new(_haContext, "automation.set_theme_at_startup");
        ///<summary>Zigbee Join Disabled</summary>
        public AutomationEntity ZigbeeJoinDisabled => new(_haContext, "automation.zigbee_join_disabled");
        ///<summary>Zigbee Join Enabled</summary>
        public AutomationEntity ZigbeeJoinEnabled => new(_haContext, "automation.zigbee_join_enabled");
        ///<summary>Zigbee2mqtt Log Level</summary>
        public AutomationEntity Zigbee2mqttLogLevel => new(_haContext, "automation.zigbee2mqtt_log_level");
    }

    public class BinarySensorEntities
    {
        private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
        public BinarySensorEntities(NetDaemon.HassModel.Common.IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>AC 15bc0cfe:1</summary>
        public BinarySensorEntity Ac15bc0cfe1 => new(_haContext, "binary_sensor.ac_15bc0cfe_1");
        ///<summary>AC 18ce362:11</summary>
        public BinarySensorEntity Ac18ce36211 => new(_haContext, "binary_sensor.ac_18ce362_11");
        ///<summary>AC 18ce362:12</summary>
        public BinarySensorEntity Ac18ce36212 => new(_haContext, "binary_sensor.ac_18ce362_12");
        ///<summary>AC 2947346:14</summary>
        public BinarySensorEntity Ac294734614 => new(_haContext, "binary_sensor.ac_2947346_14");
        ///<summary>AC 2947346:15</summary>
        public BinarySensorEntity Ac294734615 => new(_haContext, "binary_sensor.ac_2947346_15");
        ///<summary>AC 2947346:16</summary>
        public BinarySensorEntity Ac294734616 => new(_haContext, "binary_sensor.ac_2947346_16");
        ///<summary>AC 29bc0cfe:6</summary>
        public BinarySensorEntity Ac29bc0cfe6 => new(_haContext, "binary_sensor.ac_29bc0cfe_6");
        ///<summary>AC 2bc0cfe:1</summary>
        public BinarySensorEntity Ac2bc0cfe1 => new(_haContext, "binary_sensor.ac_2bc0cfe_1");
        ///<summary>AC 34bc0cfe:6</summary>
        public BinarySensorEntity Ac34bc0cfe6 => new(_haContext, "binary_sensor.ac_34bc0cfe_6");
        ///<summary>AC 36bc0cfe:8</summary>
        public BinarySensorEntity Ac36bc0cfe8 => new(_haContext, "binary_sensor.ac_36bc0cfe_8");
        ///<summary>AC 39bc0cfe:7</summary>
        public BinarySensorEntity Ac39bc0cfe7 => new(_haContext, "binary_sensor.ac_39bc0cfe_7");
        ///<summary>AC 44bc0cfe:1</summary>
        public BinarySensorEntity Ac44bc0cfe1 => new(_haContext, "binary_sensor.ac_44bc0cfe_1");
        ///<summary>AC 50bc0cfe:8</summary>
        public BinarySensorEntity Ac50bc0cfe8 => new(_haContext, "binary_sensor.ac_50bc0cfe_8");
        ///<summary>AC 51bc0cfe:4</summary>
        public BinarySensorEntity Ac51bc0cfe4 => new(_haContext, "binary_sensor.ac_51bc0cfe_4");
        ///<summary>AC 51bc0cfe:8</summary>
        public BinarySensorEntity Ac51bc0cfe8 => new(_haContext, "binary_sensor.ac_51bc0cfe_8");
        ///<summary>AC 52bc0cfe:1</summary>
        public BinarySensorEntity Ac52bc0cfe1 => new(_haContext, "binary_sensor.ac_52bc0cfe_1");
        ///<summary>AC 55bc0cfe:7</summary>
        public BinarySensorEntity Ac55bc0cfe7 => new(_haContext, "binary_sensor.ac_55bc0cfe_7");
        ///<summary>AC 63bc0cfe:9</summary>
        public BinarySensorEntity Ac63bc0cfe9 => new(_haContext, "binary_sensor.ac_63bc0cfe_9");
        ///<summary>AC 67bc0cfe:4</summary>
        public BinarySensorEntity Ac67bc0cfe4 => new(_haContext, "binary_sensor.ac_67bc0cfe_4");
        ///<summary>AC 72bc0cfe:2</summary>
        public BinarySensorEntity Ac72bc0cfe2 => new(_haContext, "binary_sensor.ac_72bc0cfe_2");
        ///<summary>AC 81bc0cfe:1</summary>
        public BinarySensorEntity Ac81bc0cfe1 => new(_haContext, "binary_sensor.ac_81bc0cfe_1");
        ///<summary>AC 93bc0cfe:2</summary>
        public BinarySensorEntity Ac93bc0cfe2 => new(_haContext, "binary_sensor.ac_93bc0cfe_2");
        ///<summary>farstukvist_led_update_available</summary>
        public BinarySensorEntity FarstukvistLedUpdateAvailable => new(_haContext, "binary_sensor.farstukvist_led_update_available");
        ///<summary>0x7cb03eaa00aa0002 update available</summary>
        public BinarySensorEntity GymLedUpdateAvailable => new(_haContext, "binary_sensor.gym_led_update_available");
        ///<summary>hall_byra_update_available</summary>
        public BinarySensorEntity HallByraUpdateAvailable => new(_haContext, "binary_sensor.hall_byra_update_available");
        ///<summary>Ytterdörr uppe</summary>
        public BinarySensorEntity HallDorr => new(_haContext, "binary_sensor.hall_dorr");
        ///<summary>hall_dorr_update_available</summary>
        public BinarySensorEntity HallDorrUpdateAvailable => new(_haContext, "binary_sensor.hall_dorr_update_available");
        ///<summary>julbelysning_hoger_update_available</summary>
        public BinarySensorEntity JulbelysningHogerUpdateAvailable => new(_haContext, "binary_sensor.julbelysning_hoger_update_available");
        ///<summary>julbelysning_kok_h_update_available</summary>
        public BinarySensorEntity JulbelysningKokHUpdateAvailable => new(_haContext, "binary_sensor.julbelysning_kok_h_update_available");
        ///<summary>julbelysning_tomas_rum_update_available</summary>
        public BinarySensorEntity JulbelysningTomasRumUpdateAvailable => new(_haContext, "binary_sensor.julbelysning_tomas_rum_update_available");
        ///<summary>julbelysning_vardagsrum_v_update_available</summary>
        public BinarySensorEntity JulbelysningVardagsrumVUpdateAvailable => new(_haContext, "binary_sensor.julbelysning_vardagsrum_v_update_available");
        ///<summary>kamera_3 Motion Detected</summary>
        public BinarySensorEntity Kamera3MotionDetected => new(_haContext, "binary_sensor.kamera_3_motion_detected");
        ///<summary>kok_lilla_fonster_update_available</summary>
        public BinarySensorEntity KokFonsterLillaUpdateAvailable => new(_haContext, "binary_sensor.kok_fonster_lilla_update_available");
        ///<summary>kok_fonster_update_available</summary>
        public BinarySensorEntity KokFonsterUpdateAvailable => new(_haContext, "binary_sensor.kok_fonster_update_available");
        ///<summary>Rörelsedetektor köket</summary>
        public BinarySensorEntity KokPir => new(_haContext, "binary_sensor.kok_pir");
        ///<summary>melkers_fonster_update_available</summary>
        public BinarySensorEntity MelkersFonsterUpdateAvailable => new(_haContext, "binary_sensor.melkers_fonster_update_available");
        ///<summary>melkers_rum_pir_illuminance_above_threshold</summary>
        public BinarySensorEntity MelkersRumPirIlluminanceAboveThreshold => new(_haContext, "binary_sensor.melkers_rum_pir_illuminance_above_threshold");
        ///<summary>Rörelsedetektor Melkers rum</summary>
        public BinarySensorEntity MelkersRumPirOccupancy => new(_haContext, "binary_sensor.melkers_rum_pir_occupancy");
        ///<summary>melkers_rum_pir_update_available</summary>
        public BinarySensorEntity MelkersRumPirOccupancyUpdateAvailable => new(_haContext, "binary_sensor.melkers_rum_pir_occupancy_update_available");
        ///<summary>0x7cb03eaa00ab30fb update available</summary>
        public BinarySensorEntity MotorvarmareHogerUpdateAvailable => new(_haContext, "binary_sensor.motorvarmare_hoger_update_available");
        ///<summary>motorvarmare_hoger_update_available</summary>
        public BinarySensorEntity MotorvarmareHogerUpdateAvailableOld => new(_haContext, "binary_sensor.motorvarmare_hoger_update_available_old");
        ///<summary>sallys_fonster_update_available</summary>
        public BinarySensorEntity SallysFonsterUpdateAvailable => new(_haContext, "binary_sensor.sallys_fonster_update_available");
        ///<summary>Rörelsedetektor Sallys rum</summary>
        public BinarySensorEntity SallysRumPir => new(_haContext, "binary_sensor.sallys_rum_pir");
        ///<summary>sallys_rum_pir_illuminance_above_threshold</summary>
        public BinarySensorEntity SallysRumPirIlluminanceAboveThreshold => new(_haContext, "binary_sensor.sallys_rum_pir_illuminance_above_threshold");
        ///<summary>sallys_rum_pir_update_available</summary>
        public BinarySensorEntity SallysRumPirUpdateAvailable => new(_haContext, "binary_sensor.sallys_rum_pir_update_available");
        ///<summary>SM-G986B Is Charging</summary>
        public BinarySensorEntity SmG986bIsCharging => new(_haContext, "binary_sensor.sm_g986b_is_charging");
        ///<summary>Snapshots Stale</summary>
        public BinarySensorEntity SnapshotsStale => new(_haContext, "binary_sensor.snapshots_stale");
        ///<summary>sonoff1_button</summary>
        public BinarySensorEntity Sonoff1Button => new(_haContext, "binary_sensor.sonoff1_button");
        ///<summary>sovrum_byra_update_available</summary>
        public BinarySensorEntity SovrumByraUpdateAvailable => new(_haContext, "binary_sensor.sovrum_byra_update_available");
        ///<summary>sovrum_fonster_update_available</summary>
        public BinarySensorEntity SovrumFonsterUpdateAvailable => new(_haContext, "binary_sensor.sovrum_fonster_update_available");
        ///<summary>Rörelsedetektor sovrum</summary>
        public BinarySensorEntity SovrumPir => new(_haContext, "binary_sensor.sovrum_pir");
        ///<summary>sovrum_pir_illuminance_above_threshold</summary>
        public BinarySensorEntity SovrumPirIlluminanceAboveThreshold => new(_haContext, "binary_sensor.sovrum_pir_illuminance_above_threshold");
        ///<summary>sovrum_pir_update_available</summary>
        public BinarySensorEntity SovrumPirUpdateAvailable => new(_haContext, "binary_sensor.sovrum_pir_update_available");
        ///<summary>sw_input</summary>
        public BinarySensorEntity SwInput => new(_haContext, "binary_sensor.sw_input");
        ///<summary>swe_recycling_matfors</summary>
        public BinarySensorEntity SweRecyclingMatfors => new(_haContext, "binary_sensor.swe_recycling_matfors");
        ///<summary>swe_recycling_vattjom</summary>
        public BinarySensorEntity SweRecyclingVattjom => new(_haContext, "binary_sensor.swe_recycling_vattjom");
        ///<summary>Tomas iPad Focus</summary>
        public BinarySensorEntity TomasIpadFocus => new(_haContext, "binary_sensor.tomas_ipad_focus");
        ///<summary>Rörelsedetektor Tomas rum</summary>
        public BinarySensorEntity TomasRumPir => new(_haContext, "binary_sensor.tomas_rum_pir");
        ///<summary>tomas_rum_pir_illuminance_above_threshold</summary>
        public BinarySensorEntity TomasRumPirIlluminanceAboveThreshold => new(_haContext, "binary_sensor.tomas_rum_pir_illuminance_above_threshold");
        ///<summary>tomas_rum_pir_update_available</summary>
        public BinarySensorEntity TomasRumPirUpdateAvailable => new(_haContext, "binary_sensor.tomas_rum_pir_update_available");
        ///<summary>tomas_rum_update_available</summary>
        public BinarySensorEntity TomasRumUpdateAvailable => new(_haContext, "binary_sensor.tomas_rum_update_available");
        ///<summary>Rörelsedetektor trapp</summary>
        public BinarySensorEntity TrappPir => new(_haContext, "binary_sensor.trapp_pir");
        ///<summary>tvrum_bakgrund_tv_update_available</summary>
        public BinarySensorEntity TvrumBakgrundTvUpdateAvailable => new(_haContext, "binary_sensor.tvrum_bakgrund_tv_update_available");
        ///<summary>0x90fd9ffffed4315a update available</summary>
        public BinarySensorEntity TvrumHogerUpdateAvailable => new(_haContext, "binary_sensor.tvrum_hoger_update_available");
        ///<summary>Rörelsedetektor TV-rum</summary>
        public BinarySensorEntity TvrumPir => new(_haContext, "binary_sensor.tvrum_pir");
        ///<summary>tvrum_rullgardin_hoger_update_available</summary>
        public BinarySensorEntity TvrumRullgardinHogerUpdateAvailable => new(_haContext, "binary_sensor.tvrum_rullgardin_hoger_update_available");
        ///<summary>tvrum_rullgardin_vanster_update_available</summary>
        public BinarySensorEntity TvrumRullgardinVansterUpdateAvailable => new(_haContext, "binary_sensor.tvrum_rullgardin_vanster_update_available");
        ///<summary>0x90fd9ffffe92a856 update available</summary>
        public BinarySensorEntity TvrumVansterUpdateAvailable => new(_haContext, "binary_sensor.tvrum_vanster_update_available");
        ///<summary>tvrumm_vagg_update_available</summary>
        public BinarySensorEntity TvrummVaggUpdateAvailable => new(_haContext, "binary_sensor.tvrumm_vagg_update_available");
        ///<summary>Updater</summary>
        public BinarySensorEntity Updater => new(_haContext, "binary_sensor.updater");
        ///<summary>0x90fd9ffffe723932 update available</summary>
        public BinarySensorEntity VardagsrumHogerUpdateAvailable => new(_haContext, "binary_sensor.vardagsrum_hoger_update_available");
        ///<summary>vardagsrum_fonster_mitten_update_available</summary>
        public BinarySensorEntity VardagsrumMittenUpdateAvailable => new(_haContext, "binary_sensor.vardagsrum_mitten_update_available");
        ///<summary>Rörelsedetektor vardagsrum uppe</summary>
        public BinarySensorEntity VardagsrumPir => new(_haContext, "binary_sensor.vardagsrum_pir");
        ///<summary>vardagsrum_pir_led_indication</summary>
        public BinarySensorEntity VardagsrumPirLedIndication => new(_haContext, "binary_sensor.vardagsrum_pir_led_indication");
        ///<summary>vardagsrum_pir_update_available</summary>
        public BinarySensorEntity VardagsrumPirUpdateAvailable => new(_haContext, "binary_sensor.vardagsrum_pir_update_available");
        ///<summary>vardagsrum_fonster_vanster_update_available</summary>
        public BinarySensorEntity VardagsrumVansterUpdateAvailable => new(_haContext, "binary_sensor.vardagsrum_vanster_update_available");
    }

    public class ButtonEntities
    {
        private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
        public ButtonEntities(NetDaemon.HassModel.Common.IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Identify</summary>
        public ButtonEntity Identify => new(_haContext, "button.identify");
        ///<summary>Identify</summary>
        public ButtonEntity Identify2 => new(_haContext, "button.identify_2");
    }

    public class CalendarEntities
    {
        private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
        public CalendarEntities(NetDaemon.HassModel.Common.IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Familjen</summary>
        public CalendarEntity FamiljenHellstrom => new(_haContext, "calendar.familjen_hellstrom");
        ///<summary>Sundsvalls Fotoklubb</summary>
        public CalendarEntity SundsvallsFotoklubb => new(_haContext, "calendar.sundsvalls_fotoklubb");
        ///<summary>Ta ut soporna</summary>
        public CalendarEntity TaUtSopor => new(_haContext, "calendar.ta_ut_sopor");
        ///<summary>tomash277@gmail.com</summary>
        public CalendarEntity Tomash277GmailCom => new(_haContext, "calendar.tomash277_gmail_com");
    }

    public class CameraEntities
    {
        private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
        public CameraEntities(NetDaemon.HassModel.Common.IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>kamera_3</summary>
        public CameraEntity Kamera3 => new(_haContext, "camera.kamera_3");
        ///<summary>kamera_stream</summary>
        public CameraEntity KameraStream => new(_haContext, "camera.kamera_stream");
        ///<summary>My Camera</summary>
        public CameraEntity MyCamera => new(_haContext, "camera.my_camera");
    }

    public class CoverEntities
    {
        private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
        public CoverEntities(NetDaemon.HassModel.Common.IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>tvrum</summary>
        public CoverEntity Tvrum => new(_haContext, "cover.tvrum");
        ///<summary>tvrum_rullgardin_hoger</summary>
        public CoverEntity TvrumRullgardinHoger => new(_haContext, "cover.tvrum_rullgardin_hoger");
        ///<summary>tvrum_rullgardin_vanster</summary>
        public CoverEntity TvrumRullgardinVanster => new(_haContext, "cover.tvrum_rullgardin_vanster");
    }

    public class DeviceTrackerEntities
    {
        private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
        public DeviceTrackerEntities(NetDaemon.HassModel.Common.IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>5CG709284W</summary>
        public DeviceTrackerEntity E5cg709284w => new(_haContext, "device_tracker.5cg709284w");
        ///<summary>5CG81709HJ</summary>
        public DeviceTrackerEntity E5cg81709hj => new(_haContext, "device_tracker.5cg81709hj");
        ///<summary>5CG8292F67</summary>
        public DeviceTrackerEntity E5cg8292f67 => new(_haContext, "device_tracker.5cg8292f67");
        ///<summary>Carl-Greger</summary>
        public DeviceTrackerEntity AutomowerNone205202468200840768 => new(_haContext, "device_tracker.automower_none_205202468_200840768");
        ///<summary>Chromecast</summary>
        public DeviceTrackerEntity Chromecast => new(_haContext, "device_tracker.chromecast");
        ///<summary>Chromecast</summary>
        public DeviceTrackerEntity Chromecast2 => new(_haContext, "device_tracker.chromecast_2");
        ///<summary>Chromecast</summary>
        public DeviceTrackerEntity Chromecast3 => new(_haContext, "device_tracker.chromecast_3");
        ///<summary>Chromecast</summary>
        public DeviceTrackerEntity Chromecast5 => new(_haContext, "device_tracker.chromecast_5");
        ///<summary>DAFANG</summary>
        public DeviceTrackerEntity Dafang => new(_haContext, "device_tracker.dafang");
        ///<summary>Efraims-iPhone</summary>
        public DeviceTrackerEntity EfraimsIphone => new(_haContext, "device_tracker.efraims_iphone");
        ///<summary>Efraims-iPhone</summary>
        public DeviceTrackerEntity EfraimsIphone2 => new(_haContext, "device_tracker.efraims_iphone_2");
        ///<summary>XK</summary>
        public DeviceTrackerEntity ElgatoKeyLightAirA847 => new(_haContext, "device_tracker.elgato_key_light_air_a847");
        ///<summary></summary>
        public DeviceTrackerEntity ElgatoKeyLightAirAcae => new(_haContext, "device_tracker.elgato_key_light_air_acae");
        ///<summary>Galaxy-S20-5G</summary>
        public DeviceTrackerEntity ElinGalaxyWifi => new(_haContext, "device_tracker.elin_galaxy_wifi");
        ///<summary>Elins galaxy wifi_old</summary>
        public DeviceTrackerEntity ElinGalaxyWifiOld => new(_haContext, "device_tracker.elin_galaxy_wifi_old");
        ///<summary>Elins galaxy wifi</summary>
        public DeviceTrackerEntity ElinGalaxyWifiOldOold => new(_haContext, "device_tracker.elin_galaxy_wifi_old_oold");
        ///<summary>Elin</summary>
        public DeviceTrackerEntity ElinPresence => new(_haContext, "device_tracker.elin_presence");
        ///<summary>Elins-iPad</summary>
        public DeviceTrackerEntity ElinsIpad2 => new(_haContext, "device_tracker.elins_ipad_2");
        ///<summary>Elins-iPad</summary>
        public DeviceTrackerEntity ElinsIpad3 => new(_haContext, "device_tracker.elins_ipad_3");
        ///<summary>Elins-iPhone</summary>
        public DeviceTrackerEntity ElinsIphone => new(_haContext, "device_tracker.elins_iphone");
        ///<summary>Emelie--iPhone</summary>
        public DeviceTrackerEntity EmelieIphone => new(_haContext, "device_tracker.emelie_iphone");
        ///<summary>Emelie--iPhone</summary>
        public DeviceTrackerEntity EmelieIphone2 => new(_haContext, "device_tracker.emelie_iphone_2");
        ///<summary>esp_kamera_1</summary>
        public DeviceTrackerEntity EspKamera12 => new(_haContext, "device_tracker.esp_kamera_1_2");
        ///<summary>Galaxy-S10</summary>
        public DeviceTrackerEntity GalaxyS10 => new(_haContext, "device_tracker.galaxy_s10");
        ///<summary>Galaxy-S8</summary>
        public DeviceTrackerEntity GalaxyS8 => new(_haContext, "device_tracker.galaxy_s8");
        ///<summary>Galaxy-Tab-A</summary>
        public DeviceTrackerEntity GalaxyTabA => new(_haContext, "device_tracker.galaxy_tab_a");
        ///<summary>Galaxy-Tab-A</summary>
        public DeviceTrackerEntity GalaxyTabA2 => new(_haContext, "device_tracker.galaxy_tab_a_2");
        ///<summary>Galaxy-Tab-A</summary>
        public DeviceTrackerEntity GalaxyTabA3 => new(_haContext, "device_tracker.galaxy_tab_a_3");
        ///<summary>Google-Home</summary>
        public DeviceTrackerEntity GoogleHome => new(_haContext, "device_tracker.google_home");
        ///<summary>Google-Home-Mini</summary>
        public DeviceTrackerEntity GoogleHomeMini => new(_haContext, "device_tracker.google_home_mini");
        ///<summary>Google-Home-Mini</summary>
        public DeviceTrackerEntity GoogleHomeMini2 => new(_haContext, "device_tracker.google_home_mini_2");
        ///<summary>Google-Home-Mini</summary>
        public DeviceTrackerEntity GoogleHomeMini3 => new(_haContext, "device_tracker.google_home_mini_3");
        ///<summary>Google-Home-Mini</summary>
        public DeviceTrackerEntity GoogleHomeMini4 => new(_haContext, "device_tracker.google_home_mini_4");
        ///<summary>Google-Home-Mini</summary>
        public DeviceTrackerEntity GoogleHomeMini5 => new(_haContext, "device_tracker.google_home_mini_5");
        ///<summary>Elins mobil GPS</summary>
        public DeviceTrackerEntity GoogleMaps110786808112177763666 => new(_haContext, "device_tracker.google_maps_110786808112177763666");
        ///<summary>Melker mobil GPS</summary>
        public DeviceTrackerEntity GoogleMaps113728439587103002947 => new(_haContext, "device_tracker.google_maps_113728439587103002947");
        ///<summary>Sallys mobil GPS</summary>
        public DeviceTrackerEntity GoogleMaps115932713534918928318 => new(_haContext, "device_tracker.google_maps_115932713534918928318");
        ///<summary>Tomas mobil GPS</summary>
        public DeviceTrackerEntity GoogleMaps118123190245690142371 => new(_haContext, "device_tracker.google_maps_118123190245690142371");
        ///<summary>Harmony</summary>
        public DeviceTrackerEntity Harmony => new(_haContext, "device_tracker.harmony");
        ///<summary>HPG2E024</summary>
        public DeviceTrackerEntity Hpg2e024 => new(_haContext, "device_tracker.hpg2e024");
        ///<summary>HUAWEI_Mate_10_lite-d2b0a</summary>
        public DeviceTrackerEntity HuaweiMate10LiteD2b0a => new(_haContext, "device_tracker.huawei_mate_10_lite_d2b0a");
        ///<summary>HUAWEI_Mate_20_Pro-3c5327</summary>
        public DeviceTrackerEntity HuaweiMate20Pro3c5327 => new(_haContext, "device_tracker.huawei_mate_20_pro_3c5327");
        ///<summary>iPad</summary>
        public DeviceTrackerEntity Ipad => new(_haContext, "device_tracker.ipad");
        ///<summary>iPad</summary>
        public DeviceTrackerEntity Ipad2 => new(_haContext, "device_tracker.ipad_2");
        ///<summary>AirsomthorSally</summary>
        public DeviceTrackerEntity MacbookAir => new(_haContext, "device_tracker.macbook_air");
        ///<summary>Galaxy-S20-5G</summary>
        public DeviceTrackerEntity MelkerGalaxyWifi => new(_haContext, "device_tracker.melker_galaxy_wifi");
        ///<summary>Melker huawei wifi</summary>
        public DeviceTrackerEntity MelkerHuaweiWifi => new(_haContext, "device_tracker.melker_huawei_wifi");
        ///<summary>Melker</summary>
        public DeviceTrackerEntity MelkerPresence => new(_haContext, "device_tracker.melker_presence");
        ///<summary>Nere</summary>
        public DeviceTrackerEntity Nere => new(_haContext, "device_tracker.nere");
        ///<summary>Nest-Audio</summary>
        public DeviceTrackerEntity NestAudio => new(_haContext, "device_tracker.nest_audio");
        ///<summary>Nest-Audio</summary>
        public DeviceTrackerEntity NestAudio2 => new(_haContext, "device_tracker.nest_audio_2");
        ///<summary>Nest-Audio</summary>
        public DeviceTrackerEntity NestAudio3 => new(_haContext, "device_tracker.nest_audio_3");
        ///<summary>Nintendo Wii U</summary>
        public DeviceTrackerEntity NintendoWiiU2 => new(_haContext, "device_tracker.nintendo_wii_u_2");
        ///<summary>raspberrypi</summary>
        public DeviceTrackerEntity Octopi => new(_haContext, "device_tracker.octopi");
        ///<summary>PISERVER</summary>
        public DeviceTrackerEntity Piserver => new(_haContext, "device_tracker.piserver");
        ///<summary>PISERVER</summary>
        public DeviceTrackerEntity Piserver2 => new(_haContext, "device_tracker.piserver_2");
        ///<summary>PISERVER</summary>
        public DeviceTrackerEntity Piserver3 => new(_haContext, "device_tracker.piserver_3");
        ///<summary>PISERVER</summary>
        public DeviceTrackerEntity Piserver4 => new(_haContext, "device_tracker.piserver_4");
        ///<summary>PISERVER</summary>
        public DeviceTrackerEntity Piserver5 => new(_haContext, "device_tracker.piserver_5");
        ///<summary>PISERVER</summary>
        public DeviceTrackerEntity Piserver6 => new(_haContext, "device_tracker.piserver_6");
        ///<summary>PISERVER</summary>
        public DeviceTrackerEntity Piserver7 => new(_haContext, "device_tracker.piserver_7");
        ///<summary>PISERVER</summary>
        public DeviceTrackerEntity Piserver8 => new(_haContext, "device_tracker.piserver_8");
        ///<summary>raspberrypi</summary>
        public DeviceTrackerEntity Raspberrypi => new(_haContext, "device_tracker.raspberrypi");
        ///<summary>raspberrypi</summary>
        public DeviceTrackerEntity Raspberrypi2 => new(_haContext, "device_tracker.raspberrypi_2");
        ///<summary>raspberrypi</summary>
        public DeviceTrackerEntity Raspberrypi3 => new(_haContext, "device_tracker.raspberrypi_3");
        ///<summary>roborock-vacuum-a15</summary>
        public DeviceTrackerEntity RoborockVacuumA15 => new(_haContext, "device_tracker.roborock_vacuum_a15");
        ///<summary>Sallys Huawei wifi</summary>
        public DeviceTrackerEntity SallyHuaweiWifi => new(_haContext, "device_tracker.sally_huawei_wifi");
        ///<summary>Sally--iPhone</summary>
        public DeviceTrackerEntity SallyIphone => new(_haContext, "device_tracker.sally_iphone");
        ///<summary>Sally--iPhone</summary>
        public DeviceTrackerEntity SallyIphone2 => new(_haContext, "device_tracker.sally_iphone_2");
        ///<summary>Sally</summary>
        public DeviceTrackerEntity SallyPresence => new(_haContext, "device_tracker.sally_presence");
        ///<summary>Samsung-Galaxy-S7</summary>
        public DeviceTrackerEntity SamsungGalaxyS7 => new(_haContext, "device_tracker.samsung_galaxy_s7");
        ///<summary>shelly_1</summary>
        public DeviceTrackerEntity Shelly1 => new(_haContext, "device_tracker.shelly_1");
        ///<summary>SM-G975F</summary>
        public DeviceTrackerEntity SmG975f => new(_haContext, "device_tracker.sm_g975f");
        ///<summary>SM-G986B</summary>
        public DeviceTrackerEntity SmG986b => new(_haContext, "device_tracker.sm_g986b");
        ///<summary>sonoff1</summary>
        public DeviceTrackerEntity SonoffTest => new(_haContext, "device_tracker.sonoff_test");
        ///<summary>Tomas mobil wifi</summary>
        public DeviceTrackerEntity TomasGalaxyWifi => new(_haContext, "device_tracker.tomas_galaxy_wifi");
        ///<summary>Tomas galaxy wifi</summary>
        public DeviceTrackerEntity TomasGalaxyWifiOld => new(_haContext, "device_tracker.tomas_galaxy_wifi_old");
        ///<summary>Tomas-gamla-pad</summary>
        public DeviceTrackerEntity TomasGamlaPad => new(_haContext, "device_tracker.tomas_gamla_pad");
        ///<summary>Tomass-iPad</summary>
        public DeviceTrackerEntity TomasIpad2 => new(_haContext, "device_tracker.tomas_ipad_2");
        ///<summary>Tomas-iPad</summary>
        public DeviceTrackerEntity TomasIpad3 => new(_haContext, "device_tracker.tomas_ipad_3");
        ///<summary>Tomas iPad</summary>
        public DeviceTrackerEntity TomasIpad4 => new(_haContext, "device_tracker.tomas_ipad_4");
        ///<summary>Tomas iPad</summary>
        public DeviceTrackerEntity TomasIpad5 => new(_haContext, "device_tracker.tomas_ipad_5");
        ///<summary>Tomas-iPad</summary>
        public DeviceTrackerEntity TomasIpad6 => new(_haContext, "device_tracker.tomas_ipad_6");
        ///<summary>Tomas</summary>
        public DeviceTrackerEntity TomasPresence => new(_haContext, "device_tracker.tomas_presence");
        ///<summary>Tomas-S20</summary>
        public DeviceTrackerEntity TomasS20 => new(_haContext, "device_tracker.tomas_s20");
        public DeviceTrackerEntity Unifi0024E451550aDefault => new(_haContext, "device_tracker.unifi_00_24_e4_51_55_0a_default");
        public DeviceTrackerEntity Unifi04D3B0632d29Default => new(_haContext, "device_tracker.unifi_04_d3_b0_63_2d_29_default");
        public DeviceTrackerEntity Unifi2c2617B78551Default => new(_haContext, "device_tracker.unifi_2c_26_17_b7_85_51_default");
        ///<summary>raspberrypi</summary>
        public DeviceTrackerEntity Unifi862c82A4F469Default => new(_haContext, "device_tracker.unifi_86_2c_82_a4_f4_69_default");
        ///<summary>hassnuc</summary>
        public DeviceTrackerEntity UnifiAcFdCe031c4aDefault => new(_haContext, "device_tracker.unifi_ac_fd_ce_03_1c_4a_default");
        ///<summary>ubuntu</summary>
        public DeviceTrackerEntity UnifiC417Fe4d8f42Default => new(_haContext, "device_tracker.unifi_c4_17_fe_4d_8f_42_default");
        public DeviceTrackerEntity UnifiE0D4E80330F9Default => new(_haContext, "device_tracker.unifi_e0_d4_e8_03_30_f9_default");
        ///<summary>Uppe</summary>
        public DeviceTrackerEntity Uppe => new(_haContext, "device_tracker.uppe");
        ///<summary>wlan0</summary>
        public DeviceTrackerEntity Wlan0 => new(_haContext, "device_tracker.wlan0");
        ///<summary>wlan0</summary>
        public DeviceTrackerEntity Wlan02 => new(_haContext, "device_tracker.wlan0_2");
        ///<summary>wlan0</summary>
        public DeviceTrackerEntity Wlan03 => new(_haContext, "device_tracker.wlan0_3");
        ///<summary>wled-WLED</summary>
        public DeviceTrackerEntity WledWled => new(_haContext, "device_tracker.wled_wled");
        ///<summary>wled-WLED</summary>
        public DeviceTrackerEntity WledWled2 => new(_haContext, "device_tracker.wled_wled_2");
        ///<summary>Xbox-SystemOS</summary>
        public DeviceTrackerEntity XboxSystemos => new(_haContext, "device_tracker.xbox_systemos");
        ///<summary>yeelink-light-color1_miio867704</summary>
        public DeviceTrackerEntity YeelinkLightColor1Miio867704 => new(_haContext, "device_tracker.yeelink_light_color1_miio867704");
    }

    public class GroupEntities
    {
        private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
        public GroupEntities(NetDaemon.HassModel.Common.IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Kameror</summary>
        public GroupEntity Cameras => new(_haContext, "group.cameras");
        ///<summary>Chrome casts</summary>
        public GroupEntity Chromecasts => new(_haContext, "group.chromecasts");
        ///<summary>Klimat</summary>
        public GroupEntity Climate => new(_haContext, "group.climate");
        ///<summary>dummy</summary>
        public GroupEntity Dummy => new(_haContext, "group.dummy");
        ///<summary>Elins mobil</summary>
        public GroupEntity ElinsDevices => new(_haContext, "group.elins_devices");
        ///<summary>Google homes</summary>
        public GroupEntity Googlehomes => new(_haContext, "group.googlehomes");
        ///<summary>kamera_uppe</summary>
        public GroupEntity KameraUppe => new(_haContext, "group.kamera_uppe");
        ///<summary>Kodi media players</summary>
        public GroupEntity Kodis => new(_haContext, "group.kodis");
        ///<summary>Batteristat</summary>
        public GroupEntity LowBatteryDevices => new(_haContext, "group.low_battery_devices");
        ///<summary>Melkers mobil</summary>
        public GroupEntity MelkersDevices => new(_haContext, "group.melkers_devices");
        ///<summary>Familjen hemmastatus</summary>
        public GroupEntity PeopleStatus => new(_haContext, "group.people_status");
        ///<summary>Familjens devicestatus</summary>
        public GroupEntity Presence => new(_haContext, "group.presence");
        ///<summary>Fjärrkontroller</summary>
        public GroupEntity Remotes => new(_haContext, "group.remotes");
        ///<summary>Sallys mobil</summary>
        public GroupEntity SallysDevices => new(_haContext, "group.sallys_devices");
        ///<summary>Systemparametrar</summary>
        public GroupEntity SystemMetrix => new(_haContext, "group.system_metrix");
        ///<summary>Tomas mobil</summary>
        public GroupEntity TomasDevices => new(_haContext, "group.tomas_devices");
    }

    public class InputBooleanEntities
    {
        private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
        public InputBooleanEntities(NetDaemon.HassModel.Common.IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Good night house</summary>
        public InputBooleanEntity GoodNightHouse => new(_haContext, "input_boolean.good_night_house");
        ///<summary>Kör på helger</summary>
        public InputBooleanEntity ScheduleOnWeekends => new(_haContext, "input_boolean.schedule_on_weekends");
    }

    public class InputNumberEntities
    {
        private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
        public InputNumberEntities(NetDaemon.HassModel.Common.IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Timmar</summary>
        public InputNumberEntity CarHeaterDepTimeHour => new(_haContext, "input_number.car_heater_dep_time_hour");
        ///<summary>Minuter</summary>
        public InputNumberEntity CarHeaterDepTimeMinutes => new(_haContext, "input_number.car_heater_dep_time_minutes");
    }

    public class InputSelectEntities
    {
        private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
        public InputSelectEntities(NetDaemon.HassModel.Common.IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Husstatus</summary>
        public InputSelectEntity HouseModeSelect => new(_haContext, "input_select.house_mode_select");
        ///<summary>Husstatus test</summary>
        public InputSelectEntity HouseModeSelectTest => new(_haContext, "input_select.house_mode_select_test");
        ///<summary>Zigbee2mqtt Log Level</summary>
        public InputSelectEntity Zigbee2mqttLogLevel => new(_haContext, "input_select.zigbee2mqtt_log_level");
    }

    public class InputTextEntities
    {
        private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
        public InputTextEntities(NetDaemon.HassModel.Common.IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Zigbee2mqtt New Name</summary>
        public InputTextEntity Zigbee2mqttNewName => new(_haContext, "input_text.zigbee2mqtt_new_name");
        ///<summary>Zigbee2mqtt Old Name</summary>
        public InputTextEntity Zigbee2mqttOldName => new(_haContext, "input_text.zigbee2mqtt_old_name");
        ///<summary>Zigbee2mqtt Remove</summary>
        public InputTextEntity Zigbee2mqttRemove => new(_haContext, "input_text.zigbee2mqtt_remove");
    }

    public class LightEntities
    {
        private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
        public LightEntities(NetDaemon.HassModel.Common.IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>ambient</summary>
        public LightEntity Ambient => new(_haContext, "light.ambient");
        ///<summary>elgato hoger</summary>
        public LightEntity ElgatoHoger => new(_haContext, "light.elgato_hoger");
        ///<summary>elgato_key_light</summary>
        public LightEntity ElgatoKeyLight => new(_haContext, "light.elgato_key_light");
        ///<summary>elgato vanster</summary>
        public LightEntity ElgatoVanster => new(_haContext, "light.elgato_vanster");
        ///<summary>farstukvist_led</summary>
        public LightEntity FarstukvistLed => new(_haContext, "light.farstukvist_led");
        ///<summary>farstukvisten</summary>
        public LightEntity Farstukvisten => new(_haContext, "light.farstukvisten");
        ///<summary>Gym led</summary>
        public LightEntity GymLed => new(_haContext, "light.gym_led");
        ///<summary>hall_byra</summary>
        public LightEntity HallByra => new(_haContext, "light.hall_byra");
        ///<summary>hall_byra</summary>
        public LightEntity HallByraOld => new(_haContext, "light.hall_byra_old");
        ///<summary>hall_dorr</summary>
        public LightEntity HallDorr => new(_haContext, "light.hall_dorr");
        ///<summary>julbelysning_kok_h</summary>
        public LightEntity JulbelysningKokH => new(_haContext, "light.julbelysning_kok_h");
        ///<summary>julbelysning_kok_v</summary>
        public LightEntity JulbelysningKokV => new(_haContext, "light.julbelysning_kok_v");
        ///<summary>julbelysning_sovrum</summary>
        public LightEntity JulbelysningSovrum => new(_haContext, "light.julbelysning_sovrum");
        ///<summary>julbelysning_tomas_rum</summary>
        public LightEntity JulbelysningTomasRum => new(_haContext, "light.julbelysning_tomas_rum");
        ///<summary>julbelysning_tvrummet</summary>
        public LightEntity JulbelysningTvrummet => new(_haContext, "light.julbelysning_tvrummet");
        ///<summary>julbelysning_vardagsrum_h</summary>
        public LightEntity JulbelysningVardagsrumH => new(_haContext, "light.julbelysning_vardagsrum_h");
        ///<summary>julbelysning_vardagsrum_v</summary>
        public LightEntity JulbelysningVardagsrumV => new(_haContext, "light.julbelysning_vardagsrum_v");
        ///<summary>kok</summary>
        public LightEntity Kok => new(_haContext, "light.kok");
        ///<summary>kok_fonster</summary>
        public LightEntity KokFonster => new(_haContext, "light.kok_fonster");
        ///<summary>kok_lilla_fonster</summary>
        public LightEntity KokLillaFonster => new(_haContext, "light.kok_lilla_fonster");
        ///<summary>melkers_rum</summary>
        public LightEntity MelkersRum => new(_haContext, "light.melkers_rum");
        ///<summary>melkers_rum_fonster</summary>
        public LightEntity MelkersRumFonster => new(_haContext, "light.melkers_rum_fonster");
        ///<summary>sallys_rum</summary>
        public LightEntity SallysRum => new(_haContext, "light.sallys_rum");
        ///<summary>sallys_rum_fonster</summary>
        public LightEntity SallysRumFonster => new(_haContext, "light.sallys_rum_fonster");
        ///<summary>sovrum</summary>
        public LightEntity Sovrum => new(_haContext, "light.sovrum");
        ///<summary>sovrum_byra</summary>
        public LightEntity SovrumByra => new(_haContext, "light.sovrum_byra");
        ///<summary>sovrum_fonster</summary>
        public LightEntity SovrumFonster => new(_haContext, "light.sovrum_fonster");
        ///<summary>tomas_rum</summary>
        public LightEntity TomasRum => new(_haContext, "light.tomas_rum");
        ///<summary>tomas_rum</summary>
        public LightEntity TomasRumFonster => new(_haContext, "light.tomas_rum_fonster");
        ///<summary>tvrum_bakgrund_tv</summary>
        public LightEntity TvrumBakgrundTv => new(_haContext, "light.tvrum_bakgrund_tv");
        ///<summary>0x90fd9ffffed4315a</summary>
        public LightEntity TvrumFonsterHoger => new(_haContext, "light.tvrum_fonster_hoger");
        ///<summary>0x90fd9ffffe92a856</summary>
        public LightEntity TvrumFonsterVanster => new(_haContext, "light.tvrum_fonster_vanster");
        ///<summary>tvrum_vagg</summary>
        public LightEntity TvrumVagg => new(_haContext, "light.tvrum_vagg");
        ///<summary>tvrummet</summary>
        public LightEntity Tvrummet => new(_haContext, "light.tvrummet");
        ///<summary>vardagsrum</summary>
        public LightEntity Vardagsrum => new(_haContext, "light.vardagsrum");
        ///<summary>0x90fd9ffffe723932</summary>
        public LightEntity VardagsrumFonsterHoger => new(_haContext, "light.vardagsrum_fonster_hoger");
        ///<summary>vardagsrum_fonster_mitten</summary>
        public LightEntity VardagsrumFonsterMitten => new(_haContext, "light.vardagsrum_fonster_mitten");
        ///<summary>vardagsrum_fonster_vanster</summary>
        public LightEntity VardagsrumFonsterVanster => new(_haContext, "light.vardagsrum_fonster_vanster");
    }

    public class LockEntities
    {
        private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
        public LockEntities(NetDaemon.HassModel.Common.IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>las_uppe</summary>
        public LockEntity LasUppe => new(_haContext, "lock.las_uppe");
    }

    public class MediaPlayerEntities
    {
        private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
        public MediaPlayerEntities(NetDaemon.HassModel.Common.IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Gymmet</summary>
        public MediaPlayerEntity Gym => new(_haContext, "media_player.gym");
        ///<summary>Huset</summary>
        public MediaPlayerEntity Huset => new(_haContext, "media_player.huset");
        ///<summary>Kök</summary>
        public MediaPlayerEntity Kok => new(_haContext, "media_player.kok");
        ///<summary>melkers rum</summary>
        public MediaPlayerEntity MelkersRum => new(_haContext, "media_player.melkers_rum");
        ///<summary>melkers tv</summary>
        public MediaPlayerEntity MelkersTv => new(_haContext, "media_player.melkers_tv");
        ///<summary>Kök</summary>
        public MediaPlayerEntity Nestaudio0573 => new(_haContext, "media_player.nestaudio0573");
        ///<summary>Ute</summary>
        public MediaPlayerEntity Nestaudio1916 => new(_haContext, "media_player.nestaudio1916");
        ///<summary>NestAudio2936</summary>
        public MediaPlayerEntity Nestaudio2936 => new(_haContext, "media_player.nestaudio2936");
        ///<summary>Plex (Plex Web - Chrome - Windows)</summary>
        public MediaPlayerEntity PlexChrome => new(_haContext, "media_player.plex_chrome");
        public MediaPlayerEntity PlexChrome2 => new(_haContext, "media_player.plex_chrome_2");
        public MediaPlayerEntity PlexChrome3 => new(_haContext, "media_player.plex_chrome_3");
        public MediaPlayerEntity PlexChromecast => new(_haContext, "media_player.plex_chromecast");
        ///<summary>Plex (Plex for Kodi - Kodi)</summary>
        public MediaPlayerEntity PlexKodiAddOnLibreelec => new(_haContext, "media_player.plex_kodi_add_on_libreelec");
        ///<summary>Plex (Plex Cast - Chromecast)</summary>
        public MediaPlayerEntity PlexPlexCastChromecast => new(_haContext, "media_player.plex_plex_cast_chromecast");
        ///<summary>Plex (Plex for Android (TV) - SHIELD Android TV)</summary>
        public MediaPlayerEntity PlexPlexForAndroidTvShieldAndroidTv => new(_haContext, "media_player.plex_plex_for_android_tv_shield_android_tv");
        ///<summary>Plex (Plex Web - Chrome - Windows)</summary>
        public MediaPlayerEntity PlexPlexWebChrome => new(_haContext, "media_player.plex_plex_web_chrome");
        ///<summary>Plex (Plex Web - Chrome - Linux)</summary>
        public MediaPlayerEntity PlexPlexWebChromeLinux => new(_haContext, "media_player.plex_plex_web_chrome_linux");
        ///<summary>Plex (Plex Web - Chrome - Linux)</summary>
        public MediaPlayerEntity PlexPlexWebChromeLinux2 => new(_haContext, "media_player.plex_plex_web_chrome_linux_2");
        ///<summary>Plex (Plex for iOS - Tomas iPad)</summary>
        public MediaPlayerEntity PlexTomasIpad => new(_haContext, "media_player.plex_tomas_ipad");
        ///<summary>Sallys högtalare</summary>
        public MediaPlayerEntity SallysHogtalare => new(_haContext, "media_player.sallys_hogtalare");
        ///<summary>SHIELD</summary>
        public MediaPlayerEntity Shield => new(_haContext, "media_player.shield");
        ///<summary>Shield TV</summary>
        public MediaPlayerEntity ShieldTv => new(_haContext, "media_player.shield_tv");
        ///<summary>Sovrum</summary>
        public MediaPlayerEntity Sovrum => new(_haContext, "media_player.sovrum");
        ///<summary>TV Gym</summary>
        public MediaPlayerEntity TvGym => new(_haContext, "media_player.tv_gym");
        ///<summary>TV Nere</summary>
        public MediaPlayerEntity TvNere => new(_haContext, "media_player.tv_nere");
        ///<summary>Tv rummet GH</summary>
        public MediaPlayerEntity TvRummetGh => new(_haContext, "media_player.tv_rummet_gh");
        ///<summary>Tv Uppe</summary>
        public MediaPlayerEntity TvUppe => new(_haContext, "media_player.tv_uppe");
        ///<summary>Vardagsrum</summary>
        public MediaPlayerEntity Vardagsrum => new(_haContext, "media_player.vardagsrum");
    }

    public class NumberEntities
    {
        private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
        public NumberEntities(NetDaemon.HassModel.Common.IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>vardagsrum_pir_occupancy_timeout</summary>
        public NumericNumberEntity VardagsrumPirOccupancyTimeout => new(_haContext, "number.vardagsrum_pir_occupancy_timeout");
    }

    public class PersonEntities
    {
        private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
        public PersonEntities(NetDaemon.HassModel.Common.IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Elin</summary>
        public PersonEntity Elin => new(_haContext, "person.elin");
        ///<summary>Melker</summary>
        public PersonEntity Melker => new(_haContext, "person.melker");
        ///<summary>Sally</summary>
        public PersonEntity Sally => new(_haContext, "person.sally");
        ///<summary>Tomas</summary>
        public PersonEntity Tomas => new(_haContext, "person.tomas");
    }

    public class ProximityEntities
    {
        private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
        public ProximityEntities(NetDaemon.HassModel.Common.IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>prox_home_elin</summary>
        public NumericProximityEntity ProxHomeElin => new(_haContext, "proximity.prox_home_elin");
        ///<summary>prox_home_melker</summary>
        public NumericProximityEntity ProxHomeMelker => new(_haContext, "proximity.prox_home_melker");
        ///<summary>prox_home_sally</summary>
        public NumericProximityEntity ProxHomeSally => new(_haContext, "proximity.prox_home_sally");
        ///<summary>prox_home_tomas</summary>
        public NumericProximityEntity ProxHomeTomas => new(_haContext, "proximity.prox_home_tomas");
    }

    public class RemoteEntities
    {
        private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
        public RemoteEntities(NetDaemon.HassModel.Common.IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>TVRUMMET</summary>
        public RemoteEntity Tvrummet => new(_haContext, "remote.tvrummet");
    }

    public class SceneEntities
    {
        private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
        public SceneEntities(NetDaemon.HassModel.Common.IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Dag</summary>
        public SceneEntity Dag => new(_haContext, "scene.dag");
        ///<summary>Kväll</summary>
        public SceneEntity Kvall => new(_haContext, "scene.kvall");
        ///<summary>Morgon</summary>
        public SceneEntity Morgon => new(_haContext, "scene.morgon");
        ///<summary>Natt</summary>
        public SceneEntity Natt => new(_haContext, "scene.natt");
        ///<summary>Städning</summary>
        public SceneEntity Stadning => new(_haContext, "scene.stadning");
    }

    public class ScriptEntities
    {
        private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
        public ScriptEntities(NetDaemon.HassModel.Common.IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Test</summary>
        public ScriptEntity E1586350051032 => new(_haContext, "script.1586350051032");
        ///<summary>Cleaning scene</summary>
        public ScriptEntity CleaningScene => new(_haContext, "script.cleaning_scene");
        ///<summary>Color scene</summary>
        public ScriptEntity ColorScene => new(_haContext, "script.color_scene");
        ///<summary>Day scene</summary>
        public ScriptEntity DayScene => new(_haContext, "script.day_scene");
        ///<summary>Evening scene</summary>
        public ScriptEntity EveningScene => new(_haContext, "script.evening_scene");
        ///<summary>Film scene</summary>
        public ScriptEntity FilmScene => new(_haContext, "script.film_scene");
        ///<summary>Morning scene</summary>
        public ScriptEntity MorningScene => new(_haContext, "script.morning_scene");
        ///<summary>Night scene</summary>
        public ScriptEntity NightScene => new(_haContext, "script.night_scene");
        ///<summary>notify</summary>
        public ScriptEntity Notify => new(_haContext, "script.notify");
        ///<summary>notify_greet</summary>
        public ScriptEntity NotifyGreet => new(_haContext, "script.notify_greet");
        ///<summary>setnightmode</summary>
        public ScriptEntity Setnightmode => new(_haContext, "script.setnightmode");
        ///<summary>TV off scene</summary>
        public ScriptEntity TvOffScene => new(_haContext, "script.tv_off_scene");
        ///<summary>TV scene</summary>
        public ScriptEntity TvScene => new(_haContext, "script.tv_scene");
        ///<summary>Zigbee2mqtt Remove</summary>
        public ScriptEntity Zigbee2mqttRemove => new(_haContext, "script.zigbee2mqtt_remove");
        ///<summary>Zigbee2mqtt Rename</summary>
        public ScriptEntity Zigbee2mqttRename => new(_haContext, "script.zigbee2mqtt_rename");
    }

    public class SelectEntities
    {
        private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
        public SelectEntities(NetDaemon.HassModel.Common.IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>TVRUMMET Activities</summary>
        public SelectEntity TvrummetActivities => new(_haContext, "select.tvrummet_activities");
    }

    public class SensorEntities
    {
        private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
        public SensorEntities(NetDaemon.HassModel.Common.IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>sallys_rum_temp_linkquality</summary>
        public NumericSensorEntity E0x00158d0001c09b01Linkquality => new(_haContext, "sensor.0x00158d0001c09b01_linkquality");
        ///<summary>hall_dorr_sensor_battery</summary>
        public NumericSensorEntity E0x00158d00020b7df4Battery => new(_haContext, "sensor.0x00158d00020b7df4_battery");
        ///<summary>hall_dorr_sensor_linkquality</summary>
        public NumericSensorEntity E0x00158d00020b7df4Linkquality => new(_haContext, "sensor.0x00158d00020b7df4_linkquality");
        ///<summary>AC 15bc0cfe:1 Rssi numeric</summary>
        public NumericSensorEntity Ac15bc0cfe1RssiNumeric => new(_haContext, "sensor.ac_15bc0cfe_1_rssi_numeric");
        ///<summary>AC 18ce362:11 Rssi numeric</summary>
        public NumericSensorEntity Ac18ce36211RssiNumeric => new(_haContext, "sensor.ac_18ce362_11_rssi_numeric");
        ///<summary>AC 18ce362:12 Rssi numeric</summary>
        public NumericSensorEntity Ac18ce36212RssiNumeric => new(_haContext, "sensor.ac_18ce362_12_rssi_numeric");
        ///<summary>AC 2947346:14 Rssi numeric</summary>
        public NumericSensorEntity Ac294734614RssiNumeric => new(_haContext, "sensor.ac_2947346_14_rssi_numeric");
        ///<summary>AC 2947346:15 Rssi numeric</summary>
        public NumericSensorEntity Ac294734615RssiNumeric => new(_haContext, "sensor.ac_2947346_15_rssi_numeric");
        ///<summary>AC 2947346:16 Rssi numeric</summary>
        public NumericSensorEntity Ac294734616RssiNumeric => new(_haContext, "sensor.ac_2947346_16_rssi_numeric");
        ///<summary>AC 29bc0cfe:6 Rssi numeric</summary>
        public NumericSensorEntity Ac29bc0cfe6RssiNumeric => new(_haContext, "sensor.ac_29bc0cfe_6_rssi_numeric");
        ///<summary>AC 2bc0cfe:1 Rssi numeric</summary>
        public NumericSensorEntity Ac2bc0cfe1RssiNumeric => new(_haContext, "sensor.ac_2bc0cfe_1_rssi_numeric");
        ///<summary>AC 34bc0cfe:6 Rssi numeric</summary>
        public NumericSensorEntity Ac34bc0cfe6RssiNumeric => new(_haContext, "sensor.ac_34bc0cfe_6_rssi_numeric");
        ///<summary>AC 36bc0cfe:8 Rssi numeric</summary>
        public NumericSensorEntity Ac36bc0cfe8RssiNumeric => new(_haContext, "sensor.ac_36bc0cfe_8_rssi_numeric");
        ///<summary>AC 39bc0cfe:7 Rssi numeric</summary>
        public NumericSensorEntity Ac39bc0cfe7RssiNumeric => new(_haContext, "sensor.ac_39bc0cfe_7_rssi_numeric");
        ///<summary>AC 44bc0cfe:1 Rssi numeric</summary>
        public NumericSensorEntity Ac44bc0cfe1RssiNumeric => new(_haContext, "sensor.ac_44bc0cfe_1_rssi_numeric");
        ///<summary>AC 50bc0cfe:8 Rssi numeric</summary>
        public NumericSensorEntity Ac50bc0cfe8RssiNumeric => new(_haContext, "sensor.ac_50bc0cfe_8_rssi_numeric");
        ///<summary>AC 51bc0cfe:4 Rssi numeric</summary>
        public NumericSensorEntity Ac51bc0cfe4RssiNumeric => new(_haContext, "sensor.ac_51bc0cfe_4_rssi_numeric");
        ///<summary>AC 51bc0cfe:8 Rssi numeric</summary>
        public NumericSensorEntity Ac51bc0cfe8RssiNumeric => new(_haContext, "sensor.ac_51bc0cfe_8_rssi_numeric");
        ///<summary>AC 52bc0cfe:1 Rssi numeric</summary>
        public NumericSensorEntity Ac52bc0cfe1RssiNumeric => new(_haContext, "sensor.ac_52bc0cfe_1_rssi_numeric");
        ///<summary>AC 55bc0cfe:7 Rssi numeric</summary>
        public NumericSensorEntity Ac55bc0cfe7RssiNumeric => new(_haContext, "sensor.ac_55bc0cfe_7_rssi_numeric");
        ///<summary>AC 63bc0cfe:9 Rssi numeric</summary>
        public NumericSensorEntity Ac63bc0cfe9RssiNumeric => new(_haContext, "sensor.ac_63bc0cfe_9_rssi_numeric");
        ///<summary>AC 67bc0cfe:4 Rssi numeric</summary>
        public NumericSensorEntity Ac67bc0cfe4RssiNumeric => new(_haContext, "sensor.ac_67bc0cfe_4_rssi_numeric");
        ///<summary>AC 72bc0cfe:2 Rssi numeric</summary>
        public NumericSensorEntity Ac72bc0cfe2RssiNumeric => new(_haContext, "sensor.ac_72bc0cfe_2_rssi_numeric");
        ///<summary>AC 81bc0cfe:1 Rssi numeric</summary>
        public NumericSensorEntity Ac81bc0cfe1RssiNumeric => new(_haContext, "sensor.ac_81bc0cfe_1_rssi_numeric");
        ///<summary>AC 93bc0cfe:2 Rssi numeric</summary>
        public NumericSensorEntity Ac93bc0cfe2RssiNumeric => new(_haContext, "sensor.ac_93bc0cfe_2_rssi_numeric");
        ///<summary>Tomas iPad Battery Level</summary>
        public NumericSensorEntity BatteryLevel => new(_haContext, "sensor.battery_level");
        ///<summary>diod_temp</summary>
        public NumericSensorEntity DiodTemp => new(_haContext, "sensor.diod_temp");
        ///<summary>Disk use (percent) /home</summary>
        public NumericSensorEntity DiskUsePercentHome => new(_haContext, "sensor.disk_use_percent_home");
        ///<summary>farstukvist_led_linkquality</summary>
        public NumericSensorEntity FarstukvistLedLinkquality => new(_haContext, "sensor.farstukvist_led_linkquality");
        ///<summary>Temp frys nere</summary>
        public NumericSensorEntity FrysnereTemperature => new(_haContext, "sensor.frysnere_temperature");
        ///<summary>0x7cb03eaa00aa0002 linkquality</summary>
        public NumericSensorEntity GymLedLinkquality => new(_haContext, "sensor.gym_led_linkquality");
        ///<summary>hacs</summary>
        public NumericSensorEntity Hacs => new(_haContext, "sensor.hacs");
        ///<summary>hall_byra_linkquality</summary>
        public NumericSensorEntity HallByraLinkquality => new(_haContext, "sensor.hall_byra_linkquality");
        ///<summary>hall_dorr_linkquality</summary>
        public NumericSensorEntity HallDorrLinkquality => new(_haContext, "sensor.hall_dorr_linkquality");
        ///<summary>hall_dorr_sensor_temperature</summary>
        public NumericSensorEntity HallDorrSensorTemperature => new(_haContext, "sensor.hall_dorr_sensor_temperature");
        ///<summary>hall_dorr_sensor_voltage</summary>
        public NumericSensorEntity HallDorrSensorVoltage => new(_haContext, "sensor.hall_dorr_sensor_voltage");
        ///<summary>Temperatur hobbyrummet</summary>
        public NumericSensorEntity HobbyrumTemp => new(_haContext, "sensor.hobbyrum_temp");
        ///<summary>hobbyrum_temp_battery</summary>
        public NumericSensorEntity HobbyrumTempBattery => new(_haContext, "sensor.hobbyrum_temp_battery");
        ///<summary>hobbyrum_temp_humidity</summary>
        public NumericSensorEntity HobbyrumTempHum => new(_haContext, "sensor.hobbyrum_temp_hum");
        ///<summary>hobbyrum_temp_linkquality</summary>
        public NumericSensorEntity HobbyrumTempLinkquality => new(_haContext, "sensor.hobbyrum_temp_linkquality");
        ///<summary>hobbyrum_temp_voltage</summary>
        public NumericSensorEntity HobbyrumTempVoltage => new(_haContext, "sensor.hobbyrum_temp_voltage");
        ///<summary>julbelysning_hoger_linkquality</summary>
        public NumericSensorEntity JulbelysningHogerLinkquality => new(_haContext, "sensor.julbelysning_hoger_linkquality");
        ///<summary>julbelysning_kok_h_linkquality</summary>
        public NumericSensorEntity JulbelysningKokHLinkquality => new(_haContext, "sensor.julbelysning_kok_h_linkquality");
        ///<summary>julbelysning_kok_v_current</summary>
        public NumericSensorEntity JulbelysningKokVCurrent => new(_haContext, "sensor.julbelysning_kok_v_current");
        ///<summary>julbelysning_kok_v_energy</summary>
        public NumericSensorEntity JulbelysningKokVEnergy => new(_haContext, "sensor.julbelysning_kok_v_energy");
        ///<summary>julbelysning_kok_v_linkquality</summary>
        public NumericSensorEntity JulbelysningKokVLinkquality => new(_haContext, "sensor.julbelysning_kok_v_linkquality");
        ///<summary>julbelysning_kok_v_power</summary>
        public NumericSensorEntity JulbelysningKokVPower => new(_haContext, "sensor.julbelysning_kok_v_power");
        ///<summary>julbelysning_kok_v_voltage</summary>
        public NumericSensorEntity JulbelysningKokVVoltage => new(_haContext, "sensor.julbelysning_kok_v_voltage");
        ///<summary>julbelysning_tomas_rum_linkquality</summary>
        public NumericSensorEntity JulbelysningTomasRumLinkquality => new(_haContext, "sensor.julbelysning_tomas_rum_linkquality");
        ///<summary>julbelysning_tvrummet_current</summary>
        public NumericSensorEntity JulbelysningTvrummetCurrent => new(_haContext, "sensor.julbelysning_tvrummet_current");
        ///<summary>julbelysning_tvrummet_energy</summary>
        public NumericSensorEntity JulbelysningTvrummetEnergy => new(_haContext, "sensor.julbelysning_tvrummet_energy");
        ///<summary>julbelysning_tvrummet_linkquality</summary>
        public NumericSensorEntity JulbelysningTvrummetLinkquality => new(_haContext, "sensor.julbelysning_tvrummet_linkquality");
        ///<summary>julbelysning_tvrummet_power</summary>
        public NumericSensorEntity JulbelysningTvrummetPower => new(_haContext, "sensor.julbelysning_tvrummet_power");
        ///<summary>julbelysning_tvrummet_voltage</summary>
        public NumericSensorEntity JulbelysningTvrummetVoltage => new(_haContext, "sensor.julbelysning_tvrummet_voltage");
        ///<summary>julbelysning_vardagsrum_v_linkquality</summary>
        public NumericSensorEntity JulbelysningVardagsrumVLinkquality => new(_haContext, "sensor.julbelysning_vardagsrum_v_linkquality");
        ///<summary>kok_lilla_fonster_linkquality</summary>
        public NumericSensorEntity KokFonsterLillaLinkquality => new(_haContext, "sensor.kok_fonster_lilla_linkquality");
        ///<summary>kok_fonster_linkquality</summary>
        public NumericSensorEntity KokFonsterLinkquality => new(_haContext, "sensor.kok_fonster_linkquality");
        ///<summary>Temp frys kök(zigbee)</summary>
        public NumericSensorEntity KokFrysTemp => new(_haContext, "sensor.kok_frys_temp");
        ///<summary>kok_frys_temp_battery</summary>
        public NumericSensorEntity KokFrysTempBattery => new(_haContext, "sensor.kok_frys_temp_battery");
        ///<summary>kok_frys_temp_humidity</summary>
        public NumericSensorEntity KokFrysTempHumidity => new(_haContext, "sensor.kok_frys_temp_humidity");
        ///<summary>kok_frys_temp_linkquality</summary>
        public NumericSensorEntity KokFrysTempLinkquality => new(_haContext, "sensor.kok_frys_temp_linkquality");
        ///<summary>kok_frys_temp_voltage</summary>
        public NumericSensorEntity KokFrysTempVoltage => new(_haContext, "sensor.kok_frys_temp_voltage");
        ///<summary>kok_pir_battery</summary>
        public NumericSensorEntity KokPirBattery => new(_haContext, "sensor.kok_pir_battery");
        ///<summary>kok_pir_illuminance</summary>
        public NumericSensorEntity KokPirIlluminance => new(_haContext, "sensor.kok_pir_illuminance");
        ///<summary>kok_pir_illuminance_lux</summary>
        public NumericSensorEntity KokPirIlluminanceLux => new(_haContext, "sensor.kok_pir_illuminance_lux");
        ///<summary>kok_pir_linkquality</summary>
        public NumericSensorEntity KokPirLinkquality => new(_haContext, "sensor.kok_pir_linkquality");
        ///<summary>kok_pir_temperature</summary>
        public NumericSensorEntity KokPirTemperature => new(_haContext, "sensor.kok_pir_temperature");
        ///<summary>kok_pir_voltage</summary>
        public NumericSensorEntity KokPirVoltage => new(_haContext, "sensor.kok_pir_voltage");
        ///<summary>las_uppe_battery</summary>
        public NumericSensorEntity LasUppeBattery => new(_haContext, "sensor.las_uppe_battery");
        ///<summary>las_uppe_linkquality</summary>
        public NumericSensorEntity LasUppeLinkquality => new(_haContext, "sensor.las_uppe_linkquality");
        ///<summary>light_outside_illuminance_lux</summary>
        public NumericSensorEntity LightOutside => new(_haContext, "sensor.light_outside");
        ///<summary>light_outside_battery</summary>
        public NumericSensorEntity LightOutsideBattery => new(_haContext, "sensor.light_outside_battery");
        ///<summary>light_outside_linkquality</summary>
        public NumericSensorEntity LightOutsideLinkquality => new(_haContext, "sensor.light_outside_linkquality");
        ///<summary>melkers_fonster_linkquality</summary>
        public NumericSensorEntity MelkersFonsterLinkquality => new(_haContext, "sensor.melkers_fonster_linkquality");
        ///<summary>melkers_rum_pir_battery</summary>
        public NumericSensorEntity MelkersRumPirOccupancyBattery => new(_haContext, "sensor.melkers_rum_pir_occupancy_battery");
        ///<summary>melkers_rum_pir_linkquality</summary>
        public NumericSensorEntity MelkersRumPirOccupancyLinkquality => new(_haContext, "sensor.melkers_rum_pir_occupancy_linkquality");
        ///<summary>melkers_rum_temp</summary>
        public NumericSensorEntity MelkersRumTemp => new(_haContext, "sensor.melkers_rum_temp");
        ///<summary>melkers_rum_temp_battery</summary>
        public NumericSensorEntity MelkersRumTempBattery => new(_haContext, "sensor.melkers_rum_temp_battery");
        ///<summary>melkers_rum_temp_humidity</summary>
        public NumericSensorEntity MelkersRumTempHumidity => new(_haContext, "sensor.melkers_rum_temp_humidity");
        ///<summary>melkers_rum_temp_linkquality</summary>
        public NumericSensorEntity MelkersRumTempLinkquality => new(_haContext, "sensor.melkers_rum_temp_linkquality");
        ///<summary>melkers_rum_temp_voltage</summary>
        public NumericSensorEntity MelkersRumTempVoltage => new(_haContext, "sensor.melkers_rum_temp_voltage");
        ///<summary>Memory use (percent)</summary>
        public NumericSensorEntity MemoryUsePercent => new(_haContext, "sensor.memory_use_percent");
        ///<summary>0x7cb03eaa00ab30fb linkquality</summary>
        public NumericSensorEntity MotorvarmareHogerLinkquality => new(_haContext, "sensor.motorvarmare_hoger_linkquality");
        ///<summary>motorvarmare_hoger_linkquality</summary>
        public NumericSensorEntity MotorvarmareHogerLinkqualityOld => new(_haContext, "sensor.motorvarmare_hoger_linkquality_old");
        ///<summary>myfitnesspal_tomas</summary>
        public NumericSensorEntity MyfitnesspalTomas => new(_haContext, "sensor.myfitnesspal_tomas");
        ///<summary>Network out wlp2s0</summary>
        public NumericSensorEntity NetworkOutWlp2s0 => new(_haContext, "sensor.network_out_wlp2s0");
        ///<summary>Plex (PLEX)</summary>
        public NumericSensorEntity PlexPlex => new(_haContext, "sensor.plex_plex");
        ///<summary>Processor use</summary>
        public NumericSensorEntity ProcessorUse => new(_haContext, "sensor.processor_use");
        ///<summary>sallys_fonster_linkquality</summary>
        public NumericSensorEntity SallysFonsterLinkquality => new(_haContext, "sensor.sallys_fonster_linkquality");
        ///<summary>sallys_rum_temp_humidity</summary>
        public NumericSensorEntity SallysRumHum => new(_haContext, "sensor.sallys_rum_hum");
        ///<summary>sallys_rum_pir_battery</summary>
        public NumericSensorEntity SallysRumPirBattery => new(_haContext, "sensor.sallys_rum_pir_battery");
        ///<summary>sallys_rum_pir_linkquality</summary>
        public NumericSensorEntity SallysRumPirLinkquality => new(_haContext, "sensor.sallys_rum_pir_linkquality");
        ///<summary>Temperatur Sallys rum</summary>
        public NumericSensorEntity SallysRumTemp => new(_haContext, "sensor.sallys_rum_temp");
        ///<summary>sallys_rum_temp_battery</summary>
        public NumericSensorEntity SallysRumTempBatt => new(_haContext, "sensor.sallys_rum_temp_batt");
        ///<summary>sallys_rum_temp_voltage</summary>
        public NumericSensorEntity SallysRumTempVoltage => new(_haContext, "sensor.sallys_rum_temp_voltage");
        ///<summary>SM-G975F Battery Level</summary>
        public NumericSensorEntity SmG975fBatteryLevel => new(_haContext, "sensor.sm_g975f_battery_level");
        ///<summary>SM-G986B Battery Level</summary>
        public NumericSensorEntity SmG986bBatteryLevel => new(_haContext, "sensor.sm_g986b_battery_level");
        ///<summary>SM-G986B Battery Temperature</summary>
        public NumericSensorEntity SmG986bBatteryTemperature => new(_haContext, "sensor.sm_g986b_battery_temperature");
        ///<summary>SM-G986B Bluetooth Connection</summary>
        public NumericSensorEntity SmG986bBluetoothConnection => new(_haContext, "sensor.sm_g986b_bluetooth_connection");
        ///<summary>SM-G986B Light Sensor</summary>
        public NumericSensorEntity SmG986bLightSensor => new(_haContext, "sensor.sm_g986b_light_sensor");
        ///<summary>SM-G986B Pressure Sensor</summary>
        public NumericSensorEntity SmG986bPressureSensor => new(_haContext, "sensor.sm_g986b_pressure_sensor");
        ///<summary>SM-G986B Storage Sensor</summary>
        public NumericSensorEntity SmG986bStorageSensor => new(_haContext, "sensor.sm_g986b_storage_sensor");
        ///<summary>sovrum_byra_linkquality</summary>
        public NumericSensorEntity SovrumByraLinkquality => new(_haContext, "sensor.sovrum_byra_linkquality");
        ///<summary>sovrum_fonster_linkquality</summary>
        public NumericSensorEntity SovrumFonsterLinkquality => new(_haContext, "sensor.sovrum_fonster_linkquality");
        ///<summary>sovrum_pir_battery</summary>
        public NumericSensorEntity SovrumPirBattery => new(_haContext, "sensor.sovrum_pir_battery");
        ///<summary>sovrum_pir_linkquality</summary>
        public NumericSensorEntity SovrumPirLinkquality => new(_haContext, "sensor.sovrum_pir_linkquality");
        ///<summary>Temperatur sovrum nere</summary>
        public NumericSensorEntity SovrumTemp => new(_haContext, "sensor.sovrum_temp");
        ///<summary>sovrum_temp_battery</summary>
        public NumericSensorEntity SovrumTempBattery => new(_haContext, "sensor.sovrum_temp_battery");
        ///<summary>sovrum_temp_humidity</summary>
        public NumericSensorEntity SovrumTempHumidity => new(_haContext, "sensor.sovrum_temp_humidity");
        ///<summary>sovrum_temp_linkquality</summary>
        public NumericSensorEntity SovrumTempLinkquality => new(_haContext, "sensor.sovrum_temp_linkquality");
        ///<summary>sovrum_temp_voltage</summary>
        public NumericSensorEntity SovrumTempVoltage => new(_haContext, "sensor.sovrum_temp_voltage");
        ///<summary>Tomas iPad Battery Level</summary>
        public NumericSensorEntity TomasIpadBatteryLevel => new(_haContext, "sensor.tomas_ipad_battery_level");
        ///<summary>Tomas iPad Storage</summary>
        public NumericSensorEntity TomasIpadStorage => new(_haContext, "sensor.tomas_ipad_storage");
        ///<summary>Tomas iPad Storage</summary>
        public NumericSensorEntity TomasIpadStorage2 => new(_haContext, "sensor.tomas_ipad_storage_2");
        ///<summary>tomas_rum_linkquality</summary>
        public NumericSensorEntity TomasRumLinkquality => new(_haContext, "sensor.tomas_rum_linkquality");
        ///<summary>tomas_rum_pir_battery</summary>
        public NumericSensorEntity TomasRumPirBattery => new(_haContext, "sensor.tomas_rum_pir_battery");
        ///<summary>tomas_rum_pir_linkquality</summary>
        public NumericSensorEntity TomasRumPirLinkquality => new(_haContext, "sensor.tomas_rum_pir_linkquality");
        ///<summary>trapp_pir_battery</summary>
        public NumericSensorEntity TrappPirBattery => new(_haContext, "sensor.trapp_pir_battery");
        ///<summary>trapp_pir_illuminance</summary>
        public NumericSensorEntity TrappPirIlluminance => new(_haContext, "sensor.trapp_pir_illuminance");
        ///<summary>trapp_pir_illuminance_lux</summary>
        public NumericSensorEntity TrappPirIlluminanceLux => new(_haContext, "sensor.trapp_pir_illuminance_lux");
        ///<summary>trapp_pir_linkquality</summary>
        public NumericSensorEntity TrappPirLinkquality => new(_haContext, "sensor.trapp_pir_linkquality");
        ///<summary>trapp_pir_temperature</summary>
        public NumericSensorEntity TrappPirTemperature => new(_haContext, "sensor.trapp_pir_temperature");
        ///<summary>trapp_pir_voltage</summary>
        public NumericSensorEntity TrappPirVoltage => new(_haContext, "sensor.trapp_pir_voltage");
        ///<summary>tvrum_bakgrund_tv_linkquality</summary>
        public NumericSensorEntity TvrumBakgrundTvLinkquality => new(_haContext, "sensor.tvrum_bakgrund_tv_linkquality");
        ///<summary>tvrum_cube_battery</summary>
        public NumericSensorEntity TvrumCubeBatt => new(_haContext, "sensor.tvrum_cube_batt");
        ///<summary>tvrum_cube_linkquality</summary>
        public NumericSensorEntity TvrumCubeLinkquality => new(_haContext, "sensor.tvrum_cube_linkquality");
        ///<summary>tvrum_cube_voltage</summary>
        public NumericSensorEntity TvrumCubeVoltage => new(_haContext, "sensor.tvrum_cube_voltage");
        ///<summary>0x90fd9ffffed4315a linkquality</summary>
        public NumericSensorEntity TvrumHogerLinkquality => new(_haContext, "sensor.tvrum_hoger_linkquality");
        ///<summary>tvrum_pir_battery</summary>
        public NumericSensorEntity TvrumPirBattery => new(_haContext, "sensor.tvrum_pir_battery");
        ///<summary>tvrum_pir_illuminance</summary>
        public NumericSensorEntity TvrumPirIlluminance => new(_haContext, "sensor.tvrum_pir_illuminance");
        ///<summary>tvrum_pir_illuminance_lux</summary>
        public NumericSensorEntity TvrumPirIlluminanceLux => new(_haContext, "sensor.tvrum_pir_illuminance_lux");
        ///<summary>tvrum_pir_linkquality</summary>
        public NumericSensorEntity TvrumPirLinkquality => new(_haContext, "sensor.tvrum_pir_linkquality");
        ///<summary>tvrum_pir_temperature</summary>
        public NumericSensorEntity TvrumPirTemperature => new(_haContext, "sensor.tvrum_pir_temperature");
        ///<summary>tvrum_pir_voltage</summary>
        public NumericSensorEntity TvrumPirVoltage => new(_haContext, "sensor.tvrum_pir_voltage");
        ///<summary>tvrum_rullgardin_hoger_battery</summary>
        public NumericSensorEntity TvrumRullgardinHogerBattery => new(_haContext, "sensor.tvrum_rullgardin_hoger_battery");
        ///<summary>tvrum_rullgardin_hoger_linkquality</summary>
        public NumericSensorEntity TvrumRullgardinHogerLinkquality => new(_haContext, "sensor.tvrum_rullgardin_hoger_linkquality");
        ///<summary>tvrum_rullgardin_vanster_battery</summary>
        public NumericSensorEntity TvrumRullgardinVansterBattery => new(_haContext, "sensor.tvrum_rullgardin_vanster_battery");
        ///<summary>tvrum_rullgardin_vanster_linkquality</summary>
        public NumericSensorEntity TvrumRullgardinVansterLinkquality => new(_haContext, "sensor.tvrum_rullgardin_vanster_linkquality");
        ///<summary>0x90fd9ffffe92a856 linkquality</summary>
        public NumericSensorEntity TvrumVansterLinkquality => new(_haContext, "sensor.tvrum_vanster_linkquality");
        ///<summary>tvrumm_vagg_linkquality</summary>
        public NumericSensorEntity TvrummVaggLinkquality => new(_haContext, "sensor.tvrumm_vagg_linkquality");
        ///<summary>ute_temp_humidity</summary>
        public NumericSensorEntity UteHum => new(_haContext, "sensor.ute_hum");
        ///<summary>ute_temp_temperature</summary>
        public NumericSensorEntity UteTemp => new(_haContext, "sensor.ute_temp");
        ///<summary>ute_temp_battery</summary>
        public NumericSensorEntity UteTempBattery => new(_haContext, "sensor.ute_temp_battery");
        ///<summary>ute_temp_linkquality</summary>
        public NumericSensorEntity UteTempLinkquality => new(_haContext, "sensor.ute_temp_linkquality");
        ///<summary>ute_temp_voltage</summary>
        public NumericSensorEntity UteTempVoltage => new(_haContext, "sensor.ute_temp_voltage");
        ///<summary>0x90fd9ffffe723932 linkquality</summary>
        public NumericSensorEntity VardagsrumHogerLinkquality => new(_haContext, "sensor.vardagsrum_hoger_linkquality");
        ///<summary>vardagsrum_fonster_mitten_linkquality</summary>
        public NumericSensorEntity VardagsrumMittenLinkquality => new(_haContext, "sensor.vardagsrum_mitten_linkquality");
        ///<summary>vardagsrum_pir_battery</summary>
        public NumericSensorEntity VardagsrumPirBattery => new(_haContext, "sensor.vardagsrum_pir_battery");
        ///<summary>vardagsrum_pir_illuminance_lux</summary>
        public NumericSensorEntity VardagsrumPirIlluminanceLux => new(_haContext, "sensor.vardagsrum_pir_illuminance_lux");
        ///<summary>vardagsrum_pir_linkquality</summary>
        public NumericSensorEntity VardagsrumPirLinkquality => new(_haContext, "sensor.vardagsrum_pir_linkquality");
        ///<summary>vardagsrum_pir_occupancy_timeout</summary>
        public NumericSensorEntity VardagsrumPirOccupancyTimeout => new(_haContext, "sensor.vardagsrum_pir_occupancy_timeout");
        ///<summary>vardagsrum_pir_temperature</summary>
        public NumericSensorEntity VardagsrumPirTemperature => new(_haContext, "sensor.vardagsrum_pir_temperature");
        ///<summary>Temperatur vardagsrum uppe</summary>
        public NumericSensorEntity VardagsrumTemp => new(_haContext, "sensor.vardagsrum_temp");
        ///<summary>vardagsrum_temp_battery</summary>
        public NumericSensorEntity VardagsrumTempBattery => new(_haContext, "sensor.vardagsrum_temp_battery");
        ///<summary>vardagsrum_temp_humidity</summary>
        public NumericSensorEntity VardagsrumTempHumidity => new(_haContext, "sensor.vardagsrum_temp_humidity");
        ///<summary>vardagsrum_temp_linkquality</summary>
        public NumericSensorEntity VardagsrumTempLinkquality => new(_haContext, "sensor.vardagsrum_temp_linkquality");
        ///<summary>vardagsrum_temp_voltage</summary>
        public NumericSensorEntity VardagsrumTempVoltage => new(_haContext, "sensor.vardagsrum_temp_voltage");
        ///<summary>vardagsrum_fonster_vanster_linkquality</summary>
        public NumericSensorEntity VardagsrumVansterLinkquality => new(_haContext, "sensor.vardagsrum_vanster_linkquality");
        ///<summary>Viking 02035,02038 b7:00 Temperature</summary>
        public NumericSensorEntity Viking0203502038B700 => new(_haContext, "sensor.viking_0203502038_b7_00");
        ///<summary>Viking 02035,02038 b7:00 Battery numeric</summary>
        public NumericSensorEntity Viking0203502038B700BatteryNumeric => new(_haContext, "sensor.viking_0203502038_b7_00_battery_numeric");
        ///<summary>Viking 02035,02038 b7:00 Humidity</summary>
        public NumericSensorEntity Viking0203502038B700Humidity => new(_haContext, "sensor.viking_0203502038_b7_00_humidity");
        ///<summary>Viking 02035,02038 b7:00 Rssi numeric</summary>
        public NumericSensorEntity Viking0203502038B700RssiNumeric => new(_haContext, "sensor.viking_0203502038_b7_00_rssi_numeric");
        ///<summary>Viking 02035,02038 b7:00 Temperature</summary>
        public NumericSensorEntity Viking0203502038B700Temperature => new(_haContext, "sensor.viking_0203502038_b7_00_temperature");
        ///<summary>Viking 02811 97:00 Temperature</summary>
        public NumericSensorEntity Viking028119700 => new(_haContext, "sensor.viking_02811_97_00");
        ///<summary>Viking 02811 97:00 Battery numeric</summary>
        public NumericSensorEntity Viking028119700BatteryNumeric => new(_haContext, "sensor.viking_02811_97_00_battery_numeric");
        ///<summary>Viking 02811 97:00 Rssi numeric</summary>
        public NumericSensorEntity Viking028119700RssiNumeric => new(_haContext, "sensor.viking_02811_97_00_rssi_numeric");
        ///<summary>Viking 02811 97:00 Temperature</summary>
        public NumericSensorEntity Viking028119700Temperature => new(_haContext, "sensor.viking_02811_97_00_temperature");
        ///<summary>Viking 02811 a7:00 Battery numeric</summary>
        public NumericSensorEntity Viking02811A700BatteryNumeric => new(_haContext, "sensor.viking_02811_a7_00_battery_numeric");
        ///<summary>Viking 02811 a7:00 Rssi numeric</summary>
        public NumericSensorEntity Viking02811A700RssiNumeric => new(_haContext, "sensor.viking_02811_a7_00_rssi_numeric");
        ///<summary>Viking 02811 a7:00 Temperature</summary>
        public NumericSensorEntity Viking02811A700Temperature => new(_haContext, "sensor.viking_02811_a7_00_temperature");
        ///<summary>yt_helto</summary>
        public NumericSensorEntity YtHelto => new(_haContext, "sensor.yt_helto");
        ///<summary>yt_me4le</summary>
        public NumericSensorEntity YtMe4le => new(_haContext, "sensor.yt_me4le");
        ///<summary>yt_pewdiepie</summary>
        public NumericSensorEntity YtPewdiepie => new(_haContext, "sensor.yt_pewdiepie");
        ///<summary>yt_qg8r</summary>
        public NumericSensorEntity YtQg8r => new(_haContext, "sensor.yt_qg8r");
        ///<summary>0x90fd9ffffe723932 power on behavior</summary>
        public SensorEntity E0x90fd9ffffe723932PowerOnBehavior => new(_haContext, "sensor.0x90fd9ffffe723932_power_on_behavior");
        ///<summary>0x90fd9ffffe92a856 power on behavior</summary>
        public SensorEntity E0x90fd9ffffe92a856PowerOnBehavior => new(_haContext, "sensor.0x90fd9ffffe92a856_power_on_behavior");
        ///<summary>0x90fd9ffffed4315a power on behavior</summary>
        public SensorEntity E0x90fd9ffffed4315aPowerOnBehavior => new(_haContext, "sensor.0x90fd9ffffed4315a_power_on_behavior");
        ///<summary>Tomas iPad Activity</summary>
        public SensorEntity Activity => new(_haContext, "sensor.activity");
        ///<summary>awesome</summary>
        public SensorEntity Awesome => new(_haContext, "sensor.awesome");
        ///<summary>Tomas iPad Battery State</summary>
        public SensorEntity BatteryState => new(_haContext, "sensor.battery_state");
        ///<summary>Tomas iPad BSSID</summary>
        public SensorEntity Bssid => new(_haContext, "sensor.bssid");
        ///<summary>Avresetid bil</summary>
        public SensorEntity CarDepartureTime => new(_haContext, "sensor.car_departure_time");
        ///<summary>Tomas iPad Connection Type</summary>
        public SensorEntity ConnectionType => new(_haContext, "sensor.connection_type");
        ///<summary>Coordinator Version</summary>
        public SensorEntity CoordinatorVersion => new(_haContext, "sensor.coordinator_version");
        ///<summary>farstukvist_led_update_state</summary>
        public SensorEntity FarstukvistLedUpdateState => new(_haContext, "sensor.farstukvist_led_update_state");
        ///<summary>Tomas iPad Geocoded Location</summary>
        public SensorEntity GeocodedLocation => new(_haContext, "sensor.geocoded_location");
        ///<summary>0x7cb03eaa00aa0002 update state</summary>
        public SensorEntity GymLedUpdateState => new(_haContext, "sensor.gym_led_update_state");
        ///<summary>Gymmet alarms</summary>
        public SensorEntity GymmetAlarms => new(_haContext, "sensor.gymmet_alarms");
        ///<summary>Gymmet device</summary>
        public SensorEntity GymmetDevice => new(_haContext, "sensor.gymmet_device");
        ///<summary>Gymmet timers</summary>
        public SensorEntity GymmetTimers => new(_haContext, "sensor.gymmet_timers");
        ///<summary>hall_byra_power_on_behavior</summary>
        public SensorEntity HallByraPowerOnBehavior => new(_haContext, "sensor.hall_byra_power_on_behavior");
        ///<summary>hall_byra_update_state</summary>
        public SensorEntity HallByraUpdateState => new(_haContext, "sensor.hall_byra_update_state");
        ///<summary>hall_dorr_power_on_behavior</summary>
        public SensorEntity HallDorrPowerOnBehavior => new(_haContext, "sensor.hall_dorr_power_on_behavior");
        ///<summary>hall_dorr_update_state</summary>
        public SensorEntity HallDorrUpdateState => new(_haContext, "sensor.hall_dorr_update_state");
        ///<summary>Hus status</summary>
        public SensorEntity HouseMode => new(_haContext, "sensor.house_mode");
        ///<summary>Humidity outside</summary>
        public SensorEntity HumOutside => new(_haContext, "sensor.hum_outside");
        ///<summary>julbelysning_hoger_update_state</summary>
        public SensorEntity JulbelysningHogerUpdateState => new(_haContext, "sensor.julbelysning_hoger_update_state");
        ///<summary>julbelysning_kok_h_power_on_behavior</summary>
        public SensorEntity JulbelysningKokHPowerOnBehavior => new(_haContext, "sensor.julbelysning_kok_h_power_on_behavior");
        ///<summary>julbelysning_kok_h_update_state</summary>
        public SensorEntity JulbelysningKokHUpdateState => new(_haContext, "sensor.julbelysning_kok_h_update_state");
        ///<summary>julbelysning_tomas_rum_power_on_behavior</summary>
        public SensorEntity JulbelysningTomasRumPowerOnBehavior => new(_haContext, "sensor.julbelysning_tomas_rum_power_on_behavior");
        ///<summary>julbelysning_tomas_rum_update_state</summary>
        public SensorEntity JulbelysningTomasRumUpdateState => new(_haContext, "sensor.julbelysning_tomas_rum_update_state");
        ///<summary>julbelysning_vardagsrum_h_power_on_behavior</summary>
        public SensorEntity JulbelysningVardagsrumHPowerOnBehavior => new(_haContext, "sensor.julbelysning_vardagsrum_h_power_on_behavior");
        ///<summary>julbelysning_vardagsrum_v_power_on_behavior</summary>
        public SensorEntity JulbelysningVardagsrumVPowerOnBehavior => new(_haContext, "sensor.julbelysning_vardagsrum_v_power_on_behavior");
        ///<summary>sensor.julbelysning_vardagsrum_v_update_state</summary>
        public SensorEntity JulbelysningVardagsrumVUpdateState => new(_haContext, "sensor.julbelysning_vardagsrum_v_update_state");
        ///<summary>Kök alarms</summary>
        public SensorEntity KokAlarms => new(_haContext, "sensor.kok_alarms");
        ///<summary>Kök device</summary>
        public SensorEntity KokDevice => new(_haContext, "sensor.kok_device");
        ///<summary>kok_lilla_fonster_update_state</summary>
        public SensorEntity KokFonsterLillaUpdateState => new(_haContext, "sensor.kok_fonster_lilla_update_state");
        ///<summary>kok_fonster_power_on_behavior</summary>
        public SensorEntity KokFonsterPowerOnBehavior => new(_haContext, "sensor.kok_fonster_power_on_behavior");
        ///<summary>kok_fonster_update_state</summary>
        public SensorEntity KokFonsterUpdateState => new(_haContext, "sensor.kok_fonster_update_state");
        ///<summary>kok_lilla_fonster_power_on_behavior</summary>
        public SensorEntity KokLillaFonsterPowerOnBehavior => new(_haContext, "sensor.kok_lilla_fonster_power_on_behavior");
        ///<summary>Kök timers</summary>
        public SensorEntity KokTimers => new(_haContext, "sensor.kok_timers");
        ///<summary>Krisinformation Västernorrland</summary>
        public SensorEntity KrisinformationVasternorrland => new(_haContext, "sensor.krisinformation_vasternorrland");
        ///<summary>Last boot</summary>
        public SensorEntity LastBoot => new(_haContext, "sensor.last_boot");
        ///<summary>Tomas iPad Last Update Trigger</summary>
        public SensorEntity LastUpdateTrigger => new(_haContext, "sensor.last_update_trigger");
        ///<summary>light_outside_illuminance</summary>
        public SensorEntity LightOutsideIlluminance => new(_haContext, "sensor.light_outside_illuminance");
        ///<summary>Load (15m)</summary>
        public SensorEntity Load15m => new(_haContext, "sensor.load_15m");
        ///<summary>Load (1m)</summary>
        public SensorEntity Load1m => new(_haContext, "sensor.load_1m");
        ///<summary>Load (5m)</summary>
        public SensorEntity Load5m => new(_haContext, "sensor.load_5m");
        ///<summary>melkers_fonster_power_on_behavior</summary>
        public SensorEntity MelkersFonsterPowerOnBehavior => new(_haContext, "sensor.melkers_fonster_power_on_behavior");
        ///<summary>melkers_fonster_update_state</summary>
        public SensorEntity MelkersFonsterUpdateState => new(_haContext, "sensor.melkers_fonster_update_state");
        ///<summary>melkers rum alarms</summary>
        public SensorEntity MelkersRumAlarms => new(_haContext, "sensor.melkers_rum_alarms");
        ///<summary>melkers rum device</summary>
        public SensorEntity MelkersRumDevice => new(_haContext, "sensor.melkers_rum_device");
        ///<summary>melkers_rum_pir_requested_brightness_level</summary>
        public SensorEntity MelkersRumPirOccupancyRequestedBrightnessLevel => new(_haContext, "sensor.melkers_rum_pir_occupancy_requested_brightness_level");
        ///<summary>melkers_rum_pir_requested_brightness_percent</summary>
        public SensorEntity MelkersRumPirOccupancyRequestedBrightnessPercent => new(_haContext, "sensor.melkers_rum_pir_occupancy_requested_brightness_percent");
        ///<summary>melkers_rum_pir_update_state</summary>
        public SensorEntity MelkersRumPirUpdateState => new(_haContext, "sensor.melkers_rum_pir_update_state");
        ///<summary>melkers rum timers</summary>
        public SensorEntity MelkersRumTimers => new(_haContext, "sensor.melkers_rum_timers");
        ///<summary>melkers tv device</summary>
        public SensorEntity MelkersTvDevice => new(_haContext, "sensor.melkers_tv_device");
        ///<summary>0x7cb03eaa00ab30fb update state</summary>
        public SensorEntity MotorvarmareHogerUpdateState => new(_haContext, "sensor.motorvarmare_hoger_update_state");
        ///<summary>motorvarmare_hoger_update_state</summary>
        public SensorEntity MotorvarmareHogerUpdateStateOld => new(_haContext, "sensor.motorvarmare_hoger_update_state_old");
        ///<summary>netdaemon_status</summary>
        public SensorEntity NetdaemonStatus => new(_haContext, "sensor.netdaemon_status");
        ///<summary>sallys_fonster_power_on_behavior</summary>
        public SensorEntity SallysFonsterPowerOnBehavior => new(_haContext, "sensor.sallys_fonster_power_on_behavior");
        ///<summary>sallys_fonster_update_state</summary>
        public SensorEntity SallysFonsterUpdateState => new(_haContext, "sensor.sallys_fonster_update_state");
        ///<summary>Sallys högtalare alarms</summary>
        public SensorEntity SallysHogtalareAlarms => new(_haContext, "sensor.sallys_hogtalare_alarms");
        ///<summary>Sallys högtalare device</summary>
        public SensorEntity SallysHogtalareDevice => new(_haContext, "sensor.sallys_hogtalare_device");
        ///<summary>Sallys högtalare timers</summary>
        public SensorEntity SallysHogtalareTimers => new(_haContext, "sensor.sallys_hogtalare_timers");
        ///<summary>sallys_rum_pir_requested_brightness_level</summary>
        public SensorEntity SallysRumPirRequestedBrightnessLevel => new(_haContext, "sensor.sallys_rum_pir_requested_brightness_level");
        ///<summary>sallys_rum_pir_requested_brightness_percent</summary>
        public SensorEntity SallysRumPirRequestedBrightnessPercent => new(_haContext, "sensor.sallys_rum_pir_requested_brightness_percent");
        ///<summary>sallys_rum_pir_update_state</summary>
        public SensorEntity SallysRumPirUpdateState => new(_haContext, "sensor.sallys_rum_pir_update_state");
        ///<summary>SM-G975F Battery State</summary>
        public SensorEntity SmG975fBatteryState => new(_haContext, "sensor.sm_g975f_battery_state");
        ///<summary>SM-G975F Geocoded Location</summary>
        public SensorEntity SmG975fGeocodedLocation => new(_haContext, "sensor.sm_g975f_geocoded_location");
        ///<summary>SM-G975F Wifi Connection</summary>
        public SensorEntity SmG975fWifiConnection => new(_haContext, "sensor.sm_g975f_wifi_connection");
        ///<summary>SM-G986B Audio Sensor</summary>
        public SensorEntity SmG986bAudioSensor => new(_haContext, "sensor.sm_g986b_audio_sensor");
        ///<summary>SM-G986B Battery Health</summary>
        public SensorEntity SmG986bBatteryHealth => new(_haContext, "sensor.sm_g986b_battery_health");
        ///<summary>SM-G986B Battery State</summary>
        public SensorEntity SmG986bBatteryState => new(_haContext, "sensor.sm_g986b_battery_state");
        ///<summary>SM-G986B Charger Type</summary>
        public SensorEntity SmG986bChargerType => new(_haContext, "sensor.sm_g986b_charger_type");
        ///<summary>SM-G986B Do Not Disturb Sensor</summary>
        public SensorEntity SmG986bDoNotDisturbSensor => new(_haContext, "sensor.sm_g986b_do_not_disturb_sensor");
        ///<summary>SM-G986B Geocoded Location</summary>
        public SensorEntity SmG986bGeocodedLocation => new(_haContext, "sensor.sm_g986b_geocoded_location");
        ///<summary>SM-G986B Last Reboot</summary>
        public SensorEntity SmG986bLastReboot => new(_haContext, "sensor.sm_g986b_last_reboot");
        ///<summary>SM-G986B Next Alarm</summary>
        public SensorEntity SmG986bNextAlarm => new(_haContext, "sensor.sm_g986b_next_alarm");
        ///<summary>SM-G986B Proximity Sensor</summary>
        public SensorEntity SmG986bProximitySensor => new(_haContext, "sensor.sm_g986b_proximity_sensor");
        ///<summary>SM-G986B Wifi Connection</summary>
        public SensorEntity SmG986bWifiConnection => new(_haContext, "sensor.sm_g986b_wifi_connection");
        ///<summary>Snapshot State</summary>
        public SensorEntity SnapshotBackup => new(_haContext, "sensor.snapshot_backup");
        ///<summary>Sovrum alarms</summary>
        public SensorEntity SovrumAlarms => new(_haContext, "sensor.sovrum_alarms");
        ///<summary>sovrum_byra_power_on_behavior</summary>
        public SensorEntity SovrumByraPowerOnBehavior => new(_haContext, "sensor.sovrum_byra_power_on_behavior");
        ///<summary>sovrum_byra_update_state</summary>
        public SensorEntity SovrumByraUpdateState => new(_haContext, "sensor.sovrum_byra_update_state");
        ///<summary>Sovrum device</summary>
        public SensorEntity SovrumDevice => new(_haContext, "sensor.sovrum_device");
        ///<summary>sovrum_fonster_power_on_behavior</summary>
        public SensorEntity SovrumFonsterPowerOnBehavior => new(_haContext, "sensor.sovrum_fonster_power_on_behavior");
        ///<summary>sovrum_fonster_update_state</summary>
        public SensorEntity SovrumFonsterUpdateState => new(_haContext, "sensor.sovrum_fonster_update_state");
        ///<summary>sovrum_pir_requested_brightness_level</summary>
        public SensorEntity SovrumPirRequestedBrightnessLevel => new(_haContext, "sensor.sovrum_pir_requested_brightness_level");
        ///<summary>sovrum_pir_requested_brightness_percent</summary>
        public SensorEntity SovrumPirRequestedBrightnessPercent => new(_haContext, "sensor.sovrum_pir_requested_brightness_percent");
        ///<summary>sovrum_pir_update_state</summary>
        public SensorEntity SovrumPirUpdateState => new(_haContext, "sensor.sovrum_pir_update_state");
        ///<summary>Sovrum timers</summary>
        public SensorEntity SovrumTimers => new(_haContext, "sensor.sovrum_timers");
        ///<summary>Tomas iPad SSID</summary>
        public SensorEntity Ssid => new(_haContext, "sensor.ssid");
        ///<summary>Temperature outside</summary>
        public SensorEntity TempOutside => new(_haContext, "sensor.temp_outside");
        ///<summary>Tomas iPad Activity</summary>
        public SensorEntity TomasIpadActivity => new(_haContext, "sensor.tomas_ipad_activity");
        ///<summary>Tomas iPad Battery State</summary>
        public SensorEntity TomasIpadBatteryState => new(_haContext, "sensor.tomas_ipad_battery_state");
        ///<summary>Tomas iPad BSSID</summary>
        public SensorEntity TomasIpadBssid => new(_haContext, "sensor.tomas_ipad_bssid");
        ///<summary>Tomas iPad Connection Type</summary>
        public SensorEntity TomasIpadConnectionType => new(_haContext, "sensor.tomas_ipad_connection_type");
        ///<summary>Tomas iPad Geocoded Location</summary>
        public SensorEntity TomasIpadGeocodedLocation => new(_haContext, "sensor.tomas_ipad_geocoded_location");
        ///<summary>Tomas iPad Last Update Trigger</summary>
        public SensorEntity TomasIpadLastUpdateTrigger => new(_haContext, "sensor.tomas_ipad_last_update_trigger");
        ///<summary>Tomas iPad SSID</summary>
        public SensorEntity TomasIpadSsid => new(_haContext, "sensor.tomas_ipad_ssid");
        ///<summary>tomas_rum_pir_requested_brightness_level</summary>
        public SensorEntity TomasRumPirRequestedBrightnessLevel => new(_haContext, "sensor.tomas_rum_pir_requested_brightness_level");
        ///<summary>tomas_rum_pir_requested_brightness_percent</summary>
        public SensorEntity TomasRumPirRequestedBrightnessPercent => new(_haContext, "sensor.tomas_rum_pir_requested_brightness_percent");
        ///<summary>tomas_rum_pir_update_state</summary>
        public SensorEntity TomasRumPirUpdateState => new(_haContext, "sensor.tomas_rum_pir_update_state");
        ///<summary>tomas_rum_power_on_behavior</summary>
        public SensorEntity TomasRumPowerOnBehavior => new(_haContext, "sensor.tomas_rum_power_on_behavior");
        ///<summary>tomas_rum_update_state</summary>
        public SensorEntity TomasRumUpdateState => new(_haContext, "sensor.tomas_rum_update_state");
        ///<summary>TV Gym device</summary>
        public SensorEntity TvGymDevice => new(_haContext, "sensor.tv_gym_device");
        ///<summary>TV Nere device</summary>
        public SensorEntity TvNereDevice => new(_haContext, "sensor.tv_nere_device");
        ///<summary>Tv rummet GH alarms</summary>
        public SensorEntity TvRummetGhAlarms => new(_haContext, "sensor.tv_rummet_gh_alarms");
        ///<summary>Tv rummet GH device</summary>
        public SensorEntity TvRummetGhDevice => new(_haContext, "sensor.tv_rummet_gh_device");
        ///<summary>Tv rummet GH timers</summary>
        public SensorEntity TvRummetGhTimers => new(_haContext, "sensor.tv_rummet_gh_timers");
        ///<summary>Tv Uppe device</summary>
        public SensorEntity TvUppeDevice => new(_haContext, "sensor.tv_uppe_device");
        ///<summary>tvrum_bakgrund_tv_update_state</summary>
        public SensorEntity TvrumBakgrundTvUpdateState => new(_haContext, "sensor.tvrum_bakgrund_tv_update_state");
        ///<summary>tvrum_cube_action</summary>
        public SensorEntity TvrumCube => new(_haContext, "sensor.tvrum_cube");
        ///<summary>tvrum_cube_action_angle</summary>
        public SensorEntity TvrumCubeActionAngle => new(_haContext, "sensor.tvrum_cube_action_angle");
        ///<summary>tvrum_cube_action_from_side</summary>
        public SensorEntity TvrumCubeActionFromSide => new(_haContext, "sensor.tvrum_cube_action_from_side");
        ///<summary>tvrum_cube_action_side</summary>
        public SensorEntity TvrumCubeActionSide => new(_haContext, "sensor.tvrum_cube_action_side");
        ///<summary>tvrum_cube_action_to_side</summary>
        public SensorEntity TvrumCubeActionToSide => new(_haContext, "sensor.tvrum_cube_action_to_side");
        ///<summary>0x90fd9ffffed4315a update state</summary>
        public SensorEntity TvrumFonsterHogerUpdateState => new(_haContext, "sensor.tvrum_fonster_hoger_update_state");
        ///<summary>0x90fd9ffffe92a856 update state</summary>
        public SensorEntity TvrumFonsterVansterUpdateState => new(_haContext, "sensor.tvrum_fonster_vanster_update_state");
        ///<summary>tvrum_rullgardin_hoger_update_state</summary>
        public SensorEntity TvrumRullgardinHogerUpdateState => new(_haContext, "sensor.tvrum_rullgardin_hoger_update_state");
        ///<summary>tvrum_rullgardin_vanster_update_state</summary>
        public SensorEntity TvrumRullgardinVansterUpdateState => new(_haContext, "sensor.tvrum_rullgardin_vanster_update_state");
        ///<summary>tvrumm_vagg_update_state</summary>
        public SensorEntity TvrummVaggUpdateState => new(_haContext, "sensor.tvrumm_vagg_update_state");
        ///<summary>Ute alarms</summary>
        public SensorEntity UteAlarms => new(_haContext, "sensor.ute_alarms");
        ///<summary>Ute device</summary>
        public SensorEntity UteDevice => new(_haContext, "sensor.ute_device");
        ///<summary>Ute timers</summary>
        public SensorEntity UteTimers => new(_haContext, "sensor.ute_timers");
        ///<summary>Vardagsrum alarms</summary>
        public SensorEntity VardagsrumAlarms => new(_haContext, "sensor.vardagsrum_alarms");
        ///<summary>Vardagsrum device</summary>
        public SensorEntity VardagsrumDevice => new(_haContext, "sensor.vardagsrum_device");
        ///<summary>0x90fd9ffffe723932 update state</summary>
        public SensorEntity VardagsrumFonsterHogerUpdateState => new(_haContext, "sensor.vardagsrum_fonster_hoger_update_state");
        ///<summary>vardagsrum_fonster_mitten_power_on_behavior</summary>
        public SensorEntity VardagsrumFonsterMittenPowerOnBehavior => new(_haContext, "sensor.vardagsrum_fonster_mitten_power_on_behavior");
        ///<summary>vardagsrum_fonster_mitten_update_state</summary>
        public SensorEntity VardagsrumFonsterMittenUpdateState => new(_haContext, "sensor.vardagsrum_fonster_mitten_update_state");
        ///<summary>vardagsrum_fonster_vanster_power_on_behavior</summary>
        public SensorEntity VardagsrumFonsterVansterPowerOnBehavior => new(_haContext, "sensor.vardagsrum_fonster_vanster_power_on_behavior");
        ///<summary>vardagsrum_fonster_vanster_update_state</summary>
        public SensorEntity VardagsrumFonsterVansterUpdateState => new(_haContext, "sensor.vardagsrum_fonster_vanster_update_state");
        ///<summary>vardagsrum_pir_illuminance</summary>
        public SensorEntity VardagsrumPirIlluminance => new(_haContext, "sensor.vardagsrum_pir_illuminance");
        ///<summary>vardagsrum_pir_motion_sensitivity</summary>
        public SensorEntity VardagsrumPirMotionSensitivity => new(_haContext, "sensor.vardagsrum_pir_motion_sensitivity");
        ///<summary>vardagsrum_pir_update_state</summary>
        public SensorEntity VardagsrumPirUpdateState => new(_haContext, "sensor.vardagsrum_pir_update_state");
        ///<summary>Vardagsrum timers</summary>
        public SensorEntity VardagsrumTimers => new(_haContext, "sensor.vardagsrum_timers");
        ///<summary>Viking 02035,02038 b7:00 Humidity status</summary>
        public SensorEntity Viking0203502038B700HumidityStatus => new(_haContext, "sensor.viking_0203502038_b7_00_humidity_status");
        ///<summary>Zigbee2mqtt Bridge state</summary>
        public SensorEntity Zigbee2mqttBridgeState => new(_haContext, "sensor.zigbee2mqtt_bridge_state");
        ///<summary>Zigbee2mqtt Version</summary>
        public SensorEntity Zigbee2mqttVersion => new(_haContext, "sensor.zigbee2mqtt_version");
    }

    public class SunEntities
    {
        private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
        public SunEntities(NetDaemon.HassModel.Common.IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Sun</summary>
        public SunEntity Sun => new(_haContext, "sun.sun");
    }

    public class SwitchEntities
    {
        private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
        public SwitchEntities(NetDaemon.HassModel.Common.IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>a_diod</summary>
        public SwitchEntity ADiod => new(_haContext, "switch.a_diod");
        ///<summary>AC 15bc0cfe:1</summary>
        public SwitchEntity Ac15bc0cfe1 => new(_haContext, "switch.ac_15bc0cfe_1");
        ///<summary>AC 18ce362:11</summary>
        public SwitchEntity Ac18ce36211 => new(_haContext, "switch.ac_18ce362_11");
        ///<summary>AC 18ce362:12</summary>
        public SwitchEntity Ac18ce36212 => new(_haContext, "switch.ac_18ce362_12");
        ///<summary>AC 2947346:14</summary>
        public SwitchEntity Ac294734614 => new(_haContext, "switch.ac_2947346_14");
        ///<summary>AC 2947346:15</summary>
        public SwitchEntity Ac294734615 => new(_haContext, "switch.ac_2947346_15");
        ///<summary>AC 2947346:16</summary>
        public SwitchEntity Ac294734616 => new(_haContext, "switch.ac_2947346_16");
        ///<summary>AC 29bc0cfe:6</summary>
        public SwitchEntity Ac29bc0cfe6 => new(_haContext, "switch.ac_29bc0cfe_6");
        ///<summary>AC 2bc0cfe:1</summary>
        public SwitchEntity Ac2bc0cfe1 => new(_haContext, "switch.ac_2bc0cfe_1");
        ///<summary>AC 34bc0cfe:6</summary>
        public SwitchEntity Ac34bc0cfe6 => new(_haContext, "switch.ac_34bc0cfe_6");
        ///<summary>AC 36bc0cfe:8</summary>
        public SwitchEntity Ac36bc0cfe8 => new(_haContext, "switch.ac_36bc0cfe_8");
        ///<summary>AC 39bc0cfe:7</summary>
        public SwitchEntity Ac39bc0cfe7 => new(_haContext, "switch.ac_39bc0cfe_7");
        ///<summary>AC 44bc0cfe:1</summary>
        public SwitchEntity Ac44bc0cfe1 => new(_haContext, "switch.ac_44bc0cfe_1");
        ///<summary>AC 50bc0cfe:8</summary>
        public SwitchEntity Ac50bc0cfe8 => new(_haContext, "switch.ac_50bc0cfe_8");
        ///<summary>AC 51bc0cfe:4</summary>
        public SwitchEntity Ac51bc0cfe4 => new(_haContext, "switch.ac_51bc0cfe_4");
        ///<summary>AC 51bc0cfe:8</summary>
        public SwitchEntity Ac51bc0cfe8 => new(_haContext, "switch.ac_51bc0cfe_8");
        ///<summary>AC 52bc0cfe:1</summary>
        public SwitchEntity Ac52bc0cfe1 => new(_haContext, "switch.ac_52bc0cfe_1");
        ///<summary>AC 55bc0cfe:7</summary>
        public SwitchEntity Ac55bc0cfe7 => new(_haContext, "switch.ac_55bc0cfe_7");
        ///<summary>AC 67bc0cfe:4</summary>
        public SwitchEntity Ac67bc0cfe4 => new(_haContext, "switch.ac_67bc0cfe_4");
        ///<summary>AC 81bc0cfe:1</summary>
        public SwitchEntity Ac81bc0cfe1 => new(_haContext, "switch.ac_81bc0cfe_1");
        ///<summary>AC 93bc0cfe:2</summary>
        public SwitchEntity Ac93bc0cfe2 => new(_haContext, "switch.ac_93bc0cfe_2");
        ///<summary>computer_tomas</summary>
        public SwitchEntity ComputerTomas => new(_haContext, "switch.computer_tomas");
        ///<summary>film</summary>
        public SwitchEntity Film => new(_haContext, "switch.film");
        ///<summary>Gymmet Do Not Disturb</summary>
        public SwitchEntity GymmetDoNotDisturb => new(_haContext, "switch.gymmet_do_not_disturb");
        ///<summary>Switch Hall byrå</summary>
        public SwitchEntity HallByra => new(_haContext, "switch.hall_byra");
        ///<summary>Julbelysning 1</summary>
        public SwitchEntity Julbelysning1 => new(_haContext, "switch.julbelysning_1");
        ///<summary>julbelysning_kok_h</summary>
        public SwitchEntity JulbelysningKokH => new(_haContext, "switch.julbelysning_kok_h");
        ///<summary>julbelysning_kok_v</summary>
        public SwitchEntity JulbelysningKokV => new(_haContext, "switch.julbelysning_kok_v");
        ///<summary>julbelysning_tomas_rum</summary>
        public SwitchEntity JulbelysningTomasRum => new(_haContext, "switch.julbelysning_tomas_rum");
        ///<summary>julbelysning_tvrummet</summary>
        public SwitchEntity JulbelysningTvrummet => new(_haContext, "switch.julbelysning_tvrummet");
        ///<summary>julbelysning_hoger</summary>
        public SwitchEntity JulbelysningVardagsrumH => new(_haContext, "switch.julbelysning_vardagsrum_h");
        ///<summary>julbelysning_vardagsrum_v</summary>
        public SwitchEntity JulbelysningVardagsrumV => new(_haContext, "switch.julbelysning_vardagsrum_v");
        ///<summary>KODI Switch</summary>
        public SwitchEntity Kodi => new(_haContext, "switch.kodi");
        ///<summary>Kök Do Not Disturb</summary>
        public SwitchEntity KokDoNotDisturb => new(_haContext, "switch.kok_do_not_disturb");
        ///<summary>melkers rum Do Not Disturb</summary>
        public SwitchEntity MelkersRumDoNotDisturb => new(_haContext, "switch.melkers_rum_do_not_disturb");
        ///<summary>melkers_fonster</summary>
        public SwitchEntity MelkersRumFonster => new(_haContext, "switch.melkers_rum_fonster");
        ///<summary>motorvärmare</summary>
        public SwitchEntity MotorvarmareHoger => new(_haContext, "switch.motorvarmare_hoger");
        ///<summary>motorvarmare_hoger</summary>
        public SwitchEntity MotorvarmareHogerOld => new(_haContext, "switch.motorvarmare_hoger_old");
        ///<summary>netdaemon_alarm</summary>
        public SwitchEntity NetdaemonAlarm => new(_haContext, "switch.netdaemon_alarm");
        ///<summary>netdaemon_calendar_trash</summary>
        public SwitchEntity NetdaemonCalendarTrash => new(_haContext, "switch.netdaemon_calendar_trash");
        ///<summary>netdaemon_callserviceapp</summary>
        public SwitchEntity NetdaemonCallserviceapp => new(_haContext, "switch.netdaemon_callserviceapp");
        ///<summary>netdaemon_debug_app</summary>
        public SwitchEntity NetdaemonDebugApp => new(_haContext, "switch.netdaemon_debug_app");
        ///<summary>netdaemon_frys</summary>
        public SwitchEntity NetdaemonFrys => new(_haContext, "switch.netdaemon_frys");
        ///<summary>netdaemon_generatedappbase</summary>
        public SwitchEntity NetdaemonGeneratedappbase => new(_haContext, "switch.netdaemon_generatedappbase");
        ///<summary>netdaemon_googlecalendarmanager</summary>
        public SwitchEntity NetdaemonGooglecalendarmanager => new(_haContext, "switch.netdaemon_googlecalendarmanager");
        ///<summary>netdaemon_hacs_notify_on_update</summary>
        public SwitchEntity NetdaemonHacsNotifyOnUpdate => new(_haContext, "switch.netdaemon_hacs_notify_on_update");
        ///<summary>netdaemon_hello_world_app</summary>
        public SwitchEntity NetdaemonHelloWorldApp => new(_haContext, "switch.netdaemon_hello_world_app");
        ///<summary>netdaemon_hellonewmodelapp</summary>
        public SwitchEntity NetdaemonHellonewmodelapp => new(_haContext, "switch.netdaemon_hellonewmodelapp");
        ///<summary>netdaemon_helloworldapp</summary>
        public SwitchEntity NetdaemonHelloworldapp => new(_haContext, "switch.netdaemon_helloworldapp");
        ///<summary>netdaemon_house_state_manager</summary>
        public SwitchEntity NetdaemonHouseStateManager => new(_haContext, "switch.netdaemon_house_state_manager");
        ///<summary>netdaemon_housestatemanager</summary>
        public SwitchEntity NetdaemonHousestatemanager => new(_haContext, "switch.netdaemon_housestatemanager");
        ///<summary>netdaemon_interfaceapp</summary>
        public SwitchEntity NetdaemonInterfaceapp => new(_haContext, "switch.netdaemon_interfaceapp");
        ///<summary>netdaemon_isolation1</summary>
        public SwitchEntity NetdaemonIsolation1 => new(_haContext, "switch.netdaemon_isolation1");
        ///<summary>netdaemon_isolation2</summary>
        public SwitchEntity NetdaemonIsolation2 => new(_haContext, "switch.netdaemon_isolation2");
        ///<summary>netdaemon_isolation3</summary>
        public SwitchEntity NetdaemonIsolation3 => new(_haContext, "switch.netdaemon_isolation3");
        ///<summary>netdaemon_light_manager</summary>
        public SwitchEntity NetdaemonLightManager => new(_haContext, "switch.netdaemon_light_manager");
        ///<summary>netdaemon_m3app</summary>
        public SwitchEntity NetdaemonM3app => new(_haContext, "switch.netdaemon_m3app");
        ///<summary>netdaemon_magic_cube</summary>
        public SwitchEntity NetdaemonMagicCube => new(_haContext, "switch.netdaemon_magic_cube");
        ///<summary>netdaemon_motion</summary>
        public SwitchEntity NetdaemonMotion => new(_haContext, "switch.netdaemon_motion");
        ///<summary>netdaemon_motorvarmare</summary>
        public SwitchEntity NetdaemonMotorvarmare => new(_haContext, "switch.netdaemon_motorvarmare");
        ///<summary>netdaemon_room_specific</summary>
        public SwitchEntity NetdaemonRoomSpecific => new(_haContext, "switch.netdaemon_room_specific");
        ///<summary>netdaemon_roomspecificmanager</summary>
        public SwitchEntity NetdaemonRoomspecificmanager => new(_haContext, "switch.netdaemon_roomspecificmanager");
        ///<summary>netdaemon_scheduledapp</summary>
        public SwitchEntity NetdaemonScheduledapp => new(_haContext, "switch.netdaemon_scheduledapp");
        ///<summary>netdaemon_schedulertests</summary>
        public SwitchEntity NetdaemonSchedulertests => new(_haContext, "switch.netdaemon_schedulertests");
        ///<summary>netdaemon_ttsapp</summary>
        public SwitchEntity NetdaemonTtsapp => new(_haContext, "switch.netdaemon_ttsapp");
        ///<summary>netdaemon_tv</summary>
        public SwitchEntity NetdaemonTv => new(_haContext, "switch.netdaemon_tv");
        ///<summary>netdaemon_tvmanager</summary>
        public SwitchEntity NetdaemonTvmanager => new(_haContext, "switch.netdaemon_tvmanager");
        ///<summary>netdaemon_webhook</summary>
        public SwitchEntity NetdaemonWebhook => new(_haContext, "switch.netdaemon_webhook");
        ///<summary>netdaemon_welcome_home</summary>
        public SwitchEntity NetdaemonWelcomeHome => new(_haContext, "switch.netdaemon_welcome_home");
        ///<summary>netdaemon_yamlentitiesapp</summary>
        public SwitchEntity NetdaemonYamlentitiesapp => new(_haContext, "switch.netdaemon_yamlentitiesapp");
        ///<summary>netdaemon_zhaapp</summary>
        public SwitchEntity NetdaemonZhaapp => new(_haContext, "switch.netdaemon_zhaapp");
        ///<summary>Sallys högtalare Do Not Disturb</summary>
        public SwitchEntity SallysHogtalareDoNotDisturb => new(_haContext, "switch.sallys_hogtalare_do_not_disturb");
        ///<summary>sallys_fonster</summary>
        public SwitchEntity SallysRumFonster => new(_haContext, "switch.sallys_rum_fonster");
        ///<summary>shelly_relay</summary>
        public SwitchEntity ShellyRelay => new(_haContext, "switch.shelly_relay");
        ///<summary>sonoff1_relay</summary>
        public SwitchEntity Sonoff1Relay => new(_haContext, "switch.sonoff1_relay");
        ///<summary>Sovrum Do Not Disturb</summary>
        public SwitchEntity SovrumDoNotDisturb => new(_haContext, "switch.sovrum_do_not_disturb");
        ///<summary>Melkers TV switch</summary>
        public SwitchEntity Switch8MelkersTv => new(_haContext, "switch.switch8_melkers_tv");
        ///<summary>tv</summary>
        public SwitchEntity Tv => new(_haContext, "switch.tv");
        ///<summary>Tv rummet GH Do Not Disturb</summary>
        public SwitchEntity TvRummetGhDoNotDisturb => new(_haContext, "switch.tv_rummet_gh_do_not_disturb");
        ///<summary>tvrumm_vagg</summary>
        public SwitchEntity TvrumVagg => new(_haContext, "switch.tvrum_vagg");
        ///<summary>TVRUMMET TV</summary>
        public SwitchEntity TvrummetTv => new(_haContext, "switch.tvrummet_tv");
        ///<summary>Ute Do Not Disturb</summary>
        public SwitchEntity UteDoNotDisturb => new(_haContext, "switch.ute_do_not_disturb");
        ///<summary>Vardagsrum Do Not Disturb</summary>
        public SwitchEntity VardagsrumDoNotDisturb => new(_haContext, "switch.vardagsrum_do_not_disturb");
        ///<summary>vardagsrum_pir_led_indication</summary>
        public SwitchEntity VardagsrumPirLedIndication => new(_haContext, "switch.vardagsrum_pir_led_indication");
        ///<summary>Zigbee2mqtt Main join</summary>
        public SwitchEntity Zigbee2mqttMainJoin => new(_haContext, "switch.zigbee2mqtt_main_join");
    }

    public class TimerEntities
    {
        private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
        public TimerEntities(NetDaemon.HassModel.Common.IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Time remaining</summary>
        public TimerEntity ZigbeePermitJoin => new(_haContext, "timer.zigbee_permit_join");
    }

    public class WeatherEntities
    {
        private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
        public WeatherEntities(NetDaemon.HassModel.Common.IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Hemma</summary>
        public WeatherEntity SmhiHemma => new(_haContext, "weather.smhi_hemma");
    }

    public class ZoneEntities
    {
        private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
        public ZoneEntities(NetDaemon.HassModel.Common.IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Gårn</summary>
        public ZoneEntity Garn => new(_haContext, "zone.garn");
        ///<summary>Home</summary>
        public ZoneEntity Home => new(_haContext, "zone.home");
        ///<summary>Sjukhuset</summary>
        public ZoneEntity Sjukhuset => new(_haContext, "zone.sjukhuset");
        ///<summary>SPV</summary>
        public ZoneEntity Spv => new(_haContext, "zone.spv");
        ///<summary>Svärmor</summary>
        public ZoneEntity Svarmor => new(_haContext, "zone.svarmor");
        ///<summary>Vårdinge</summary>
        public ZoneEntity Vardinge => new(_haContext, "zone.vardinge");
    }

    public record AutomationEntity : NetDaemon.HassModel.Entities.Entity<AutomationEntity, NetDaemon.HassModel.Entities.EntityState<AutomationAttributes>, AutomationAttributes>
    {
        public AutomationEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
        {
        }

        public AutomationEntity(NetDaemon.HassModel.Entities.Entity entity) : base(entity)
        {
        }
    }

    public record BinarySensorEntity : NetDaemon.HassModel.Entities.Entity<BinarySensorEntity, NetDaemon.HassModel.Entities.EntityState<BinarySensorAttributes>, BinarySensorAttributes>
    {
        public BinarySensorEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
        {
        }

        public BinarySensorEntity(NetDaemon.HassModel.Entities.Entity entity) : base(entity)
        {
        }
    }

    public record ButtonEntity : NetDaemon.HassModel.Entities.Entity<ButtonEntity, NetDaemon.HassModel.Entities.EntityState<ButtonAttributes>, ButtonAttributes>
    {
        public ButtonEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
        {
        }

        public ButtonEntity(NetDaemon.HassModel.Entities.Entity entity) : base(entity)
        {
        }
    }

    public record CalendarEntity : NetDaemon.HassModel.Entities.Entity<CalendarEntity, NetDaemon.HassModel.Entities.EntityState<CalendarAttributes>, CalendarAttributes>
    {
        public CalendarEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
        {
        }

        public CalendarEntity(NetDaemon.HassModel.Entities.Entity entity) : base(entity)
        {
        }
    }

    public record CameraEntity : NetDaemon.HassModel.Entities.Entity<CameraEntity, NetDaemon.HassModel.Entities.EntityState<CameraAttributes>, CameraAttributes>
    {
        public CameraEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
        {
        }

        public CameraEntity(NetDaemon.HassModel.Entities.Entity entity) : base(entity)
        {
        }
    }

    public record CoverEntity : NetDaemon.HassModel.Entities.Entity<CoverEntity, NetDaemon.HassModel.Entities.EntityState<CoverAttributes>, CoverAttributes>
    {
        public CoverEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
        {
        }

        public CoverEntity(NetDaemon.HassModel.Entities.Entity entity) : base(entity)
        {
        }
    }

    public record DeviceTrackerEntity : NetDaemon.HassModel.Entities.Entity<DeviceTrackerEntity, NetDaemon.HassModel.Entities.EntityState<DeviceTrackerAttributes>, DeviceTrackerAttributes>
    {
        public DeviceTrackerEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
        {
        }

        public DeviceTrackerEntity(NetDaemon.HassModel.Entities.Entity entity) : base(entity)
        {
        }
    }

    public record GroupEntity : NetDaemon.HassModel.Entities.Entity<GroupEntity, NetDaemon.HassModel.Entities.EntityState<GroupAttributes>, GroupAttributes>
    {
        public GroupEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
        {
        }

        public GroupEntity(NetDaemon.HassModel.Entities.Entity entity) : base(entity)
        {
        }
    }

    public record InputBooleanEntity : NetDaemon.HassModel.Entities.Entity<InputBooleanEntity, NetDaemon.HassModel.Entities.EntityState<InputBooleanAttributes>, InputBooleanAttributes>
    {
        public InputBooleanEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
        {
        }

        public InputBooleanEntity(NetDaemon.HassModel.Entities.Entity entity) : base(entity)
        {
        }
    }

    public record InputNumberEntity : NetDaemon.HassModel.Entities.NumericEntity<InputNumberEntity, NetDaemon.HassModel.Entities.NumericEntityState<InputNumberAttributes>, InputNumberAttributes>
    {
        public InputNumberEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
        {
        }

        public InputNumberEntity(NetDaemon.HassModel.Entities.Entity entity) : base(entity)
        {
        }
    }

    public record InputSelectEntity : NetDaemon.HassModel.Entities.Entity<InputSelectEntity, NetDaemon.HassModel.Entities.EntityState<InputSelectAttributes>, InputSelectAttributes>
    {
        public InputSelectEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
        {
        }

        public InputSelectEntity(NetDaemon.HassModel.Entities.Entity entity) : base(entity)
        {
        }
    }

    public record InputTextEntity : NetDaemon.HassModel.Entities.Entity<InputTextEntity, NetDaemon.HassModel.Entities.EntityState<InputTextAttributes>, InputTextAttributes>
    {
        public InputTextEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
        {
        }

        public InputTextEntity(NetDaemon.HassModel.Entities.Entity entity) : base(entity)
        {
        }
    }

    public record LightEntity : NetDaemon.HassModel.Entities.Entity<LightEntity, NetDaemon.HassModel.Entities.EntityState<LightAttributes>, LightAttributes>
    {
        public LightEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
        {
        }

        public LightEntity(NetDaemon.HassModel.Entities.Entity entity) : base(entity)
        {
        }
    }

    public record LockEntity : NetDaemon.HassModel.Entities.Entity<LockEntity, NetDaemon.HassModel.Entities.EntityState<LockAttributes>, LockAttributes>
    {
        public LockEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
        {
        }

        public LockEntity(NetDaemon.HassModel.Entities.Entity entity) : base(entity)
        {
        }
    }

    public record MediaPlayerEntity : NetDaemon.HassModel.Entities.Entity<MediaPlayerEntity, NetDaemon.HassModel.Entities.EntityState<MediaPlayerAttributes>, MediaPlayerAttributes>
    {
        public MediaPlayerEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
        {
        }

        public MediaPlayerEntity(NetDaemon.HassModel.Entities.Entity entity) : base(entity)
        {
        }
    }

    public record NumericNumberEntity : NetDaemon.HassModel.Entities.NumericEntity<NumericNumberEntity, NetDaemon.HassModel.Entities.NumericEntityState<NumericNumberAttributes>, NumericNumberAttributes>
    {
        public NumericNumberEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
        {
        }

        public NumericNumberEntity(NetDaemon.HassModel.Entities.Entity entity) : base(entity)
        {
        }
    }

    public record PersonEntity : NetDaemon.HassModel.Entities.Entity<PersonEntity, NetDaemon.HassModel.Entities.EntityState<PersonAttributes>, PersonAttributes>
    {
        public PersonEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
        {
        }

        public PersonEntity(NetDaemon.HassModel.Entities.Entity entity) : base(entity)
        {
        }
    }

    public record NumericProximityEntity : NetDaemon.HassModel.Entities.NumericEntity<NumericProximityEntity, NetDaemon.HassModel.Entities.NumericEntityState<NumericProximityAttributes>, NumericProximityAttributes>
    {
        public NumericProximityEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
        {
        }

        public NumericProximityEntity(NetDaemon.HassModel.Entities.Entity entity) : base(entity)
        {
        }
    }

    public record RemoteEntity : NetDaemon.HassModel.Entities.Entity<RemoteEntity, NetDaemon.HassModel.Entities.EntityState<RemoteAttributes>, RemoteAttributes>
    {
        public RemoteEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
        {
        }

        public RemoteEntity(NetDaemon.HassModel.Entities.Entity entity) : base(entity)
        {
        }
    }

    public record SceneEntity : NetDaemon.HassModel.Entities.Entity<SceneEntity, NetDaemon.HassModel.Entities.EntityState<SceneAttributes>, SceneAttributes>
    {
        public SceneEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
        {
        }

        public SceneEntity(NetDaemon.HassModel.Entities.Entity entity) : base(entity)
        {
        }
    }

    public record ScriptEntity : NetDaemon.HassModel.Entities.Entity<ScriptEntity, NetDaemon.HassModel.Entities.EntityState<ScriptAttributes>, ScriptAttributes>
    {
        public ScriptEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
        {
        }

        public ScriptEntity(NetDaemon.HassModel.Entities.Entity entity) : base(entity)
        {
        }
    }

    public record SelectEntity : NetDaemon.HassModel.Entities.Entity<SelectEntity, NetDaemon.HassModel.Entities.EntityState<SelectAttributes>, SelectAttributes>
    {
        public SelectEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
        {
        }

        public SelectEntity(NetDaemon.HassModel.Entities.Entity entity) : base(entity)
        {
        }
    }

    public record NumericSensorEntity : NetDaemon.HassModel.Entities.NumericEntity<NumericSensorEntity, NetDaemon.HassModel.Entities.NumericEntityState<NumericSensorAttributes>, NumericSensorAttributes>
    {
        public NumericSensorEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
        {
        }

        public NumericSensorEntity(NetDaemon.HassModel.Entities.Entity entity) : base(entity)
        {
        }
    }

    public record SensorEntity : NetDaemon.HassModel.Entities.Entity<SensorEntity, NetDaemon.HassModel.Entities.EntityState<SensorAttributes>, SensorAttributes>
    {
        public SensorEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
        {
        }

        public SensorEntity(NetDaemon.HassModel.Entities.Entity entity) : base(entity)
        {
        }
    }

    public record SunEntity : NetDaemon.HassModel.Entities.Entity<SunEntity, NetDaemon.HassModel.Entities.EntityState<SunAttributes>, SunAttributes>
    {
        public SunEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
        {
        }

        public SunEntity(NetDaemon.HassModel.Entities.Entity entity) : base(entity)
        {
        }
    }

    public record SwitchEntity : NetDaemon.HassModel.Entities.Entity<SwitchEntity, NetDaemon.HassModel.Entities.EntityState<SwitchAttributes>, SwitchAttributes>
    {
        public SwitchEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
        {
        }

        public SwitchEntity(NetDaemon.HassModel.Entities.Entity entity) : base(entity)
        {
        }
    }

    public record TimerEntity : NetDaemon.HassModel.Entities.Entity<TimerEntity, NetDaemon.HassModel.Entities.EntityState<TimerAttributes>, TimerAttributes>
    {
        public TimerEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
        {
        }

        public TimerEntity(NetDaemon.HassModel.Entities.Entity entity) : base(entity)
        {
        }
    }

    public record WeatherEntity : NetDaemon.HassModel.Entities.Entity<WeatherEntity, NetDaemon.HassModel.Entities.EntityState<WeatherAttributes>, WeatherAttributes>
    {
        public WeatherEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
        {
        }

        public WeatherEntity(NetDaemon.HassModel.Entities.Entity entity) : base(entity)
        {
        }
    }

    public record ZoneEntity : NetDaemon.HassModel.Entities.Entity<ZoneEntity, NetDaemon.HassModel.Entities.EntityState<ZoneAttributes>, ZoneAttributes>
    {
        public ZoneEntity(NetDaemon.HassModel.Common.IHaContext haContext, string entityId) : base(haContext, entityId)
        {
        }

        public ZoneEntity(NetDaemon.HassModel.Entities.Entity entity) : base(entity)
        {
        }
    }

    public record AutomationAttributes
    {
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("current")]
        public double? Current { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("friendly_name")]
        public string? FriendlyName { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public string? Id { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("last_triggered")]
        public string? LastTriggered { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("mode")]
        public string? Mode { get; init; }
    }

    public record BinarySensorAttributes
    {
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("assumed_state")]
        public bool? AssumedState { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("attribution")]
        public string? Attribution { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("battery")]
        public double? Battery { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("brightness")]
        public double? Brightness { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("color")]
        public object? Color { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("color_mode")]
        public string? ColorMode { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("color_temp")]
        public double? ColorTemp { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("contact")]
        public bool? Contact { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("device_class")]
        public string? DeviceClass { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("friendly_name")]
        public string? FriendlyName { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("icon")]
        public string? Icon { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("illuminance")]
        public double? Illuminance { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("illuminance_lux")]
        public double? IlluminanceLux { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("LastCarton")]
        public string? LastCarton { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("LastCleaning")]
        public string? LastCleaning { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("LastColoredGlass")]
        public string? LastColoredGlass { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("LastGlass")]
        public string? LastGlass { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("LastMetal")]
        public string? LastMetal { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("LastPapers")]
        public string? LastPapers { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("LastPlastic")]
        public string? LastPlastic { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("led_indication")]
        public object? LedIndication { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("linkquality")]
        public double? Linkquality { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("motion_sensitivity")]
        public object? MotionSensitivity { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("newest_version")]
        public string? NewestVersion { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("NextCarton")]
        public string? NextCarton { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("NextCleaning")]
        public string? NextCleaning { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("NextColoredGlass")]
        public string? NextColoredGlass { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("NextGlass")]
        public string? NextGlass { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("NextMetal")]
        public string? NextMetal { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("NextPapers")]
        public string? NextPapers { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("NextPlastic")]
        public string? NextPlastic { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("occupancy")]
        public bool? Occupancy { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("occupancy_timeout")]
        public object? OccupancyTimeout { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("position")]
        public double? Position { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("power_on_behavior")]
        public object? PowerOnBehavior { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("release_notes")]
        public string? ReleaseNotes { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("restored")]
        public bool? Restored { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("supported_features")]
        public double? SupportedFeatures { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("temperature")]
        public double? Temperature { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("update")]
        public object? Update { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("update_available")]
        public bool? UpdateAvailable { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("voltage")]
        public double? Voltage { get; init; }
    }

    public record ButtonAttributes
    {
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("friendly_name")]
        public string? FriendlyName { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("icon")]
        public string? Icon { get; init; }
    }

    public record CalendarAttributes
    {
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("all_day")]
        public bool? AllDay { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("description")]
        public string? Description { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("end_time")]
        public string? EndTime { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("friendly_name")]
        public string? FriendlyName { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("location")]
        public string? Location { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("message")]
        public string? Message { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("offset_reached")]
        public bool? OffsetReached { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("start_time")]
        public string? StartTime { get; init; }
    }

    public record CameraAttributes
    {
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("access_token")]
        public string? AccessToken { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("entity_picture")]
        public string? EntityPicture { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("friendly_name")]
        public string? FriendlyName { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("frontend_stream_type")]
        public string? FrontendStreamType { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("supported_features")]
        public double? SupportedFeatures { get; init; }
    }

    public record CoverAttributes
    {
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("battery")]
        public double? Battery { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("current_position")]
        public double? CurrentPosition { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("entity_id")]
        public object? EntityId { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("friendly_name")]
        public string? FriendlyName { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("linkquality")]
        public double? Linkquality { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("position")]
        public double? Position { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("supported_features")]
        public double? SupportedFeatures { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("update")]
        public object? Update { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("update_available")]
        public bool? UpdateAvailable { get; init; }
    }

    public record DeviceTrackerAttributes
    {
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("address")]
        public string? Address { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("altitude")]
        public double? Altitude { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("battery_charging")]
        public bool? BatteryCharging { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("battery_level")]
        public double? BatteryLevel { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("course")]
        public double? Course { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("distance")]
        public double? Distance { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("entity_picture")]
        public string? EntityPicture { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("friendly_name")]
        public string? FriendlyName { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("full_name")]
        public string? FullName { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("gps_accuracy")]
        public double? GpsAccuracy { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public string? Id { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("last_seen")]
        public string? LastSeen { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("latitude")]
        public double? Latitude { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("longitude")]
        public double? Longitude { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("nickname")]
        public string? Nickname { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("restored")]
        public bool? Restored { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("source_type")]
        public string? SourceType { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("speed")]
        public double? Speed { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("supported_features")]
        public double? SupportedFeatures { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("vertical_accuracy")]
        public double? VerticalAccuracy { get; init; }
    }

    public record GroupAttributes
    {
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("entity_id")]
        public object? EntityId { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("entity_picture")]
        public string? EntityPicture { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("friendly_name")]
        public string? FriendlyName { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("icon")]
        public string? Icon { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("order")]
        public double? Order { get; init; }
    }

    public record InputBooleanAttributes
    {
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("editable")]
        public bool? Editable { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("friendly_name")]
        public string? FriendlyName { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("icon")]
        public string? Icon { get; init; }
    }

    public record InputNumberAttributes
    {
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("editable")]
        public bool? Editable { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("friendly_name")]
        public string? FriendlyName { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("icon")]
        public string? Icon { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("initial")]
        public double? Initial { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("max")]
        public double? Max { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("min")]
        public double? Min { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("mode")]
        public string? Mode { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("step")]
        public double? Step { get; init; }
    }

    public record InputSelectAttributes
    {
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("editable")]
        public bool? Editable { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("friendly_name")]
        public string? FriendlyName { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("icon")]
        public string? Icon { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("options")]
        public object? Options { get; init; }
    }

    public record InputTextAttributes
    {
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("editable")]
        public bool? Editable { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("friendly_name")]
        public string? FriendlyName { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("max")]
        public double? Max { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("min")]
        public double? Min { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("mode")]
        public string? Mode { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("pattern")]
        public object? Pattern { get; init; }
    }

    public record LightAttributes
    {
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("brightness")]
        public double? Brightness { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("color")]
        public object? Color { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("color_mode")]
        public string? ColorMode { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("color_temp")]
        public double? ColorTemp { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("effect_list")]
        public object? EffectList { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("entity_id")]
        public object? EntityId { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("friendly_name")]
        public string? FriendlyName { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("hs_color")]
        public object? HsColor { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("icon")]
        public string? Icon { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("linkquality")]
        public double? Linkquality { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("max_mireds")]
        public double? MaxMireds { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("min_mireds")]
        public double? MinMireds { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("power_on_behavior")]
        public object? PowerOnBehavior { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("rgb_color")]
        public object? RgbColor { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("supported_color_modes")]
        public object? SupportedColorModes { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("supported_features")]
        public double? SupportedFeatures { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("update")]
        public object? Update { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("update_available")]
        public bool? UpdateAvailable { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("xy_color")]
        public object? XyColor { get; init; }
    }

    public record LockAttributes
    {
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("friendly_name")]
        public string? FriendlyName { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("supported_features")]
        public double? SupportedFeatures { get; init; }
    }

    public record MediaPlayerAttributes
    {
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("adb_response")]
        public object? AdbResponse { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("friendly_name")]
        public string? FriendlyName { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("hdmi_input")]
        public object? HdmiInput { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("icon")]
        public string? Icon { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("restored")]
        public bool? Restored { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("supported_features")]
        public double? SupportedFeatures { get; init; }
    }

    public record NumericNumberAttributes
    {
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("battery")]
        public double? Battery { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("friendly_name")]
        public string? FriendlyName { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("icon")]
        public string? Icon { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("illuminance")]
        public double? Illuminance { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("illuminance_lux")]
        public double? IlluminanceLux { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("led_indication")]
        public object? LedIndication { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("linkquality")]
        public double? Linkquality { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("max")]
        public double? Max { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("min")]
        public double? Min { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("mode")]
        public string? Mode { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("motion_sensitivity")]
        public object? MotionSensitivity { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("occupancy")]
        public bool? Occupancy { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("occupancy_timeout")]
        public object? OccupancyTimeout { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("step")]
        public double? Step { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("temperature")]
        public double? Temperature { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("unit_of_measurement")]
        public string? UnitOfMeasurement { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("update")]
        public object? Update { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("update_available")]
        public bool? UpdateAvailable { get; init; }
    }

    public record PersonAttributes
    {
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("editable")]
        public bool? Editable { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("friendly_name")]
        public string? FriendlyName { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("gps_accuracy")]
        public double? GpsAccuracy { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("id")]
        public string? Id { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("latitude")]
        public double? Latitude { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("longitude")]
        public double? Longitude { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("source")]
        public string? Source { get; init; }
    }

    public record NumericProximityAttributes
    {
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("dir_of_travel")]
        public string? DirOfTravel { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("friendly_name")]
        public string? FriendlyName { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("nearest")]
        public string? Nearest { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("unit_of_measurement")]
        public string? UnitOfMeasurement { get; init; }
    }

    public record RemoteAttributes
    {
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("activity_list")]
        public object? ActivityList { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("activity_starting")]
        public object? ActivityStarting { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("current_activity")]
        public string? CurrentActivity { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("devices_list")]
        public object? DevicesList { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("friendly_name")]
        public string? FriendlyName { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("last_activity")]
        public string? LastActivity { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("supported_features")]
        public double? SupportedFeatures { get; init; }
    }

    public record SceneAttributes
    {
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("entity_id")]
        public object? EntityId { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("friendly_name")]
        public string? FriendlyName { get; init; }
    }

    public record ScriptAttributes
    {
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("current")]
        public double? Current { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("friendly_name")]
        public string? FriendlyName { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("last_triggered")]
        public string? LastTriggered { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("mode")]
        public string? Mode { get; init; }
    }

    public record SelectAttributes
    {
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("friendly_name")]
        public string? FriendlyName { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("icon")]
        public string? Icon { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("options")]
        public object? Options { get; init; }
    }

    public record NumericSensorAttributes
    {
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("assumed_state")]
        public bool? AssumedState { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("Available")]
        public string? Available { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("Available (Important)")]
        public string? AvailableImportant { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("Available (Opportunistic)")]
        public string? AvailableOpportunistic { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("battery")]
        public double? Battery { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("brightness")]
        public double? Brightness { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("color")]
        public object? Color { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("color_mode")]
        public string? ColorMode { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("color_temp")]
        public double? ColorTemp { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("connected_not_paired_devices")]
        public string? ConnectedNotPairedDevices { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("connected_paired_devices")]
        public string? ConnectedPairedDevices { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("contact")]
        public bool? Contact { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("current")]
        public double? Current { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("device_class")]
        public string? DeviceClass { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("energy")]
        public double? Energy { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("event")]
        public string? Event { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("Free internal storage")]
        public string? Freeinternalstorage { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("friendly_name")]
        public string? FriendlyName { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("humidity")]
        public double? Humidity { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("icon")]
        public string? Icon { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("illuminance")]
        public double? Illuminance { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("illuminance_lux")]
        public double? IlluminanceLux { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("led_indication")]
        public object? LedIndication { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("linkquality")]
        public double? Linkquality { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("motion_sensitivity")]
        public object? MotionSensitivity { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("occupancy")]
        public bool? Occupancy { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("occupancy_timeout")]
        public object? OccupancyTimeout { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("paired_devices")]
        public string? PairedDevices { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("position")]
        public double? Position { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("power")]
        public double? Power { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("power_on_behavior")]
        public object? PowerOnBehavior { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("repositories")]
        public object? Repositories { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("restored")]
        public bool? Restored { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("state_class")]
        public string? StateClass { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("supported_features")]
        public double? SupportedFeatures { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("temperature")]
        public double? Temperature { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("Total")]
        public string? Total { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("Total internal storage")]
        public string? Totalinternalstorage { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("unit_of_measurement")]
        public string? UnitOfMeasurement { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("update")]
        public object? Update { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("update_available")]
        public bool? UpdateAvailable { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("voltage")]
        public double? Voltage { get; init; }
    }

    public record SensorAttributes
    {
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("Administrative Area")]
        public string? AdministrativeArea { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("Areas Of Interest")]
        public string? AreasOfInterest { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("assumed_state")]
        public bool? AssumedState { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("battery")]
        public double? Battery { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("brightness")]
        public double? Brightness { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("color")]
        public object? Color { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("color_mode")]
        public string? ColorMode { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("color_temp")]
        public double? ColorTemp { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("Confidence")]
        public string? Confidence { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("Country")]
        public string? Country { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("device_class")]
        public string? DeviceClass { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("event")]
        public string? Event { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("friendly_name")]
        public string? FriendlyName { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("icon")]
        public string? Icon { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("illuminance")]
        public double? Illuminance { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("illuminance_lux")]
        public double? IlluminanceLux { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("Inland Water")]
        public string? InlandWater { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("integration")]
        public string? Integration { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("is_hidden")]
        public bool? IsHidden { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("ISO Country Code")]
        public string? ISOCountryCode { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("last_snapshot")]
        public string? LastSnapshot { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("Latitude")]
        public double? Latitude { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("led_indication")]
        public object? LedIndication { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("linkquality")]
        public double? Linkquality { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("Locality")]
        public string? Locality { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("Local Time")]
        public string? LocalTime { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("Location")]
        public object? Location { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("Longitude")]
        public double? Longitude { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("Low Power Mode")]
        public bool? LowPowerMode { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("messages")]
        public object? Messages { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("motion_sensitivity")]
        public object? MotionSensitivity { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("Name")]
        public string? Name { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("number_of_loaded_apps")]
        public double? NumberOfLoadedApps { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("number_of_running_apps")]
        public double? NumberOfRunningApps { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("occupancy")]
        public bool? Occupancy { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("occupancy_timeout")]
        public object? OccupancyTimeout { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("Ocean")]
        public string? Ocean { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("position")]
        public double? Position { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("Postal Code")]
        public string? PostalCode { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("power_on_behavior")]
        public object? PowerOnBehavior { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("restored")]
        public bool? Restored { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("size_in_google_drive")]
        public string? SizeInGoogleDrive { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("size_in_home_assistant")]
        public string? SizeInHomeAssistant { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("snapshots")]
        public object? Snapshots { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("snapshots_in_google_drive")]
        public double? SnapshotsInGoogleDrive { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("snapshots_in_hassio")]
        public double? SnapshotsInHassio { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("snapshots_in_home_assistant")]
        public double? SnapshotsInHomeAssistant { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("state_class")]
        public string? StateClass { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("Sub Administrative Area")]
        public string? SubAdministrativeArea { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("Sub Locality")]
        public string? SubLocality { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("Sub Thoroughfare")]
        public string? SubThoroughfare { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("supported_features")]
        public double? SupportedFeatures { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("temperature")]
        public double? Temperature { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("Thoroughfare")]
        public string? Thoroughfare { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("Time in Milliseconds")]
        public double? TimeinMilliseconds { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("Time Zone")]
        public string? TimeZone { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("Types")]
        public object? Types { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("update")]
        public object? Update { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("update_available")]
        public bool? UpdateAvailable { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("version")]
        public string? Version { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("voltage")]
        public double? Voltage { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("Zones")]
        public object? Zones { get; init; }
    }

    public record SunAttributes
    {
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("azimuth")]
        public double? Azimuth { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("elevation")]
        public double? Elevation { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("friendly_name")]
        public string? FriendlyName { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("next_dawn")]
        public string? NextDawn { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("next_dusk")]
        public string? NextDusk { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("next_midnight")]
        public string? NextMidnight { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("next_noon")]
        public string? NextNoon { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("next_rising")]
        public string? NextRising { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("next_setting")]
        public string? NextSetting { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("rising")]
        public bool? Rising { get; init; }
    }

    public record SwitchAttributes
    {
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("assumed_state")]
        public bool? AssumedState { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("battery")]
        public double? Battery { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("current")]
        public double? Current { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("current_consumption")]
        public double? CurrentConsumption { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("energy")]
        public double? Energy { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("friendly_name")]
        public string? FriendlyName { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("icon")]
        public string? Icon { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("illuminance")]
        public double? Illuminance { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("illuminance_lux")]
        public double? IlluminanceLux { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("integration")]
        public string? Integration { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("led_indication")]
        public object? LedIndication { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("linkquality")]
        public double? Linkquality { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("motion_sensitivity")]
        public object? MotionSensitivity { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("occupancy")]
        public bool? Occupancy { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("occupancy_timeout")]
        public object? OccupancyTimeout { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("power")]
        public double? Power { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("power_on_behavior")]
        public object? PowerOnBehavior { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("restored")]
        public bool? Restored { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("runtime_info")]
        public object? RuntimeInfo { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("supported_features")]
        public double? SupportedFeatures { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("temperature")]
        public double? Temperature { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("update")]
        public object? Update { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("update_available")]
        public bool? UpdateAvailable { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("voltage")]
        public double? Voltage { get; init; }
    }

    public record TimerAttributes
    {
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("duration")]
        public string? Duration { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("editable")]
        public bool? Editable { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("friendly_name")]
        public string? FriendlyName { get; init; }
    }

    public record WeatherAttributes
    {
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("attribution")]
        public string? Attribution { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("cloudiness")]
        public double? Cloudiness { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("forecast")]
        public object? Forecast { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("friendly_name")]
        public string? FriendlyName { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("humidity")]
        public double? Humidity { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("pressure")]
        public double? Pressure { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("temperature")]
        public double? Temperature { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("thunder_probability")]
        public double? ThunderProbability { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("visibility")]
        public double? Visibility { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("wind_bearing")]
        public double? WindBearing { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("wind_gust_speed")]
        public double? WindGustSpeed { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("wind_speed")]
        public double? WindSpeed { get; init; }
    }

    public record ZoneAttributes
    {
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("editable")]
        public bool? Editable { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("friendly_name")]
        public string? FriendlyName { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("icon")]
        public string? Icon { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("latitude")]
        public double? Latitude { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("longitude")]
        public double? Longitude { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("passive")]
        public bool? Passive { get; init; }

        [System.Text.Json.Serialization.JsonPropertyNameAttribute("radius")]
        public double? Radius { get; init; }
    }

    public interface IServices
    {
        AmcrestServices Amcrest { get; }

        AndroidtvServices Androidtv { get; }

        AutomationServices Automation { get; }

        ButtonServices Button { get; }

        CameraServices Camera { get; }

        CastServices Cast { get; }

        ClimateServices Climate { get; }

        ConversationServices Conversation { get; }

        CoverServices Cover { get; }

        DeviceTrackerServices DeviceTracker { get; }

        ElgatoServices Elgato { get; }

        FfmpegServices Ffmpeg { get; }

        FrontendServices Frontend { get; }

        GenericServices Generic { get; }

        GoogleServices Google { get; }

        GoogleHomeServices GoogleHome { get; }

        GroupServices Group { get; }

        HarmonyServices Harmony { get; }

        HassioServices Hassio { get; }

        HomeassistantServices Homeassistant { get; }

        InputBooleanServices InputBoolean { get; }

        InputNumberServices InputNumber { get; }

        InputSelectServices InputSelect { get; }

        InputTextServices InputText { get; }

        LightServices Light { get; }

        LocaltuyaServices Localtuya { get; }

        LockServices Lock { get; }

        LogbookServices Logbook { get; }

        LoggerServices Logger { get; }

        LovelaceServices Lovelace { get; }

        MediaPlayerServices MediaPlayer { get; }

        MqttServices Mqtt { get; }

        NetdaemonServices Netdaemon { get; }

        NotifyServices Notify { get; }

        NumberServices Number { get; }

        PersistentNotificationServices PersistentNotification { get; }

        PersonServices Person { get; }

        PlexServices Plex { get; }

        RecorderServices Recorder { get; }

        RemoteServices Remote { get; }

        RfxtrxServices Rfxtrx { get; }

        SceneServices Scene { get; }

        ScriptServices Script { get; }

        SelectServices Select { get; }

        SwitchServices Switch { get; }

        SystemLogServices SystemLog { get; }

        TemplateServices Template { get; }

        TimerServices Timer { get; }

        TtsServices Tts { get; }

        ZoneServices Zone { get; }
    }

    public class Services : IServices
    {
        private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
        public Services(NetDaemon.HassModel.Common.IHaContext haContext)
        {
            _haContext = haContext;
        }

        public AmcrestServices Amcrest => new(_haContext);
        public AndroidtvServices Androidtv => new(_haContext);
        public AutomationServices Automation => new(_haContext);
        public ButtonServices Button => new(_haContext);
        public CameraServices Camera => new(_haContext);
        public CastServices Cast => new(_haContext);
        public ClimateServices Climate => new(_haContext);
        public ConversationServices Conversation => new(_haContext);
        public CoverServices Cover => new(_haContext);
        public DeviceTrackerServices DeviceTracker => new(_haContext);
        public ElgatoServices Elgato => new(_haContext);
        public FfmpegServices Ffmpeg => new(_haContext);
        public FrontendServices Frontend => new(_haContext);
        public GenericServices Generic => new(_haContext);
        public GoogleServices Google => new(_haContext);
        public GoogleHomeServices GoogleHome => new(_haContext);
        public GroupServices Group => new(_haContext);
        public HarmonyServices Harmony => new(_haContext);
        public HassioServices Hassio => new(_haContext);
        public HomeassistantServices Homeassistant => new(_haContext);
        public InputBooleanServices InputBoolean => new(_haContext);
        public InputNumberServices InputNumber => new(_haContext);
        public InputSelectServices InputSelect => new(_haContext);
        public InputTextServices InputText => new(_haContext);
        public LightServices Light => new(_haContext);
        public LocaltuyaServices Localtuya => new(_haContext);
        public LockServices Lock => new(_haContext);
        public LogbookServices Logbook => new(_haContext);
        public LoggerServices Logger => new(_haContext);
        public LovelaceServices Lovelace => new(_haContext);
        public MediaPlayerServices MediaPlayer => new(_haContext);
        public MqttServices Mqtt => new(_haContext);
        public NetdaemonServices Netdaemon => new(_haContext);
        public NotifyServices Notify => new(_haContext);
        public NumberServices Number => new(_haContext);
        public PersistentNotificationServices PersistentNotification => new(_haContext);
        public PersonServices Person => new(_haContext);
        public PlexServices Plex => new(_haContext);
        public RecorderServices Recorder => new(_haContext);
        public RemoteServices Remote => new(_haContext);
        public RfxtrxServices Rfxtrx => new(_haContext);
        public SceneServices Scene => new(_haContext);
        public ScriptServices Script => new(_haContext);
        public SelectServices Select => new(_haContext);
        public SwitchServices Switch => new(_haContext);
        public SystemLogServices SystemLog => new(_haContext);
        public TemplateServices Template => new(_haContext);
        public TimerServices Timer => new(_haContext);
        public TtsServices Tts => new(_haContext);
        public ZoneServices Zone => new(_haContext);
    }

    public class AmcrestServices
    {
        private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
        public AmcrestServices(NetDaemon.HassModel.Common.IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Disable audio stream.</summary>
        public void DisableAudio(AmcrestDisableAudioParameters data)
        {
            _haContext.CallService("amcrest", "disable_audio", null, data);
        }

        ///<summary>Disable audio stream.</summary>
        ///<param name="entityId">Name(s) of the cameras, or 'all' for all cameras. eg: camera.house_front</param>
        public void DisableAudio(string? @entityId = null)
        {
            _haContext.CallService("amcrest", "disable_audio", null, new AmcrestDisableAudioParameters { EntityId = @entityId });
        }

        ///<summary>Disable recording a clip to camera storage when motion is detected.</summary>
        public void DisableMotionRecording(AmcrestDisableMotionRecordingParameters data)
        {
            _haContext.CallService("amcrest", "disable_motion_recording", null, data);
        }

        ///<summary>Disable recording a clip to camera storage when motion is detected.</summary>
        ///<param name="entityId">Name(s) of the cameras, or 'all' for all cameras. eg: camera.house_front</param>
        public void DisableMotionRecording(string? @entityId = null)
        {
            _haContext.CallService("amcrest", "disable_motion_recording", null, new AmcrestDisableMotionRecordingParameters { EntityId = @entityId });
        }

        ///<summary>Disable continuous recording to camera storage.</summary>
        public void DisableRecording(AmcrestDisableRecordingParameters data)
        {
            _haContext.CallService("amcrest", "disable_recording", null, data);
        }

        ///<summary>Disable continuous recording to camera storage.</summary>
        ///<param name="entityId">Name(s) of the cameras, or 'all' for all cameras. eg: camera.house_front</param>
        public void DisableRecording(string? @entityId = null)
        {
            _haContext.CallService("amcrest", "disable_recording", null, new AmcrestDisableRecordingParameters { EntityId = @entityId });
        }

        ///<summary>Enable audio stream.</summary>
        public void EnableAudio(AmcrestEnableAudioParameters data)
        {
            _haContext.CallService("amcrest", "enable_audio", null, data);
        }

        ///<summary>Enable audio stream.</summary>
        ///<param name="entityId">Name(s) of the cameras, or 'all' for all cameras. eg: camera.house_front</param>
        public void EnableAudio(string? @entityId = null)
        {
            _haContext.CallService("amcrest", "enable_audio", null, new AmcrestEnableAudioParameters { EntityId = @entityId });
        }

        ///<summary>Enable recording a clip to camera storage when motion is detected.</summary>
        public void EnableMotionRecording(AmcrestEnableMotionRecordingParameters data)
        {
            _haContext.CallService("amcrest", "enable_motion_recording", null, data);
        }

        ///<summary>Enable recording a clip to camera storage when motion is detected.</summary>
        ///<param name="entityId">Name(s) of the cameras, or 'all' for all cameras. eg: camera.house_front</param>
        public void EnableMotionRecording(string? @entityId = null)
        {
            _haContext.CallService("amcrest", "enable_motion_recording", null, new AmcrestEnableMotionRecordingParameters { EntityId = @entityId });
        }

        ///<summary>Enable continuous recording to camera storage.</summary>
        public void EnableRecording(AmcrestEnableRecordingParameters data)
        {
            _haContext.CallService("amcrest", "enable_recording", null, data);
        }

        ///<summary>Enable continuous recording to camera storage.</summary>
        ///<param name="entityId">Name(s) of the cameras, or 'all' for all cameras. eg: camera.house_front</param>
        public void EnableRecording(string? @entityId = null)
        {
            _haContext.CallService("amcrest", "enable_recording", null, new AmcrestEnableRecordingParameters { EntityId = @entityId });
        }

        ///<summary>Move camera to PTZ preset.</summary>
        public void GotoPreset(AmcrestGotoPresetParameters data)
        {
            _haContext.CallService("amcrest", "goto_preset", null, data);
        }

        ///<summary>Move camera to PTZ preset.</summary>
        ///<param name="entityId">Name(s) of the cameras, or 'all' for all cameras.</param>
        ///<param name="preset">Preset number.</param>
        public void GotoPreset(long @preset, string? @entityId = null)
        {
            _haContext.CallService("amcrest", "goto_preset", null, new AmcrestGotoPresetParameters { EntityId = @entityId, Preset = @preset });
        }

        ///<summary>Move (Pan/Tilt) and/or Zoom a PTZ camera.</summary>
        public void PtzControl(AmcrestPtzControlParameters data)
        {
            _haContext.CallService("amcrest", "ptz_control", null, data);
        }

        ///<summary>Move (Pan/Tilt) and/or Zoom a PTZ camera.</summary>
        ///<param name="entityId">Name of the camera, or 'all' for all cameras. eg: camera.house_front</param>
        ///<param name="movement">Direction to move the camera.</param>
        ///<param name="travelTime">Travel time in fractional seconds: from 0 to 1.</param>
        public void PtzControl(string @movement, string? @entityId = null, double? @travelTime = null)
        {
            _haContext.CallService("amcrest", "ptz_control", null, new AmcrestPtzControlParameters { EntityId = @entityId, Movement = @movement, TravelTime = @travelTime });
        }

        ///<summary>Set camera color mode.</summary>
        public void SetColorBw(AmcrestSetColorBwParameters data)
        {
            _haContext.CallService("amcrest", "set_color_bw", null, data);
        }

        ///<summary>Set camera color mode.</summary>
        ///<param name="entityId">Name(s) of the cameras, or 'all' for all cameras. eg: camera.house_front</param>
        ///<param name="colorBw">Color mode.</param>
        public void SetColorBw(string? @entityId = null, string? @colorBw = null)
        {
            _haContext.CallService("amcrest", "set_color_bw", null, new AmcrestSetColorBwParameters { EntityId = @entityId, ColorBw = @colorBw });
        }

        ///<summary>Start camera's PTZ tour function.</summary>
        public void StartTour(AmcrestStartTourParameters data)
        {
            _haContext.CallService("amcrest", "start_tour", null, data);
        }

        ///<summary>Start camera's PTZ tour function.</summary>
        ///<param name="entityId">Name(s) of the cameras, or 'all' for all cameras. eg: camera.house_front</param>
        public void StartTour(string? @entityId = null)
        {
            _haContext.CallService("amcrest", "start_tour", null, new AmcrestStartTourParameters { EntityId = @entityId });
        }

        ///<summary>Stop camera's PTZ tour function.</summary>
        public void StopTour(AmcrestStopTourParameters data)
        {
            _haContext.CallService("amcrest", "stop_tour", null, data);
        }

        ///<summary>Stop camera's PTZ tour function.</summary>
        ///<param name="entityId">Name(s) of the cameras, or 'all' for all cameras. eg: camera.house_front</param>
        public void StopTour(string? @entityId = null)
        {
            _haContext.CallService("amcrest", "stop_tour", null, new AmcrestStopTourParameters { EntityId = @entityId });
        }
    }

    public record AmcrestDisableAudioParameters
    {
        ///<summary>Name(s) of the cameras, or 'all' for all cameras. eg: camera.house_front</summary>
        [System.Text.Json.Serialization.JsonPropertyName("entity_id")]
        public string? EntityId { get; init; }
    }

    public record AmcrestDisableMotionRecordingParameters
    {
        ///<summary>Name(s) of the cameras, or 'all' for all cameras. eg: camera.house_front</summary>
        [System.Text.Json.Serialization.JsonPropertyName("entity_id")]
        public string? EntityId { get; init; }
    }

    public record AmcrestDisableRecordingParameters
    {
        ///<summary>Name(s) of the cameras, or 'all' for all cameras. eg: camera.house_front</summary>
        [System.Text.Json.Serialization.JsonPropertyName("entity_id")]
        public string? EntityId { get; init; }
    }

    public record AmcrestEnableAudioParameters
    {
        ///<summary>Name(s) of the cameras, or 'all' for all cameras. eg: camera.house_front</summary>
        [System.Text.Json.Serialization.JsonPropertyName("entity_id")]
        public string? EntityId { get; init; }
    }

    public record AmcrestEnableMotionRecordingParameters
    {
        ///<summary>Name(s) of the cameras, or 'all' for all cameras. eg: camera.house_front</summary>
        [System.Text.Json.Serialization.JsonPropertyName("entity_id")]
        public string? EntityId { get; init; }
    }

    public record AmcrestEnableRecordingParameters
    {
        ///<summary>Name(s) of the cameras, or 'all' for all cameras. eg: camera.house_front</summary>
        [System.Text.Json.Serialization.JsonPropertyName("entity_id")]
        public string? EntityId { get; init; }
    }

    public record AmcrestGotoPresetParameters
    {
        ///<summary>Name(s) of the cameras, or 'all' for all cameras.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("entity_id")]
        public string? EntityId { get; init; }

        ///<summary>Preset number.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("preset")]
        public long? Preset { get; init; }
    }

    public record AmcrestPtzControlParameters
    {
        ///<summary>Name of the camera, or 'all' for all cameras. eg: camera.house_front</summary>
        [System.Text.Json.Serialization.JsonPropertyName("entity_id")]
        public string? EntityId { get; init; }

        ///<summary>Direction to move the camera.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("movement")]
        public string? Movement { get; init; }

        ///<summary>Travel time in fractional seconds: from 0 to 1.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("travel_time")]
        public double? TravelTime { get; init; }
    }

    public record AmcrestSetColorBwParameters
    {
        ///<summary>Name(s) of the cameras, or 'all' for all cameras. eg: camera.house_front</summary>
        [System.Text.Json.Serialization.JsonPropertyName("entity_id")]
        public string? EntityId { get; init; }

        ///<summary>Color mode.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("color_bw")]
        public string? ColorBw { get; init; }
    }

    public record AmcrestStartTourParameters
    {
        ///<summary>Name(s) of the cameras, or 'all' for all cameras. eg: camera.house_front</summary>
        [System.Text.Json.Serialization.JsonPropertyName("entity_id")]
        public string? EntityId { get; init; }
    }

    public record AmcrestStopTourParameters
    {
        ///<summary>Name(s) of the cameras, or 'all' for all cameras. eg: camera.house_front</summary>
        [System.Text.Json.Serialization.JsonPropertyName("entity_id")]
        public string? EntityId { get; init; }
    }

    public class AndroidtvServices
    {
        private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
        public AndroidtvServices(NetDaemon.HassModel.Common.IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Send an ADB command to an Android TV / Fire TV device.</summary>
        public void AdbCommand(AndroidtvAdbCommandParameters data)
        {
            _haContext.CallService("androidtv", "adb_command", null, data);
        }

        ///<summary>Send an ADB command to an Android TV / Fire TV device.</summary>
        ///<param name="entityId">Name(s) of Android TV / Fire TV entities.</param>
        ///<param name="command">Either a key command or an ADB shell command. eg: HOME</param>
        public void AdbCommand(string @entityId, string @command)
        {
            _haContext.CallService("androidtv", "adb_command", null, new AndroidtvAdbCommandParameters { EntityId = @entityId, Command = @command });
        }

        ///<summary>Download a file from your Android TV / Fire TV device to your Home Assistant instance.</summary>
        public void Download(AndroidtvDownloadParameters data)
        {
            _haContext.CallService("androidtv", "download", null, data);
        }

        ///<summary>Download a file from your Android TV / Fire TV device to your Home Assistant instance.</summary>
        ///<param name="entityId">Name of Android TV / Fire TV entity.</param>
        ///<param name="devicePath">The filepath on the Android TV / Fire TV device. eg: /storage/emulated/0/Download/example.txt</param>
        ///<param name="localPath">The filepath on your Home Assistant instance. eg: /config/www/example.txt</param>
        public void Download(string @entityId, string @devicePath, string @localPath)
        {
            _haContext.CallService("androidtv", "download", null, new AndroidtvDownloadParameters { EntityId = @entityId, DevicePath = @devicePath, LocalPath = @localPath });
        }

        ///<summary>Translate a key press on a remote into ADB 'sendevent' commands.  You must press one button on the remote within 8 seconds of calling this service.</summary>
        ///<param name="target">The target for this service call</param>
        public void LearnSendevent(NetDaemon.HassModel.Entities.ServiceTarget target)
        {
            _haContext.CallService("androidtv", "learn_sendevent", target);
        }

        ///<summary>Upload a file from your Home Assistant instance to an Android TV / Fire TV device.</summary>
        public void Upload(AndroidtvUploadParameters data)
        {
            _haContext.CallService("androidtv", "upload", null, data);
        }

        ///<summary>Upload a file from your Home Assistant instance to an Android TV / Fire TV device.</summary>
        ///<param name="entityId">Name(s) of Android TV / Fire TV entities.</param>
        ///<param name="devicePath">The filepath on the Android TV / Fire TV device. eg: /storage/emulated/0/Download/example.txt</param>
        ///<param name="localPath">The filepath on your Home Assistant instance. eg: /config/www/example.txt</param>
        public void Upload(string @entityId, string @devicePath, string @localPath)
        {
            _haContext.CallService("androidtv", "upload", null, new AndroidtvUploadParameters { EntityId = @entityId, DevicePath = @devicePath, LocalPath = @localPath });
        }
    }

    public record AndroidtvAdbCommandParameters
    {
        ///<summary>Name(s) of Android TV / Fire TV entities.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("entity_id")]
        public string? EntityId { get; init; }

        ///<summary>Either a key command or an ADB shell command. eg: HOME</summary>
        [System.Text.Json.Serialization.JsonPropertyName("command")]
        public string? Command { get; init; }
    }

    public record AndroidtvDownloadParameters
    {
        ///<summary>Name of Android TV / Fire TV entity.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("entity_id")]
        public string? EntityId { get; init; }

        ///<summary>The filepath on the Android TV / Fire TV device. eg: /storage/emulated/0/Download/example.txt</summary>
        [System.Text.Json.Serialization.JsonPropertyName("device_path")]
        public string? DevicePath { get; init; }

        ///<summary>The filepath on your Home Assistant instance. eg: /config/www/example.txt</summary>
        [System.Text.Json.Serialization.JsonPropertyName("local_path")]
        public string? LocalPath { get; init; }
    }

    public record AndroidtvUploadParameters
    {
        ///<summary>Name(s) of Android TV / Fire TV entities.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("entity_id")]
        public string? EntityId { get; init; }

        ///<summary>The filepath on the Android TV / Fire TV device. eg: /storage/emulated/0/Download/example.txt</summary>
        [System.Text.Json.Serialization.JsonPropertyName("device_path")]
        public string? DevicePath { get; init; }

        ///<summary>The filepath on your Home Assistant instance. eg: /config/www/example.txt</summary>
        [System.Text.Json.Serialization.JsonPropertyName("local_path")]
        public string? LocalPath { get; init; }
    }

    public class AutomationServices
    {
        private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
        public AutomationServices(NetDaemon.HassModel.Common.IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Reload the automation configuration.</summary>
        public void Reload()
        {
            _haContext.CallService("automation", "reload", null);
        }

        ///<summary>Toggle (enable / disable) an automation.</summary>
        ///<param name="target">The target for this service call</param>
        public void Toggle(NetDaemon.HassModel.Entities.ServiceTarget target)
        {
            _haContext.CallService("automation", "toggle", target);
        }

        ///<summary>Trigger the actions of an automation.</summary>
        ///<param name="target">The target for this service call</param>
        public void Trigger(NetDaemon.HassModel.Entities.ServiceTarget target, AutomationTriggerParameters data)
        {
            _haContext.CallService("automation", "trigger", target, data);
        }

        ///<summary>Trigger the actions of an automation.</summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="skipCondition">Whether or not the conditions will be skipped.</param>
        public void Trigger(NetDaemon.HassModel.Entities.ServiceTarget target, bool? @skipCondition = null)
        {
            _haContext.CallService("automation", "trigger", target, new AutomationTriggerParameters { SkipCondition = @skipCondition });
        }

        ///<summary>Disable an automation.</summary>
        ///<param name="target">The target for this service call</param>
        public void TurnOff(NetDaemon.HassModel.Entities.ServiceTarget target, AutomationTurnOffParameters data)
        {
            _haContext.CallService("automation", "turn_off", target, data);
        }

        ///<summary>Disable an automation.</summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="stopActions">Stop currently running actions.</param>
        public void TurnOff(NetDaemon.HassModel.Entities.ServiceTarget target, bool? @stopActions = null)
        {
            _haContext.CallService("automation", "turn_off", target, new AutomationTurnOffParameters { StopActions = @stopActions });
        }

        ///<summary>Enable an automation.</summary>
        ///<param name="target">The target for this service call</param>
        public void TurnOn(NetDaemon.HassModel.Entities.ServiceTarget target)
        {
            _haContext.CallService("automation", "turn_on", target);
        }
    }

    public record AutomationTriggerParameters
    {
        ///<summary>Whether or not the conditions will be skipped.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("skip_condition")]
        public bool? SkipCondition { get; init; }
    }

    public record AutomationTurnOffParameters
    {
        ///<summary>Stop currently running actions.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("stop_actions")]
        public bool? StopActions { get; init; }
    }

    public class ButtonServices
    {
        private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
        public ButtonServices(NetDaemon.HassModel.Common.IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Press the button entity.</summary>
        ///<param name="target">The target for this service call</param>
        public void Press(NetDaemon.HassModel.Entities.ServiceTarget target)
        {
            _haContext.CallService("button", "press", target);
        }
    }

    public class CameraServices
    {
        private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
        public CameraServices(NetDaemon.HassModel.Common.IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Disable the motion detection in a camera.</summary>
        ///<param name="target">The target for this service call</param>
        public void DisableMotionDetection(NetDaemon.HassModel.Entities.ServiceTarget target)
        {
            _haContext.CallService("camera", "disable_motion_detection", target);
        }

        ///<summary>Enable the motion detection in a camera.</summary>
        ///<param name="target">The target for this service call</param>
        public void EnableMotionDetection(NetDaemon.HassModel.Entities.ServiceTarget target)
        {
            _haContext.CallService("camera", "enable_motion_detection", target);
        }

        ///<summary>Play camera stream on supported media player.</summary>
        ///<param name="target">The target for this service call</param>
        public void PlayStream(NetDaemon.HassModel.Entities.ServiceTarget target, CameraPlayStreamParameters data)
        {
            _haContext.CallService("camera", "play_stream", target, data);
        }

        ///<summary>Play camera stream on supported media player.</summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="mediaPlayer">Name(s) of media player to stream to.</param>
        ///<param name="format">Stream format supported by media player.</param>
        public void PlayStream(NetDaemon.HassModel.Entities.ServiceTarget target, string @mediaPlayer, string? @format = null)
        {
            _haContext.CallService("camera", "play_stream", target, new CameraPlayStreamParameters { MediaPlayer = @mediaPlayer, Format = @format });
        }

        ///<summary>Record live camera feed.</summary>
        ///<param name="target">The target for this service call</param>
        public void Record(NetDaemon.HassModel.Entities.ServiceTarget target, CameraRecordParameters data)
        {
            _haContext.CallService("camera", "record", target, data);
        }

        ///<summary>Record live camera feed.</summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="filename">Template of a Filename. Variable is entity_id. Must be mp4. eg: /tmp/snapshot_{{ entity_id.name }}.mp4</param>
        ///<param name="duration">Target recording length.</param>
        ///<param name="lookback">Target lookback period to include in addition to duration. Only available if there is currently an active HLS stream.</param>
        public void Record(NetDaemon.HassModel.Entities.ServiceTarget target, string @filename, long? @duration = null, long? @lookback = null)
        {
            _haContext.CallService("camera", "record", target, new CameraRecordParameters { Filename = @filename, Duration = @duration, Lookback = @lookback });
        }

        ///<summary>Take a snapshot from a camera.</summary>
        ///<param name="target">The target for this service call</param>
        public void Snapshot(NetDaemon.HassModel.Entities.ServiceTarget target, CameraSnapshotParameters data)
        {
            _haContext.CallService("camera", "snapshot", target, data);
        }

        ///<summary>Take a snapshot from a camera.</summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="filename">Template of a Filename. Variable is entity_id. eg: /tmp/snapshot_{{ entity_id.name }}.jpg</param>
        public void Snapshot(NetDaemon.HassModel.Entities.ServiceTarget target, string @filename)
        {
            _haContext.CallService("camera", "snapshot", target, new CameraSnapshotParameters { Filename = @filename });
        }

        ///<summary>Turn off camera.</summary>
        ///<param name="target">The target for this service call</param>
        public void TurnOff(NetDaemon.HassModel.Entities.ServiceTarget target)
        {
            _haContext.CallService("camera", "turn_off", target);
        }

        ///<summary>Turn on camera.</summary>
        ///<param name="target">The target for this service call</param>
        public void TurnOn(NetDaemon.HassModel.Entities.ServiceTarget target)
        {
            _haContext.CallService("camera", "turn_on", target);
        }
    }

    public record CameraPlayStreamParameters
    {
        ///<summary>Name(s) of media player to stream to.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("media_player")]
        public string? MediaPlayer { get; init; }

        ///<summary>Stream format supported by media player.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("format")]
        public string? Format { get; init; }
    }

    public record CameraRecordParameters
    {
        ///<summary>Template of a Filename. Variable is entity_id. Must be mp4. eg: /tmp/snapshot_{{ entity_id.name }}.mp4</summary>
        [System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; init; }

        ///<summary>Target recording length.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("duration")]
        public long? Duration { get; init; }

        ///<summary>Target lookback period to include in addition to duration. Only available if there is currently an active HLS stream.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("lookback")]
        public long? Lookback { get; init; }
    }

    public record CameraSnapshotParameters
    {
        ///<summary>Template of a Filename. Variable is entity_id. eg: /tmp/snapshot_{{ entity_id.name }}.jpg</summary>
        [System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; init; }
    }

    public class CastServices
    {
        private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
        public CastServices(NetDaemon.HassModel.Common.IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Show a Lovelace view on a Chromecast.</summary>
        public void ShowLovelaceView(CastShowLovelaceViewParameters data)
        {
            _haContext.CallService("cast", "show_lovelace_view", null, data);
        }

        ///<summary>Show a Lovelace view on a Chromecast.</summary>
        ///<param name="entityId">Media Player entity to show the Lovelace view on.</param>
        ///<param name="dashboardPath">The URL path of the Lovelace dashboard to show. eg: lovelace-cast</param>
        ///<param name="viewPath">The path of the Lovelace view to show. eg: downstairs</param>
        public void ShowLovelaceView(string @entityId, string @dashboardPath, string? @viewPath = null)
        {
            _haContext.CallService("cast", "show_lovelace_view", null, new CastShowLovelaceViewParameters { EntityId = @entityId, DashboardPath = @dashboardPath, ViewPath = @viewPath });
        }
    }

    public record CastShowLovelaceViewParameters
    {
        ///<summary>Media Player entity to show the Lovelace view on.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("entity_id")]
        public string? EntityId { get; init; }

        ///<summary>The URL path of the Lovelace dashboard to show. eg: lovelace-cast</summary>
        [System.Text.Json.Serialization.JsonPropertyName("dashboard_path")]
        public string? DashboardPath { get; init; }

        ///<summary>The path of the Lovelace view to show. eg: downstairs</summary>
        [System.Text.Json.Serialization.JsonPropertyName("view_path")]
        public string? ViewPath { get; init; }
    }

    public class ClimateServices
    {
        private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
        public ClimateServices(NetDaemon.HassModel.Common.IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Turn auxiliary heater on/off for climate device.</summary>
        ///<param name="target">The target for this service call</param>
        public void SetAuxHeat(NetDaemon.HassModel.Entities.ServiceTarget target, ClimateSetAuxHeatParameters data)
        {
            _haContext.CallService("climate", "set_aux_heat", target, data);
        }

        ///<summary>Turn auxiliary heater on/off for climate device.</summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="auxHeat">New value of auxiliary heater.</param>
        public void SetAuxHeat(NetDaemon.HassModel.Entities.ServiceTarget target, bool @auxHeat)
        {
            _haContext.CallService("climate", "set_aux_heat", target, new ClimateSetAuxHeatParameters { AuxHeat = @auxHeat });
        }

        ///<summary>Set fan operation for climate device.</summary>
        ///<param name="target">The target for this service call</param>
        public void SetFanMode(NetDaemon.HassModel.Entities.ServiceTarget target, ClimateSetFanModeParameters data)
        {
            _haContext.CallService("climate", "set_fan_mode", target, data);
        }

        ///<summary>Set fan operation for climate device.</summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="fanMode">New value of fan mode. eg: low</param>
        public void SetFanMode(NetDaemon.HassModel.Entities.ServiceTarget target, string @fanMode)
        {
            _haContext.CallService("climate", "set_fan_mode", target, new ClimateSetFanModeParameters { FanMode = @fanMode });
        }

        ///<summary>Set target humidity of climate device.</summary>
        ///<param name="target">The target for this service call</param>
        public void SetHumidity(NetDaemon.HassModel.Entities.ServiceTarget target, ClimateSetHumidityParameters data)
        {
            _haContext.CallService("climate", "set_humidity", target, data);
        }

        ///<summary>Set target humidity of climate device.</summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="humidity">New target humidity for climate device.</param>
        public void SetHumidity(NetDaemon.HassModel.Entities.ServiceTarget target, long @humidity)
        {
            _haContext.CallService("climate", "set_humidity", target, new ClimateSetHumidityParameters { Humidity = @humidity });
        }

        ///<summary>Set HVAC operation mode for climate device.</summary>
        ///<param name="target">The target for this service call</param>
        public void SetHvacMode(NetDaemon.HassModel.Entities.ServiceTarget target, ClimateSetHvacModeParameters data)
        {
            _haContext.CallService("climate", "set_hvac_mode", target, data);
        }

        ///<summary>Set HVAC operation mode for climate device.</summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="hvacMode">New value of operation mode.</param>
        public void SetHvacMode(NetDaemon.HassModel.Entities.ServiceTarget target, string? @hvacMode = null)
        {
            _haContext.CallService("climate", "set_hvac_mode", target, new ClimateSetHvacModeParameters { HvacMode = @hvacMode });
        }

        ///<summary>Set preset mode for climate device.</summary>
        ///<param name="target">The target for this service call</param>
        public void SetPresetMode(NetDaemon.HassModel.Entities.ServiceTarget target, ClimateSetPresetModeParameters data)
        {
            _haContext.CallService("climate", "set_preset_mode", target, data);
        }

        ///<summary>Set preset mode for climate device.</summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="presetMode">New value of preset mode. eg: away</param>
        public void SetPresetMode(NetDaemon.HassModel.Entities.ServiceTarget target, string @presetMode)
        {
            _haContext.CallService("climate", "set_preset_mode", target, new ClimateSetPresetModeParameters { PresetMode = @presetMode });
        }

        ///<summary>Set swing operation for climate device.</summary>
        ///<param name="target">The target for this service call</param>
        public void SetSwingMode(NetDaemon.HassModel.Entities.ServiceTarget target, ClimateSetSwingModeParameters data)
        {
            _haContext.CallService("climate", "set_swing_mode", target, data);
        }

        ///<summary>Set swing operation for climate device.</summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="swingMode">New value of swing mode. eg: horizontal</param>
        public void SetSwingMode(NetDaemon.HassModel.Entities.ServiceTarget target, string @swingMode)
        {
            _haContext.CallService("climate", "set_swing_mode", target, new ClimateSetSwingModeParameters { SwingMode = @swingMode });
        }

        ///<summary>Set target temperature of climate device.</summary>
        ///<param name="target">The target for this service call</param>
        public void SetTemperature(NetDaemon.HassModel.Entities.ServiceTarget target, ClimateSetTemperatureParameters data)
        {
            _haContext.CallService("climate", "set_temperature", target, data);
        }

        ///<summary>Set target temperature of climate device.</summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="temperature">New target temperature for HVAC.</param>
        ///<param name="targetTempHigh">New target high temperature for HVAC.</param>
        ///<param name="targetTempLow">New target low temperature for HVAC.</param>
        ///<param name="hvacMode">HVAC operation mode to set temperature to.</param>
        public void SetTemperature(NetDaemon.HassModel.Entities.ServiceTarget target, double? @temperature = null, double? @targetTempHigh = null, double? @targetTempLow = null, string? @hvacMode = null)
        {
            _haContext.CallService("climate", "set_temperature", target, new ClimateSetTemperatureParameters { Temperature = @temperature, TargetTempHigh = @targetTempHigh, TargetTempLow = @targetTempLow, HvacMode = @hvacMode });
        }

        ///<summary>Turn climate device off.</summary>
        ///<param name="target">The target for this service call</param>
        public void TurnOff(NetDaemon.HassModel.Entities.ServiceTarget target)
        {
            _haContext.CallService("climate", "turn_off", target);
        }

        ///<summary>Turn climate device on.</summary>
        ///<param name="target">The target for this service call</param>
        public void TurnOn(NetDaemon.HassModel.Entities.ServiceTarget target)
        {
            _haContext.CallService("climate", "turn_on", target);
        }
    }

    public record ClimateSetAuxHeatParameters
    {
        ///<summary>New value of auxiliary heater.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("aux_heat")]
        public bool? AuxHeat { get; init; }
    }

    public record ClimateSetFanModeParameters
    {
        ///<summary>New value of fan mode. eg: low</summary>
        [System.Text.Json.Serialization.JsonPropertyName("fan_mode")]
        public string? FanMode { get; init; }
    }

    public record ClimateSetHumidityParameters
    {
        ///<summary>New target humidity for climate device.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("humidity")]
        public long? Humidity { get; init; }
    }

    public record ClimateSetHvacModeParameters
    {
        ///<summary>New value of operation mode.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("hvac_mode")]
        public string? HvacMode { get; init; }
    }

    public record ClimateSetPresetModeParameters
    {
        ///<summary>New value of preset mode. eg: away</summary>
        [System.Text.Json.Serialization.JsonPropertyName("preset_mode")]
        public string? PresetMode { get; init; }
    }

    public record ClimateSetSwingModeParameters
    {
        ///<summary>New value of swing mode. eg: horizontal</summary>
        [System.Text.Json.Serialization.JsonPropertyName("swing_mode")]
        public string? SwingMode { get; init; }
    }

    public record ClimateSetTemperatureParameters
    {
        ///<summary>New target temperature for HVAC.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; init; }

        ///<summary>New target high temperature for HVAC.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("target_temp_high")]
        public double? TargetTempHigh { get; init; }

        ///<summary>New target low temperature for HVAC.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("target_temp_low")]
        public double? TargetTempLow { get; init; }

        ///<summary>HVAC operation mode to set temperature to.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("hvac_mode")]
        public string? HvacMode { get; init; }
    }

    public class ConversationServices
    {
        private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
        public ConversationServices(NetDaemon.HassModel.Common.IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Launch a conversation from a transcribed text.</summary>
        public void Process(ConversationProcessParameters data)
        {
            _haContext.CallService("conversation", "process", null, data);
        }

        ///<summary>Launch a conversation from a transcribed text.</summary>
        ///<param name="text">Transcribed text eg: Turn all lights on</param>
        public void Process(string? @text = null)
        {
            _haContext.CallService("conversation", "process", null, new ConversationProcessParameters { Text = @text });
        }
    }

    public record ConversationProcessParameters
    {
        ///<summary>Transcribed text eg: Turn all lights on</summary>
        [System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; init; }
    }

    public class CoverServices
    {
        private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
        public CoverServices(NetDaemon.HassModel.Common.IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Close all or specified cover.</summary>
        ///<param name="target">The target for this service call</param>
        public void CloseCover(NetDaemon.HassModel.Entities.ServiceTarget target)
        {
            _haContext.CallService("cover", "close_cover", target);
        }

        ///<summary>Close all or specified cover tilt.</summary>
        ///<param name="target">The target for this service call</param>
        public void CloseCoverTilt(NetDaemon.HassModel.Entities.ServiceTarget target)
        {
            _haContext.CallService("cover", "close_cover_tilt", target);
        }

        ///<summary>Open all or specified cover.</summary>
        ///<param name="target">The target for this service call</param>
        public void OpenCover(NetDaemon.HassModel.Entities.ServiceTarget target)
        {
            _haContext.CallService("cover", "open_cover", target);
        }

        ///<summary>Open all or specified cover tilt.</summary>
        ///<param name="target">The target for this service call</param>
        public void OpenCoverTilt(NetDaemon.HassModel.Entities.ServiceTarget target)
        {
            _haContext.CallService("cover", "open_cover_tilt", target);
        }

        ///<summary>Move to specific position all or specified cover.</summary>
        ///<param name="target">The target for this service call</param>
        public void SetCoverPosition(NetDaemon.HassModel.Entities.ServiceTarget target, CoverSetCoverPositionParameters data)
        {
            _haContext.CallService("cover", "set_cover_position", target, data);
        }

        ///<summary>Move to specific position all or specified cover.</summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="position">Position of the cover</param>
        public void SetCoverPosition(NetDaemon.HassModel.Entities.ServiceTarget target, long @position)
        {
            _haContext.CallService("cover", "set_cover_position", target, new CoverSetCoverPositionParameters { Position = @position });
        }

        ///<summary>Move to specific position all or specified cover tilt.</summary>
        ///<param name="target">The target for this service call</param>
        public void SetCoverTiltPosition(NetDaemon.HassModel.Entities.ServiceTarget target, CoverSetCoverTiltPositionParameters data)
        {
            _haContext.CallService("cover", "set_cover_tilt_position", target, data);
        }

        ///<summary>Move to specific position all or specified cover tilt.</summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="tiltPosition">Tilt position of the cover.</param>
        public void SetCoverTiltPosition(NetDaemon.HassModel.Entities.ServiceTarget target, long @tiltPosition)
        {
            _haContext.CallService("cover", "set_cover_tilt_position", target, new CoverSetCoverTiltPositionParameters { TiltPosition = @tiltPosition });
        }

        ///<summary>Stop all or specified cover.</summary>
        ///<param name="target">The target for this service call</param>
        public void StopCover(NetDaemon.HassModel.Entities.ServiceTarget target)
        {
            _haContext.CallService("cover", "stop_cover", target);
        }

        ///<summary>Stop all or specified cover.</summary>
        ///<param name="target">The target for this service call</param>
        public void StopCoverTilt(NetDaemon.HassModel.Entities.ServiceTarget target)
        {
            _haContext.CallService("cover", "stop_cover_tilt", target);
        }

        ///<summary>Toggle a cover open/closed.</summary>
        ///<param name="target">The target for this service call</param>
        public void Toggle(NetDaemon.HassModel.Entities.ServiceTarget target)
        {
            _haContext.CallService("cover", "toggle", target);
        }

        ///<summary>Toggle a cover tilt open/closed.</summary>
        ///<param name="target">The target for this service call</param>
        public void ToggleCoverTilt(NetDaemon.HassModel.Entities.ServiceTarget target)
        {
            _haContext.CallService("cover", "toggle_cover_tilt", target);
        }
    }

    public record CoverSetCoverPositionParameters
    {
        ///<summary>Position of the cover</summary>
        [System.Text.Json.Serialization.JsonPropertyName("position")]
        public long? Position { get; init; }
    }

    public record CoverSetCoverTiltPositionParameters
    {
        ///<summary>Tilt position of the cover.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("tilt_position")]
        public long? TiltPosition { get; init; }
    }

    public class DeviceTrackerServices
    {
        private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
        public DeviceTrackerServices(NetDaemon.HassModel.Common.IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Control tracked device.</summary>
        public void See(DeviceTrackerSeeParameters data)
        {
            _haContext.CallService("device_tracker", "see", null, data);
        }

        ///<summary>Control tracked device.</summary>
        ///<param name="mac">MAC address of device eg: FF:FF:FF:FF:FF:FF</param>
        ///<param name="devId">Id of device (find id in known_devices.yaml). eg: phonedave</param>
        ///<param name="hostName">Hostname of device eg: Dave</param>
        ///<param name="locationName">Name of location where device is located (not_home is away). eg: home</param>
        ///<param name="gps">GPS coordinates where device is located (latitude, longitude). eg: [51.509802, -0.086692]</param>
        ///<param name="gpsAccuracy">Accuracy of GPS coordinates.</param>
        ///<param name="battery">Battery level of device.</param>
        public void See(string? @mac = null, string? @devId = null, string? @hostName = null, string? @locationName = null, object? @gps = null, long? @gpsAccuracy = null, long? @battery = null)
        {
            _haContext.CallService("device_tracker", "see", null, new DeviceTrackerSeeParameters { Mac = @mac, DevId = @devId, HostName = @hostName, LocationName = @locationName, Gps = @gps, GpsAccuracy = @gpsAccuracy, Battery = @battery });
        }
    }

    public record DeviceTrackerSeeParameters
    {
        ///<summary>MAC address of device eg: FF:FF:FF:FF:FF:FF</summary>
        [System.Text.Json.Serialization.JsonPropertyName("mac")]
        public string? Mac { get; init; }

        ///<summary>Id of device (find id in known_devices.yaml). eg: phonedave</summary>
        [System.Text.Json.Serialization.JsonPropertyName("dev_id")]
        public string? DevId { get; init; }

        ///<summary>Hostname of device eg: Dave</summary>
        [System.Text.Json.Serialization.JsonPropertyName("host_name")]
        public string? HostName { get; init; }

        ///<summary>Name of location where device is located (not_home is away). eg: home</summary>
        [System.Text.Json.Serialization.JsonPropertyName("location_name")]
        public string? LocationName { get; init; }

        ///<summary>GPS coordinates where device is located (latitude, longitude). eg: [51.509802, -0.086692]</summary>
        [System.Text.Json.Serialization.JsonPropertyName("gps")]
        public object? Gps { get; init; }

        ///<summary>Accuracy of GPS coordinates.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("gps_accuracy")]
        public long? GpsAccuracy { get; init; }

        ///<summary>Battery level of device.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("battery")]
        public long? Battery { get; init; }
    }

    public class ElgatoServices
    {
        private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
        public ElgatoServices(NetDaemon.HassModel.Common.IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Identify an Elgato Light. Blinks the light, which can be useful for, e.g., a visual notification.</summary>
        ///<param name="target">The target for this service call</param>
        public void Identify(NetDaemon.HassModel.Entities.ServiceTarget target)
        {
            _haContext.CallService("elgato", "identify", target);
        }
    }

    public class FfmpegServices
    {
        private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
        public FfmpegServices(NetDaemon.HassModel.Common.IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Send a restart command to a ffmpeg based sensor.</summary>
        public void Restart(FfmpegRestartParameters data)
        {
            _haContext.CallService("ffmpeg", "restart", null, data);
        }

        ///<summary>Send a restart command to a ffmpeg based sensor.</summary>
        ///<param name="entityId">Name of entity that will restart. Platform dependent.</param>
        public void Restart(string? @entityId = null)
        {
            _haContext.CallService("ffmpeg", "restart", null, new FfmpegRestartParameters { EntityId = @entityId });
        }

        ///<summary>Send a start command to a ffmpeg based sensor.</summary>
        public void Start(FfmpegStartParameters data)
        {
            _haContext.CallService("ffmpeg", "start", null, data);
        }

        ///<summary>Send a start command to a ffmpeg based sensor.</summary>
        ///<param name="entityId">Name of entity that will start. Platform dependent.</param>
        public void Start(string? @entityId = null)
        {
            _haContext.CallService("ffmpeg", "start", null, new FfmpegStartParameters { EntityId = @entityId });
        }

        ///<summary>Send a stop command to a ffmpeg based sensor.</summary>
        public void Stop(FfmpegStopParameters data)
        {
            _haContext.CallService("ffmpeg", "stop", null, data);
        }

        ///<summary>Send a stop command to a ffmpeg based sensor.</summary>
        ///<param name="entityId">Name of entity that will stop. Platform dependent.</param>
        public void Stop(string? @entityId = null)
        {
            _haContext.CallService("ffmpeg", "stop", null, new FfmpegStopParameters { EntityId = @entityId });
        }
    }

    public record FfmpegRestartParameters
    {
        ///<summary>Name of entity that will restart. Platform dependent.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("entity_id")]
        public string? EntityId { get; init; }
    }

    public record FfmpegStartParameters
    {
        ///<summary>Name of entity that will start. Platform dependent.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("entity_id")]
        public string? EntityId { get; init; }
    }

    public record FfmpegStopParameters
    {
        ///<summary>Name of entity that will stop. Platform dependent.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("entity_id")]
        public string? EntityId { get; init; }
    }

    public class FrontendServices
    {
        private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
        public FrontendServices(NetDaemon.HassModel.Common.IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Reload themes from YAML configuration.</summary>
        public void ReloadThemes()
        {
            _haContext.CallService("frontend", "reload_themes", null);
        }

        ///<summary>Set a theme unless the client selected per-device theme.</summary>
        public void SetTheme(FrontendSetThemeParameters data)
        {
            _haContext.CallService("frontend", "set_theme", null, data);
        }

        ///<summary>Set a theme unless the client selected per-device theme.</summary>
        ///<param name="name">Name of a predefined theme, 'default' or 'none'. eg: default</param>
        ///<param name="mode">The mode the theme is for.</param>
        public void SetTheme(string @name, string? @mode = null)
        {
            _haContext.CallService("frontend", "set_theme", null, new FrontendSetThemeParameters { Name = @name, Mode = @mode });
        }
    }

    public record FrontendSetThemeParameters
    {
        ///<summary>Name of a predefined theme, 'default' or 'none'. eg: default</summary>
        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; init; }

        ///<summary>The mode the theme is for.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("mode")]
        public string? Mode { get; init; }
    }

    public class GenericServices
    {
        private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
        public GenericServices(NetDaemon.HassModel.Common.IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Reload all generic entities.</summary>
        public void Reload()
        {
            _haContext.CallService("generic", "reload", null);
        }
    }

    public class GoogleServices
    {
        private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
        public GoogleServices(NetDaemon.HassModel.Common.IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Add a new calendar event.</summary>
        public void AddEvent(GoogleAddEventParameters data)
        {
            _haContext.CallService("google", "add_event", null, data);
        }

        ///<summary>Add a new calendar event.</summary>
        ///<param name="calendarId">The id of the calendar you want. eg: Your email</param>
        ///<param name="summary">Acts as the title of the event. eg: Bowling</param>
        ///<param name="description">The description of the event. Optional. eg: Birthday bowling</param>
        ///<param name="startDateTime">The date and time the event should start. eg: 2019-03-22 20:00:00</param>
        ///<param name="endDateTime">The date and time the event should end. eg: 2019-03-22 22:00:00</param>
        ///<param name="startDate">The date the whole day event should start. eg: 2019-03-10</param>
        ///<param name="endDate">The date the whole day event should end. eg: 2019-03-11</param>
        ///<param name="in">Days or weeks that you want to create the event in. eg: "days": 2 or "weeks": 2</param>
        public void AddEvent(string @calendarId, string @summary, string? @description = null, string? @startDateTime = null, string? @endDateTime = null, string? @startDate = null, string? @endDate = null, object? @in = null)
        {
            _haContext.CallService("google", "add_event", null, new GoogleAddEventParameters { CalendarId = @calendarId, Summary = @summary, Description = @description, StartDateTime = @startDateTime, EndDateTime = @endDateTime, StartDate = @startDate, EndDate = @endDate, In = @in });
        }

        ///<summary>Add calendar if it has not been already discovered.</summary>
        public void FoundCalendar()
        {
            _haContext.CallService("google", "found_calendar", null);
        }

        ///<summary>Scan for new calendars.</summary>
        public void ScanForCalendars()
        {
            _haContext.CallService("google", "scan_for_calendars", null);
        }
    }

    public record GoogleAddEventParameters
    {
        ///<summary>The id of the calendar you want. eg: Your email</summary>
        [System.Text.Json.Serialization.JsonPropertyName("calendar_id")]
        public string? CalendarId { get; init; }

        ///<summary>Acts as the title of the event. eg: Bowling</summary>
        [System.Text.Json.Serialization.JsonPropertyName("summary")]
        public string? Summary { get; init; }

        ///<summary>The description of the event. Optional. eg: Birthday bowling</summary>
        [System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; init; }

        ///<summary>The date and time the event should start. eg: 2019-03-22 20:00:00</summary>
        [System.Text.Json.Serialization.JsonPropertyName("start_date_time")]
        public string? StartDateTime { get; init; }

        ///<summary>The date and time the event should end. eg: 2019-03-22 22:00:00</summary>
        [System.Text.Json.Serialization.JsonPropertyName("end_date_time")]
        public string? EndDateTime { get; init; }

        ///<summary>The date the whole day event should start. eg: 2019-03-10</summary>
        [System.Text.Json.Serialization.JsonPropertyName("start_date")]
        public string? StartDate { get; init; }

        ///<summary>The date the whole day event should end. eg: 2019-03-11</summary>
        [System.Text.Json.Serialization.JsonPropertyName("end_date")]
        public string? EndDate { get; init; }

        ///<summary>Days or weeks that you want to create the event in. eg: "days": 2 or "weeks": 2</summary>
        [System.Text.Json.Serialization.JsonPropertyName("in")]
        public object? In { get; init; }
    }

    public class GoogleHomeServices
    {
        private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
        public GoogleHomeServices(NetDaemon.HassModel.Common.IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Delete an alarm from a Google Home device.</summary>
        public void DeleteAlarm(GoogleHomeDeleteAlarmParameters data)
        {
            _haContext.CallService("google_home", "delete_alarm", null, data);
        }

        ///<summary>Delete an alarm from a Google Home device.</summary>
        ///<param name="entityId">Represents a Google Home device (sensor.xxxx_alarms). eg: sensor.kitchen_alarms</param>
        ///<param name="alarmId">ID of an alarm (alarm/xxx). eg: alarm/6ed06a56-8a58-c6e3-a7d4-03f92c9d8a51</param>
        public void DeleteAlarm(string @entityId, string @alarmId)
        {
            _haContext.CallService("google_home", "delete_alarm", null, new GoogleHomeDeleteAlarmParameters { EntityId = @entityId, AlarmId = @alarmId });
        }

        ///<summary>Delete a timer from a Google Home device.</summary>
        public void DeleteTimer(GoogleHomeDeleteTimerParameters data)
        {
            _haContext.CallService("google_home", "delete_timer", null, data);
        }

        ///<summary>Delete a timer from a Google Home device.</summary>
        ///<param name="entityId">Represents a Google Home device (sensor.xxxx_timers). eg: sensor.kitchen_timers</param>
        ///<param name="timerId">ID of a timer (timer/xxx). eg: timer/6ed06a56-8a58-c6e3-a7d4-03f92c9d8a51</param>
        public void DeleteTimer(string @entityId, string @timerId)
        {
            _haContext.CallService("google_home", "delete_timer", null, new GoogleHomeDeleteTimerParameters { EntityId = @entityId, TimerId = @timerId });
        }

        ///<summary>Reboot a Google Home device.</summary>
        public void RebootDevice(GoogleHomeRebootDeviceParameters data)
        {
            _haContext.CallService("google_home", "reboot_device", null, data);
        }

        ///<summary>Reboot a Google Home device.</summary>
        ///<param name="entityId">Represents a Google Home device (sensor.xxxx_device). eg: sensor.kitchen_device</param>
        public void RebootDevice(string @entityId)
        {
            _haContext.CallService("google_home", "reboot_device", null, new GoogleHomeRebootDeviceParameters { EntityId = @entityId });
        }
    }

    public record GoogleHomeDeleteAlarmParameters
    {
        ///<summary>Represents a Google Home device (sensor.xxxx_alarms). eg: sensor.kitchen_alarms</summary>
        [System.Text.Json.Serialization.JsonPropertyName("entity_id")]
        public string? EntityId { get; init; }

        ///<summary>ID of an alarm (alarm/xxx). eg: alarm/6ed06a56-8a58-c6e3-a7d4-03f92c9d8a51</summary>
        [System.Text.Json.Serialization.JsonPropertyName("alarm_id")]
        public string? AlarmId { get; init; }
    }

    public record GoogleHomeDeleteTimerParameters
    {
        ///<summary>Represents a Google Home device (sensor.xxxx_timers). eg: sensor.kitchen_timers</summary>
        [System.Text.Json.Serialization.JsonPropertyName("entity_id")]
        public string? EntityId { get; init; }

        ///<summary>ID of a timer (timer/xxx). eg: timer/6ed06a56-8a58-c6e3-a7d4-03f92c9d8a51</summary>
        [System.Text.Json.Serialization.JsonPropertyName("timer_id")]
        public string? TimerId { get; init; }
    }

    public record GoogleHomeRebootDeviceParameters
    {
        ///<summary>Represents a Google Home device (sensor.xxxx_device). eg: sensor.kitchen_device</summary>
        [System.Text.Json.Serialization.JsonPropertyName("entity_id")]
        public string? EntityId { get; init; }
    }

    public class GroupServices
    {
        private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
        public GroupServices(NetDaemon.HassModel.Common.IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Reload group configuration, entities, and notify services.</summary>
        public void Reload()
        {
            _haContext.CallService("group", "reload", null);
        }

        ///<summary>Remove a user group.</summary>
        public void Remove(GroupRemoveParameters data)
        {
            _haContext.CallService("group", "remove", null, data);
        }

        ///<summary>Remove a user group.</summary>
        ///<param name="objectId">Group id and part of entity id. eg: test_group</param>
        public void Remove(object @objectId)
        {
            _haContext.CallService("group", "remove", null, new GroupRemoveParameters { ObjectId = @objectId });
        }

        ///<summary>Create/Update a user group.</summary>
        public void Set(GroupSetParameters data)
        {
            _haContext.CallService("group", "set", null, data);
        }

        ///<summary>Create/Update a user group.</summary>
        ///<param name="objectId">Group id and part of entity id. eg: test_group</param>
        ///<param name="name">Name of group eg: My test group</param>
        ///<param name="icon">Name of icon for the group. eg: mdi:camera</param>
        ///<param name="entities">List of all members in the group. Not compatible with 'delta'. eg: domain.entity_id1, domain.entity_id2</param>
        ///<param name="addEntities">List of members that will change on group listening. eg: domain.entity_id1, domain.entity_id2</param>
        ///<param name="all">Enable this option if the group should only turn on when all entities are on.</param>
        public void Set(string @objectId, string? @name = null, string? @icon = null, object? @entities = null, object? @addEntities = null, bool? @all = null)
        {
            _haContext.CallService("group", "set", null, new GroupSetParameters { ObjectId = @objectId, Name = @name, Icon = @icon, Entities = @entities, AddEntities = @addEntities, All = @all });
        }
    }

    public record GroupRemoveParameters
    {
        ///<summary>Group id and part of entity id. eg: test_group</summary>
        [System.Text.Json.Serialization.JsonPropertyName("object_id")]
        public object? ObjectId { get; init; }
    }

    public record GroupSetParameters
    {
        ///<summary>Group id and part of entity id. eg: test_group</summary>
        [System.Text.Json.Serialization.JsonPropertyName("object_id")]
        public string? ObjectId { get; init; }

        ///<summary>Name of group eg: My test group</summary>
        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; init; }

        ///<summary>Name of icon for the group. eg: mdi:camera</summary>
        [System.Text.Json.Serialization.JsonPropertyName("icon")]
        public string? Icon { get; init; }

        ///<summary>List of all members in the group. Not compatible with 'delta'. eg: domain.entity_id1, domain.entity_id2</summary>
        [System.Text.Json.Serialization.JsonPropertyName("entities")]
        public object? Entities { get; init; }

        ///<summary>List of members that will change on group listening. eg: domain.entity_id1, domain.entity_id2</summary>
        [System.Text.Json.Serialization.JsonPropertyName("add_entities")]
        public object? AddEntities { get; init; }

        ///<summary>Enable this option if the group should only turn on when all entities are on.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("all")]
        public bool? All { get; init; }
    }

    public class HarmonyServices
    {
        private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
        public HarmonyServices(NetDaemon.HassModel.Common.IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Sends change channel command to the Harmony HUB</summary>
        ///<param name="target">The target for this service call</param>
        public void ChangeChannel(NetDaemon.HassModel.Entities.ServiceTarget target, HarmonyChangeChannelParameters data)
        {
            _haContext.CallService("harmony", "change_channel", target, data);
        }

        ///<summary>Sends change channel command to the Harmony HUB</summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="channel">Channel number to change to</param>
        public void ChangeChannel(NetDaemon.HassModel.Entities.ServiceTarget target, long @channel)
        {
            _haContext.CallService("harmony", "change_channel", target, new HarmonyChangeChannelParameters { Channel = @channel });
        }

        ///<summary>Syncs the remote's configuration.</summary>
        ///<param name="target">The target for this service call</param>
        public void Sync(NetDaemon.HassModel.Entities.ServiceTarget target)
        {
            _haContext.CallService("harmony", "sync", target);
        }
    }

    public record HarmonyChangeChannelParameters
    {
        ///<summary>Channel number to change to</summary>
        [System.Text.Json.Serialization.JsonPropertyName("channel")]
        public long? Channel { get; init; }
    }

    public class HassioServices
    {
        private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
        public HassioServices(NetDaemon.HassModel.Common.IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Restart add-on.</summary>
        public void AddonRestart(HassioAddonRestartParameters data)
        {
            _haContext.CallService("hassio", "addon_restart", null, data);
        }

        ///<summary>Restart add-on.</summary>
        ///<param name="addon">The add-on slug. eg: core_ssh</param>
        public void AddonRestart(string @addon)
        {
            _haContext.CallService("hassio", "addon_restart", null, new HassioAddonRestartParameters { Addon = @addon });
        }

        ///<summary>Start add-on.</summary>
        public void AddonStart(HassioAddonStartParameters data)
        {
            _haContext.CallService("hassio", "addon_start", null, data);
        }

        ///<summary>Start add-on.</summary>
        ///<param name="addon">The add-on slug. eg: core_ssh</param>
        public void AddonStart(string @addon)
        {
            _haContext.CallService("hassio", "addon_start", null, new HassioAddonStartParameters { Addon = @addon });
        }

        ///<summary>Write data to add-on stdin.</summary>
        public void AddonStdin(HassioAddonStdinParameters data)
        {
            _haContext.CallService("hassio", "addon_stdin", null, data);
        }

        ///<summary>Write data to add-on stdin.</summary>
        ///<param name="addon">The add-on slug. eg: core_ssh</param>
        public void AddonStdin(string @addon)
        {
            _haContext.CallService("hassio", "addon_stdin", null, new HassioAddonStdinParameters { Addon = @addon });
        }

        ///<summary>Stop add-on.</summary>
        public void AddonStop(HassioAddonStopParameters data)
        {
            _haContext.CallService("hassio", "addon_stop", null, data);
        }

        ///<summary>Stop add-on.</summary>
        ///<param name="addon">The add-on slug. eg: core_ssh</param>
        public void AddonStop(string @addon)
        {
            _haContext.CallService("hassio", "addon_stop", null, new HassioAddonStopParameters { Addon = @addon });
        }

        ///<summary>Update add-on. This service should be used with caution since add-on updates can contain breaking changes. It is highly recommended that you review release notes/change logs before updating an add-on.</summary>
        public void AddonUpdate(HassioAddonUpdateParameters data)
        {
            _haContext.CallService("hassio", "addon_update", null, data);
        }

        ///<summary>Update add-on. This service should be used with caution since add-on updates can contain breaking changes. It is highly recommended that you review release notes/change logs before updating an add-on.</summary>
        ///<param name="addon">The add-on slug. eg: core_ssh</param>
        public void AddonUpdate(string @addon)
        {
            _haContext.CallService("hassio", "addon_update", null, new HassioAddonUpdateParameters { Addon = @addon });
        }

        ///<summary>Create a full backup.</summary>
        public void BackupFull(HassioBackupFullParameters data)
        {
            _haContext.CallService("hassio", "backup_full", null, data);
        }

        ///<summary>Create a full backup.</summary>
        ///<param name="name">Optional (default = current date and time). eg: Backup 1</param>
        ///<param name="password">Optional password. eg: password</param>
        public void BackupFull(string? @name = null, string? @password = null)
        {
            _haContext.CallService("hassio", "backup_full", null, new HassioBackupFullParameters { Name = @name, Password = @password });
        }

        ///<summary>Create a partial backup.</summary>
        public void BackupPartial(HassioBackupPartialParameters data)
        {
            _haContext.CallService("hassio", "backup_partial", null, data);
        }

        ///<summary>Create a partial backup.</summary>
        ///<param name="addons">Optional list of add-on slugs. eg: ["core_ssh", "core_samba", "core_mosquitto"]</param>
        ///<param name="folders">Optional list of directories. eg: ["homeassistant", "share"]</param>
        ///<param name="name">Optional (default = current date and time). eg: Partial backup 1</param>
        ///<param name="password">Optional password. eg: password</param>
        public void BackupPartial(object? @addons = null, object? @folders = null, string? @name = null, string? @password = null)
        {
            _haContext.CallService("hassio", "backup_partial", null, new HassioBackupPartialParameters { Addons = @addons, Folders = @folders, Name = @name, Password = @password });
        }

        ///<summary>Reboot the host system.</summary>
        public void HostReboot()
        {
            _haContext.CallService("hassio", "host_reboot", null);
        }

        ///<summary>Poweroff the host system.</summary>
        public void HostShutdown()
        {
            _haContext.CallService("hassio", "host_shutdown", null);
        }

        ///<summary>Restore from full backup.</summary>
        public void RestoreFull(HassioRestoreFullParameters data)
        {
            _haContext.CallService("hassio", "restore_full", null, data);
        }

        ///<summary>Restore from full backup.</summary>
        ///<param name="slug">Slug of backup to restore from.</param>
        ///<param name="password">Optional password. eg: password</param>
        public void RestoreFull(string @slug, string? @password = null)
        {
            _haContext.CallService("hassio", "restore_full", null, new HassioRestoreFullParameters { Slug = @slug, Password = @password });
        }

        ///<summary>Restore from partial backup.</summary>
        public void RestorePartial(HassioRestorePartialParameters data)
        {
            _haContext.CallService("hassio", "restore_partial", null, data);
        }

        ///<summary>Restore from partial backup.</summary>
        ///<param name="slug">Slug of backup to restore from.</param>
        ///<param name="homeassistant">Restore Home Assistant</param>
        ///<param name="folders">Optional list of directories. eg: ["homeassistant", "share"]</param>
        ///<param name="addons">Optional list of add-on slugs. eg: ["core_ssh", "core_samba", "core_mosquitto"]</param>
        ///<param name="password">Optional password. eg: password</param>
        public void RestorePartial(string @slug, bool? @homeassistant = null, object? @folders = null, object? @addons = null, string? @password = null)
        {
            _haContext.CallService("hassio", "restore_partial", null, new HassioRestorePartialParameters { Slug = @slug, Homeassistant = @homeassistant, Folders = @folders, Addons = @addons, Password = @password });
        }
    }

    public record HassioAddonRestartParameters
    {
        ///<summary>The add-on slug. eg: core_ssh</summary>
        [System.Text.Json.Serialization.JsonPropertyName("addon")]
        public string? Addon { get; init; }
    }

    public record HassioAddonStartParameters
    {
        ///<summary>The add-on slug. eg: core_ssh</summary>
        [System.Text.Json.Serialization.JsonPropertyName("addon")]
        public string? Addon { get; init; }
    }

    public record HassioAddonStdinParameters
    {
        ///<summary>The add-on slug. eg: core_ssh</summary>
        [System.Text.Json.Serialization.JsonPropertyName("addon")]
        public string? Addon { get; init; }
    }

    public record HassioAddonStopParameters
    {
        ///<summary>The add-on slug. eg: core_ssh</summary>
        [System.Text.Json.Serialization.JsonPropertyName("addon")]
        public string? Addon { get; init; }
    }

    public record HassioAddonUpdateParameters
    {
        ///<summary>The add-on slug. eg: core_ssh</summary>
        [System.Text.Json.Serialization.JsonPropertyName("addon")]
        public string? Addon { get; init; }
    }

    public record HassioBackupFullParameters
    {
        ///<summary>Optional (default = current date and time). eg: Backup 1</summary>
        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; init; }

        ///<summary>Optional password. eg: password</summary>
        [System.Text.Json.Serialization.JsonPropertyName("password")]
        public string? Password { get; init; }
    }

    public record HassioBackupPartialParameters
    {
        ///<summary>Optional list of add-on slugs. eg: ["core_ssh", "core_samba", "core_mosquitto"]</summary>
        [System.Text.Json.Serialization.JsonPropertyName("addons")]
        public object? Addons { get; init; }

        ///<summary>Optional list of directories. eg: ["homeassistant", "share"]</summary>
        [System.Text.Json.Serialization.JsonPropertyName("folders")]
        public object? Folders { get; init; }

        ///<summary>Optional (default = current date and time). eg: Partial backup 1</summary>
        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; init; }

        ///<summary>Optional password. eg: password</summary>
        [System.Text.Json.Serialization.JsonPropertyName("password")]
        public string? Password { get; init; }
    }

    public record HassioRestoreFullParameters
    {
        ///<summary>Slug of backup to restore from.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("slug")]
        public string? Slug { get; init; }

        ///<summary>Optional password. eg: password</summary>
        [System.Text.Json.Serialization.JsonPropertyName("password")]
        public string? Password { get; init; }
    }

    public record HassioRestorePartialParameters
    {
        ///<summary>Slug of backup to restore from.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("slug")]
        public string? Slug { get; init; }

        ///<summary>Restore Home Assistant</summary>
        [System.Text.Json.Serialization.JsonPropertyName("homeassistant")]
        public bool? Homeassistant { get; init; }

        ///<summary>Optional list of directories. eg: ["homeassistant", "share"]</summary>
        [System.Text.Json.Serialization.JsonPropertyName("folders")]
        public object? Folders { get; init; }

        ///<summary>Optional list of add-on slugs. eg: ["core_ssh", "core_samba", "core_mosquitto"]</summary>
        [System.Text.Json.Serialization.JsonPropertyName("addons")]
        public object? Addons { get; init; }

        ///<summary>Optional password. eg: password</summary>
        [System.Text.Json.Serialization.JsonPropertyName("password")]
        public string? Password { get; init; }
    }

    public class HomeassistantServices
    {
        private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
        public HomeassistantServices(NetDaemon.HassModel.Common.IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Check the Home Assistant configuration files for errors. Errors will be displayed in the Home Assistant log.</summary>
        public void CheckConfig()
        {
            _haContext.CallService("homeassistant", "check_config", null);
        }

        ///<summary>Reload a config entry that matches a target.</summary>
        ///<param name="target">The target for this service call</param>
        public void ReloadConfigEntry(NetDaemon.HassModel.Entities.ServiceTarget target, HomeassistantReloadConfigEntryParameters data)
        {
            _haContext.CallService("homeassistant", "reload_config_entry", target, data);
        }

        ///<summary>Reload a config entry that matches a target.</summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="entryId">A configuration entry id eg: 8955375327824e14ba89e4b29cc3ec9a</param>
        public void ReloadConfigEntry(NetDaemon.HassModel.Entities.ServiceTarget target, string? @entryId = null)
        {
            _haContext.CallService("homeassistant", "reload_config_entry", target, new HomeassistantReloadConfigEntryParameters { EntryId = @entryId });
        }

        ///<summary>Reload the core configuration.</summary>
        public void ReloadCoreConfig()
        {
            _haContext.CallService("homeassistant", "reload_core_config", null);
        }

        ///<summary>Restart the Home Assistant service.</summary>
        public void Restart()
        {
            _haContext.CallService("homeassistant", "restart", null);
        }

        ///<summary>Save the persistent states (for entities derived from RestoreEntity) immediately. Maintain the normal periodic saving interval.</summary>
        public void SavePersistentStates()
        {
            _haContext.CallService("homeassistant", "save_persistent_states", null);
        }

        ///<summary>Update the Home Assistant location.</summary>
        public void SetLocation(HomeassistantSetLocationParameters data)
        {
            _haContext.CallService("homeassistant", "set_location", null, data);
        }

        ///<summary>Update the Home Assistant location.</summary>
        ///<param name="latitude">Latitude of your location. eg: 32.87336</param>
        ///<param name="longitude">Longitude of your location. eg: 117.22743</param>
        public void SetLocation(string @latitude, string @longitude)
        {
            _haContext.CallService("homeassistant", "set_location", null, new HomeassistantSetLocationParameters { Latitude = @latitude, Longitude = @longitude });
        }

        ///<summary>Stop the Home Assistant service.</summary>
        public void Stop()
        {
            _haContext.CallService("homeassistant", "stop", null);
        }

        ///<summary>Generic service to toggle devices on/off under any domain</summary>
        ///<param name="target">The target for this service call</param>
        public void Toggle(NetDaemon.HassModel.Entities.ServiceTarget target)
        {
            _haContext.CallService("homeassistant", "toggle", target);
        }

        ///<summary>Generic service to turn devices off under any domain.</summary>
        ///<param name="target">The target for this service call</param>
        public void TurnOff(NetDaemon.HassModel.Entities.ServiceTarget target)
        {
            _haContext.CallService("homeassistant", "turn_off", target);
        }

        ///<summary>Generic service to turn devices on under any domain.</summary>
        ///<param name="target">The target for this service call</param>
        public void TurnOn(NetDaemon.HassModel.Entities.ServiceTarget target)
        {
            _haContext.CallService("homeassistant", "turn_on", target);
        }

        ///<summary>Force one or more entities to update its data</summary>
        ///<param name="target">The target for this service call</param>
        public void UpdateEntity(NetDaemon.HassModel.Entities.ServiceTarget target)
        {
            _haContext.CallService("homeassistant", "update_entity", target);
        }
    }

    public record HomeassistantReloadConfigEntryParameters
    {
        ///<summary>A configuration entry id eg: 8955375327824e14ba89e4b29cc3ec9a</summary>
        [System.Text.Json.Serialization.JsonPropertyName("entry_id")]
        public string? EntryId { get; init; }
    }

    public record HomeassistantSetLocationParameters
    {
        ///<summary>Latitude of your location. eg: 32.87336</summary>
        [System.Text.Json.Serialization.JsonPropertyName("latitude")]
        public string? Latitude { get; init; }

        ///<summary>Longitude of your location. eg: 117.22743</summary>
        [System.Text.Json.Serialization.JsonPropertyName("longitude")]
        public string? Longitude { get; init; }
    }

    public class InputBooleanServices
    {
        private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
        public InputBooleanServices(NetDaemon.HassModel.Common.IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Reload the input_boolean configuration</summary>
        public void Reload()
        {
            _haContext.CallService("input_boolean", "reload", null);
        }

        ///<summary>Toggle an input boolean</summary>
        ///<param name="target">The target for this service call</param>
        public void Toggle(NetDaemon.HassModel.Entities.ServiceTarget target)
        {
            _haContext.CallService("input_boolean", "toggle", target);
        }

        ///<summary>Turn off an input boolean</summary>
        ///<param name="target">The target for this service call</param>
        public void TurnOff(NetDaemon.HassModel.Entities.ServiceTarget target)
        {
            _haContext.CallService("input_boolean", "turn_off", target);
        }

        ///<summary>Turn on an input boolean</summary>
        ///<param name="target">The target for this service call</param>
        public void TurnOn(NetDaemon.HassModel.Entities.ServiceTarget target)
        {
            _haContext.CallService("input_boolean", "turn_on", target);
        }
    }

    public class InputNumberServices
    {
        private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
        public InputNumberServices(NetDaemon.HassModel.Common.IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Decrement the value of an input number entity by its stepping.</summary>
        ///<param name="target">The target for this service call</param>
        public void Decrement(NetDaemon.HassModel.Entities.ServiceTarget target)
        {
            _haContext.CallService("input_number", "decrement", target);
        }

        ///<summary>Increment the value of an input number entity by its stepping.</summary>
        ///<param name="target">The target for this service call</param>
        public void Increment(NetDaemon.HassModel.Entities.ServiceTarget target)
        {
            _haContext.CallService("input_number", "increment", target);
        }

        ///<summary>Reload the input_number configuration.</summary>
        public void Reload()
        {
            _haContext.CallService("input_number", "reload", null);
        }

        ///<summary>Set the value of an input number entity.</summary>
        ///<param name="target">The target for this service call</param>
        public void SetValue(NetDaemon.HassModel.Entities.ServiceTarget target, InputNumberSetValueParameters data)
        {
            _haContext.CallService("input_number", "set_value", target, data);
        }

        ///<summary>Set the value of an input number entity.</summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="value">The target value the entity should be set to.</param>
        public void SetValue(NetDaemon.HassModel.Entities.ServiceTarget target, double @value)
        {
            _haContext.CallService("input_number", "set_value", target, new InputNumberSetValueParameters { Value = @value });
        }
    }

    public record InputNumberSetValueParameters
    {
        ///<summary>The target value the entity should be set to.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("value")]
        public double? Value { get; init; }
    }

    public class InputSelectServices
    {
        private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
        public InputSelectServices(NetDaemon.HassModel.Common.IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Reload the input_select configuration.</summary>
        public void Reload()
        {
            _haContext.CallService("input_select", "reload", null);
        }

        ///<summary>Select the first option of an input select entity.</summary>
        ///<param name="target">The target for this service call</param>
        public void SelectFirst(NetDaemon.HassModel.Entities.ServiceTarget target)
        {
            _haContext.CallService("input_select", "select_first", target);
        }

        ///<summary>Select the last option of an input select entity.</summary>
        ///<param name="target">The target for this service call</param>
        public void SelectLast(NetDaemon.HassModel.Entities.ServiceTarget target)
        {
            _haContext.CallService("input_select", "select_last", target);
        }

        ///<summary>Select the next options of an input select entity.</summary>
        ///<param name="target">The target for this service call</param>
        public void SelectNext(NetDaemon.HassModel.Entities.ServiceTarget target, InputSelectSelectNextParameters data)
        {
            _haContext.CallService("input_select", "select_next", target, data);
        }

        ///<summary>Select the next options of an input select entity.</summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="cycle">If the option should cycle from the last to the first.</param>
        public void SelectNext(NetDaemon.HassModel.Entities.ServiceTarget target, bool? @cycle = null)
        {
            _haContext.CallService("input_select", "select_next", target, new InputSelectSelectNextParameters { Cycle = @cycle });
        }

        ///<summary>Select an option of an input select entity.</summary>
        ///<param name="target">The target for this service call</param>
        public void SelectOption(NetDaemon.HassModel.Entities.ServiceTarget target, InputSelectSelectOptionParameters data)
        {
            _haContext.CallService("input_select", "select_option", target, data);
        }

        ///<summary>Select an option of an input select entity.</summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="option">Option to be selected. eg: "Item A"</param>
        public void SelectOption(NetDaemon.HassModel.Entities.ServiceTarget target, string @option)
        {
            _haContext.CallService("input_select", "select_option", target, new InputSelectSelectOptionParameters { Option = @option });
        }

        ///<summary>Select the previous options of an input select entity.</summary>
        ///<param name="target">The target for this service call</param>
        public void SelectPrevious(NetDaemon.HassModel.Entities.ServiceTarget target, InputSelectSelectPreviousParameters data)
        {
            _haContext.CallService("input_select", "select_previous", target, data);
        }

        ///<summary>Select the previous options of an input select entity.</summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="cycle">If the option should cycle from the first to the last.</param>
        public void SelectPrevious(NetDaemon.HassModel.Entities.ServiceTarget target, bool? @cycle = null)
        {
            _haContext.CallService("input_select", "select_previous", target, new InputSelectSelectPreviousParameters { Cycle = @cycle });
        }

        ///<summary>Set the options of an input select entity.</summary>
        ///<param name="target">The target for this service call</param>
        public void SetOptions(NetDaemon.HassModel.Entities.ServiceTarget target, InputSelectSetOptionsParameters data)
        {
            _haContext.CallService("input_select", "set_options", target, data);
        }

        ///<summary>Set the options of an input select entity.</summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="options">Options for the input select entity. eg: ["Item A", "Item B", "Item C"]</param>
        public void SetOptions(NetDaemon.HassModel.Entities.ServiceTarget target, object @options)
        {
            _haContext.CallService("input_select", "set_options", target, new InputSelectSetOptionsParameters { Options = @options });
        }
    }

    public record InputSelectSelectNextParameters
    {
        ///<summary>If the option should cycle from the last to the first.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("cycle")]
        public bool? Cycle { get; init; }
    }

    public record InputSelectSelectOptionParameters
    {
        ///<summary>Option to be selected. eg: "Item A"</summary>
        [System.Text.Json.Serialization.JsonPropertyName("option")]
        public string? Option { get; init; }
    }

    public record InputSelectSelectPreviousParameters
    {
        ///<summary>If the option should cycle from the first to the last.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("cycle")]
        public bool? Cycle { get; init; }
    }

    public record InputSelectSetOptionsParameters
    {
        ///<summary>Options for the input select entity. eg: ["Item A", "Item B", "Item C"]</summary>
        [System.Text.Json.Serialization.JsonPropertyName("options")]
        public object? Options { get; init; }
    }

    public class InputTextServices
    {
        private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
        public InputTextServices(NetDaemon.HassModel.Common.IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Reload the input_text configuration.</summary>
        public void Reload()
        {
            _haContext.CallService("input_text", "reload", null);
        }

        ///<summary>Set the value of an input text entity.</summary>
        ///<param name="target">The target for this service call</param>
        public void SetValue(NetDaemon.HassModel.Entities.ServiceTarget target, InputTextSetValueParameters data)
        {
            _haContext.CallService("input_text", "set_value", target, data);
        }

        ///<summary>Set the value of an input text entity.</summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="value">The target value the entity should be set to. eg: This is an example text</param>
        public void SetValue(NetDaemon.HassModel.Entities.ServiceTarget target, string @value)
        {
            _haContext.CallService("input_text", "set_value", target, new InputTextSetValueParameters { Value = @value });
        }
    }

    public record InputTextSetValueParameters
    {
        ///<summary>The target value the entity should be set to. eg: This is an example text</summary>
        [System.Text.Json.Serialization.JsonPropertyName("value")]
        public string? Value { get; init; }
    }

    public class LightServices
    {
        private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
        public LightServices(NetDaemon.HassModel.Common.IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Toggles one or more lights, from on to off, or, off to on, based on their current state. </summary>
        ///<param name="target">The target for this service call</param>
        public void Toggle(NetDaemon.HassModel.Entities.ServiceTarget target, LightToggleParameters data)
        {
            _haContext.CallService("light", "toggle", target, data);
        }

        ///<summary>Toggles one or more lights, from on to off, or, off to on, based on their current state. </summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="transition">Duration it takes to get to next state.</param>
        ///<param name="rgbColor">Color for the light in RGB-format. eg: [255, 100, 100]</param>
        ///<param name="colorName">A human readable color name.</param>
        ///<param name="hsColor">Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</param>
        ///<param name="xyColor">Color for the light in XY-format. eg: [0.52, 0.43]</param>
        ///<param name="colorTemp">Color temperature for the light in mireds.</param>
        ///<param name="kelvin">Color temperature for the light in Kelvin.</param>
        ///<param name="whiteValue">Number indicating level of white.</param>
        ///<param name="brightness">Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
        ///<param name="brightnessPct">Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and 100 is the maximum brightness supported by the light.</param>
        ///<param name="profile">Name of a light profile to use. eg: relax</param>
        ///<param name="flash">If the light should flash.</param>
        ///<param name="effect">Light effect.</param>
        public void Toggle(NetDaemon.HassModel.Entities.ServiceTarget target, long? @transition = null, object? @rgbColor = null, string? @colorName = null, object? @hsColor = null, object? @xyColor = null, long? @colorTemp = null, long? @kelvin = null, long? @whiteValue = null, long? @brightness = null, long? @brightnessPct = null, string? @profile = null, string? @flash = null, string? @effect = null)
        {
            _haContext.CallService("light", "toggle", target, new LightToggleParameters { Transition = @transition, RgbColor = @rgbColor, ColorName = @colorName, HsColor = @hsColor, XyColor = @xyColor, ColorTemp = @colorTemp, Kelvin = @kelvin, WhiteValue = @whiteValue, Brightness = @brightness, BrightnessPct = @brightnessPct, Profile = @profile, Flash = @flash, Effect = @effect });
        }

        ///<summary>Turns off one or more lights.</summary>
        ///<param name="target">The target for this service call</param>
        public void TurnOff(NetDaemon.HassModel.Entities.ServiceTarget target, LightTurnOffParameters data)
        {
            _haContext.CallService("light", "turn_off", target, data);
        }

        ///<summary>Turns off one or more lights.</summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="transition">Duration it takes to get to next state.</param>
        ///<param name="flash">If the light should flash.</param>
        public void TurnOff(NetDaemon.HassModel.Entities.ServiceTarget target, long? @transition = null, string? @flash = null)
        {
            _haContext.CallService("light", "turn_off", target, new LightTurnOffParameters { Transition = @transition, Flash = @flash });
        }

        ///<summary>Turn on one or more lights and adjust properties of the light, even when they are turned on already. </summary>
        ///<param name="target">The target for this service call</param>
        public void TurnOn(NetDaemon.HassModel.Entities.ServiceTarget target, LightTurnOnParameters data)
        {
            _haContext.CallService("light", "turn_on", target, data);
        }

        ///<summary>Turn on one or more lights and adjust properties of the light, even when they are turned on already. </summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="transition">Duration it takes to get to next state.</param>
        ///<param name="rgbColor">A list containing three integers between 0 and 255 representing the RGB (red, green, blue) color for the light. eg: [255, 100, 100]</param>
        ///<param name="rgbwColor">A list containing four integers between 0 and 255 representing the RGBW (red, green, blue, white) color for the light. eg: [255, 100, 100, 50]</param>
        ///<param name="rgbwwColor">A list containing five integers between 0 and 255 representing the RGBWW (red, green, blue, cold white, warm white) color for the light. eg: [255, 100, 100, 50, 70]</param>
        ///<param name="colorName">A human readable color name.</param>
        ///<param name="hsColor">Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</param>
        ///<param name="xyColor">Color for the light in XY-format. eg: [0.52, 0.43]</param>
        ///<param name="colorTemp">Color temperature for the light in mireds.</param>
        ///<param name="kelvin">Color temperature for the light in Kelvin.</param>
        ///<param name="brightness">Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
        ///<param name="brightnessPct">Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and 100 is the maximum brightness supported by the light.</param>
        ///<param name="brightnessStep">Change brightness by an amount.</param>
        ///<param name="brightnessStepPct">Change brightness by a percentage.</param>
        ///<param name="white">Set the light to white mode and change its brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
        ///<param name="profile">Name of a light profile to use. eg: relax</param>
        ///<param name="flash">If the light should flash.</param>
        ///<param name="effect">Light effect.</param>
        public void TurnOn(NetDaemon.HassModel.Entities.ServiceTarget target, long? @transition = null, object? @rgbColor = null, object? @rgbwColor = null, object? @rgbwwColor = null, string? @colorName = null, object? @hsColor = null, object? @xyColor = null, long? @colorTemp = null, long? @kelvin = null, long? @brightness = null, long? @brightnessPct = null, long? @brightnessStep = null, long? @brightnessStepPct = null, long? @white = null, string? @profile = null, string? @flash = null, string? @effect = null)
        {
            _haContext.CallService("light", "turn_on", target, new LightTurnOnParameters { Transition = @transition, RgbColor = @rgbColor, RgbwColor = @rgbwColor, RgbwwColor = @rgbwwColor, ColorName = @colorName, HsColor = @hsColor, XyColor = @xyColor, ColorTemp = @colorTemp, Kelvin = @kelvin, Brightness = @brightness, BrightnessPct = @brightnessPct, BrightnessStep = @brightnessStep, BrightnessStepPct = @brightnessStepPct, White = @white, Profile = @profile, Flash = @flash, Effect = @effect });
        }
    }

    public record LightToggleParameters
    {
        ///<summary>Duration it takes to get to next state.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("transition")]
        public long? Transition { get; init; }

        ///<summary>Color for the light in RGB-format. eg: [255, 100, 100]</summary>
        [System.Text.Json.Serialization.JsonPropertyName("rgb_color")]
        public object? RgbColor { get; init; }

        ///<summary>A human readable color name.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("color_name")]
        public string? ColorName { get; init; }

        ///<summary>Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</summary>
        [System.Text.Json.Serialization.JsonPropertyName("hs_color")]
        public object? HsColor { get; init; }

        ///<summary>Color for the light in XY-format. eg: [0.52, 0.43]</summary>
        [System.Text.Json.Serialization.JsonPropertyName("xy_color")]
        public object? XyColor { get; init; }

        ///<summary>Color temperature for the light in mireds.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("color_temp")]
        public long? ColorTemp { get; init; }

        ///<summary>Color temperature for the light in Kelvin.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("kelvin")]
        public long? Kelvin { get; init; }

        ///<summary>Number indicating level of white.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("white_value")]
        public long? WhiteValue { get; init; }

        ///<summary>Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("brightness")]
        public long? Brightness { get; init; }

        ///<summary>Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and 100 is the maximum brightness supported by the light.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("brightness_pct")]
        public long? BrightnessPct { get; init; }

        ///<summary>Name of a light profile to use. eg: relax</summary>
        [System.Text.Json.Serialization.JsonPropertyName("profile")]
        public string? Profile { get; init; }

        ///<summary>If the light should flash.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("flash")]
        public string? Flash { get; init; }

        ///<summary>Light effect.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("effect")]
        public string? Effect { get; init; }
    }

    public record LightTurnOffParameters
    {
        ///<summary>Duration it takes to get to next state.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("transition")]
        public long? Transition { get; init; }

        ///<summary>If the light should flash.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("flash")]
        public string? Flash { get; init; }
    }

    public record LightTurnOnParameters
    {
        ///<summary>Duration it takes to get to next state.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("transition")]
        public long? Transition { get; init; }

        ///<summary>A list containing three integers between 0 and 255 representing the RGB (red, green, blue) color for the light. eg: [255, 100, 100]</summary>
        [System.Text.Json.Serialization.JsonPropertyName("rgb_color")]
        public object? RgbColor { get; init; }

        ///<summary>A list containing four integers between 0 and 255 representing the RGBW (red, green, blue, white) color for the light. eg: [255, 100, 100, 50]</summary>
        [System.Text.Json.Serialization.JsonPropertyName("rgbw_color")]
        public object? RgbwColor { get; init; }

        ///<summary>A list containing five integers between 0 and 255 representing the RGBWW (red, green, blue, cold white, warm white) color for the light. eg: [255, 100, 100, 50, 70]</summary>
        [System.Text.Json.Serialization.JsonPropertyName("rgbww_color")]
        public object? RgbwwColor { get; init; }

        ///<summary>A human readable color name.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("color_name")]
        public string? ColorName { get; init; }

        ///<summary>Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</summary>
        [System.Text.Json.Serialization.JsonPropertyName("hs_color")]
        public object? HsColor { get; init; }

        ///<summary>Color for the light in XY-format. eg: [0.52, 0.43]</summary>
        [System.Text.Json.Serialization.JsonPropertyName("xy_color")]
        public object? XyColor { get; init; }

        ///<summary>Color temperature for the light in mireds.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("color_temp")]
        public long? ColorTemp { get; init; }

        ///<summary>Color temperature for the light in Kelvin.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("kelvin")]
        public long? Kelvin { get; init; }

        ///<summary>Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("brightness")]
        public long? Brightness { get; init; }

        ///<summary>Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and 100 is the maximum brightness supported by the light.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("brightness_pct")]
        public long? BrightnessPct { get; init; }

        ///<summary>Change brightness by an amount.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("brightness_step")]
        public long? BrightnessStep { get; init; }

        ///<summary>Change brightness by a percentage.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("brightness_step_pct")]
        public long? BrightnessStepPct { get; init; }

        ///<summary>Set the light to white mode and change its brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("white")]
        public long? White { get; init; }

        ///<summary>Name of a light profile to use. eg: relax</summary>
        [System.Text.Json.Serialization.JsonPropertyName("profile")]
        public string? Profile { get; init; }

        ///<summary>If the light should flash.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("flash")]
        public string? Flash { get; init; }

        ///<summary>Light effect.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("effect")]
        public string? Effect { get; init; }
    }

    public class LocaltuyaServices
    {
        private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
        public LocaltuyaServices(NetDaemon.HassModel.Common.IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Reload localtuya and re-process yaml configuration.</summary>
        public void Reload()
        {
            _haContext.CallService("localtuya", "reload", null);
        }

        ///<summary>Change the value of a datapoint (DP)</summary>
        public void SetDp(LocaltuyaSetDpParameters data)
        {
            _haContext.CallService("localtuya", "set_dp", null, data);
        }

        ///<summary>Change the value of a datapoint (DP)</summary>
        ///<param name="deviceId">Device ID of device to change datapoint value for eg: 11100118278aab4de001</param>
        ///<param name="dp">Datapoint index eg: 1</param>
        ///<param name="value">New value to set eg: False</param>
        public void SetDp(string? @deviceId = null, string? @dp = null, string? @value = null)
        {
            _haContext.CallService("localtuya", "set_dp", null, new LocaltuyaSetDpParameters { DeviceId = @deviceId, Dp = @dp, Value = @value });
        }
    }

    public record LocaltuyaSetDpParameters
    {
        ///<summary>Device ID of device to change datapoint value for eg: 11100118278aab4de001</summary>
        [System.Text.Json.Serialization.JsonPropertyName("device_id")]
        public string? DeviceId { get; init; }

        ///<summary>Datapoint index eg: 1</summary>
        [System.Text.Json.Serialization.JsonPropertyName("dp")]
        public string? Dp { get; init; }

        ///<summary>New value to set eg: False</summary>
        [System.Text.Json.Serialization.JsonPropertyName("value")]
        public string? Value { get; init; }
    }

    public class LockServices
    {
        private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
        public LockServices(NetDaemon.HassModel.Common.IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Lock all or specified locks.</summary>
        ///<param name="target">The target for this service call</param>
        public void Lock(NetDaemon.HassModel.Entities.ServiceTarget target, LockLockParameters data)
        {
            _haContext.CallService("lock", "lock", target, data);
        }

        ///<summary>Lock all or specified locks.</summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="code">An optional code to lock the lock with. eg: 1234</param>
        public void Lock(NetDaemon.HassModel.Entities.ServiceTarget target, string? @code = null)
        {
            _haContext.CallService("lock", "lock", target, new LockLockParameters { Code = @code });
        }

        ///<summary>Open all or specified locks.</summary>
        ///<param name="target">The target for this service call</param>
        public void Open(NetDaemon.HassModel.Entities.ServiceTarget target, LockOpenParameters data)
        {
            _haContext.CallService("lock", "open", target, data);
        }

        ///<summary>Open all or specified locks.</summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="code">An optional code to open the lock with. eg: 1234</param>
        public void Open(NetDaemon.HassModel.Entities.ServiceTarget target, string? @code = null)
        {
            _haContext.CallService("lock", "open", target, new LockOpenParameters { Code = @code });
        }

        ///<summary>Unlock all or specified locks.</summary>
        ///<param name="target">The target for this service call</param>
        public void Unlock(NetDaemon.HassModel.Entities.ServiceTarget target, LockUnlockParameters data)
        {
            _haContext.CallService("lock", "unlock", target, data);
        }

        ///<summary>Unlock all or specified locks.</summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="code">An optional code to unlock the lock with. eg: 1234</param>
        public void Unlock(NetDaemon.HassModel.Entities.ServiceTarget target, string? @code = null)
        {
            _haContext.CallService("lock", "unlock", target, new LockUnlockParameters { Code = @code });
        }
    }

    public record LockLockParameters
    {
        ///<summary>An optional code to lock the lock with. eg: 1234</summary>
        [System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; init; }
    }

    public record LockOpenParameters
    {
        ///<summary>An optional code to open the lock with. eg: 1234</summary>
        [System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; init; }
    }

    public record LockUnlockParameters
    {
        ///<summary>An optional code to unlock the lock with. eg: 1234</summary>
        [System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; init; }
    }

    public class LogbookServices
    {
        private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
        public LogbookServices(NetDaemon.HassModel.Common.IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Create a custom entry in your logbook.</summary>
        public void Log(LogbookLogParameters data)
        {
            _haContext.CallService("logbook", "log", null, data);
        }

        ///<summary>Create a custom entry in your logbook.</summary>
        ///<param name="name">Custom name for an entity, can be referenced with entity_id. eg: Kitchen</param>
        ///<param name="message">Message of the custom logbook entry. eg: is being used</param>
        ///<param name="entityId">Entity to reference in custom logbook entry.</param>
        ///<param name="domain">Icon of domain to display in custom logbook entry. eg: light</param>
        public void Log(string @name, string @message, string? @entityId = null, string? @domain = null)
        {
            _haContext.CallService("logbook", "log", null, new LogbookLogParameters { Name = @name, Message = @message, EntityId = @entityId, Domain = @domain });
        }
    }

    public record LogbookLogParameters
    {
        ///<summary>Custom name for an entity, can be referenced with entity_id. eg: Kitchen</summary>
        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; init; }

        ///<summary>Message of the custom logbook entry. eg: is being used</summary>
        [System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; init; }

        ///<summary>Entity to reference in custom logbook entry.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("entity_id")]
        public string? EntityId { get; init; }

        ///<summary>Icon of domain to display in custom logbook entry. eg: light</summary>
        [System.Text.Json.Serialization.JsonPropertyName("domain")]
        public string? Domain { get; init; }
    }

    public class LoggerServices
    {
        private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
        public LoggerServices(NetDaemon.HassModel.Common.IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Set the default log level for integrations.</summary>
        public void SetDefaultLevel(LoggerSetDefaultLevelParameters data)
        {
            _haContext.CallService("logger", "set_default_level", null, data);
        }

        ///<summary>Set the default log level for integrations.</summary>
        ///<param name="level">Default severity level for all integrations.</param>
        public void SetDefaultLevel(string? @level = null)
        {
            _haContext.CallService("logger", "set_default_level", null, new LoggerSetDefaultLevelParameters { Level = @level });
        }

        ///<summary>Set log level for integrations.</summary>
        public void SetLevel()
        {
            _haContext.CallService("logger", "set_level", null);
        }
    }

    public record LoggerSetDefaultLevelParameters
    {
        ///<summary>Default severity level for all integrations.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("level")]
        public string? Level { get; init; }
    }

    public class LovelaceServices
    {
        private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
        public LovelaceServices(NetDaemon.HassModel.Common.IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Reload Lovelace resources from YAML configuration</summary>
        public void ReloadResources()
        {
            _haContext.CallService("lovelace", "reload_resources", null);
        }
    }

    public class MediaPlayerServices
    {
        private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
        public MediaPlayerServices(NetDaemon.HassModel.Common.IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Send the media player the command to clear players playlist.</summary>
        ///<param name="target">The target for this service call</param>
        public void ClearPlaylist(NetDaemon.HassModel.Entities.ServiceTarget target)
        {
            _haContext.CallService("media_player", "clear_playlist", target);
        }

        ///<summary>Group players together. Only works on platforms with support for player groups.</summary>
        ///<param name="target">The target for this service call</param>
        public void Join(NetDaemon.HassModel.Entities.ServiceTarget target, MediaPlayerJoinParameters data)
        {
            _haContext.CallService("media_player", "join", target, data);
        }

        ///<summary>Group players together. Only works on platforms with support for player groups.</summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="groupMembers">The players which will be synced with the target player. eg: ["media_player.multiroom_player2", "media_player.multiroom_player3"]</param>
        public void Join(NetDaemon.HassModel.Entities.ServiceTarget target, object? @groupMembers = null)
        {
            _haContext.CallService("media_player", "join", target, new MediaPlayerJoinParameters { GroupMembers = @groupMembers });
        }

        ///<summary>Send the media player the command for next track.</summary>
        ///<param name="target">The target for this service call</param>
        public void MediaNextTrack(NetDaemon.HassModel.Entities.ServiceTarget target)
        {
            _haContext.CallService("media_player", "media_next_track", target);
        }

        ///<summary>Send the media player the command for pause.</summary>
        ///<param name="target">The target for this service call</param>
        public void MediaPause(NetDaemon.HassModel.Entities.ServiceTarget target)
        {
            _haContext.CallService("media_player", "media_pause", target);
        }

        ///<summary>Send the media player the command for play.</summary>
        ///<param name="target">The target for this service call</param>
        public void MediaPlay(NetDaemon.HassModel.Entities.ServiceTarget target)
        {
            _haContext.CallService("media_player", "media_play", target);
        }

        ///<summary>Toggle media player play/pause state.</summary>
        ///<param name="target">The target for this service call</param>
        public void MediaPlayPause(NetDaemon.HassModel.Entities.ServiceTarget target)
        {
            _haContext.CallService("media_player", "media_play_pause", target);
        }

        ///<summary>Send the media player the command for previous track.</summary>
        ///<param name="target">The target for this service call</param>
        public void MediaPreviousTrack(NetDaemon.HassModel.Entities.ServiceTarget target)
        {
            _haContext.CallService("media_player", "media_previous_track", target);
        }

        ///<summary>Send the media player the command to seek in current playing media.</summary>
        ///<param name="target">The target for this service call</param>
        public void MediaSeek(NetDaemon.HassModel.Entities.ServiceTarget target, MediaPlayerMediaSeekParameters data)
        {
            _haContext.CallService("media_player", "media_seek", target, data);
        }

        ///<summary>Send the media player the command to seek in current playing media.</summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="seekPosition">Position to seek to. The format is platform dependent.</param>
        public void MediaSeek(NetDaemon.HassModel.Entities.ServiceTarget target, double @seekPosition)
        {
            _haContext.CallService("media_player", "media_seek", target, new MediaPlayerMediaSeekParameters { SeekPosition = @seekPosition });
        }

        ///<summary>Send the media player the stop command.</summary>
        ///<param name="target">The target for this service call</param>
        public void MediaStop(NetDaemon.HassModel.Entities.ServiceTarget target)
        {
            _haContext.CallService("media_player", "media_stop", target);
        }

        ///<summary>Send the media player the command for playing media.</summary>
        ///<param name="target">The target for this service call</param>
        public void PlayMedia(NetDaemon.HassModel.Entities.ServiceTarget target, MediaPlayerPlayMediaParameters data)
        {
            _haContext.CallService("media_player", "play_media", target, data);
        }

        ///<summary>Send the media player the command for playing media.</summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="mediaContentId">The ID of the content to play. Platform dependent. eg: https://home-assistant.io/images/cast/splash.png</param>
        ///<param name="mediaContentType">The type of the content to play. Like image, music, tvshow, video, episode, channel or playlist. eg: music</param>
        public void PlayMedia(NetDaemon.HassModel.Entities.ServiceTarget target, string @mediaContentId, string @mediaContentType)
        {
            _haContext.CallService("media_player", "play_media", target, new MediaPlayerPlayMediaParameters { MediaContentId = @mediaContentId, MediaContentType = @mediaContentType });
        }

        ///<summary>Set repeat mode</summary>
        ///<param name="target">The target for this service call</param>
        public void RepeatSet(NetDaemon.HassModel.Entities.ServiceTarget target, MediaPlayerRepeatSetParameters data)
        {
            _haContext.CallService("media_player", "repeat_set", target, data);
        }

        ///<summary>Set repeat mode</summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="repeat">Repeat mode to set.</param>
        public void RepeatSet(NetDaemon.HassModel.Entities.ServiceTarget target, string @repeat)
        {
            _haContext.CallService("media_player", "repeat_set", target, new MediaPlayerRepeatSetParameters { Repeat = @repeat });
        }

        ///<summary>Send the media player the command to change sound mode.</summary>
        ///<param name="target">The target for this service call</param>
        public void SelectSoundMode(NetDaemon.HassModel.Entities.ServiceTarget target, MediaPlayerSelectSoundModeParameters data)
        {
            _haContext.CallService("media_player", "select_sound_mode", target, data);
        }

        ///<summary>Send the media player the command to change sound mode.</summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="soundMode">Name of the sound mode to switch to. eg: Music</param>
        public void SelectSoundMode(NetDaemon.HassModel.Entities.ServiceTarget target, string? @soundMode = null)
        {
            _haContext.CallService("media_player", "select_sound_mode", target, new MediaPlayerSelectSoundModeParameters { SoundMode = @soundMode });
        }

        ///<summary>Send the media player the command to change input source.</summary>
        ///<param name="target">The target for this service call</param>
        public void SelectSource(NetDaemon.HassModel.Entities.ServiceTarget target, MediaPlayerSelectSourceParameters data)
        {
            _haContext.CallService("media_player", "select_source", target, data);
        }

        ///<summary>Send the media player the command to change input source.</summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="source">Name of the source to switch to. Platform dependent. eg: video1</param>
        public void SelectSource(NetDaemon.HassModel.Entities.ServiceTarget target, string @source)
        {
            _haContext.CallService("media_player", "select_source", target, new MediaPlayerSelectSourceParameters { Source = @source });
        }

        ///<summary>Set shuffling state.</summary>
        ///<param name="target">The target for this service call</param>
        public void ShuffleSet(NetDaemon.HassModel.Entities.ServiceTarget target, MediaPlayerShuffleSetParameters data)
        {
            _haContext.CallService("media_player", "shuffle_set", target, data);
        }

        ///<summary>Set shuffling state.</summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="shuffle">True/false for enabling/disabling shuffle.</param>
        public void ShuffleSet(NetDaemon.HassModel.Entities.ServiceTarget target, bool @shuffle)
        {
            _haContext.CallService("media_player", "shuffle_set", target, new MediaPlayerShuffleSetParameters { Shuffle = @shuffle });
        }

        ///<summary>Toggles a media player power state.</summary>
        ///<param name="target">The target for this service call</param>
        public void Toggle(NetDaemon.HassModel.Entities.ServiceTarget target)
        {
            _haContext.CallService("media_player", "toggle", target);
        }

        ///<summary>Turn a media player power off.</summary>
        ///<param name="target">The target for this service call</param>
        public void TurnOff(NetDaemon.HassModel.Entities.ServiceTarget target)
        {
            _haContext.CallService("media_player", "turn_off", target);
        }

        ///<summary>Turn a media player power on.</summary>
        ///<param name="target">The target for this service call</param>
        public void TurnOn(NetDaemon.HassModel.Entities.ServiceTarget target)
        {
            _haContext.CallService("media_player", "turn_on", target);
        }

        ///<summary>Unjoin the player from a group. Only works on platforms with support for player groups.</summary>
        ///<param name="target">The target for this service call</param>
        public void Unjoin(NetDaemon.HassModel.Entities.ServiceTarget target)
        {
            _haContext.CallService("media_player", "unjoin", target);
        }

        ///<summary>Turn a media player volume down.</summary>
        ///<param name="target">The target for this service call</param>
        public void VolumeDown(NetDaemon.HassModel.Entities.ServiceTarget target)
        {
            _haContext.CallService("media_player", "volume_down", target);
        }

        ///<summary>Mute a media player's volume.</summary>
        ///<param name="target">The target for this service call</param>
        public void VolumeMute(NetDaemon.HassModel.Entities.ServiceTarget target, MediaPlayerVolumeMuteParameters data)
        {
            _haContext.CallService("media_player", "volume_mute", target, data);
        }

        ///<summary>Mute a media player's volume.</summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="isVolumeMuted">True/false for mute/unmute.</param>
        public void VolumeMute(NetDaemon.HassModel.Entities.ServiceTarget target, bool @isVolumeMuted)
        {
            _haContext.CallService("media_player", "volume_mute", target, new MediaPlayerVolumeMuteParameters { IsVolumeMuted = @isVolumeMuted });
        }

        ///<summary>Set a media player's volume level.</summary>
        ///<param name="target">The target for this service call</param>
        public void VolumeSet(NetDaemon.HassModel.Entities.ServiceTarget target, MediaPlayerVolumeSetParameters data)
        {
            _haContext.CallService("media_player", "volume_set", target, data);
        }

        ///<summary>Set a media player's volume level.</summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="volumeLevel">Volume level to set as float.</param>
        public void VolumeSet(NetDaemon.HassModel.Entities.ServiceTarget target, double @volumeLevel)
        {
            _haContext.CallService("media_player", "volume_set", target, new MediaPlayerVolumeSetParameters { VolumeLevel = @volumeLevel });
        }

        ///<summary>Turn a media player volume up.</summary>
        ///<param name="target">The target for this service call</param>
        public void VolumeUp(NetDaemon.HassModel.Entities.ServiceTarget target)
        {
            _haContext.CallService("media_player", "volume_up", target);
        }
    }

    public record MediaPlayerJoinParameters
    {
        ///<summary>The players which will be synced with the target player. eg: ["media_player.multiroom_player2", "media_player.multiroom_player3"]</summary>
        [System.Text.Json.Serialization.JsonPropertyName("group_members")]
        public object? GroupMembers { get; init; }
    }

    public record MediaPlayerMediaSeekParameters
    {
        ///<summary>Position to seek to. The format is platform dependent.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("seek_position")]
        public double? SeekPosition { get; init; }
    }

    public record MediaPlayerPlayMediaParameters
    {
        ///<summary>The ID of the content to play. Platform dependent. eg: https://home-assistant.io/images/cast/splash.png</summary>
        [System.Text.Json.Serialization.JsonPropertyName("media_content_id")]
        public string? MediaContentId { get; init; }

        ///<summary>The type of the content to play. Like image, music, tvshow, video, episode, channel or playlist. eg: music</summary>
        [System.Text.Json.Serialization.JsonPropertyName("media_content_type")]
        public string? MediaContentType { get; init; }
    }

    public record MediaPlayerRepeatSetParameters
    {
        ///<summary>Repeat mode to set.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("repeat")]
        public string? Repeat { get; init; }
    }

    public record MediaPlayerSelectSoundModeParameters
    {
        ///<summary>Name of the sound mode to switch to. eg: Music</summary>
        [System.Text.Json.Serialization.JsonPropertyName("sound_mode")]
        public string? SoundMode { get; init; }
    }

    public record MediaPlayerSelectSourceParameters
    {
        ///<summary>Name of the source to switch to. Platform dependent. eg: video1</summary>
        [System.Text.Json.Serialization.JsonPropertyName("source")]
        public string? Source { get; init; }
    }

    public record MediaPlayerShuffleSetParameters
    {
        ///<summary>True/false for enabling/disabling shuffle.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("shuffle")]
        public bool? Shuffle { get; init; }
    }

    public record MediaPlayerVolumeMuteParameters
    {
        ///<summary>True/false for mute/unmute.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("is_volume_muted")]
        public bool? IsVolumeMuted { get; init; }
    }

    public record MediaPlayerVolumeSetParameters
    {
        ///<summary>Volume level to set as float.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("volume_level")]
        public double? VolumeLevel { get; init; }
    }

    public class MqttServices
    {
        private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
        public MqttServices(NetDaemon.HassModel.Common.IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Dump messages on a topic selector to the 'mqtt_dump.txt' file in your configuration folder.</summary>
        public void Dump(MqttDumpParameters data)
        {
            _haContext.CallService("mqtt", "dump", null, data);
        }

        ///<summary>Dump messages on a topic selector to the 'mqtt_dump.txt' file in your configuration folder.</summary>
        ///<param name="topic">topic to listen to eg: OpenZWave/#</param>
        ///<param name="duration">how long we should listen for messages in seconds</param>
        public void Dump(string? @topic = null, long? @duration = null)
        {
            _haContext.CallService("mqtt", "dump", null, new MqttDumpParameters { Topic = @topic, Duration = @duration });
        }

        ///<summary>Publish a message to an MQTT topic.</summary>
        public void Publish(MqttPublishParameters data)
        {
            _haContext.CallService("mqtt", "publish", null, data);
        }

        ///<summary>Publish a message to an MQTT topic.</summary>
        ///<param name="topic">Topic to publish payload. eg: /homeassistant/hello</param>
        ///<param name="payload">Payload to publish. eg: This is great</param>
        ///<param name="payloadTemplate">Template to render as payload value. Ignored if payload given. eg: {{ states('sensor.temperature') }}</param>
        ///<param name="qos">Quality of Service to use.</param>
        ///<param name="retain">If message should have the retain flag set.</param>
        public void Publish(string @topic, string? @payload = null, object? @payloadTemplate = null, string? @qos = null, bool? @retain = null)
        {
            _haContext.CallService("mqtt", "publish", null, new MqttPublishParameters { Topic = @topic, Payload = @payload, PayloadTemplate = @payloadTemplate, Qos = @qos, Retain = @retain });
        }

        ///<summary>Reload all MQTT entities from YAML.</summary>
        public void Reload()
        {
            _haContext.CallService("mqtt", "reload", null);
        }
    }

    public record MqttDumpParameters
    {
        ///<summary>topic to listen to eg: OpenZWave/#</summary>
        [System.Text.Json.Serialization.JsonPropertyName("topic")]
        public string? Topic { get; init; }

        ///<summary>how long we should listen for messages in seconds</summary>
        [System.Text.Json.Serialization.JsonPropertyName("duration")]
        public long? Duration { get; init; }
    }

    public record MqttPublishParameters
    {
        ///<summary>Topic to publish payload. eg: /homeassistant/hello</summary>
        [System.Text.Json.Serialization.JsonPropertyName("topic")]
        public string? Topic { get; init; }

        ///<summary>Payload to publish. eg: This is great</summary>
        [System.Text.Json.Serialization.JsonPropertyName("payload")]
        public string? Payload { get; init; }

        ///<summary>Template to render as payload value. Ignored if payload given. eg: {{ states('sensor.temperature') }}</summary>
        [System.Text.Json.Serialization.JsonPropertyName("payload_template")]
        public object? PayloadTemplate { get; init; }

        ///<summary>Quality of Service to use.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("qos")]
        public string? Qos { get; init; }

        ///<summary>If message should have the retain flag set.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("retain")]
        public bool? Retain { get; init; }
    }

    public class NetdaemonServices
    {
        private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
        public NetdaemonServices(NetDaemon.HassModel.Common.IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Create an entity</summary>
        public void EntityCreate(NetdaemonEntityCreateParameters data)
        {
            _haContext.CallService("netdaemon", "entity_create", null, data);
        }

        ///<summary>Create an entity</summary>
        ///<param name="entityId">The entity ID of the entity eg: sensor.awesome</param>
        ///<param name="state">The state of the entity eg: Lorem ipsum</param>
        ///<param name="icon">The icon for the entity eg: mdi:rocket-launch-outline</param>
        ///<param name="unit">The unit of measurement for the entity</param>
        ///<param name="attributes">The attributes of the entity</param>
        public void EntityCreate(string? @entityId = null, string? @state = null, string? @icon = null, string? @unit = null, string? @attributes = null)
        {
            _haContext.CallService("netdaemon", "entity_create", null, new NetdaemonEntityCreateParameters { EntityId = @entityId, State = @state, Icon = @icon, Unit = @unit, Attributes = @attributes });
        }

        ///<summary>Remove an entity</summary>
        public void EntityRemove(NetdaemonEntityRemoveParameters data)
        {
            _haContext.CallService("netdaemon", "entity_remove", null, data);
        }

        ///<summary>Remove an entity</summary>
        ///<param name="entityId">The entity ID of the entity eg: sensor.awesome</param>
        public void EntityRemove(string? @entityId = null)
        {
            _haContext.CallService("netdaemon", "entity_remove", null, new NetdaemonEntityRemoveParameters { EntityId = @entityId });
        }

        ///<summary>Update an entity</summary>
        public void EntityUpdate(NetdaemonEntityUpdateParameters data)
        {
            _haContext.CallService("netdaemon", "entity_update", null, data);
        }

        ///<summary>Update an entity</summary>
        ///<param name="entityId">The entity ID of the entity eg: sensor.awesome</param>
        ///<param name="state">The state of the entity eg: Lorem ipsum</param>
        ///<param name="icon">The icon for the entity eg: mdi:rocket-launch-outline</param>
        ///<param name="unit">The unit of measurement for the entity</param>
        ///<param name="attributes">The attributes of the entity</param>
        public void EntityUpdate(string? @entityId = null, string? @state = null, string? @icon = null, string? @unit = null, string? @attributes = null)
        {
            _haContext.CallService("netdaemon", "entity_update", null, new NetdaemonEntityUpdateParameters { EntityId = @entityId, State = @state, Icon = @icon, Unit = @unit, Attributes = @attributes });
        }

        ///<summary>Register a new service for netdaemon, used by the daemon and not to be used by users</summary>
        public void RegisterService(NetdaemonRegisterServiceParameters data)
        {
            _haContext.CallService("netdaemon", "register_service", null, data);
        }

        ///<summary>Register a new service for netdaemon, used by the daemon and not to be used by users</summary>
        ///<param name="service">The name of the service to register</param>
        ///<param name="class">The class that implements the service call</param>
        ///<param name="method">The method to call</param>
        public void RegisterService(string? @service = null, string? @class = null, string? @method = null)
        {
            _haContext.CallService("netdaemon", "register_service", null, new NetdaemonRegisterServiceParameters { Service = @service, Class = @class, Method = @method });
        }

        public void ReloadApps()
        {
            _haContext.CallService("netdaemon", "reload_apps", null);
        }

        public void WebhookmanagerOnwebhook()
        {
            _haContext.CallService("netdaemon", "webhookmanager_onwebhook", null);
        }
    }

    public record NetdaemonEntityCreateParameters
    {
        ///<summary>The entity ID of the entity eg: sensor.awesome</summary>
        [System.Text.Json.Serialization.JsonPropertyName("entity_id")]
        public string? EntityId { get; init; }

        ///<summary>The state of the entity eg: Lorem ipsum</summary>
        [System.Text.Json.Serialization.JsonPropertyName("state")]
        public string? State { get; init; }

        ///<summary>The icon for the entity eg: mdi:rocket-launch-outline</summary>
        [System.Text.Json.Serialization.JsonPropertyName("icon")]
        public string? Icon { get; init; }

        ///<summary>The unit of measurement for the entity</summary>
        [System.Text.Json.Serialization.JsonPropertyName("unit")]
        public string? Unit { get; init; }

        ///<summary>The attributes of the entity</summary>
        [System.Text.Json.Serialization.JsonPropertyName("attributes")]
        public string? Attributes { get; init; }
    }

    public record NetdaemonEntityRemoveParameters
    {
        ///<summary>The entity ID of the entity eg: sensor.awesome</summary>
        [System.Text.Json.Serialization.JsonPropertyName("entity_id")]
        public string? EntityId { get; init; }
    }

    public record NetdaemonEntityUpdateParameters
    {
        ///<summary>The entity ID of the entity eg: sensor.awesome</summary>
        [System.Text.Json.Serialization.JsonPropertyName("entity_id")]
        public string? EntityId { get; init; }

        ///<summary>The state of the entity eg: Lorem ipsum</summary>
        [System.Text.Json.Serialization.JsonPropertyName("state")]
        public string? State { get; init; }

        ///<summary>The icon for the entity eg: mdi:rocket-launch-outline</summary>
        [System.Text.Json.Serialization.JsonPropertyName("icon")]
        public string? Icon { get; init; }

        ///<summary>The unit of measurement for the entity</summary>
        [System.Text.Json.Serialization.JsonPropertyName("unit")]
        public string? Unit { get; init; }

        ///<summary>The attributes of the entity</summary>
        [System.Text.Json.Serialization.JsonPropertyName("attributes")]
        public string? Attributes { get; init; }
    }

    public record NetdaemonRegisterServiceParameters
    {
        ///<summary>The name of the service to register</summary>
        [System.Text.Json.Serialization.JsonPropertyName("service")]
        public string? Service { get; init; }

        ///<summary>The class that implements the service call</summary>
        [System.Text.Json.Serialization.JsonPropertyName("class")]
        public string? Class { get; init; }

        ///<summary>The method to call</summary>
        [System.Text.Json.Serialization.JsonPropertyName("method")]
        public string? Method { get; init; }
    }

    public class NotifyServices
    {
        private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
        public NotifyServices(NetDaemon.HassModel.Common.IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Sends a notification message using the hass_discord service.</summary>
        public void HassDiscord(NotifyHassDiscordParameters data)
        {
            _haContext.CallService("notify", "hass_discord", null, data);
        }

        ///<summary>Sends a notification message using the hass_discord service.</summary>
        ///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
        ///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
        ///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
        ///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
        public void HassDiscord(string @message, string? @title = null, object? @target = null, object? @data = null)
        {
            _haContext.CallService("notify", "hass_discord", null, new NotifyHassDiscordParameters { Message = @message, Title = @title, Target = @target, Data = @data });
        }

        ///<summary>Sends a notification message using the mobile_app_sm_g975f integration.</summary>
        public void MobileAppSmG975f(NotifyMobileAppSmG975fParameters data)
        {
            _haContext.CallService("notify", "mobile_app_sm_g975f", null, data);
        }

        ///<summary>Sends a notification message using the mobile_app_sm_g975f integration.</summary>
        ///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
        ///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
        ///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
        ///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
        public void MobileAppSmG975f(string @message, string? @title = null, object? @target = null, object? @data = null)
        {
            _haContext.CallService("notify", "mobile_app_sm_g975f", null, new NotifyMobileAppSmG975fParameters { Message = @message, Title = @title, Target = @target, Data = @data });
        }

        ///<summary>Sends a notification message using the mobile_app_sm_g986b integration.</summary>
        public void MobileAppSmG986b(NotifyMobileAppSmG986bParameters data)
        {
            _haContext.CallService("notify", "mobile_app_sm_g986b", null, data);
        }

        ///<summary>Sends a notification message using the mobile_app_sm_g986b integration.</summary>
        ///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
        ///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
        ///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
        ///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
        public void MobileAppSmG986b(string @message, string? @title = null, object? @target = null, object? @data = null)
        {
            _haContext.CallService("notify", "mobile_app_sm_g986b", null, new NotifyMobileAppSmG986bParameters { Message = @message, Title = @title, Target = @target, Data = @data });
        }

        ///<summary>Sends a notification message using the mobile_app_tomas_ipad integration.</summary>
        public void MobileAppTomasIpad(NotifyMobileAppTomasIpadParameters data)
        {
            _haContext.CallService("notify", "mobile_app_tomas_ipad", null, data);
        }

        ///<summary>Sends a notification message using the mobile_app_tomas_ipad integration.</summary>
        ///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
        ///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
        ///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
        ///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
        public void MobileAppTomasIpad(string @message, string? @title = null, object? @target = null, object? @data = null)
        {
            _haContext.CallService("notify", "mobile_app_tomas_ipad", null, new NotifyMobileAppTomasIpadParameters { Message = @message, Title = @title, Target = @target, Data = @data });
        }

        ///<summary>Sends a notification message using the notify service.</summary>
        public void Notify(NotifyNotifyParameters data)
        {
            _haContext.CallService("notify", "notify", null, data);
        }

        ///<summary>Sends a notification message using the notify service.</summary>
        ///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
        ///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
        ///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
        ///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
        public void Notify(string @message, string? @title = null, object? @target = null, object? @data = null)
        {
            _haContext.CallService("notify", "notify", null, new NotifyNotifyParameters { Message = @message, Title = @title, Target = @target, Data = @data });
        }

        ///<summary>Sends a notification to the visible in the front-end.</summary>
        public void PersistentNotification(NotifyPersistentNotificationParameters data)
        {
            _haContext.CallService("notify", "persistent_notification", null, data);
        }

        ///<summary>Sends a notification to the visible in the front-end.</summary>
        ///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
        ///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
        public void PersistentNotification(string @message, string? @title = null)
        {
            _haContext.CallService("notify", "persistent_notification", null, new NotifyPersistentNotificationParameters { Message = @message, Title = @title });
        }
    }

    public record NotifyHassDiscordParameters
    {
        ///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; init; }

        ///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
        [System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; init; }

        ///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
        [System.Text.Json.Serialization.JsonPropertyName("target")]
        public object? Target { get; init; }

        ///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public object? Data { get; init; }
    }

    public record NotifyMobileAppSmG975fParameters
    {
        ///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; init; }

        ///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
        [System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; init; }

        ///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
        [System.Text.Json.Serialization.JsonPropertyName("target")]
        public object? Target { get; init; }

        ///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public object? Data { get; init; }
    }

    public record NotifyMobileAppSmG986bParameters
    {
        ///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; init; }

        ///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
        [System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; init; }

        ///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
        [System.Text.Json.Serialization.JsonPropertyName("target")]
        public object? Target { get; init; }

        ///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public object? Data { get; init; }
    }

    public record NotifyMobileAppTomasIpadParameters
    {
        ///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; init; }

        ///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
        [System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; init; }

        ///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
        [System.Text.Json.Serialization.JsonPropertyName("target")]
        public object? Target { get; init; }

        ///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public object? Data { get; init; }
    }

    public record NotifyNotifyParameters
    {
        ///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; init; }

        ///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
        [System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; init; }

        ///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
        [System.Text.Json.Serialization.JsonPropertyName("target")]
        public object? Target { get; init; }

        ///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public object? Data { get; init; }
    }

    public record NotifyPersistentNotificationParameters
    {
        ///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; init; }

        ///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
        [System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; init; }
    }

    public class NumberServices
    {
        private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
        public NumberServices(NetDaemon.HassModel.Common.IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Set the value of a Number entity.</summary>
        ///<param name="target">The target for this service call</param>
        public void SetValue(NetDaemon.HassModel.Entities.ServiceTarget target, NumberSetValueParameters data)
        {
            _haContext.CallService("number", "set_value", target, data);
        }

        ///<summary>Set the value of a Number entity.</summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="value">The target value the entity should be set to. eg: 42</param>
        public void SetValue(NetDaemon.HassModel.Entities.ServiceTarget target, string? @value = null)
        {
            _haContext.CallService("number", "set_value", target, new NumberSetValueParameters { Value = @value });
        }
    }

    public record NumberSetValueParameters
    {
        ///<summary>The target value the entity should be set to. eg: 42</summary>
        [System.Text.Json.Serialization.JsonPropertyName("value")]
        public string? Value { get; init; }
    }

    public class PersistentNotificationServices
    {
        private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
        public PersistentNotificationServices(NetDaemon.HassModel.Common.IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Show a notification in the frontend.</summary>
        public void Create(PersistentNotificationCreateParameters data)
        {
            _haContext.CallService("persistent_notification", "create", null, data);
        }

        ///<summary>Show a notification in the frontend.</summary>
        ///<param name="message">Message body of the notification. [Templates accepted] eg: Please check your configuration.yaml.</param>
        ///<param name="title">Optional title for your notification. [Templates accepted] eg: Test notification</param>
        ///<param name="notificationId">Target ID of the notification, will replace a notification with the same ID. eg: 1234</param>
        public void Create(string @message, string? @title = null, string? @notificationId = null)
        {
            _haContext.CallService("persistent_notification", "create", null, new PersistentNotificationCreateParameters { Message = @message, Title = @title, NotificationId = @notificationId });
        }

        ///<summary>Remove a notification from the frontend.</summary>
        public void Dismiss(PersistentNotificationDismissParameters data)
        {
            _haContext.CallService("persistent_notification", "dismiss", null, data);
        }

        ///<summary>Remove a notification from the frontend.</summary>
        ///<param name="notificationId">Target ID of the notification, which should be removed. eg: 1234</param>
        public void Dismiss(string @notificationId)
        {
            _haContext.CallService("persistent_notification", "dismiss", null, new PersistentNotificationDismissParameters { NotificationId = @notificationId });
        }

        ///<summary>Mark a notification read.</summary>
        public void MarkRead(PersistentNotificationMarkReadParameters data)
        {
            _haContext.CallService("persistent_notification", "mark_read", null, data);
        }

        ///<summary>Mark a notification read.</summary>
        ///<param name="notificationId">Target ID of the notification, which should be mark read. eg: 1234</param>
        public void MarkRead(string @notificationId)
        {
            _haContext.CallService("persistent_notification", "mark_read", null, new PersistentNotificationMarkReadParameters { NotificationId = @notificationId });
        }
    }

    public record PersistentNotificationCreateParameters
    {
        ///<summary>Message body of the notification. [Templates accepted] eg: Please check your configuration.yaml.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; init; }

        ///<summary>Optional title for your notification. [Templates accepted] eg: Test notification</summary>
        [System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; init; }

        ///<summary>Target ID of the notification, will replace a notification with the same ID. eg: 1234</summary>
        [System.Text.Json.Serialization.JsonPropertyName("notification_id")]
        public string? NotificationId { get; init; }
    }

    public record PersistentNotificationDismissParameters
    {
        ///<summary>Target ID of the notification, which should be removed. eg: 1234</summary>
        [System.Text.Json.Serialization.JsonPropertyName("notification_id")]
        public string? NotificationId { get; init; }
    }

    public record PersistentNotificationMarkReadParameters
    {
        ///<summary>Target ID of the notification, which should be mark read. eg: 1234</summary>
        [System.Text.Json.Serialization.JsonPropertyName("notification_id")]
        public string? NotificationId { get; init; }
    }

    public class PersonServices
    {
        private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
        public PersonServices(NetDaemon.HassModel.Common.IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Reload the person configuration.</summary>
        public void Reload()
        {
            _haContext.CallService("person", "reload", null);
        }
    }

    public class PlexServices
    {
        private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
        public PlexServices(NetDaemon.HassModel.Common.IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Refresh a Plex library to scan for new and updated media.</summary>
        public void RefreshLibrary(PlexRefreshLibraryParameters data)
        {
            _haContext.CallService("plex", "refresh_library", null, data);
        }

        ///<summary>Refresh a Plex library to scan for new and updated media.</summary>
        ///<param name="serverName">Name of a Plex server if multiple Plex servers configured. eg: My Plex Server</param>
        ///<param name="libraryName">Name of the Plex library to refresh. eg: TV Shows</param>
        public void RefreshLibrary(string @libraryName, string? @serverName = null)
        {
            _haContext.CallService("plex", "refresh_library", null, new PlexRefreshLibraryParameters { ServerName = @serverName, LibraryName = @libraryName });
        }

        ///<summary>Scan for available clients from the Plex server(s), local network, and plex.tv.</summary>
        public void ScanForClients()
        {
            _haContext.CallService("plex", "scan_for_clients", null);
        }
    }

    public record PlexRefreshLibraryParameters
    {
        ///<summary>Name of a Plex server if multiple Plex servers configured. eg: My Plex Server</summary>
        [System.Text.Json.Serialization.JsonPropertyName("server_name")]
        public string? ServerName { get; init; }

        ///<summary>Name of the Plex library to refresh. eg: TV Shows</summary>
        [System.Text.Json.Serialization.JsonPropertyName("library_name")]
        public string? LibraryName { get; init; }
    }

    public class RecorderServices
    {
        private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
        public RecorderServices(NetDaemon.HassModel.Common.IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Stop the recording of events and state changes</summary>
        public void Disable()
        {
            _haContext.CallService("recorder", "disable", null);
        }

        ///<summary>Start the recording of events and state changes</summary>
        public void Enable()
        {
            _haContext.CallService("recorder", "enable", null);
        }

        ///<summary>Start purge task - to clean up old data from your database.</summary>
        public void Purge(RecorderPurgeParameters data)
        {
            _haContext.CallService("recorder", "purge", null, data);
        }

        ///<summary>Start purge task - to clean up old data from your database.</summary>
        ///<param name="keepDays">Number of history days to keep in database after purge.</param>
        ///<param name="repack">Attempt to save disk space by rewriting the entire database file.</param>
        ///<param name="applyFilter">Apply entity_id and event_type filter in addition to time based purge.</param>
        public void Purge(long? @keepDays = null, bool? @repack = null, bool? @applyFilter = null)
        {
            _haContext.CallService("recorder", "purge", null, new RecorderPurgeParameters { KeepDays = @keepDays, Repack = @repack, ApplyFilter = @applyFilter });
        }

        ///<summary>Start purge task to remove specific entities from your database.</summary>
        ///<param name="target">The target for this service call</param>
        public void PurgeEntities(NetDaemon.HassModel.Entities.ServiceTarget target, RecorderPurgeEntitiesParameters data)
        {
            _haContext.CallService("recorder", "purge_entities", target, data);
        }

        ///<summary>Start purge task to remove specific entities from your database.</summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="domains">List the domains that need to be removed from the recorder database. eg: sun</param>
        ///<param name="entityGlobs">List the regular expressions to select entities for removal from the recorder database. eg: domain*.object_id*</param>
        public void PurgeEntities(NetDaemon.HassModel.Entities.ServiceTarget target, object? @domains = null, object? @entityGlobs = null)
        {
            _haContext.CallService("recorder", "purge_entities", target, new RecorderPurgeEntitiesParameters { Domains = @domains, EntityGlobs = @entityGlobs });
        }
    }

    public record RecorderPurgeParameters
    {
        ///<summary>Number of history days to keep in database after purge.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("keep_days")]
        public long? KeepDays { get; init; }

        ///<summary>Attempt to save disk space by rewriting the entire database file.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("repack")]
        public bool? Repack { get; init; }

        ///<summary>Apply entity_id and event_type filter in addition to time based purge.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("apply_filter")]
        public bool? ApplyFilter { get; init; }
    }

    public record RecorderPurgeEntitiesParameters
    {
        ///<summary>List the domains that need to be removed from the recorder database. eg: sun</summary>
        [System.Text.Json.Serialization.JsonPropertyName("domains")]
        public object? Domains { get; init; }

        ///<summary>List the regular expressions to select entities for removal from the recorder database. eg: domain*.object_id*</summary>
        [System.Text.Json.Serialization.JsonPropertyName("entity_globs")]
        public object? EntityGlobs { get; init; }
    }

    public class RemoteServices
    {
        private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
        public RemoteServices(NetDaemon.HassModel.Common.IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Deletes a command or a list of commands from the database.</summary>
        ///<param name="target">The target for this service call</param>
        public void DeleteCommand(NetDaemon.HassModel.Entities.ServiceTarget target, RemoteDeleteCommandParameters data)
        {
            _haContext.CallService("remote", "delete_command", target, data);
        }

        ///<summary>Deletes a command or a list of commands from the database.</summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="device">Name of the device from which commands will be deleted. eg: television</param>
        ///<param name="command">A single command or a list of commands to delete. eg: Mute</param>
        public void DeleteCommand(NetDaemon.HassModel.Entities.ServiceTarget target, object @command, string? @device = null)
        {
            _haContext.CallService("remote", "delete_command", target, new RemoteDeleteCommandParameters { Device = @device, Command = @command });
        }

        ///<summary>Learns a command or a list of commands from a device.</summary>
        ///<param name="target">The target for this service call</param>
        public void LearnCommand(NetDaemon.HassModel.Entities.ServiceTarget target, RemoteLearnCommandParameters data)
        {
            _haContext.CallService("remote", "learn_command", target, data);
        }

        ///<summary>Learns a command or a list of commands from a device.</summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="device">Device ID to learn command from. eg: television</param>
        ///<param name="command">A single command or a list of commands to learn. eg: Turn on</param>
        ///<param name="commandType">The type of command to be learned.</param>
        ///<param name="alternative">If code must be stored as alternative (useful for discrete remotes).</param>
        ///<param name="timeout">Timeout for the command to be learned.</param>
        public void LearnCommand(NetDaemon.HassModel.Entities.ServiceTarget target, string? @device = null, object? @command = null, string? @commandType = null, bool? @alternative = null, long? @timeout = null)
        {
            _haContext.CallService("remote", "learn_command", target, new RemoteLearnCommandParameters { Device = @device, Command = @command, CommandType = @commandType, Alternative = @alternative, Timeout = @timeout });
        }

        ///<summary>Sends a command or a list of commands to a device.</summary>
        ///<param name="target">The target for this service call</param>
        public void SendCommand(NetDaemon.HassModel.Entities.ServiceTarget target, RemoteSendCommandParameters data)
        {
            _haContext.CallService("remote", "send_command", target, data);
        }

        ///<summary>Sends a command or a list of commands to a device.</summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="device">Device ID to send command to. eg: 32756745</param>
        ///<param name="command">A single command or a list of commands to send. eg: Play</param>
        ///<param name="numRepeats">The number of times you want to repeat the command(s).</param>
        ///<param name="delaySecs">The time you want to wait in between repeated commands.</param>
        ///<param name="holdSecs">The time you want to have it held before the release is send.</param>
        public void SendCommand(NetDaemon.HassModel.Entities.ServiceTarget target, string @command, string? @device = null, long? @numRepeats = null, double? @delaySecs = null, double? @holdSecs = null)
        {
            _haContext.CallService("remote", "send_command", target, new RemoteSendCommandParameters { Device = @device, Command = @command, NumRepeats = @numRepeats, DelaySecs = @delaySecs, HoldSecs = @holdSecs });
        }

        ///<summary>Toggles a device.</summary>
        ///<param name="target">The target for this service call</param>
        public void Toggle(NetDaemon.HassModel.Entities.ServiceTarget target)
        {
            _haContext.CallService("remote", "toggle", target);
        }

        ///<summary>Sends the Power Off Command.</summary>
        ///<param name="target">The target for this service call</param>
        public void TurnOff(NetDaemon.HassModel.Entities.ServiceTarget target)
        {
            _haContext.CallService("remote", "turn_off", target);
        }

        ///<summary>Sends the Power On Command.</summary>
        ///<param name="target">The target for this service call</param>
        public void TurnOn(NetDaemon.HassModel.Entities.ServiceTarget target, RemoteTurnOnParameters data)
        {
            _haContext.CallService("remote", "turn_on", target, data);
        }

        ///<summary>Sends the Power On Command.</summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="activity">Activity ID or Activity Name to start. eg: BedroomTV</param>
        public void TurnOn(NetDaemon.HassModel.Entities.ServiceTarget target, string? @activity = null)
        {
            _haContext.CallService("remote", "turn_on", target, new RemoteTurnOnParameters { Activity = @activity });
        }
    }

    public record RemoteDeleteCommandParameters
    {
        ///<summary>Name of the device from which commands will be deleted. eg: television</summary>
        [System.Text.Json.Serialization.JsonPropertyName("device")]
        public string? Device { get; init; }

        ///<summary>A single command or a list of commands to delete. eg: Mute</summary>
        [System.Text.Json.Serialization.JsonPropertyName("command")]
        public object? Command { get; init; }
    }

    public record RemoteLearnCommandParameters
    {
        ///<summary>Device ID to learn command from. eg: television</summary>
        [System.Text.Json.Serialization.JsonPropertyName("device")]
        public string? Device { get; init; }

        ///<summary>A single command or a list of commands to learn. eg: Turn on</summary>
        [System.Text.Json.Serialization.JsonPropertyName("command")]
        public object? Command { get; init; }

        ///<summary>The type of command to be learned.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("command_type")]
        public string? CommandType { get; init; }

        ///<summary>If code must be stored as alternative (useful for discrete remotes).</summary>
        [System.Text.Json.Serialization.JsonPropertyName("alternative")]
        public bool? Alternative { get; init; }

        ///<summary>Timeout for the command to be learned.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("timeout")]
        public long? Timeout { get; init; }
    }

    public record RemoteSendCommandParameters
    {
        ///<summary>Device ID to send command to. eg: 32756745</summary>
        [System.Text.Json.Serialization.JsonPropertyName("device")]
        public string? Device { get; init; }

        ///<summary>A single command or a list of commands to send. eg: Play</summary>
        [System.Text.Json.Serialization.JsonPropertyName("command")]
        public string? Command { get; init; }

        ///<summary>The number of times you want to repeat the command(s).</summary>
        [System.Text.Json.Serialization.JsonPropertyName("num_repeats")]
        public long? NumRepeats { get; init; }

        ///<summary>The time you want to wait in between repeated commands.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("delay_secs")]
        public double? DelaySecs { get; init; }

        ///<summary>The time you want to have it held before the release is send.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("hold_secs")]
        public double? HoldSecs { get; init; }
    }

    public record RemoteTurnOnParameters
    {
        ///<summary>Activity ID or Activity Name to start. eg: BedroomTV</summary>
        [System.Text.Json.Serialization.JsonPropertyName("activity")]
        public string? Activity { get; init; }
    }

    public class RfxtrxServices
    {
        private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
        public RfxtrxServices(NetDaemon.HassModel.Common.IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Sends a raw event on radio.</summary>
        public void Send(RfxtrxSendParameters data)
        {
            _haContext.CallService("rfxtrx", "send", null, data);
        }

        ///<summary>Sends a raw event on radio.</summary>
        ///<param name="event">A hexadecimal string to send. eg: 0b11009e00e6116202020070</param>
        public void Send(string @event)
        {
            _haContext.CallService("rfxtrx", "send", null, new RfxtrxSendParameters { Event = @event });
        }
    }

    public record RfxtrxSendParameters
    {
        ///<summary>A hexadecimal string to send. eg: 0b11009e00e6116202020070</summary>
        [System.Text.Json.Serialization.JsonPropertyName("event")]
        public string? Event { get; init; }
    }

    public class SceneServices
    {
        private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
        public SceneServices(NetDaemon.HassModel.Common.IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Activate a scene with configuration.</summary>
        public void Apply(SceneApplyParameters data)
        {
            _haContext.CallService("scene", "apply", null, data);
        }

        ///<summary>Activate a scene with configuration.</summary>
        ///<param name="entities">The entities and the state that they need to be. eg: {"light.kitchen": "on", "light.ceiling": {"state": "on", "brightness": 80}}</param>
        ///<param name="transition">Transition duration it takes to bring devices to the state defined in the scene.</param>
        public void Apply(object @entities, long? @transition = null)
        {
            _haContext.CallService("scene", "apply", null, new SceneApplyParameters { Entities = @entities, Transition = @transition });
        }

        ///<summary>Creates a new scene.</summary>
        public void Create(SceneCreateParameters data)
        {
            _haContext.CallService("scene", "create", null, data);
        }

        ///<summary>Creates a new scene.</summary>
        ///<param name="sceneId">The entity_id of the new scene. eg: all_lights</param>
        ///<param name="entities">The entities to control with the scene. eg: {"light.tv_back_light": "on", "light.ceiling": {"state": "on", "brightness": 200}}</param>
        ///<param name="snapshotEntities">The entities of which a snapshot is to be taken eg: ["light.ceiling", "light.kitchen"]</param>
        public void Create(string @sceneId, object? @entities = null, object? @snapshotEntities = null)
        {
            _haContext.CallService("scene", "create", null, new SceneCreateParameters { SceneId = @sceneId, Entities = @entities, SnapshotEntities = @snapshotEntities });
        }

        ///<summary>Reload the scene configuration.</summary>
        public void Reload()
        {
            _haContext.CallService("scene", "reload", null);
        }

        ///<summary>Activate a scene.</summary>
        ///<param name="target">The target for this service call</param>
        public void TurnOn(NetDaemon.HassModel.Entities.ServiceTarget target, SceneTurnOnParameters data)
        {
            _haContext.CallService("scene", "turn_on", target, data);
        }

        ///<summary>Activate a scene.</summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="transition">Transition duration it takes to bring devices to the state defined in the scene.</param>
        public void TurnOn(NetDaemon.HassModel.Entities.ServiceTarget target, long? @transition = null)
        {
            _haContext.CallService("scene", "turn_on", target, new SceneTurnOnParameters { Transition = @transition });
        }
    }

    public record SceneApplyParameters
    {
        ///<summary>The entities and the state that they need to be. eg: {"light.kitchen": "on", "light.ceiling": {"state": "on", "brightness": 80}}</summary>
        [System.Text.Json.Serialization.JsonPropertyName("entities")]
        public object? Entities { get; init; }

        ///<summary>Transition duration it takes to bring devices to the state defined in the scene.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("transition")]
        public long? Transition { get; init; }
    }

    public record SceneCreateParameters
    {
        ///<summary>The entity_id of the new scene. eg: all_lights</summary>
        [System.Text.Json.Serialization.JsonPropertyName("scene_id")]
        public string? SceneId { get; init; }

        ///<summary>The entities to control with the scene. eg: {"light.tv_back_light": "on", "light.ceiling": {"state": "on", "brightness": 200}}</summary>
        [System.Text.Json.Serialization.JsonPropertyName("entities")]
        public object? Entities { get; init; }

        ///<summary>The entities of which a snapshot is to be taken eg: ["light.ceiling", "light.kitchen"]</summary>
        [System.Text.Json.Serialization.JsonPropertyName("snapshot_entities")]
        public object? SnapshotEntities { get; init; }
    }

    public record SceneTurnOnParameters
    {
        ///<summary>Transition duration it takes to bring devices to the state defined in the scene.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("transition")]
        public long? Transition { get; init; }
    }

    public class ScriptServices
    {
        private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
        public ScriptServices(NetDaemon.HassModel.Common.IHaContext haContext)
        {
            _haContext = haContext;
        }

        public void HA1586350051032()
        {
            _haContext.CallService("script", "1586350051032", null);
        }

        public void CleaningScene()
        {
            _haContext.CallService("script", "cleaning_scene", null);
        }

        public void ColorScene()
        {
            _haContext.CallService("script", "color_scene", null);
        }

        public void DayScene()
        {
            _haContext.CallService("script", "day_scene", null);
        }

        public void EveningScene()
        {
            _haContext.CallService("script", "evening_scene", null);
        }

        public void FilmScene()
        {
            _haContext.CallService("script", "film_scene", null);
        }

        public void MorningScene()
        {
            _haContext.CallService("script", "morning_scene", null);
        }

        public void NightScene()
        {
            _haContext.CallService("script", "night_scene", null);
        }

        public void Notify()
        {
            _haContext.CallService("script", "notify", null);
        }

        public void NotifyGreet()
        {
            _haContext.CallService("script", "notify_greet", null);
        }

        ///<summary>Reload all the available scripts</summary>
        public void Reload()
        {
            _haContext.CallService("script", "reload", null);
        }

        public void Setnightmode()
        {
            _haContext.CallService("script", "setnightmode", null);
        }

        ///<summary>Toggle script</summary>
        ///<param name="target">The target for this service call</param>
        public void Toggle(NetDaemon.HassModel.Entities.ServiceTarget target)
        {
            _haContext.CallService("script", "toggle", target);
        }

        ///<summary>Turn off script</summary>
        ///<param name="target">The target for this service call</param>
        public void TurnOff(NetDaemon.HassModel.Entities.ServiceTarget target)
        {
            _haContext.CallService("script", "turn_off", target);
        }

        ///<summary>Turn on script</summary>
        ///<param name="target">The target for this service call</param>
        public void TurnOn(NetDaemon.HassModel.Entities.ServiceTarget target)
        {
            _haContext.CallService("script", "turn_on", target);
        }

        public void TvOffScene()
        {
            _haContext.CallService("script", "tv_off_scene", null);
        }

        public void TvScene()
        {
            _haContext.CallService("script", "tv_scene", null);
        }

        public void Zigbee2mqttRemove()
        {
            _haContext.CallService("script", "zigbee2mqtt_remove", null);
        }

        public void Zigbee2mqttRename()
        {
            _haContext.CallService("script", "zigbee2mqtt_rename", null);
        }
    }

    public class SelectServices
    {
        private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
        public SelectServices(NetDaemon.HassModel.Common.IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Select an option of an select entity.</summary>
        ///<param name="target">The target for this service call</param>
        public void SelectOption(NetDaemon.HassModel.Entities.ServiceTarget target, SelectSelectOptionParameters data)
        {
            _haContext.CallService("select", "select_option", target, data);
        }

        ///<summary>Select an option of an select entity.</summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="option">Option to be selected. eg: "Item A"</param>
        public void SelectOption(NetDaemon.HassModel.Entities.ServiceTarget target, string @option)
        {
            _haContext.CallService("select", "select_option", target, new SelectSelectOptionParameters { Option = @option });
        }
    }

    public record SelectSelectOptionParameters
    {
        ///<summary>Option to be selected. eg: "Item A"</summary>
        [System.Text.Json.Serialization.JsonPropertyName("option")]
        public string? Option { get; init; }
    }

    public class SwitchServices
    {
        private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
        public SwitchServices(NetDaemon.HassModel.Common.IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Toggles a switch state</summary>
        ///<param name="target">The target for this service call</param>
        public void Toggle(NetDaemon.HassModel.Entities.ServiceTarget target)
        {
            _haContext.CallService("switch", "toggle", target);
        }

        ///<summary>Turn a switch off</summary>
        ///<param name="target">The target for this service call</param>
        public void TurnOff(NetDaemon.HassModel.Entities.ServiceTarget target)
        {
            _haContext.CallService("switch", "turn_off", target);
        }

        ///<summary>Turn a switch on</summary>
        ///<param name="target">The target for this service call</param>
        public void TurnOn(NetDaemon.HassModel.Entities.ServiceTarget target)
        {
            _haContext.CallService("switch", "turn_on", target);
        }
    }

    public class SystemLogServices
    {
        private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
        public SystemLogServices(NetDaemon.HassModel.Common.IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Clear all log entries.</summary>
        public void Clear()
        {
            _haContext.CallService("system_log", "clear", null);
        }

        ///<summary>Write log entry.</summary>
        public void Write(SystemLogWriteParameters data)
        {
            _haContext.CallService("system_log", "write", null, data);
        }

        ///<summary>Write log entry.</summary>
        ///<param name="message">Message to log. eg: Something went wrong</param>
        ///<param name="level">Log level.</param>
        ///<param name="logger">Logger name under which to log the message. Defaults to 'system_log.external'. eg: mycomponent.myplatform</param>
        public void Write(string @message, string? @level = null, string? @logger = null)
        {
            _haContext.CallService("system_log", "write", null, new SystemLogWriteParameters { Message = @message, Level = @level, Logger = @logger });
        }
    }

    public record SystemLogWriteParameters
    {
        ///<summary>Message to log. eg: Something went wrong</summary>
        [System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; init; }

        ///<summary>Log level.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("level")]
        public string? Level { get; init; }

        ///<summary>Logger name under which to log the message. Defaults to 'system_log.external'. eg: mycomponent.myplatform</summary>
        [System.Text.Json.Serialization.JsonPropertyName("logger")]
        public string? Logger { get; init; }
    }

    public class TemplateServices
    {
        private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
        public TemplateServices(NetDaemon.HassModel.Common.IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Reload all template entities.</summary>
        public void Reload()
        {
            _haContext.CallService("template", "reload", null);
        }
    }

    public class TimerServices
    {
        private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
        public TimerServices(NetDaemon.HassModel.Common.IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Cancel a timer.</summary>
        ///<param name="target">The target for this service call</param>
        public void Cancel(NetDaemon.HassModel.Entities.ServiceTarget target)
        {
            _haContext.CallService("timer", "cancel", target);
        }

        ///<summary>Finish a timer.</summary>
        ///<param name="target">The target for this service call</param>
        public void Finish(NetDaemon.HassModel.Entities.ServiceTarget target)
        {
            _haContext.CallService("timer", "finish", target);
        }

        ///<summary>Pause a timer.</summary>
        ///<param name="target">The target for this service call</param>
        public void Pause(NetDaemon.HassModel.Entities.ServiceTarget target)
        {
            _haContext.CallService("timer", "pause", target);
        }

        public void Reload()
        {
            _haContext.CallService("timer", "reload", null);
        }

        ///<summary>Start a timer</summary>
        ///<param name="target">The target for this service call</param>
        public void Start(NetDaemon.HassModel.Entities.ServiceTarget target, TimerStartParameters data)
        {
            _haContext.CallService("timer", "start", target, data);
        }

        ///<summary>Start a timer</summary>
        ///<param name="target">The target for this service call</param>
        ///<param name="duration">Duration the timer requires to finish. [optional] eg: 00:01:00 or 60</param>
        public void Start(NetDaemon.HassModel.Entities.ServiceTarget target, string? @duration = null)
        {
            _haContext.CallService("timer", "start", target, new TimerStartParameters { Duration = @duration });
        }
    }

    public record TimerStartParameters
    {
        ///<summary>Duration the timer requires to finish. [optional] eg: 00:01:00 or 60</summary>
        [System.Text.Json.Serialization.JsonPropertyName("duration")]
        public string? Duration { get; init; }
    }

    public class TtsServices
    {
        private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
        public TtsServices(NetDaemon.HassModel.Common.IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Remove all text-to-speech cache files and RAM cache.</summary>
        public void ClearCache()
        {
            _haContext.CallService("tts", "clear_cache", null);
        }

        ///<summary>Say something using text-to-speech on a media player with google_translate.</summary>
        public void GoogleCloudSay(TtsGoogleCloudSayParameters data)
        {
            _haContext.CallService("tts", "google_cloud_say", null, data);
        }

        ///<summary>Say something using text-to-speech on a media player with google_translate.</summary>
        ///<param name="entityId">Name(s) of media player entities.</param>
        ///<param name="message">Text to speak on devices. eg: My name is hanna</param>
        ///<param name="cache">Control file cache of this message.</param>
        ///<param name="language">Language to use for speech generation. eg: ru</param>
        ///<param name="options">A dictionary containing platform-specific options. Optional depending on the platform. eg: platform specific</param>
        public void GoogleCloudSay(string @entityId, string @message, bool? @cache = null, string? @language = null, object? @options = null)
        {
            _haContext.CallService("tts", "google_cloud_say", null, new TtsGoogleCloudSayParameters { EntityId = @entityId, Message = @message, Cache = @cache, Language = @language, Options = @options });
        }
    }

    public record TtsGoogleCloudSayParameters
    {
        ///<summary>Name(s) of media player entities.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("entity_id")]
        public string? EntityId { get; init; }

        ///<summary>Text to speak on devices. eg: My name is hanna</summary>
        [System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; init; }

        ///<summary>Control file cache of this message.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("cache")]
        public bool? Cache { get; init; }

        ///<summary>Language to use for speech generation. eg: ru</summary>
        [System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; init; }

        ///<summary>A dictionary containing platform-specific options. Optional depending on the platform. eg: platform specific</summary>
        [System.Text.Json.Serialization.JsonPropertyName("options")]
        public object? Options { get; init; }
    }

    public class ZoneServices
    {
        private readonly NetDaemon.HassModel.Common.IHaContext _haContext;
        public ZoneServices(NetDaemon.HassModel.Common.IHaContext haContext)
        {
            _haContext = haContext;
        }

        ///<summary>Reload the YAML-based zone configuration.</summary>
        public void Reload()
        {
            _haContext.CallService("zone", "reload", null);
        }
    }

    public static class AndroidtvEntityExtensionMethods
    {
        ///<summary>Translate a key press on a remote into ADB 'sendevent' commands.  You must press one button on the remote within 8 seconds of calling this service.</summary>
        public static void LearnSendevent(this MediaPlayerEntity entity)
        {
            entity.CallService("learn_sendevent");
        }
    }

    public static class AutomationEntityExtensionMethods
    {
        ///<summary>Toggle (enable / disable) an automation.</summary>
        public static void Toggle(this AutomationEntity entity)
        {
            entity.CallService("toggle");
        }

        ///<summary>Trigger the actions of an automation.</summary>
        public static void Trigger(this AutomationEntity entity, AutomationTriggerParameters data)
        {
            entity.CallService("trigger", data);
        }

        ///<summary>Trigger the actions of an automation.</summary>
        ///<param name="entity">The AutomationEntity to call this service for</param>
        ///<param name="skipCondition">Whether or not the conditions will be skipped.</param>
        public static void Trigger(this AutomationEntity entity, bool? @skipCondition = null)
        {
            entity.CallService("trigger", new AutomationTriggerParameters { SkipCondition = @skipCondition });
        }

        ///<summary>Disable an automation.</summary>
        public static void TurnOff(this AutomationEntity entity, AutomationTurnOffParameters data)
        {
            entity.CallService("turn_off", data);
        }

        ///<summary>Disable an automation.</summary>
        ///<param name="entity">The AutomationEntity to call this service for</param>
        ///<param name="stopActions">Stop currently running actions.</param>
        public static void TurnOff(this AutomationEntity entity, bool? @stopActions = null)
        {
            entity.CallService("turn_off", new AutomationTurnOffParameters { StopActions = @stopActions });
        }

        ///<summary>Enable an automation.</summary>
        public static void TurnOn(this AutomationEntity entity)
        {
            entity.CallService("turn_on");
        }
    }

    public static class ButtonEntityExtensionMethods
    {
        ///<summary>Press the button entity.</summary>
        public static void Press(this ButtonEntity entity)
        {
            entity.CallService("press");
        }
    }

    public static class CameraEntityExtensionMethods
    {
        ///<summary>Disable the motion detection in a camera.</summary>
        public static void DisableMotionDetection(this CameraEntity entity)
        {
            entity.CallService("disable_motion_detection");
        }

        ///<summary>Enable the motion detection in a camera.</summary>
        public static void EnableMotionDetection(this CameraEntity entity)
        {
            entity.CallService("enable_motion_detection");
        }

        ///<summary>Play camera stream on supported media player.</summary>
        public static void PlayStream(this CameraEntity entity, CameraPlayStreamParameters data)
        {
            entity.CallService("play_stream", data);
        }

        ///<summary>Play camera stream on supported media player.</summary>
        ///<param name="entity">The CameraEntity to call this service for</param>
        ///<param name="mediaPlayer">Name(s) of media player to stream to.</param>
        ///<param name="format">Stream format supported by media player.</param>
        public static void PlayStream(this CameraEntity entity, string @mediaPlayer, string? @format = null)
        {
            entity.CallService("play_stream", new CameraPlayStreamParameters { MediaPlayer = @mediaPlayer, Format = @format });
        }

        ///<summary>Record live camera feed.</summary>
        public static void Record(this CameraEntity entity, CameraRecordParameters data)
        {
            entity.CallService("record", data);
        }

        ///<summary>Record live camera feed.</summary>
        ///<param name="entity">The CameraEntity to call this service for</param>
        ///<param name="filename">Template of a Filename. Variable is entity_id. Must be mp4. eg: /tmp/snapshot_{{ entity_id.name }}.mp4</param>
        ///<param name="duration">Target recording length.</param>
        ///<param name="lookback">Target lookback period to include in addition to duration. Only available if there is currently an active HLS stream.</param>
        public static void Record(this CameraEntity entity, string @filename, long? @duration = null, long? @lookback = null)
        {
            entity.CallService("record", new CameraRecordParameters { Filename = @filename, Duration = @duration, Lookback = @lookback });
        }

        ///<summary>Take a snapshot from a camera.</summary>
        public static void Snapshot(this CameraEntity entity, CameraSnapshotParameters data)
        {
            entity.CallService("snapshot", data);
        }

        ///<summary>Take a snapshot from a camera.</summary>
        ///<param name="entity">The CameraEntity to call this service for</param>
        ///<param name="filename">Template of a Filename. Variable is entity_id. eg: /tmp/snapshot_{{ entity_id.name }}.jpg</param>
        public static void Snapshot(this CameraEntity entity, string @filename)
        {
            entity.CallService("snapshot", new CameraSnapshotParameters { Filename = @filename });
        }

        ///<summary>Turn off camera.</summary>
        public static void TurnOff(this CameraEntity entity)
        {
            entity.CallService("turn_off");
        }

        ///<summary>Turn on camera.</summary>
        public static void TurnOn(this CameraEntity entity)
        {
            entity.CallService("turn_on");
        }
    }

    public static class CoverEntityExtensionMethods
    {
        ///<summary>Close all or specified cover.</summary>
        public static void CloseCover(this CoverEntity entity)
        {
            entity.CallService("close_cover");
        }

        ///<summary>Close all or specified cover tilt.</summary>
        public static void CloseCoverTilt(this CoverEntity entity)
        {
            entity.CallService("close_cover_tilt");
        }

        ///<summary>Open all or specified cover.</summary>
        public static void OpenCover(this CoverEntity entity)
        {
            entity.CallService("open_cover");
        }

        ///<summary>Open all or specified cover tilt.</summary>
        public static void OpenCoverTilt(this CoverEntity entity)
        {
            entity.CallService("open_cover_tilt");
        }

        ///<summary>Move to specific position all or specified cover.</summary>
        public static void SetCoverPosition(this CoverEntity entity, CoverSetCoverPositionParameters data)
        {
            entity.CallService("set_cover_position", data);
        }

        ///<summary>Move to specific position all or specified cover.</summary>
        ///<param name="entity">The CoverEntity to call this service for</param>
        ///<param name="position">Position of the cover</param>
        public static void SetCoverPosition(this CoverEntity entity, long @position)
        {
            entity.CallService("set_cover_position", new CoverSetCoverPositionParameters { Position = @position });
        }

        ///<summary>Move to specific position all or specified cover tilt.</summary>
        public static void SetCoverTiltPosition(this CoverEntity entity, CoverSetCoverTiltPositionParameters data)
        {
            entity.CallService("set_cover_tilt_position", data);
        }

        ///<summary>Move to specific position all or specified cover tilt.</summary>
        ///<param name="entity">The CoverEntity to call this service for</param>
        ///<param name="tiltPosition">Tilt position of the cover.</param>
        public static void SetCoverTiltPosition(this CoverEntity entity, long @tiltPosition)
        {
            entity.CallService("set_cover_tilt_position", new CoverSetCoverTiltPositionParameters { TiltPosition = @tiltPosition });
        }

        ///<summary>Stop all or specified cover.</summary>
        public static void StopCover(this CoverEntity entity)
        {
            entity.CallService("stop_cover");
        }

        ///<summary>Stop all or specified cover.</summary>
        public static void StopCoverTilt(this CoverEntity entity)
        {
            entity.CallService("stop_cover_tilt");
        }

        ///<summary>Toggle a cover open/closed.</summary>
        public static void Toggle(this CoverEntity entity)
        {
            entity.CallService("toggle");
        }

        ///<summary>Toggle a cover tilt open/closed.</summary>
        public static void ToggleCoverTilt(this CoverEntity entity)
        {
            entity.CallService("toggle_cover_tilt");
        }
    }

    public static class ElgatoEntityExtensionMethods
    {
        ///<summary>Identify an Elgato Light. Blinks the light, which can be useful for, e.g., a visual notification.</summary>
        public static void Identify(this LightEntity entity)
        {
            entity.CallService("identify");
        }
    }

    public static class HarmonyEntityExtensionMethods
    {
        ///<summary>Sends change channel command to the Harmony HUB</summary>
        public static void ChangeChannel(this RemoteEntity entity, HarmonyChangeChannelParameters data)
        {
            entity.CallService("change_channel", data);
        }

        ///<summary>Sends change channel command to the Harmony HUB</summary>
        ///<param name="entity">The RemoteEntity to call this service for</param>
        ///<param name="channel">Channel number to change to</param>
        public static void ChangeChannel(this RemoteEntity entity, long @channel)
        {
            entity.CallService("change_channel", new HarmonyChangeChannelParameters { Channel = @channel });
        }

        ///<summary>Syncs the remote's configuration.</summary>
        public static void Sync(this RemoteEntity entity)
        {
            entity.CallService("sync");
        }
    }

    public static class InputBooleanEntityExtensionMethods
    {
        ///<summary>Toggle an input boolean</summary>
        public static void Toggle(this InputBooleanEntity entity)
        {
            entity.CallService("toggle");
        }

        ///<summary>Turn off an input boolean</summary>
        public static void TurnOff(this InputBooleanEntity entity)
        {
            entity.CallService("turn_off");
        }

        ///<summary>Turn on an input boolean</summary>
        public static void TurnOn(this InputBooleanEntity entity)
        {
            entity.CallService("turn_on");
        }
    }

    public static class InputNumberEntityExtensionMethods
    {
        ///<summary>Decrement the value of an input number entity by its stepping.</summary>
        public static void Decrement(this InputNumberEntity entity)
        {
            entity.CallService("decrement");
        }

        ///<summary>Increment the value of an input number entity by its stepping.</summary>
        public static void Increment(this InputNumberEntity entity)
        {
            entity.CallService("increment");
        }

        ///<summary>Set the value of an input number entity.</summary>
        public static void SetValue(this InputNumberEntity entity, InputNumberSetValueParameters data)
        {
            entity.CallService("set_value", data);
        }

        ///<summary>Set the value of an input number entity.</summary>
        ///<param name="entity">The InputNumberEntity to call this service for</param>
        ///<param name="value">The target value the entity should be set to.</param>
        public static void SetValue(this InputNumberEntity entity, double @value)
        {
            entity.CallService("set_value", new InputNumberSetValueParameters { Value = @value });
        }
    }

    public static class InputSelectEntityExtensionMethods
    {
        ///<summary>Select the first option of an input select entity.</summary>
        public static void SelectFirst(this InputSelectEntity entity)
        {
            entity.CallService("select_first");
        }

        ///<summary>Select the last option of an input select entity.</summary>
        public static void SelectLast(this InputSelectEntity entity)
        {
            entity.CallService("select_last");
        }

        ///<summary>Select the next options of an input select entity.</summary>
        public static void SelectNext(this InputSelectEntity entity, InputSelectSelectNextParameters data)
        {
            entity.CallService("select_next", data);
        }

        ///<summary>Select the next options of an input select entity.</summary>
        ///<param name="entity">The InputSelectEntity to call this service for</param>
        ///<param name="cycle">If the option should cycle from the last to the first.</param>
        public static void SelectNext(this InputSelectEntity entity, bool? @cycle = null)
        {
            entity.CallService("select_next", new InputSelectSelectNextParameters { Cycle = @cycle });
        }

        ///<summary>Select an option of an input select entity.</summary>
        public static void SelectOption(this InputSelectEntity entity, InputSelectSelectOptionParameters data)
        {
            entity.CallService("select_option", data);
        }

        ///<summary>Select an option of an input select entity.</summary>
        ///<param name="entity">The InputSelectEntity to call this service for</param>
        ///<param name="option">Option to be selected. eg: "Item A"</param>
        public static void SelectOption(this InputSelectEntity entity, string @option)
        {
            entity.CallService("select_option", new InputSelectSelectOptionParameters { Option = @option });
        }

        ///<summary>Select the previous options of an input select entity.</summary>
        public static void SelectPrevious(this InputSelectEntity entity, InputSelectSelectPreviousParameters data)
        {
            entity.CallService("select_previous", data);
        }

        ///<summary>Select the previous options of an input select entity.</summary>
        ///<param name="entity">The InputSelectEntity to call this service for</param>
        ///<param name="cycle">If the option should cycle from the first to the last.</param>
        public static void SelectPrevious(this InputSelectEntity entity, bool? @cycle = null)
        {
            entity.CallService("select_previous", new InputSelectSelectPreviousParameters { Cycle = @cycle });
        }

        ///<summary>Set the options of an input select entity.</summary>
        public static void SetOptions(this InputSelectEntity entity, InputSelectSetOptionsParameters data)
        {
            entity.CallService("set_options", data);
        }

        ///<summary>Set the options of an input select entity.</summary>
        ///<param name="entity">The InputSelectEntity to call this service for</param>
        ///<param name="options">Options for the input select entity. eg: ["Item A", "Item B", "Item C"]</param>
        public static void SetOptions(this InputSelectEntity entity, object @options)
        {
            entity.CallService("set_options", new InputSelectSetOptionsParameters { Options = @options });
        }
    }

    public static class InputTextEntityExtensionMethods
    {
        ///<summary>Set the value of an input text entity.</summary>
        public static void SetValue(this InputTextEntity entity, InputTextSetValueParameters data)
        {
            entity.CallService("set_value", data);
        }

        ///<summary>Set the value of an input text entity.</summary>
        ///<param name="entity">The InputTextEntity to call this service for</param>
        ///<param name="value">The target value the entity should be set to. eg: This is an example text</param>
        public static void SetValue(this InputTextEntity entity, string @value)
        {
            entity.CallService("set_value", new InputTextSetValueParameters { Value = @value });
        }
    }

    public static class LightEntityExtensionMethods
    {
        ///<summary>Toggles one or more lights, from on to off, or, off to on, based on their current state. </summary>
        public static void Toggle(this LightEntity entity, LightToggleParameters data)
        {
            entity.CallService("toggle", data);
        }

        ///<summary>Toggles one or more lights, from on to off, or, off to on, based on their current state. </summary>
        ///<param name="entity">The LightEntity to call this service for</param>
        ///<param name="transition">Duration it takes to get to next state.</param>
        ///<param name="rgbColor">Color for the light in RGB-format. eg: [255, 100, 100]</param>
        ///<param name="colorName">A human readable color name.</param>
        ///<param name="hsColor">Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</param>
        ///<param name="xyColor">Color for the light in XY-format. eg: [0.52, 0.43]</param>
        ///<param name="colorTemp">Color temperature for the light in mireds.</param>
        ///<param name="kelvin">Color temperature for the light in Kelvin.</param>
        ///<param name="whiteValue">Number indicating level of white.</param>
        ///<param name="brightness">Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
        ///<param name="brightnessPct">Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and 100 is the maximum brightness supported by the light.</param>
        ///<param name="profile">Name of a light profile to use. eg: relax</param>
        ///<param name="flash">If the light should flash.</param>
        ///<param name="effect">Light effect.</param>
        public static void Toggle(this LightEntity entity, long? @transition = null, object? @rgbColor = null, string? @colorName = null, object? @hsColor = null, object? @xyColor = null, long? @colorTemp = null, long? @kelvin = null, long? @whiteValue = null, long? @brightness = null, long? @brightnessPct = null, string? @profile = null, string? @flash = null, string? @effect = null)
        {
            entity.CallService("toggle", new LightToggleParameters { Transition = @transition, RgbColor = @rgbColor, ColorName = @colorName, HsColor = @hsColor, XyColor = @xyColor, ColorTemp = @colorTemp, Kelvin = @kelvin, WhiteValue = @whiteValue, Brightness = @brightness, BrightnessPct = @brightnessPct, Profile = @profile, Flash = @flash, Effect = @effect });
        }

        ///<summary>Turns off one or more lights.</summary>
        public static void TurnOff(this LightEntity entity, LightTurnOffParameters data)
        {
            entity.CallService("turn_off", data);
        }

        ///<summary>Turns off one or more lights.</summary>
        ///<param name="entity">The LightEntity to call this service for</param>
        ///<param name="transition">Duration it takes to get to next state.</param>
        ///<param name="flash">If the light should flash.</param>
        public static void TurnOff(this LightEntity entity, long? @transition = null, string? @flash = null)
        {
            entity.CallService("turn_off", new LightTurnOffParameters { Transition = @transition, Flash = @flash });
        }

        ///<summary>Turn on one or more lights and adjust properties of the light, even when they are turned on already. </summary>
        public static void TurnOn(this LightEntity entity, LightTurnOnParameters data)
        {
            entity.CallService("turn_on", data);
        }

        ///<summary>Turn on one or more lights and adjust properties of the light, even when they are turned on already. </summary>
        ///<param name="entity">The LightEntity to call this service for</param>
        ///<param name="transition">Duration it takes to get to next state.</param>
        ///<param name="rgbColor">A list containing three integers between 0 and 255 representing the RGB (red, green, blue) color for the light. eg: [255, 100, 100]</param>
        ///<param name="rgbwColor">A list containing four integers between 0 and 255 representing the RGBW (red, green, blue, white) color for the light. eg: [255, 100, 100, 50]</param>
        ///<param name="rgbwwColor">A list containing five integers between 0 and 255 representing the RGBWW (red, green, blue, cold white, warm white) color for the light. eg: [255, 100, 100, 50, 70]</param>
        ///<param name="colorName">A human readable color name.</param>
        ///<param name="hsColor">Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</param>
        ///<param name="xyColor">Color for the light in XY-format. eg: [0.52, 0.43]</param>
        ///<param name="colorTemp">Color temperature for the light in mireds.</param>
        ///<param name="kelvin">Color temperature for the light in Kelvin.</param>
        ///<param name="brightness">Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
        ///<param name="brightnessPct">Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and 100 is the maximum brightness supported by the light.</param>
        ///<param name="brightnessStep">Change brightness by an amount.</param>
        ///<param name="brightnessStepPct">Change brightness by a percentage.</param>
        ///<param name="white">Set the light to white mode and change its brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
        ///<param name="profile">Name of a light profile to use. eg: relax</param>
        ///<param name="flash">If the light should flash.</param>
        ///<param name="effect">Light effect.</param>
        public static void TurnOn(this LightEntity entity, long? @transition = null, object? @rgbColor = null, object? @rgbwColor = null, object? @rgbwwColor = null, string? @colorName = null, object? @hsColor = null, object? @xyColor = null, long? @colorTemp = null, long? @kelvin = null, long? @brightness = null, long? @brightnessPct = null, long? @brightnessStep = null, long? @brightnessStepPct = null, long? @white = null, string? @profile = null, string? @flash = null, string? @effect = null)
        {
            entity.CallService("turn_on", new LightTurnOnParameters { Transition = @transition, RgbColor = @rgbColor, RgbwColor = @rgbwColor, RgbwwColor = @rgbwwColor, ColorName = @colorName, HsColor = @hsColor, XyColor = @xyColor, ColorTemp = @colorTemp, Kelvin = @kelvin, Brightness = @brightness, BrightnessPct = @brightnessPct, BrightnessStep = @brightnessStep, BrightnessStepPct = @brightnessStepPct, White = @white, Profile = @profile, Flash = @flash, Effect = @effect });
        }
    }

    public static class LockEntityExtensionMethods
    {
        ///<summary>Lock all or specified locks.</summary>
        public static void Lock(this LockEntity entity, LockLockParameters data)
        {
            entity.CallService("lock", data);
        }

        ///<summary>Lock all or specified locks.</summary>
        ///<param name="entity">The LockEntity to call this service for</param>
        ///<param name="code">An optional code to lock the lock with. eg: 1234</param>
        public static void Lock(this LockEntity entity, string? @code = null)
        {
            entity.CallService("lock", new LockLockParameters { Code = @code });
        }

        ///<summary>Open all or specified locks.</summary>
        public static void Open(this LockEntity entity, LockOpenParameters data)
        {
            entity.CallService("open", data);
        }

        ///<summary>Open all or specified locks.</summary>
        ///<param name="entity">The LockEntity to call this service for</param>
        ///<param name="code">An optional code to open the lock with. eg: 1234</param>
        public static void Open(this LockEntity entity, string? @code = null)
        {
            entity.CallService("open", new LockOpenParameters { Code = @code });
        }

        ///<summary>Unlock all or specified locks.</summary>
        public static void Unlock(this LockEntity entity, LockUnlockParameters data)
        {
            entity.CallService("unlock", data);
        }

        ///<summary>Unlock all or specified locks.</summary>
        ///<param name="entity">The LockEntity to call this service for</param>
        ///<param name="code">An optional code to unlock the lock with. eg: 1234</param>
        public static void Unlock(this LockEntity entity, string? @code = null)
        {
            entity.CallService("unlock", new LockUnlockParameters { Code = @code });
        }
    }

    public static class MediaPlayerEntityExtensionMethods
    {
        ///<summary>Send the media player the command to clear players playlist.</summary>
        public static void ClearPlaylist(this MediaPlayerEntity entity)
        {
            entity.CallService("clear_playlist");
        }

        ///<summary>Group players together. Only works on platforms with support for player groups.</summary>
        public static void Join(this MediaPlayerEntity entity, MediaPlayerJoinParameters data)
        {
            entity.CallService("join", data);
        }

        ///<summary>Group players together. Only works on platforms with support for player groups.</summary>
        ///<param name="entity">The MediaPlayerEntity to call this service for</param>
        ///<param name="groupMembers">The players which will be synced with the target player. eg: ["media_player.multiroom_player2", "media_player.multiroom_player3"]</param>
        public static void Join(this MediaPlayerEntity entity, object? @groupMembers = null)
        {
            entity.CallService("join", new MediaPlayerJoinParameters { GroupMembers = @groupMembers });
        }

        ///<summary>Send the media player the command for next track.</summary>
        public static void MediaNextTrack(this MediaPlayerEntity entity)
        {
            entity.CallService("media_next_track");
        }

        ///<summary>Send the media player the command for pause.</summary>
        public static void MediaPause(this MediaPlayerEntity entity)
        {
            entity.CallService("media_pause");
        }

        ///<summary>Send the media player the command for play.</summary>
        public static void MediaPlay(this MediaPlayerEntity entity)
        {
            entity.CallService("media_play");
        }

        ///<summary>Toggle media player play/pause state.</summary>
        public static void MediaPlayPause(this MediaPlayerEntity entity)
        {
            entity.CallService("media_play_pause");
        }

        ///<summary>Send the media player the command for previous track.</summary>
        public static void MediaPreviousTrack(this MediaPlayerEntity entity)
        {
            entity.CallService("media_previous_track");
        }

        ///<summary>Send the media player the command to seek in current playing media.</summary>
        public static void MediaSeek(this MediaPlayerEntity entity, MediaPlayerMediaSeekParameters data)
        {
            entity.CallService("media_seek", data);
        }

        ///<summary>Send the media player the command to seek in current playing media.</summary>
        ///<param name="entity">The MediaPlayerEntity to call this service for</param>
        ///<param name="seekPosition">Position to seek to. The format is platform dependent.</param>
        public static void MediaSeek(this MediaPlayerEntity entity, double @seekPosition)
        {
            entity.CallService("media_seek", new MediaPlayerMediaSeekParameters { SeekPosition = @seekPosition });
        }

        ///<summary>Send the media player the stop command.</summary>
        public static void MediaStop(this MediaPlayerEntity entity)
        {
            entity.CallService("media_stop");
        }

        ///<summary>Send the media player the command for playing media.</summary>
        public static void PlayMedia(this MediaPlayerEntity entity, MediaPlayerPlayMediaParameters data)
        {
            entity.CallService("play_media", data);
        }

        ///<summary>Send the media player the command for playing media.</summary>
        ///<param name="entity">The MediaPlayerEntity to call this service for</param>
        ///<param name="mediaContentId">The ID of the content to play. Platform dependent. eg: https://home-assistant.io/images/cast/splash.png</param>
        ///<param name="mediaContentType">The type of the content to play. Like image, music, tvshow, video, episode, channel or playlist. eg: music</param>
        public static void PlayMedia(this MediaPlayerEntity entity, string @mediaContentId, string @mediaContentType)
        {
            entity.CallService("play_media", new MediaPlayerPlayMediaParameters { MediaContentId = @mediaContentId, MediaContentType = @mediaContentType });
        }

        ///<summary>Set repeat mode</summary>
        public static void RepeatSet(this MediaPlayerEntity entity, MediaPlayerRepeatSetParameters data)
        {
            entity.CallService("repeat_set", data);
        }

        ///<summary>Set repeat mode</summary>
        ///<param name="entity">The MediaPlayerEntity to call this service for</param>
        ///<param name="repeat">Repeat mode to set.</param>
        public static void RepeatSet(this MediaPlayerEntity entity, string @repeat)
        {
            entity.CallService("repeat_set", new MediaPlayerRepeatSetParameters { Repeat = @repeat });
        }

        ///<summary>Send the media player the command to change sound mode.</summary>
        public static void SelectSoundMode(this MediaPlayerEntity entity, MediaPlayerSelectSoundModeParameters data)
        {
            entity.CallService("select_sound_mode", data);
        }

        ///<summary>Send the media player the command to change sound mode.</summary>
        ///<param name="entity">The MediaPlayerEntity to call this service for</param>
        ///<param name="soundMode">Name of the sound mode to switch to. eg: Music</param>
        public static void SelectSoundMode(this MediaPlayerEntity entity, string? @soundMode = null)
        {
            entity.CallService("select_sound_mode", new MediaPlayerSelectSoundModeParameters { SoundMode = @soundMode });
        }

        ///<summary>Send the media player the command to change input source.</summary>
        public static void SelectSource(this MediaPlayerEntity entity, MediaPlayerSelectSourceParameters data)
        {
            entity.CallService("select_source", data);
        }

        ///<summary>Send the media player the command to change input source.</summary>
        ///<param name="entity">The MediaPlayerEntity to call this service for</param>
        ///<param name="source">Name of the source to switch to. Platform dependent. eg: video1</param>
        public static void SelectSource(this MediaPlayerEntity entity, string @source)
        {
            entity.CallService("select_source", new MediaPlayerSelectSourceParameters { Source = @source });
        }

        ///<summary>Set shuffling state.</summary>
        public static void ShuffleSet(this MediaPlayerEntity entity, MediaPlayerShuffleSetParameters data)
        {
            entity.CallService("shuffle_set", data);
        }

        ///<summary>Set shuffling state.</summary>
        ///<param name="entity">The MediaPlayerEntity to call this service for</param>
        ///<param name="shuffle">True/false for enabling/disabling shuffle.</param>
        public static void ShuffleSet(this MediaPlayerEntity entity, bool @shuffle)
        {
            entity.CallService("shuffle_set", new MediaPlayerShuffleSetParameters { Shuffle = @shuffle });
        }

        ///<summary>Toggles a media player power state.</summary>
        public static void Toggle(this MediaPlayerEntity entity)
        {
            entity.CallService("toggle");
        }

        ///<summary>Turn a media player power off.</summary>
        public static void TurnOff(this MediaPlayerEntity entity)
        {
            entity.CallService("turn_off");
        }

        ///<summary>Turn a media player power on.</summary>
        public static void TurnOn(this MediaPlayerEntity entity)
        {
            entity.CallService("turn_on");
        }

        ///<summary>Unjoin the player from a group. Only works on platforms with support for player groups.</summary>
        public static void Unjoin(this MediaPlayerEntity entity)
        {
            entity.CallService("unjoin");
        }

        ///<summary>Turn a media player volume down.</summary>
        public static void VolumeDown(this MediaPlayerEntity entity)
        {
            entity.CallService("volume_down");
        }

        ///<summary>Mute a media player's volume.</summary>
        public static void VolumeMute(this MediaPlayerEntity entity, MediaPlayerVolumeMuteParameters data)
        {
            entity.CallService("volume_mute", data);
        }

        ///<summary>Mute a media player's volume.</summary>
        ///<param name="entity">The MediaPlayerEntity to call this service for</param>
        ///<param name="isVolumeMuted">True/false for mute/unmute.</param>
        public static void VolumeMute(this MediaPlayerEntity entity, bool @isVolumeMuted)
        {
            entity.CallService("volume_mute", new MediaPlayerVolumeMuteParameters { IsVolumeMuted = @isVolumeMuted });
        }

        ///<summary>Set a media player's volume level.</summary>
        public static void VolumeSet(this MediaPlayerEntity entity, MediaPlayerVolumeSetParameters data)
        {
            entity.CallService("volume_set", data);
        }

        ///<summary>Set a media player's volume level.</summary>
        ///<param name="entity">The MediaPlayerEntity to call this service for</param>
        ///<param name="volumeLevel">Volume level to set as float.</param>
        public static void VolumeSet(this MediaPlayerEntity entity, double @volumeLevel)
        {
            entity.CallService("volume_set", new MediaPlayerVolumeSetParameters { VolumeLevel = @volumeLevel });
        }

        ///<summary>Turn a media player volume up.</summary>
        public static void VolumeUp(this MediaPlayerEntity entity)
        {
            entity.CallService("volume_up");
        }
    }

    public static class RemoteEntityExtensionMethods
    {
        ///<summary>Deletes a command or a list of commands from the database.</summary>
        public static void DeleteCommand(this RemoteEntity entity, RemoteDeleteCommandParameters data)
        {
            entity.CallService("delete_command", data);
        }

        ///<summary>Deletes a command or a list of commands from the database.</summary>
        ///<param name="entity">The RemoteEntity to call this service for</param>
        ///<param name="device">Name of the device from which commands will be deleted. eg: television</param>
        ///<param name="command">A single command or a list of commands to delete. eg: Mute</param>
        public static void DeleteCommand(this RemoteEntity entity, object @command, string? @device = null)
        {
            entity.CallService("delete_command", new RemoteDeleteCommandParameters { Device = @device, Command = @command });
        }

        ///<summary>Learns a command or a list of commands from a device.</summary>
        public static void LearnCommand(this RemoteEntity entity, RemoteLearnCommandParameters data)
        {
            entity.CallService("learn_command", data);
        }

        ///<summary>Learns a command or a list of commands from a device.</summary>
        ///<param name="entity">The RemoteEntity to call this service for</param>
        ///<param name="device">Device ID to learn command from. eg: television</param>
        ///<param name="command">A single command or a list of commands to learn. eg: Turn on</param>
        ///<param name="commandType">The type of command to be learned.</param>
        ///<param name="alternative">If code must be stored as alternative (useful for discrete remotes).</param>
        ///<param name="timeout">Timeout for the command to be learned.</param>
        public static void LearnCommand(this RemoteEntity entity, string? @device = null, object? @command = null, string? @commandType = null, bool? @alternative = null, long? @timeout = null)
        {
            entity.CallService("learn_command", new RemoteLearnCommandParameters { Device = @device, Command = @command, CommandType = @commandType, Alternative = @alternative, Timeout = @timeout });
        }

        ///<summary>Sends a command or a list of commands to a device.</summary>
        public static void SendCommand(this RemoteEntity entity, RemoteSendCommandParameters data)
        {
            entity.CallService("send_command", data);
        }

        ///<summary>Sends a command or a list of commands to a device.</summary>
        ///<param name="entity">The RemoteEntity to call this service for</param>
        ///<param name="device">Device ID to send command to. eg: 32756745</param>
        ///<param name="command">A single command or a list of commands to send. eg: Play</param>
        ///<param name="numRepeats">The number of times you want to repeat the command(s).</param>
        ///<param name="delaySecs">The time you want to wait in between repeated commands.</param>
        ///<param name="holdSecs">The time you want to have it held before the release is send.</param>
        public static void SendCommand(this RemoteEntity entity, string @command, string? @device = null, long? @numRepeats = null, double? @delaySecs = null, double? @holdSecs = null)
        {
            entity.CallService("send_command", new RemoteSendCommandParameters { Device = @device, Command = @command, NumRepeats = @numRepeats, DelaySecs = @delaySecs, HoldSecs = @holdSecs });
        }

        ///<summary>Toggles a device.</summary>
        public static void Toggle(this RemoteEntity entity)
        {
            entity.CallService("toggle");
        }

        ///<summary>Sends the Power Off Command.</summary>
        public static void TurnOff(this RemoteEntity entity)
        {
            entity.CallService("turn_off");
        }

        ///<summary>Sends the Power On Command.</summary>
        public static void TurnOn(this RemoteEntity entity, RemoteTurnOnParameters data)
        {
            entity.CallService("turn_on", data);
        }

        ///<summary>Sends the Power On Command.</summary>
        ///<param name="entity">The RemoteEntity to call this service for</param>
        ///<param name="activity">Activity ID or Activity Name to start. eg: BedroomTV</param>
        public static void TurnOn(this RemoteEntity entity, string? @activity = null)
        {
            entity.CallService("turn_on", new RemoteTurnOnParameters { Activity = @activity });
        }
    }

    public static class SceneEntityExtensionMethods
    {
        ///<summary>Activate a scene.</summary>
        public static void TurnOn(this SceneEntity entity, SceneTurnOnParameters data)
        {
            entity.CallService("turn_on", data);
        }

        ///<summary>Activate a scene.</summary>
        ///<param name="entity">The SceneEntity to call this service for</param>
        ///<param name="transition">Transition duration it takes to bring devices to the state defined in the scene.</param>
        public static void TurnOn(this SceneEntity entity, long? @transition = null)
        {
            entity.CallService("turn_on", new SceneTurnOnParameters { Transition = @transition });
        }
    }

    public static class ScriptEntityExtensionMethods
    {
        ///<summary>Toggle script</summary>
        public static void Toggle(this ScriptEntity entity)
        {
            entity.CallService("toggle");
        }

        ///<summary>Turn off script</summary>
        public static void TurnOff(this ScriptEntity entity)
        {
            entity.CallService("turn_off");
        }

        ///<summary>Turn on script</summary>
        public static void TurnOn(this ScriptEntity entity)
        {
            entity.CallService("turn_on");
        }
    }

    public static class SelectEntityExtensionMethods
    {
        ///<summary>Select an option of an select entity.</summary>
        public static void SelectOption(this SelectEntity entity, SelectSelectOptionParameters data)
        {
            entity.CallService("select_option", data);
        }

        ///<summary>Select an option of an select entity.</summary>
        ///<param name="entity">The SelectEntity to call this service for</param>
        ///<param name="option">Option to be selected. eg: "Item A"</param>
        public static void SelectOption(this SelectEntity entity, string @option)
        {
            entity.CallService("select_option", new SelectSelectOptionParameters { Option = @option });
        }
    }

    public static class SwitchEntityExtensionMethods
    {
        ///<summary>Toggles a switch state</summary>
        public static void Toggle(this SwitchEntity entity)
        {
            entity.CallService("toggle");
        }

        ///<summary>Turn a switch off</summary>
        public static void TurnOff(this SwitchEntity entity)
        {
            entity.CallService("turn_off");
        }

        ///<summary>Turn a switch on</summary>
        public static void TurnOn(this SwitchEntity entity)
        {
            entity.CallService("turn_on");
        }
    }

    public static class TimerEntityExtensionMethods
    {
        ///<summary>Cancel a timer.</summary>
        public static void Cancel(this TimerEntity entity)
        {
            entity.CallService("cancel");
        }

        ///<summary>Finish a timer.</summary>
        public static void Finish(this TimerEntity entity)
        {
            entity.CallService("finish");
        }

        ///<summary>Pause a timer.</summary>
        public static void Pause(this TimerEntity entity)
        {
            entity.CallService("pause");
        }

        ///<summary>Start a timer</summary>
        public static void Start(this TimerEntity entity, TimerStartParameters data)
        {
            entity.CallService("start", data);
        }

        ///<summary>Start a timer</summary>
        ///<param name="entity">The TimerEntity to call this service for</param>
        ///<param name="duration">Duration the timer requires to finish. [optional] eg: 00:01:00 or 60</param>
        public static void Start(this TimerEntity entity, string? @duration = null)
        {
            entity.CallService("start", new TimerStartParameters { Duration = @duration });
        }
    }
}