using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPSC_481_Trailexplorers
{
    public class MWVM : INotifyPropertyChanged
    {
        /*private int _boundNumber;
        public int BoundNumber
        {
            get { return _boundNumber; }
            set
            {
                if(_boundNumber != null)
                {
                    _boundNumber = value;
                    NotifyPropertyChanged();
                }
            }
        }*/

        public MWVM()
        {
            ProvinceCollection = new ObservableCollection<Province>();
            ParksCollection = new ObservableCollection<Park>();
            DifficultyCollection = new ObservableCollection<Difficulty>();
            SliderCollection = new ObservableCollection<Slidercontrol1>();
            SliderCollection2 = new ObservableCollection<SliderControl2>();
            SliderCollection3 = new ObservableCollection<SliderControl3>();
            LoadData();
        }
        public ObservableCollection<SliderControl3> _SliderCollection3;

        public ObservableCollection<SliderControl3> SliderCollection3
        {
            get { return _SliderCollection3; }
            set
            {
                _SliderCollection3 = value;
                NotifyPropertyChanged("SliderCollection3");
            }
        }


        public ObservableCollection<SliderControl2> _SliderCollection2;

        public ObservableCollection<SliderControl2> SliderCollection2
        {
            get { return _SliderCollection2; }
            set
            {
                _SliderCollection2 = value;
                NotifyPropertyChanged("SliderCollection2");
            }
        }

        public ObservableCollection<Slidercontrol1> _SliderCollection;

        public ObservableCollection<Slidercontrol1> SliderCollection
        {
            get { return _SliderCollection; }
            set
            {
                _SliderCollection = value;
                NotifyPropertyChanged("SliderCollection");
            }
        }


        public ObservableCollection<Difficulty> _DifficultyCollection;

        public ObservableCollection<Difficulty> DifficultyCollection
        {
            get { return _DifficultyCollection; }
            set
            {
                _DifficultyCollection = value;
                NotifyPropertyChanged("DifficultyCollection");
            }
        }





        public ObservableCollection<Province> _ProvinceCollection;

        public ObservableCollection<Province> ProvinceCollection
        {
            get { return _ProvinceCollection; }
            set
            {
                _ProvinceCollection = value;
                NotifyPropertyChanged("ProvinceCollection");
            }
        }

        public ObservableCollection<Park> _ParksCollection;

        public ObservableCollection<Park> ParksCollection
        {
            get { return _ParksCollection; }
            set
            {
                _ParksCollection = value;
                NotifyPropertyChanged("ParksCollection");
            }
        }

        public Province _SelectedProvince;

        public Province SelectedProvince
        {
            get { return _SelectedProvince; }
            set
            {
                _SelectedProvince = value;
                if (_SelectedProvince != null && _SelectedProvince.Parks != null && _SelectedProvince.DifficultyCollection !=null && _SelectedProvince.SliderCollection != null)
                {
                    ParksCollection = new ObservableCollection<Park>(_SelectedProvince.Parks);
                }
                NotifyPropertyChanged("SelectedProvince");
            }
        }
        public void LoadData()
        { 
            if (ProvinceCollection != null)
            {
                ProvinceCollection.Add(new Province
                {
                    ProvinceId = 1,
                    ProvinceName = "ALBERTA",
                    Parks = new List<Park>  
                        {
                                    new Park { ParkId = 1, ParkName = "Banff National Park", diff= 3},
                                    new Park { ParkId = 2, ParkName = "Jasper National Park", diff=6},
                                    new Park { ParkId = 3, ParkName = "Waterton Lakes National Park", diff=10}
                        },
                    
                    SliderCollection = new List<Slidercontrol1>
                    {
                                    new Slidercontrol1 { SliderId1 = 1, SliderName1 = 1},
                                    new Slidercontrol1 { SliderId1 = 2, SliderName1 = 2},
                                    new Slidercontrol1 { SliderId1 = 3, SliderName1 = 3}
                    }





                });
                ProvinceCollection.Add(new Province
                {
                    ProvinceId = 2,
                    ProvinceName = "BRITISH COLUMBIA",
                    Parks = new List<Park>
                            {
                                    new Park { ParkId = 4, ParkName = "Glacier National Park"},
                                    new Park { ParkId = 5, ParkName = "Kootenay National Park"},
                                    new Park { ParkId = 6, ParkName = "Yoho National Park"}
                            }
                });
                ProvinceCollection.Add(new Province
                {
                    ProvinceId = 3,
                    ProvinceName = "MANITOBA",
                    Parks = new List<Park>
                            {
                                    new Park { ParkId = 7, ParkName = "Nopiming"},
                                    new Park { ParkId = 77, ParkName = "Riding Mountain"},
                                    new Park { ParkId = 546, ParkName = "Wapusk National Park"}
                            }
                });

                ProvinceCollection.Add(new Province
                {
                    ProvinceId = 4,
                    ProvinceName = "NEW BRUNSWICK",
                    Parks = new List<Park>
                            {
                                    new Park { ParkId = 7324, ParkName = "Fundy"},
                                    new Park { ParkId = 77234234, ParkName = "Mount Carleton"},
                                    new Park { ParkId = 542342346, ParkName = "Parlee Beach"}
                            }
                });

                ProvinceCollection.Add(new Province
                {
                    ProvinceId = 5,
                    ProvinceName = "NEWFOUNDLAND and LABRADOR",
                    Parks = new List<Park>
                            {
                                    new Park { ParkId = 7324324, ParkName = "Gros Morne"},
                                    new Park { ParkId = 231, ParkName = "Terra Nova"},
                                    new Park { ParkId = 23123, ParkName = "Western Brook"}
                            }
                });

                ProvinceCollection.Add(new Province
                {
                    ProvinceId = 6,
                    ProvinceName = "NOVA SCOTIA",
                    Parks = new List<Park>
                            {
                                    new Park { ParkId = 4535, ParkName = "Cape Breton"},
                                    new Park { ParkId = 4543543, ParkName = "Kejimkujik"},
                                    new Park { ParkId = 234234, ParkName = "Sable Island"}
                            }
                });

                ProvinceCollection.Add(new Province
                {
                    ProvinceId = 7,
                    ProvinceName = "ONTARIO",
                    Parks = new List<Park>
                            {
                                    new Park { ParkId = 756856, ParkName = "Bruce Peninsula"},
                                    new Park { ParkId = 456, ParkName = "Point Pelee"},
                                    new Park { ParkId = 56, ParkName = "Sandbanks"}
                            }
                });



                ProvinceCollection.Add(new Province
                {
                    ProvinceId = 8,
                    ProvinceName = "PRINCE EDWARD ISLAND",
                    Parks = new List<Park>
                            {
                                    new Park { ParkId = 345435, ParkName = "Cabot Beach"},
                                    new Park { ParkId = 345435, ParkName = "Northumberland"},
                                    new Park { ParkId = 7868, ParkName = "Union Corner"}
                            }
                });

                ProvinceCollection.Add(new Province
                {
                    ProvinceId = 9,
                    ProvinceName = "QUEBEC",
                    Parks = new List<Park>
                            {
                                    new Park { ParkId = 435345, ParkName = "Hautes-Gorges"},
                                    new Park { ParkId = 4534543, ParkName = "Jacques Cartier"},
                                    new Park { ParkId = 435, ParkName = "Gaspesie"}
                            }
                });

                ProvinceCollection.Add(new Province
                {
                    ProvinceId = 10,
                    ProvinceName = "SASCATCHEWAN",
                    Parks = new List<Park>
                            {
                                    new Park { ParkId = 345, ParkName = "Grasslands"},
                                    new Park { ParkId = 34543543, ParkName = "Meadow Lake"},
                                    new Park { ParkId = 34534, ParkName = "Prince Albert"}
                            }
                });

                ProvinceCollection.Add(new Province
                {
                    ProvinceId = 11,
                    ProvinceName = "NORTHWEST TERRITORIES",
                    Parks = new List<Park>
                            {
                                    new Park { ParkId = 456456, ParkName = "Nahanni"},
                                    new Park { ParkId = 56, ParkName = "Grand Teton"},
                                    new Park { ParkId = 456456765, ParkName = "Olympic"}
                            }
                });

                ProvinceCollection.Add(new Province
                {
                    ProvinceId = 12,
                    ProvinceName = "NUNAVUT",
                    Parks = new List<Park>
                            {
                                    new Park { ParkId = 123213, ParkName = "Auyuittuq"},
                                    new Park { ParkId = 324324, ParkName = "Quttinirpaaq"},
                                    new Park { ParkId = 3434, ParkName = "Ukkusiksalik "}
                            }
                });

                ProvinceCollection.Add(new Province
                {
                    ProvinceId = 13,
                    ProvinceName = "YUKON",
                    Parks = new List<Park>
                            {
                                    new Park { ParkId = 1234214, ParkName = "Ivvavik "},
                                    new Park { ParkId = 34343, ParkName = "Kluane"},
                                    new Park { ParkId = 34342, ParkName = "Vuntut"}
                            }
                });
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        
        public void NotifyPropertyChanged(String info)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(info));
        }

    }
}


