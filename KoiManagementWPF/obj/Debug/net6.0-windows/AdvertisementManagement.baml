   M S B A M L   `   `   `  ����K  GKoiManagementWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:KoiManagementWPFKoiManagementWPF  5   	   .    (KoiManagementWPF.AdvertisementManagement   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:KoiManagementWPF     5   	     � Title$  AdvertisementManagement��5   	   $	��450��6)   $	��800��66   .��5	      � -   5         �Name$ AdvertisementGrid��5	      .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ AdsGrid��5
      $
��Left=�6$   $	��194��6?   $��149,230,0,0q�6L   $	��Top=�6a   $	��641��6y   6�   �� 5   
   -   5         ��Name$ 	btnAppove��5      $��Approve��6$   $
��Left=�66   $��40��6Q   $��
21,230,0,0q�6]   $	��Top=�6q   $��99��6�   $
��Bold"�6�   ���	#FF65F4586�   �� 5   
   -   5        $
��Deny��5      $
��Left=�6    $��40��6;   $��
21,281,0,0q�6G   $	��Top=�6[   $��99��6s   $
��Bold"�6�   ���	#FFED6B6B6�   �� 5   
   -   5        $
��Back��5      $
��Left=�6    $��40��6;   $��
21,384,0,0q�6G   $	��Top=�6[   $��99��6s   $
��Bold"�6�   �� 5   
   $"��Koi advertisement management��6   $��Center=�67   $	��Top=�6T   $	��376��6l   $
��Bold"�6x   $��24(�6�   �� 5   
   $��Title��6   $
��Left=�6    $��25��6;   $��
151,78,0,0q�6G   $	��Top=�6[   $��59��6s   $
��Bold"�6~   �� 5   
   $��Description��6   $
��Left=�6&   $��25��6A   $��129,114,0,0q�6M   $	��Top=�6b   $��74��6z   $
��Bold"�6�   �� 5   
   -   5         ��Name$ txtTitle��5      $
��Left=�6$   $��
212,82,0,0q�6?    �� TextWrapping$
 Wrap=�6S   $	��Top=�6g   $	��174��6   �� 5   
   -   5        $ txtDescription��5      $
��Left=�6*   $��212,118,0,0q�6E   $
 Wrap=�6Z   $	��Top=�6n   $	��174��6�   �� 5   
   $��Koi fish name��6   $
��Left=�6(   $��25��6C   $��115,147,0,0q�6O   $	��Top=�6d   $��88��6|   $
��Bold"�6�   �� 5   
   $��	Posted by��6   $
��Left=�6$   $��25��6?   $��133,183,0,0q�6K   $	��Top=�6`   $��74��6x   $
��Bold"�6�   �� 5   
   -   5        $ txtKoiFishId��5      $
��Left=�6(   $��212,151,0,0q�6C   $
 Wrap=�6X   $	��Top=�6l   $	��174��6�   �� 5   
   -	   5        $ txtPostedBy��5      $
��Left=�6'   $��212,187,0,0q�6B   $
 Wrap=�6W   $	��Top=�6k   $	��174��6�   �� 5   
   $��
Created at��6   $
��Left=�6%   $��25��6@   $��
450,78,0,0q�6L   $	��Top=�6`   $��77��6x   $
��Bold"�6�   �� 5   
   -
   5        $ txtCreatedAt��5      $
��Left=�6(   $��
541,82,0,0q�6C   $
 Wrap=�6W   $	��Top=�6k   $	��174��6�   �� 5   
   $��
Updated at��6   $
��Left=�6%   $��25��6@   $��445,114,0,0q�6L   $	��Top=�6a   $��77��6y   $
��Bold"�6�   �� 5   
   -   5        $ txtUpdatedAt��5      $
��Left=�6(   $��541,118,0,0q�6C   $
 Wrap=�6X   $	��Top=�6l   $	��174��6�   �� 5   
   $��Verified��6   $
��Left=�6#   $��25��6>   $��467,147,0,0q�6J   $	��Top=�6_   $��55��6w   $
��Bold"�6�   �� 5   
   -   5         ��Name$ chkVerified��5      $�� ��6(   $
��Left=�63   $��541,152,0,0q�6N   $	��Top=�6c   6{   5      5      