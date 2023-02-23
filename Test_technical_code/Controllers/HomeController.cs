using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test_technical_code.Models;

namespace Test_technical_code.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult GenerateSegitiga(string input)
        {
            var resp = new Response();

            if (ValidateInput(input)) {
                resp.Success = true;

                var output = new List<string>();

                for (int i = 0; i < input.Length; i++) {
                    string added = "";
                    for (int j = 0; j <= i; j++) {
                        added += "0";
                    }
                    output.Add(input[i] + added);
                }

                resp.Data = output;
            } else
            {
                resp.Success = false;
            }
            

            return Json(resp, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult GenerateGanjil(string input)
        {
            var resp = new Response();

            if (ValidateInput(input))
            {
                resp.Success = true;

                var output = new List<string>();

                for (int i = 1; i < (int.Parse(input) + 1); i++) { 
                    if (i % 2 != 0)
                    {
                        output.Add(i.ToString());
                    }
                }

                resp.Data = output;
            }
            else
            {
                resp.Success = false;
            }


            return Json(resp, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult GeneratePrima(string input)
        {
            var resp = new Response();

            if (ValidateInput(input))
            {
                resp.Success = true;

                var output = new List<string>();

                for (int i = 1; i < (int.Parse(input) + 1); i++)
                {
                    bool prime = true;
                    int j;
                    for (j = 2; j <= i - 1; j++)
                    {
                        if (i % j == 0)
                        {
                            prime = false;
                            break;
                        }
                    }
                    if (prime)
                    {
                        output.Add(i.ToString());
                    }
                }

                resp.Data = output;
            }
            else
            {
                resp.Success = false;
            }


            return Json(resp, JsonRequestBehavior.AllowGet);
        }


        private bool ValidateInput(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return false;
            }

            if (!int.TryParse(input, out int result))
            {
                return false;
            }

            return true;
        }

    }
}