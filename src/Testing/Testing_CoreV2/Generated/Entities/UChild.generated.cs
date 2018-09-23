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
   public partial class UChild : INotifyPropertyChanged
   {
      partial void Init();

      /// <summary>
      /// Default constructor. Protected due to required properties, but present because EF needs it.
      /// </summary>
      protected UChild()
      {
         Init();
      }

      /// <summary>
      /// Public constructor with required data
      /// </summary>
      /// <param name="_uparentrequired0"></param>
      /// <param name="_uparentrequired1"></param>
      /// <param name="_uparentrequired2"></param>
      public UChild(Testing.UParentRequired _uparentrequired0, Testing.UParentRequired _uparentrequired1, Testing.UParentRequired _uparentrequired2)
      {
         if (_uparentrequired0 == null) throw new ArgumentNullException(nameof(_uparentrequired0));
         _uparentrequired0.UChildRequired = this;

         if (_uparentrequired1 == null) throw new ArgumentNullException(nameof(_uparentrequired1));
         _uparentrequired1.UChildCollection.Add(this);

         if (_uparentrequired2 == null) throw new ArgumentNullException(nameof(_uparentrequired2));
         _uparentrequired2.UChildOptional = this;

         Init();
      }

      /// <summary>
      /// Static create function (for use in LINQ queries, etc.)
      /// </summary>
      /// <param name="_uparentrequired0"></param>
      /// <param name="_uparentrequired1"></param>
      /// <param name="_uparentrequired2"></param>
      public static UChild Create(Testing.UParentRequired _uparentrequired0, Testing.UParentRequired _uparentrequired1, Testing.UParentRequired _uparentrequired2)
      {
         return new UChild(_uparentrequired0, _uparentrequired1, _uparentrequired2);
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

      public virtual event PropertyChangedEventHandler PropertyChanged;

      protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
      {
         PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
      }

   }
}

