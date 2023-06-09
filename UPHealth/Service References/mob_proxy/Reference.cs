﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UPHealth.mob_proxy {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="mob_proxy.IExproMobileService")]
    public interface IExproMobileService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExproMobileService/AuthenticateUser", ReplyAction="http://tempuri.org/IExproMobileService/AuthenticateUserResponse")]
        string AuthenticateUser(string member_id, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExproMobileService/RegisterMember", ReplyAction="http://tempuri.org/IExproMobileService/RegisterMemberResponse")]
        string RegisterMember(string member_name, string email_id, string mobile_no, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExproMobileService/DiagnosticRequest", ReplyAction="http://tempuri.org/IExproMobileService/DiagnosticRequestResponse")]
        string DiagnosticRequest(string member_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExproMobileService/HospitalRequest", ReplyAction="http://tempuri.org/IExproMobileService/HospitalRequestResponse")]
        string HospitalRequest(string member_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExproMobileService/PharmacyRequest", ReplyAction="http://tempuri.org/IExproMobileService/PharmacyRequestResponse")]
        string PharmacyRequest(string member_id, byte[] image);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExproMobileService/SaveNHM_Image", ReplyAction="http://tempuri.org/IExproMobileService/SaveNHM_ImageResponse")]
        string SaveNHM_Image(string UID, string ref_no, string doc_name, byte[] data, string extension, string login_id, string Logic);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExproMobileService/EditProfile", ReplyAction="http://tempuri.org/IExproMobileService/EditProfileResponse")]
        string EditProfile(string member_id, string member_name, string email_id, string mobile_no, byte[] ProfilePic);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExproMobileService/GetDiagnoticRequestHistory", ReplyAction="http://tempuri.org/IExproMobileService/GetDiagnoticRequestHistoryResponse")]
        string GetDiagnoticRequestHistory(string member_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExproMobileService/GetPharmacyRequestHistory", ReplyAction="http://tempuri.org/IExproMobileService/GetPharmacyRequestHistoryResponse")]
        string GetPharmacyRequestHistory(string member_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExproMobileService/GetHospitalRequestHistory", ReplyAction="http://tempuri.org/IExproMobileService/GetHospitalRequestHistoryResponse")]
        string GetHospitalRequestHistory(string member_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExproMobileService/ForgotPassword", ReplyAction="http://tempuri.org/IExproMobileService/ForgotPasswordResponse")]
        string ForgotPassword(string MobileNo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExproMobileService/GetUserDetails", ReplyAction="http://tempuri.org/IExproMobileService/GetUserDetailsResponse")]
        string GetUserDetails(string member_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExproMobileService/GetScheduledReferralList", ReplyAction="http://tempuri.org/IExproMobileService/GetScheduledReferralListResponse")]
        string GetScheduledReferralList(string login_id, string Logic);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExproMobileService/GetSaleByLogin", ReplyAction="http://tempuri.org/IExproMobileService/GetSaleByLoginResponse")]
        string GetSaleByLogin(string login_id, string Logic);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExproMobileService/UpdateLatLong", ReplyAction="http://tempuri.org/IExproMobileService/UpdateLatLongResponse")]
        string UpdateLatLong(string emp_code, string d_code, string prm_1, string prm_2, string logic);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExproMobileService/SalesLogin", ReplyAction="http://tempuri.org/IExproMobileService/SalesLoginResponse")]
        string SalesLogin(string UserId, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExproMobileService/GetTargetList", ReplyAction="http://tempuri.org/IExproMobileService/GetTargetListResponse")]
        string GetTargetList(string login_id, string Logic);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExproMobileService/InHouseAppLogin", ReplyAction="http://tempuri.org/IExproMobileService/InHouseAppLoginResponse")]
        string InHouseAppLogin(string AppName, string emp_code, string psw, string Logic, string OTP);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExproMobileService/TagGeo_ReferralAndVisit", ReplyAction="http://tempuri.org/IExproMobileService/TagGeo_ReferralAndVisitResponse")]
        string TagGeo_ReferralAndVisit(string emp_code, string d_code, string geo_lat, string geo_long, string remark, string logic);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IExproMobileServiceChannel : UPHealth.mob_proxy.IExproMobileService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ExproMobileServiceClient : System.ServiceModel.ClientBase<UPHealth.mob_proxy.IExproMobileService>, UPHealth.mob_proxy.IExproMobileService {
        
        public ExproMobileServiceClient() {
        }
        
        public ExproMobileServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ExproMobileServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ExproMobileServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ExproMobileServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string AuthenticateUser(string member_id, string password) {
            return base.Channel.AuthenticateUser(member_id, password);
        }
        
        public string RegisterMember(string member_name, string email_id, string mobile_no, string password) {
            return base.Channel.RegisterMember(member_name, email_id, mobile_no, password);
        }
        
        public string DiagnosticRequest(string member_id) {
            return base.Channel.DiagnosticRequest(member_id);
        }
        
        public string HospitalRequest(string member_id) {
            return base.Channel.HospitalRequest(member_id);
        }
        
        public string PharmacyRequest(string member_id, byte[] image) {
            return base.Channel.PharmacyRequest(member_id, image);
        }
        
        public string SaveNHM_Image(string UID, string ref_no, string doc_name, byte[] data, string extension, string login_id, string Logic) {
            return base.Channel.SaveNHM_Image(UID, ref_no, doc_name, data, extension, login_id, Logic);
        }
        
        public string EditProfile(string member_id, string member_name, string email_id, string mobile_no, byte[] ProfilePic) {
            return base.Channel.EditProfile(member_id, member_name, email_id, mobile_no, ProfilePic);
        }
        
        public string GetDiagnoticRequestHistory(string member_id) {
            return base.Channel.GetDiagnoticRequestHistory(member_id);
        }
        
        public string GetPharmacyRequestHistory(string member_id) {
            return base.Channel.GetPharmacyRequestHistory(member_id);
        }
        
        public string GetHospitalRequestHistory(string member_id) {
            return base.Channel.GetHospitalRequestHistory(member_id);
        }
        
        public string ForgotPassword(string MobileNo) {
            return base.Channel.ForgotPassword(MobileNo);
        }
        
        public string GetUserDetails(string member_id) {
            return base.Channel.GetUserDetails(member_id);
        }
        
        public string GetScheduledReferralList(string login_id, string Logic) {
            return base.Channel.GetScheduledReferralList(login_id, Logic);
        }
        
        public string GetSaleByLogin(string login_id, string Logic) {
            return base.Channel.GetSaleByLogin(login_id, Logic);
        }
        
        public string UpdateLatLong(string emp_code, string d_code, string prm_1, string prm_2, string logic) {
            return base.Channel.UpdateLatLong(emp_code, d_code, prm_1, prm_2, logic);
        }
        
        public string SalesLogin(string UserId, string password) {
            return base.Channel.SalesLogin(UserId, password);
        }
        
        public string GetTargetList(string login_id, string Logic) {
            return base.Channel.GetTargetList(login_id, Logic);
        }
        
        public string InHouseAppLogin(string AppName, string emp_code, string psw, string Logic, string OTP) {
            return base.Channel.InHouseAppLogin(AppName, emp_code, psw, Logic, OTP);
        }
        
        public string TagGeo_ReferralAndVisit(string emp_code, string d_code, string geo_lat, string geo_long, string remark, string logic) {
            return base.Channel.TagGeo_ReferralAndVisit(emp_code, d_code, geo_lat, geo_long, remark, logic);
        }
    }
}
