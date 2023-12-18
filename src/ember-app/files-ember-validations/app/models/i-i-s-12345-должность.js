import {
  defineNamespace,
  defineProjections,
  Model as ДолжностьMixin
} from '../mixins/regenerated/models/i-i-s-12345-должность';

import EmberFlexberryDataModel from 'ember-flexberry-data/models/model';

let Model = EmberFlexberryDataModel.extend(ДолжностьMixin, {
});

defineNamespace(Model);
defineProjections(Model);

export default Model;
