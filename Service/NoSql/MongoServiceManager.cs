using AutoMapper;
using Contracts.IRepository;
using Contracts.IService;
using Contracts;
using Contracts.IService.NoSql;
using Entities.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts.IRepository.NoSql;

namespace Service.NoSql
{
    public sealed class MongoServiceManager : IMongoServiceManager
    {
        private readonly Lazy<IAuditService> _auditService;

        public MongoServiceManager(IMongoRepositoryManager repositoryManager)
        {
            _auditService = new Lazy<IAuditService>(() => new AuditService(repositoryManager));
        }

        public IAuditService AuditService => _auditService.Value;
    }
}
