﻿using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace GenderSampleApp.Models;

/// <summary>
/// Container for people read from a data source such as a
/// database table. INotifyPropertyChanged is not needed here
/// , although it's good practice to use.
/// </summary>
public class Person : INotifyPropertyChanged
{
    private string _firstName;
    private string _lastName;
    private GenderType _gender;
    public int Id { get; set; }

    public string FirstName
    {
        get => _firstName;
        set
        {
            _firstName = value;
            OnPropertyChanged();
        }
    }

    public string LastName
    {
        get => _lastName;
        set
        {
            _lastName = value;
            OnPropertyChanged();
        }
    }

    public string FullName => $"{FirstName} {LastName}";

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public GenderType Gender
    {
        get => _gender;
        set
        {
            _gender = value;
            OnPropertyChanged();
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;
    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}