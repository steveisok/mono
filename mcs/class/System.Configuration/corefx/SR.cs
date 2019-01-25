//
// This file was generated by resx2sr tool
//

internal partial class SR
{
	public const string Parameter_Invalid = "The parameter '{0}' is invalid.";
	public const string Parameter_NullOrEmpty = "The string parameter '{0}' cannot be null or empty.";
	public const string Property_NullOrEmpty = "The value assigned to property '{0}' cannot be null or empty.";
	public const string Property_Invalid = "The value assigned to property '{0}' is invalid.";
	public const string Unexpected_Error = "An unexpected error occurred in '{0}'.";
	public const string Wrapped_exception_message = "{0}: {1}";
	public const string Config_error_loading_XML_file = "An error occurred loading a configuration file";
	public const string Config_exception_creating_section_handler = "An error occurred creating the configuration section handler for {0}";
	public const string Config_exception_creating_section = "An error occurred creating the configuration section for {0}";
	public const string Config_tag_name_invalid = "Invalid format for a section or section group name";
	public const string Argument_AddingDuplicate = "An entry with the same key already exists.";
	public const string Config_add_configurationsection_already_added = "Cannot add a ConfigurationSection that already belongs to the Configuration.";
	public const string Config_add_configurationsection_already_exists = "Cannot add a ConfigurationSection with the same name that already exists.";
	public const string Config_add_configurationsection_in_location_config = "Cannot add a ConfigurationSection to a Configuration with a location.";
	public const string Config_add_configurationsectiongroup_already_added = "Cannot add a ConfigurationSectionGroup that already belongs to the Configuration.";
	public const string Config_add_configurationsectiongroup_already_exists = "Cannot add a ConfigurationSectionGroup with the same name that already exists.";
	public const string Config_add_configurationsectiongroup_in_location_config = "Cannot add a ConfigurationSectionGroup to a Configuration with a location.";
	public const string Config_allow_exedefinition_error_application = "It is an error to use a section registered as allowExeDefinition='MachineToApplication' beyond the application, in the user's config.  (This is the default behavior if not specified)";
	public const string Config_allow_exedefinition_error_machine = "It is an error to use a section registered as allowExeDefinition='MachineOnly' beyond machine.config.";
	public const string Config_allow_exedefinition_error_roaminguser = "It is an error to use a section registered as allowExeDefinition='MachineToRoamingUser' beyond the roaming user config, in the local user config.";
	public const string Config_appsettings_declaration_invalid = "The configuration section 'appSettings' has an unexpected declaration.";
	public const string Config_base_attribute_locked = "The attribute '{0}' has been locked in a higher level configuration.";
	public const string Config_base_collection_item_locked_cannot_clear = "A collection item has been locked in a higher level configuration. The collection may not be cleared.";
	public const string Config_base_collection_item_locked = "The collection item has been locked in a higher level configuration and may not be changed.";
	public const string Config_base_cannot_add_items_above_inherited_items = "This collection does not permit items to be added in or above the inherited items.";
	public const string Config_base_cannot_add_items_below_inherited_items = "This collection does not permit items to be added in or below the inherited items.";
	public const string Config_base_cannot_remove_inherited_items = "Inherited items may not be removed.";
	public const string Config_base_collection_elements_may_not_be_removed = "Elements of this collection may not be removed.";
	public const string Config_base_collection_entry_already_exists = "The entry '{0}' has already been added.";
	public const string Config_base_collection_entry_already_removed = "Entry already removed.";
	public const string Config_base_collection_entry_not_found = "The entry '{0}' is not in the collection.";
	public const string Config_base_element_cannot_have_multiple_child_elements = "The element <{0}> may only appear once in this section.";
	public const string Config_base_element_locked = "The element '{0}' has been locked in a higher level configuration.";
	public const string Config_base_expected_to_find_element = "Expected to find an element.";
	public const string Config_base_invalid_attribute_to_lock = "The attribute '{0}' is not valid in the locked list for this section. The following attributes can be locked: {1}. Multiple attributes may be listed separated by commas.";
	public const string Config_base_invalid_attribute_to_lock_by_add = "The attribute '{0}' is not valid in the locked list for this section. The following attributes can be locked: {1}.";
	public const string Config_base_invalid_element_key = "Invalid key value.";
	public const string Config_base_invalid_element_to_lock = "The element '{0}' is not valid in the locked list for this section. The following elements can be locked: {1}. Multiple elements may be listed separated by commas.";
	public const string Config_base_invalid_element_to_lock_by_add = "The element '{0}' is not valid in the locked list for this section. The following elements can be locked: {1}.";
	public const string Config_base_property_is_not_a_configuration_element = "Property '{0}' is not a ConfigurationElement.";
	public const string Config_base_read_only = "The configuration is read only.";
	public const string Config_base_required_attribute_locked = "The attribute '{0}' is required and is locked at a higher level configuration. The configuration with the lock should lock the entire element if it needs to lock required attributes.";
	public const string Config_base_required_attribute_lock_attempt = "The attribute '{0}' is required and cannot be locked. The configuration should lock the entire element if it needs to lock required attributes.";
	public const string Config_base_required_attribute_missing = "Required attribute '{0}' not found.";
	public const string Config_base_section_invalid_content = "The configuration section cannot contain a CDATA or text element.";
	public const string Config_base_unrecognized_attribute = "Unrecognized attribute '{0}'. Note that attribute names are case-sensitive.";
	public const string Config_base_unrecognized_element = "Unrecognized element.";
	public const string Config_base_unrecognized_element_name = "Unrecognized element '{0}'.";
	public const string Config_base_value_cannot_contain = "The value may not contain the '{0}' character.";
	public const string Config_cannot_edit_configurationsection_in_location_config = "ConfigurationSection properties for a <section> declaration cannot be edited in a Configuration with a location.";
	public const string Config_cannot_edit_configurationsection_parentsection = "ConfigurationSection properties can not be edited for the parent section of another section (ie. a section retrieved by calling GetParentSection on a section)";
	public const string Config_cannot_edit_configurationsection_when_location_locked = "ConfigurationSection properties for a location section cannot be edited when allowLocation=false.";
	public const string Config_cannot_edit_configurationsection_when_locked = "ConfigurationSection properties cannot be edited when locked.";
	public const string Config_cannot_edit_configurationsection_when_not_attached = "ConfigurationSection cannot be edited before being added to a section group belonging to an instance of class Configuration.";
	public const string Config_cannot_edit_configurationsection_when_it_is_implicit = "ConfigurationSection cannot be edited because it is a built-in section.";
	public const string Config_cannot_edit_configurationsection_when_it_is_undeclared = "ConfigurationSection cannot be edited because it is not declared.";
	public const string Config_cannot_edit_configurationsectiongroup_in_location_config = "ConfigurationSectionGroup properties for a <sectionGroup> declaration cannot be edited in a Configuration with a location.";
	public const string Config_cannot_edit_configurationsectiongroup_when_not_attached = "ConfigurationSectionGroup cannot be edited before being added to a section group belonging to an instance of class Configuration.";
	public const string Config_cannot_edit_locationattriubtes = "AllowOverride and InheritInChildApplications can not be set in the exe configuration, these settings have no meaning there.";
	public const string Config_cannot_open_config_source = "Unable to open configSource file '{0}'.";
	public const string Config_client_config_init_error = "Configuration system failed to initialize";
	public const string Config_client_config_too_many_configsections_elements = "Only one <configSections> element allowed per config file and if present must be the first child of the root <configuration> element.";
	public const string Config_configmanager_open_noexe = "exePath must be specified when not running inside a stand alone exe.";
	public const string Config_configsection_parentnotvalid = "This is not valid for the parent section of another section (ie. a section retrieved by calling GetParentSection on a section)";
	public const string Config_connectionstrings_declaration_invalid = "The configuration section 'connectionStrings' has an unexpected declaration.";
	public const string Config_data_read_count_mismatch = "Data read count is not equal to data available.";
	public const string Config_element_no_context = "This element is not currently associated with any context";
	public const string Config_empty_lock_attributes_except = "The '{0}' attribute cannot be an empty string. {1}=\"*\" may be used to lock all attributes.";
	public const string Config_empty_lock_element_except = "The '{0}' attribute cannot be an empty string. {1}=\"*\" may be used to lock all elements.";
	public const string Config_exception_in_config_section_handler = "An error occurred executing the configuration section handler for {0}.";
	public const string Config_file_doesnt_have_root_configuration = "Configuration file {0} does not have root <configuration> tag";
	public const string Config_file_has_changed = "The configuration file has been changed by another program.";
	public const string Config_getparentconfigurationsection_first_instance = "GetParentSection can only be applied to ConfigurationSections from the first instance of a Configuration.";
	public const string Config_inconsistent_location_attributes = "Error in configuration section \"{0}\": AllowLocation is false and either AllowOverride or InheritInChildApplications is true.";
	public const string Config_invalid_attributes_for_write = "Unable to open file '{0}' for writing because it is read-only or hidden.";
	public const string Config_invalid_boolean_attribute = "The property '{0}' must have value 'true' or 'false'.";
	public const string Config_invalid_node_type = "Invalid node type.";
	public const string Config_location_location_not_allowed = "<location> sections are allowed only within <configuration> sections.";
	public const string Config_location_path_invalid_character = "<location> path attribute must be a relative virtual path.  It cannot contain any of '?' ':' '\\\\' '*' '\"' '<' '>' or '|'.";
	public const string Config_location_path_invalid_first_character = "<location> path attribute must be a relative virtual path.  It cannot start with any of ' ' '.' '/' or '\\\\'.";
	public const string Config_location_path_invalid_last_character = "<location> path attribute must be a relative virtual path.  It cannot end with any of ' ' '.' '/' or '\\\\'.";
	public const string Config_missing_required_attribute = "The '{0}' attribute must be specified on the '{1}' tag.";
	public const string Config_more_data_than_expected = "More data than expected.";
	public const string Config_name_value_file_section_file_invalid_root = "The root element must match the name of the section referencing the file, '{0}'";
	public const string Config_namespace_invalid = "Namespace of '{0}' on configuration element is invalid, only '{1}' is valid.";
	public const string Config_no_stream_to_write = "A configuration file cannot be created for the requested Configuration object.";
	public const string Config_not_allowed_to_encrypt_this_section = "This configuration section cannot be encrypted.";
	public const string Config_object_is_null = "Configuration section handler returned a null object.";
	public const string Config_operation_not_runtime = "This operation does not apply at runtime.";
	public const string Config_properties_may_not_be_derived_from_configuration_section = "The Configuration property '{0}' may not be derived from ConfigurationSection.";
	public const string Config_provider_must_implement_type = "Provider must implement the class '{0}'.";
	public const string Config_root_section_group_cannot_be_edited = "The RootSectionGroup cannot be edited";
	public const string Config_section_allow_definition_attribute_invalid = "The 'allowDefinition' attribute must be one of the following values: Everywhere, MachineOnly, MachineToWebRoot, MachineToApplication.";
	public const string Config_section_allow_exe_definition_attribute_invalid = "The 'allowExeDefinition' attribute must be one of the following values: MachineOnly, MachineToApplication, MachineToRoamingUser, MachineToLocalUser.";
	public const string Config_section_cannot_be_used_in_location = "This section is not allowed in <location> elements.  This section has been marked allowLocation=\"false\".";
	public const string Config_section_locked = "This configuration section cannot be used at this path.  This happens when the site administrator has locked access to this section using <location allowOverride=\"false\"> from an inherited configuration file.";
	public const string Config_sections_must_be_unique = "Sections must only appear once per config file.  See the help topic <location> for exceptions.";
	public const string Config_source_cannot_be_shared = "The configSource file '{0}' can only be used by one type of section, and may not be the same as the configuration file.";
	public const string Config_source_parent_conflict = "The configSource file '{0}' is also used in a parent, this is not allowed.";
	public const string Config_source_file_format = "The format of a configSource file must be an element containing the name of the section.";
	public const string Config_source_invalid_format = "The configSource attribute must be a relative physical path.";
	public const string Config_source_invalid_chars = "The configSource attribute must be a relative physical path, so the '/' character is not allowed.";
	public const string Config_source_requires_file = "The 'configSource' property may not be set in a configuration that has no associated file.";
	public const string Config_source_syntax_error = "A section using 'configSource' may contain no other attributes or elements.";
	public const string Config_system_already_set = "The configuration system has already been initialized.";
	public const string Config_tag_name_already_defined = "Section or group name '{0}' is already defined. Updates to this may only occur at the configuration level where it is defined.";
	public const string Config_tag_name_already_defined_at_this_level = "Section or group name '{0}' is already defined. This can not be defined multiple times.";
	public const string Config_tag_name_cannot_be_location = "The section name 'location' is reserved for <location> sections.";
	public const string Config_tag_name_cannot_begin_with_config = "Section names beginning with config are reserved.";
	public const string Config_type_doesnt_inherit_from_type = "Type '{0}' does not inherit from '{1}'.";
	public const string Config_unexpected_element_end = "Unexpected end of element {0}.";
	public const string Config_unexpected_element_name = "Unexpected element name {0}.";
	public const string Config_unexpected_node_type = "expected XmlNodeType.Element, type is {0}.";
	public const string Config_unrecognized_configuration_section = "Unrecognized configuration section {0}.";
	public const string Config_write_failed = "Unable to save config to file '{0}'.";
	public const string Converter_timespan_not_in_second = "The expected format is an integer value in seconds.";
	public const string Converter_unsupported_value_type = "The converter cannot convert values with type '{0}'.";
	public const string Decryption_failed = "Failed to decrypt using provider '{0}'. Error message from the provider: {1}";
	public const string Default_value_conversion_error_from_string = "The default value of the property '{0}' cannot be parsed. The error is: {1}";
	public const string Default_value_wrong_type = "The default value for the property '{0}' has different type than the one of the property itself.";
	public const string DPAPI_bad_data = "The data specified for decryption is bad.";
	public const string Empty_attribute = "The '{0}' attribute cannot be an empty string.";
	public const string EncryptedNode_not_found = "The section is marked as being protected. However, the <EncryptedData> child node was not found in the section's node. Make sure that the section is correctly encrypted.";
	public const string EncryptedNode_is_in_invalid_format = "The section is marked as being protected, but it does not have the correct format. It should contain only the <EncryptedData> child node.";
	public const string Encryption_failed = "Failed to encrypt the section '{0}' using provider '{1}'. Error message from the provider: {2}";
	public const string IndexOutOfRange = "Index {0} is out of range.";
	public const string Invalid_enum_value = "The enumeration value must be one of the following: {0}.";
	public const string Must_add_to_config_before_protecting_it = "The configuration section must be added to a configuration hierarchy before you can protect it.";
	public const string No_converter = "Unable to find a converter that supports conversion to/from string for the property '{0}' of type '{1}'.";
	public const string No_exception_information_available = "No information about the exception is available.";
	public const string Property_name_reserved = "A configuration property cannot have the name '{0}' because it starts with the reserved prefix 'config' or 'lock'.";
	public const string Item_name_reserved = "A configuration item alias for '{0}' cannot have the name '{1}' because it starts with the reserved prefix 'config' or 'lock'.";
	public const string Basicmap_item_name_reserved = "A configuration item cannot have the name '{0}' because it starts with the reserved prefix 'config' or 'lock'.";
	public const string ProtectedConfigurationProvider_not_found = "The protection provider '{0}' was not found.";
	public const string Regex_validator_error = "The value does not conform to the validation regex string '{0}'.";
	public const string String_null_or_empty = "The string cannot be null or empty.";
	public const string Subclass_validator_error = "The type '{0}' must be derived from the type '{1}'.";
	public const string Top_level_conversion_error_from_string = "The value of the property '{0}' cannot be parsed. The error is: {1}";
	public const string Top_level_conversion_error_to_string = "The value of the property '{0}' cannot be converted to string. The error is: {1}";
	public const string Top_level_validation_error = "The value for the property '{0}' is not valid. The error is: {1}";
	public const string Type_cannot_be_resolved = "The type '{0}' cannot be resolved. Please verify the spelling is correct or that the full type name is provided.";
	public const string TypeNotPublic = "Unable to load type '{0}' because it is not public.";
	public const string Unrecognized_initialization_value = "The configuration setting '{0}' was not recognized.";
	public const string Validation_scalar_range_violation_not_different = "The value must be different than {0}.";
	public const string Validation_scalar_range_violation_not_equal = "The value must be equal to {0}.";
	public const string Validation_scalar_range_violation_not_in_range = "The value must be inside the range {0}-{1}.";
	public const string Validation_scalar_range_violation_not_outside_range = "The value must not be in the range {0}-{1}.";
	public const string Validator_Attribute_param_not_validator = "Only types derived from {0} are valid validator types.";
	public const string Validator_does_not_support_elem_type = "The supplied validator does not support validating the configuration element type {0}.";
	public const string Validator_does_not_support_prop_type = "The supplied validator does not support the type of the property '{0}'.";
	public const string Validator_element_not_valid = "The configuration element '{0}' is not valid. The error is: {1}";
	public const string Validator_method_not_found = "The supplied method name '{0}' was not found. The callback method must be a public static void method with one object parameter.";
	public const string Validator_min_greater_than_max = "The upper range limit value must be greater than the lower range limit value.";
	public const string Validator_scalar_resolution_violation = "The value must have a resolution of {0}.";
	public const string Validator_string_invalid_chars = "The string cannot contain any of the following characters: '{0}'.";
	public const string Validator_string_max_length = "The string must be no more than {0} characters long.";
	public const string Validator_string_min_length = "The string must be at least {0} characters long.";
	public const string Validator_value_type_invalid = "The supplied value is not of type which the validator can process.";
	public const string Validator_multiple_validator_attributes = "Multiple validator attributes are not currently supported. The property '{0}' has more than one validator attribute associated with it.";
	public const string Validator_timespan_value_must_be_positive = "The time span value must be positive.";
	public const string WrongType_of_Protected_provider = "The type specified does not extend ProtectedConfigurationProvider class.";
	public const string Config_element_locking_not_supported = "Locking of elements or attributes within a configuration section is not supported for legacy section '{0}'.";
	public const string Protection_provider_syntax_error = "A section using 'configProtectionProvider' may contain no other attributes.";
	public const string Protection_provider_invalid_format = "The configProtectionProvider attribute cannot be an empty string.";
	public const string Cannot_declare_or_remove_implicit_section = "The section '{0}' is a built-in section.  It cannot be declared by the user.";
	public const string Config_reserved_attribute = "The attribute '{0}' cannot be specified because its name starts with the reserved prefix 'config' or 'lock'.";
	public const string Filename_in_SaveAs_is_used_already = "The file name '{0}' is invalid because the same file name is already referenced by the configuration hierarchy you have opened.";
	public const string Provider_Already_Initialized = "This provider instance has already been initialized.";
	public const string Config_provider_name_null_or_empty = "Provider name cannot be null or empty.";
	public const string CollectionReadOnly = "Collection is read-only.";
	public const string Config_source_not_under_config_dir = "The configSource '{0}' is invalid. It must refer to a file in the same directory or in a subdirectory as the configuration file.";
	public const string Config_source_invalid = "The configSource attribute is invalid.";
	public const string Location_invalid_inheritInChildApplications_in_machine_or_root_web_config = "InheritInChildApplications cannot be set to \"false\" if the location path is referring to machine.config or the root web.config.";
	public const string Cannot_change_both_AllowOverride_and_OverrideMode = "Changing both AllowOverride and OverrideMode is not supported for compatibility reasons. Please use only one or the other.";
	public const string Config_section_override_mode_attribute_invalid = "The 'overrideMode' and 'overrideModeDefault' attributes must be one of the following values: Inherited, Allow, Deny.";
	public const string Invalid_override_mode_declaration = "A <location> tag may contain only one of the 'allowOverride' or 'overrideMode' attributes.";
	public const string Machine_config_file_not_found = "The machine.config file '{0}' was not found.";
	public const string ObjectDisposed_StreamClosed = "Cannot access a closed Stream.";
	public const string Unable_to_convert_type_from_string = "Could not find a type-converter to convert object if type '{0}' from string.";
	public const string Unable_to_convert_type_to_string = "Could not find a type-converter to convert object if type '{0}' to string.";
	public const string Could_not_create_from_default_value = "The property '{0}' could not be created from it's default value. Error message: {1}";
	public const string Could_not_create_from_default_value_2 = "The property '{0}' could not be created from it's default value because the default value is of a different type.";
	public const string UserSettingsNotSupported = "The current configuration system does not support user-scoped settings.";
	public const string SettingsSaveFailed = "Failed to save settings: {0}";
	public const string SettingsSaveFailedNoSection = "Failed to save settings: unable to access the configuration section.";
	public const string UnknownUserLevel = "Unknown ConfigurationUserLevel specified.";
	public const string BothScopeAttributes = "The setting {0} has both an ApplicationScopedSettingAttribute and a UserScopedSettingAttribute.";
	public const string NoScopeAttributes = "The setting {0} does not have either an ApplicationScopedSettingAttribute or UserScopedSettingAttribute.";
	public const string SettingsPropertyNotFound = "The settings property '{0}' was not found.";
	public const string SettingsPropertyReadOnly = "The settings property '{0}' is read-only.";
	public const string SettingsPropertyWrongType = "The settings property '{0}' is of a non-compatible type.";
	public const string ProviderInstantiationFailed = "Failed to instantiate provider: {0}.";
	public const string ProviderTypeLoadFailed = "Failed to load provider type: {0}.";
	public const string AppSettingsReaderNoKey = "The key '{0}' does not exist in the appSettings configuration section.";
	public const string AppSettingsReaderCantParse = "The value '{0}' was found in the appSettings configuration section for key '{1}', and this value is not a valid {2}.";
	public const string AppSettingsReaderEmptyString = "(empty string)";
	public const string Config_invalid_integer_attribute = "The '{0}' attribute must be set to an integer value.";
	public const string Config_base_required_attribute_empty = "Required attribute '{0}' cannot be empty.";
	public const string Config_base_elements_only = "Only elements allowed.";
	public const string Config_base_no_child_nodes = "Child nodes not allowed.";
	public const string InvalidNullEmptyArgument = "Argument {0} cannot be null or zero-length.";
	public const string DuplicateFileName = "The file name '{0}' was already in the collection.";
}

