using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.DTOs.Contact;
using Core.Services.Interfaces;
using DataLayer.Contexts;
using DataLayer.Entities.ContactAgg;
using Microsoft.EntityFrameworkCore;

namespace Core.Services.Impelimentations
{
    public class ContactService : IContactService
    {
        #region Constructor

        private readonly DataBaseContext _context;

        public ContactService(DataBaseContext context)
        {
            _context = context;
        }

        #endregion

        public async Task<List<ContactUsDto>> GetAllContactUsAsync()
        {
            return await _context.ContactUs.Select(s => new ContactUsDto()
            {
                Name = s.Name,
                ContactUsId = s.ContactUsId,
                Email = s.Email
            }).ToListAsync();
        }

        public async Task<string> GetContactUsMessageByIdAsync(long contactUsId)
        {
            return (await _context.ContactUs.FindAsync(contactUsId)).Message;
        }

        public async Task SendMessageByUserAsync(CreateContactUsDto command)
        {
            var contact = new ContactUs(command.Name, command.Email, command.Message);
            try
            {
                await _context.ContactUs.AddAsync(contact);
                await _context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }
    }
}