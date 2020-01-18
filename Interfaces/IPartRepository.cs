using GruntbackAuto.Models;
using System.Collections.Generic;

namespace GruntbackAuto.Interfaces
{
    public interface IPartRepository
    {
        void AddPart(Part part);
        IEnumerable<Part> GetAllParts();
        Part GetPart(int id);
    }
}