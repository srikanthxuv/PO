angular.module('TEPOApp')
    .factory('DraftPOFactory', function($sessionStorage, $http) {
        var result = {};
        result.PODraftList_Pagination = function(data) { return $http.post($sessionStorage.purchaseorder_url+'/PurchaseOrder/TEPurchaseDraftList_Pagination', data, heads); }
        result.POPDFDefaultView = function(data) { return $http.post($sessionStorage.purchaseorder_url_mvc+'/POGeneratePDF/PODefaultView', data, heads); }
        result.submitForApproval = function(data){return $http.post($sessionStorage.purchaseorder_url+'/TEPOSearchAPI/SubmitForApprove',data,heads);}
	    result.PendingForPOApprove = function(data) {  return $http.post($sessionStorage.purchaseorder_url+'/TEPOSearchAPI/ApprovePO', data, heads); }
        result.PendingForPOReject = function(data) {  return $http.post($sessionStorage.purchaseorder_url+'/PurchaseOrder/POReject', data, heads); }
        result.POWithDrawl = function(data) {  return $http.post($sessionStorage.purchaseorder_url+'/PurchaseOrder/POWithDrawl', data, heads); }
        result.ManualExpirExtensionOfferCall = function(data){return $http.post($sessionStorage.server_url+'/OfferManualExpiry/ExtendExpiryDate',data,heads);}
        result.GetPurchaseItemswithPOIdForGLupdate = function(data) {  return $http.post($sessionStorage.purchaseorder_url+'/GLAccountAPI/GetPurchaseItemswithPOIdForGLupdate', data, heads); }
        result.GetGLAccountDetails = function(data) {  return $http.post($sessionStorage.purchaseorder_url+'/GLAccountAPI/GetGLAccountDetails', data, heads); }
        result.UpdateGLAccountDetails = function(data) {  return $http.post($sessionStorage.purchaseorder_url+'/GLAccountAPI/UpdateGLAccountsForPurchaseItems', data, heads); }
        return result;
    })