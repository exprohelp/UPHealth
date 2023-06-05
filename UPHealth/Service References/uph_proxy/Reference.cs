﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UPHealth.uph_proxy {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="uph_proxy.UPHealthServicesSoap")]
    public interface UPHealthServicesSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UPHealth_Queries", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet UPHealth_Queries(out string processInfo, string unit_id, string prm1, string prm2, string prm3, string logic, string login_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UPHealth_GetMultipleImages", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        byte[][] UPHealth_GetMultipleImages(string ref_no, string login_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UPHealth_GetMultipleImagesTemp", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        byte[][] UPHealth_GetMultipleImagesTemp(string ref_no, string login_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/EstablishLink", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string EstablishLink(string ref_no, string patient_code, string emp_code, string Logic);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/QueryExecute", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string QueryExecute(string query, string Database);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/MarkAllChecked", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string MarkAllChecked(string unit_id, string prm_1, string prm_2, string login_id, string Logic);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TransferSampleToBiotech", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string TransferSampleToBiotech(string unit_id, string login_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Transfer_TestPerfAtUnit", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string Transfer_TestPerfAtUnit(string unit_id, string login_id, System.Data.DataSet ds);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Sample_Queries", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet Sample_Queries(string unit_id, string dispatch_no, string prm_1, string prm_2, string from, string to, string Logic, string login_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/PushTestResult_UPHBySync", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string PushTestResult_UPHBySync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/PushTestResult_UPHBySync_Dummy", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string PushTestResult_UPHBySync_Dummy();
        
        // CODEGEN: Parameter 'DownloadFileResult' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DownloadFile", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        UPHealth.uph_proxy.DownloadFileResponse DownloadFile(UPHealth.uph_proxy.DownloadFileRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/QueryOrTNPTest", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string QueryOrTNPTest(string unit_id, string patient_code, string Test_Id, string login_id, string prm_1, string prm_2, string remark, string logic);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DownloadFile", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class DownloadFileRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string path;
        
        public DownloadFileRequest() {
        }
        
        public DownloadFileRequest(string path) {
            this.path = path;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DownloadFileResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class DownloadFileResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] DownloadFileResult;
        
        public DownloadFileResponse() {
        }
        
        public DownloadFileResponse(byte[] DownloadFileResult) {
            this.DownloadFileResult = DownloadFileResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface UPHealthServicesSoapChannel : UPHealth.uph_proxy.UPHealthServicesSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UPHealthServicesSoapClient : System.ServiceModel.ClientBase<UPHealth.uph_proxy.UPHealthServicesSoap>, UPHealth.uph_proxy.UPHealthServicesSoap {
        
        public UPHealthServicesSoapClient() {
        }
        
        public UPHealthServicesSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UPHealthServicesSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UPHealthServicesSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UPHealthServicesSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet UPHealth_Queries(out string processInfo, string unit_id, string prm1, string prm2, string prm3, string logic, string login_id) {
            return base.Channel.UPHealth_Queries(out processInfo, unit_id, prm1, prm2, prm3, logic, login_id);
        }
        
        public byte[][] UPHealth_GetMultipleImages(string ref_no, string login_id) {
            return base.Channel.UPHealth_GetMultipleImages(ref_no, login_id);
        }
        
        public byte[][] UPHealth_GetMultipleImagesTemp(string ref_no, string login_id) {
            return base.Channel.UPHealth_GetMultipleImagesTemp(ref_no, login_id);
        }
        
        public string EstablishLink(string ref_no, string patient_code, string emp_code, string Logic) {
            return base.Channel.EstablishLink(ref_no, patient_code, emp_code, Logic);
        }
        
        public string QueryExecute(string query, string Database) {
            return base.Channel.QueryExecute(query, Database);
        }
        
        public string MarkAllChecked(string unit_id, string prm_1, string prm_2, string login_id, string Logic) {
            return base.Channel.MarkAllChecked(unit_id, prm_1, prm_2, login_id, Logic);
        }
        
        public string TransferSampleToBiotech(string unit_id, string login_id) {
            return base.Channel.TransferSampleToBiotech(unit_id, login_id);
        }
        
        public string Transfer_TestPerfAtUnit(string unit_id, string login_id, System.Data.DataSet ds) {
            return base.Channel.Transfer_TestPerfAtUnit(unit_id, login_id, ds);
        }
        
        public System.Data.DataSet Sample_Queries(string unit_id, string dispatch_no, string prm_1, string prm_2, string from, string to, string Logic, string login_id) {
            return base.Channel.Sample_Queries(unit_id, dispatch_no, prm_1, prm_2, from, to, Logic, login_id);
        }
        
        public string PushTestResult_UPHBySync() {
            return base.Channel.PushTestResult_UPHBySync();
        }
        
        public string PushTestResult_UPHBySync_Dummy() {
            return base.Channel.PushTestResult_UPHBySync_Dummy();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        UPHealth.uph_proxy.DownloadFileResponse UPHealth.uph_proxy.UPHealthServicesSoap.DownloadFile(UPHealth.uph_proxy.DownloadFileRequest request) {
            return base.Channel.DownloadFile(request);
        }
        
        public byte[] DownloadFile(string path) {
            UPHealth.uph_proxy.DownloadFileRequest inValue = new UPHealth.uph_proxy.DownloadFileRequest();
            inValue.path = path;
            UPHealth.uph_proxy.DownloadFileResponse retVal = ((UPHealth.uph_proxy.UPHealthServicesSoap)(this)).DownloadFile(inValue);
            return retVal.DownloadFileResult;
        }
        
        public string QueryOrTNPTest(string unit_id, string patient_code, string Test_Id, string login_id, string prm_1, string prm_2, string remark, string logic) {
            return base.Channel.QueryOrTNPTest(unit_id, patient_code, Test_Id, login_id, prm_1, prm_2, remark, logic);
        }
    }
}