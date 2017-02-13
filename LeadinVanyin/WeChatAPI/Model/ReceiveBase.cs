using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace WeChatAPI.Model
{


    /// <summary>
    /// 接收消息基类
    /// </summary>
    [XmlRoot("xml")]
    public class ReceiveBase
    {

        /// <summary>
        /// 【开发者】微信号
        /// </summary> 
        public string ToUserName { get; set; }

        /// <summary>
        /// 发送方帐号（一个OpenID）
        /// </summary> 
        public string FromUserName { get; set; }

        /// <summary>
        /// 消息创建时间 （整型）
        /// </summary> 
        public int CreateTime { get; set; }

        /// <summary>
        /// 文本消息:text   图片消息;image  语音消息：voice  视频消息:video 地理位置消息:location
        /// </summary> 
        public string MsgType { get; set; }

        /// <summary>
        /// 消息id，64位整型
        /// </summary> 
        public string MsgId { get; set; }


    }

    /// <summary>
    /// 文本消息
    /// </summary>
    [XmlRoot("xml")]
    public class ReceiveText : ReceiveBase
    {

        /// <summary>
        /// 文本消息内容
        /// </summary> 
        public string Content { get; set; }


    }
    /// <summary>
    /// 图片消息
    /// </summary>
    [XmlRoot("xml")]
    public class ReceiveImage : ReceiveBase
    {
        /// <summary>
        /// 图片链接
        /// </summary>
        [XmlElement("PicUrl")]
        public string PicUrl { get; set; }

        /// <summary>
        /// 图片消息媒体id，可以调用多媒体文件下载接口拉取数据。
        /// </summary>
        [XmlElement("MediaId")]
        public string MediaId { get; set; }
    }
    /// <summary>
    /// 语音消息
    /// </summary>
    [XmlRoot("xml")]
    public class ReceiveVoice : ReceiveBase
    {
        /// <summary>
        /// 语音消息媒体id，可以调用多媒体文件下载接口拉取数据。
        /// </summary>
        [XmlElement("MediaId")]
        public string MediaId { get; set; }

        /// <summary>
        /// 语音格式，如amr，speex等
        /// </summary>
        [XmlElement("Format")]
        public string Format { get; set; }
    }
    /// <summary>
    /// 视频消息
    /// </summary>
    [XmlRoot("xml")]
    public class ReceiveVideo : ReceiveBase
    {
        /// <summary>
        /// 视频消息媒体id，可以调用多媒体文件下载接口拉取数据。
        /// </summary>
        [XmlElement("MediaId")]
        public string MediaId { get; set; }

        /// <summary>
        /// 视频消息缩略图的媒体id，可以调用多媒体文件下载接口拉取数据。
        /// </summary>
        [XmlElement("ThumbMediaId")]
        public string ThumbMediaId { get; set; }
    }
    /// <summary>
    /// 地理位置消息
    /// </summary>
    [XmlRoot("xml")]
    public class ReceiveLocation : ReceiveBase
    {
        /// <summary>
        /// 地理位置维度
        /// </summary>
        public string Location_X { get; set; }
        /// <summary>
        /// 地理位置经度
        /// </summary>
        public string Location_Y { get; set; }
        /// <summary>
        /// 地图缩放大小
        /// </summary>
        public string Scale { get; set; }
        /// <summary>
        /// 地理位置信息
        /// </summary>
        public string Label { get; set; }
    }

    /// <summary>
    /// 链接消息
    /// </summary>
    [XmlRoot("xml")]
    public class ReceiveLink : ReceiveBase
    {
        /// <summary>
        /// 消息标题
        /// </summary>
        [XmlElement("Title")]
        public string Title { get; set; }
        /// <summary>
        /// 消息描述
        /// </summary>
        [XmlElement("Description")]
        public string Description { get; set; }
        /// <summary>
        /// 消息链接
        /// </summary>
        [XmlElement("Url")]
        public string Url { get; set; }
    }
}

