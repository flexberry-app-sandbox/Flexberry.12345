import Controller from '@ember/controller';
import { computed } from '@ember/object';

export default Controller.extend({
  sitemap: computed('i18n.locale', function () {
    let i18n = this.get('i18n');

    return {
      nodes: [
        {
          link: 'index',
          icon: 'home',
          caption: i18n.t('forms.application.sitemap.index.caption'),
          title: i18n.t('forms.application.sitemap.index.title'),
          children: null
        }, {
          link: null,
          icon: 'list',
          caption: i18n.t('forms.application.sitemap.12345.caption'),
          title: i18n.t('forms.application.sitemap.12345.title'),
          children: [{
            link: 'i-i-s-12345-сотрудник-l',
            caption: i18n.t('forms.application.sitemap.12345.i-i-s-12345-сотрудник-l.caption'),
            title: i18n.t('forms.application.sitemap.12345.i-i-s-12345-сотрудник-l.title'),
            icon: 'briefcase',
            children: null
          }, {
            link: 'i-i-s-12345-должность-l',
            caption: i18n.t('forms.application.sitemap.12345.i-i-s-12345-должность-l.caption'),
            title: i18n.t('forms.application.sitemap.12345.i-i-s-12345-должность-l.title'),
            icon: 'book',
            children: null
          }, {
            link: 'i-i-s-12345-сенсоры-l',
            caption: i18n.t('forms.application.sitemap.12345.i-i-s-12345-сенсоры-l.caption'),
            title: i18n.t('forms.application.sitemap.12345.i-i-s-12345-сенсоры-l.title'),
            icon: 'tags',
            children: null
          }, {
            link: 'i-i-s-12345-отчет-о-сервере-l',
            caption: i18n.t('forms.application.sitemap.12345.i-i-s-12345-отчет-о-сервере-l.caption'),
            title: i18n.t('forms.application.sitemap.12345.i-i-s-12345-отчет-о-сервере-l.title'),
            icon: 'address card',
            children: null
          }, {
            link: 'i-i-s-12345-серверная-l',
            caption: i18n.t('forms.application.sitemap.12345.i-i-s-12345-серверная-l.caption'),
            title: i18n.t('forms.application.sitemap.12345.i-i-s-12345-серверная-l.title'),
            icon: 'phone',
            children: null
          }, {
            link: 'i-i-s-12345-расположение-l',
            caption: i18n.t('forms.application.sitemap.12345.i-i-s-12345-расположение-l.caption'),
            title: i18n.t('forms.application.sitemap.12345.i-i-s-12345-расположение-l.title'),
            icon: 'chart bar',
            children: null
          }]
        }
      ]
    };
  }),
})