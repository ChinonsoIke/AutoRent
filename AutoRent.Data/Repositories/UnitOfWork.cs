using AutoRent.Data.Interfaces;
using AutoRent.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AutoRent.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AutoRentDbContext _dbContext;
        private IGenericRepository<Booking> _bookingRepository;
        private IGenericRepository<Car> _carRepository;
        private IGenericRepository<Feature> _featureRepository;
        private IGenericRepository<Location> _locationRepository;
        private IGenericRepository<Payment> _paymentRepository;
        private IGenericRepository<Post> _postRepository;
        private IGenericRepository<Rating> _ratingRepository;
        private IGenericRepository<User> _userRepository;

        public UnitOfWork(AutoRentDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IGenericRepository<Booking> BookingRepository
        {
            get
            {
                if(_bookingRepository == null)
                {
                    _bookingRepository = new GenericRepository<Booking>(_dbContext);
                }
                return _bookingRepository;
            }
        }

        public IGenericRepository<Car> CarRepository => throw new NotImplementedException();

        public IGenericRepository<Feature> FeatureRepository => throw new NotImplementedException();

        public IGenericRepository<Location> LocationRepository => throw new NotImplementedException();

        public IGenericRepository<Payment> PaymentRepository => throw new NotImplementedException();

        public IGenericRepository<Post> PostRepository => throw new NotImplementedException();

        public IGenericRepository<Rating> RatingRepository => throw new NotImplementedException();

        public IGenericRepository<User> UserRepository => throw new NotImplementedException();

        public async Task Save()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
