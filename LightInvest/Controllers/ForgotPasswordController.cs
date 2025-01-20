﻿using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

public class PasswordRecoveryController : Controller
{
	[HttpGet]
	public IActionResult Recover()
	{
		return View();
	}

	[HttpPost]
	public async Task<IActionResult> Recover(string email)
	{
		if (ModelState.IsValid)
		{
			TempData["SuccessMessage"] = "Instruções de recuperação foram enviadas para o seu e-mail.";
			return RedirectToAction("Login", "Account");
		}
		return View();
	}
}