﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18010
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: System.Runtime.Serialization.ContractNamespaceAttribute("http://ZiZhuJY.Services.Location", ClrNamespace = "zizhujy.services.location")]

namespace zizhujy.services.location
{
    using System.Runtime.Serialization;


    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "Device", Namespace = "http://ZiZhuJY.Services.Location")]
    public partial class Device : object, System.Runtime.Serialization.IExtensibleDataObject
    {

        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        private string DeviceNameField;

        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DeviceName
        {
            get
            {
                return this.DeviceNameField;
            }
            set
            {
                this.DeviceNameField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "GeoCoordinate", Namespace = "http://ZiZhuJY.Services.Location")]
    public partial class GeoCoordinate : object, System.Runtime.Serialization.IExtensibleDataObject
    {

        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        private double AltitudeField;

        private double CourseField;

        private double HorizontalAccuracyField;

        private double LatitudeField;

        private double LongitudeField;

        private string RemarkField;

        private double SpeedField;

        private System.DateTime TimeStampField;

        private double VerticalAccruracyField;

        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Altitude
        {
            get
            {
                return this.AltitudeField;
            }
            set
            {
                this.AltitudeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Course
        {
            get
            {
                return this.CourseField;
            }
            set
            {
                this.CourseField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public double HorizontalAccuracy
        {
            get
            {
                return this.HorizontalAccuracyField;
            }
            set
            {
                this.HorizontalAccuracyField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Latitude
        {
            get
            {
                return this.LatitudeField;
            }
            set
            {
                this.LatitudeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Longitude
        {
            get
            {
                return this.LongitudeField;
            }
            set
            {
                this.LongitudeField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Remark
        {
            get
            {
                return this.RemarkField;
            }
            set
            {
                this.RemarkField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Speed
        {
            get
            {
                return this.SpeedField;
            }
            set
            {
                this.SpeedField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime TimeStamp
        {
            get
            {
                return this.TimeStampField;
            }
            set
            {
                this.TimeStampField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public double VerticalAccruracy
        {
            get
            {
                return this.VerticalAccruracyField;
            }
            set
            {
                this.VerticalAccruracyField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "IdentifiedDevice", Namespace = "http://ZiZhuJY.Services.Location")]
    public partial class IdentifiedDevice : object, System.Runtime.Serialization.IExtensibleDataObject
    {

        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        private zizhujy.services.location.Device DeviceField;

        private string UserNameField;

        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public zizhujy.services.location.Device Device
        {
            get
            {
                return this.DeviceField;
            }
            set
            {
                this.DeviceField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserName
        {
            get
            {
                return this.UserNameField;
            }
            set
            {
                this.UserNameField = value;
            }
        }
    }
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(Namespace = "http://ZiZhuJY.Services.Location", ConfigurationName = "ILocationService")]
public interface ILocationService
{

    [System.ServiceModel.OperationContractAttribute(Action = "http://ZiZhuJY.Services.Location/ILocationService/UpdateGeoCoordinate", ReplyAction = "http://ZiZhuJY.Services.Location/ILocationService/UpdateGeoCoordinateResponse")]
    void UpdateGeoCoordinate(zizhujy.services.location.Device device, zizhujy.services.location.GeoCoordinate geoCoor);

    [System.ServiceModel.OperationContractAttribute(Action = "http://ZiZhuJY.Services.Location/ILocationService/UpdateGeoCoordinate", ReplyAction = "http://ZiZhuJY.Services.Location/ILocationService/UpdateGeoCoordinateResponse")]
    System.Threading.Tasks.Task UpdateGeoCoordinateAsync(zizhujy.services.location.Device device, zizhujy.services.location.GeoCoordinate geoCoor);

    [System.ServiceModel.OperationContractAttribute(Action = "http://ZiZhuJY.Services.Location/ILocationService/GetLatestGeoCoordinateByDevice", ReplyAction = "http://ZiZhuJY.Services.Location/ILocationService/GetLatestGeoCoordinateByDeviceR" +
        "esponse")]
    zizhujy.services.location.GeoCoordinate GetLatestGeoCoordinateByDevice(zizhujy.services.location.Device device);

    [System.ServiceModel.OperationContractAttribute(Action = "http://ZiZhuJY.Services.Location/ILocationService/GetLatestGeoCoordinateByDevice", ReplyAction = "http://ZiZhuJY.Services.Location/ILocationService/GetLatestGeoCoordinateByDeviceR" +
        "esponse")]
    System.Threading.Tasks.Task<zizhujy.services.location.GeoCoordinate> GetLatestGeoCoordinateByDeviceAsync(zizhujy.services.location.Device device);

    [System.ServiceModel.OperationContractAttribute(Action = "http://ZiZhuJY.Services.Location/ILocationService/GetLatestGeoCoordinates", ReplyAction = "http://ZiZhuJY.Services.Location/ILocationService/GetLatestGeoCoordinatesResponse" +
        "")]
    System.Collections.Generic.Dictionary<zizhujy.services.location.IdentifiedDevice, zizhujy.services.location.GeoCoordinate> GetLatestGeoCoordinates();

    [System.ServiceModel.OperationContractAttribute(Action = "http://ZiZhuJY.Services.Location/ILocationService/GetLatestGeoCoordinates", ReplyAction = "http://ZiZhuJY.Services.Location/ILocationService/GetLatestGeoCoordinatesResponse" +
        "")]
    System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<zizhujy.services.location.IdentifiedDevice, zizhujy.services.location.GeoCoordinate>> GetLatestGeoCoordinatesAsync();

    [System.ServiceModel.OperationContractAttribute(Action = "http://ZiZhuJY.Services.Location/ILocationService/GetLatestGeoCoordinatesByUserNa" +
        "me", ReplyAction = "http://ZiZhuJY.Services.Location/ILocationService/GetLatestGeoCoordinatesByUserNa" +
        "meResponse")]
    System.Collections.Generic.Dictionary<zizhujy.services.location.Device, zizhujy.services.location.GeoCoordinate> GetLatestGeoCoordinatesByUserName(string userName);

    [System.ServiceModel.OperationContractAttribute(Action = "http://ZiZhuJY.Services.Location/ILocationService/GetLatestGeoCoordinatesByUserNa" +
        "me", ReplyAction = "http://ZiZhuJY.Services.Location/ILocationService/GetLatestGeoCoordinatesByUserNa" +
        "meResponse")]
    System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<zizhujy.services.location.Device, zizhujy.services.location.GeoCoordinate>> GetLatestGeoCoordinatesByUserNameAsync(string userName);

    [System.ServiceModel.OperationContractAttribute(Action = "http://ZiZhuJY.Services.Location/ILocationService/GetLatestGeoCoordinateByUserNam" +
        "eAndDevice", ReplyAction = "http://ZiZhuJY.Services.Location/ILocationService/GetLatestGeoCoordinateByUserNam" +
        "eAndDeviceResponse")]
    zizhujy.services.location.GeoCoordinate GetLatestGeoCoordinateByUserNameAndDevice(string userName, zizhujy.services.location.Device device);

    [System.ServiceModel.OperationContractAttribute(Action = "http://ZiZhuJY.Services.Location/ILocationService/GetLatestGeoCoordinateByUserNam" +
        "eAndDevice", ReplyAction = "http://ZiZhuJY.Services.Location/ILocationService/GetLatestGeoCoordinateByUserNam" +
        "eAndDeviceResponse")]
    System.Threading.Tasks.Task<zizhujy.services.location.GeoCoordinate> GetLatestGeoCoordinateByUserNameAndDeviceAsync(string userName, zizhujy.services.location.Device device);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface ILocationServiceChannel : ILocationService, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class LocationServiceClient : System.ServiceModel.ClientBase<ILocationService>, ILocationService
{

    public LocationServiceClient()
    {
    }

    public LocationServiceClient(string endpointConfigurationName) :
        base(endpointConfigurationName)
    {
    }

    public LocationServiceClient(string endpointConfigurationName, string remoteAddress) :
        base(endpointConfigurationName, remoteAddress)
    {
    }

    public LocationServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
        base(endpointConfigurationName, remoteAddress)
    {
    }

    public LocationServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
        base(binding, remoteAddress)
    {
    }

    public void UpdateGeoCoordinate(zizhujy.services.location.Device device, zizhujy.services.location.GeoCoordinate geoCoor)
    {
        base.Channel.UpdateGeoCoordinate(device, geoCoor);
    }

    public System.Threading.Tasks.Task UpdateGeoCoordinateAsync(zizhujy.services.location.Device device, zizhujy.services.location.GeoCoordinate geoCoor)
    {
        return base.Channel.UpdateGeoCoordinateAsync(device, geoCoor);
    }

    public zizhujy.services.location.GeoCoordinate GetLatestGeoCoordinateByDevice(zizhujy.services.location.Device device)
    {
        return base.Channel.GetLatestGeoCoordinateByDevice(device);
    }

    public System.Threading.Tasks.Task<zizhujy.services.location.GeoCoordinate> GetLatestGeoCoordinateByDeviceAsync(zizhujy.services.location.Device device)
    {
        return base.Channel.GetLatestGeoCoordinateByDeviceAsync(device);
    }

    public System.Collections.Generic.Dictionary<zizhujy.services.location.IdentifiedDevice, zizhujy.services.location.GeoCoordinate> GetLatestGeoCoordinates()
    {
        return base.Channel.GetLatestGeoCoordinates();
    }

    public System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<zizhujy.services.location.IdentifiedDevice, zizhujy.services.location.GeoCoordinate>> GetLatestGeoCoordinatesAsync()
    {
        return base.Channel.GetLatestGeoCoordinatesAsync();
    }

    public System.Collections.Generic.Dictionary<zizhujy.services.location.Device, zizhujy.services.location.GeoCoordinate> GetLatestGeoCoordinatesByUserName(string userName)
    {
        return base.Channel.GetLatestGeoCoordinatesByUserName(userName);
    }

    public System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<zizhujy.services.location.Device, zizhujy.services.location.GeoCoordinate>> GetLatestGeoCoordinatesByUserNameAsync(string userName)
    {
        return base.Channel.GetLatestGeoCoordinatesByUserNameAsync(userName);
    }

    public zizhujy.services.location.GeoCoordinate GetLatestGeoCoordinateByUserNameAndDevice(string userName, zizhujy.services.location.Device device)
    {
        return base.Channel.GetLatestGeoCoordinateByUserNameAndDevice(userName, device);
    }

    public System.Threading.Tasks.Task<zizhujy.services.location.GeoCoordinate> GetLatestGeoCoordinateByUserNameAndDeviceAsync(string userName, zizhujy.services.location.Device device)
    {
        return base.Channel.GetLatestGeoCoordinateByUserNameAndDeviceAsync(userName, device);
    }
}