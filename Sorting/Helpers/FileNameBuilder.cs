using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting.Helpers
{
    public class FileNameBuilder
    {
        private string _name;
        private string _extension;
        private string _date;
        private string _time;
        private string _guid;

        public FileNameBuilder(string name, string extension)
        {
            _name = name;
            _extension = extension;
        }

        public string GetResult()
        {
            return $"{_name}{_date}{_time}{_guid}{_extension}";
        }

        public FileNameBuilder AddDate()
        {
            _date = DateTime.Now.ToString("_yyyy-MM-dd");
            return this;
        }

        public FileNameBuilder AddTime()
        {
            _time = DateTime.Now.ToString("_HH.mm.ss");
            return this;
        }

        public FileNameBuilder AddGuid()
        {
            _guid = "_" + Guid.NewGuid();
            return this;
        }
    }
}
