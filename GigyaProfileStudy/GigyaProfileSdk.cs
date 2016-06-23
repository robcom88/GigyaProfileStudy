using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gigya.Socialize.SDK;

namespace GigyaProfileStudy
{
    public class GigyaProfileSdk
    {
        private const string _apiKey = "3_Nv7wuEL4y6JiSMWIzkts_kOi1K7iSjN7uIum8W8okGow8ipmaxyfxRhOstfUwmEV";
        private const string _apiSecret = "taIF5YS7YKAb/VtYTRHI1GXWznWcK5BK";
        private const string _userKey = "AFY05mHz4xmh";

        private const string GetUserInfoMethodName = "socialize.getUserInfo";
        private const string GetAccountInfoMethodName = "accounts.getAccountInfo";
        private const string SetAccountInfoMethodName = "accounts.setAccountInfo";
        
        private const string uid = "4fdba411391946c7b71821b0e4d93416";


        private const string UIDParam = "UID";
        private const string SignatureTimeStampParam = "signatureTimestamp";
        private const string UIDSignatureParam = "UIDSignature";
        private const string UserNameParam = "nickname";
        private const string EmailParam = "email";
        private const string FirstNameParam = "firstName";
        private const string LastNameParam = "lastName";


        public string GetProfile()
        {
            

            try
            {
                //var req = new GSRequest(_apiKey,_apiSecret,GetUserInfoMethodName,null,true,_userKey);
                //var req = new GSRequest(_apiKey,_apiSecret,GetAccountInfoMethodName,null,true,_userKey);
                var req = new GSRequest(_apiKey,_apiSecret,SetAccountInfoMethodName,null,true,_userKey);
                req.SetParam("uid",uid);
                var updatedData = @"{'hearstEdbid0':'12345'}";

                req.SetParam("data",updatedData);
                
                var res = req.Send(5000);         // send request but timeout after 5 seconds

                if(res.GetErrorCode() == 0)
                {
                    //var UserName = res.GetString(UIDParam, "");
                    //var Email = res.GetString(EmailParam, "");
                    //var FirstName = res.GetString(FirstNameParam, "");
                    //var LastName = res.GetString(LastNameParam, "");
                    //return FirstName + " " + LastName;
                    
                    GSObject responseData = res.GetData();
                    GSObject data = responseData.GetObject("data");

                    return "";
                }
                else
                {
                    return res.GetErrorCode() + res.GetErrorMessage();
                }

            }
            catch(Exception ex)
            {
                throw;
            }
        }

    }
}
