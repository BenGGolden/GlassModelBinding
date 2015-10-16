# Glass Model Binding

This project implements ASP.NET model binding for Sitecore and Glass Mapper. It allows you to decouple your Sitecore MVC controllers from Glass Mapper by eliminating the need to derive from GlassController.  Instead, you can pass your glass models to your action methods as parameters and they will be mapped and ready to go.

#### Setup
1. Create abstractions for both your item models and your rendering parameter models.  The project uses [IGlassItem](Source/GlassModelBinding/Models/IGlassItem.cs) and [IGlassRenderingParameters](Source/GlassModelBinding/Models/IGlassRenderingParameters.cs) as examples.  If you use the standard TDS code gen templates, you can use IGlassBase for the item models, but you will still need something for the parameter models.
2. Add the following files to your project:
  - [GlassItemModelBinder.cs](Source/GlassModelBinding/GlassItemModelBinder.cs)
  - [GlassParametersModelBinder.cs](Source/GlassModelBinding/GlassParametersModelBinder.cs)
  - [GlassModelBinderProvider.cs](Source/GlassModelBinding/GlassModelBinderProvider.cs)
  - [Pipelines/Loader/AddModelBinderProvider.cs](Source/GlassModelBinding/Pipelines/Loader/AddModelBinderProvider.cs)
  - [App_Config/Include/GlassModelBinding.config](Source/GlassModelBinding/App_Config/Include/GlassModelBinding.config)
3. Modify Pipelines/Loader/AddModelBinderProvider.cs to pass the appropriate types to GlassModelBinderProvider.
4. Pass your models to your action methods as parameters shown in [Controllers/ContentController.cs](Source/GlassModelBinding/Controllers/ContentController.cs)