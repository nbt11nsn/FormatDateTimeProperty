using System.ComponentModel.DataAnnotations;
using BizTalkComponents.Utils;
using Microsoft.BizTalk.Component.Interop;
using Microsoft.BizTalk.Message.Interop;
using System;
using System.ComponentModel;
using System.IO;
using System.Text.RegularExpressions;

namespace BizTalkComponents.PipelineComponents.FormatDateTimeProperties
{
    [ComponentCategory(CategoryTypes.CATID_PipelineComponent)]
    [ComponentCategory(CategoryTypes.CATID_Receiver)]
    [ComponentCategory(CategoryTypes.CATID_Any)]
    [System.Runtime.InteropServices.Guid("35db2d42-f633-4c96-bea7-a86c7a0350e9")]

    public partial class FormatDateTimeProperties : IBaseComponent,
        Microsoft.BizTalk.Component.Interop.IComponent,
        IComponentUI,
        IPersistPropertyBag
    {
        public virtual void Load(IPropertyBag pb, int errlog)
        {
        }

        public virtual void Save(IPropertyBag pb, bool fClearDirty,
            bool fSaveAllProperties)
        {
        }

        public IBaseMessage Execute(IPipelineContext pContext, IBaseMessage pInMsg)
        {
            var result = DateTime.Now.ToString("yyMM");
            pInMsg.Context.Promote("ReceivedFileName","http://schemas.microsoft.com/BizTalk/2003/file-properties", result);

            return pInMsg;
        }

    }
}
