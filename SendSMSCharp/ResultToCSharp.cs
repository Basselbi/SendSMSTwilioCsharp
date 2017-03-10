/* 
 Licensed under the Apache License, Version 2.0

 http://www.apache.org/licenses/LICENSE-2.0
 */
using System;
using System.Xml.Serialization;
using System.Collections.Generic;
namespace ResultToCSharp
{
    
   
    
    [XmlRoot(ElementName = "SubresourceUris")]
    public class SubresourceUris
    {
        [XmlElement(ElementName = "Media")]
        public string Media { get; set; }
    }

    [XmlRoot(ElementName = "Message")]
    public class Message
    {
        [XmlElement(ElementName = "Sid")]
        public string Sid { get; set; }
        [XmlElement(ElementName = "DateCreated")]
        public string DateCreated { get; set; }
        [XmlElement(ElementName = "DateUpdated")]
        public string DateUpdated { get; set; }
        [XmlElement(ElementName = "DateSent")]
        public string DateSent { get; set; }
        [XmlElement(ElementName = "AccountSid")]
        public string AccountSid { get; set; }
        [XmlElement(ElementName = "To")]
        public string To { get; set; }
        [XmlElement(ElementName = "From")]
        public string From { get; set; }
        [XmlElement(ElementName = "MessagingServiceSid")]
        public string MessagingServiceSid { get; set; }
        [XmlElement(ElementName = "Body")]
        public string Body { get; set; }
        [XmlElement(ElementName = "Status")]
        public string Status { get; set; }
        [XmlElement(ElementName = "NumSegments")]
        public string NumSegments { get; set; }
        [XmlElement(ElementName = "NumMedia")]
        public string NumMedia { get; set; }
        [XmlElement(ElementName = "Direction")]
        public string Direction { get; set; }
        [XmlElement(ElementName = "ApiVersion")]
        public string ApiVersion { get; set; }
        [XmlElement(ElementName = "Price")]
        public string Price { get; set; }
        [XmlElement(ElementName = "PriceUnit")]
        public string PriceUnit { get; set; }
        [XmlElement(ElementName = "ErrorCode")]
        public string ErrorCode { get; set; }
        [XmlElement(ElementName = "ErrorMessage")]
        public string ErrorMessage { get; set; }
        [XmlElement(ElementName = "Uri")]
        public string Uri { get; set; }
        [XmlElement(ElementName = "SubresourceUris")]
        public SubresourceUris SubresourceUris { get; set; }
    }

    [XmlRoot(ElementName = "Messages")]
    public class Messages
    {
        [XmlElement(ElementName = "Message")]
        public List<Message> Message { get; set; }
        [XmlAttribute(AttributeName = "end")]
        public string End { get; set; }
        [XmlAttribute(AttributeName = "firstpageuri")]
        public string Firstpageuri { get; set; }
        [XmlAttribute(AttributeName = "nextpageuri")]
        public string Nextpageuri { get; set; }
        [XmlAttribute(AttributeName = "page")]
        public string Page { get; set; }
        [XmlAttribute(AttributeName = "pagesize")]
        public string Pagesize { get; set; }
        [XmlAttribute(AttributeName = "previouspageuri")]
        public string Previouspageuri { get; set; }
        [XmlAttribute(AttributeName = "start")]
        public string Start { get; set; }
        [XmlAttribute(AttributeName = "uri")]
        public string Uri { get; set; }
    }

    [XmlRoot(ElementName = "TwilioResponse")]
    public class TwilioResponse
    {
        [XmlElement(ElementName = "Messages")]
        public Messages Messages { get; set; }
    }

}
