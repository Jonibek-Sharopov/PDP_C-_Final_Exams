using FirstModuleFinalExam.Model;

namespace FirstModuleFinalExam.Service;

public class PhoneService
{
    private List<Phone> _phones;

    public PhoneService()
    {
        _phones = new List<Phone>();
    }

    public Phone AddPhone(Phone phone)
    {
        phone.Id = Guid.NewGuid();
        _phones.Add(phone);
        
        return phone;
    }

    public List<Phone> GetAllPhones()
    {
        return _phones;
    }

    public Phone GetPhoneById(Guid phoneId)
    {
        foreach (var phone in _phones)
        {
            if (phone.Id == phoneId)
            {
                return phone;
            }
        }
        return null;
    }

    public bool UpdatePhone(Phone phone)
    {
        var updatingPhone = GetPhoneById(phone.Id);
        
        if (updatingPhone == null)
        {
            return false;
        }
        
        _phones[_phones.IndexOf(updatingPhone)] = phone;
        return true;
    }

    public bool DeletePhone(Guid phoneId)
    {
        var deletingPhone = GetPhoneById(phoneId);

        if (deletingPhone == null)
        {
            return false;
        }
        
        _phones.Remove(deletingPhone);
        return true;
    }
}