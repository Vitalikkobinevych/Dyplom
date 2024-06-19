﻿using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using System.Collections.Generic;

namespace WebApplication1.Controllers
{
    public class PetitionController : Controller
    {
        public IActionResult Index()
        {
            var petitions = new List<PetitionViewModel>
            {
                new PetitionViewModel { Id = 1, Title = "Збільшення фінансування освіти", Description = "Підтримайте петицію за збільшення фінансування освітніх закладів...", ImageUrl = "https://images.pexels.com/photos/355948/pexels-photo-355948.jpeg?auto=compress&cs=tinysrgb&w=600" },
                new PetitionViewModel { Id = 2, Title = "Заборона використання пластику", Description = "Підтримайте петицію за заборону використання пластику...", ImageUrl = "https://images.pexels.com/photos/373548/pexels-photo-373548.jpeg?auto=compress&cs=tinysrgb&w=600" },
                // Add more petitions as needed
            };

            return View(petitions);
        }

        public IActionResult Details(int id)
        {
            var petition = new PetitionViewModel
            {
                Id = id,
                Title = "Збільшення фінансування освіти", // Replace with actual data
                Description = "Ми, мешканці нашого затишного міста, звертаємося до вас із важливим питанням, яке стосується майбутнього наших дітей та онуків — питанням фінансування освіти. У сучасному світі, як ніколи, необхідно забезпечити нашим дітям якісну освіту, яка відповідає вимогам сьогодення. На жаль, нинішній рівень фінансування не дозволяє досягти цієї мети в повній мірі.\r\n\r\nОсвіта є основою розвитку нашого суспільства та економіки. Інвестуючи в освіту, ми інвестуємо в майбутнє нашого міста, його стабільність та процвітання. Достатнє фінансування освітньої сфери дозволить:\r\n\r\nПоліпшити умови навчання: Забезпечити наші школи сучасними матеріалами, обладнанням та технологіями.\r\nПідвищити кваліфікацію вчителів: Надати можливості для постійного професійного розвитку та підвищення кваліфікації наших педагогів.\r\nЗабезпечити доступ до освіти для всіх: Підтримати дітей із малозабезпечених сімей та забезпечити рівний доступ до якісної освіти для всіх наших дітей.\r\nПідтримати місцеві наукові ініціативи: Стимулювати розвиток науки та інновацій у нашому місті.\r\nМи закликаємо владу нашого міста та регіону збільшити фінансування освітньої сфери, забезпечити ефективне та цільове використання бюджетних коштів, а також сприяти залученню додаткових інвестицій у розвиток освіти. Ми впевнені, що ці заходи сприятимуть підвищенню рівня освіти, розвитку інтелектуального потенціалу нашого міста та зміцненню його позицій у регіоні.\r\n\r\nПідтримайте нашу петицію, якщо ви вважаєте, що якісна освіта є ключем до успішного майбутнього наших дітей та нашого міста. Разом ми можемо зробити важливий крок для забезпечення гідного життя нашим дітям та наступним поколінням.\r\n\r\nЗ повагою,\r\nВіталій", // Replace with actual data
                ImageUrl = "https://images.pexels.com/photos/355948/pexels-photo-355948.jpeg?auto=compress&cs=tinysrgb&w=600" // Replace with actual data
            };

            return View(petition);
        }
    }
}
