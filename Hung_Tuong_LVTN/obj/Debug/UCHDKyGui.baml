   M S B A M L   `   `   `  ����J  FHung_Tuong_LVTN, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Hung_Tuong_LVTNHung_Tuong_LVTN  5      ?$clr-namespace:Hung_Tuong_LVTN.ModelsHung_Tuong_LVTN.Models  5          Hung_Tuong_LVTN.UCHDKyGui   5      a ]DevExpress.Xpf.Core.v17.1, Version=17.1.8.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a<dxb2http://schemas.devexpress.com/winfx/2008/xaml/bars  j fDevExpress.Xpf.LayoutControl.v17.1, Version=17.1.8.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aFdxlc;http://schemas.devexpress.com/winfx/2008/xaml/layoutcontrol  6N   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:Hung_Tuong_LVTN     5      ;dx2http://schemas.devexpress.com/winfx/2008/xaml/core  5      f bDevExpress.Xpf.Grid.v17.1.Core, Version=17.1.8.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aa	 ]DevExpress.Xpf.Grid.v17.1, Version=17.1.8.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a>dxg2http://schemas.devexpress.com/winfx/2008/xaml/grid  	 5      3Models$clr-namespace:Hung_Tuong_LVTN.Models  	 5      ?dxe5http://schemas.devexpress.com/winfx/2008/xaml/editors  69   &   DevExpress.Xpf.Bars.BarNameScope    IsScopeOwner  .  � DataContext 5      *  $Hung_Tuong_LVTN.Models.HDKGModelView  5   
   .��5      0  *DevExpress.Xpf.LayoutControl.LayoutControl  .  (DevExpress.Xpf.LayoutControl.LayoutGroup   Orientation$ Vertical=�6   $	��Top=�60   .+�5   
   �� $(��"Danh Sách Hợp Đồng Ký Gửi��6   $
��Bold"�65   $��14(�6G   $	��Top=�6U   (  "DevExpress.Xpf.Bars.ToolBarControl  5   
   ,  &DevExpress.Xpf.Bars.ToolBarControlBase   Caption$ listnvtb��6   $
��Left=�60      IsCollapsed .     RotateWhenVertical .     AllowQuickCustomization .    	AllowHide .     AllowCustomizationMenu .  	   BarItemDisplayMode$	 ContentAndGlyph=�6�   $
��Bold"�6�   $��10(�6�   
 J� OpacityMask

 �   �$��2q�6  $��Right=�63     Items. 5      '  !DevExpress.Xpf.Bars.BarButtonItem  -   5          Name$
 bicn��5       !  DevExpress.Xpf.Bars.BarItem   Content)	  #DevExpress.Xpf.Core.ObjectConverter$    Cập Nhật   	 6.      GlyphAlignment$
 Left=�6�      Glyph 6G   *
  $DevExpress.Xpf.Core.DXImageExtension
   
  Image1  +DevExpress.Xpf.Core.Native.DXImageConverter$ Cut_16x16.png    
LargeGlyph 6p   
  $ Refresh_32x32.png 6�     5      -   5        $ biThem��5       $
 Left=�61   $ Thêm Hợp Đồng	 6G    6|   
  $ Insert_32x32.png  6�   
  $ Insert_16x16.png   5      -   5        $ bixoa��5          CommandParameter$
 Xóa��6�   $      Xóa     	 6�   $
 Left=�6�    6/   
  $ Copy_16x16.png  6Y   
  $ Trash_32x32.png 6�   5      % 	 DevExpress.Xpf.Grid.GridControl  5   
   -   5        $
��grid��5   9   )  #DevExpress.Xpf.Grid.DataControlBase   ItemsSource 6   �� *DSHDKG+   View 5      # 	 DevExpress.Xpf.Grid.TableView  5      -   5           AllowPerPixelScrolling . &   DevExpress.Xpf.Grid.DataViewBase   ShowTotalSummary .    AllowEditing .    NavigationStyle$	 Row=�5!          AllowColumnMoving .    AllowResizing .    	AutoWidth . & 	  DevExpress.Xpf.Grid.GridViewBase   ShowGroupedColumns .    EditFormShowMode$ Inline=�5"   :      ShowEditFormOnF2Key .      ShowEditFormOnDoubleClick .  6�    5$        5%          Columns.  5'      $ 	 DevExpress.Xpf.Grid.GridColumn  $  DevExpress.Xpf.Grid.ColumnBase!   AllowEditing]
 YDevExpress.Data.v17.1, Version=17.1.8.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a5 
 /DevExpress.Utils.Design.DefaultBooleanConverter$! False 6   "   	FieldName$
" kgid��62   $  DevExpress.Xpf.Grid.BaseColumn'#    HorizontalHeaderContentAlignment$# Center=�6C   $   Header$$ KG ID	 6m   %   ReadOnly% . &   Fixed$
& Left=�6�   '   EditFormVisible$' FalseX�6�     5(      $" bdsid��6   $# Center=�6/   $$ BĐS ID	 6Y   (   EditSettings( 5)      :  4DevExpress.Xpf.Editors.Settings.ComboBoxEditSettings  5*      <  6DevExpress.Xpf.Editors.Settings.LookUpEditSettingsBase)   DisplayMember$) bdsid��6/   *   ValueMember$* bdsid��6c   +   ItemsSource+ 6E   �� *DSBDS+6c   5,        5-      $
" nvid��6   $# Center=�6.   $$ Người Lập	 6X   ( 5.        5/      $) tennv��6/   $
* nvid��6b   + 6E   �� *DSNV+6b   51        52      $
" khid��6   $# Center=�6.   $$ Khách Hàng	 6X   ( 53        54      $) hoten��6S   $
* khid��6i   + 6/   �� *DSKhachHang+6i   56        57      $" giatri��6   $# Center=�60   $$ Giá Trị BĐS	 6Z   $! False 6o   % . $' FalseX�6�     58      $" chiphidv��6   $# Center=�62   $$ Chi Phí DV	 6\     59      $" 
ngaybatdau��6   $# Center=�64   $$ Ngày Bắt Đầu	 6^     5:      $" ngayketthuc��6   $$ Ngày Kết Thúc	 65   5;      5=      5>      