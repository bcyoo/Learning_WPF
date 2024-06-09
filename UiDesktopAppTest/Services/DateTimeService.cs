using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UiDesktopAppTest.Interfaces;

namespace UiDesktopAppTest.Services
{
    internal class DateTimeService : IDateTime
    {
        public DateTime? GetCurrentTime()
        {
            return DateTime.Now;
        }
    }
}
