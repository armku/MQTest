using NewLife.Xml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MQTest.Config
{
    /// <summary>
    /// 配置参数
    /// </summary>
    [XmlConfigFile(@"Config/PortCfg.config")]
    [Description("配置参数")]
    public class PortCfg : XmlConfig<PortCfg>
    {
        /// <summary>
        /// 服务器
        /// </summary>
        [Description("服务器")]
        public String Server { get; set; }
        /// <summary>
        /// 端口
        /// </summary>
        [Description("端口")]
        public Int32 Port { get; set; }
        /// <summary>
        /// ClientID
        /// </summary>
        [Description("ClientID")]
        public String ClientID { get; set; }
        /// <summary>
        /// 需要发送内容
        /// </summary>
        [Description("需要发送内容")]
        public String StrSend { get; set; }
        /// <summary>
        /// 推送主题
        /// </summary>
        public String StrPubToc { get; set; }
        /// <summary>
        /// 是否HEX发送
        /// </summary>
        [Description("是否HEX发送")]
        public Boolean FlagHexSend { get; set; }
        /// <summary>
        /// 是否Hex接收
        /// </summary>
        [Description("是否Hex接收")]
        public Boolean FlagHexRcv { get; set; }
        /// <summary>
        /// 是否发送新行
        /// </summary>
        [Description("是否发送新行")]
        public Boolean FlagSendNewLine { get; set; }

        protected override void OnNew()
        {
            this.Server = "127.0.0.1";
            this.Port = 1883;
            this.StrSend = "Hello";
            this.FlagHexRcv = false;
            this.FlagHexSend = false;
            this.FlagSendNewLine = false;
            this.ClientID = "123456789";
            this.StrPubToc = "G/ddd";
        }
    }
}
