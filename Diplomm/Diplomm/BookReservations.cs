//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Diplomm
{
    using System;
    using System.Collections.Generic;
    
    public partial class BookReservations
    {
        public int ReservationId { get; set; }
        public int BookId { get; set; }
        public int ReaderId { get; set; }
        public System.DateTime ReservationDate { get; set; }
        public System.DateTime ReturnDate { get; set; }
    
        public virtual Books Books { get; set; }
        public virtual Readers Readers { get; set; }
        public virtual Books Books1 { get; set; }
        public virtual Readers Readers1 { get; set; }
    }
}
