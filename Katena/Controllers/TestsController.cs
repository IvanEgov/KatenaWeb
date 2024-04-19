using Humanizer;
using Katena.Domain;
using Katena.Domain.Entities;
using Katena.Models;
using Katena.TestProg;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using MySqlX.XDevAPI.Common;
using Org.BouncyCastle.Crypto;
using System.Diagnostics;
using System.Net;
using System.Text;
using System.Text.Encodings.Web;


namespace Katena.Controllers
{
	public class TestsController : Controller
	{
		private readonly DataManager dataManager;
        
        //respresents number of page while carrying test (-1 - wellcome page,
        //[0:number of questions] - question, number of questions> results)
        private int index;

		public TestsController(DataManager dataManager)
		{
			this.dataManager = dataManager;
		}

		public IActionResult Index(Guid id)
		{
			if (id != default)
			{
				QuestionPackBase pack = dataManager.Packs.GetPackById(id);
				index = -1;
				ViewBag.pack = pack;
				ViewBag.index = index;
				return View();
			}
/*			ViewBag.TextField = dataManager.TextFields.GetTextFieldByCodeWord("PageTests");*/
			return View(dataManager.TextFields.GetTextFieldByCodeWord("PageTests"));
		}

        /*[HttpPost]
        public IActionResult SetGender(string gender, Guid id)
        {
            ViewBag.gender = gender;
			QuestionPackBase pack = dataManager.Packs.GetPackById(id);
			ViewBag.pack = pack;
			ViewBag.index = -1;
			return View("Index");
		}*/

		[HttpPost]
		public IActionResult NextQuestion(Guid pack, int index, Guid question, Guid answers, Guid reason, string gender, bool checkReason = false)
		{
            //TODO: Test logic
            //  
            ViewBag.reason = checkReason;
            ViewBag.gender = gender;
			
			if (!checkReason)
			{
				index = index + 1;
				if (reason != new Guid("00000000-0000-0000-0000-000000000000"))
				{
					CalculationLoogiсReason calcReason = new CalculationLoogiсReason(dataManager.Reasons.GetReasonById(reason));
					calcReason.MassCheckReason();
				
					
                    //Условия создания контейнера куки 
                    if (HttpContext.Session.Keys.Contains("distr_mentor"))
                    {

                        Int32 distr_mentor = Int32.Parse(HttpContext.Session.GetString("distr_mentor"));
                        Int32 flag = distr_mentor + (int)calcReason.distr_mentor;
                        HttpContext.Session.SetString("distr_mentorP", $"{flag}");
                    }
                    else
                    {
                        HttpContext.Session.SetString("distr_mentor", $"{calcReason.distr_mentor}");

                    }

                    if (HttpContext.Session.Keys.Contains("distr_looking"))
                    {

                        Int32 distr_looking = Int32.Parse(HttpContext.Session.GetString("distr_looking"));
                        Int32 flag = distr_looking + (int)calcReason.distr_looking;
                        HttpContext.Session.SetString("distr_looking", $"{flag}");
                    }
                    else
                    {
                        HttpContext.Session.SetString("distr_looking", $"{calcReason.distr_looking}");

                    }

                    if (HttpContext.Session.Keys.Contains("distr_hunter"))
                    {

                        Int32 distr_hunter = Int32.Parse(HttpContext.Session.GetString("distr_hunter"));
                        Int32 flag = distr_hunter + (int)calcReason.distr_hunter;
                        HttpContext.Session.SetString("distr_hunter", $"{flag}");
                    }
                    else
                    {
                        HttpContext.Session.SetString("distr_hunter", $"{calcReason.distr_hunter}");

                    }

                    if (HttpContext.Session.Keys.Contains("distr_mentorP"))
                    {

                        Int32 distr_mentorP = Int32.Parse(HttpContext.Session.GetString("distr_mentorP"));
                        Int32 flag = distr_mentorP + calcReason.distr_mentorP;
                        HttpContext.Session.SetString("distr_mentorP", $"{flag}");
                    }
                    else
                    {
                        HttpContext.Session.SetString("distr_mentorP", $"{calcReason.distr_mentorP}");

                    }

                    if (HttpContext.Session.Keys.Contains("distr_lookingP"))
                    {

                        Int32 distr_lookingP = Int32.Parse(HttpContext.Session.GetString("distr_lookingP"));
                        Int32 flag = distr_lookingP + calcReason.distr_lookingP;
                        HttpContext.Session.SetString("distr_lookingP", $"{flag}");
                    }
                    else
                    {
                        HttpContext.Session.SetString("distr_lookingP", $"{calcReason.distr_lookingP}");

                    }

                    if (HttpContext.Session.Keys.Contains("distr_hunterP"))
                    {

                        Int32 distr_hunterP = Int32.Parse(HttpContext.Session.GetString("distr_hunterP"));
                        Int32 flag = distr_hunterP + calcReason.distr_hunterP;
                        HttpContext.Session.SetString("distr_hunterP", $"{flag}");
                    }
                    else
                    {
                        HttpContext.Session.SetString("distr_hunterP", $"{calcReason.distr_hunterP}");

                    }
                }
            }
			else
			{
				ViewBag.answer = dataManager.Answers.GetAnswerById(answers);
				if (answers != new Guid("00000000-0000-0000-0000-000000000000"))
				{
					CalculationLoogiсAnswer calcAnswer = new CalculationLoogiсAnswer(dataManager.Answers.GetAnswerById(answers));
					calcAnswer.MassCheckAnswer();
					
					
                    //Условия создания контейнера куки 
                    if (HttpContext.Session.Keys.Contains("style_p"))
                    {

                        Int32 style_p = Int32.Parse(HttpContext.Session.GetString("style_p"));
                        Int32 flag = style_p + (int)calcAnswer.style_P;
                        HttpContext.Session.SetString("style_p", $"{flag}");
                    }
                    else
                    {
                        HttpContext.Session.SetString("style_p", $"{calcAnswer.style_P}");

                    }

                    if (HttpContext.Session.Keys.Contains("style_a"))
                    {

                        Int32 style_a = Int32.Parse(HttpContext.Session.GetString("style_a"));
                        Int32 flag = style_a + (int)calcAnswer.style_A;
                        HttpContext.Session.SetString("style_a", $"{flag}");
                    }
                    else
                    {
                        HttpContext.Session.SetString("style_a", $"{calcAnswer.style_A}");

                    }

                    if (HttpContext.Session.Keys.Contains("style_e"))
                    {

                        Int32 style_e = Int32.Parse(HttpContext.Session.GetString("style_e"));
                        Int32 flag = style_e + (int)calcAnswer.style_E;
                        HttpContext.Session.SetString("style_e", $"{flag}");
                    }
                    else
                    {
                        HttpContext.Session.SetString("style_e", $"{calcAnswer.style_E}");

                    }

                    if (HttpContext.Session.Keys.Contains("style_i"))
                    {

                        Int32 style_i = Int32.Parse(HttpContext.Session.GetString("style_i"));
                        Int32 flag = style_i + (int)calcAnswer.style_I;
                        HttpContext.Session.SetString("style_i", $"{flag}");
                    }
                    else
                    {
                        HttpContext.Session.SetString("style_i", $"{calcAnswer.style_I}");

                    }

                    if (HttpContext.Session.Keys.Contains("style_pp"))
                    {
						
						Int32 style_pp = Int32.Parse(HttpContext.Session.GetString("style_pp"));
						Int32 flag = style_pp + calcAnswer.style_PP;
						HttpContext.Session.SetString("style_pp", $"{flag}");
                    }
					else
					{
                        HttpContext.Session.SetString("style_pp", $"{calcAnswer.style_PP}");
                       
                    }
					
                    if (HttpContext.Session.Keys.Contains("style_aa"))
                    {

                        Int32 style_aa = Int32.Parse(HttpContext.Session.GetString("style_aa"));
						Int32 flag = style_aa + calcAnswer.style_AA;
                        HttpContext.Session.SetString("style_aa", $"{flag}");
                    }
                    else
                    {
                        HttpContext.Session.SetString("style_aa", $"{calcAnswer.style_AA}");

                    }

                    if (HttpContext.Session.Keys.Contains("style_ee"))
                    {

                        Int32 style_ee = Int32.Parse(HttpContext.Session.GetString("style_ee"));
						Int32 flag = style_ee + calcAnswer.style_EE;
                        HttpContext.Session.SetString("style_ee", $"{flag}");
                    }
                    else
                    {
                        HttpContext.Session.SetString("style_ee", $"{calcAnswer.style_EE}");

                    }

                    if (HttpContext.Session.Keys.Contains("style_ii"))
                    {

                        Int32 style_ii = Int32.Parse(HttpContext.Session.GetString("style_ii"));
						Int32 flag = style_ii + calcAnswer.style_II;
                        HttpContext.Session.SetString("style_ii", $"{flag}");
                    }
                    else
                    {
                        HttpContext.Session.SetString("style_ii", $"{calcAnswer.style_II}") ;

                    }

                }
            }
			
			ViewBag.pack = dataManager.Packs.GetPackById(pack);
            ViewBag.index = index;
			if (ViewBag.pack != null)
			{
				if (ViewBag.index == ViewBag.pack.QuestionsIds.Count)
				{
					/// Допсиать расчет результатат
					/// 
					
                   if( HttpContext.Session.Keys.Contains("style_pp"))
					{
						int style_pp_s = Int32.Parse(HttpContext.Session.GetString("style_pp"))/10 +1 + Int32.Parse(HttpContext.Session.GetString("style_p"));
                        int style_ee_s = Int32.Parse(HttpContext.Session.GetString("style_aa"))/10 +1 + Int32.Parse(HttpContext.Session.GetString("style_a"));
                        int style_aa_s = Int32.Parse(HttpContext.Session.GetString("style_ee")) / 10 + 1 + Int32.Parse(HttpContext.Session.GetString("style_e"));
                        int style_ii_s = Int32.Parse(HttpContext.Session.GetString("style_ii")) / 10 + 1 + Int32.Parse(HttpContext.Session.GetString("style_i"));

                       
                        int distr_mentorP_s = Int32.Parse(HttpContext.Session.GetString("distr_mentorP"))/10 +1 + Int32.Parse(HttpContext.Session.GetString("distr_mentor"));
                        int distr_lookingP_s = Int32.Parse(HttpContext.Session.GetString("distr_lookingP")) / 10 + 1 + Int32.Parse(HttpContext.Session.GetString("distr_looking"));
                        int distr_hunterP_s = Int32.Parse(HttpContext.Session.GetString("distr_hunterP")) / 10 + 1 + Int32.Parse(HttpContext.Session.GetString("distr_hunter"));

                        int max_styl = Math.Max(style_pp_s,Math.Max(style_ee_s, Math.Max(style_aa_s, style_ii_s)));
                        int max_distr = Math.Max(distr_mentorP_s, Math.Max(distr_lookingP_s, distr_hunterP_s));
                       if(max_styl == style_pp_s)
                        {
                            //вывод Производитель
                            ViewBag.calculateStyle = "Производитель";

                        }
                       else if (max_styl== style_aa_s) 
                        {
                            //вывод  Админестратор
                            ViewBag.calculateStyle = "Администратор";
                        }
                       else if(max_styl == style_ee_s)
                        {
                            //вывод  Предприниматель
                            ViewBag.calculateType = "Предприниматель";
                        }
                       else
                        {
                            //Вывод  Интегратор
                            ViewBag.calculateType = "Интегратор";
                        }

                       if(max_distr == distr_mentorP_s)
                        {
                         //   if(ViewBag.)
                            //вывод дистрикта наставник/заботлива
                            ViewBag.calculateType = "Наставник";
                        }
                       else if(max_distr == distr_lookingP_s)
                        {
                            //вывод дистрикта ищущий/познающая
                            ViewBag.calculateType = "Ищущий";
                        }
                       else
                        {
                            //вывод дистрикта охотник/хранительница
                            ViewBag.calculateType = "Охотник";
                        }

                       /// Дописать удаление куки сесии++++++++++++++++++++++++++++++++++++++++++++++++++++
                    }


                }
			}
            return View("Index", dataManager.TextFields.GetTextFieldByCodeWord("PageTests"));
		}

	}
   
}
