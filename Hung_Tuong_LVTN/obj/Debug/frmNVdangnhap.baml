   M S B A M L   `   `   `  ����J  FHung_Tuong_LVTN, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Hung_Tuong_LVTNHung_Tuong_LVTN  5   	   #    Hung_Tuong_LVTN.frmNVdangnhap   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35a ]DevExpress.Xpf.Core.v17.1, Version=17.1.8.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;dx2http://schemas.devexpress.com/winfx/2008/xaml/core  5   	   j fDevExpress.Xpf.LayoutControl.v17.1, Version=17.1.8.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aFdxlc;http://schemas.devexpress.com/winfx/2008/xaml/layoutcontrol  5   	   ?dxe5http://schemas.devexpress.com/winfx/2008/xaml/editors  5   	   <dxb2http://schemas.devexpress.com/winfx/2008/xaml/bars  5	   	   f bDevExpress.Xpf.Grid.v17.1.Core, Version=17.1.8.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aa	 ]DevExpress.Xpf.Grid.v17.1, Version=17.1.8.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a>dxg2http://schemas.devexpress.com/winfx/2008/xaml/grid  	 5
   	   +localclr-namespace:Hung_Tuong_LVTN  	 5   	     � Title$  frmNVdangnhap��5   	   $	��730��6   $
��1000��6,    � WindowStartupLocation$ CenterScreen=�69    � Icon 6^   *  $DevExpress.Xpf.Core.DXImageExtension     Image1  +DevExpress.Xpf.Core.Native.DXImageConverter$ User_32x32.png .��5      � .+�5   
   .  (DevExpress.Xpf.LayoutControl.LayoutGroup     Orientation$ Vertical=�6   ��62   Z� .+�5           View$ GroupBox=�6      Header$ Personal Information :��6/    � UseLayoutRounding . ��6h   Z� .+�5        .+�5      &   DevExpress.Xpf.Editors.ImageEdit  -   5        $	��img��5   $   %  DevExpress.Xpf.Editors.BaseEdit   
IsReadOnly . $	��200��6A   $	��350��6N   5        5      $ Vertical=�6$   $ GroupBox=�6;   .+�5      -  'DevExpress.Xpf.LayoutControl.LayoutItem  	   
IsRequired	 . 
   Label$
 - Name           :��69      LabelPosition$
 Left=�6T   $
��Bold"�6j   $��14(�6|      Content. 5      �� -   5        $��lbname��5       $��Normal"�6.   6E   5        5      	 . $
 - Birth Date    :��68   $
 Left=�6R   $
��Bold"�6g   $��14(�6y   . 5      �� -   5        $��
lbngaysinh��5       $��Normal"�62   6H   5         5!      	 . $
 - Gender         :��68   $
 Left=�6S   $
��Bold"�6i   $��14(�6{   . 5"      �� -   5        $��
lbGioiTinh��5"       $��Normal"�62   6H   5$        5%      	 . $
 - Phone           :��68   $
 Left=�6T   $
��Bold"�6j   $��14(�6|   . 5&      �� -   5        $��lbsdt��5&       $��Normal"�6-   6C   5'        5(      	 . $
 - E-mail           :��68   $
 Left=�6U   $
��Bold"�6k   $��14(�6}   . 5)      �� -   5        $��lbemail��5)       $��Normal"�6/   6E   5*        5+      	 . $
 - Revenue       :��68   $
 Left=�6R   $
��Bold"�6h   $��14(�6z   . 5,      �� -   5        $��
lbdoanhthu��5,       $��Normal"�62   6H   5-      5/      50        52      $ List Customer :��6   $��0,2,0,0q�68   $ Vertical=�6I   $ GroupBox=�6`    . .+�53      (  "DevExpress.Xpf.Bars.ToolBarControl  ,  &DevExpress.Xpf.Bars.ToolBarControlBase   Caption$ toolthem��6%   $
��Left=�68      IsCollapsed .     RotateWhenVertical .     AllowQuickCustomization .    	AllowHide .     AllowCustomizationMenu .     BarItemDisplayMode$ ContentAndGlyph=�6�   $
��Bold"�6�   $��10(�6   J� OpacityMask
 �   �$��2q�6'  $��Right=�6;  $��20,0,0,0q�6W     Items. 54      '	  !DevExpress.Xpf.Bars.BarButtonItem	  -   5         	 Name$ bithem��54   (   !
  DevExpress.Xpf.Bars.BarItem 
  
LargeGlyph$b \pack://application:,,,/DevExpress.Images.v17.1;component/DevAV/Actions/NewEmployee_32x32.png��6b    
  Content)  #DevExpress.Xpf.Core.ObjectConverter$ Add Customer 6�    
  GlyphAlignment$
 Left=�6�    
  Glyph 68     $ Copy_16x16.png 6�   55      % 	 DevExpress.Xpf.Grid.GridControl  56      -	   5          Name$ gridControlkh��56   "   )  #DevExpress.Xpf.Grid.DataControlBase   SelectionMode$	 Row=�69      ItemsSource 6O   �� *khnc+   Columns. 57      $ 	 DevExpress.Xpf.Grid.GridColumn  $  DevExpress.Xpf.Grid.ColumnBase   	FieldName$ hoten��6%   $  DevExpress.Xpf.Grid.BaseColumn    Header$
  Name 67     58      $ gioitinh��6%   $  Gender 6:     59      $ loaikh��6%   $  Customer Type 68     5:      $	 sdt��6%   $  Phone 65     5;      $ diachi��6%   $  Address 68     5<      $ email��6%   $  E-mail 67   !   View! 5=      # 	 DevExpress.Xpf.Grid.TableView  5>      "   	AutoWidth" . &   DevExpress.Xpf.Grid.DataViewBase#   AllowEditing# .  & 	  DevExpress.Xpf.Grid.GridViewBase$   AllowGrouping$ .  %   AllowColumnMoving% .  &   NavigationStyle$	& Row=�6~   '   AllowFixedGroups]
 YDevExpress.Data.v17.1, Version=17.1.8.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a5 
 /DevExpress.Utils.Design.DefaultBooleanConverter$' False 6�   (   ShowGroupPanel( .  6�   5A      5B        5C      $ GroupBox=�6   $��Right=�6/   .+�5D        	 . $
 Chọn nhân viên:��64   $	 Top=�6L   $	��300��6`   $��0q�6l   $��Right=�6w   . 5E      �� -
   5        $	��cbx��5E      ) �� DisplayMemberPath$) tennv��6*   * �� SelectedValuePath$
* nvid��6D   6_   5F        5G      $ listnvtb��6%   $
��Left=�68    .   .   .  .   .  $ ContentAndGlyph=�6�   $
��Bold"�6�   $��10(�6  
 �   �$��2q�6'  $��Right=�6;  $��20,0,0,0q�6W  . 5H      	  -   5        $
 bicn��5H   (   $ Send Customer 6�   $
 Left=�6�    66     $ Copy_16x16.png  6`     $ Right_32x32.png 6�   5I      5J      5K      5L      5M      