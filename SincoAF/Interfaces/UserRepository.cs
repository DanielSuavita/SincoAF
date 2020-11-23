using System;
using System.Collections.Generic;
using SincoAF.Models;

namespace SincoAF.Interfaces {
    public interface UserRepository {

        Boolean Create(UserEntity User);
        Boolean Update(UserEntity User);
        Boolean Delete(UserEntity User);
        List<UserEntity> Select();

    }
}
