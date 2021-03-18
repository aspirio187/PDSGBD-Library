﻿using AutoMapper;
using Bibliotheque.EntityFramework.Services.Repositories;
using Bibliotheque.UI.Helpers;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheque.UI.ViewModels
{
    public class HomeViewModel : BindableBase, INavigationAware
    {
        private readonly ILibraryRepository m_Repository;
        private readonly IMapper m_Mapper;

        private IRegionNavigationService m_Navigation;

        /***************************************************/
        /********* Commandes s'appliquant à la vue *********/
        /***************************************************/

        public DelegateCommand LoginCommand { get; set; }
        public DelegateCommand NavigateToRegisterCommand { get; set; }

        /***************************************************/
        /******** Propriétés récupérées dans la vue ********/
        /***************************************************/
        

        public HomeViewModel(ILibraryRepository repository, IMapper mapper)
        {
            m_Repository = repository ??
                throw new ArgumentNullException(nameof(repository));
            m_Mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));
        }

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            throw new NotImplementedException();
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
            throw new NotImplementedException();
        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            if (m_Navigation == null) m_Navigation = navigationContext.Parameters.GetValue<IRegionNavigationService>(GlobalInfos.NavigationServiceName);
        }
    }
}