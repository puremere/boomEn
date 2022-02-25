using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace banimo.apiViewModel
{
    public class baseClass
    {
        public string mbrand { get; set; }
        public string device { get; set; }
        public string code { get; set; }
        public string lan { get; set; }
    }
    public class getCats: baseClass
    {
        public string ID { get; set; }

        public string catLevel { get; set; }
    }
    public class addTransaction: baseClass
    {
        public string price { get; set; }
        public string token { get; set; }
        public string status { get; set; }
    }
    public class buyRequest: baseClass
    {
        public string token { get; set; }
        public string status { get; set; }
        public string fullname { get; set; }
        public string mobile { get; set; }
        public string email { get; set; }
        public string state { get; set; }
        public string city { get; set; }
        public string address { get; set; }
        public string addressID { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public string hourID { get; set; }
        public string comment { get; set; }
        public string phone { get; set; }
        public string payment { get; set; }
        public string ids { get; set; }
        public string nums { get; set; }
        public string discount { get; set; }
        public string postalCode { get; set; }
        public string auth { get; set; }
    }

    public class callMe: baseClass
    {
        public string id { get; set; }
        public string token { get; set; }
        public string mobile { get; set; }
        public string email { get; set; }
    }
    public class changePass: baseClass
    {
        public string password { get; set; }
        public string activate_code { get; set; }
        public string mobile { get; set; }
      
    }
    public class commentArticleProduct: baseClass
    {
        public string comment { get; set; }
        public string MyProtokenperty { get; set; }
        public string ID { get; set; }
        public string title { get; set; }
        public string email { get; set; }
        public string name { get; set; }
        public string mobile { get; set; }
        public string token { get; set; }
    }
    public class commentProduct: baseClass
    {
        public string token { get; set; }
        public string ID { get; set; }
        public string title { get; set; }
        public string comment { get; set; }
    }
    public class compare: baseClass
    {
        public  string productID { get; set; }
        public  string productID2 { get; set; }
      
    }
    
    public class compareSearch: baseClass
    {
        public  string productID { get; set; }
        public  string word { get; set; }
     
    }
    
          public class completeProfile: baseClass
    {
        public  string mobile { get; set; }
        public  string token { get; set; }
        public  string fullname { get; set; }
        public  string email { get; set; }
        public  string province { get; set; }
        public  string city { get; set; }
        public  string address { get; set; }
        public  string latitude { get; set; }
        public  string longitude { get; set; }
    }

    public class confirmUser: baseClass
    {
        public  string mobile { get; set; }
    }
    public   class defaultAddress: baseClass
    {
        public string token{get; set;} public string id{get; set;}
    }
    public class doFinalCheck: baseClass
    {
        public string token{get; set;} public string auth{get; set;} public string amount{get; set;} public string refID{get; set;}
           public string paymentStatus{get; set;} public string payment{get; set;} public string isPayed{get; set;}
    }
    public class doSignIn: baseClass
    {
        public string password{get; set;} public string phone{get; set;}
    }
    public class doSignUp: baseClass
    {
        public string password{get; set;} public string phone{get; set;} public string moaref{get; set;}
    }
    public class doWalletFinalCheck: baseClass
    {
        public string auth{get; set;}
    }
    public class editProduct: baseClass
    {
        public string id{get; set;} public string token{get; set;} public string newPrice{get; set;} public string newTitle{get; set;} public string newDesc{get; set;} public string newDiscount{get; set;}
            public string newCount{get; set;} public string isOffer{get; set;} public string isSpecial{get; set;} public string isAvalible { get; set;} public string isActive{get; set;}
    }
    public class FinalizeOrder: baseClass
    {
        public string deliverID{get; set;} public string desc{get; set;} public string ID{get; set;} public string status{get; set;}

    }
    public class getCredit: baseClass
    {
        public string token{get; set;}
    }
    public class getCode: baseClass
    {
        public string user{get; set;} public string activeCode{get; set;}
    }
    public class getDataArticleComment: baseClass
    {
        public string token{get; set;} public string ID{get; set;}
    }



    public class getDataArticlesDetail: baseClass
    {
        public string token{get; set;} public string id{get; set;}
    }

    public class getDataCatArticle: baseClass
    {
        public string page{get; set;}
    }
    public class getDataCatArticlesList: baseClass
    {
        public string page{get; set;} public string id{get; set;} public string hashtag{get; set;}

    }

    public class getDataComment: baseClass
    {
        public string token{get; set;} public string ID{get; set;}
    }
    public class getDataMyOrderDetails: baseClass
    {
        public string ID {get; set;}
    }
    public class getDataMyOrders: baseClass
    {
        public string token{get; set;}
    }
    public class getDataProductList0: baseClass
    {
        public string wonder { get; set; }
        public string page{get; set;} public string colorIds{get; set;} public string filterIds{get; set;} public string min
           {get; set;} public string max{get; set;} public string hashtag{get; set;} public string sortID{get; set;} public string priorityID{get; set;} public string specificItem{get; set;} public string query{get; set;} public string catID{get; set;} public string catLevel{get; set;} public string isAvalible{get; set;}
    }
    public class getDataProfile: baseClass
    {
        public string mobile{get; set;} public string token{get; set;}
    }
    public class getDataWishList: baseClass
    {
        public string token{get; set;}
    }
    public class getDeliverCode: baseClass
    {
        public string token{get; set;} public string deliverCode{get; set;} public string tranID{get; set;} public string ID{get; set;}
    }
    public class getDeliverList: baseClass
    {
        public string token{get; set;}
    }
    public class getDiscount: baseClass
    {
        public string discountCode{get; set;} public string token{get; set;} public string price{get; set;}
    }
    public class getListOfFeaturesCombinWithValue: baseClass
    {
        public string productID{get; set;}
    }
    public class getproductdetailForCookie: baseClass
    {
        public string idlist{get; set;}
    }
    public class getSubcatData: baseClass
    {
        public string id{get; set;} public string token{get; set;}
    }
    public class getTime: baseClass
    {
        public string storeID{get; set;} public string token{get; set;}
    }
    public class getTypeList: baseClass
    {
        public string catID{get; set;} public string catLevel{get; set;}
    }
    public class isInArea: baseClass
    {
        public string token{get; set;} public string latitude{get; set;} public string longitude { get; set; }
    }
    public class removeAddress: baseClass
    {
        public string token{get; set;} public string id{get; set;}
    }
    public class sendCodeAgain: baseClass
    {
        public string mobile{get; set;}
    }
    public class sendSMS: baseClass
    {
        public string mobile{get; set;}
    }
    public class setAddress: baseClass
    {
        public string token{get; set;} public string address{get; set;} public string lat{get; set;} public string lng{get; set;} public string postalCode
           {get; set;} public string title{get; set;} public string city{get; set;} public string state{get; set;} public string id{get; set;}
    }
    public class setAUTcode: baseClass
    {
        public string token{get; set;} public string timestamp{get; set;} public string auth{get; set;}
    }
    public class setauth: baseClass
    {
        public string token{get; set;} public string timestamp{get; set;} public string auth{get; set;}
    }
    public class setWalletAuth: baseClass
    {
        public string timestamp{get; set;} public string auth{get; set;}
    }
    public class update: baseClass
    {
        public string model{get; set;} public string osVersion{get; set;} public string minSdk{get; set;} public string versionCode{get; set;} public string versionName{get; set;} public string os
           {get; set;} public string mobile{get; set;} public string latitude{get; set;} public string longitude{get; set;} public string token{get; set;}
    }
    public class viewArticle: baseClass
    {
        public string token{get; set;} public string id{get; set;}
    }
    public class viewProduct: baseClass
    {
        public string token{get; set;} public string id{get; set;}
    }
    public class getproductVM : baseClass
    {
        public string  page { get; set; }
    }
}