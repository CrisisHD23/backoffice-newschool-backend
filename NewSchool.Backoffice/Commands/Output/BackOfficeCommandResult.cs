﻿using NewSchool.Backoffice.Infra.Comum;

namespace NewSchool.Backoffice.Commands.Output
{
    public class BackOfficeCommandResult : ICommandResult
    {
        public BackOfficeCommandResult(bool success, string message, object data)
        {
            Success = success;
            Message = message;
            Data = data;
        }

        public bool Success { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }
    }
}
