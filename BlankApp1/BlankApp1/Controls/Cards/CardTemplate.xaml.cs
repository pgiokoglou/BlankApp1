namespace Blank1.Controls.Cards
{
   using System.Collections.ObjectModel;
   using System.ComponentModel;

   using Blank1.Models;

   using CardView;
   

   using Xamarin.Forms;
   using Xamarin.Forms.Xaml;


   [ XamlCompilation( xamlCompilationOptions: XamlCompilationOptions.Compile ) ]
   public partial class CardTemplate
      : CardView
   {
   #region Public
      public static readonly BindableProperty ImageProperty = BindableProperty.Create( propertyName: nameof( CardTemplate.Image ),
                                                                                       returnType: typeof( ImageSource ),
                                                                                       declaringType: typeof( CardTemplate ),
                                                                                       defaultValue: null,
                                                                                       defaultBindingMode: BindingMode.TwoWay,
                                                                                       propertyChanged: CardTemplate.OnSourceChanged );

      public static readonly BindableProperty TitleProperty = BindableProperty.Create( propertyName: nameof( CardTemplate.Title ),
                                                                                       returnType: typeof( string ),
                                                                                       declaringType: typeof( CardTemplate ),
                                                                                       propertyChanged: CardTemplate.OnTitleChanged );

      public static readonly BindableProperty DescriptionsProperty = BindableProperty.Create( propertyName: nameof( CardTemplate.Descriptions ),
                                                                                              returnType: typeof( ObservableCollection< CardDescription > ),
                                                                                              declaringType: typeof( CardTemplate ),
                                                                                              defaultBindingMode: BindingMode.TwoWay,
                                                                                              propertyChanged: CardTemplate.OnDescriptionItemsChanged );

      public CardTemplate()
      {
         InitializeComponent();

         Descriptions = new ObservableCollection< CardDescription >();
      }

      public ImageSource Image
      {
         get => GetValue( property: ImageProperty ) as ImageSource;
         set
         {
            SetValue( property: ImageProperty, value: value );

            OnPropertyChanged( propertyName: nameof( CardTemplate.Image ) );
         }
      }

      public ObservableCollection< CardDescription > Descriptions
      {
         get => GetValue( property: DescriptionsProperty ) as ObservableCollection< CardDescription >;
         set
         {
            SetValue( property: DescriptionsProperty, value: value );

            OnPropertyChanged( propertyName: nameof( CardTemplate.Descriptions ) );
         }
      }

      public string Title
      {
         get => GetValue( property: TitleProperty ) as string;
         set
         {
            SetValue( property: TitleProperty, value: value );

            OnPropertyChanged( propertyName: nameof( CardTemplate.Title ) );
         }
      }
   #endregion


   #region Private
      private static void OnDescriptionItemsChanged( BindableObject bindable, object old_value, object new_value )
      {
         if( new_value == null )
         {
            return;
         }

         if( bindable is not CardTemplate cardTemplate )
         {
            return;
         }

         cardTemplate.Descriptions = new_value as ObservableCollection< CardDescription >;
      }

      private static void OnSourceChanged( BindableObject bindable, object old_value, object new_value )
      {
         if( new_value == null )
         {
            return;
         }

         if( bindable is not CardTemplate cardTemplate )
         {
            return;
         }

         cardTemplate.Image = new_value as ImageSource;
      }

      private static void OnTitleChanged( BindableObject bindable, object old_value, object new_value )
      {
         if( new_value == null )
         {
            return;
         }

         if( bindable is not CardTemplate cardTemplate )
         {
            return;
         }

         cardTemplate.Title = new_value as string;
      }
   #endregion
   }
}
