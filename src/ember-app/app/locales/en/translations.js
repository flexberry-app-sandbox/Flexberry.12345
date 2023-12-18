import $ from 'jquery';
import EmberFlexberryTranslations from 'ember-flexberry/locales/en/translations';

import IIS12345ДолжностьLForm from './forms/i-i-s-12345-должность-l';
import IIS12345ОтчетОСервереLForm from './forms/i-i-s-12345-отчет-о-сервере-l';
import IIS12345РасположениеLForm from './forms/i-i-s-12345-расположение-l';
import IIS12345СенсорыLForm from './forms/i-i-s-12345-сенсоры-l';
import IIS12345СервернаяLForm from './forms/i-i-s-12345-серверная-l';
import IIS12345СотрудникLForm from './forms/i-i-s-12345-сотрудник-l';
import IIS12345ДолжностьEForm from './forms/i-i-s-12345-должность-e';
import IIS12345ОтчетОСервереEForm from './forms/i-i-s-12345-отчет-о-сервере-e';
import IIS12345РасположениеEForm from './forms/i-i-s-12345-расположение-e';
import IIS12345СенсорыEForm from './forms/i-i-s-12345-сенсоры-e';
import IIS12345СервернаяEForm from './forms/i-i-s-12345-серверная-e';
import IIS12345СотрудникEForm from './forms/i-i-s-12345-сотрудник-e';
import IIS12345ДолжностьModel from './models/i-i-s-12345-должность';
import IIS12345КонтроллерModel from './models/i-i-s-12345-контроллер';
import IIS12345ОтчетОСервереModel from './models/i-i-s-12345-отчет-о-сервере';
import IIS12345РасположениеModel from './models/i-i-s-12345-расположение';
import IIS12345СенсорыModel from './models/i-i-s-12345-сенсоры';
import IIS12345СервернаяModel from './models/i-i-s-12345-серверная';
import IIS12345СотрудникModel from './models/i-i-s-12345-сотрудник';

const translations = {};
$.extend(true, translations, EmberFlexberryTranslations);

$.extend(true, translations, {
  models: {
    'i-i-s-12345-должность': IIS12345ДолжностьModel,
    'i-i-s-12345-контроллер': IIS12345КонтроллерModel,
    'i-i-s-12345-отчет-о-сервере': IIS12345ОтчетОСервереModel,
    'i-i-s-12345-расположение': IIS12345РасположениеModel,
    'i-i-s-12345-сенсоры': IIS12345СенсорыModel,
    'i-i-s-12345-серверная': IIS12345СервернаяModel,
    'i-i-s-12345-сотрудник': IIS12345СотрудникModel
  },

  'application-name': '12345',

  forms: {
    loading: {
      'spinner-caption': 'Loading stuff, please wait for a moment...'
    },
    index: {
      greeting: 'Welcome to ember-flexberry test stand!'
    },

    application: {
      header: {
        menu: {
          'sitemap-button': {
            title: 'Menu'
          },
          'user-settings-service-checkbox': {
            caption: 'Use service to save user settings'
          },
          'show-menu': {
            caption: 'Show menu'
          },
          'hide-menu': {
            caption: 'Hide menu'
          },
          'language-dropdown': {
            caption: 'Application language',
            placeholder: 'Choose language'
          }
        },
        login: {
          caption: 'Login'
        },
        logout: {
          caption: 'Logout'
        }
      },

      footer: {
        'application-name': '12345',
        'application-version': {
          caption: 'Addon version {{version}}',
          title: 'It is version of ember-flexberry addon, which uses in this dummy application ' +
          '(npm version + commit sha). ' +
          'Click to open commit on GitHub.'
        }
      },

      sitemap: {
        'application-name': {
          caption: '12345',
          title: '12345'
        },
        'application-version': {
          caption: 'Addon version {{version}}',
          title: 'It is version of ember-flexberry addon, which uses in this dummy application ' +
          '(npm version + commit sha). ' +
          'Click to open commit on GitHub.'
        },
        index: {
          caption: 'Home',
          title: ''
        },
        12345: {
          caption: '12345',
          title: '12345',
          'i-i-s-12345-сотрудник-l': {
            caption: 'Сотрудник',
            title: ''
          },
          'i-i-s-12345-должность-l': {
            caption: 'Должность',
            title: ''
          },
          'i-i-s-12345-сенсоры-l': {
            caption: 'Сенсоры',
            title: ''
          },
          'i-i-s-12345-отчет-о-сервере-l': {
            caption: 'Отчет о сервере',
            title: ''
          },
          'i-i-s-12345-серверная-l': {
            caption: 'Серверная',
            title: ''
          },
          'i-i-s-12345-расположение-l': {
            caption: 'Расположение',
            title: ''
          }
        }
      }
    },

    'edit-form': {
      'save-success-message-caption': 'Save operation succeed',
      'save-success-message': 'Object saved',
      'save-error-message-caption': 'Save operation failed',
      'delete-success-message-caption': 'Delete operation succeed',
      'delete-success-message': 'Object deleted',
      'delete-error-message-caption': 'Delete operation failed'
    },
    'i-i-s-12345-должность-l': IIS12345ДолжностьLForm,
    'i-i-s-12345-отчет-о-сервере-l': IIS12345ОтчетОСервереLForm,
    'i-i-s-12345-расположение-l': IIS12345РасположениеLForm,
    'i-i-s-12345-сенсоры-l': IIS12345СенсорыLForm,
    'i-i-s-12345-серверная-l': IIS12345СервернаяLForm,
    'i-i-s-12345-сотрудник-l': IIS12345СотрудникLForm,
    'i-i-s-12345-должность-e': IIS12345ДолжностьEForm,
    'i-i-s-12345-отчет-о-сервере-e': IIS12345ОтчетОСервереEForm,
    'i-i-s-12345-расположение-e': IIS12345РасположениеEForm,
    'i-i-s-12345-сенсоры-e': IIS12345СенсорыEForm,
    'i-i-s-12345-серверная-e': IIS12345СервернаяEForm,
    'i-i-s-12345-сотрудник-e': IIS12345СотрудникEForm
  },

});

export default translations;
