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
        public MWVM()
        {
            ProvinceCollection = new ObservableCollection<Province>();
            ParksCollection = new ObservableCollection<Park>();
            DifficultyCollection = new ObservableCollection<Difficulty>();
            LoadData();
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
                if (_SelectedProvince != null && _SelectedProvince.Parks != null && _SelectedProvince.DifficultyCollection !=null)
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
                                    new Park { ParkId = 1, ParkName = "asd"},
                                    new Park { ParkId = 2, ParkName = "asdasd"},
                                    new Park { ParkId = 3, ParkName = "asdasd"}
                            }
                });
                ProvinceCollection.Add(new Province
                {
                    ProvinceId = 2,
                    ProvinceName = "BRITISH COLUMBIA",
                    Parks = new List<Park>
                            {
                                    new Park { ParkId = 4, ParkName = "G"},
                                    new Park { ParkId = 5, ParkName = "P"},
                                    new Park { ParkId = 6, ParkName = "M"}
                            }
                });
                ProvinceCollection.Add(new Province
                {
                    ProvinceId = 3,
                    ProvinceName = "MANITOBA",
                    Parks = new List<Park>
                            {
                                    new Park { ParkId = 7, ParkName = "at"},
                                    new Park { ParkId = 77, ParkName = "jab"},
                                    new Park { ParkId = 546, ParkName = "Ma"}
                            }
                });

                ProvinceCollection.Add(new Province
                {
                    ProvinceId = 4,
                    ProvinceName = "NEW BRUNSWICK",
                    Parks = new List<Park>
                            {
                                    new Park { ParkId = 7324, ParkName = "atfdsgs"},
                                    new Park { ParkId = 77234234, ParkName = "dfgdfjab"},
                                    new Park { ParkId = 542342346, ParkName = "Mdfgdfga"}
                            }
                });

                ProvinceCollection.Add(new Province
                {
                    ProvinceId = 5,
                    ProvinceName = "NEWFOUNDLAND and LABRADOR",
                    Parks = new List<Park>
                            {
                                    new Park { ParkId = 7324324, ParkName = "gfdfg"},
                                    new Park { ParkId = 231, ParkName = "fdgf"},
                                    new Park { ParkId = 23123, ParkName = "fdg"}
                            }
                });

                ProvinceCollection.Add(new Province
                {
                    ProvinceId = 6,
                    ProvinceName = "NOVA SCOTIA",
                    Parks = new List<Park>
                            {
                                    new Park { ParkId = 4535, ParkName = "fg"},
                                    new Park { ParkId = 4543543, ParkName = "jhkhj"},
                                    new Park { ParkId = 234234, ParkName = "jhkjkkjhk"}
                            }
                });

                ProvinceCollection.Add(new Province
                {
                    ProvinceId = 7,
                    ProvinceName = "ONTARIO",
                    Parks = new List<Park>
                            {
                                    new Park { ParkId = 756856, ParkName = "fghfgh"},
                                    new Park { ParkId = 456, ParkName = "ghjgf"},
                                    new Park { ParkId = 56, ParkName = "hj"}
                            }
                });

                ProvinceCollection.Add(new Province
                {
                    ProvinceId = 8,
                    ProvinceName = "ONTARIO",
                    Parks = new List<Park>
                            {
                                    new Park { ParkId = 5647, ParkName = "gfh"},
                                    new Park { ParkId = 67, ParkName = "gfh"},
                                    new Park { ParkId = 21312, ParkName = "hghj"}
                            }
                });

                ProvinceCollection.Add(new Province
                {
                    ProvinceId = 8,
                    ProvinceName = "PRINCE EDWARD ISLAND",
                    Parks = new List<Park>
                            {
                                    new Park { ParkId = 345435, ParkName = "dfgdfgdf"},
                                    new Park { ParkId = 345435, ParkName = "gdfghfdghffh"},
                                    new Park { ParkId = 7868, ParkName = "hghfghfghj"}
                            }
                });

                ProvinceCollection.Add(new Province
                {
                    ProvinceId = 9,
                    ProvinceName = "QUEBEC",
                    Parks = new List<Park>
                            {
                                    new Park { ParkId = 435345, ParkName = "sdf"},
                                    new Park { ParkId = 4534543, ParkName = "dsf"},
                                    new Park { ParkId = 435, ParkName = "dsfsd"}
                            }
                });

                ProvinceCollection.Add(new Province
                {
                    ProvinceId = 10,
                    ProvinceName = "SASCATCHEWAN",
                    Parks = new List<Park>
                            {
                                    new Park { ParkId = 345, ParkName = "sdf"},
                                    new Park { ParkId = 34543543, ParkName = "dsf"},
                                    new Park { ParkId = 34534, ParkName = "dsfsd"}
                            }
                });

                ProvinceCollection.Add(new Province
                {
                    ProvinceId = 11,
                    ProvinceName = "NORTHWEST TERRITORIES",
                    Parks = new List<Park>
                            {
                                    new Park { ParkId = 456456, ParkName = "sdfsdf"},
                                    new Park { ParkId = 56, ParkName = "sdfsdfsdf"},
                                    new Park { ParkId = 456456765, ParkName = "s"}
                            }
                });

                ProvinceCollection.Add(new Province
                {
                    ProvinceId = 12,
                    ProvinceName = "NUNAVUT",
                    Parks = new List<Park>
                            {
                                    new Park { ParkId = 123213, ParkName = "sdfgsdghgdgfh"},
                                    new Park { ParkId = 324324, ParkName = "sdfsdf"},
                                    new Park { ParkId = 3434, ParkName = "dsdfgsdf"}
                            }
                });

                ProvinceCollection.Add(new Province
                {
                    ProvinceId = 13,
                    ProvinceName = "YUKON",
                    Parks = new List<Park>
                            {
                                    new Park { ParkId = 1234214, ParkName = "sfg"},
                                    new Park { ParkId = 34343, ParkName = "dfgdfg"},
                                    new Park { ParkId = 34342, ParkName = "jkhjkhjk"}
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


