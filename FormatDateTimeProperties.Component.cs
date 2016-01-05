using System;
using System.Collections;
using System.Linq;
using BizTalkComponents.Utils;

namespace BizTalkComponents.PipelineComponents.FormatDateTimeProperties
{
    public partial class FormatDateTimeProperties
    {
        public string Name { get { return "Format DateTime Property Component"; } }
        public string Version { get { return "0.1"; } }
        public string Description { get { return @"Replaces a context value with specified datetime pattern"; } }

        public void GetClassID(out Guid classid)
        {
            classid = new Guid("77043a51-4fdb-422a-b66a-de1a53957568");
        }

        public void InitNew() { }

        public IntPtr Icon
        {
            get
            {
                return IntPtr.Zero;
            }
        }

        public IEnumerator Validate(object projectSystem)
        {
            return ValidationHelper.Validate(this, false).ToArray().GetEnumerator();
        }

        public bool Validate(out string errorMessage)
        {
            var errors = ValidationHelper.Validate(this, true).ToArray();

            if (errors.Any())
            {
                errorMessage = string.Join(",", errors);

                return false;
            }

            errorMessage = string.Empty;

            return true;
        }
    }
}