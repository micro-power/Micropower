
using MongoDB.Bson;

namespace Micropower.Interfaces

{
    public interface IBson
    {
        ObjectId Id { get; set; }
    }
}

