using System;
using System.Diagnostics;
using System.IO;
using System.Text.Json;

namespace XBatteryStatus
{
    public class UserSettings
    {
        private bool _enableLowBatteryNotifications = true;
        private bool _enableNotificationAudio = true;
        private string _notificationAudio = "ms-winsoundevent:Notification.Looping.Alarm7";
        private int _updateFrequencyMs = 10000;
        private int _lastBatteryReading = 100;
        private int _warningLevel0 = 15;
        private int _warningLevel1 = 10;
        private int _warningLevel2 = 5;
        private bool _enableBatteryLog = false;

        private bool _unsavedChanges = true;

        private static string _filePath = Path.Combine(FileHelpers.GetAppDataFolder(), "usersettings.cfg");
        private static JsonSerializerOptions SerializerOptions = new JsonSerializerOptions
        {
            IgnoreReadOnlyProperties = true,
            IncludeFields = false,
            WriteIndented = true
        };


        #region Properties
        public bool EnableLowBatteryNotifications {
            get => _enableLowBatteryNotifications; 
            set 
            {
                if (_enableLowBatteryNotifications != value)
                {
                    _enableLowBatteryNotifications = value;
                    _unsavedChanges = true;

                }
            }
        }
        public bool EnableNotificationAudio
        {
            get => _enableNotificationAudio; 
            set
            {
                if (_enableNotificationAudio != value)
                {
                    _enableNotificationAudio = value;
                    _unsavedChanges = true;
                }
            }
        }
        public string NotificationAudio
        {
            get => _notificationAudio; 
            set
            {
                if (_notificationAudio != value)
                {
                    _notificationAudio = value;
                    _unsavedChanges = true;
                }
            }
        }
        public int UpdateFrequencyMs
        {
            get => _updateFrequencyMs; 
            set
            {
                if (_updateFrequencyMs != value)
                {
                    _updateFrequencyMs = value;
                    _unsavedChanges = true;
                }
            }
        }
        public int LastBatteryReading
        {
            get => _lastBatteryReading; 
            set
            {
                if (_lastBatteryReading != value)
                {
                    _lastBatteryReading = value;
                    _unsavedChanges = true;
                }
            }
        }
        public int WarningLevel0
        {
            get => _warningLevel0; 
            set
            {
                if (_warningLevel0 != value)
                {
                    _warningLevel0 = value;
                    _unsavedChanges = true;
                }
            }
        }
        public int WarningLevel1
        {
            get => _warningLevel1; 
            set
            {
                if (_warningLevel1 != value)
                {
                    _warningLevel1 = value;
                    _unsavedChanges = true;
                }
            }
        }
        public int WarningLevel2
        {
            get => _warningLevel2; 
            set
            {
                if (_warningLevel2 != value)
                {
                    _warningLevel2 = value;
                    _unsavedChanges = true;
                }
            }
        }
        public bool EnableBatteryLog
        {
            get => _enableBatteryLog; 
            set
            {
                if (_enableBatteryLog != value)
                {
                    _enableBatteryLog = value;
                    _unsavedChanges = true;
                }
            }
        }
        #endregion

        private static UserSettings _settings;
        public static UserSettings Get()
        {
            if (_settings == null)
            {
                _settings = Load();
            }
            return _settings;
        }

        private static UserSettings Load()
        {
            try
            {
                string jsonString = File.ReadAllText(_filePath);
                var ret = JsonSerializer.Deserialize<UserSettings>(jsonString, SerializerOptions);
                ret.NotifyLoaded();
                return ret;
            }
            catch (Exception)
            {
                return new UserSettings();
            }

        }

        private void NotifyLoaded()
        {
            _unsavedChanges = false;
        }
        public void Save()
        {
            if (_unsavedChanges)
            {
                try
                {
                    string jsonString = JsonSerializer.Serialize<UserSettings>(this, SerializerOptions);
                    File.WriteAllText(_filePath, jsonString);

                    _unsavedChanges = false;
                }
                catch (Exception)
                {
                }

            }
        }

    }
}
