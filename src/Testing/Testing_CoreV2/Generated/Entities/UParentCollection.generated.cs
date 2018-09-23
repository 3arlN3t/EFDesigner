//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Testing
{
   public partial class UParentCollection : INotifyPropertyChanged
   {
      partial void Init();

      /// <summary>
      /// Default constructor. Protected due to required properties, but present because EF needs it.
      /// </summary>
      protected UParentCollection()
      {
         Init();
      }

      /// <summary>
      /// Public constructor with required data
      /// </summary>
      /// <param name="_uchildrequired"></param>
      public UParentCollection(Testing.UChild _uchildrequired)
      {
         if (_uchildrequired == null) throw new ArgumentNullException(nameof(_uchildrequired));
         UChildRequired = _uchildrequired;

         Init();
      }

      /// <summary>
      /// Static create function (for use in LINQ queries, etc.)
      /// </summary>
      /// <param name="_uchildrequired"></param>
      public static UParentCollection Create(Testing.UChild _uchildrequired)
      {
         return new UParentCollection(_uchildrequired);
      }

      // Persistent properties

      protected int _Id;
      partial void SetId(int oldValue, ref int newValue);
      partial void GetId(ref int result);

      /// <summary>
      /// Identity, Required, Indexed
      /// </summary>
      [Key]
      [Required]
      public int Id
      {
         get
         {
            int value = _Id;
            GetId(ref value);
            return (_Id = value);
         }
         set
         {
            int oldValue = _Id;
            SetId(oldValue, ref value);
            if (oldValue != value)
            {
               _Id = value;
               OnPropertyChanged();
            }
         }
      }

      // Persistent navigation properties

      protected Testing.UChild _UChildRequired;
      partial void SetUChildRequired(Testing.UChild oldValue, ref Testing.UChild newValue);
      partial void GetUChildRequired(ref Testing.UChild result);

      /// <summary>
      /// Required
      /// </summary>
      public Testing.UChild UChildRequired
      {
         get
         {
            Testing.UChild value = _UChildRequired;
            GetUChildRequired(ref value);
            return (_UChildRequired = value);
         }
         set
         {
            Testing.UChild oldValue = _UChildRequired;
            SetUChildRequired(oldValue, ref value);
            if (oldValue != value)
            {
               _UChildRequired = value;
               OnPropertyChanged();
            }
         }
      }

      protected Testing.UChild _UChildOptional;
      partial void SetUChildOptional(Testing.UChild oldValue, ref Testing.UChild newValue);
      partial void GetUChildOptional(ref Testing.UChild result);

      public Testing.UChild UChildOptional
      {
         get
         {
            Testing.UChild value = _UChildOptional;
            GetUChildOptional(ref value);
            return (_UChildOptional = value);
         }
         set
         {
            Testing.UChild oldValue = _UChildOptional;
            SetUChildOptional(oldValue, ref value);
            if (oldValue != value)
            {
               _UChildOptional = value;
               OnPropertyChanged();
            }
         }
      }

      public virtual event PropertyChangedEventHandler PropertyChanged;

      protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
      {
         PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
      }

   }
}

