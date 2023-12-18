import { Serializer as ОтчетОСервереSerializer } from
  '../mixins/regenerated/serializers/i-i-s-12345-отчет-о-сервере';
import __ApplicationSerializer from './application';

export default __ApplicationSerializer.extend(ОтчетОСервереSerializer, {
  /**
  * Field name where object identifier is kept.
  */
  primaryKey: '__PrimaryKey'
});
