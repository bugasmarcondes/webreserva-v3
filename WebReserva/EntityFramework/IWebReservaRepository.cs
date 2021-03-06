﻿using System.Collections.Generic;
using WebReserva.Models;
using WebReserva.ViewModels;

namespace WebReserva.EntityFramework
{
    public interface IWebReservaRepository
    {
        bool Save();
        WrHotel GetTenantBasedOnUrl(string hostUrl);
        List<WrBloqueioData> GetSectionSlider(int wrHotelId);
        bool AddEmail(WrMailing newEmail);
        SectionAboutViewModel GetSectionAbout(int wrHotelId);
        bool SendEmail(SectionContactViewModel newEmail);
        List<SectionPackageViewModel> GetSectionPackage(int wrHotelId);
        WrTipoApartamento GetWrTipoApartamento(int wrHotelId);
        List<SectionRoomViewModel> GetAvailability(SectionAvailabilityViewModel sectionAvailability);
        int UpdateReservation(PostReservationViewModel existingReservation);
        int SaveReservationSearch(PostReservationSearchViewModel reservationSearch);
        List<SectionPackageViewModel> AlertIfPackageFound(SectionAvailabilityViewModel sectionAvailability);
        void SaveWrPesquisa(WrPesquisa wrPesquisa);
    }
}