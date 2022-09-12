using AutoRent.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoRent.Core.Interfaces
{
    public interface IUserService : IService<UserRequestInitialDto, UserResponseDto>
    {
        public void CompleteRegistration(string id, UserRequestCompletionDto userRequestCompletionDto);
    }
}
