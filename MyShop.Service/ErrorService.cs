﻿using MyShop.Data.Infrastructure;
using MyShop.Data.Respositories;
using MyShop.Model.Models;

namespace MyShop.Service
{
    public interface IErrorService
    {
        Error Create(Error error);

        void Save();
    }

    public class ErrorService : IErrorService
    {
        private IErrorRespository _errorRepository;
        private IUnitOfWork _unitOfWork;

        public ErrorService(IErrorRespository errorRepository, IUnitOfWork unitOfWork)
        {
            this._errorRepository = errorRepository;
            this._unitOfWork = unitOfWork;
        }

        public Error Create(Error error)
        {
            return _errorRepository.Add(error);
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }
    }
}