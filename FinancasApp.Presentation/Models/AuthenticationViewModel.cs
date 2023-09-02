﻿namespace FinancasApp.Presentation.Models
{
    public class AuthenticationViewModel
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataHoraAcesso { get; set; }
    }
}
