using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
//using Amazon;
//using Amazon.SecretsManager;
//using Amazon.SecretsManager.Model;
using IntexFinal.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace IntexFinal.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<IdentityUser> userManager;
        private SignInManager<IdentityUser> signInManager;

        public AccountController(UserManager<IdentityUser> um, SignInManager<IdentityUser> sim)
        {
            userManager = um;
            signInManager = sim;
        }

        //public static void GetSecret()
        //{
        //    string secretName = "Intex";
        //    string region = "us-east-1";
        //    string secret = "";

        //    MemoryStream memoryStream = new MemoryStream();

        //    IAmazonSecretsManager client = new AmazonSecretsManagerClient(RegionEndpoint.GetBySystemName(region));

        //    GetSecretValueRequest request = new GetSecretValueRequest();
        //    request.SecretId = secretName;
        //    request.VersionStage = "AWSCURRENT"; // VersionStage defaults to AWSCURRENT if unspecified.

        //    GetSecretValueResponse response = null;

        //    // In this sample we only handle the specific exceptions for the 'GetSecretValue' API.
        //    // See https://docs.aws.amazon.com/secretsmanager/latest/apireference/API_GetSecretValue.html
        //    // We rethrow the exception by default.

        //    try
        //    {
        //        response = client.GetSecretValueAsync(request).Result;
        //    }
        //    catch (DecryptionFailureException e)
        //    {
        //        // Secrets Manager can't decrypt the protected secret text using the provided KMS key.
        //        // Deal with the exception here, and/or rethrow at your discretion.
        //        throw;
        //    }
        //    catch (InternalServiceErrorException e)
        //    {
        //        // An error occurred on the server side.
        //        // Deal with the exception here, and/or rethrow at your discretion.
        //        throw;
        //    }
        //    catch (InvalidParameterException e)
        //    {
        //        // You provided an invalid value for a parameter.
        //        // Deal with the exception here, and/or rethrow at your discretion
        //        throw;
        //    }
        //    catch (InvalidRequestException e)
        //    {
        //        // You provided a parameter value that is not valid for the current state of the resource.
        //        // Deal with the exception here, and/or rethrow at your discretion.
        //        throw;
        //    }
        //    catch (ResourceNotFoundException e)
        //    {
        //        // We can't find the resource that you asked for.
        //        // Deal with the exception here, and/or rethrow at your discretion.
        //        throw;
        //    }
        //    catch (System.AggregateException ae)
        //    {
        //        // More than one of the above exceptions were triggered.
        //        // Deal with the exception here, and/or rethrow at your discretion.
        //        throw;
        //    }

        //    // Decrypts secret using the associated KMS key.
        //    // Depending on whether the secret is a string or binary, one of these fields will be populated.
        //    if (response.SecretString != null)
        //    {
        //        secret = response.SecretString;
        //    }
        //    else
        //    {
        //        memoryStream = response.SecretBinary;
        //        StreamReader reader = new StreamReader(memoryStream);
        //        string decodedBinarySecret = System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(reader.ReadToEnd()));
        //    }

        //    // Your code goes here.
        //}

        [HttpGet]
        public IActionResult Login(string returnUrl)
        {
            return View(new LoginModel { ReturnUrl = returnUrl });
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel loginModel)
        {
            IdentityUser user = await userManager.FindByNameAsync(loginModel.Username);

            if (user != null)
            {
                await signInManager.SignOutAsync();

                if ((await signInManager.PasswordSignInAsync(user, loginModel.Password, false, false)).Succeeded)
                {
                    return Redirect(loginModel?.ReturnUrl ?? "/Admin");
                }
                else if ((await signInManager.PasswordSignInAsync(user, loginModel.Password, false, false)).RequiresTwoFactor)
                {
                    return Redirect("/2fa");
                }

            }

            ModelState.AddModelError("", "Invalid name or password");

            return View(loginModel);
        }

        public async Task<RedirectResult> Logout(string returnUrl = "/")
        {
            await signInManager.SignOutAsync();

            return Redirect(returnUrl);
        }
    }
}
