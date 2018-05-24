using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Tips.EnumLearning
{
    public class EnumEntity
    {
        public EnumEntity()
        {
        }

        public bool CheckEventHappen(DateTime dateTime, string setting)
        {
            var daysOfWeek = (int)Math.Pow(2, (int)dateTime.DayOfWeek);
            if (string.IsNullOrEmpty(setting))
            {
                return (daysOfWeek & (int) EnumFlag.Weekend) == daysOfWeek;
            }

            var settingmodle = GetSetting(setting);
            return (daysOfWeek & settingmodle) == daysOfWeek;
        }

        private int GetSetting(string setting)
        {
            var settingList = setting.Split(new[] {','}, StringSplitOptions.RemoveEmptyEntries).ToList().Select(x=>Convert.ToInt32(x)).ToList();
           
            if (settingList.Count > 1)
            {
                var result = (int)Math.Pow(2, settingList[0]);
                for (var i = 1; i < settingList.Count; i++)
                {
                    var bitInt = (int) Math.Pow(2, settingList[i]);
                    result = result | bitInt;
                }

                return result;
            }

            return (int)Math.Pow(2, settingList.FirstOrDefault());
        }
    }
}
