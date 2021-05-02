using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using NetDaemon.Common;
using NetDaemon.Common.Reactive;

namespace NetDaemon.Generated.Reactive
{
    public class GeneratedAppBase : NetDaemonRxApp
    {
        public SensorEntities Sensor => new(this);
        public CameraEntities Camera => new(this);
        public DeviceTrackerEntities DeviceTracker => new(this);
        public BinarySensorEntities BinarySensor => new(this);
        public ProximityEntities Proximity => new(this);
        public GroupEntities Group => new(this);
        public SwitchEntities Switch => new(this);
        public CoverEntities Cover => new(this);
        public ScriptEntity Script => new(this, new string[]{""});
        public MediaPlayerEntities MediaPlayer => new(this);
        public SceneEntities Scene => new(this);
        public TimerEntities Timer => new(this);
        public LightEntities Light => new(this);
        public SunEntities Sun => new(this);
        public ZoneEntities Zone => new(this);
        public RemoteEntities Remote => new(this);
        public AutomationEntities Automation => new(this);
        public InputTextEntities InputText => new(this);
        public CalendarEntities Calendar => new(this);
        public PersonEntities Person => new(this);
        public WeatherEntities Weather => new(this);
        public InputNumberEntities InputNumber => new(this);
        public InputBooleanEntities InputBoolean => new(this);
        public InputSelectEntities InputSelect => new(this);
        public NetdaemonEntities Netdaemon => new(this);
        public LockEntities Lock => new(this);
    }

    public partial class SensorEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public EntityState? EntityState => DaemonRxApp?.State(EntityId);
        public string? Area => DaemonRxApp?.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp?.State(EntityId)?.Attribute;
        public DateTime? LastChanged => DaemonRxApp?.State(EntityId)?.LastChanged;
        public DateTime? LastUpdated => DaemonRxApp?.State(EntityId)?.LastUpdated;
        public dynamic? State => DaemonRxApp?.State(EntityId)?.State;
        public SensorEntity(INetDaemonRxApp daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }
    }

    public partial class CameraEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public EntityState? EntityState => DaemonRxApp?.State(EntityId);
        public string? Area => DaemonRxApp?.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp?.State(EntityId)?.Attribute;
        public DateTime? LastChanged => DaemonRxApp?.State(EntityId)?.LastChanged;
        public DateTime? LastUpdated => DaemonRxApp?.State(EntityId)?.LastUpdated;
        public dynamic? State => DaemonRxApp?.State(EntityId)?.State;
        public CameraEntity(INetDaemonRxApp daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }

        public void EnableMotionDetection(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("camera", "enable_motion_detection", serviceData);
        }

        public void DisableMotionDetection(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("camera", "disable_motion_detection", serviceData);
        }

        public void Snapshot(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("camera", "snapshot", serviceData);
        }

        public void PlayStream(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("camera", "play_stream", serviceData);
        }

        public void Record(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("camera", "record", serviceData);
        }
    }

    public partial class DeviceTrackerEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public EntityState? EntityState => DaemonRxApp?.State(EntityId);
        public string? Area => DaemonRxApp?.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp?.State(EntityId)?.Attribute;
        public DateTime? LastChanged => DaemonRxApp?.State(EntityId)?.LastChanged;
        public DateTime? LastUpdated => DaemonRxApp?.State(EntityId)?.LastUpdated;
        public dynamic? State => DaemonRxApp?.State(EntityId)?.State;
        public DeviceTrackerEntity(INetDaemonRxApp daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }

        public void See(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("device_tracker", "see", serviceData);
        }
    }

    public partial class BinarySensorEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public EntityState? EntityState => DaemonRxApp?.State(EntityId);
        public string? Area => DaemonRxApp?.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp?.State(EntityId)?.Attribute;
        public DateTime? LastChanged => DaemonRxApp?.State(EntityId)?.LastChanged;
        public DateTime? LastUpdated => DaemonRxApp?.State(EntityId)?.LastUpdated;
        public dynamic? State => DaemonRxApp?.State(EntityId)?.State;
        public BinarySensorEntity(INetDaemonRxApp daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }
    }

    public partial class ProximityEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public EntityState? EntityState => DaemonRxApp?.State(EntityId);
        public string? Area => DaemonRxApp?.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp?.State(EntityId)?.Attribute;
        public DateTime? LastChanged => DaemonRxApp?.State(EntityId)?.LastChanged;
        public DateTime? LastUpdated => DaemonRxApp?.State(EntityId)?.LastUpdated;
        public dynamic? State => DaemonRxApp?.State(EntityId)?.State;
        public ProximityEntity(INetDaemonRxApp daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }
    }

    public partial class GroupEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public EntityState? EntityState => DaemonRxApp?.State(EntityId);
        public string? Area => DaemonRxApp?.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp?.State(EntityId)?.Attribute;
        public DateTime? LastChanged => DaemonRxApp?.State(EntityId)?.LastChanged;
        public DateTime? LastUpdated => DaemonRxApp?.State(EntityId)?.LastUpdated;
        public dynamic? State => DaemonRxApp?.State(EntityId)?.State;
        public GroupEntity(INetDaemonRxApp daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }

        public void Reload(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("group", "reload", serviceData);
        }

        public void Set(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("group", "set", serviceData);
        }

        public void Remove(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("group", "remove", serviceData);
        }
    }

    public partial class SwitchEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public EntityState? EntityState => DaemonRxApp?.State(EntityId);
        public string? Area => DaemonRxApp?.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp?.State(EntityId)?.Attribute;
        public DateTime? LastChanged => DaemonRxApp?.State(EntityId)?.LastChanged;
        public DateTime? LastUpdated => DaemonRxApp?.State(EntityId)?.LastUpdated;
        public dynamic? State => DaemonRxApp?.State(EntityId)?.State;
        public SwitchEntity(INetDaemonRxApp daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }
    }

    public partial class CoverEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public EntityState? EntityState => DaemonRxApp?.State(EntityId);
        public string? Area => DaemonRxApp?.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp?.State(EntityId)?.Attribute;
        public DateTime? LastChanged => DaemonRxApp?.State(EntityId)?.LastChanged;
        public DateTime? LastUpdated => DaemonRxApp?.State(EntityId)?.LastUpdated;
        public dynamic? State => DaemonRxApp?.State(EntityId)?.State;
        public CoverEntity(INetDaemonRxApp daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }

        public void OpenCover(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("cover", "open_cover", serviceData);
        }

        public void CloseCover(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("cover", "close_cover", serviceData);
        }

        public void SetCoverPosition(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("cover", "set_cover_position", serviceData);
        }

        public void StopCover(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("cover", "stop_cover", serviceData);
        }

        public void OpenCoverTilt(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("cover", "open_cover_tilt", serviceData);
        }

        public void CloseCoverTilt(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("cover", "close_cover_tilt", serviceData);
        }

        public void StopCoverTilt(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("cover", "stop_cover_tilt", serviceData);
        }

        public void SetCoverTiltPosition(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("cover", "set_cover_tilt_position", serviceData);
        }

        public void ToggleCoverTilt(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("cover", "toggle_cover_tilt", serviceData);
        }
    }

    public partial class ScriptEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public EntityState? EntityState => DaemonRxApp?.State(EntityId);
        public string? Area => DaemonRxApp?.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp?.State(EntityId)?.Attribute;
        public DateTime? LastChanged => DaemonRxApp?.State(EntityId)?.LastChanged;
        public DateTime? LastUpdated => DaemonRxApp?.State(EntityId)?.LastUpdated;
        public dynamic? State => DaemonRxApp?.State(EntityId)?.State;
        public ScriptEntity(INetDaemonRxApp daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }

        public void MorningScene(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "morning_scene", serviceData);
        }

        public void DayScene(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "day_scene", serviceData);
        }

        public void EveningScene(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "evening_scene", serviceData);
        }

        public void ColorScene(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "color_scene", serviceData);
        }

        public void CleaningScene(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "cleaning_scene", serviceData);
        }

        public void NightScene(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "night_scene", serviceData);
        }

        public void TvScene(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "tv_scene", serviceData);
        }

        public void FilmScene(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "film_scene", serviceData);
        }

        public void TvOffScene(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "tv_off_scene", serviceData);
        }

        public void S1586350051032(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "1586350051032", serviceData);
        }

        public void Setnightmode(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "setnightmode", serviceData);
        }

        public void Zigbee2mqttRename(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "zigbee2mqtt_rename", serviceData);
        }

        public void Zigbee2mqttRemove(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "zigbee2mqtt_remove", serviceData);
        }

        public void Notify(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "notify", serviceData);
        }

        public void NotifyGreet(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "notify_greet", serviceData);
        }

        public void Reload(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("script", "reload", serviceData);
        }
    }

    public partial class MediaPlayerEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public EntityState? EntityState => DaemonRxApp?.State(EntityId);
        public string? Area => DaemonRxApp?.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp?.State(EntityId)?.Attribute;
        public DateTime? LastChanged => DaemonRxApp?.State(EntityId)?.LastChanged;
        public DateTime? LastUpdated => DaemonRxApp?.State(EntityId)?.LastUpdated;
        public dynamic? State => DaemonRxApp?.State(EntityId)?.State;
        public MediaPlayerEntity(INetDaemonRxApp daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }

        public void VolumeUp(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("media_player", "volume_up", serviceData);
        }

        public void VolumeDown(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("media_player", "volume_down", serviceData);
        }

        public void MediaPlayPause(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("media_player", "media_play_pause", serviceData);
        }

        public void MediaPlay(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("media_player", "media_play", serviceData);
        }

        public void MediaPause(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("media_player", "media_pause", serviceData);
        }

        public void MediaStop(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("media_player", "media_stop", serviceData);
        }

        public void MediaNextTrack(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("media_player", "media_next_track", serviceData);
        }

        public void MediaPreviousTrack(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("media_player", "media_previous_track", serviceData);
        }

        public void ClearPlaylist(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("media_player", "clear_playlist", serviceData);
        }

        public void VolumeSet(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("media_player", "volume_set", serviceData);
        }

        public void VolumeMute(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("media_player", "volume_mute", serviceData);
        }

        public void MediaSeek(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("media_player", "media_seek", serviceData);
        }

        public void SelectSource(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("media_player", "select_source", serviceData);
        }

        public void SelectSoundMode(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("media_player", "select_sound_mode", serviceData);
        }

        public void PlayMedia(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("media_player", "play_media", serviceData);
        }

        public void ShuffleSet(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("media_player", "shuffle_set", serviceData);
        }

        public void RepeatSet(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("media_player", "repeat_set", serviceData);
        }
    }

    public partial class SceneEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public EntityState? EntityState => DaemonRxApp?.State(EntityId);
        public string? Area => DaemonRxApp?.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp?.State(EntityId)?.Attribute;
        public DateTime? LastChanged => DaemonRxApp?.State(EntityId)?.LastChanged;
        public DateTime? LastUpdated => DaemonRxApp?.State(EntityId)?.LastUpdated;
        public dynamic? State => DaemonRxApp?.State(EntityId)?.State;
        public SceneEntity(INetDaemonRxApp daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }

        public void Reload(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("scene", "reload", serviceData);
        }

        public void Apply(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("scene", "apply", serviceData);
        }

        public void Create(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("scene", "create", serviceData);
        }
    }

    public partial class TimerEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public EntityState? EntityState => DaemonRxApp?.State(EntityId);
        public string? Area => DaemonRxApp?.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp?.State(EntityId)?.Attribute;
        public DateTime? LastChanged => DaemonRxApp?.State(EntityId)?.LastChanged;
        public DateTime? LastUpdated => DaemonRxApp?.State(EntityId)?.LastUpdated;
        public dynamic? State => DaemonRxApp?.State(EntityId)?.State;
        public TimerEntity(INetDaemonRxApp daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }

        public void Reload(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("timer", "reload", serviceData);
        }

        public void Start(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("timer", "start", serviceData);
        }

        public void Pause(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("timer", "pause", serviceData);
        }

        public void Cancel(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("timer", "cancel", serviceData);
        }

        public void Finish(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("timer", "finish", serviceData);
        }
    }

    public partial class LightEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public EntityState? EntityState => DaemonRxApp?.State(EntityId);
        public string? Area => DaemonRxApp?.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp?.State(EntityId)?.Attribute;
        public DateTime? LastChanged => DaemonRxApp?.State(EntityId)?.LastChanged;
        public DateTime? LastUpdated => DaemonRxApp?.State(EntityId)?.LastUpdated;
        public dynamic? State => DaemonRxApp?.State(EntityId)?.State;
        public LightEntity(INetDaemonRxApp daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }
    }

    public partial class SunEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public EntityState? EntityState => DaemonRxApp?.State(EntityId);
        public string? Area => DaemonRxApp?.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp?.State(EntityId)?.Attribute;
        public DateTime? LastChanged => DaemonRxApp?.State(EntityId)?.LastChanged;
        public DateTime? LastUpdated => DaemonRxApp?.State(EntityId)?.LastUpdated;
        public dynamic? State => DaemonRxApp?.State(EntityId)?.State;
        public SunEntity(INetDaemonRxApp daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }
    }

    public partial class ZoneEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public EntityState? EntityState => DaemonRxApp?.State(EntityId);
        public string? Area => DaemonRxApp?.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp?.State(EntityId)?.Attribute;
        public DateTime? LastChanged => DaemonRxApp?.State(EntityId)?.LastChanged;
        public DateTime? LastUpdated => DaemonRxApp?.State(EntityId)?.LastUpdated;
        public dynamic? State => DaemonRxApp?.State(EntityId)?.State;
        public ZoneEntity(INetDaemonRxApp daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }

        public void Reload(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("zone", "reload", serviceData);
        }
    }

    public partial class RemoteEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public EntityState? EntityState => DaemonRxApp?.State(EntityId);
        public string? Area => DaemonRxApp?.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp?.State(EntityId)?.Attribute;
        public DateTime? LastChanged => DaemonRxApp?.State(EntityId)?.LastChanged;
        public DateTime? LastUpdated => DaemonRxApp?.State(EntityId)?.LastUpdated;
        public dynamic? State => DaemonRxApp?.State(EntityId)?.State;
        public RemoteEntity(INetDaemonRxApp daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }

        public void SendCommand(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("remote", "send_command", serviceData);
        }

        public void LearnCommand(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("remote", "learn_command", serviceData);
        }

        public void DeleteCommand(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("remote", "delete_command", serviceData);
        }
    }

    public partial class AutomationEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public EntityState? EntityState => DaemonRxApp?.State(EntityId);
        public string? Area => DaemonRxApp?.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp?.State(EntityId)?.Attribute;
        public DateTime? LastChanged => DaemonRxApp?.State(EntityId)?.LastChanged;
        public DateTime? LastUpdated => DaemonRxApp?.State(EntityId)?.LastUpdated;
        public dynamic? State => DaemonRxApp?.State(EntityId)?.State;
        public AutomationEntity(INetDaemonRxApp daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }

        public void Trigger(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("automation", "trigger", serviceData);
        }

        public void Reload(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("automation", "reload", serviceData);
        }
    }

    public partial class InputTextEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public EntityState? EntityState => DaemonRxApp?.State(EntityId);
        public string? Area => DaemonRxApp?.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp?.State(EntityId)?.Attribute;
        public DateTime? LastChanged => DaemonRxApp?.State(EntityId)?.LastChanged;
        public DateTime? LastUpdated => DaemonRxApp?.State(EntityId)?.LastUpdated;
        public dynamic? State => DaemonRxApp?.State(EntityId)?.State;
        public InputTextEntity(INetDaemonRxApp daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }

        public void Reload(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("input_text", "reload", serviceData);
        }

        public void SetValue(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("input_text", "set_value", serviceData);
        }
    }

    public partial class CalendarEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public EntityState? EntityState => DaemonRxApp?.State(EntityId);
        public string? Area => DaemonRxApp?.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp?.State(EntityId)?.Attribute;
        public DateTime? LastChanged => DaemonRxApp?.State(EntityId)?.LastChanged;
        public DateTime? LastUpdated => DaemonRxApp?.State(EntityId)?.LastUpdated;
        public dynamic? State => DaemonRxApp?.State(EntityId)?.State;
        public CalendarEntity(INetDaemonRxApp daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }
    }

    public partial class PersonEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public EntityState? EntityState => DaemonRxApp?.State(EntityId);
        public string? Area => DaemonRxApp?.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp?.State(EntityId)?.Attribute;
        public DateTime? LastChanged => DaemonRxApp?.State(EntityId)?.LastChanged;
        public DateTime? LastUpdated => DaemonRxApp?.State(EntityId)?.LastUpdated;
        public dynamic? State => DaemonRxApp?.State(EntityId)?.State;
        public PersonEntity(INetDaemonRxApp daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }

        public void Reload(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("person", "reload", serviceData);
        }
    }

    public partial class WeatherEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public EntityState? EntityState => DaemonRxApp?.State(EntityId);
        public string? Area => DaemonRxApp?.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp?.State(EntityId)?.Attribute;
        public DateTime? LastChanged => DaemonRxApp?.State(EntityId)?.LastChanged;
        public DateTime? LastUpdated => DaemonRxApp?.State(EntityId)?.LastUpdated;
        public dynamic? State => DaemonRxApp?.State(EntityId)?.State;
        public WeatherEntity(INetDaemonRxApp daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }
    }

    public partial class InputNumberEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public EntityState? EntityState => DaemonRxApp?.State(EntityId);
        public string? Area => DaemonRxApp?.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp?.State(EntityId)?.Attribute;
        public DateTime? LastChanged => DaemonRxApp?.State(EntityId)?.LastChanged;
        public DateTime? LastUpdated => DaemonRxApp?.State(EntityId)?.LastUpdated;
        public dynamic? State => DaemonRxApp?.State(EntityId)?.State;
        public InputNumberEntity(INetDaemonRxApp daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }

        public void Reload(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("input_number", "reload", serviceData);
        }

        public void SetValue(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("input_number", "set_value", serviceData);
        }

        public void Increment(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("input_number", "increment", serviceData);
        }

        public void Decrement(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("input_number", "decrement", serviceData);
        }
    }

    public partial class InputBooleanEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public EntityState? EntityState => DaemonRxApp?.State(EntityId);
        public string? Area => DaemonRxApp?.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp?.State(EntityId)?.Attribute;
        public DateTime? LastChanged => DaemonRxApp?.State(EntityId)?.LastChanged;
        public DateTime? LastUpdated => DaemonRxApp?.State(EntityId)?.LastUpdated;
        public dynamic? State => DaemonRxApp?.State(EntityId)?.State;
        public InputBooleanEntity(INetDaemonRxApp daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }

        public void Reload(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("input_boolean", "reload", serviceData);
        }
    }

    public partial class InputSelectEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public EntityState? EntityState => DaemonRxApp?.State(EntityId);
        public string? Area => DaemonRxApp?.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp?.State(EntityId)?.Attribute;
        public DateTime? LastChanged => DaemonRxApp?.State(EntityId)?.LastChanged;
        public DateTime? LastUpdated => DaemonRxApp?.State(EntityId)?.LastUpdated;
        public dynamic? State => DaemonRxApp?.State(EntityId)?.State;
        public InputSelectEntity(INetDaemonRxApp daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }

        public void Reload(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("input_select", "reload", serviceData);
        }

        public void SelectOption(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("input_select", "select_option", serviceData);
        }

        public void SelectNext(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("input_select", "select_next", serviceData);
        }

        public void SelectPrevious(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("input_select", "select_previous", serviceData);
        }

        public void SetOptions(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("input_select", "set_options", serviceData);
        }
    }

    public partial class NetdaemonEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public EntityState? EntityState => DaemonRxApp?.State(EntityId);
        public string? Area => DaemonRxApp?.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp?.State(EntityId)?.Attribute;
        public DateTime? LastChanged => DaemonRxApp?.State(EntityId)?.LastChanged;
        public DateTime? LastUpdated => DaemonRxApp?.State(EntityId)?.LastUpdated;
        public dynamic? State => DaemonRxApp?.State(EntityId)?.State;
        public NetdaemonEntity(INetDaemonRxApp daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }

        public void RegisterService(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("netdaemon", "register_service", serviceData);
        }

        public void ReloadApps(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("netdaemon", "reload_apps", serviceData);
        }

        public void WebhookmanagerOnwebhook(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            DaemonRxApp.CallService("netdaemon", "webhookmanager_onwebhook", serviceData);
        }
    }

    public partial class LockEntity : RxEntity
    {
        public string EntityId => EntityIds.First();
        public EntityState? EntityState => DaemonRxApp?.State(EntityId);
        public string? Area => DaemonRxApp?.State(EntityId)?.Area;
        public dynamic? Attribute => DaemonRxApp?.State(EntityId)?.Attribute;
        public DateTime? LastChanged => DaemonRxApp?.State(EntityId)?.LastChanged;
        public DateTime? LastUpdated => DaemonRxApp?.State(EntityId)?.LastUpdated;
        public dynamic? State => DaemonRxApp?.State(EntityId)?.State;
        public LockEntity(INetDaemonRxApp daemon, IEnumerable<string> entityIds): base(daemon, entityIds)
        {
        }

        public void Unlock(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("lock", "unlock", serviceData);
        }

        public void Lock(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("lock", "lock", serviceData);
        }

        public void Open(dynamic? data = null)
        {
            var serviceData = new FluentExpandoObject();
            if (data is ExpandoObject)
            {
                serviceData.CopyFrom(data);
            }
            else if (data is not null)
            {
                var expObject = ((object)data).ToExpandoObject();
                if (expObject is not null)
                    serviceData.CopyFrom(expObject);
            }

            serviceData["entity_id"] = EntityId;
            DaemonRxApp.CallService("lock", "open", serviceData);
        }
    }

    public partial class SensorEntities
    {
        private readonly NetDaemonRxApp _app;
        public SensorEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public SensorEntity JulbelysningHogerLinkquality => new(_app, new string[]{"sensor.julbelysning_hoger_linkquality"});
        public SensorEntity TomasIpadStorage => new(_app, new string[]{"sensor.tomas_ipad_storage"});
        public SensorEntity LasUppeLinkquality => new(_app, new string[]{"sensor.las_uppe_linkquality"});
        public SensorEntity JulbelysningVardagsrumVPowerOnBehavior => new(_app, new string[]{"sensor.julbelysning_vardagsrum_v_power_on_behavior"});
        public SensorEntity Viking02811A700BatteryNumeric => new(_app, new string[]{"sensor.viking_02811_a7_00_battery_numeric"});
        public SensorEntity Ac67bc0cfe4RssiNumeric => new(_app, new string[]{"sensor.ac_67bc0cfe_4_rssi_numeric"});
        public SensorEntity TrappPirBattery => new(_app, new string[]{"sensor.trapp_pir_battery"});
        public SensorEntity VardagsrumPirMotionSensitivity => new(_app, new string[]{"sensor.vardagsrum_pir_motion_sensitivity"});
        public SensorEntity JulbelysningKokVLinkquality => new(_app, new string[]{"sensor.julbelysning_kok_v_linkquality"});
        public SensorEntity SallysRumTempBatt => new(_app, new string[]{"sensor.sallys_rum_temp_batt"});
        public SensorEntity TomasIpadActivity => new(_app, new string[]{"sensor.tomas_ipad_activity"});
        public SensorEntity MelkersRumPirOccupancyRequestedBrightnessPercent => new(_app, new string[]{"sensor.melkers_rum_pir_occupancy_requested_brightness_percent"});
        public SensorEntity SmG975fWifiConnection => new(_app, new string[]{"sensor.sm_g975f_wifi_connection"});
        public SensorEntity Ac2bc0cfe1RssiNumeric => new(_app, new string[]{"sensor.ac_2bc0cfe_1_rssi_numeric"});
        public SensorEntity TvrumFonsterVansterUpdateState => new(_app, new string[]{"sensor.tvrum_fonster_vanster_update_state"});
        public SensorEntity MelkersRumTemp => new(_app, new string[]{"sensor.melkers_rum_temp"});
        public SensorEntity Ac18ce36211RssiNumeric => new(_app, new string[]{"sensor.ac_18ce362_11_rssi_numeric"});
        public SensorEntity VardagsrumPirLinkquality => new(_app, new string[]{"sensor.vardagsrum_pir_linkquality"});
        public SensorEntity SmG986bBatteryHealth => new(_app, new string[]{"sensor.sm_g986b_battery_health"});
        public SensorEntity Viking02811A700Temperature => new(_app, new string[]{"sensor.viking_02811_a7_00_temperature"});
        public SensorEntity TvrumCube => new(_app, new string[]{"sensor.tvrum_cube"});
        public SensorEntity FarstukvistLedUpdateState => new(_app, new string[]{"sensor.farstukvist_led_update_state"});
        public SensorEntity JulbelysningTvrummetCurrent => new(_app, new string[]{"sensor.julbelysning_tvrummet_current"});
        public SensorEntity Viking0203502038B700Humidity => new(_app, new string[]{"sensor.viking_0203502038_b7_00_humidity"});
        public SensorEntity Bssid => new(_app, new string[]{"sensor.bssid"});
        public SensorEntity JulbelysningKokHLinkquality => new(_app, new string[]{"sensor.julbelysning_kok_h_linkquality"});
        public SensorEntity FarstukvistLedLinkquality => new(_app, new string[]{"sensor.farstukvist_led_linkquality"});
        public SensorEntity TvrumPirIlluminance => new(_app, new string[]{"sensor.tvrum_pir_illuminance"});
        public SensorEntity KokFonsterLinkquality => new(_app, new string[]{"sensor.kok_fonster_linkquality"});
        public SensorEntity MelkersRumTempBattery => new(_app, new string[]{"sensor.melkers_rum_temp_battery"});
        public SensorEntity Ac51bc0cfe4RssiNumeric => new(_app, new string[]{"sensor.ac_51bc0cfe_4_rssi_numeric"});
        public SensorEntity VardagsrumVansterLinkquality => new(_app, new string[]{"sensor.vardagsrum_vanster_linkquality"});
        public SensorEntity SallysRumTemp => new(_app, new string[]{"sensor.sallys_rum_temp"});
        public SensorEntity TomasRumUpdateState => new(_app, new string[]{"sensor.tomas_rum_update_state"});
        public SensorEntity JulbelysningHogerUpdateState => new(_app, new string[]{"sensor.julbelysning_hoger_update_state"});
        public SensorEntity PlexPlex => new(_app, new string[]{"sensor.plex_plex"});
        public SensorEntity GymLedLinkquality => new(_app, new string[]{"sensor.gym_led_linkquality"});
        public SensorEntity YtQg8r => new(_app, new string[]{"sensor.yt_qg8r"});
        public SensorEntity TvrummVaggLinkquality => new(_app, new string[]{"sensor.tvrumm_vagg_linkquality"});
        public SensorEntity Viking0203502038B700 => new(_app, new string[]{"sensor.viking_0203502038_b7_00"});
        public SensorEntity TvrumPirBattery => new(_app, new string[]{"sensor.tvrum_pir_battery"});
        public SensorEntity SmG986bBluetoothConnection => new(_app, new string[]{"sensor.sm_g986b_bluetooth_connection"});
        public SensorEntity TomasRumPirBattery => new(_app, new string[]{"sensor.tomas_rum_pir_battery"});
        public SensorEntity TomasRumPirUpdateState => new(_app, new string[]{"sensor.tomas_rum_pir_update_state"});
        public SensorEntity HobbyrumTempLinkquality => new(_app, new string[]{"sensor.hobbyrum_temp_linkquality"});
        public SensorEntity TrappPirIlluminance => new(_app, new string[]{"sensor.trapp_pir_illuminance"});
        public SensorEntity Ac39bc0cfe7RssiNumeric => new(_app, new string[]{"sensor.ac_39bc0cfe_7_rssi_numeric"});
        public SensorEntity SovrumTempLinkquality => new(_app, new string[]{"sensor.sovrum_temp_linkquality"});
        public SensorEntity TempOutside => new(_app, new string[]{"sensor.temp_outside"});
        public SensorEntity SmG986bStorageSensor => new(_app, new string[]{"sensor.sm_g986b_storage_sensor"});
        public SensorEntity SovrumPirUpdateState => new(_app, new string[]{"sensor.sovrum_pir_update_state"});
        public SensorEntity JulbelysningTomasRumPowerOnBehavior => new(_app, new string[]{"sensor.julbelysning_tomas_rum_power_on_behavior"});
        public SensorEntity MotorvarmareHogerLinkquality => new(_app, new string[]{"sensor.motorvarmare_hoger_linkquality"});
        public SensorEntity TvrumPirLinkquality => new(_app, new string[]{"sensor.tvrum_pir_linkquality"});
        public SensorEntity BatteryState => new(_app, new string[]{"sensor.battery_state"});
        public SensorEntity SallysRumPirUpdateState => new(_app, new string[]{"sensor.sallys_rum_pir_update_state"});
        public SensorEntity SmG986bLastReboot => new(_app, new string[]{"sensor.sm_g986b_last_reboot"});
        public SensorEntity YtPewdiepie => new(_app, new string[]{"sensor.yt_pewdiepie"});
        public SensorEntity Ac81bc0cfe1RssiNumeric => new(_app, new string[]{"sensor.ac_81bc0cfe_1_rssi_numeric"});
        public SensorEntity FrysnereTemperature => new(_app, new string[]{"sensor.frysnere_temperature"});
        public SensorEntity Ac55bc0cfe7RssiNumeric => new(_app, new string[]{"sensor.ac_55bc0cfe_7_rssi_numeric"});
        public SensorEntity SmG986bChargerType => new(_app, new string[]{"sensor.sm_g986b_charger_type"});
        public SensorEntity UteTempLinkquality => new(_app, new string[]{"sensor.ute_temp_linkquality"});
        public SensorEntity JulbelysningKokVEnergy => new(_app, new string[]{"sensor.julbelysning_kok_v_energy"});
        public SensorEntity LastBoot => new(_app, new string[]{"sensor.last_boot"});
        public SensorEntity Zigbee2mqttVersion => new(_app, new string[]{"sensor.zigbee2mqtt_version"});
        public SensorEntity MyfitnesspalHelto4real => new(_app, new string[]{"sensor.myfitnesspal_helto4real"});
        public SensorEntity JulbelysningKokVPower => new(_app, new string[]{"sensor.julbelysning_kok_v_power"});
        public SensorEntity TomasIpadLastUpdateTrigger => new(_app, new string[]{"sensor.tomas_ipad_last_update_trigger"});
        public SensorEntity SovrumTempBattery => new(_app, new string[]{"sensor.sovrum_temp_battery"});
        public SensorEntity Load15m => new(_app, new string[]{"sensor.load_15m"});
        public SensorEntity Ac72bc0cfe2RssiNumeric => new(_app, new string[]{"sensor.ac_72bc0cfe_2_rssi_numeric"});
        public SensorEntity MelkersRumPirUpdateState => new(_app, new string[]{"sensor.melkers_rum_pir_update_state"});
        public SensorEntity E0x00158d00020b7df4Linkquality => new(_app, new string[]{"sensor.0x00158d00020b7df4_linkquality"});
        public SensorEntity JulbelysningVardagsrumVLinkquality => new(_app, new string[]{"sensor.julbelysning_vardagsrum_v_linkquality"});
        public SensorEntity HallDorrLinkquality => new(_app, new string[]{"sensor.hall_dorr_linkquality"});
        public SensorEntity JulbelysningKokVVoltage => new(_app, new string[]{"sensor.julbelysning_kok_v_voltage"});
        public SensorEntity SallysRumPirRequestedBrightnessPercent => new(_app, new string[]{"sensor.sallys_rum_pir_requested_brightness_percent"});
        public SensorEntity SmG986bBatteryState => new(_app, new string[]{"sensor.sm_g986b_battery_state"});
        public SensorEntity YtMe4le => new(_app, new string[]{"sensor.yt_me4le"});
        public SensorEntity JulbelysningTvrummetVoltage => new(_app, new string[]{"sensor.julbelysning_tvrummet_voltage"});
        public SensorEntity NetworkOutWlp2s0 => new(_app, new string[]{"sensor.network_out_wlp2s0"});
        public SensorEntity HallByraUpdateState => new(_app, new string[]{"sensor.hall_byra_update_state"});
        public SensorEntity KokPirLinkquality => new(_app, new string[]{"sensor.kok_pir_linkquality"});
        public SensorEntity Viking0203502038B700HumidityStatus => new(_app, new string[]{"sensor.viking_0203502038_b7_00_humidity_status"});
        public SensorEntity TomasRumPirLinkquality => new(_app, new string[]{"sensor.tomas_rum_pir_linkquality"});
        public SensorEntity CarDepartureTime => new(_app, new string[]{"sensor.car_departure_time"});
        public SensorEntity JulbelysningTvrummetLinkquality => new(_app, new string[]{"sensor.julbelysning_tvrummet_linkquality"});
        public SensorEntity TvrumHogerLinkquality => new(_app, new string[]{"sensor.tvrum_hoger_linkquality"});
        public SensorEntity ProcessorUse => new(_app, new string[]{"sensor.processor_use"});
        public SensorEntity TvrumRullgardinHogerBattery => new(_app, new string[]{"sensor.tvrum_rullgardin_hoger_battery"});
        public SensorEntity VardagsrumPirTemperature => new(_app, new string[]{"sensor.vardagsrum_pir_temperature"});
        public SensorEntity MelkersFonsterPowerOnBehavior => new(_app, new string[]{"sensor.melkers_fonster_power_on_behavior"});
        public SensorEntity SallysRumHum => new(_app, new string[]{"sensor.sallys_rum_hum"});
        public SensorEntity KokPirBattery => new(_app, new string[]{"sensor.kok_pir_battery"});
        public SensorEntity Ac51bc0cfe8RssiNumeric => new(_app, new string[]{"sensor.ac_51bc0cfe_8_rssi_numeric"});
        public SensorEntity Viking0203502038B700Temperature => new(_app, new string[]{"sensor.viking_0203502038_b7_00_temperature"});
        public SensorEntity Viking0203502038B700RssiNumeric => new(_app, new string[]{"sensor.viking_0203502038_b7_00_rssi_numeric"});
        public SensorEntity TvrumRullgardinVansterLinkquality => new(_app, new string[]{"sensor.tvrum_rullgardin_vanster_linkquality"});
        public SensorEntity SovrumPirRequestedBrightnessPercent => new(_app, new string[]{"sensor.sovrum_pir_requested_brightness_percent"});
        public SensorEntity SmG986bNextAlarm => new(_app, new string[]{"sensor.sm_g986b_next_alarm"});
        public SensorEntity MemoryUsePercent => new(_app, new string[]{"sensor.memory_use_percent"});
        public SensorEntity SmG986bLightSensor => new(_app, new string[]{"sensor.sm_g986b_light_sensor"});
        public SensorEntity SmG986bProximitySensor => new(_app, new string[]{"sensor.sm_g986b_proximity_sensor"});
        public SensorEntity MelkersRumTempLinkquality => new(_app, new string[]{"sensor.melkers_rum_temp_linkquality"});
        public SensorEntity Ac93bc0cfe2RssiNumeric => new(_app, new string[]{"sensor.ac_93bc0cfe_2_rssi_numeric"});
        public SensorEntity JulbelysningTvrummetEnergy => new(_app, new string[]{"sensor.julbelysning_tvrummet_energy"});
        public SensorEntity TomasIpadBatteryState => new(_app, new string[]{"sensor.tomas_ipad_battery_state"});
        public SensorEntity E0x00158d00020b7df4Battery => new(_app, new string[]{"sensor.0x00158d00020b7df4_battery"});
        public SensorEntity MelkersFonsterUpdateState => new(_app, new string[]{"sensor.melkers_fonster_update_state"});
        public SensorEntity BatteryLevel => new(_app, new string[]{"sensor.battery_level"});
        public SensorEntity CoordinatorVersion => new(_app, new string[]{"sensor.coordinator_version"});
        public SensorEntity KrisinformationVasternorrland => new(_app, new string[]{"sensor.krisinformation_vasternorrland"});
        public SensorEntity TvrumRullgardinHogerLinkquality => new(_app, new string[]{"sensor.tvrum_rullgardin_hoger_linkquality"});
        public SensorEntity TomasRumPirRequestedBrightnessLevel => new(_app, new string[]{"sensor.tomas_rum_pir_requested_brightness_level"});
        public SensorEntity VardagsrumFonsterMittenUpdateState => new(_app, new string[]{"sensor.vardagsrum_fonster_mitten_update_state"});
        public SensorEntity MelkersRumPirOccupancyLinkquality => new(_app, new string[]{"sensor.melkers_rum_pir_occupancy_linkquality"});
        public SensorEntity Viking02811A700RssiNumeric => new(_app, new string[]{"sensor.viking_02811_a7_00_rssi_numeric"});
        public SensorEntity TvrumFonsterHogerUpdateState => new(_app, new string[]{"sensor.tvrum_fonster_hoger_update_state"});
        public SensorEntity HobbyrumTempBattery => new(_app, new string[]{"sensor.hobbyrum_temp_battery"});
        public SensorEntity SovrumFonsterLinkquality => new(_app, new string[]{"sensor.sovrum_fonster_linkquality"});
        public SensorEntity DiskUsePercentHome => new(_app, new string[]{"sensor.disk_use_percent_home"});
        public SensorEntity LightOutsideBattery => new(_app, new string[]{"sensor.light_outside_battery"});
        public SensorEntity MelkersRumTempHumidity => new(_app, new string[]{"sensor.melkers_rum_temp_humidity"});
        public SensorEntity JulbelysningTomasRumUpdateState => new(_app, new string[]{"sensor.julbelysning_tomas_rum_update_state"});
        public SensorEntity SmG986bPressureSensor => new(_app, new string[]{"sensor.sm_g986b_pressure_sensor"});
        public SensorEntity YtHelto => new(_app, new string[]{"sensor.yt_helto"});
        public SensorEntity VardagsrumHogerLinkquality => new(_app, new string[]{"sensor.vardagsrum_hoger_linkquality"});
        public SensorEntity E0x00158d0001c09b01Linkquality => new(_app, new string[]{"sensor.0x00158d0001c09b01_linkquality"});
        public SensorEntity VardagsrumTempLinkquality => new(_app, new string[]{"sensor.vardagsrum_temp_linkquality"});
        public SensorEntity TvrumBakgrundTvUpdateState => new(_app, new string[]{"sensor.tvrum_bakgrund_tv_update_state"});
        public SensorEntity TomasIpadStorage2 => new(_app, new string[]{"sensor.tomas_ipad_storage_2"});
        public SensorEntity LasUppeBattery => new(_app, new string[]{"sensor.las_uppe_battery"});
        public SensorEntity UteHum => new(_app, new string[]{"sensor.ute_hum"});
        public SensorEntity TomasRumPirRequestedBrightnessPercent => new(_app, new string[]{"sensor.tomas_rum_pir_requested_brightness_percent"});
        public SensorEntity HallDorrUpdateState => new(_app, new string[]{"sensor.hall_dorr_update_state"});
        public SensorEntity JulbelysningKokVCurrent => new(_app, new string[]{"sensor.julbelysning_kok_v_current"});
        public SensorEntity JulbelysningVardagsrumHPowerOnBehavior => new(_app, new string[]{"sensor.julbelysning_vardagsrum_h_power_on_behavior"});
        public SensorEntity SmG975fBatteryState => new(_app, new string[]{"sensor.sm_g975f_battery_state"});
        public SensorEntity VardagsrumPirUpdateState => new(_app, new string[]{"sensor.vardagsrum_pir_update_state"});
        public SensorEntity VardagsrumPirIlluminance => new(_app, new string[]{"sensor.vardagsrum_pir_illuminance"});
        public SensorEntity Load1m => new(_app, new string[]{"sensor.load_1m"});
        public SensorEntity SallysRumPirRequestedBrightnessLevel => new(_app, new string[]{"sensor.sallys_rum_pir_requested_brightness_level"});
        public SensorEntity Ssid => new(_app, new string[]{"sensor.ssid"});
        public SensorEntity KokFrysTempLinkquality => new(_app, new string[]{"sensor.kok_frys_temp_linkquality"});
        public SensorEntity TvrumCubeBatt => new(_app, new string[]{"sensor.tvrum_cube_batt"});
        public SensorEntity Ac63bc0cfe9RssiNumeric => new(_app, new string[]{"sensor.ac_63bc0cfe_9_rssi_numeric"});
        public SensorEntity Viking028119700Temperature => new(_app, new string[]{"sensor.viking_02811_97_00_temperature"});
        public SensorEntity VardagsrumPirBattery => new(_app, new string[]{"sensor.vardagsrum_pir_battery"});
        public SensorEntity VardagsrumTempBattery => new(_app, new string[]{"sensor.vardagsrum_temp_battery"});
        public SensorEntity SallysRumPirBattery => new(_app, new string[]{"sensor.sallys_rum_pir_battery"});
        public SensorEntity LightOutsideLinkquality => new(_app, new string[]{"sensor.light_outside_linkquality"});
        public SensorEntity SmG986bAudioSensor => new(_app, new string[]{"sensor.sm_g986b_audio_sensor"});
        public SensorEntity Ac294734614RssiNumeric => new(_app, new string[]{"sensor.ac_2947346_14_rssi_numeric"});
        public SensorEntity UteTempBattery => new(_app, new string[]{"sensor.ute_temp_battery"});
        public SensorEntity SmG986bGeocodedLocation => new(_app, new string[]{"sensor.sm_g986b_geocoded_location"});
        public SensorEntity TvrumCubeLinkquality => new(_app, new string[]{"sensor.tvrum_cube_linkquality"});
        public SensorEntity Ac44bc0cfe1RssiNumeric => new(_app, new string[]{"sensor.ac_44bc0cfe_1_rssi_numeric"});
        public SensorEntity LastUpdateTrigger => new(_app, new string[]{"sensor.last_update_trigger"});
        public SensorEntity TvrumRullgardinVansterUpdateState => new(_app, new string[]{"sensor.tvrum_rullgardin_vanster_update_state"});
        public SensorEntity Ac34bc0cfe6RssiNumeric => new(_app, new string[]{"sensor.ac_34bc0cfe_6_rssi_numeric"});
        public SensorEntity SovrumByraLinkquality => new(_app, new string[]{"sensor.sovrum_byra_linkquality"});
        public SensorEntity TvrummVaggUpdateState => new(_app, new string[]{"sensor.tvrumm_vagg_update_state"});
        public SensorEntity KokFonsterUpdateState => new(_app, new string[]{"sensor.kok_fonster_update_state"});
        public SensorEntity Ac36bc0cfe8RssiNumeric => new(_app, new string[]{"sensor.ac_36bc0cfe_8_rssi_numeric"});
        public SensorEntity KokFonsterLillaLinkquality => new(_app, new string[]{"sensor.kok_fonster_lilla_linkquality"});
        public SensorEntity KokFonsterLillaUpdateState => new(_app, new string[]{"sensor.kok_fonster_lilla_update_state"});
        public SensorEntity UteTemp => new(_app, new string[]{"sensor.ute_temp"});
        public SensorEntity VardagsrumPirIlluminanceLux => new(_app, new string[]{"sensor.vardagsrum_pir_illuminance_lux"});
        public SensorEntity VardagsrumMittenLinkquality => new(_app, new string[]{"sensor.vardagsrum_mitten_linkquality"});
        public SensorEntity MelkersFonsterLinkquality => new(_app, new string[]{"sensor.melkers_fonster_linkquality"});
        public SensorEntity Hacs => new(_app, new string[]{"sensor.hacs"});
        public SensorEntity TomasIpadGeocodedLocation => new(_app, new string[]{"sensor.tomas_ipad_geocoded_location"});
        public SensorEntity TvrumRullgardinVansterBattery => new(_app, new string[]{"sensor.tvrum_rullgardin_vanster_battery"});
        public SensorEntity Ac294734615RssiNumeric => new(_app, new string[]{"sensor.ac_2947346_15_rssi_numeric"});
        public SensorEntity JulbelysningKokHPowerOnBehavior => new(_app, new string[]{"sensor.julbelysning_kok_h_power_on_behavior"});
        public SensorEntity SovrumTempHumidity => new(_app, new string[]{"sensor.sovrum_temp_humidity"});
        public SensorEntity SallysFonsterUpdateState => new(_app, new string[]{"sensor.sallys_fonster_update_state"});
        public SensorEntity TvrumBakgrundTvLinkquality => new(_app, new string[]{"sensor.tvrum_bakgrund_tv_linkquality"});
        public SensorEntity VardagsrumFonsterHogerUpdateState => new(_app, new string[]{"sensor.vardagsrum_fonster_hoger_update_state"});
        public SensorEntity SallysFonsterLinkquality => new(_app, new string[]{"sensor.sallys_fonster_linkquality"});
        public SensorEntity SmG986bBatteryLevel => new(_app, new string[]{"sensor.sm_g986b_battery_level"});
        public SensorEntity LightOutsideIlluminance => new(_app, new string[]{"sensor.light_outside_illuminance"});
        public SensorEntity SmG986bWifiConnection => new(_app, new string[]{"sensor.sm_g986b_wifi_connection"});
        public SensorEntity LightOutside => new(_app, new string[]{"sensor.light_outside"});
        public SensorEntity JulbelysningTvrummetPower => new(_app, new string[]{"sensor.julbelysning_tvrummet_power"});
        public SensorEntity Ac52bc0cfe1RssiNumeric => new(_app, new string[]{"sensor.ac_52bc0cfe_1_rssi_numeric"});
        public SensorEntity TrappPirLinkquality => new(_app, new string[]{"sensor.trapp_pir_linkquality"});
        public SensorEntity Viking028119700 => new(_app, new string[]{"sensor.viking_02811_97_00"});
        public SensorEntity MotorvarmareHogerUpdateState => new(_app, new string[]{"sensor.motorvarmare_hoger_update_state"});
        public SensorEntity JulbelysningKokHUpdateState => new(_app, new string[]{"sensor.julbelysning_kok_h_update_state"});
        public SensorEntity SovrumPirRequestedBrightnessLevel => new(_app, new string[]{"sensor.sovrum_pir_requested_brightness_level"});
        public SensorEntity GeocodedLocation => new(_app, new string[]{"sensor.geocoded_location"});
        public SensorEntity Load5m => new(_app, new string[]{"sensor.load_5m"});
        public SensorEntity DiodTemp => new(_app, new string[]{"sensor.diod_temp"});
        public SensorEntity KokFrysTempHumidity => new(_app, new string[]{"sensor.kok_frys_temp_humidity"});
        public SensorEntity Ac294734616RssiNumeric => new(_app, new string[]{"sensor.ac_2947346_16_rssi_numeric"});
        public SensorEntity SovrumPirBattery => new(_app, new string[]{"sensor.sovrum_pir_battery"});
        public SensorEntity TomasRumLinkquality => new(_app, new string[]{"sensor.tomas_rum_linkquality"});
        public SensorEntity SovrumTemp => new(_app, new string[]{"sensor.sovrum_temp"});
        public SensorEntity Ac18ce36212RssiNumeric => new(_app, new string[]{"sensor.ac_18ce362_12_rssi_numeric"});
        public SensorEntity KokFrysTemp => new(_app, new string[]{"sensor.kok_frys_temp"});
        public SensorEntity HallByraLinkquality => new(_app, new string[]{"sensor.hall_byra_linkquality"});
        public SensorEntity TomasIpadConnectionType => new(_app, new string[]{"sensor.tomas_ipad_connection_type"});
        public SensorEntity Viking028119700BatteryNumeric => new(_app, new string[]{"sensor.viking_02811_97_00_battery_numeric"});
        public SensorEntity VardagsrumPirOccupancyTimeout => new(_app, new string[]{"sensor.vardagsrum_pir_occupancy_timeout"});
        public SensorEntity TomasIpadBssid => new(_app, new string[]{"sensor.tomas_ipad_bssid"});
        public SensorEntity Viking028119700RssiNumeric => new(_app, new string[]{"sensor.viking_02811_97_00_rssi_numeric"});
        public SensorEntity SovrumFonsterUpdateState => new(_app, new string[]{"sensor.sovrum_fonster_update_state"});
        public SensorEntity Viking0203502038B700BatteryNumeric => new(_app, new string[]{"sensor.viking_0203502038_b7_00_battery_numeric"});
        public SensorEntity HobbyrumTemp => new(_app, new string[]{"sensor.hobbyrum_temp"});
        public SensorEntity SmG986bDoNotDisturbSensor => new(_app, new string[]{"sensor.sm_g986b_do_not_disturb_sensor"});
        public SensorEntity Activity => new(_app, new string[]{"sensor.activity"});
        public SensorEntity KokPirIlluminance => new(_app, new string[]{"sensor.kok_pir_illuminance"});
        public SensorEntity JulbelysningVardagsrumVUpdateState => new(_app, new string[]{"sensor.julbelysning_vardagsrum_v_update_state"});
        public SensorEntity SovrumByraUpdateState => new(_app, new string[]{"sensor.sovrum_byra_update_state"});
        public SensorEntity TvrumVansterLinkquality => new(_app, new string[]{"sensor.tvrum_vanster_linkquality"});
        public SensorEntity MelkersRumPirOccupancyBattery => new(_app, new string[]{"sensor.melkers_rum_pir_occupancy_battery"});
        public SensorEntity TvrumRullgardinHogerUpdateState => new(_app, new string[]{"sensor.tvrum_rullgardin_hoger_update_state"});
        public SensorEntity HouseMode => new(_app, new string[]{"sensor.house_mode"});
        public SensorEntity HobbyrumTempHum => new(_app, new string[]{"sensor.hobbyrum_temp_hum"});
        public SensorEntity SmG975fBatteryLevel => new(_app, new string[]{"sensor.sm_g975f_battery_level"});
        public SensorEntity SmG975fGeocodedLocation => new(_app, new string[]{"sensor.sm_g975f_geocoded_location"});
        public SensorEntity HumOutside => new(_app, new string[]{"sensor.hum_outside"});
        public SensorEntity SovrumPirLinkquality => new(_app, new string[]{"sensor.sovrum_pir_linkquality"});
        public SensorEntity ConnectionType => new(_app, new string[]{"sensor.connection_type"});
        public SensorEntity SnapshotBackup => new(_app, new string[]{"sensor.snapshot_backup"});
        public SensorEntity MelkersRumPirOccupancyRequestedBrightnessLevel => new(_app, new string[]{"sensor.melkers_rum_pir_occupancy_requested_brightness_level"});
        public SensorEntity Ac15bc0cfe1RssiNumeric => new(_app, new string[]{"sensor.ac_15bc0cfe_1_rssi_numeric"});
        public SensorEntity TomasIpadSsid => new(_app, new string[]{"sensor.tomas_ipad_ssid"});
        public SensorEntity VardagsrumFonsterVansterUpdateState => new(_app, new string[]{"sensor.vardagsrum_fonster_vanster_update_state"});
        public SensorEntity KokFrysTempBattery => new(_app, new string[]{"sensor.kok_frys_temp_battery"});
        public SensorEntity GymLedUpdateState => new(_app, new string[]{"sensor.gym_led_update_state"});
        public SensorEntity Ac29bc0cfe6RssiNumeric => new(_app, new string[]{"sensor.ac_29bc0cfe_6_rssi_numeric"});
        public SensorEntity Ac50bc0cfe8RssiNumeric => new(_app, new string[]{"sensor.ac_50bc0cfe_8_rssi_numeric"});
        public SensorEntity TomasIpadBatteryLevel => new(_app, new string[]{"sensor.tomas_ipad_battery_level"});
        public SensorEntity VardagsrumTempHumidity => new(_app, new string[]{"sensor.vardagsrum_temp_humidity"});
        public SensorEntity SallysRumPirLinkquality => new(_app, new string[]{"sensor.sallys_rum_pir_linkquality"});
        public SensorEntity VardagsrumTemp => new(_app, new string[]{"sensor.vardagsrum_temp"});
        public SensorEntity SallysFonsterPowerOnBehavior => new(_app, new string[]{"sensor.sallys_fonster_power_on_behavior"});
        public SensorEntity Zigbee2mqttBridgeState => new(_app, new string[]{"sensor.zigbee2mqtt_bridge_state"});
        public SensorEntity JulbelysningTomasRumLinkquality => new(_app, new string[]{"sensor.julbelysning_tomas_rum_linkquality"});
    }

    public partial class CameraEntities
    {
        private readonly NetDaemonRxApp _app;
        public CameraEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public CameraEntity Cam1 => new(_app, new string[]{"camera.cam1"});
        public CameraEntity FramsidanProfile000Mainstream => new(_app, new string[]{"camera.framsidan_profile000_mainstream"});
        public CameraEntity KameraStream => new(_app, new string[]{"camera.kamera_stream"});
        public CameraEntity FramsidanProfile000Mainstream2 => new(_app, new string[]{"camera.framsidan_profile000_mainstream_2"});
        public CameraEntity MyCamera => new(_app, new string[]{"camera.my_camera"});
        public CameraEntity Kamera3 => new(_app, new string[]{"camera.kamera_3"});
    }

    public partial class DeviceTrackerEntities
    {
        private readonly NetDaemonRxApp _app;
        public DeviceTrackerEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public DeviceTrackerEntity Uppe => new(_app, new string[]{"device_tracker.uppe"});
        public DeviceTrackerEntity MelkerPresence => new(_app, new string[]{"device_tracker.melker_presence"});
        public DeviceTrackerEntity SonoffTest => new(_app, new string[]{"device_tracker.sonoff_test"});
        public DeviceTrackerEntity GalaxyS10 => new(_app, new string[]{"device_tracker.galaxy_s10"});
        public DeviceTrackerEntity Unifi0024E451550aDefault => new(_app, new string[]{"device_tracker.unifi_00_24_e4_51_55_0a_default"});
        public DeviceTrackerEntity Hpg2e024 => new(_app, new string[]{"device_tracker.hpg2e024"});
        public DeviceTrackerEntity Dafang => new(_app, new string[]{"device_tracker.dafang"});
        public DeviceTrackerEntity Shelly1 => new(_app, new string[]{"device_tracker.shelly_1"});
        public DeviceTrackerEntity TomasPresence => new(_app, new string[]{"device_tracker.tomas_presence"});
        public DeviceTrackerEntity Nere => new(_app, new string[]{"device_tracker.nere"});
        public DeviceTrackerEntity Unifi862c82A4F469Default => new(_app, new string[]{"device_tracker.unifi_86_2c_82_a4_f4_69_default"});
        public DeviceTrackerEntity Piserver5 => new(_app, new string[]{"device_tracker.piserver_5"});
        public DeviceTrackerEntity Octopi => new(_app, new string[]{"device_tracker.octopi"});
        public DeviceTrackerEntity Sonoff1 => new(_app, new string[]{"device_tracker.sonoff1"});
        public DeviceTrackerEntity Tomasgps => new(_app, new string[]{"device_tracker.tomasgps"});
        public DeviceTrackerEntity Piserver4 => new(_app, new string[]{"device_tracker.piserver_4"});
        public DeviceTrackerEntity GalaxyS8 => new(_app, new string[]{"device_tracker.galaxy_s8"});
        public DeviceTrackerEntity Harmony => new(_app, new string[]{"device_tracker.harmony"});
        public DeviceTrackerEntity YeelinkLightColor1Miio867704 => new(_app, new string[]{"device_tracker.yeelink_light_color1_miio867704"});
        public DeviceTrackerEntity Sallygps => new(_app, new string[]{"device_tracker.sallygps"});
        public DeviceTrackerEntity NintendoWiiU2 => new(_app, new string[]{"device_tracker.nintendo_wii_u_2"});
        public DeviceTrackerEntity GoogleMaps110786808112177763666 => new(_app, new string[]{"device_tracker.google_maps_110786808112177763666"});
        public DeviceTrackerEntity TomasIpad => new(_app, new string[]{"device_tracker.tomas_ipad"});
        public DeviceTrackerEntity Piserver6 => new(_app, new string[]{"device_tracker.piserver_6"});
        public DeviceTrackerEntity E1921681104F83f512eB4E6 => new(_app, new string[]{"device_tracker.192_168_1_104_f8_3f_51_2e_b4_e6"});
        public DeviceTrackerEntity Piserver2 => new(_app, new string[]{"device_tracker.piserver_2"});
        public DeviceTrackerEntity Piserver7 => new(_app, new string[]{"device_tracker.piserver_7"});
        public DeviceTrackerEntity SmG975f => new(_app, new string[]{"device_tracker.sm_g975f"});
        public DeviceTrackerEntity MelkerGalaxyWifi => new(_app, new string[]{"device_tracker.melker_galaxy_wifi"});
        public DeviceTrackerEntity UnifiE0D4E80330F9Default => new(_app, new string[]{"device_tracker.unifi_e0_d4_e8_03_30_f9_default"});
        public DeviceTrackerEntity Googlehome3 => new(_app, new string[]{"device_tracker.googlehome_3"});
        public DeviceTrackerEntity EspKamera1 => new(_app, new string[]{"device_tracker.esp_kamera_1"});
        public DeviceTrackerEntity EmelieIphone => new(_app, new string[]{"device_tracker.emelie_iphone"});
        public DeviceTrackerEntity GoogleHomeMini5 => new(_app, new string[]{"device_tracker.google_home_mini_5"});
        public DeviceTrackerEntity GoogleHome => new(_app, new string[]{"device_tracker.google_home"});
        public DeviceTrackerEntity Raspberrypi3 => new(_app, new string[]{"device_tracker.raspberrypi_3"});
        public DeviceTrackerEntity ElgatoKeyLightAirAcae => new(_app, new string[]{"device_tracker.elgato_key_light_air_acae"});
        public DeviceTrackerEntity SamsungGalaxyS7 => new(_app, new string[]{"device_tracker.samsung_galaxy_s7"});
        public DeviceTrackerEntity NintendoWiiU => new(_app, new string[]{"device_tracker.nintendo_wii_u"});
        public DeviceTrackerEntity Esp12Test => new(_app, new string[]{"device_tracker.esp_12_test"});
        public DeviceTrackerEntity ElinsIpad => new(_app, new string[]{"device_tracker.elins_ipad"});
        public DeviceTrackerEntity EfraimsIphone => new(_app, new string[]{"device_tracker.efraims_iphone"});
        public DeviceTrackerEntity E5cg709284w => new(_app, new string[]{"device_tracker.5cg709284w"});
        public DeviceTrackerEntity E5cg8292f67 => new(_app, new string[]{"device_tracker.5cg8292f67"});
        public DeviceTrackerEntity HuaweiMate20Pro3c5327 => new(_app, new string[]{"device_tracker.huawei_mate_20_pro_3c5327"});
        public DeviceTrackerEntity Unifi2c2617B78551Default => new(_app, new string[]{"device_tracker.unifi_2c_26_17_b7_85_51_default"});
        public DeviceTrackerEntity NestAudio2 => new(_app, new string[]{"device_tracker.nest_audio_2"});
        public DeviceTrackerEntity Piserver => new(_app, new string[]{"device_tracker.piserver"});
        public DeviceTrackerEntity Chromecast => new(_app, new string[]{"device_tracker.chromecast"});
        public DeviceTrackerEntity NestAudio => new(_app, new string[]{"device_tracker.nest_audio"});
        public DeviceTrackerEntity ElinsIpad2 => new(_app, new string[]{"device_tracker.elins_ipad_2"});
        public DeviceTrackerEntity GoogleMaps115932713534918928318 => new(_app, new string[]{"device_tracker.google_maps_115932713534918928318"});
        public DeviceTrackerEntity EspKamera12 => new(_app, new string[]{"device_tracker.esp_kamera_1_2"});
        public DeviceTrackerEntity Chromecast4 => new(_app, new string[]{"device_tracker.chromecast_4"});
        public DeviceTrackerEntity TomasIpad3 => new(_app, new string[]{"device_tracker.tomas_ipad_3"});
        public DeviceTrackerEntity E5cg81709hj => new(_app, new string[]{"device_tracker.5cg81709hj"});
        public DeviceTrackerEntity GoogleMapsTomash277hassioGmailCom => new(_app, new string[]{"device_tracker.google_maps_tomash277hassio_gmail_com"});
        public DeviceTrackerEntity GoogleHomeMini => new(_app, new string[]{"device_tracker.google_home_mini"});
        public DeviceTrackerEntity EspD6983d => new(_app, new string[]{"device_tracker.esp_d6983d"});
        public DeviceTrackerEntity GalaxyTabA3 => new(_app, new string[]{"device_tracker.galaxy_tab_a_3"});
        public DeviceTrackerEntity SallyIphone2 => new(_app, new string[]{"device_tracker.sally_iphone_2"});
        public DeviceTrackerEntity UnifiAcFdCe031c4aDefault => new(_app, new string[]{"device_tracker.unifi_ac_fd_ce_03_1c_4a_default"});
        public DeviceTrackerEntity TomasIpad6 => new(_app, new string[]{"device_tracker.tomas_ipad_6"});
        public DeviceTrackerEntity Tomaspc => new(_app, new string[]{"device_tracker.tomaspc"});
        public DeviceTrackerEntity TomasGamlaPad => new(_app, new string[]{"device_tracker.tomas_gamla_pad"});
        public DeviceTrackerEntity TomasIpad4 => new(_app, new string[]{"device_tracker.tomas_ipad_4"});
        public DeviceTrackerEntity SallyHuaweiWifi => new(_app, new string[]{"device_tracker.sally_huawei_wifi"});
        public DeviceTrackerEntity GoogleMaps118123190245690142371 => new(_app, new string[]{"device_tracker.google_maps_118123190245690142371"});
        public DeviceTrackerEntity Piserver8 => new(_app, new string[]{"device_tracker.piserver_8"});
        public DeviceTrackerEntity ElinPresence => new(_app, new string[]{"device_tracker.elin_presence"});
        public DeviceTrackerEntity EspA82880 => new(_app, new string[]{"device_tracker.esp_a82880"});
        public DeviceTrackerEntity TomasGalaxyWifiOld => new(_app, new string[]{"device_tracker.tomas_galaxy_wifi_old"});
        public DeviceTrackerEntity Chromecast3 => new(_app, new string[]{"device_tracker.chromecast_3"});
        public DeviceTrackerEntity Unifi04D3B0632d29Default => new(_app, new string[]{"device_tracker.unifi_04_d3_b0_63_2d_29_default"});
        public DeviceTrackerEntity Chromecast5 => new(_app, new string[]{"device_tracker.chromecast_5"});
        public DeviceTrackerEntity Ipad2 => new(_app, new string[]{"device_tracker.ipad_2"});
        public DeviceTrackerEntity Piserver3 => new(_app, new string[]{"device_tracker.piserver_3"});
        public DeviceTrackerEntity Xboxsystemos => new(_app, new string[]{"device_tracker.xboxsystemos"});
        public DeviceTrackerEntity ElinGalaxyWifi => new(_app, new string[]{"device_tracker.elin_galaxy_wifi"});
        public DeviceTrackerEntity MelkerHuaweiWifi => new(_app, new string[]{"device_tracker.melker_huawei_wifi"});
        public DeviceTrackerEntity Tomass8 => new(_app, new string[]{"device_tracker.tomass8"});
        public DeviceTrackerEntity UnifiC417Fe4d8f42Default => new(_app, new string[]{"device_tracker.unifi_c4_17_fe_4d_8f_42_default"});
        public DeviceTrackerEntity HuaweiMate10LiteD2b0a => new(_app, new string[]{"device_tracker.huawei_mate_10_lite_d2b0a"});
        public DeviceTrackerEntity Tomasipad => new(_app, new string[]{"device_tracker.tomasipad"});
        public DeviceTrackerEntity GalaxyTabA => new(_app, new string[]{"device_tracker.galaxy_tab_a"});
        public DeviceTrackerEntity SallyIphone => new(_app, new string[]{"device_tracker.sally_iphone"});
        public DeviceTrackerEntity E0024E451550a => new(_app, new string[]{"device_tracker.00_24_e4_51_55_0a"});
        public DeviceTrackerEntity Melkergps => new(_app, new string[]{"device_tracker.melkergps"});
        public DeviceTrackerEntity SmG986b => new(_app, new string[]{"device_tracker.sm_g986b"});
        public DeviceTrackerEntity TomasIpad5 => new(_app, new string[]{"device_tracker.tomas_ipad_5"});
        public DeviceTrackerEntity GoogleHomeMini2 => new(_app, new string[]{"device_tracker.google_home_mini_2"});
        public DeviceTrackerEntity GoogleHomeMini4 => new(_app, new string[]{"device_tracker.google_home_mini_4"});
        public DeviceTrackerEntity Elinsipad => new(_app, new string[]{"device_tracker.elinsipad"});
        public DeviceTrackerEntity Googlehome2 => new(_app, new string[]{"device_tracker.googlehome_2"});
        public DeviceTrackerEntity GalaxywatchBc7b => new(_app, new string[]{"device_tracker.galaxywatch_bc7b"});
        public DeviceTrackerEntity GoogleHomeMini3 => new(_app, new string[]{"device_tracker.google_home_mini_3"});
        public DeviceTrackerEntity SallyPresence => new(_app, new string[]{"device_tracker.sally_presence"});
        public DeviceTrackerEntity ElgatoKeyLightAirA847 => new(_app, new string[]{"device_tracker.elgato_key_light_air_a847"});
        public DeviceTrackerEntity XboxSystemos => new(_app, new string[]{"device_tracker.xbox_systemos"});
        public DeviceTrackerEntity TomasGalaxyWifi => new(_app, new string[]{"device_tracker.tomas_galaxy_wifi"});
        public DeviceTrackerEntity Chromecast2 => new(_app, new string[]{"device_tracker.chromecast_2"});
        public DeviceTrackerEntity ElinsIpad3 => new(_app, new string[]{"device_tracker.elins_ipad_3"});
        public DeviceTrackerEntity ElinGalaxyWifiOld => new(_app, new string[]{"device_tracker.elin_galaxy_wifi_old"});
        public DeviceTrackerEntity Ipad => new(_app, new string[]{"device_tracker.ipad"});
        public DeviceTrackerEntity Raspberrypi => new(_app, new string[]{"device_tracker.raspberrypi"});
        public DeviceTrackerEntity GalaxyTabA2 => new(_app, new string[]{"device_tracker.galaxy_tab_a_2"});
        public DeviceTrackerEntity Raspberrypi2 => new(_app, new string[]{"device_tracker.raspberrypi_2"});
        public DeviceTrackerEntity Samsunggalaxys7 => new(_app, new string[]{"device_tracker.samsunggalaxys7"});
        public DeviceTrackerEntity TomasIpad2 => new(_app, new string[]{"device_tracker.tomas_ipad_2"});
        public DeviceTrackerEntity ElinGalaxyWifiOldOold => new(_app, new string[]{"device_tracker.elin_galaxy_wifi_old_oold"});
        public DeviceTrackerEntity GoogleMaps113728439587103002947 => new(_app, new string[]{"device_tracker.google_maps_113728439587103002947"});
    }

    public partial class BinarySensorEntities
    {
        private readonly NetDaemonRxApp _app;
        public BinarySensorEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public BinarySensorEntity Ac67bc0cfe4 => new(_app, new string[]{"binary_sensor.ac_67bc0cfe_4"});
        public BinarySensorEntity TvrumRullgardinHogerUpdateAvailable => new(_app, new string[]{"binary_sensor.tvrum_rullgardin_hoger_update_available"});
        public BinarySensorEntity JulbelysningHogerUpdateAvailable => new(_app, new string[]{"binary_sensor.julbelysning_hoger_update_available"});
        public BinarySensorEntity TvrumHogerUpdateAvailable => new(_app, new string[]{"binary_sensor.tvrum_hoger_update_available"});
        public BinarySensorEntity KokPir => new(_app, new string[]{"binary_sensor.kok_pir"});
        public BinarySensorEntity HallByraUpdateAvailable => new(_app, new string[]{"binary_sensor.hall_byra_update_available"});
        public BinarySensorEntity Ac55bc0cfe7 => new(_app, new string[]{"binary_sensor.ac_55bc0cfe_7"});
        public BinarySensorEntity SnapshotsStale => new(_app, new string[]{"binary_sensor.snapshots_stale"});
        public BinarySensorEntity SweRecyclingVattjom => new(_app, new string[]{"binary_sensor.swe_recycling_vattjom"});
        public BinarySensorEntity VardagsrumHogerUpdateAvailable => new(_app, new string[]{"binary_sensor.vardagsrum_hoger_update_available"});
        public BinarySensorEntity Ac72bc0cfe2 => new(_app, new string[]{"binary_sensor.ac_72bc0cfe_2"});
        public BinarySensorEntity Ac52bc0cfe1 => new(_app, new string[]{"binary_sensor.ac_52bc0cfe_1"});
        public BinarySensorEntity Ac39bc0cfe7 => new(_app, new string[]{"binary_sensor.ac_39bc0cfe_7"});
        public BinarySensorEntity Ac2bc0cfe1 => new(_app, new string[]{"binary_sensor.ac_2bc0cfe_1"});
        public BinarySensorEntity VardagsrumPir => new(_app, new string[]{"binary_sensor.vardagsrum_pir"});
        public BinarySensorEntity HallDorr => new(_app, new string[]{"binary_sensor.hall_dorr"});
        public BinarySensorEntity FarstukvistLedUpdateAvailable => new(_app, new string[]{"binary_sensor.farstukvist_led_update_available"});
        public BinarySensorEntity TomasRumPir => new(_app, new string[]{"binary_sensor.tomas_rum_pir"});
        public BinarySensorEntity MelkersFonsterUpdateAvailable => new(_app, new string[]{"binary_sensor.melkers_fonster_update_available"});
        public BinarySensorEntity SovrumPir => new(_app, new string[]{"binary_sensor.sovrum_pir"});
        public BinarySensorEntity Ac50bc0cfe8 => new(_app, new string[]{"binary_sensor.ac_50bc0cfe_8"});
        public BinarySensorEntity GymLedUpdateAvailable => new(_app, new string[]{"binary_sensor.gym_led_update_available"});
        public BinarySensorEntity Sonoff1Button => new(_app, new string[]{"binary_sensor.sonoff1_button"});
        public BinarySensorEntity JulbelysningKokHUpdateAvailable => new(_app, new string[]{"binary_sensor.julbelysning_kok_h_update_available"});
        public BinarySensorEntity SovrumFonsterUpdateAvailable => new(_app, new string[]{"binary_sensor.sovrum_fonster_update_available"});
        public BinarySensorEntity TvrumRullgardinVansterUpdateAvailable => new(_app, new string[]{"binary_sensor.tvrum_rullgardin_vanster_update_available"});
        public BinarySensorEntity Ac44bc0cfe1 => new(_app, new string[]{"binary_sensor.ac_44bc0cfe_1"});
        public BinarySensorEntity SweRecyclingMatfors => new(_app, new string[]{"binary_sensor.swe_recycling_matfors"});
        public BinarySensorEntity SallysRumPir => new(_app, new string[]{"binary_sensor.sallys_rum_pir"});
        public BinarySensorEntity SwInput => new(_app, new string[]{"binary_sensor.sw_input"});
        public BinarySensorEntity KokFonsterLillaUpdateAvailable => new(_app, new string[]{"binary_sensor.kok_fonster_lilla_update_available"});
        public BinarySensorEntity Ac51bc0cfe4 => new(_app, new string[]{"binary_sensor.ac_51bc0cfe_4"});
        public BinarySensorEntity TomasRumUpdateAvailable => new(_app, new string[]{"binary_sensor.tomas_rum_update_available"});
        public BinarySensorEntity MotorvarmareHogerUpdateAvailable => new(_app, new string[]{"binary_sensor.motorvarmare_hoger_update_available"});
        public BinarySensorEntity JulbelysningVardagsrumVUpdateAvailable => new(_app, new string[]{"binary_sensor.julbelysning_vardagsrum_v_update_available"});
        public BinarySensorEntity VardagsrumMittenUpdateAvailable => new(_app, new string[]{"binary_sensor.vardagsrum_mitten_update_available"});
        public BinarySensorEntity Ac36bc0cfe8 => new(_app, new string[]{"binary_sensor.ac_36bc0cfe_8"});
        public BinarySensorEntity Ac294734614 => new(_app, new string[]{"binary_sensor.ac_2947346_14"});
        public BinarySensorEntity Updater => new(_app, new string[]{"binary_sensor.updater"});
        public BinarySensorEntity TrappPir => new(_app, new string[]{"binary_sensor.trapp_pir"});
        public BinarySensorEntity TomasRumPirUpdateAvailable => new(_app, new string[]{"binary_sensor.tomas_rum_pir_update_available"});
        public BinarySensorEntity Ac34bc0cfe6 => new(_app, new string[]{"binary_sensor.ac_34bc0cfe_6"});
        public BinarySensorEntity Ac29bc0cfe6 => new(_app, new string[]{"binary_sensor.ac_29bc0cfe_6"});
        public BinarySensorEntity Ac15bc0cfe1 => new(_app, new string[]{"binary_sensor.ac_15bc0cfe_1"});
        public BinarySensorEntity SovrumPirUpdateAvailable => new(_app, new string[]{"binary_sensor.sovrum_pir_update_available"});
        public BinarySensorEntity KokFonsterUpdateAvailable => new(_app, new string[]{"binary_sensor.kok_fonster_update_available"});
        public BinarySensorEntity Ac294734616 => new(_app, new string[]{"binary_sensor.ac_2947346_16"});
        public BinarySensorEntity VardagsrumPirUpdateAvailable => new(_app, new string[]{"binary_sensor.vardagsrum_pir_update_available"});
        public BinarySensorEntity TvrumVansterUpdateAvailable => new(_app, new string[]{"binary_sensor.tvrum_vanster_update_available"});
        public BinarySensorEntity SmG986bIsCharging => new(_app, new string[]{"binary_sensor.sm_g986b_is_charging"});
        public BinarySensorEntity Ac18ce36211 => new(_app, new string[]{"binary_sensor.ac_18ce362_11"});
        public BinarySensorEntity MelkersRumPirOccupancy => new(_app, new string[]{"binary_sensor.melkers_rum_pir_occupancy"});
        public BinarySensorEntity TvrumBakgrundTvUpdateAvailable => new(_app, new string[]{"binary_sensor.tvrum_bakgrund_tv_update_available"});
        public BinarySensorEntity JulbelysningTomasRumUpdateAvailable => new(_app, new string[]{"binary_sensor.julbelysning_tomas_rum_update_available"});
        public BinarySensorEntity MelkersRumPirOccupancyUpdateAvailable => new(_app, new string[]{"binary_sensor.melkers_rum_pir_occupancy_update_available"});
        public BinarySensorEntity VardagsrumVansterUpdateAvailable => new(_app, new string[]{"binary_sensor.vardagsrum_vanster_update_available"});
        public BinarySensorEntity Ac63bc0cfe9 => new(_app, new string[]{"binary_sensor.ac_63bc0cfe_9"});
        public BinarySensorEntity Ac93bc0cfe2 => new(_app, new string[]{"binary_sensor.ac_93bc0cfe_2"});
        public BinarySensorEntity HallDorrUpdateAvailable => new(_app, new string[]{"binary_sensor.hall_dorr_update_available"});
        public BinarySensorEntity SallysRumPirUpdateAvailable => new(_app, new string[]{"binary_sensor.sallys_rum_pir_update_available"});
        public BinarySensorEntity Ac51bc0cfe8 => new(_app, new string[]{"binary_sensor.ac_51bc0cfe_8"});
        public BinarySensorEntity Ac294734615 => new(_app, new string[]{"binary_sensor.ac_2947346_15"});
        public BinarySensorEntity SovrumByraUpdateAvailable => new(_app, new string[]{"binary_sensor.sovrum_byra_update_available"});
        public BinarySensorEntity Ac81bc0cfe1 => new(_app, new string[]{"binary_sensor.ac_81bc0cfe_1"});
        public BinarySensorEntity TvrumPir => new(_app, new string[]{"binary_sensor.tvrum_pir"});
        public BinarySensorEntity Ac18ce36212 => new(_app, new string[]{"binary_sensor.ac_18ce362_12"});
        public BinarySensorEntity Kamera3MotionDetected => new(_app, new string[]{"binary_sensor.kamera_3_motion_detected"});
        public BinarySensorEntity TvrummVaggUpdateAvailable => new(_app, new string[]{"binary_sensor.tvrumm_vagg_update_available"});
        public BinarySensorEntity SallysFonsterUpdateAvailable => new(_app, new string[]{"binary_sensor.sallys_fonster_update_available"});
    }

    public partial class ProximityEntities
    {
        private readonly NetDaemonRxApp _app;
        public ProximityEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public ProximityEntity ProxHomeMelker => new(_app, new string[]{"proximity.prox_home_melker"});
        public ProximityEntity ProxHomeTomas => new(_app, new string[]{"proximity.prox_home_tomas"});
        public ProximityEntity ProxHomeElin => new(_app, new string[]{"proximity.prox_home_elin"});
        public ProximityEntity ProxHomeSally => new(_app, new string[]{"proximity.prox_home_sally"});
    }

    public partial class GroupEntities
    {
        private readonly NetDaemonRxApp _app;
        public GroupEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public GroupEntity Presence => new(_app, new string[]{"group.presence"});
        public GroupEntity LowBatteryDevices => new(_app, new string[]{"group.low_battery_devices"});
        public GroupEntity SystemMetrix => new(_app, new string[]{"group.system_metrix"});
        public GroupEntity Remotes => new(_app, new string[]{"group.remotes"});
        public GroupEntity PeopleStatus => new(_app, new string[]{"group.people_status"});
        public GroupEntity Cameras => new(_app, new string[]{"group.cameras"});
        public GroupEntity TomasDevices => new(_app, new string[]{"group.tomas_devices"});
        public GroupEntity Chromecasts => new(_app, new string[]{"group.chromecasts"});
        public GroupEntity ElinsDevices => new(_app, new string[]{"group.elins_devices"});
        public GroupEntity MelkersDevices => new(_app, new string[]{"group.melkers_devices"});
        public GroupEntity KameraUppe => new(_app, new string[]{"group.kamera_uppe"});
        public GroupEntity Googlehomes => new(_app, new string[]{"group.googlehomes"});
        public GroupEntity SallysDevices => new(_app, new string[]{"group.sallys_devices"});
        public GroupEntity Kodis => new(_app, new string[]{"group.kodis"});
        public GroupEntity Climate => new(_app, new string[]{"group.climate"});
        public GroupEntity Dummy => new(_app, new string[]{"group.dummy"});
    }

    public partial class SwitchEntities
    {
        private readonly NetDaemonRxApp _app;
        public SwitchEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public SwitchEntity NetdaemonHacsNotifyOnUpdate => new(_app, new string[]{"switch.netdaemon_hacs_notify_on_update"});
        public SwitchEntity Ac18ce36212 => new(_app, new string[]{"switch.ac_18ce362_12"});
        public SwitchEntity Ac15bc0cfe1 => new(_app, new string[]{"switch.ac_15bc0cfe_1"});
        public SwitchEntity Ac93bc0cfe2 => new(_app, new string[]{"switch.ac_93bc0cfe_2"});
        public SwitchEntity Film => new(_app, new string[]{"switch.film"});
        public SwitchEntity NetdaemonHouseStateManager => new(_app, new string[]{"switch.netdaemon_house_state_manager"});
        public SwitchEntity TvrumVagg => new(_app, new string[]{"switch.tvrum_vagg"});
        public SwitchEntity NetdaemonHelloWorldApp => new(_app, new string[]{"switch.netdaemon_hello_world_app"});
        public SwitchEntity Ac294734614 => new(_app, new string[]{"switch.ac_2947346_14"});
        public SwitchEntity NetdaemonTv => new(_app, new string[]{"switch.netdaemon_tv"});
        public SwitchEntity ShellyRelay => new(_app, new string[]{"switch.shelly_relay"});
        public SwitchEntity Ac44bc0cfe1 => new(_app, new string[]{"switch.ac_44bc0cfe_1"});
        public SwitchEntity ADiod => new(_app, new string[]{"switch.a_diod"});
        public SwitchEntity Ac81bc0cfe1 => new(_app, new string[]{"switch.ac_81bc0cfe_1"});
        public SwitchEntity ComputerTomas => new(_app, new string[]{"switch.computer_tomas"});
        public SwitchEntity Ac2bc0cfe1 => new(_app, new string[]{"switch.ac_2bc0cfe_1"});
        public SwitchEntity Ac50bc0cfe8 => new(_app, new string[]{"switch.ac_50bc0cfe_8"});
        public SwitchEntity JulbelysningTomasRum => new(_app, new string[]{"switch.julbelysning_tomas_rum"});
        public SwitchEntity NetdaemonMotion => new(_app, new string[]{"switch.netdaemon_motion"});
        public SwitchEntity Ac294734615 => new(_app, new string[]{"switch.ac_2947346_15"});
        public SwitchEntity Kodi => new(_app, new string[]{"switch.kodi"});
        public SwitchEntity NetdaemonRoomSpecific => new(_app, new string[]{"switch.netdaemon_room_specific"});
        public SwitchEntity JulbelysningVardagsrumV => new(_app, new string[]{"switch.julbelysning_vardagsrum_v"});
        public SwitchEntity Ac67bc0cfe4 => new(_app, new string[]{"switch.ac_67bc0cfe_4"});
        public SwitchEntity Ac36bc0cfe8 => new(_app, new string[]{"switch.ac_36bc0cfe_8"});
        public SwitchEntity NetdaemonWelcomeHome => new(_app, new string[]{"switch.netdaemon_welcome_home"});
        public SwitchEntity Sonoff1Relay => new(_app, new string[]{"switch.sonoff1_relay"});
        public SwitchEntity JulbelysningVardagsrumH => new(_app, new string[]{"switch.julbelysning_vardagsrum_h"});
        public SwitchEntity Zigbee2mqttMainJoin => new(_app, new string[]{"switch.zigbee2mqtt_main_join"});
        public SwitchEntity Ac18ce36211 => new(_app, new string[]{"switch.ac_18ce362_11"});
        public SwitchEntity JulbelysningKokV => new(_app, new string[]{"switch.julbelysning_kok_v"});
        public SwitchEntity Ac39bc0cfe7 => new(_app, new string[]{"switch.ac_39bc0cfe_7"});
        public SwitchEntity Ac55bc0cfe7 => new(_app, new string[]{"switch.ac_55bc0cfe_7"});
        public SwitchEntity Tv => new(_app, new string[]{"switch.tv"});
        public SwitchEntity NetdaemonFrys => new(_app, new string[]{"switch.netdaemon_frys"});
        public SwitchEntity NetdaemonMagicCube => new(_app, new string[]{"switch.netdaemon_magic_cube"});
        public SwitchEntity Ac29bc0cfe6 => new(_app, new string[]{"switch.ac_29bc0cfe_6"});
        public SwitchEntity NetdaemonCalendarTrash => new(_app, new string[]{"switch.netdaemon_calendar_trash"});
        public SwitchEntity Switch8MelkersTv => new(_app, new string[]{"switch.switch8_melkers_tv"});
        public SwitchEntity Ac51bc0cfe8 => new(_app, new string[]{"switch.ac_51bc0cfe_8"});
        public SwitchEntity NetdaemonLightManager => new(_app, new string[]{"switch.netdaemon_light_manager"});
        public SwitchEntity Ac34bc0cfe6 => new(_app, new string[]{"switch.ac_34bc0cfe_6"});
        public SwitchEntity NetdaemonWebhook => new(_app, new string[]{"switch.netdaemon_webhook"});
        public SwitchEntity Ac294734616 => new(_app, new string[]{"switch.ac_2947346_16"});
        public SwitchEntity MotorvarmareHoger => new(_app, new string[]{"switch.motorvarmare_hoger"});
        public SwitchEntity JulbelysningTvrummet => new(_app, new string[]{"switch.julbelysning_tvrummet"});
        public SwitchEntity Ac52bc0cfe1 => new(_app, new string[]{"switch.ac_52bc0cfe_1"});
        public SwitchEntity Ac51bc0cfe4 => new(_app, new string[]{"switch.ac_51bc0cfe_4"});
        public SwitchEntity MelkersRumFonster => new(_app, new string[]{"switch.melkers_rum_fonster"});
        public SwitchEntity NetdaemonMotorvarmare => new(_app, new string[]{"switch.netdaemon_motorvarmare"});
        public SwitchEntity JulbelysningKokH => new(_app, new string[]{"switch.julbelysning_kok_h"});
        public SwitchEntity SallysRumFonster => new(_app, new string[]{"switch.sallys_rum_fonster"});
    }

    public partial class CoverEntities
    {
        private readonly NetDaemonRxApp _app;
        public CoverEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public CoverEntity Tvrum => new(_app, new string[]{"cover.tvrum"});
        public CoverEntity TvrumRullgardinVanster => new(_app, new string[]{"cover.tvrum_rullgardin_vanster"});
        public CoverEntity TvrumRullgardinHoger => new(_app, new string[]{"cover.tvrum_rullgardin_hoger"});
    }

    public partial class ScriptEntities
    {
        private readonly NetDaemonRxApp _app;
        public ScriptEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public ScriptEntity FilmScene => new(_app, new string[]{"script.film_scene"});
        public ScriptEntity NotifyGreet => new(_app, new string[]{"script.notify_greet"});
        public ScriptEntity EveningScene => new(_app, new string[]{"script.evening_scene"});
        public ScriptEntity Zigbee2mqttRemove => new(_app, new string[]{"script.zigbee2mqtt_remove"});
        public ScriptEntity DayScene => new(_app, new string[]{"script.day_scene"});
        public ScriptEntity TvScene => new(_app, new string[]{"script.tv_scene"});
        public ScriptEntity Zigbee2mqttRename => new(_app, new string[]{"script.zigbee2mqtt_rename"});
        public ScriptEntity Setnightmode => new(_app, new string[]{"script.setnightmode"});
        public ScriptEntity CleaningScene => new(_app, new string[]{"script.cleaning_scene"});
        public ScriptEntity ColorScene => new(_app, new string[]{"script.color_scene"});
        public ScriptEntity TvOffScene => new(_app, new string[]{"script.tv_off_scene"});
        public ScriptEntity Notify => new(_app, new string[]{"script.notify"});
        public ScriptEntity MorningScene => new(_app, new string[]{"script.morning_scene"});
        public ScriptEntity NightScene => new(_app, new string[]{"script.night_scene"});
        public ScriptEntity E1586350051032 => new(_app, new string[]{"script.1586350051032"});
    }

    public partial class MediaPlayerEntities
    {
        private readonly NetDaemonRxApp _app;
        public MediaPlayerEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public MediaPlayerEntity PlexKodiAddOnLibreelec => new(_app, new string[]{"media_player.plex_kodi_add_on_libreelec"});
        public MediaPlayerEntity TvNere => new(_app, new string[]{"media_player.tv_nere"});
        public MediaPlayerEntity PlexPlexWebChrome => new(_app, new string[]{"media_player.plex_plex_web_chrome"});
        public MediaPlayerEntity PlexChrome3 => new(_app, new string[]{"media_player.plex_chrome_3"});
        public MediaPlayerEntity Gym => new(_app, new string[]{"media_player.gym"});
        public MediaPlayerEntity PlexChrome2 => new(_app, new string[]{"media_player.plex_chrome_2"});
        public MediaPlayerEntity MelkersTv => new(_app, new string[]{"media_player.melkers_tv"});
        public MediaPlayerEntity PlexChrome => new(_app, new string[]{"media_player.plex_chrome"});
        public MediaPlayerEntity TvRummetGh => new(_app, new string[]{"media_player.tv_rummet_gh"});
        public MediaPlayerEntity PlexChromecast => new(_app, new string[]{"media_player.plex_chromecast"});
        public MediaPlayerEntity Huset => new(_app, new string[]{"media_player.huset"});
        public MediaPlayerEntity PlexTomasIpad => new(_app, new string[]{"media_player.plex_tomas_ipad"});
        public MediaPlayerEntity ShieldTv => new(_app, new string[]{"media_player.shield_tv"});
        public MediaPlayerEntity PlexPlexWebChromeLinux2 => new(_app, new string[]{"media_player.plex_plex_web_chrome_linux_2"});
        public MediaPlayerEntity MelkersRum => new(_app, new string[]{"media_player.melkers_rum"});
        public MediaPlayerEntity PlexPlexCastChromecast => new(_app, new string[]{"media_player.plex_plex_cast_chromecast"});
        public MediaPlayerEntity TvGym => new(_app, new string[]{"media_player.tv_gym"});
        public MediaPlayerEntity Kok => new(_app, new string[]{"media_player.kok"});
        public MediaPlayerEntity SallysHogtalare => new(_app, new string[]{"media_player.sallys_hogtalare"});
        public MediaPlayerEntity PlexPlexWebChromeLinux => new(_app, new string[]{"media_player.plex_plex_web_chrome_linux"});
        public MediaPlayerEntity Sovrum => new(_app, new string[]{"media_player.sovrum"});
        public MediaPlayerEntity PlexPlexForAndroidTvShieldAndroidTv => new(_app, new string[]{"media_player.plex_plex_for_android_tv_shield_android_tv"});
        public MediaPlayerEntity TvUppe => new(_app, new string[]{"media_player.tv_uppe"});
        public MediaPlayerEntity Nestaudio0573 => new(_app, new string[]{"media_player.nestaudio0573"});
        public MediaPlayerEntity Vardagsrum => new(_app, new string[]{"media_player.vardagsrum"});
        public MediaPlayerEntity Shield => new(_app, new string[]{"media_player.shield"});
    }

    public partial class SceneEntities
    {
        private readonly NetDaemonRxApp _app;
        public SceneEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public SceneEntity Morgon => new(_app, new string[]{"scene.morgon"});
        public SceneEntity Dag => new(_app, new string[]{"scene.dag"});
        public SceneEntity Kvall => new(_app, new string[]{"scene.kvall"});
        public SceneEntity Natt => new(_app, new string[]{"scene.natt"});
        public SceneEntity Stadning => new(_app, new string[]{"scene.stadning"});
    }

    public partial class TimerEntities
    {
        private readonly NetDaemonRxApp _app;
        public TimerEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public TimerEntity ZigbeePermitJoin => new(_app, new string[]{"timer.zigbee_permit_join"});
    }

    public partial class LightEntities
    {
        private readonly NetDaemonRxApp _app;
        public LightEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public LightEntity Farstukvisten => new(_app, new string[]{"light.farstukvisten"});
        public LightEntity Ambient => new(_app, new string[]{"light.ambient"});
        public LightEntity MelkersRumFonster => new(_app, new string[]{"light.melkers_rum_fonster"});
        public LightEntity MelkersRum => new(_app, new string[]{"light.melkers_rum"});
        public LightEntity VardagsrumFonsterVanster => new(_app, new string[]{"light.vardagsrum_fonster_vanster"});
        public LightEntity TvrumBakgrundTv => new(_app, new string[]{"light.tvrum_bakgrund_tv"});
        public LightEntity SallysRum => new(_app, new string[]{"light.sallys_rum"});
        public LightEntity TomasRumFonster => new(_app, new string[]{"light.tomas_rum_fonster"});
        public LightEntity FarstukvistLed => new(_app, new string[]{"light.farstukvist_led"});
        public LightEntity GymLed => new(_app, new string[]{"light.gym_led"});
        public LightEntity KokFonster => new(_app, new string[]{"light.kok_fonster"});
        public LightEntity JulbelysningTvrummet => new(_app, new string[]{"light.julbelysning_tvrummet"});
        public LightEntity VardagsrumFonsterMitten => new(_app, new string[]{"light.vardagsrum_fonster_mitten"});
        public LightEntity Sovrum => new(_app, new string[]{"light.sovrum"});
        public LightEntity Tvrummet => new(_app, new string[]{"light.tvrummet"});
        public LightEntity HallByra => new(_app, new string[]{"light.hall_byra"});
        public LightEntity TomasRum => new(_app, new string[]{"light.tomas_rum"});
        public LightEntity SallysRumFonster => new(_app, new string[]{"light.sallys_rum_fonster"});
        public LightEntity SovrumFonster => new(_app, new string[]{"light.sovrum_fonster"});
        public LightEntity JulbelysningSovrum => new(_app, new string[]{"light.julbelysning_sovrum"});
        public LightEntity HallDorr => new(_app, new string[]{"light.hall_dorr"});
        public LightEntity Kok => new(_app, new string[]{"light.kok"});
        public LightEntity TvrumFonsterVanster => new(_app, new string[]{"light.tvrum_fonster_vanster"});
        public LightEntity Vardagsrum => new(_app, new string[]{"light.vardagsrum"});
        public LightEntity JulbelysningKokV => new(_app, new string[]{"light.julbelysning_kok_v"});
        public LightEntity JulbelysningKokH => new(_app, new string[]{"light.julbelysning_kok_h"});
        public LightEntity JulbelysningTomasRum => new(_app, new string[]{"light.julbelysning_tomas_rum"});
        public LightEntity TvrumFonsterHoger => new(_app, new string[]{"light.tvrum_fonster_hoger"});
        public LightEntity JulbelysningVardagsrumV => new(_app, new string[]{"light.julbelysning_vardagsrum_v"});
        public LightEntity KokLillaFonster => new(_app, new string[]{"light.kok_lilla_fonster"});
        public LightEntity TvrumVagg => new(_app, new string[]{"light.tvrum_vagg"});
        public LightEntity JulbelysningVardagsrumH => new(_app, new string[]{"light.julbelysning_vardagsrum_h"});
        public LightEntity SovrumByra => new(_app, new string[]{"light.sovrum_byra"});
        public LightEntity VardagsrumFonsterHoger => new(_app, new string[]{"light.vardagsrum_fonster_hoger"});
    }

    public partial class SunEntities
    {
        private readonly NetDaemonRxApp _app;
        public SunEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public SunEntity Sun => new(_app, new string[]{"sun.sun"});
    }

    public partial class ZoneEntities
    {
        private readonly NetDaemonRxApp _app;
        public ZoneEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public ZoneEntity Spv => new(_app, new string[]{"zone.spv"});
        public ZoneEntity Home => new(_app, new string[]{"zone.home"});
        public ZoneEntity Sjukhuset => new(_app, new string[]{"zone.sjukhuset"});
        public ZoneEntity Vardinge => new(_app, new string[]{"zone.vardinge"});
        public ZoneEntity Garn => new(_app, new string[]{"zone.garn"});
        public ZoneEntity Svarmor => new(_app, new string[]{"zone.svarmor"});
    }

    public partial class RemoteEntities
    {
        private readonly NetDaemonRxApp _app;
        public RemoteEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public RemoteEntity Tvrummet => new(_app, new string[]{"remote.tvrummet"});
    }

    public partial class AutomationEntities
    {
        private readonly NetDaemonRxApp _app;
        public AutomationEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public AutomationEntity ZigbeeJoinEnabled => new(_app, new string[]{"automation.zigbee_join_enabled"});
        public AutomationEntity Automation3 => new(_app, new string[]{"automation.automation_3"});
        public AutomationEntity Zigbee2mqttLogLevel => new(_app, new string[]{"automation.zigbee2mqtt_log_level"});
        public AutomationEntity ZigbeeJoinDisabled => new(_app, new string[]{"automation.zigbee_join_disabled"});
        public AutomationEntity SetThemeAtStartup => new(_app, new string[]{"automation.set_theme_at_startup"});
    }

    public partial class InputTextEntities
    {
        private readonly NetDaemonRxApp _app;
        public InputTextEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public InputTextEntity Zigbee2mqttNewName => new(_app, new string[]{"input_text.zigbee2mqtt_new_name"});
        public InputTextEntity Zigbee2mqttRemove => new(_app, new string[]{"input_text.zigbee2mqtt_remove"});
        public InputTextEntity Zigbee2mqttOldName => new(_app, new string[]{"input_text.zigbee2mqtt_old_name"});
    }

    public partial class CalendarEntities
    {
        private readonly NetDaemonRxApp _app;
        public CalendarEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public CalendarEntity Tomash277GmailCom => new(_app, new string[]{"calendar.tomash277_gmail_com"});
        public CalendarEntity FamiljenHellstrom => new(_app, new string[]{"calendar.familjen_hellstrom"});
        public CalendarEntity SundsvallsFotoklubb => new(_app, new string[]{"calendar.sundsvalls_fotoklubb"});
        public CalendarEntity TaUtSopor => new(_app, new string[]{"calendar.ta_ut_sopor"});
    }

    public partial class PersonEntities
    {
        private readonly NetDaemonRxApp _app;
        public PersonEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public PersonEntity Sally => new(_app, new string[]{"person.sally"});
        public PersonEntity Melker => new(_app, new string[]{"person.melker"});
        public PersonEntity Elin => new(_app, new string[]{"person.elin"});
        public PersonEntity Tomas => new(_app, new string[]{"person.tomas"});
    }

    public partial class WeatherEntities
    {
        private readonly NetDaemonRxApp _app;
        public WeatherEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public WeatherEntity SmhiHemma => new(_app, new string[]{"weather.smhi_hemma"});
    }

    public partial class InputNumberEntities
    {
        private readonly NetDaemonRxApp _app;
        public InputNumberEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public InputNumberEntity CarHeaterDepTimeHour => new(_app, new string[]{"input_number.car_heater_dep_time_hour"});
        public InputNumberEntity CarHeaterDepTimeMinutes => new(_app, new string[]{"input_number.car_heater_dep_time_minutes"});
    }

    public partial class InputBooleanEntities
    {
        private readonly NetDaemonRxApp _app;
        public InputBooleanEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public InputBooleanEntity ScheduleOnWeekends => new(_app, new string[]{"input_boolean.schedule_on_weekends"});
        public InputBooleanEntity GoodNightHouse => new(_app, new string[]{"input_boolean.good_night_house"});
    }

    public partial class InputSelectEntities
    {
        private readonly NetDaemonRxApp _app;
        public InputSelectEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public InputSelectEntity HouseModeSelectTest => new(_app, new string[]{"input_select.house_mode_select_test"});
        public InputSelectEntity HouseModeSelect => new(_app, new string[]{"input_select.house_mode_select"});
        public InputSelectEntity Zigbee2mqttLogLevel => new(_app, new string[]{"input_select.zigbee2mqtt_log_level"});
    }

    public partial class NetdaemonEntities
    {
        private readonly NetDaemonRxApp _app;
        public NetdaemonEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public NetdaemonEntity Status => new(_app, new string[]{"netdaemon.status"});
    }

    public partial class LockEntities
    {
        private readonly NetDaemonRxApp _app;
        public LockEntities(NetDaemonRxApp app)
        {
            _app = app;
        }

        public LockEntity LasUppe => new(_app, new string[]{"lock.las_uppe"});
    }
}