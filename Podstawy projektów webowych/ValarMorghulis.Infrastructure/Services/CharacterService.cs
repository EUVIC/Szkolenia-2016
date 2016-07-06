using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using ValarMorghulis.Common.Exceptions;
using ValarMorghulis.Domain;
using ValarMorghulis.Domain.Interfaces;
using ValarMorghulis.Domain.Repositories;
using ValarMorghulis.Infrastructure.Interfaces;
using ValarMorghulis.Infrastructure.Models;

namespace ValarMorghulis.Infrastructure.Services
{
    public class CharacterService
    {
        private readonly ICharacterRepository characterRepository;

        public CharacterService()
        {
            characterRepository = new CharacterRepository();
        }

        private bool IsCharacterNameAlreadyTaken(string name, int? editedCharacterId = null)
        {
            if (editedCharacterId.HasValue)
            {
                return characterRepository.GetAll().Any(c => c.Name == name && c.Id != editedCharacterId);
            }
            return characterRepository.GetAll().Any(c => c.Name == name);
        }

        public CharacterWithIdDTO GetCharacterDetails(int id)
        {
            Character entity = characterRepository.GetSingle(id);
            if (entity == null)
            {
                throw new CharacterDoesNotExistException();
            }
            return Mapper.Map<CharacterWithIdDTO>(entity);
        }

        public IEnumerable<CharacterWithIdDTO> GetCharacters()
        {
            IQueryable<Character> entities = characterRepository.GetAll();
            return Mapper.Map<IEnumerable<CharacterWithIdDTO>>(entities);
        }

        public void CreateCharacter(CharacterDTO viewModel)
        {
            if (IsCharacterNameAlreadyTaken(viewModel.Name))
            {
                throw new CharacterNameAlreadyTakenException();
            }

            Character entity = Mapper.Map<Character>(viewModel);

            characterRepository.Add(entity);
            characterRepository.Save();
        }

        public void UpdateCharacter(int id, ICharacterDTO viewModel)
        {
            Character entity = characterRepository.GetSingle(id);

            if (entity == null)
            {
                throw new CharacterDoesNotExistException();
            }
            if (IsCharacterNameAlreadyTaken(viewModel.Name, id))
            {
                throw new CharacterNameAlreadyTakenException();
            }

            Mapper.Map(viewModel, entity);
            characterRepository.Save();
        }

        public void UpdateCharacter(CharacterWithIdDTO viewModel)
        {
            UpdateCharacter(viewModel.Id, viewModel);
        }

        public void DeleteCharacter(int id)
        {
            Character entity = characterRepository.GetSingle(id);

            if (entity == null)
            {
                throw new CharacterDoesNotExistException();
            }

            characterRepository.Delete(entity);
            characterRepository.Save();
        }
    }
}
