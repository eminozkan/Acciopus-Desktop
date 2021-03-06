using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acciopus
{
    enum LoginStatements
    {
        Success,
        WrongPassword,
        WrongEmail,
        Fail
    }

    enum RegisterStatements
    {
        Success,
        Fail
    }

    enum RequestStatements
    {
        Success,
        Fail
    }

    enum LogOffStatements
    {
        UserWantsToQuit,
        UserDoesntWantToQuit
    }


    enum OldPasswordStatements
    {
        NotSame,
        Same
    }

    enum PasswordChangeStatements
    {
        Fail,
        Success
    }

    enum SqlCommandStatements
    {
        Success,
        Fail
    }

    enum ChangeRequestStatements
    {
        NonApproved,
        Approved
    }

}
