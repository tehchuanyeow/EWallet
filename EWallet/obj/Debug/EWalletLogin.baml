   M S B A M L   `   `   `  ����B  >EWallet, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:EWalletEWallet  5          EWallet.EWalletLogin   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:EWallet     5        N� 
Background
  ����� N� Title$ EWallet Login ��5	      .��5      �  � RowDefinitions 5   
   �� 5      $
��215* �6   �� 5      $	��77* �6   �� 5      $	��77* �6   �� 5      $	��77* �6   .+�5   
   �� $��1q�6   $��0��6%    �� CornerRadius$ 30,30,30,30��5      
���   �
�������$��110,179,182,16q�6\   $��4��6t   �� 5   
   -   5         ��Name$
 Logo��5      $��0��6"   $	��Top=�5      $
��Left=�6,   $��60(�5      $��Trebuchet MS)�6"   $��	ExtraBold"�6=   $��	25,16,0,0q�5      $��73��6'   $	��247��63   
E-Wallet6I   �� 5   
   $��Right=�6   $��Resource\Logo.jpg��6,   $��
0,20,20,68q�6G   $	��154��6[   �� 5   
   -   5        $ username��5   !   $��1��6   $��20(�64   $��Center=�5      $��	200,0,0,0q�6.   $��45��6A   
Username6X   �� 5   
   -   5         ��Name$ usernameTextBox��5      $��1��6   $
��Bold"�5      $��Center=�6$   $	��200��6?   $��45��5       
���   �6   �� 5"   
   -   5        $ password��5"   !   $��2��6   $��20(�63   $��Center=�5#      $��200,0q�6/   $��45��6>   
Password6U   �� 5$   
   -   5        $ passwordTextBox��5$      $��2��6   $
��Bold"�69   $��Center=�6K   $	��200��6f   $��45��5%      
���   �6   �� 5(   
   -   5         ��Name$ LoginButton��5(      $��3��6   $��Log in��63   $��1q�6E   $��20(�6Y   $
��Bold"�6g   $��445,0,257,32q�6y   5)      5*      5+      