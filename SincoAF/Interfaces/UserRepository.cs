using System;
using System.Collections.Generic;
using SincoAF.Models;

namespace SincoAF.Interfaces {
    interface UserRepository {

        Boolean Create(UserEntity User);
        Boolean Update(UserEntity User);
        Boolean Delete(int id);
        List<object> Select(string name);

    }
}
