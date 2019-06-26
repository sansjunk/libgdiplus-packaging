﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace System {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class SR {
        public static string Format(string value, params object[] args)
        {
            return string.Format(value, args);
        }

        public static string InvalidArgumentValue { get { return "InvalidArgumentValue"; } }
        public static string IconInvalidMaskLength { get { return "IconInvalidMaskLength"; } }

        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SR() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("CoreCompat.System.Drawing.SR", typeof(SR).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid Blend object. The positions array must have 0.0 as its first element..
        /// </summary>
        internal static string BlendObjectFirstElementInvalid {
            get {
                return ResourceManager.GetString("BlendObjectFirstElementInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid Blend object. The positions array must have 1.0 as its last element..
        /// </summary>
        internal static string BlendObjectLastElementInvalid {
            get {
                return ResourceManager.GetString("BlendObjectLastElementInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid Blend object. It should have at least 2 elements in each of the factors and positions arrays..
        /// </summary>
        internal static string BlendObjectMustHaveTwoElements {
            get {
                return ResourceManager.GetString("BlendObjectMustHaveTwoElements", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Changes cannot be made to {0} because permissions are not valid..
        /// </summary>
        internal static string CantChangeImmutableObjects {
            get {
                return ResourceManager.GetString("CantChangeImmutableObjects", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Bitmaps that are icons cannot be made transparent. Icons natively support transparency. Use the Icon constructor to create an icon..
        /// </summary>
        internal static string CantMakeIconTransparent {
            get {
                return ResourceManager.GetString("CantMakeIconTransparent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (printer name protected due to security restrictions).
        /// </summary>
        internal static string CantTellPrinterName {
            get {
                return ResourceManager.GetString("CantTellPrinterName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The color {0} is not a system color..
        /// </summary>
        internal static string ColorNotSystemColor {
            get {
                return ResourceManager.GetString("ColorNotSystemColor", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} is not a valid value for {1}..
        /// </summary>
        internal static string ConvertInvalidPrimitive {
            get {
                return ResourceManager.GetString("ConvertInvalidPrimitive", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to GetObjectType on this dc returned an invalid value..
        /// </summary>
        internal static string DCTypeInvalid {
            get {
                return ResourceManager.GetString("DCTypeInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to load DLL &apos;{0}&apos;: The specified module could not be found..
        /// </summary>
        internal static string DllNotFoundExceptionMessage {
            get {
                return ResourceManager.GetString("DllNotFoundExceptionMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to .NET Component.
        /// </summary>
        internal static string DotNET_ComponentType {
            get {
                return ResourceManager.GetString("DotNET_ComponentType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to find an entry point named &apos;{0}&apos; in DLL &apos;{1}&apos;..
        /// </summary>
        internal static string EntryPointNotFoundExceptionMessage {
            get {
                return ResourceManager.GetString("EntryPointNotFoundExceptionMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Function was ended..
        /// </summary>
        internal static string GdiplusAborted {
            get {
                return ResourceManager.GetString("GdiplusAborted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to File access is denied..
        /// </summary>
        internal static string GdiplusAccessDenied {
            get {
                return ResourceManager.GetString("GdiplusAccessDenied", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A Graphics object cannot be created from an image that has an indexed pixel format..
        /// </summary>
        internal static string GdiplusCannotCreateGraphicsFromIndexedPixelFormat {
            get {
                return ResourceManager.GetString("GdiplusCannotCreateGraphicsFromIndexedPixelFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SetPixel is not supported for images with indexed pixel formats..
        /// </summary>
        internal static string GdiplusCannotSetPixelFromIndexedPixelFormat {
            get {
                return ResourceManager.GetString("GdiplusCannotSetPixelFromIndexedPixelFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Destination points must be an array with a length of 3 or 4. A length of 3 defines a parallelogram with the upper-left, upper-right, and lower-left corners. A length of 4 defines a quadrilateral with the fourth element of the array specifying the lower-right coordinate..
        /// </summary>
        internal static string GdiplusDestPointsInvalidLength {
            get {
                return ResourceManager.GetString("GdiplusDestPointsInvalidLength", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Destination points define a parallelogram which must have a length of 3. These points will represent the upper-left, upper-right, and lower-left coordinates (defined in that order)..
        /// </summary>
        internal static string GdiplusDestPointsInvalidParallelogram {
            get {
                return ResourceManager.GetString("GdiplusDestPointsInvalidParallelogram", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to File not found..
        /// </summary>
        internal static string GdiplusFileNotFound {
            get {
                return ResourceManager.GetString("GdiplusFileNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Font &apos;{0}&apos; cannot be found..
        /// </summary>
        internal static string GdiplusFontFamilyNotFound {
            get {
                return ResourceManager.GetString("GdiplusFontFamilyNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Font &apos;{0}&apos; does not support style &apos;{1}&apos;..
        /// </summary>
        internal static string GdiplusFontStyleNotFound {
            get {
                return ResourceManager.GetString("GdiplusFontStyleNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A generic error occurred in GDI+..
        /// </summary>
        internal static string GdiplusGenericError {
            get {
                return ResourceManager.GetString("GdiplusGenericError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Buffer is too small (internal GDI+ error)..
        /// </summary>
        internal static string GdiplusInsufficientBuffer {
            get {
                return ResourceManager.GetString("GdiplusInsufficientBuffer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Parameter is not valid..
        /// </summary>
        internal static string GdiplusInvalidParameter {
            get {
                return ResourceManager.GetString("GdiplusInvalidParameter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Rectangle &apos;{0}&apos; cannot have a width or height equal to 0..
        /// </summary>
        internal static string GdiplusInvalidRectangle {
            get {
                return ResourceManager.GetString("GdiplusInvalidRectangle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Operation requires a transformation of the image from GDI+ to GDI. GDI does not support images with a width or height greater than 32767..
        /// </summary>
        internal static string GdiplusInvalidSize {
            get {
                return ResourceManager.GetString("GdiplusInvalidSize", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Not implemented..
        /// </summary>
        internal static string GdiplusNotImplemented {
            get {
                return ResourceManager.GetString("GdiplusNotImplemented", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to GDI+ is not properly initialized (internal GDI+ error)..
        /// </summary>
        internal static string GdiplusNotInitialized {
            get {
                return ResourceManager.GetString("GdiplusNotInitialized", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Only TrueType fonts are supported. &apos;{0}&apos; is not a TrueType font..
        /// </summary>
        internal static string GdiplusNotTrueTypeFont {
            get {
                return ResourceManager.GetString("GdiplusNotTrueTypeFont", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Only TrueType fonts are supported. This is not a TrueType font..
        /// </summary>
        internal static string GdiplusNotTrueTypeFont_NoName {
            get {
                return ResourceManager.GetString("GdiplusNotTrueTypeFont_NoName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Object is currently in use elsewhere..
        /// </summary>
        internal static string GdiplusObjectBusy {
            get {
                return ResourceManager.GetString("GdiplusObjectBusy", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Out of memory..
        /// </summary>
        internal static string GdiplusOutOfMemory {
            get {
                return ResourceManager.GetString("GdiplusOutOfMemory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Overflow error..
        /// </summary>
        internal static string GdiplusOverflow {
            get {
                return ResourceManager.GetString("GdiplusOverflow", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Property cannot be found..
        /// </summary>
        internal static string GdiplusPropertyNotFoundError {
            get {
                return ResourceManager.GetString("GdiplusPropertyNotFoundError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Property is not supported..
        /// </summary>
        internal static string GdiplusPropertyNotSupportedError {
            get {
                return ResourceManager.GetString("GdiplusPropertyNotSupportedError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unknown GDI+ error occurred..
        /// </summary>
        internal static string GdiplusUnknown {
            get {
                return ResourceManager.GetString("GdiplusUnknown", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Image format is unknown..
        /// </summary>
        internal static string GdiplusUnknownImageFormat {
            get {
                return ResourceManager.GetString("GdiplusUnknownImageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Current version of GDI+ does not support this feature..
        /// </summary>
        internal static string GdiplusUnsupportedGdiplusVersion {
            get {
                return ResourceManager.GetString("GdiplusUnsupportedGdiplusVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Bitmap region is already locked..
        /// </summary>
        internal static string GdiplusWrongState {
            get {
                return ResourceManager.GetString("GdiplusWrongState", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to  (Global Assembly Cache).
        /// </summary>
        internal static string GlobalAssemblyCache {
            get {
                return ResourceManager.GetString("GlobalAssemblyCache", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to BufferedGraphicsContext cannot be disposed of because a buffer operation is currently in progress..
        /// </summary>
        internal static string GraphicsBufferCurrentlyBusy {
            get {
                return ResourceManager.GetString("GraphicsBufferCurrentlyBusy", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Screen-compatible bitmap cannot be created. The screen bitmap format cannot be determined..
        /// </summary>
        internal static string GraphicsBufferQueryFail {
            get {
                return ResourceManager.GetString("GraphicsBufferQueryFail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Internal state of the {0} class is invalid..
        /// </summary>
        internal static string IllegalState {
            get {
                return ResourceManager.GetString("IllegalState", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Property must be set to a valid ColorBlend object to use interpolation colors..
        /// </summary>
        internal static string InterpolationColorsColorBlendNotSet {
            get {
                return ResourceManager.GetString("InterpolationColorsColorBlendNotSet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}{1} ColorBlend objects must be constructed with the same number of positions and color values. Positions must be between 0.0 and 1.0, 1.0 indicating the last element in the array..
        /// </summary>
        internal static string InterpolationColorsCommon {
            get {
                return ResourceManager.GetString("InterpolationColorsCommon", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ColorBlend object that was set is not valid..
        /// </summary>
        internal static string InterpolationColorsInvalidColorBlendObject {
            get {
                return ResourceManager.GetString("InterpolationColorsInvalidColorBlendObject", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Position&apos;s last element must be equal to 1.0..
        /// </summary>
        internal static string InterpolationColorsInvalidEndPosition {
            get {
                return ResourceManager.GetString("InterpolationColorsInvalidEndPosition", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Position&apos;s first element must be equal to 0..
        /// </summary>
        internal static string InterpolationColorsInvalidStartPosition {
            get {
                return ResourceManager.GetString("InterpolationColorsInvalidStartPosition", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Array of colors and positions must contain at least two elements..
        /// </summary>
        internal static string InterpolationColorsLength {
            get {
                return ResourceManager.GetString("InterpolationColorsLength", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Colors and positions do not have the same number of elements..
        /// </summary>
        internal static string InterpolationColorsLengthsDiffer {
            get {
                return ResourceManager.GetString("InterpolationColorsLengthsDiffer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Value of &apos;{1}&apos; is not valid for &apos;{0}&apos;..
        /// </summary>
        internal static string InvalidArgument {
            get {
                return ResourceManager.GetString("InvalidArgument", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Value of &apos;{1}&apos; is not valid for &apos;{0}&apos;. &apos;{0}&apos; should be greater than {2} and less than or equal to {3}..
        /// </summary>
        internal static string InvalidBoundArgument {
            get {
                return ResourceManager.GetString("InvalidBoundArgument", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Class name is not valid..
        /// </summary>
        internal static string InvalidClassName {
            get {
                return ResourceManager.GetString("InvalidClassName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Color &apos;{0}&apos; is not valid..
        /// </summary>
        internal static string InvalidColor {
            get {
                return ResourceManager.GetString("InvalidColor", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DashPattern value is not valid..
        /// </summary>
        internal static string InvalidDashPattern {
            get {
                return ResourceManager.GetString("InvalidDashPattern", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value of argument &apos;{0}&apos; ({1}) is invalid for Enum type &apos;{2}&apos;..
        /// </summary>
        internal static string InvalidEnumArgument {
            get {
                return ResourceManager.GetString("InvalidEnumArgument", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Value of &apos;{1}&apos; is not valid for &apos;{0}&apos;. &apos;{0}&apos; should be greater than or equal to {2} and less than or equal to {3}..
        /// </summary>
        internal static string InvalidEx2BoundArgument {
            get {
                return ResourceManager.GetString("InvalidEx2BoundArgument", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Frame is not valid. Frame must be between 0 and FrameCount..
        /// </summary>
        internal static string InvalidFrame {
            get {
                return ResourceManager.GetString("InvalidFrame", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Win32 handle that was passed to {0} is not valid or is the wrong type..
        /// </summary>
        internal static string InvalidGDIHandle {
            get {
                return ResourceManager.GetString("InvalidGDIHandle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Image type is unknown..
        /// </summary>
        internal static string InvalidImage {
            get {
                return ResourceManager.GetString("InvalidImage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Value of &apos;{1}&apos; is not valid for &apos;{0}&apos;. &apos;{0}&apos; must be greater than or equal to {2}..
        /// </summary>
        internal static string InvalidLowBoundArgumentEx {
            get {
                return ResourceManager.GetString("InvalidLowBoundArgumentEx", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Permission level is not valid..
        /// </summary>
        internal static string InvalidPermissionLevel {
            get {
                return ResourceManager.GetString("InvalidPermissionLevel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Permission state is not valid..
        /// </summary>
        internal static string InvalidPermissionState {
            get {
                return ResourceManager.GetString("InvalidPermissionState", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Argument &apos;{0}&apos; must be a picture that can be used as a {1}..
        /// </summary>
        internal static string InvalidPictureType {
            get {
                return ResourceManager.GetString("InvalidPictureType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Settings to access printer &apos;{0}&apos; are not valid..
        /// </summary>
        internal static string InvalidPrinterException_InvalidPrinter {
            get {
                return ResourceManager.GetString("InvalidPrinterException_InvalidPrinter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No printers are installed..
        /// </summary>
        internal static string InvalidPrinterException_NoDefaultPrinter {
            get {
                return ResourceManager.GetString("InvalidPrinterException_NoDefaultPrinter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Handle {0} is not valid..
        /// </summary>
        internal static string InvalidPrinterHandle {
            get {
                return ResourceManager.GetString("InvalidPrinterHandle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Native handle is 0..
        /// </summary>
        internal static string NativeHandle0 {
            get {
                return ResourceManager.GetString("NativeHandle0", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Default printer is not set..
        /// </summary>
        internal static string NoDefaultPrinter {
            get {
                return ResourceManager.GetString("NoDefaultPrinter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Not implemented..
        /// </summary>
        internal static string NotImplemented {
            get {
                return ResourceManager.GetString("NotImplemented", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Occurs when the document is about to be printed..
        /// </summary>
        internal static string PDOCbeginPrintDescr {
            get {
                return ResourceManager.GetString("PDOCbeginPrintDescr", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The name of the document shown to the user..
        /// </summary>
        internal static string PDOCdocumentNameDescr {
            get {
                return ResourceManager.GetString("PDOCdocumentNameDescr", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The page settings of the page currently being printed..
        /// </summary>
        internal static string PDOCdocumentPageSettingsDescr {
            get {
                return ResourceManager.GetString("PDOCdocumentPageSettingsDescr", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Occurs after the document has been printed..
        /// </summary>
        internal static string PDOCendPrintDescr {
            get {
                return ResourceManager.GetString("PDOCendPrintDescr", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Indicates that the graphics origin is located at the user-specified page margins..
        /// </summary>
        internal static string PDOCoriginAtMarginsDescr {
            get {
                return ResourceManager.GetString("PDOCoriginAtMarginsDescr", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Retrieves the print controller for this document..
        /// </summary>
        internal static string PDOCprintControllerDescr {
            get {
                return ResourceManager.GetString("PDOCprintControllerDescr", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Retrieves the settings for the printer the document is currently being printed to..
        /// </summary>
        internal static string PDOCprinterSettingsDescr {
            get {
                return ResourceManager.GetString("PDOCprinterSettingsDescr", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Occurs once for each page to be printed..
        /// </summary>
        internal static string PDOCprintPageDescr {
            get {
                return ResourceManager.GetString("PDOCprintPageDescr", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Occurs before each page is printed.  Useful for changing PageSettings for a particular page..
        /// </summary>
        internal static string PDOCqueryPageSettingsDescr {
            get {
                return ResourceManager.GetString("PDOCqueryPageSettingsDescr", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to System.Drawing is not supported on this platform..
        /// </summary>
        internal static string PlatformNotSupported_Drawing {
            get {
                return ResourceManager.GetString("PlatformNotSupported_Drawing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Defines an object that sends output to a printer..
        /// </summary>
        internal static string PrintDocumentDesc {
            get {
                return ResourceManager.GetString("PrintDocumentDesc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Permission level must be between PrintingPermissionLevel.NoPrinting and PrintingPermissionLevel.AllPrinting..
        /// </summary>
        internal static string PrintingPermissionAttributeInvalidPermissionLevel {
            get {
                return ResourceManager.GetString("PrintingPermissionAttributeInvalidPermissionLevel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to XML is not valid..
        /// </summary>
        internal static string PrintingPermissionBadXml {
            get {
                return ResourceManager.GetString("PrintingPermissionBadXml", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to IDictionary parameter contains at least one entry that is not valid. Ensure all values are consistent with the object&apos;s properties..
        /// </summary>
        internal static string PropertyValueInvalidEntry {
            get {
                return ResourceManager.GetString("PropertyValueInvalidEntry", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to PaperSize cannot be changed unless the Kind property is set to Custom..
        /// </summary>
        internal static string PSizeNotCustom {
            get {
                return ResourceManager.GetString("PSizeNotCustom", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Resource &apos;{1}&apos; cannot be found in class &apos;{0}&apos;..
        /// </summary>
        internal static string ResourceNotFound {
            get {
                return ResourceManager.GetString("ResourceNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Target does not have permission to print..
        /// </summary>
        internal static string TargetNotPrintingPermission {
            get {
                return ResourceManager.GetString("TargetNotPrintingPermission", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Text &quot;{0}&quot; cannot be parsed. The expected text format is &quot;{1}&quot;..
        /// </summary>
        internal static string TextParseFailedFormat {
            get {
                return ResourceManager.GetString("TextParseFailedFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Argument should be a non-empty string..
        /// </summary>
        internal static string ToolboxItemInvalidKey {
            get {
                return ResourceManager.GetString("ToolboxItemInvalidKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Property {0} requires an argument of type {1}..
        /// </summary>
        internal static string ToolboxItemInvalidPropertyType {
            get {
                return ResourceManager.GetString("ToolboxItemInvalidPropertyType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Toolbox item cannot be modified..
        /// </summary>
        internal static string ToolboxItemLocked {
            get {
                return ResourceManager.GetString("ToolboxItemLocked", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Data type {0} is not serializable. Items added to a property dictionary must be serializable..
        /// </summary>
        internal static string ToolboxItemValueNotSerializable {
            get {
                return ResourceManager.GetString("ToolboxItemValueNotSerializable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (Icon).
        /// </summary>
        internal static string toStringIcon {
            get {
                return ResourceManager.GetString("toStringIcon", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (none).
        /// </summary>
        internal static string toStringNone {
            get {
                return ResourceManager.GetString("toStringNone", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to TriState.Default cannot be converted into a Boolean..
        /// </summary>
        internal static string TriStateCompareError {
            get {
                return ResourceManager.GetString("TriStateCompareError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Parameter must be positive and &lt; Width..
        /// </summary>
        internal static string ValidRangeX {
            get {
                return ResourceManager.GetString("ValidRangeX", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Parameter must be positive and &lt; Height..
        /// </summary>
        internal static string ValidRangeY {
            get {
                return ResourceManager.GetString("ValidRangeY", resourceCulture);
            }
        }
    }
}