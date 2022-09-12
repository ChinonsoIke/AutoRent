using AutoMapper;
using AutoRent.Core.Interfaces;
using AutoRent.Data.Interfaces;
using AutoRent.Dtos;
using AutoRent.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AutoRent.Core.Services
{
    public class UserService : IUserService
    {
        private readonly ILogger _logger;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public UserService(ILogger logger, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task AddAsync(UserRequestInitialDto userRequestInitialDto)
        {
            var user = _mapper.Map<User>(userRequestInitialDto);
            user.Verified = false;
            user.Id = Guid.NewGuid().ToString();
            user.CreatedAt = DateTime.Now;
            user.UpdatedAt = DateTime.Now;

            if (user == null)
            {
                _logger.LogInformation("User DTO did not map to User: Invalid credentials provided for user registeration");
                throw new Exception("One or more of your inputs are incorrect");
            }

            user.Password = BCrypt.Net.BCrypt.HashPassword(user.Password);

            try
            {
                await _unitOfWork.UserRepository.AddAsync(user);
                await _unitOfWork.Save();

                _logger.LogInformation($"User registration for {user.Email} was successful");
            }
            catch (Exception ex)
            {
                _logger.LogInformation($"User details correct but could not add user to database: {ex.Message}");
                throw new Exception("One or more errors occured during your registration");
            }
        }

        public async void CompleteRegistration(string id, UserRequestCompletionDto userRequestCompletionDto)
        {
            var user = await _unitOfWork.UserRepository.GetAsync(u => u.Id == id);
            user.HomeAddress = userRequestCompletionDto.HomeAddress;
            user.NextOfKinName = userRequestCompletionDto.NextOfKinName;
            user.NextOfKinAddress = userRequestCompletionDto.NextOfKinAddress;
            user.NextOfKinContact = userRequestCompletionDto.NextOfKinContact;
            user.DrivingLicenceImage = userRequestCompletionDto.DrivingLicenceImage;
            user.UserImageUrl = userRequestCompletionDto.UserImageUrl;
            user.CompletedRegistration = true;
            user.UpdatedAt = DateTime.Now;

            try
            {
                _unitOfWork.UserRepository.Update(user);
                await _unitOfWork.Save();
                _logger.LogInformation($"Updated user {id} information successfully");
            }
            catch (Exception ex)
            {
                _logger.LogInformation($"Could not update user {id} information: {ex.Message}");
                throw new Exception("Could not update user information");
            }
        }

        public async Task DeleteAsync(string Id)
        {
            try
            {
                await _unitOfWork.UserRepository.DeleteAsync(Id);
            }
            catch (Exception ex)
            {
                _logger.LogInformation($"Could not delete user {Id} from database: {ex.Message}");
                throw new Exception($"Could not delete user {Id} from database");
            }
        }

        public Task<List<UserResponseDto>> GetAllAsync(Expression<Func<UserRequestInitialDto, bool>> expression = null, List<string> includes = null)
        {
            throw new NotImplementedException();
        }

        public Task<UserResponseDto> GetAsync(Expression<Func<UserRequestInitialDto, bool>> expression, List<string> includes = null)
        {
            throw new NotImplementedException();
        }

        public void Update(string Id, UserRequestInitialDto item)
        {
            var user = await _unitOfWork.UserRepository.GetAsync(u => u.Id == id);

            try
            {
                _unitOfWork.UserRepository.Update(user);
                await _unitOfWork.Save();
                _logger.LogInformation($"Updated user {id} information successfully");
            }
            catch (Exception ex)
            {
                _logger.LogInformation($"Could not update user {id} information: {ex.Message}");
                throw new Exception("Could not update user information");
            }
        }
    }
}
